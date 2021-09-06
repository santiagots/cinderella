using Common.Core.Enum;

namespace Factura.Core.Enum
{
    public class AfipFacturacionElectronicaConstantes
    {
        //TODO:TOMAR DESDE Settings.vb PARA OBTENER ESTOS VALORS DESDE CONFIGURACION
        public static int PUNTO_VENTA = 1;
        public static int CONCEPTO = 1; //PRODUCTOS
        public static long CUIT_FACTURACION;
        public static CondicionIVA CONDICION_IVA_VENDEDOR = CondicionIVA.Responsable_Inscripto;

        public static string NOMBRE_SERVICIO = "wsfe";

        //TIPOS COMPROBANTE
        public static int FACTURA_A = 1;
        public static int NOTA_CREDITO_A = 3;
        public static int FACTURA_B = 6;
        public static int NOTA_CREDITO_B = 8;
        public static int FACTURA_C = 11;
        public static int NOTA_CREDITO_C = 13;

        //TIPO DOCUMENTO
        public static int CUIT = 80;
        public static int CUIL = 86;
        public static int DNI = 96;

        //TIPO IVA
        public static int IVA = 5; //21%

        //TIPO MONEDA 
        public static string PESOS = "PES";

        //TIPO MONEDA COTIZACION
        public static int PESOS_COTIZACION = 1;

        //TIPO RESULTADO
        public static string APROBADO = "A";
        public static string RECHAZADO = "R";
        public static string PARCIAL = "P";

        public static string COMPROBANTE_AUTORIZADO_POR_CAE = "E";
    }
}
