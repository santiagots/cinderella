﻿using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Core.Model.VentaAggregate
{
    public class Factura: DocumentoFiscal
    {
        public virtual List<NumeroFactura> NumeroFactura { get; protected set; }
        public long IdVenta { get; protected set; }
        public virtual Venta Venta { get; protected set; }

        protected Factura()
        {
        }

        public Factura(long idVenta, int puntoVenta, TipoFactura tipoFactura, CondicionIVA condicionIVA, string nombreYApellido, string direccion, string localidad, string cuit, decimal subTotal, decimal iva, decimal total, IEnumerable<int> numeroFactura, string cae, DateTime? fechaVencimientoCae) 
            : base(idVenta, puntoVenta, tipoFactura, condicionIVA, nombreYApellido, direccion, localidad, cuit, cae, fechaVencimientoCae, subTotal, iva, total)
        {
            IdVenta = idVenta;
            NumeroFactura = numeroFactura.Select(x => new NumeroFactura(x, this.Id)).ToList();
        }
    }
}
