using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Model.CuentaCorrienteAggregate;

namespace Ventas.Core.Interfaces
{
    public interface IDocumentoDePagoRepository
    {
        Task GuardarAsync(DocumentoDePago documentoDePago);
        Task<List<DocumentoDePago>> BuscarAsync(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, TipoPago? tipoPago, TipoAccionDocumentoPago? tipoAccion);
        Task<int> CantidadAsync(int idSucursal);
        Task<DocumentoDePago> ObtenerAsync(long idDocumentoDePago);
        Task<decimal> ObtenerTotalAsync(int idSucursal, DateTime fecha, TipoPago? tipoPago);
        Task<decimal> ObtenerTotalAsync(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, TipoPago? tipoPago);
        Task ActualizarAsync(DocumentoDePago documentoDePago);
    }
}
