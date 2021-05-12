using Common.Core.Enum;
using Stock.Core.Interface;
using Stock.Core.Model.BaseAgreggate;
using Stock.Data.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Modelo = Stock.Core.Model.BaseAgreggate;

namespace Stock.Data.Service
{
    public class StockService
    {
        public static Task<List<Modelo.Stock>> BuscarAsync(int idSucursal, string filtroPorCodigoNombre, string ordenadoPor, OrdenadoDireccion direccionOrdenamiento, int paginaActual, int elementosPorPagina, out int totalElementos)
        {
            IStockRepository stockRepository = new StockRepository(new StockContext());
            return stockRepository.BuscarAsync(idSucursal, filtroPorCodigoNombre, ordenadoPor, direccionOrdenamiento, paginaActual, elementosPorPagina, out totalElementos);
        }

        public static Task ActualizarAsync(Modelo.Stock stockModel)
        {
            IStockRepository stockRepository = new StockRepository(new StockContext());
            return stockRepository.ActualizarAsync(stockModel);
        }

        public static Task GuardarAsync(Modelo.Stock stockModel)
        {
            IStockRepository stockRepository = new StockRepository(new StockContext());
            return stockRepository.GuardarAsync(stockModel);
        }
    }
}
