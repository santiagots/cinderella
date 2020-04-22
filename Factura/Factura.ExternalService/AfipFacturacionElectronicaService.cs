using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using Common.Core.Enum;
using Factura.ExternalService.Contracts;
using Common.Core.Exceptions;
using Common.Core.Constants;
using Factura.Core.Model.AfipAgreggate;
using Newtonsoft.Json;
using System.Reflection;
using Common.Core.Helper;

namespace Factura.ExternalService
{
    public class AfipFacturacionElectronicaService
    {
        //TODO:TOMAR DESDE Settings.vb PARA OBTENER ESTOS VALORS DESDE CONFIGURACION
        public static int PUNTO_VENTA = 1;
        public static int CONCEPTO = 1; //PRODUCTOS
        public static long CUIT_FACTURACION;
        public static CondicionIVA CONDICION_IVA = CondicionIVA.Responsable_Inscripto;

        private static string NOMBRE_SERVICIO = "wsfe";

        //TIPOS COMPROBANTE
        private static int FACTURA_A = 1;
        private static int NOTA_CREDITO_A = 3;
        private static int FACTURA_B = 6;
        private static int NOTA_CREDITO_B = 8;
        private static int FACTURA_C = 11;
        private static int NOTA_CREDITO_C = 13;

        //TIPO DOCUMENTO
        private static int CUIT = 80;
        private static int CUIL = 86;
        private static int DNI = 96;

        //TIPO IVA
        public static int IVA = 5; //21%

        //TIPO MONEDA 
        private static string PESOS = "PES";

        //TIPO MONEDA COTIZACION
        private static int PESOS_COTIZACION = 1;

        //TIPO RESULTADO
        private static string APROBADO = "A";
        private static string RECHAZADO = "R";
        private static string PARCIAL = "P";

        public static AfipObtenerCAEResponse ObtenerCEA(AfipObtenerCAERequest request)
        {
            Afip.Wsfev1.ServiceSoapClient serviceClient = new Afip.Wsfev1.ServiceSoapClient();

            Afip.Wsfev1.DummyResponse dummyResponse = serviceClient.FEDummy();

            Afip.Wsfev1.FECAERequest feCAERequest = new Afip.Wsfev1.FECAERequest()
            {
                FeCabReq = ObtenerCabecera(1, request.CondicionIVA, request.TipoDocumentoFiscal),
                FeDetReq = new Afip.Wsfev1.FECAEDetRequest[] { ObtenerDetalle(request) }
            };

            string feCAERequestString = JsonConvert.SerializeObject(feCAERequest);

            Afip.Wsfev1.FECAEResponse feCAEResponse = serviceClient.FECAESolicitar(ObtenerAuth(request.PasswordCertificado, request.RutaCertificado), feCAERequest);

            string feCAEResponseString = JsonConvert.SerializeObject(feCAEResponse);

            VerificarErrorEnRespuesta(feCAEResponse.Errors);
            VerificarObservacionesEnRespuesta(feCAEResponse);

            return new AfipObtenerCAEResponse()
            {
                NumeroComprobante = (int)feCAEResponse.FeDetResp.First().CbteDesde,
                Codigo = feCAEResponse.FeDetResp.First().CAE,
                FechaVencimiento = DateTime.ParseExact(feCAEResponse.FeDetResp.First().CAEFchVto, "yyyyMMdd", CultureInfo.InvariantCulture)
            };
        }

        private static Afip.Wsfev1.FEAuthRequest ObtenerAuth(string passwordCertificado, string rutaCertificado)
        {
            AfipTokenAcces afipTokenAcces = AfipTokenAccesService.Obtener(NOMBRE_SERVICIO, rutaCertificado, passwordCertificado);

            return new Afip.Wsfev1.FEAuthRequest()
            {
                Cuit = CUIT_FACTURACION,
                Sign = afipTokenAcces.Firma,
                Token = afipTokenAcces.Token
            };
        }

        private static Afip.Wsfev1.FECAECabRequest ObtenerCabecera(int cantidadRegistros, CondicionIVA condicionIVA, TipoDocumentoFiscal tipoDocumentoFiscal)
            => new Afip.Wsfev1.FECAECabRequest()
            {
                CantReg = cantidadRegistros,
                CbteTipo = ObtenerTipoComprobante(condicionIVA, tipoDocumentoFiscal),
                PtoVta = PUNTO_VENTA
            };

        private static Afip.Wsfev1.FECAEDetRequest ObtenerDetalle(AfipObtenerCAERequest CAErequest)
        {
            Afip.Wsfev1.FECAEDetRequest request = new Afip.Wsfev1.FECAEDetRequest();

            request.Concepto = CONCEPTO;
            request.DocTipo = ObtenerTipoDocumento(CAErequest.CondicionIVA);
            request.DocNro = long.Parse(CAErequest.Cuit);
            request.CbteDesde = ObtenerNumeroComprobante(CAErequest.CondicionIVA, CAErequest.TipoDocumentoFiscal, CAErequest.PasswordCertificado, CAErequest.RutaCertificado);
            request.CbteHasta = request.CbteDesde;
            request.CbteFch = DateTime.Now.ToString("yyyyMMdd");
            request.MonId = PESOS;
            request.MonCotiz = PESOS_COTIZACION;
            request.ImpTotConc = 0;                                             //Importe total no grabado
            request.ImpNeto = (double)Monto.Redondeo(CAErequest.ImporteNeto);   //Importe total neto
            request.ImpOpEx = 0;                                                //Importe total excento
            request.ImpTrib = 0;                                                //Importe total tributo

            AgregarAlicutaIva(CAErequest.AlicuotasIva, request);

            request.ImpTotal = request.ImpTotConc + request.ImpNeto + request.ImpOpEx + request.ImpIVA + request.ImpTrib;

            return request;
        }

        private static void AgregarAlicutaIva(List<AfipAlicuotaIvaRequest> alicuotaIva, Afip.Wsfev1.FECAEDetRequest request)
        {
            if (CONDICION_IVA == CondicionIVA.Monotributo)
            {
                request.ImpIVA = 0;
            }
            else
            {
                request.Iva = alicuotaIva.Select(x => new Afip.Wsfev1.AlicIva()
                {
                    Id = x.Codigo,
                    BaseImp = (double)Monto.Redondeo(x.Monto),
                    Importe = (double)Monto.Redondeo(x.IvaMonto)
                }).ToArray();

                request.ImpIVA = request.Iva.Sum(x => x.Importe);
            }
        }

        private static int ObtenerNumeroComprobante(CondicionIVA condicionesIVA, TipoDocumentoFiscal tipoDocumentoFiscal, string passwordCertificado, string rutaCertificado)
        {
            try
            {
                Afip.Wsfev1.ServiceSoapClient serviceClient = new Afip.Wsfev1.ServiceSoapClient();
                Afip.Wsfev1.FERecuperaLastCbteResponse response = serviceClient.FECompUltimoAutorizado(ObtenerAuth(passwordCertificado, rutaCertificado),
                                                                                                        PUNTO_VENTA,
                                                                                                        ObtenerTipoComprobante(condicionesIVA, tipoDocumentoFiscal));
                VerificarErrorEnRespuesta(response.Errors);

                return response.CbteNro + 1;
            }
            catch (Exception ex)
            {
                throw new NegocioException($"Error al realizar la facturación. No se pudo obtener el numero de factura.", ex);
            }
        }

        private static int ObtenerTipoComprobante(CondicionIVA condicionIVA, TipoDocumentoFiscal tipoDocumentoFiscal)
        {
            if (CONDICION_IVA == CondicionIVA.Monotributo)
            {
                switch (tipoDocumentoFiscal)
                {
                    case TipoDocumentoFiscal.Factura:
                        return FACTURA_C;
                        
                    case TipoDocumentoFiscal.NotaCredito:
                        return NOTA_CREDITO_C;
                    default:
                        throw new NegocioException($"Error al realizar la facturación. No se ha podido determinar un tipo de comprobante para el documento fiscal {tipoDocumentoFiscal}.");
                };
            }
            else
            {
                switch (condicionIVA)
                {
                    case CondicionIVA.Responsable_Inscripto when tipoDocumentoFiscal == TipoDocumentoFiscal.Factura:
                        return FACTURA_A;
                    case CondicionIVA.Responsable_Inscripto when tipoDocumentoFiscal == TipoDocumentoFiscal.NotaCredito:
                        return NOTA_CREDITO_A;
                    case CondicionIVA.Consumidor_Final when tipoDocumentoFiscal == TipoDocumentoFiscal.Factura:
                    case CondicionIVA.Monotributo when tipoDocumentoFiscal == TipoDocumentoFiscal.Factura:
                    case CondicionIVA.Exento when tipoDocumentoFiscal == TipoDocumentoFiscal.Factura:
                        return FACTURA_B;
                    case CondicionIVA.Consumidor_Final when tipoDocumentoFiscal == TipoDocumentoFiscal.NotaCredito:
                    case CondicionIVA.Monotributo when tipoDocumentoFiscal == TipoDocumentoFiscal.NotaCredito:
                    case CondicionIVA.Exento when tipoDocumentoFiscal == TipoDocumentoFiscal.NotaCredito:
                        return NOTA_CREDITO_B;
                    default:
                        throw new NegocioException($"Error al realizar la facturación. No se ha podido determinar un tipo de comprobante para el tipo de cliente {condicionIVA} y documento fiscal {tipoDocumentoFiscal}.");
                };
            }
        }

        private static int ObtenerTipoDocumento(CondicionIVA condicionesIVA)
        {
            switch (condicionesIVA)
            {
                case CondicionIVA.Consumidor_Final:
                    return DNI;
                default:
                    return CUIT;
            };
        }

        private static void VerificarErrorEnRespuesta(Afip.Wsfev1.Err[] error)
        {
            if (error != null)
                throw new NegocioException($"{string.Join("\n", error.Select(x =>$"{x.Code} {x.Msg}"))}");
        }

        private static void VerificarObservacionesEnRespuesta(Afip.Wsfev1.FECAEResponse CaeResponse)
        {
            List<string> errores = new List<string>();
            if (CaeResponse.FeCabResp.Resultado != APROBADO && CaeResponse.FeDetResp.Any(x => x.Observaciones.Any()))
            {
                CaeResponse.FeDetResp.ToList().ForEach(x => errores.AddRange(x.Observaciones.Select(y => $"{y.Code}: {y.Msg}")));
                throw new NegocioException(string.Join("\n", errores));
            }
        }
    }
}
