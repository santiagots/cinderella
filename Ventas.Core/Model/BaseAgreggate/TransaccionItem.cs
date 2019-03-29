using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.BaseAgreggate
{
    public abstract class TransaccionItem : Entity<long>
    {
        public string CodigoProducto { get; internal set; }
        public string NombreProducto { get; internal set; }
        public MontoProducto MontoProducto { get; internal set; }
        public int Cantidad { get; internal set; }
        public MontoProducto Total { get { return MontoProducto * Cantidad; } }
        public decimal PorcentajeBonificacion { get; internal set; }
        public DateTime FechaEdicion { get; internal set; }

        internal TransaccionItem() : base()
        { }

        public TransaccionItem(bool GenerarId) : base(GenerarId)
        { }
    }
}
