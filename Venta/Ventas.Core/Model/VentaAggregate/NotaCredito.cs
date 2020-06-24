using Common.Core.Enum;
using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Core.Model.VentaAggregate
{
    public class NotaCredito: DocumentoFiscal
    {
        public virtual List<NumeroNotaCredito> NumeroNotaCredito { get; protected set; }
        public long IdVenta { get; protected set; }
        public virtual Venta Venta { get; protected set; }

        protected NotaCredito()
        {
        }

        public NotaCredito(long idVenta, int puntoVenta, TipoFactura tipoFactura, CondicionIVA condicionIVA, string nombreYApellido, string direccion, string localidad, string cuit, decimal subTotal, decimal iva, decimal total, IEnumerable<int> numeroFactura, string cae, DateTime? fechaVencimientoCae)
            : base(idVenta, puntoVenta, tipoFactura, condicionIVA, nombreYApellido, direccion, localidad, cuit, cae, fechaVencimientoCae, subTotal, iva, total)
        {
            IdVenta = idVenta;
            NumeroNotaCredito = numeroFactura.Select(x => new NumeroNotaCredito(x, this.Id)).ToList();
        }
    }
}
