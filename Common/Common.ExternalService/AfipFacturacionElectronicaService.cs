using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.ValueObjects;
using Common.ExternalService.Contracts;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using Common.Core.Constants;
using Common.Core.Model;

namespace Common.ExternalService
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

        public static AfipCAEResponse ObtenerCEA(TipoCliente tipoCliente, TipoDocumentoFiscal tipoDocumentoFiscal, CondicionIVA condicionesIVA, decimal TotalNeto, string cuit)
        {

            Afip.Wsfev1.FECAERequest request = new Afip.Wsfev1.FECAERequest()
            {
                FeCabReq = ObtenerCabecera(1, tipoCliente, tipoDocumentoFiscal),
                FeDetReq = new Afip.Wsfev1.FECAEDetRequest[] { ObtenerDetalle(tipoCliente, tipoDocumentoFiscal, condicionesIVA, TotalNeto, cuit) }
            };
            Afip.Wsfev1.ServiceSoapClient serviceClient = new Afip.Wsfev1.ServiceSoapClient();

            Afip.Wsfev1.FECAEResponse response = serviceClient.FECAESolicitar(ObtenerAuth(), request);

            VerificarErrorEnRespuesta(response.Errors);

            return new AfipCAEResponse()
            {
                NumeroComprobante = (int)response.FeDetResp.First().CbteDesde,
                Codigo = response.FeDetResp.First().CAE,
                FechaVencimiento = DateTime.ParseExact(response.FeDetResp.First().CAEFchVto, "yyyyMMdd", CultureInfo.InvariantCulture)
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

        private static Afip.Wsfev1.FECAEDetRequest ObtenerDetalle(TipoCliente tipoCliente, TipoDocumentoFiscal tipoDocumentoFiscal, CondicionIVA condicionesIVA, decimal TotalNeto, string cuit)
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
            request.ImpNeto = (double)TotalNeto;    //Importe total neto
            request.ImpOpEx = 0;                    //Importe total excento

            AgregarAlicutaIva(TotalNeto, request);
            AgregarTributo(TotalNeto, request);

            request.ImpTotal = (double)Math.Round(request.ImpTotConc + request.ImpNeto + request.ImpOpEx + request.ImpIVA + request.ImpTrib, 1);

            return request;
        }

        private static void AgregarAlicutaIva(decimal TotalNeto, Afip.Wsfev1.FECAEDetRequest request)
        {
            if (CONDICION_IVA == CondicionIVA.Monotributo)
            {
                request.ImpIVA = 0;
            }
            else
            {
                request.Iva = new Afip.Wsfev1.AlicIva[] {new Afip.Wsfev1.AlicIva() {
                                                                Id = IVA,
                                                                BaseImp = (double)TotalNeto,
                                                                Importe = (double)Math.Round((TotalNeto * Constants.IVA),1) }};

                request.ImpIVA = request.Iva.First().Importe;
            }
        }

        private static void AgregarTributo(decimal TotalNeto, Afip.Wsfev1.FECAEDetRequest request)
        {
            request.ImpTrib = 0;
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
                throw new NegocioException($"{string.Join("\n", error.Select(x => x.Msg))}");
        }

        private static void VerificarObservacionesEnRespuesta(Afip.Wsfev1.FECAEResponse CaeResponse)
        {
            if (CaeResponse.FeCabResp.Resultado != APROBADO && CaeResponse.FeDetResp.Any(x => x.Observaciones.Any()))

                throw new NegocioException($"{string.Join("\n", CaeResponse.FeDetResp.Select(x => x.Observaciones.Select(y => $"{y.Code}: {y.Msg}")))}");
        }
    }
}
