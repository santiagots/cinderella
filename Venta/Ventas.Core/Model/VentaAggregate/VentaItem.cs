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
        public bool EsDevolucion { get; private set; }
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

        internal VentaItem(long idVenta, string codigoProducto, string nombreProducto, decimal monto, int cantidad, bool esDevolucion, decimal porcentajeBonificacion, decimal porcentajeFacturacion, TipoCliente tipoCliente, decimal montoProductoMinorista, decimal porcentajeBonificacionMinorista, decimal montoProductoMayorista, decimal porcentajeBonificacionMayorista) : base(true)
        {
            Pagos = new Dictionary<Pago, decimal>();
            IdVenta = idVenta;
            CodigoProducto = codigoProducto;
            NombreProducto = nombreProducto;
            MontoProducto = ObtenerMontoProducto(monto, porcentajeFacturacion, tipoCliente);
            PorcentajeBonificacion = porcentajeBonificacion;
            PorcentajePago = 0;
            Cantidad = cantidad;
            EsDevolucion = esDevolucion;
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
                MontoPago montoPago = ObtenerMontoPago(pago.MontoRestante, porcentajeRecargo, porcentajeFacturacion, tipoCliente, pago.TipoPago);
                pago.ActualizarIva(pago.MontoPago.IVA + montoPago.IVA);
                pago.ActualizarDescuento(pago.MontoPago.Descuento + montoPago.Descuento);
                PorcentajePago += Math.Round(pago.MontoRestante / Total.Valor, 4);
                ActualizarPagos(pago, 0, pago.MontoRestante);
                return 0;
            }
            else
            {
                MontoPago montoPago = ObtenerMontoPago(pendientePago, porcentajeRecargo ,porcentajeFacturacion, tipoCliente, pago.TipoPago);
                pago.ActualizarIva(pago.MontoPago.IVA + montoPago.IVA);
                pago.ActualizarDescuento(pago.MontoPago.Descuento + montoPago.Descuento);
                PorcentajePago += Math.Round(pendientePago / Total.Valor, 4);
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

        internal MontoPago ObtenerMontoPagoPendiente(decimal porcentajeRecargo, decimal porcentajeFacturacion, TipoCliente tipoCliente, TipoPago formaPago)
        {
            MontoProducto montoProductoPendientePago = PendientePago();
            return ObtenerMontoPago(montoProductoPendientePago.Valor, porcentajeRecargo, porcentajeFacturacion, tipoCliente, formaPago);
        }

        internal MontoPago ObtenerMontoPago(decimal monto, decimal porcentajeRecargo, decimal porcentajeFacturacion, TipoCliente tipoCliente, TipoPago formaPago)
        {
            if(formaPago == TipoPago.Bonificacion)
                return new MontoPago(0, monto, 0, 0);

            //Si el porcentaje de recargo es mayor a cero no se tiene que hacer descuento
            decimal porcentajeBonificacion;
            if (!AplicarBonificacion(formaPago))
                porcentajeBonificacion = 0;
            else
                porcentajeBonificacion = PorcentajeBonificacion;

            decimal decuento = monto * porcentajeBonificacion;
            decimal cft = monto * porcentajeRecargo;
            decimal iva = 0;

            if (tipoCliente == TipoCliente.Mayorista)
                iva = Math.Round((monto - decuento + cft) * Constants.IVA * porcentajeFacturacion, 1);

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
            return Math.Round((total / (1 + Constants.IVA)) / (1 - PorcentajeBonificacion + porcentajeRecargo), 1);
        }

        internal void ActualizarPorcentajePago()
        {
            if (Total.Valor == 0)
                PorcentajePago = 0;
            else
                PorcentajePago = Math.Round(Pagos.Sum(x => x.Value) / Total.Valor, 4);
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

        private bool AplicarBonificacion(TipoPago formaPago)
        {
            return formaPago == TipoPago.Efectivo || EsDevolucion;
        }

    }
}
