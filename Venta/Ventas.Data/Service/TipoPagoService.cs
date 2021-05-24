using Common.Core.Enum;
using Common.Core.Exceptions;
using System.Collections.Generic;

namespace Ventas.Data.Service
{
    public class TipoPagoService
    {
        public static List<TipoPago> Obtener(TipoCliente tipoCliente)
        {
            switch (tipoCliente)
            {
                case TipoCliente.Minorista:
                    return new List<TipoPago>() { TipoPago.Efectivo, TipoPago.TarjetaCrédito, TipoPago.TarjetaDébito };
                case TipoCliente.Mayorista:
                    return new List<TipoPago>() { TipoPago.Efectivo, TipoPago.Cheque, TipoPago.Deposito, TipoPago.CuentaCorriente };
                default:
                    throw new NegocioException($"No se pudo obtener un tipo de pago para el tipo de cliente {tipoCliente}");
            }
        }

        public static List<TipoPago> Obtener()
        {
            return new List<TipoPago>() { TipoPago.Efectivo, TipoPago.TarjetaCrédito, TipoPago.TarjetaDébito, TipoPago.Cheque, TipoPago.Deposito };
        }
    }
}
