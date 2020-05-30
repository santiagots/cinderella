using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using Ventas.Core.Model.BaseAgreggate;
using Ventas.Core.Model.ValueObjects;

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
            Pagos = new Dictionary<Pago, decimal>();
        }

        internal VentaItem(long idVenta, Producto producto, decimal monto, int cantidad, bool esDevolucion, decimal porcentajeBonificacion, decimal porcentajeFacturacion, TipoCliente tipoCliente, decimal montoProductoMinorista, decimal porcentajeBonificacionMinorista, decimal montoProductoMayorista, decimal porcentajeBonificacionMayorista) : base(true)
        {
            Pagos = new Dictionary<Pago, decimal>();
            IdVenta = idVenta;
            IdProducto = producto.Id;
            Producto = producto;
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
                MontoPago montoPago = ObtenerMontoPago(pago.MontoRestante,  porcentajeRecargo, porcentajeFacturacion, tipoCliente, pago.TipoPago);
                pago.ActualizarIva(pago.MontoPago.IVA + montoPago.IVA);
                pago.ActualizarDescuento(pago.MontoPago.Descuento + montoPago.Descuento);
                PorcentajePago += Math.Round(pago.MontoRestante / Total.Valor, 4, MidpointRounding.AwayFromZero);
                ActualizarPagos(pago, 0, pago.MontoRestante);
                return 0;
            }
            else
            {
                MontoPago montoPago = ObtenerMontoPago(pendientePago, porcentajeRecargo ,porcentajeFacturacion, tipoCliente, pago.TipoPago);
                pago.ActualizarIva(pago.MontoPago.IVA + montoPago.IVA);
                pago.ActualizarDescuento(pago.MontoPago.Descuento + montoPago.Descuento);
                PorcentajePago += Math.Round(pendientePago / Total.Valor, 4, MidpointRounding.AwayFromZero);
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
            decimal montoIva = 0;

            if (tipoCliente == TipoCliente.Mayorista)
                montoIva = (monto - decuento + cft) * Producto.SubCategoria.IVA.Valor * porcentajeFacturacion;

            return new MontoPago(monto, decuento, cft, montoIva);
        }

        internal MontoProducto PendientePago()
        {
            return Total * (1 - PorcentajePago);
        }

        internal MontoProducto TotalPago()
        {
            return Total * PorcentajePago;
        }

        public decimal TotalMonto(decimal porcentajeFacturacion, TipoCliente tipoCliente, CondicionIVA condicionIva)
        {
            IEnumerable<Pago> pagos = ObtenerPagosDeProducto(porcentajeFacturacion, tipoCliente);
            decimal monto = pagos.Sum(x => x.MontoPago.Monto);
            return CalcularMontoSegunCondicionIva(porcentajeFacturacion, condicionIva, tipoCliente, monto);
        }

        public decimal TotalDescuento(decimal porcentajeFacturacion, TipoCliente tipoCliente, CondicionIVA condicionIva)
        {
            IEnumerable<Pago> pagos = ObtenerPagosDeProducto(porcentajeFacturacion, tipoCliente);
            decimal descuento = pagos.Sum(x => x.MontoPago.Descuento);
            return CalcularMontoSegunCondicionIva(porcentajeFacturacion, condicionIva, tipoCliente, descuento);
        }
        public decimal TotalCFT(decimal porcentajeFacturacion, TipoCliente tipoCliente, CondicionIVA condicionIva)
        {
            IEnumerable<Pago> pagos = ObtenerPagosDeProducto(porcentajeFacturacion, tipoCliente);
            decimal cft = pagos.Sum(x => x.MontoPago.CFT);
            return CalcularMontoSegunCondicionIva(porcentajeFacturacion, condicionIva, tipoCliente, cft);
        }

        private decimal CalcularMontoSegunCondicionIva(decimal porcentajeFacturacion, CondicionIVA condicionIva, TipoCliente tipoCliente, decimal monto)
        {

            if (tipoCliente == TipoCliente.Minorista)
               return CalcularMontoSegunCondicionIvaMinorista(porcentajeFacturacion, condicionIva, monto);
            else
               return CalcularMontoSegunCondicionIvaMayorista(porcentajeFacturacion, condicionIva, monto);
        }

        private decimal CalcularMontoSegunCondicionIvaMinorista(decimal porcentajeFacturacion, CondicionIVA condicionIva, decimal monto)
        {
            //A los Responsable Inscripto hay que quitarle el iva dado que los montos que manejan tiene IVA
            switch (condicionIva)
            {
                case CondicionIVA.Consumidor_Final:
                case CondicionIVA.Monotributo:
                case CondicionIVA.Exento:
                    return monto * porcentajeFacturacion;
                case CondicionIVA.Responsable_Inscripto:
                    decimal montoSinIva = Monto.ObtenerSinIVA(monto, this.Producto.SubCategoria.IVA.Valor, porcentajeFacturacion);
                    return montoSinIva;
                default:
                    throw new InvalidOperationException($"Error al realizar la facturación. Condición IVA no reconocido {condicionIva.ToString()}");
            }
        }

        private decimal CalcularMontoSegunCondicionIvaMayorista(decimal porcentajeFacturacion, CondicionIVA condicionIva, decimal monto)
        {
            //A los Excentos y Monotibutistas hay que agregarle el iva dado que los montos que manejan no tiene IVA 
            switch (condicionIva)
            {
                case CondicionIVA.Responsable_Inscripto:
                    return monto * porcentajeFacturacion;
                case CondicionIVA.Monotributo:
                case CondicionIVA.Exento:
                    decimal montoConIva = Monto.ObtenerConIVA(monto, this.Producto.SubCategoria.IVA.Valor, porcentajeFacturacion);
                    return montoConIva;
                default:
                    throw new InvalidOperationException($"Error al realizar la facturación. Condición IVA no reconocido {condicionIva.ToString()}");
            }
        }

        internal decimal CalcularSubtotal(decimal total, decimal porcentajeRecargo, TipoCliente tipoCliente)
        {
            decimal totalSinIva = total;

            if (tipoCliente == TipoCliente.Mayorista)
                totalSinIva = Monto.ObtenerSinIVA(total, this.Producto.SubCategoria.IVA.Valor);
            
            decimal SubTotal = totalSinIva / (1 - PorcentajeBonificacion + porcentajeRecargo);

            return SubTotal;
        }

        internal void ActualizarPorcentajePago()
        {
            if (Total.Valor == 0)
                PorcentajePago = 0;
            else
                PorcentajePago = Math.Round(Pagos.Sum(x => x.Value) / Total.Valor, 4, MidpointRounding.AwayFromZero);
        }

        internal IEnumerable<Pago> ObtenerPagosDeProducto(decimal porcentajeFacturacion, TipoCliente tipoCliente)
        {
            List<Pago> pagos = new List<Pago>();

            foreach (KeyValuePair<Pago, decimal> montoPorPago in this.Pagos)
            {
                MontoPago montoPago = ObtenerMontoPago(montoPorPago.Value, montoPorPago.Key.PorcentajeRecargo, porcentajeFacturacion, tipoCliente, montoPorPago.Key.TipoPago);
                pagos.Add(new Pago(montoPorPago.Key.IdVenta, montoPorPago.Key.TipoPago, montoPorPago.Key.Tarjeta, montoPorPago.Key.NumeroCuotas, montoPorPago.Key.PorcentajeRecargo, montoPago.Monto, 0, montoPago.Descuento, montoPago.CFT, montoPago.IVA));
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
