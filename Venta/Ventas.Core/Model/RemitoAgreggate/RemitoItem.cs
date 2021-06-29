using Common.Core.Model;
using Ventas.Core.Model.ValueObjects;
using Common.Core.Enum;
using System;

namespace Ventas.Core.Model.RemitoAgreggate
{
    public class RemitoItem : Entity<long>
    {
        public string Codigo { get; private set; }
        public string Nombre { get; private set; }
        public int Cantidad { get; private set; }
        public MontoProducto Monto { get; internal set; } = new MontoProducto(0, 0);
        public MontoProducto Total => Monto * Cantidad;
        public DateTime FechaEdicion { get; protected set; }
        public long IdRemito { get; private set; }
        public Remito Remito { get; set; }

        internal RemitoItem() { }

        public RemitoItem(string codigo, string nombre, int cantidad, MontoProducto montoTotal) : base(true)
        {
            Codigo = codigo;
            Nombre = nombre;
            Cantidad = cantidad;
            Monto = montoTotal;
            FechaEdicion = DateTime.Now;
            EstadoEntidad = EstadoEntidad.Nuevo;
        }

        public RemitoItem(long id, long idRemito, string codigo, string nombre, int cantidad, MontoProducto montoTotal) : this(codigo, nombre, cantidad, montoTotal)
        {
            Id = id;
            IdRemito = idRemito;
            EstadoEntidad = EstadoEntidad.Modificado;
        }
    }
}
