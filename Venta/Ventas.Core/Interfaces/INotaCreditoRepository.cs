using System;
using System.Collections.Generic;
using Common.Core.Enum;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Interfaces
{
    public interface INotaCreditoRepository
    {
        void Guardar(NotaCredito notaCredito);
        NotaCredito Obtener(long id);
        object Buscar(int idSucursal, int? numeroNotaCredito, decimal? montoDesde, decimal? montoHasta, string nombre, int? cuit, DateTime? fechaDesde, DateTime? fechaHasta, List<TipoFactura> tiposFacturas);
    }
}
