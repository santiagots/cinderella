using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.ValueObjects;
using Common.ExternalService.Contracts;
using System;
using System.Collections.Generic;

namespace Common.ExternalService
{
    public class AfipFacturacionElectronicaService
    {
        //TODO:TOMAR DESDE Settings.vb PARA OBTENER ESTOS VALORS DESDE CONFIGURACION
        public static int PUNTO_VENTA = 1;
        public static int CONCEPTO = 1;
        public static long CUIT_FACTURACION = 20303932640;
        public static string PASSWORD_CERTIFICADO = "cinderella";
        public static string RUTA_CERTIFICADO = "c:\\cinderella.p12";

        internal static string NOMBRE_SERVICIO = "wsfe";

        //TIPOS COMPROBANTE
        internal static int FACTURA_A = 1;
        internal static int NOTA_CREDITO_A = 3;
        internal static int FACTURA_B = 7;
        internal static int NOTA_CREDITO_B = 8;
        internal static int FACTURA_C = 11;
        internal static int NOTA_CREDITO_C = 13;

        //TIPO DOCUMENTO
        internal static int CUIT = 80;
        internal static int CUIL = 86;
        internal static int DNI = 96;

        //TIPO MONEDA 
        internal static string PESOS = "PES";

        //TIPO MONEDA COTIZACION
        internal static int PESOS_COTIZACION = 1;

        public AfipFacturacionElectronicaService(string firma, string token)
        {
        }

        public static void ObtenerCEA(TipoCliente tipoCliente, TipoDocumentoFiscal tipoDocumentoFiscal, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
        {
            
        }

        private static Afip.Wsfev1.FEAuthRequest ObtenerAuth()
        {
            AfipTokenAcceso afipTokenAcceso = AfipTokenAccesoService.Obtener(NOMBRE_SERVICIO, RUTA_CERTIFICADO, PASSWORD_CERTIFICADO);

            return new Afip.Wsfev1.FEAuthRequest()
            {
                Cuit = CUIT_FACTURACION,
                Sign = afipTokenAcceso.Firma,
                Token = afipTokenAcceso.Firma
            };
        }

        private static Afip.Wsfev1.FECAECabRequest ObtenerCabecera(int cantidadRegistros, TipoCliente tipoCliente, TipoDocumentoFiscal tipoDocumentoFiscal)
            => new Afip.Wsfev1.FECAECabRequest()
               {
                    CantReg = cantidadRegistros,
                    CbteTipo = ObtenerTipoComprobante(tipoCliente, tipoDocumentoFiscal),
                    PtoVta = PUNTO_VENTA
               };

        private static Afip.Wsfev1.FECAEDetRequest ObtenerDetalle(TipoCliente tipoCliente, TipoDocumentoFiscal tipoDocumentoFiscal, CondicionIVA condicionesIVA, long cuit)
        {
            Afip.Wsfev1.FECAEDetRequest request = new Afip.Wsfev1.FECAEDetRequest();

            request.Concepto = CONCEPTO;
            request.DocTipo = ObtenerTipoDocumento(condicionesIVA);
            request.DocNro = cuit;
            request.CbteDesde = ObtenerNumeroComprobante(tipoCliente, tipoDocumentoFiscal);
            request.CbteHasta = request.CbteDesde;
            request.CbteFch = DateTime.Now.ToString("yyyyMMdd");
            request.MonId = PESOS;
            request.MonCotiz = PESOS_COTIZACION;
            request.ImpTotConc = 0; //Importe total no grabado
            request.ImpNeto = 
        }

        private static int ObtenerNumeroComprobante(TipoCliente tipoCliente, TipoDocumentoFiscal tipoDocumentoFiscal)
        {
            Afip.Wsfev1.ServiceSoapClient serviceClient = new Afip.Wsfev1.ServiceSoapClient();
            Afip.Wsfev1.FERecuperaLastCbteResponse response = serviceClient.FECompUltimoAutorizado(ObtenerAuth(),
                                                                                                    PUNTO_VENTA,
                                                                                                    ObtenerTipoComprobante(tipoCliente, tipoDocumentoFiscal);
            return response.CbteNro + 1;
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
                    throw new NegocioException($"No se ha podido determinar un tipo de comprobante para el tipo de cliente {tipoCliente} y documento fiscal {tipoDocumentoFiscal}.");
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
    }
}
