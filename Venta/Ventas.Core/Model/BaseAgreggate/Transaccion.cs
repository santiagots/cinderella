using Common.Core.Enum;
using Common.Core.Model;
using System;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.BaseAgreggate
{
    public abstract class Transaccion : Entity<long>
    {
        public TipoCliente TipoCliente { get; internal set; }
        public int IdSucursal { get; internal set; }
        public virtual Sucursal Sucursal { get; internal set; }
        public int IdEncargado { get; internal set; }
        public virtual Empleado Encargado { get; internal set; }
        public int IdVendedor { get; internal set; }
        public virtual Empleado Vendedor { get; internal set; }
        public decimal PorcentajeFacturacion { get; internal set; }
        public int? IdClienteMayorista { get; internal set; }
        public ClienteMayorista ClienteMayorista { get; protected set; }
        public DateTime Fecha { get; internal set; }
        public DateTime FechaEdicion { get; internal set; }
        public MontoProducto MontoTotal { get; internal set; } = new MontoProducto(0, 0);

        internal Transaccion() : base()
        {
        }

        public Transaccion(bool GenerarId) : base(GenerarId)
        {
        }
    }
}
