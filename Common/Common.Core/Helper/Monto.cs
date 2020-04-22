using System;

namespace Common.Core.Helper
{
    public class Monto
    {
        public static decimal Redondeo(decimal monto)
        {
            return Math.Round(monto, 2, MidpointRounding.ToEven);
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
