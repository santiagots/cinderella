using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Model;
using System;
using System.Linq;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.BaseAgreggate
{
    public abstract class Pago : Entity<long>
    {
        private static char Delimitador = ';';

        public TipoPago TipoPago { get; internal set; }
        public MontoPago MontoPago { get; internal set; }
        public decimal MontoRestante { get; internal set; }
        public string Tarjeta { get; internal set; }
        public int NumeroCuotas { get; internal set; }
        public decimal PorcentajeRecargo { get; internal set; }
        public string NumeroOrdenChequesData { get; internal set; }
        public int? IdCuentaBancaria { get; internal set; }
        public CuentaBancaria CuentaBancaria { get; internal set; }
        public int[] NumeroOrdenCheques
        {
            get { return !string.IsNullOrWhiteSpace(NumeroOrdenChequesData) ? NumeroOrdenChequesData.Split(Delimitador).Select(x => int.Parse(x)).ToArray() : null; }
            set
            {
                NumeroOrdenChequesData = value != null ? string.Join($"{Delimitador}", value): "";
            }
        }
        public DateTime FechaEdicion { get; internal set; }
        public bool Habilitado { get; internal set; }

        protected Pago()
        {
        }

        public Pago(TipoPago tipoPago, string tarjeta, int numeroCuotas, decimal porcentajeRecargo, int[] numeroOrdenCheques, CuentaBancaria cuentaBancaria, decimal monto, decimal montoRestante, decimal descuento, decimal cft, decimal iva, bool habilitado = true) : base(true)
        {
            if ((tipoPago == TipoPago.TarjetaCrédito || tipoPago == TipoPago.TarjetaDébito) && string.IsNullOrEmpty(tarjeta))
                throw new NegocioException("Error al crear el pago. La trajeta no puede ser vacia.");

            if (tipoPago == TipoPago.TarjetaCrédito && numeroCuotas == 0)
                throw new NegocioException("Error al crear el pago. La cantidad de cuotas debe ser mayor a cero.");

            TipoPago = tipoPago;
            PorcentajeRecargo = porcentajeRecargo;
            MontoPago = new MontoPago(monto, descuento, cft, iva);
            Tarjeta = tarjeta;
            NumeroCuotas = numeroCuotas;
            NumeroOrdenCheques = numeroOrdenCheques;
            FechaEdicion = DateTime.Now;
            MontoRestante = montoRestante;
            Habilitado = habilitado;

            if (tipoPago == TipoPago.Deposito)
            {
                IdCuentaBancaria = cuentaBancaria.Id;
                CuentaBancaria = cuentaBancaria;
            }
        }

        public override string ToString()
        {
            string formaPago;
            switch (TipoPago)
            {
                case TipoPago.Efectivo:
                    formaPago = "Efectivo";
                    break;
                case TipoPago.TarjetaCrédito:
                    formaPago = $"{Tarjeta} ({NumeroCuotas})";
                    break;
                case TipoPago.TarjetaDébito:
                    formaPago = $"{Tarjeta}";
                    break;
                case TipoPago.Cheque:
                    formaPago = $"Cheque ({NumeroOrdenChequesData})";
                    break;
                case TipoPago.Deposito:
                    formaPago = $"Deposito  {CuentaBancaria.NumeroCuenta}";
                    break;
                case TipoPago.Bonificacion:
                    formaPago = "Bonificación";
                    break;
                case TipoPago.CuentaCorriente:
                    formaPago = "Cuenta Corriente";
                    break;
                default:
                    throw new InvalidOperationException($"La forma de pago {TipoPago.ToString()} no implementa el metodo ToString().");
            }

            return formaPago;
        }
    }
}
