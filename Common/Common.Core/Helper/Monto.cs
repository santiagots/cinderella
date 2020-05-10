using System;

namespace Common.Core.Helper
{
    public class Monto
    {
        public static decimal Redondeo(decimal monto, int decimales = 2)
        {
            return Math.Round(monto, decimales, MidpointRounding.ToEven);
        }

        public static decimal ObtenerSinIVA(decimal monto, decimal iva, decimal porcentajeFacturacion = 1)
        {
            return monto / (porcentajeFacturacion * (1 + iva));
        }

        public static decimal ObtenerConIVA(decimal monto, decimal iva, decimal porcentajeFacturacion = 1)
        {
            return monto * (porcentajeFacturacion * (1 + iva));
        }
    }
}
