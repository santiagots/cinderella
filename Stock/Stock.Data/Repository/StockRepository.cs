using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Extension;
using Common.Data.Repository;
using Stock.Core.Interface;
using Stock.Core.Model.BaseAgreggate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Z.EntityFramework.Plus;
using Modelo = Stock.Core.Model.BaseAgreggate;

namespace Stock.Data.Repository
{
    public class StockRepository : BaseRepository<StockContext>, IStockRepository
    {
        public StockRepository(StockContext stockContext) : base(stockContext)
        {
        }

        public Task<List<Modelo.Stock>> BuscarAsync(int? idSucursal, string codigoNombreProducto, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            IQueryable<Modelo.Stock> stockQueryable = _context.Stock
                                                      .Where(x => !x.Borrado)
                                                      .IncludeOptimized(x => x.Usuario)
                                                      .IncludeOptimized(x => x.Producto)
                                                      .IncludeOptimized(x => x.Producto.Categoria);

            if (idSucursal.HasValue)
                stockQueryable = stockQueryable.Where(x => x.IdSucursal == idSucursal.Value);

            if (!String.IsNullOrEmpty(codigoNombreProducto))
                stockQueryable = stockQueryable.Where(x => x.Producto.Nombre.Contains(codigoNombreProducto) || x.Producto.Codigo.Contains(codigoNombreProducto));

            totalElementos = stockQueryable.Count();

            return Task.Run(() =>
            {
                List<Modelo.Stock> stocks = stockQueryable.Paginar(ordenadoPor, ordenarDireccion, pagina, itemsPorPagina).ToList();

                //Obtengo los Id de los productos de cada uno de los Stock
                List<int> IdProductos = stocks.Select(x => x.IdProducto).ToList();

                //Obtengo las reservas de los productos
                var reservados = _context.NotaPedidoItem
                                        .Where(x => !x.Borrado && (x.NotaPedido.Estado == NotaPedidoEstado.Ingresada || x.NotaPedido.Estado == NotaPedidoEstado.Venta) && IdProductos.Contains(x.IdProducto.Value))
                                        .GroupBy(x => x.IdProducto)
                                        .Select(x => new { idProducto = x.Key, cantidad = x.Sum(y => y.Cantidad) })
                                        .ToList();
                                                         
                //Registro las reservas de los productos en el stock  
                foreach (var stock in stocks)
                {
                    int? cantidad = reservados.FirstOrDefault(x => x.idProducto == stock.IdProducto)?.cantidad;
                    if (cantidad.HasValue)
                        stock.CargarReserva(cantidad.Value);
                }

                return stocks;
            });
        }

        public Task ActualizarAsync(Modelo.Stock stockModel)
        {
            stockModel.EstadoEntidad = EstadoEntidad.Modificado;
            _context.AttachRecursive(stockModel);

            Modelo.Stock stockAnterior = _context.Stock.FirstOrDefault(x => x.Id == stockModel.Id);

            Bitacora bitacora = new Bitacora();
            if(!stockModel.Borrado)
                bitacora.Modificar(stockModel, stockAnterior);
            else
                bitacora.Borrar(stockModel);

            bitacora.EstadoEntidad = EstadoEntidad.Nuevo;
            _context.AttachRecursive(bitacora);

            return _context.SaveChangesAsync();
        }

        public Task GuardarAsync(Modelo.Stock stockModel)
        {
            if (_context.Stock.Any(x => !x.Borrado && x.IdSucursal == stockModel.IdSucursal && x.IdProducto == stockModel.IdProducto))
                throw new NegocioException($"No se pudo dar de alta el stock. Ya se cuenta registrado producto [{stockModel.Producto.Codigo}] {stockModel.Producto.Nombre} con su stock correspondiente. Por favor, modifique los datos necesarios.");

            stockModel.EstadoEntidad = EstadoEntidad.Nuevo;
            _context.AttachRecursive(stockModel);

            Bitacora bitacora = new Bitacora();
            bitacora.Alta(stockModel);

            bitacora.EstadoEntidad = EstadoEntidad.Nuevo;
            _context.AttachRecursive(bitacora);

            return _context.SaveChangesAsync();
        }
    }
}
