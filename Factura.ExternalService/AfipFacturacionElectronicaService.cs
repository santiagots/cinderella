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

namespace Factura.ExternalService
{
    public class AfipFacturacionElectronicaService
    {
        //TODO:TOMAR DESDE Settings.vb PARA OBTENER ESTOS VALORS DESDE CONFIGURACION
        public static int PUNTO_VENTA = 1;
        public static int CONCEPTO = 1; //PRODUCTOS
        public static long CUIT_FACTURACION = 20303932640;
        public static string PASSWORD_CERTIFICADO = "cinderella";
        public static string RUTA_CERTIFICADO = "c:\\cinderella.p12";
        public static CondicionIVA CONDICION_IVA = CondicionIVA.Responsable_Inscripto;

        private static string NOMBRE_SERVICIO = "wsfe";

        //TIPOS COMPROBANTE
        private static int FACTURA_A = 1;
        private static int NOTA_CREDITO_A = 3;
        private static int FACTURA_B = 7;
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
                FeCabReq = ObtenerCabecera(1, request.TipoCliente, request.TipoDocumentoFiscal),
                FeDetReq = new Afip.Wsfev1.FECAEDetRequest[] { ObtenerDetalle(request.TipoCliente, request.TipoDocumentoFiscal, request.CondicionIVA, request.Cuit, request.ImporteNeto, request.AlicuotasIva) }
            };

            string feCAERequestString = JsonConvert.SerializeObject(feCAERequest);

            Afip.Wsfev1.FECAEResponse feCAEResponse = serviceClient.FECAESolicitar(ObtenerAuth(), feCAERequest);

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

        private static Afip.Wsfev1.FEAuthRequest ObtenerAuth()
        {
            AfipTokenAcces afipTokenAcces = AfipTokenAccesService.Obtener(NOMBRE_SERVICIO, RUTA_CERTIFICADO, PASSWORD_CERTIFICADO);

            return new Afip.Wsfev1.FEAuthRequest()
            {
                Cuit = CUIT_FACTURACION,
                Sign = afipTokenAcces.Firma,
                Token = afipTokenAcces.Token
            };
        }

        private static Afip.Wsfev1.FECAECabRequest ObtenerCabecera(int cantidadRegistros, TipoCliente tipoCliente, TipoDocumentoFiscal tipoDocumentoFiscal)
            => new Afip.Wsfev1.FECAECabRequest()
            {
                CantReg = cantidadRegistros,
                CbteTipo = ObtenerTipoComprobante(tipoCliente, tipoDocumentoFiscal),
                PtoVta = PUNTO_VENTA
            };

        private static Afip.Wsfev1.FECAEDetRequest ObtenerDetalle(TipoCliente tipoCliente, TipoDocumentoFiscal tipoDocumentoFiscal, CondicionIVA condicionesIVA, string cuit, decimal importeNeto, List<AfipAlicuotaIvaRequest> alicuotaIva)
        {
            Afip.Wsfev1.FECAEDetRequest request = new Afip.Wsfev1.FECAEDetRequest();

            request.Concepto = CONCEPTO;
            request.DocTipo = ObtenerTipoDocumento(condicionesIVA);
            request.DocNro = long.Parse(cuit);
            request.CbteDesde = ObtenerNumeroComprobante(tipoCliente, tipoDocumentoFiscal);
            request.CbteHasta = request.CbteDesde;
            request.CbteFch = DateTime.Now.ToString("yyyyMMdd");
            request.MonId = PESOS;
            request.MonCotiz = PESOS_COTIZACION;
            request.ImpTotConc = 0;                 //Importe total no grabado
            request.ImpNeto = (double)importeNeto;  //Importe total neto
            request.ImpOpEx = 0;                    //Importe total excento
            request.ImpTrib = 0;                    //Importe total tributo

            AgregarAlicutaIva(alicuotaIva, request);

            request.ImpTotal = Math.Round(request.ImpTotConc + request.ImpNeto + request.ImpOpEx + request.ImpIVA + request.ImpTrib, 2, MidpointRounding.AwayFromZero);

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
                    BaseImp = (double)x.Monto,
                    Importe = (double)x.IvaMonto
                }).ToArray();
                    
                request.ImpIVA = Math.Round(alicuotaIva.Sum(x => (double)x.IvaMonto), 2, MidpointRounding.AwayFromZero);
            }
        }

        private static int ObtenerNumeroComprobante(TipoCliente tipoCliente, TipoDocumentoFiscal tipoDocumentoFiscal)
        {
            try
            {
                Afip.Wsfev1.ServiceSoapClient serviceClient = new Afip.Wsfev1.ServiceSoapClient();
                Afip.Wsfev1.FERecuperaLastCbteResponse response = serviceClient.FECompUltimoAutorizado(ObtenerAuth(),
                                                                                                        PUNTO_VENTA,
                                                                                                        ObtenerTipoComprobante(tipoCliente, tipoDocumentoFiscal));
                VerificarErrorEnRespuesta(response.Errors);

                return response.CbteNro + 1;
            }
            catch (Exception ex)
            {
                throw new NegocioException($"Error al realizar la facturación. No se pudo obtener el numero de factura.", ex);
            }
        }

        private static int ObtenerTipoComprobante(TipoCliente tipoCliente, TipoDocumentoFiscal tipoDocumentoFiscal)
        {
            switch (tipoCliente)
            {
                case TipoCliente.Mayorista when tipoDocumentoFiscal == TipoDocumentoFiscal.Factura:
                    return FACTURA_A;
                case TipoCliente.Mayorista when tipoDocumentoFiscal == TipoDocumentoFiscal.NotaCredito:
                    return NOTA_CREDITO_A;
                case TipoCliente.Minorista when tipoDocumentoFiscal == TipoDocumentoFiscal.Factura:
                    return FACTURA_B;
                case TipoCliente.Minorista when tipoDocumentoFiscal == TipoDocumentoFiscal.NotaCredito:
                    return NOTA_CREDITO_B;
                default:
                    throw new NegocioException($"Error al realizar la facturación. No se ha podido determinar un tipo de comprobante para el tipo de cliente {tipoCliente} y documento fiscal {tipoDocumentoFiscal}.");
            };
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
