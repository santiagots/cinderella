using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Model;
using Common.Core.Helper;
using System.Collections.Generic;
using System.Linq;
using Ventas.Core.Model.ValueObjects;
using System;
using Ventas.Core.Model.BaseAgreggate;
using Ventas.Core.Model.ChequeAggregate;

namespace Ventas.Core.Model.VentaAggregate
{
    public class Venta: Transaccion
    {
        public string Numero { get; protected set; }
        public virtual List<Comision> Comisiones { get; protected set; }
        public virtual IList<Pago> Pagos { get; protected set; }
        public virtual IList<Cheque> Cheques { get; protected set; }
        public virtual IList<VentaItem> VentaItems { get; protected set; }
        public virtual NotaCredito NotaCredito { get; protected set; }
        public virtual Factura Factura { get; protected set; }
        public bool Anulado { get; protected set; }
        public string MotivoAnulado { get; protected set; }
        public DateTime? FechaAnulado { get; protected set; }
        public int CantidadTotal { get; private set; }
        public MontoPago PagoTotal { get; private set; }
        public bool EstaPaga { get { return !VentaItems.Any(x => x.PorcentajePago != 1); } }

        internal Venta()
        {
        }

        public Venta(int idSucursal) : base(true)
        {
            IdSucursal = idSucursal;
            VentaItems = new List<VentaItem>();
            Pagos = new List<Pago>();
            Cheques = new List<Cheque>();
            MontoTotal = new MontoProducto(0, 0);
            PagoTotal = new MontoPago(0, 0, 0, 0);
            Comisiones = new List<Comision>();
            Fecha = DateTime.Now;
            FechaEdicion = DateTime.Now;
            PorcentajeFacturacion = 1;
        }

        public void GenerarNumeroVenta(int cantidadVentas, string codigoVentaSucursal)
        {
            string facturada = Factura == null ? "N" : "S";
            Numero = $"{codigoVentaSucursal}{facturada}{Fecha.ToString("yyyyMMdd")}{cantidadVentas.ToString("D9")}";
        }

        public void Anular(string motivo)
        {
            if (Anulado)
                throw new NegocioException("Error al anular la venta. La venta ya se encuentra anulada.");

            if (string.IsNullOrWhiteSpace(motivo))
                throw new NegocioException("Error al anular la venta. Debe ingresar un motivo para anular una venta.");

            Anulado = true;
            MotivoAnulado = motivo;
            FechaAnulado = DateTime.Now;
        }

        public void AgregaVentaItem(Producto producto, decimal monto, int cantidad, bool esDevolucion, decimal porcentajeBonificacion, decimal porcentajeFacturacion, TipoCliente tipoCliente, decimal montoProductoMinorista, decimal porcentajeBonificacionMinorista, decimal montoProductoMayorista, decimal porcentajeBonificacionMayorista)
        {
            VentaItem ventaItem = VentaItems.FirstOrDefault(x => x.Producto.Codigo == producto.Codigo);

            if (ventaItem == null)
            {
                ventaItem = new VentaItem(Id, producto, monto, cantidad, esDevolucion, porcentajeBonificacion, porcentajeFacturacion, tipoCliente, montoProductoMinorista, porcentajeBonificacionMinorista, montoProductoMayorista, porcentajeBonificacionMayorista);
                VentaItems.Add(ventaItem);
            }
            else
            {
                ventaItem.ActualizarMontoProducto(monto, cantidad, porcentajeBonificacion, porcentajeFacturacion, tipoCliente);
            }

            OrdenarItemsVenta();

           ActualizarPagos();

           ActualizarTotalesPago();

           ActualizarTotalesVenta();
        }

        public void ActualizarVentaItem(string codigoProducto, decimal monto, int cantidad, decimal porcentajeBonificacion, decimal porcentajeFacturacion, TipoCliente tipoCliente)
        {
            if (porcentajeBonificacion > 1)
                porcentajeBonificacion = 1;

            VentaItem ventaItem = VentaItems.FirstOrDefault(x => x.Producto.Codigo == codigoProducto);

            ventaItem.ActualizarMontoProducto(monto, cantidad, porcentajeBonificacion, porcentajeFacturacion, tipoCliente);

            OrdenarItemsVenta();

            ActualizarPagos();

            ActualizarTotalesPago();

            ActualizarTotalesVenta();
        }

        public void ActualizarClienteMayorista(int idClienteMayorista)
        {
            IdClienteMayorista = idClienteMayorista;
        }

        public void ActualizarPorcentajeFacturacion(decimal porcentajeFacturacion)
        {
            PorcentajeFacturacion = porcentajeFacturacion;
        }

        public void AgregaPago(decimal monto, decimal descuento, decimal cft, decimal iva, TipoPago tipoPago, decimal porcentajeCft, decimal porcentajeFacturacion, TipoCliente tipoCliente, string trajeta, int numeroCuotas, bool habilitado = true)
        {
            if (VentaItems.Count == 0)
                throw new NegocioException("Error al registrar el pago. No se encuentran productos registrados en la venta.");
            if (EstaPaga)
                throw new NegocioException("Error al registrar el pago. La venta ya cuenta con el/los pagos necesarios para ser finalizada.");
            if(monto == 0 && descuento == 0 && cft == 0 && iva == 0)
                throw new NegocioException("Error al registrar el pago. El monto o el descuento o el CFT o el IVA debe ser mayor a cero.");

            Pago pago = new Pago(Id, tipoPago, trajeta, numeroCuotas, porcentajeCft, monto, monto, descuento, cft, iva, habilitado);

            if (pago.MontoPago.Total < 0)
                throw new NegocioException("Error al registrar el pago. El total debe ser mayor a cero.");

            Pagos.Add(pago);

            Pagos = Pagos.OrderBy(x => x.TipoPago).ToList();

            ActualizarPagos();

            ActualizarTotalesPago();
        }

        public void AgregarCheque(Cheque cheque)
        {
            Cheques.Add(cheque);
        }

        public void AgregarEncargado(Empleado encargado)
        {
            Encargado = encargado;
            IdEncargado = encargado != null? encargado.Id : 0;
        }

        public void AgregarVendedor(Empleado vendedor)
        {
            Vendedor = vendedor;
            IdVendedor = vendedor != null ? vendedor.Id : 0;
        }

        public void AgregarFactura(int puntoVenta, TipoFactura tipoFactura, CondicionIVA condicionesIVA, string nombreYApellido, string direccion, string localidad, string cuit, decimal monto, List<int> numeroFactura, string cae, DateTime? fechaVencimientoCae)
        {
            if (numeroFactura.Count == 0)
                throw new NegocioException($"Error al registrar la factura. Debe ingresar un número de factura.");
            if (tipoFactura == TipoFactura.Electronica && string.IsNullOrEmpty(cae))
                throw new NegocioException($"Error al registrar la factura. No se encuentra un Codigo CAE.");

            Factura = new Factura(Id, puntoVenta, tipoFactura, condicionesIVA, nombreYApellido, direccion, localidad, cuit, monto, numeroFactura, cae, fechaVencimientoCae);
        }

        public void AgregarNotaCredito(int puntoVenta, TipoFactura tipoFactura, CondicionIVA condicionesIVA, string nombreYApellido, string direccion, string localidad, string cuit, decimal monto, List<int> numeroNotaPedido, string cae, DateTime? fechaVencimientoCae)
        {
            if (numeroNotaPedido.Count == 0)
                throw new NegocioException($"Error al registrar la factura. Debe ingresar un número de factura.");
            if (tipoFactura == TipoFactura.Electronica && string.IsNullOrEmpty(cae))
                throw new NegocioException($"Error al registrar la factura. No se encuentra un Codigo CAE.");

            NotaCredito = new NotaCredito(Id, puntoVenta, tipoFactura, condicionesIVA, nombreYApellido, direccion, localidad, cuit, monto, numeroNotaPedido, cae, fechaVencimientoCae);
        }

        public void AgregarComision(Decimal porcentajeComisionEncargado, Decimal porcentajeComisionVendedor)
        {
            if (Encargado == null)
                throw new NegocioException($"Error al registrar la comision del encargado. No se cuentra un encargado en la venta.");

            if (Vendedor == null)
                throw new NegocioException($"Error al registrar la comision del vendedor. No se cuentra un vendedor en la venta.");

            Comisiones.Add(new Comision(IdEncargado, IdSucursal, Id, porcentajeComisionEncargado, PagoTotal.Total));
            Comisiones.Add(new Comision(IdVendedor, IdSucursal, Id, porcentajeComisionVendedor, PagoTotal.Total));
        }

        public void CorregirPago(long idPago)
        {
            Pago pago = Pagos.FirstOrDefault(x => x.Id == idPago);
            pago.Corregir();
            

            ActualizarTotalesPago();
        }

        public void QuitarPago(long idPago)
        {
            VentaItems.ToList().ForEach(x => x.QuitarPago(idPago));
            Pagos.Remove(Pagos.FirstOrDefault(x => x.Id == idPago));
            ActualizarTotalesPago();
        }

        public void QuitarPagos()
        {
            VentaItems.ToList().ForEach(x => x.QuitarPagos());
            Pagos.Clear();
            ActualizarTotalesPago();
        }

        public void QuitarVentaItem(string codigoProducto, decimal porcentajeFacturacion, TipoCliente tipoCliente)
        {
            VentaItem ventaItem = VentaItems.FirstOrDefault(x => x.Producto.Codigo == codigoProducto);

            if (ventaItem == null)
                throw new NegocioException($"Error al quitar el pago. El producto con código {codigoProducto} no se encuentra registrados en la venta.");

            VentaItems.Remove(ventaItem);

            OrdenarItemsVenta();

            ActualizarPagos();

            ActualizarTotalesPago();

            ActualizarTotalesVenta();
        }

        public void ModificarTipoCliente(TipoCliente tipoCliente)
        {
            TipoCliente = tipoCliente;
            QuitarPagos();
        }

        public int ObtenerCantidadDeUnidadesDeProducto(string codigoProducto)
        {
            VentaItem ventaItem = VentaItems.FirstOrDefault(x => x.Producto.Codigo == codigoProducto);
            if (ventaItem == null)
                return 0;
            else
                return ventaItem.Cantidad;
        }

        public MontoPago ObtenerPendienteMontoPago(decimal porcentajeCft, decimal porcentajeFacturacion, TipoCliente tipoCliente, TipoPago formaDePago)
        {
            if (EstaPaga || VentaItems.Count == 0)
                return new MontoPago(0, 0, 0, 0);

            return VentaItems.Select(x => x.ObtenerMontoPagoPendiente(porcentajeCft, porcentajeFacturacion, tipoCliente, formaDePago)).Aggregate((x, y) => x + y);
        }

        public MontoPago ObtenerMontoPagoDesdeSubtotal(decimal montoSubtotal, decimal porcentajeCft, decimal porcentajeFacturacion, TipoCliente tipoCliente, TipoPago formaDePago)
        {
            if (EstaPaga)
                return new MontoPago(0, 0, 0, 0);

            MontoPago montoPagoPendiente = new MontoPago(0, 0, 0, 0);

            foreach (VentaItem ventaItem in VentaItems)
            {
                MontoProducto montoProductoPendientePago = ventaItem.PendientePago();

                if (montoSubtotal >= montoProductoPendientePago.Valor)
                {
                    montoPagoPendiente += ventaItem.ObtenerMontoPagoPendiente(porcentajeCft, porcentajeFacturacion, tipoCliente, formaDePago);
                    montoSubtotal -= montoProductoPendientePago.Valor;
                }
                else
                {
                    montoPagoPendiente += ventaItem.ObtenerMontoPago(montoSubtotal, porcentajeCft, porcentajeFacturacion, tipoCliente, formaDePago);
                    montoSubtotal = 0;
                    break;
                }
            }

            return montoPagoPendiente;
        }

        public MontoPago ObtenerMontoPagoDesdeTotal(decimal montoTotal, decimal porcentajeCft, decimal porcentajeFacturacion, TipoCliente tipoCliente, TipoPago formaDePago)
        {
            if (EstaPaga)
                return new MontoPago(0, 0, 0, 0);

            decimal subtotal = CalcularSubtota(montoTotal, porcentajeCft);

            return ObtenerMontoPagoDesdeSubtotal(subtotal, porcentajeCft, porcentajeFacturacion, tipoCliente, formaDePago);
        }

        public decimal ObtenerMontoPorTipoDeCliente(string codigoProducto, TipoCliente tipoCliente)
        {
            VentaItem ventaItem = VentaItems.FirstOrDefault(x => x.Producto.Codigo == codigoProducto);
            if (ventaItem == null)
                throw new NegocioException($"Error al obtener el monto para el producto código {codigoProducto}. No se encuentran el producto en lo productos ingresado a vender.");
            else
                return ventaItem.ObtenerMontoPorTipoDeCliente(tipoCliente);
        }

        public decimal ObtenerPorcentajeBonificacionPorTipoDeCliente(string codigoProducto, TipoCliente tipoCliente)
        {
            VentaItem ventaItem = VentaItems.FirstOrDefault(x => x.Producto.Codigo == codigoProducto);
            if (ventaItem == null)
                throw new NegocioException($"Error al obtener el porcentaje bonificación para el producto código {codigoProducto}. No se encuentran el producto en lo productos ingresado a vender.");
            else
                return ventaItem.ObtenerPorcentajeBonificacionPorTipoDeCliente(tipoCliente);
        }

        public decimal ObtenerBonificacionPorListaDePrecion(string codigoProducto, TipoCliente tipoClienteSeleccionado)
        {
            VentaItem ventaItem = VentaItems.FirstOrDefault(x => x.Producto.Codigo == codigoProducto);
            if (ventaItem == null)
                return 0;
            else
                return ventaItem.Cantidad;
        }

        public IEnumerable<VentaItem> OrdenarItemsVenta()
        {
            IEnumerable<IGrouping<bool, VentaItem>> ventaItemGroup = VentaItems.GroupBy(x => x.Cantidad > 0);

            List<VentaItem> Ventas = ventaItemGroup.Where(x => x.Key == true).SelectMany(x => x).OrderByDescending(x => x.PorcentajeBonificacion).ThenBy(x => x.Cantidad).ThenBy(x => x.Producto.Codigo).ToList();
            List<VentaItem> Devoluciones = ventaItemGroup.Where(x => x.Key == false).SelectMany(x => x).OrderByDescending(x => x.PorcentajeBonificacion).ThenBy(x => x.Cantidad).ThenBy(x => x.Producto.Codigo).ToList();

            List<VentaItem> Aux = new List<VentaItem>(Devoluciones);
            Aux.AddRange(Ventas);

            VentaItems = Aux;

            return Aux;
        }

        private decimal CalcularSubtota(decimal montoTotal, decimal porcentajeCft)
        {
            decimal subtotal = 0;
            foreach (VentaItem ventaItem in VentaItems)
            {
                MontoProducto montoProductoPendientePago = ventaItem.PendientePago();
                decimal totalPendientePago = montoProductoPendientePago.toDecimal();
                if (montoTotal >= totalPendientePago)
                {
                    subtotal += ventaItem.CalcularSubtotal(totalPendientePago, porcentajeCft, TipoCliente);
                    montoTotal -= totalPendientePago;
                }
                else
                {
                    subtotal += ventaItem.CalcularSubtotal(montoTotal, porcentajeCft, TipoCliente);
                    montoTotal = 0;
                    break;
                }
            }

            return subtotal;
        }

        public void ActualizarPagos()
        {
            foreach (VentaItem ventaItems in VentaItems)
            {
                ventaItems.QuitarPagos();
            }

            foreach (Pago pago in Pagos)
            {
                pago.ActualizarMontoRestante(pago.MontoPago.Monto);
                pago.ActualizarIva(0);
                pago.ActualizarDescuento(0);

                foreach (VentaItem ventaItems in VentaItems.Where(x => x.PorcentajePago < 1))
                {
                    decimal montoRestante = ventaItems.AgregarPago(pago, pago.PorcentajeRecargo, PorcentajeFacturacion, TipoCliente);
                    ventaItems.ActualizarPorcentajePago();

                    if (montoRestante == 0)
                        break;
                }
            }
        }

        public void ActualizarTotalesVenta()
        {
            if (VentaItems.Count == 0)
            {
                CantidadTotal = 0;
                MontoTotal = new MontoProducto(0, 0);
            }
            else
            {
                CantidadTotal = VentaItems.Sum(x => x.Cantidad);
                MontoTotal = VentaItems.Select(x => x.MontoProducto * x.Cantidad).Aggregate((x, y) => x + y);
            }
        }

        public void ActualizarTotalesPago()
        {
            if (Pagos.Count == 0)
                PagoTotal = new MontoPago(0, 0, 0, 0);
            else
                PagoTotal = Pagos.Select(x => x.MontoPago).Aggregate((x, y) => x + y);

        }
    }
}
