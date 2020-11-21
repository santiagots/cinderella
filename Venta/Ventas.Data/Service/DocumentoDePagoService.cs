using Common.Core.Enum;
using System;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.CuentaCorrienteAggregate;
using Ventas.Data.Repository;

namespace Ventas.Data.Service
{
    public class DocumentoDePagoService
    {
        public static Task ActualizarAsync(TipoBase tipoBase, DocumentoDePago documentoDePago)
        {
            IDocumentoDePagoRepository documentoDePagoRepository = new DocumentoDePagoRepository(new VentaContext(tipoBase));
            return documentoDePagoRepository.ActualizarAsync(documentoDePago);
        }

        public static Task GuardarAsync(TipoBase tipoBase, DocumentoDePago documentoDePago)
        {
            IDocumentoDePagoRepository documentoDePagoRepository = new DocumentoDePagoRepository(new VentaContext(tipoBase));
            return documentoDePagoRepository.GuardarAsync(documentoDePago);
        }

        public static Task<int> CantidadAsync(TipoBase tipoBase, int idSucursal)
        {
            IDocumentoDePagoRepository documentoDePagoRepository = new DocumentoDePagoRepository(new VentaContext(tipoBase));
            return documentoDePagoRepository.CantidadAsync(idSucursal);
        }

        public static Task<DocumentoDePago> ObtenerAsync(TipoBase tipoBase, long idDocumentoDePago)
        {
            IDocumentoDePagoRepository documentoDePagoRepository = new DocumentoDePagoRepository(new VentaContext(tipoBase));
            return documentoDePagoRepository.ObtenerAsync(idDocumentoDePago);
        }

        public static Task<decimal> ObtenerTotalAsync(int idSucursal, DateTime fecha, TipoPago? tipoPago)
        {
            IDocumentoDePagoRepository documentoDePagoRepository = new DocumentoDePagoRepository(new VentaContext());
            return documentoDePagoRepository.ObtenerTotalAsync(idSucursal, fecha, tipoPago);
        }

        public static Task<decimal> ObtenerTotalAsync(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, TipoPago? tipoPago)
        {
            IDocumentoDePagoRepository documentoDePagoRepository = new DocumentoDePagoRepository(new VentaContext());
            return documentoDePagoRepository.ObtenerTotalAsync(idSucursal, fechaDesde, fechaHasta, tipoPago);
        }
    }
}
