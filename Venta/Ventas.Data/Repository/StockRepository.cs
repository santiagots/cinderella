﻿using Common.Data.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Data.Repository
{
    public class StockRepository: BaseRepository<VentaContext>, IStockRepository
    {
        public StockRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public void Actualizar(IEnumerable<Stock> stocks)
        {
            foreach (Stock stock in stocks)
            {

                if (_context.Stock.Any(x => x.Id == stock.Id))
                {
                    _context.Stock.Attach(stock);
                    _context.Entry(stock).State = EntityState.Modified;
                }
                else
                {
                    _context.Stock.Add(stock);
                }
            }
            _context.SaveChanges();
        }
    }
}
