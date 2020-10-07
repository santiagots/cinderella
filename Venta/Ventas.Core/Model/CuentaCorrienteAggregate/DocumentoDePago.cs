using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using Ventas.Core.Model.BaseAgreggate;
using Ventas.Core.Model.ChequeAggregate;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.CuentaCorrienteAggregate
{
    public class DocumentoDePago : Transaccion
    {
        public string Numero { get; protected set; }
        public bool Anulado { get; protected set; }
        public string MotivoAnulado { get; protected set; }
        public DateTime? FechaAnulado { get; protected set; }
        public virtual List<DocumentoDePagoPago> Pagos { get; protected set; }
        public virtual List<Cheque> Cheques { get; protected set; }
        public MontoPago PagoTotal { get; private set; }

        internal DocumentoDePago()
        {
        }

        public DocumentoDePago(int idSucursal, int idClienteMayorista) : base(true)
        {
            IdSucursal = idSucursal;
            IdClienteMayorista = idClienteMayorista;
            Pagos = new List<DocumentoDePagoPago>();
            Cheques = new List<Cheque>();
            MontoTotal = new MontoProducto(0, 0);
            PagoTotal = new MontoPago(0, 0, 0, 0);
            Fecha = DateTime.Now;
            FechaEdicion = DateTime.Now;
            PorcentajeFacturacion = 1;
        }

        public void Anular(string motivo)
        {
            if (Anulado)
                throw new NegocioException("Error al anular el documento de pago. El documento de pago ya se encuentra anulada.");

            if (string.IsNullOrWhiteSpace(motivo))
                throw new NegocioException("Error al anular el documento de pago. Debe ingresar un motivo para anular un documento de pago.");

            Anulado = true;
            MotivoAnulado = motivo;
            FechaAnulado = DateTime.Now;
        }

        public void AgregaPago(decimal monto, decimal cft, TipoPago formaPagoSeleccionado, decimal cuotaCft, string tarjeta, int numeroCuota)
        {
            if (monto == 0 && cft == 0)
                throw new NegocioException("Error al registrar el pago. El monto o el CFT debe ser mayor a cero.");

            DocumentoDePagoPago pago = new DocumentoDePagoPago(Id, formaPagoSeleccionado, tarjeta, numeroCuota, cuotaCft, monto, cft);

            if (pago.MontoPago.Total < 0)
                throw new NegocioException("Error al registrar el pago. El total debe ser mayor a cero.");
            Pagos.Add(pago);
            ActualizarTotalesPago();
        }

        public void QuitarPago(long id)
        {
            Pagos.Remove(Pagos.FirstOrDefault(x => x.Id == id));
            ActualizarTotalesPago();
        }

        public void AgregarEncargado(Empleado encargado)
        {
            Encargado = encargado;
            IdEncargado = encargado != null ? encargado.Id : 0;
        }

        public void AgregarCheque(Cheque cheque)
        {
            Cheques.Add(cheque);
        }

        public void ActualizarTotalesPago()
        {
            if (Pagos.Count == 0)
                PagoTotal = new MontoPago(0, 0, 0, 0);
            else
                PagoTotal = Pagos.Select(x => x.MontoPago).Aggregate((x, y) => x + y);

        }

        public void GenerarNumero(int cantidadDocumentoDePago, string codigoVentaSucursal)
        {
            if(Pagos.Count == 0) throw new NegocioException("Error en generación de Numero de Documento de Pago. No se encuentran pagos registrados.");

            string digitoFormaPago = "M"; //Mixta
            if (Pagos.Count == 1)
                digitoFormaPago = Pagos.First().TipoPago.ToString().Substring(0, 1);

            Numero = $"{codigoVentaSucursal}{digitoFormaPago}{Fecha.ToString("yyyyMMdd")}{cantidadDocumentoDePago.ToString("D9")}";
        }

        public MontoPago ObtenerMontoPagoDesdeTotal(decimal total, decimal porcentajeCft)
        {
            decimal subtotal = total / (1 + porcentajeCft);
            return ObtenerMontoPagoDesdeSubtotal(subtotal, porcentajeCft);
        }

        public MontoPago ObtenerMontoPagoDesdeSubtotal(decimal subtotal, decimal porcentajeCft)
        {
            decimal cft = (subtotal) * porcentajeCft;
            return new MontoPago(subtotal, 0, cft, 0);
        }
    }
}
