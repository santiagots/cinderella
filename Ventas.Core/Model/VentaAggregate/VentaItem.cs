using System;
using Common.Core.Constants;
using Common.Core.Exceptions;
using Common.Core.Model;
using Ventas.Core.Model.ValueObjects;
using Common.Core.Enum;
using System.Collections.Generic;
using System.Linq;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Core.Model.VentaAggregate
{
    public class VentaItem : TransaccionItem
    {
        private MontoProducto MontoProductoMinorista;
        private decimal PorcentajeBonificacionMinorista;
        private MontoProducto MontoProductoMayorista;
        private decimal PorcentajeBonificacionMayorista;
        internal Dictionary<Pago, decimal> Pagos { get; private set; }
        public long IdVenta { get; private set; }
        public virtual Venta Venta { get; private set; }

        private decimal _PorcentajePago;
        public decimal PorcentajePago
        {
            get { return _PorcentajePago; }
            private set
            {
                if (value > 1 || value < 0)
                    throw new NegocioException("Error el porcentaje de pago debe ser mayor o igual a cero y menor o igual a uno.");
                _PorcentajePago = value;
            }
        }

        public VentaItem(): base()
        {
        }

        internal VentaItem(long idVenta, string codigoProducto, string nombreProducto, decimal monto, int cantidad, decimal porcentajeBonificacion, decimal porcentajeFacturacion, TipoCliente tipoCliente, decimal montoProductoMinorista, decimal porcentajeBonificacionMinorista, decimal montoProductoMayorista, decimal porcentajeBonificacionMayorista) : base(true)
        {
            Pagos = new Dictionary<Pago, decimal>();
            IdVenta = idVenta;
            CodigoProducto = codigoProducto;
            NombreProducto = nombreProducto;
            MontoProducto = ObtenerMontoProducto(monto, porcentajeFacturacion, tipoCliente);
            PorcentajeBonificacion = porcentajeBonificacion;
            PorcentajePago = 0;
            Cantidad = cantidad;
            FechaEdicion = DateTime.Now;

            MontoProductoMinorista = ObtenerMontoProducto(montoProductoMinorista, 1, TipoCliente.Minorista);
            PorcentajeBonificacionMinorista = porcentajeBonificacionMinorista;
            MontoProductoMayorista = ObtenerMontoProducto(montoProductoMayorista, 1, TipoCliente.Mayorista);
            PorcentajeBonificacionMayorista = porcentajeBonificacionMayorista;
        }

        internal decimal AgregarPago(Pago pago, decimal porcentajeRecargo, decimal porcentajeFacturacion, TipoCliente tipoCliente)
        {
            decimal pendientePago = 0;

            if (PorcentajePago == 0)
                pendientePago = Total.Valor;
            else
                pendientePago = PendientePago().Valor;

            if (pendientePago > pago.MontoRestante)
            {
                MontoPago montoPago = ObtenerMontoPago(pago.MontoRestante, porcentajeRecargo, porcentajeFacturacion, tipoCliente, pago);
                pago.ActualizarIva(pago.MontoPago.IVA + montoPago.IVA);
                pago.ActualizarDescuento(pago.MontoPago.Descuento + montoPago.Descuento);
                PorcentajePago += pago.MontoRestante / Total.Valor;
                ActualizarPagos(pago, 0, pago.MontoRestante);
                return 0;
            }
            else
            {
                MontoPago montoPago = ObtenerMontoPago(pendientePago, porcentajeRecargo ,porcentajeFacturacion, tipoCliente, pago);
                pago.ActualizarIva(pago.MontoPago.IVA + montoPago.IVA);
                pago.ActualizarDescuento(pago.MontoPago.Descuento + montoPago.Descuento);
                PorcentajePago += pendientePago / Total.Valor;
                ActualizarPagos(pago, pago.MontoRestante - pendientePago, pendientePago);
                return pago.MontoRestante;
            }
        }

        internal void QuitarPago(long id)
        {
            Pago pago = Pagos.FirstOrDefault(x => x.Key.Id == id).Key;
            if(pago != null)
                Pagos.Remove(pago);
            ActualizarPorcentajePago();
        }

        internal void QuitarPagos()
        {
            Pagos.Clear();
            ActualizarPorcentajePago();
        }

        internal void ActualizarMontoProducto(decimal monto, int cantidad, decimal porcentajeBonificacion, decimal porcentajeFacturacion, TipoCliente tipoCliente)
        {
            Cantidad = cantidad;
            PorcentajeBonificacion = porcentajeBonificacion;
            MontoProducto = ObtenerMontoProducto(monto, porcentajeFacturacion, tipoCliente);
        }

        //public Dictionary<Pago, decimal> ActualizarPago(decimal monto, List<Pago> pagos)
        //{




        //    Dictionary<Pago, decimal> pagosAux = new Dictionary<Pago, decimal>();
        //    decimal resto = monto * cantidad;

        //    foreach (KeyValuePair<Pago, decimal> pago in Pagos)
        //    {
        //        if (resto > pago.Key.MontoPago.Monto)
        //        {
        //            pagosAux.Add(pago.Key, pago.Key.MontoPago.Monto);
        //        }
        //        else
        //        {
        //            pagosAux.Add(pago.Key, resto);
        //            break;
        //        }
        //        resto = resto - pago.Key.MontoPago.Monto;
        //    }
        //    return pagosAux;
        //}

        internal decimal ObtenerMontoPorTipoDeCliente(TipoCliente tipoCliente)
        {
            if (tipoCliente == TipoCliente.Minorista)
                return MontoProductoMinorista.Valor;
            else
                return MontoProductoMayorista.Valor;
        }

        internal decimal ObtenerPorcentajeBonificacionPorTipoDeCliente(TipoCliente tipoCliente)
        {
            if (tipoCliente == TipoCliente.Minorista)
                return PorcentajeBonificacionMinorista;
            else
                return PorcentajeBonificacionMayorista;
        }

        internal MontoPago ObtenerMontoPagoPendiente(decimal porcentajeRecargo, decimal porcentajeFacturacion, TipoCliente tipoCliente, bool aplicarBonificacion)
        {
            MontoProducto montoProductoPendientePago = PendientePago();
            return ObtenerMontoPago(montoProductoPendientePago.Valor, porcentajeRecargo, porcentajeFacturacion, tipoCliente, aplicarBonificacion);
        }

        internal MontoPago ObtenerMontoPago(decimal monto, decimal porcentajeRecargo, decimal porcentajeFacturacion, TipoCliente tipoCliente, Pago pago)
        {
            return ObtenerMontoPago(monto, porcentajeRecargo, porcentajeFacturacion, tipoCliente, pago.TipoPago == TipoPago.Efectivo);
        }

        internal MontoPago ObtenerMontoPago(decimal monto, decimal porcentajeRecargo, decimal porcentajeFacturacion, TipoCliente tipoCliente, bool aplicarBonificacion)
        {
            //Si el porcentaje de recargo es mayor a cero no se tiene que hacer descuento
            decimal porcentajeBonificacion;
            if (porcentajeRecargo > 0 || !aplicarBonificacion)
                porcentajeBonificacion = 0;
            else
                porcentajeBonificacion = PorcentajeBonificacion;

            decimal decuento = monto * porcentajeBonificacion;
            decimal cft = monto * porcentajeRecargo;
            decimal iva = 0;

            if (tipoCliente == TipoCliente.Mayorista)
                iva = (monto - decuento + cft) * Constants.IVA * porcentajeFacturacion;

            return new MontoPago(monto, decuento, cft, iva);
        }


        internal MontoProducto PendientePago()
        {
            return Total * (1 - PorcentajePago);
        }

        internal MontoProducto TotalPago()
        {
            return Total * PorcentajePago;
        }

        internal decimal CalcularSubtotal(decimal total, decimal porcentajeRecargo)
        {
            return (total / (1 + Constants.IVA)) / (1 - PorcentajeBonificacion + porcentajeRecargo);
        }

        internal void ActualizarPorcentajePago()
        {
            PorcentajePago = Math.Round(Pagos.Sum(x => x.Value) / Total.Valor, 4);
        }

        private MontoProducto ObtenerMontoProducto(decimal monto, decimal porcentajeFacturacion, TipoCliente tipoCliente)
        {
            if (tipoCliente == TipoCliente.Minorista)
                return new MontoProducto(monto, 0);
            else
                return new MontoProducto(monto, monto * Constants.IVA * porcentajeFacturacion);
        }

        internal IEnumerable<Pago> ObtenerPagosDeProducto()
        {
            List<Pago> pagos = new List<Pago>();

            foreach (KeyValuePair<Pago, decimal> montoPorPago in this.Pagos)
            {
                Pago pago = montoPorPago.Key;
                pago.ActualizarMontoRestante(montoPorPago.Value);
                pagos.Add(pago);
            }

            return pagos;
        }

        private void ActualizarPagos(Pago pago, decimal resto, decimal abonado)
        {
            if (Pagos.ContainsKey(pago))
            {
                Pagos.Remove(pago);
                pago.ActualizarMontoRestante(resto);
                Pagos.Add(pago, abonado);
            }
            else
            {
                pago.ActualizarMontoRestante(resto);
                Pagos.Add(pago, abonado);
            }
        }
    }
}
