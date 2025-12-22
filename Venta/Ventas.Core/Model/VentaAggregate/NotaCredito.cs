using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Core.Model.VentaAggregate
{
    public class NotaCredito: DocumentoFiscal
    {
        public virtual List<NumeroNotaCredito> NumeroNotaCredito { get; protected set; }
        public virtual List<PercepcionNotaCredito> Percepciones { get; protected set; }
        public long IdVenta { get; protected set; }
        public virtual Venta Venta { get; protected set; }

        protected NotaCredito()
        {
        }

        public NotaCredito(long idVenta, int puntoVenta, TipoFactura tipoFactura, CondicionIVA condicionIVA, string nombreYApellido, string direccion, string localidad, string provincia, string cuit, decimal subTotal, decimal iva, decimal total, IEnumerable<int> numeroFactura, string cae, DateTime? fechaVencimientoCae)
            : base(idVenta, puntoVenta, tipoFactura, condicionIVA, nombreYApellido, direccion, localidad, provincia, cuit, cae, fechaVencimientoCae, subTotal, iva, total)
        {
            IdVenta = idVenta;
            NumeroNotaCredito = numeroFactura.Select(x => new NumeroNotaCredito(x, this.Id)).ToList();
        }

        internal void AgregarPersepciones(List<Percepcion> persepciones)
        {
            Percepciones = new List<PercepcionNotaCredito>();
            foreach (var persepcion in persepciones)
            {
                Percepciones.Add(new PercepcionNotaCredito(Id, persepcion.Tipo, persepcion.Comcepto, persepcion.Alicuota, persepcion.Monto));
            }
        }
    }
}
