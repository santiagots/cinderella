using Common.Core.Enum;
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
            return (monto / (1 + iva)) * porcentajeFacturacion;
        }

        public static decimal ObtenerConIVA(decimal monto, decimal iva, decimal porcentajeFacturacion = 1)
        {
            return (monto * (1 + iva)) * porcentajeFacturacion;
        }

        public static decimal ObtenerMontoSinIvaSegunTipoDeCliente(decimal monto, decimal iva, CondicionIVA condicionIVA)
        {
            switch (condicionIVA)
            {
                case CondicionIVA.Consumidor_Final:
                case CondicionIVA.Exento:
                    decimal montoSinIva = Monto.ObtenerSinIVA(monto, iva);
                    return montoSinIva;
                case CondicionIVA.Monotributo:
                case CondicionIVA.Responsable_Inscripto:
                    return monto;
                default:
                    throw new InvalidOperationException($"Error al realizar la facturación. Condición IVA no reconocido {condicionIVA.ToString()}");
            }
        }
    }
}
