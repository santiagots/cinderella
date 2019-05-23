using Common.Core.Enum;
using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.VentaAggregate
{
    public class Factura: Entity<long>
    {
        public long IdVenta { get; protected set; }
        public TipoFactura TipoFactura { get; protected set; }
        public CondicionIVA CondicionIVA { get; protected set; }
        public string NombreYApellido { get; protected set; }
        public string Direccion { get; protected set; }
        public string Localidad { get; protected set; }
        public string CUIT { get; protected set; }
        public virtual List<NumeroFactura> NumeroFactura { get; protected set; }
        public virtual Venta Venta { get; protected set; }

        protected Factura()
        {
        }

        public Factura(long idVenta, TipoFactura tipoFactura, CondicionIVA condicionIVA, string nombreYApellido, string direccion, string localidad, string cuit, IEnumerable<int> numeroFactura) : base()
        {
            Id = idVenta;
            IdVenta = idVenta;
            TipoFactura = tipoFactura;
            CondicionIVA = condicionIVA;
            NombreYApellido = nombreYApellido;
            Direccion = direccion;
            Localidad = localidad;
            CUIT = cuit;
            NumeroFactura = numeroFactura.Select(x => new NumeroFactura(x, this.Id)).ToList();
        }
    }
}
