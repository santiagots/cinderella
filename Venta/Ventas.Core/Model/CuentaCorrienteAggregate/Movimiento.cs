using Common.Core.Enum;
using Common.Core.Model;
using System;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Core.Model.CuentaCorrienteAggregate
{
    public class Movimiento : Entity<long>
    {
        public int IdClienteMayorista { get; internal set; }
        public ClienteMayorista ClienteMayorista { get; set; }
        public int IdSucursal { get; internal set; }
        public Sucursal Sucursal { get; set; }
        public DateTime Fecha { get; internal set; }
        public TipoMovimientoCuentaCorriente TipoMovimientoCuentaCorriente { get; internal set; }
        public string NumeroComprobante { get; internal set; }
        public long IdComprobante { get; internal set; }
        public decimal Debito { get; internal set; }
        public decimal Credito { get; internal set; }
        public decimal Saldo { get; internal set; }

        internal Movimiento()
        {
        }

        public Movimiento(int idSucursal, int idClienteMayorista, TipoMovimientoCuentaCorriente tipoMovimientoCuentaCorriente, string numeroComprobante, long idComprobante, decimal saldo) : base(true)
        {
            IdSucursal = idSucursal;
            IdClienteMayorista = idClienteMayorista;
            TipoMovimientoCuentaCorriente = tipoMovimientoCuentaCorriente;
            NumeroComprobante = numeroComprobante;
            IdComprobante = idComprobante;
            Saldo = saldo;
            Fecha = DateTime.Now;
        }

        public void registrarDebito(decimal debito)
        {
            Debito = debito;
            Saldo -= debito;
        }

        public void registrarCredito(decimal credito)
        {
            Credito = credito;
            Saldo += credito;
        }
    }
}