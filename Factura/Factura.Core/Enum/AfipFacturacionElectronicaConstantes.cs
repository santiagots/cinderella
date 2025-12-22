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

        //TIPO CONDICION IVA
        public static int Responsable_Inscripto = 1;
        public static int Monotributo = 5;
        public static int Consumidor_Final = 4;
        public static int Exento = 3;

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

        //TIPO TRIBUTOS
        public static string IMPUESTOS_NACIONALES = "1";
        public static string IMPUESTOS_PROVINCIALES = "2";
        public static string IMPUESTOS_MUNICIPALES = "3";
        public static string IMPUESTOS_INTERNOS = "4";
        public static string OTRO = "99";
        public static string IIBB = "5";
        public static string PERCEPCION_IVA = "6";
        public static string PERCEPCION_IIBB = "7";
        public static string PERCEPCION_IMPUESTOS_MUNICIPALES = "8";
        public static string OTROS_PERCEPCIONES = "9";
        public static string PERCEPCION_IVA_NO_CATEGORICADA = "13";
    }
}
