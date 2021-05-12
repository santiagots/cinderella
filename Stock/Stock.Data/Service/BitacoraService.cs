using Common.Core.Enum;
using Stock.Core.Interface;
using Stock.Core.Model.BaseAgreggate;
using Stock.Data.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stock.Data.Service
{
    public class BitacoraService
    {
        public static Task<List<Bitacora>> BuscarAsync(int idSucursal, DateTime? fechaDesde, DateTime? fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            IBitacoraRepository bitacoraRepository = new BitacoraRepository(new StockContext());
            return bitacoraRepository.BuscarAsync(idSucursal, fechaDesde, fechaHasta, ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos);
        }

        public static Task<Decimal?> TotalAsync(int idSucursal, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            IBitacoraRepository bitacoraRepository = new BitacoraRepository(new StockContext());
            return bitacoraRepository.TotalAsync(idSucursal, fechaDesde, fechaHasta);
        }
    }
}
