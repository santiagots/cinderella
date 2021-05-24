using Common.Core.Enum;
using Common.Core.Model;
using System;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Core.Model.CuentaCorrienteAggregate
{
    public class Movimiento : Entity<long>
    {
        public int IdClienteMayorista { get; internal set; }
        public int IdSucursal { get; internal set; }
        public Sucursal Sucursal { get; set; }
        public DateTime Fecha { get; internal set; }
        public TipoAccionCuentaCorriente TipoAccionCuentaCorriente { get; internal set; }
        public TipoMovimientoCuentaCorriente TipoMovimientoCuentaCorriente { get; internal set; }
        public string NumeroComprobante { get; internal set; }
        public long IdComprobante { get; internal set; }
        public decimal Monto { get; internal set; }
        public decimal Saldo { get; internal set; }

        internal Movimiento()
        {
        }

        public Movimiento(int idSucursal, int idClienteMayorista, decimal monto, decimal saldo, TipoMovimientoCuentaCorriente tipoMovimientoCuentaCorriente, TipoAccionCuentaCorriente tipoAccionCuentaCorriente,  string numeroComprobante, long idComprobante) : base(true)
        {
            IdSucursal = idSucursal;
            IdClienteMayorista = idClienteMayorista;
            Monto = tipoAccionCuentaCorriente == TipoAccionCuentaCorriente.Crédito? monto: -monto;
            Saldo = saldo;
            TipoMovimientoCuentaCorriente = tipoMovimientoCuentaCorriente;
            TipoAccionCuentaCorriente = tipoAccionCuentaCorriente;
            NumeroComprobante = numeroComprobante;
            IdComprobante = idComprobante;
            Fecha = DateTime.Now;
        }
    }
}