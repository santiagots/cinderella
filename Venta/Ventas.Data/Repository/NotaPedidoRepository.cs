using System;
using System.Collections.Generic;
using System.Linq;
using Common.Core.Enum;
using Ventas.Core.Enum;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.NotaPedidoAgreggate;
using System.Data.Entity;
using Common.Data.Repository;
using Ventas.Core.Model.ValueObjects;
using System.Threading.Tasks;
using Ventas.Core.Model.CuentaCorrienteAggregate;
using Common.Core.Extension;
using Common.Core.Model;

namespace Ventas.Data.Repository
{
    public class NotaPedidoRepository : BaseRepository<VentaContext>, INotaPedidoRepository
    {
        public NotaPedidoRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public Task GuardarAsync(NotaPedido notaPedido)
        {
            NotaPedido UltimaNotaPedido = _context.NotaPedido
                                        .Where(x => x.IdSucursal == notaPedido.IdSucursal)
                                        .OrderByDescending(x => x.Numero)
                                        .FirstOrDefault();

            foreach (NotaPedidoItem notaPedidoItem in notaPedido.NotaPedidoItems)
            {
                notaPedidoItem.Producto.Categoria = (Categoria)_context.Attach(notaPedidoItem.Producto.Categoria);
                notaPedidoItem.Producto.SubCategoria = (SubCategoria)_context.Attach(notaPedidoItem.Producto.SubCategoria);
                _context.Entry(notaPedidoItem.Producto).State = EntityState.Unchanged;
            }

            if (UltimaNotaPedido == null)
                notaPedido.AgregarNumero(1);
            else
                notaPedido.AgregarNumero(UltimaNotaPedido.Numero + 1);

            if(notaPedido.Encargado != null)
                _context.Entry(notaPedido.Encargado).State = EntityState.Unchanged;

            if (notaPedido.Vendedor != null)
                _context.Entry(notaPedido.Vendedor).State = EntityState.Unchanged;

            if (notaPedido.ClienteMayorista != null)
                _context.Entry(notaPedido.ClienteMayorista).State = EntityState.Unchanged;

            _context.NotaPedido.Add(notaPedido);
            return _context.SaveChangesAsync();
        }

        public Task ActualizarAsync(NotaPedido notaPedido)
        {
            foreach (NotaPedidoItem notaPedidoItem in notaPedido.NotaPedidoItems)
            {
                _context.Entry(notaPedidoItem).State = notaPedidoItem.Id > 0 ? EntityState.Modified : EntityState.Added;
                notaPedidoItem.Producto.Categoria = (Categoria)_context.Attach(notaPedidoItem.Producto.Categoria);
                notaPedidoItem.Producto.SubCategoria = (SubCategoria)_context.Attach(notaPedidoItem.Producto.SubCategoria);
                _context.Entry(notaPedidoItem.Producto).State = EntityState.Unchanged;
            }

            if (notaPedido.Encargado != null)
                _context.Entry(notaPedido.Encargado).State = EntityState.Unchanged;

            if (notaPedido.Vendedor != null)
                _context.Entry(notaPedido.Vendedor).State = EntityState.Unchanged;

            if (notaPedido.ClienteMayorista != null)
                _context.Entry(notaPedido.ClienteMayorista).State = EntityState.Unchanged;

            _context.Entry(notaPedido).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }

        public Task<List<NotaPedido>> ObtenerAsync(int idSucursal, NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            IQueryable<NotaPedido> notaPedido = ObtenerConsulta()
                                                    .Where(x => x.IdSucursal == idSucursal);

            if (estado.HasValue)
                notaPedido = notaPedido.Where(x => x.Estado == estado.Value);

            if (tipoCliente.HasValue)
                notaPedido = notaPedido.Where(x => x.TipoCliente == tipoCliente.Value);

            if (fechaDesde.HasValue)
                notaPedido = notaPedido.Where(x => DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value);

            if (fechaDesde.HasValue)
                notaPedido = notaPedido.Where(x => DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);

            if (idVendedor.HasValue)
                notaPedido = notaPedido.Where(x => x.IdVendedor == idVendedor.Value);

            if (!string.IsNullOrWhiteSpace(nombreCliente))
                notaPedido = notaPedido.Where(x => x.ClienteMinorista.Apellido.Contains(nombreCliente) || x.ClienteMinorista.Nombre.Contains(nombreCliente) || x.ClienteMayorista.RazonSocial.Contains(nombreCliente));

            return notaPedido.Paginar(ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos)
                             .ToListAsync();
        }

        public Task<List<NotaPedido>> ObtenerAsync(int idClienteMayorista, NotaPedidoEstado? estado, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            IQueryable<NotaPedido> notaPedido = ObtenerConsulta().Where(x => x.ClienteMayorista.Id == idClienteMayorista);

            if (estado.HasValue)
                notaPedido = notaPedido.Where(x => x.Estado == estado.Value);

            return notaPedido.Paginar(ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos)
                             .ToListAsync();
        }

        private IQueryable<NotaPedido> ObtenerConsulta()
        {
            return _context.NotaPedido
                            .Where(x => !x.Borrado)
                            .Include(x => x.NotaPedidoItems.Select(y => y.Producto))
                            .Include(x => x.Vendedor)
                            .Include(x => x.Encargado)
                            .Include(x => x.ClienteMayorista)
                            .Include(x => x.ClienteMinorista);
        }

        public decimal ObtenerMontoTotalClienteMayorista(int idClienteMatorista)
        {
            decimal? MontoTotalClienteMayorista =  _context.NotaPedido.Where(x => !x.Borrado && x.Estado != NotaPedidoEstado.Cerrada && x.IdClienteMayorista == idClienteMatorista)
                                                                      .SelectMany(x => x.NotaPedidoItems)
                                                                      .Sum(x => (decimal?)(x.MontoProducto.Valor * x.Cantidad));

            return MontoTotalClienteMayorista ?? 0;
        }

        public int ObtenerCantidad(int idSucursal, List<NotaPedidoEstado> estado)
        {
            IQueryable<NotaPedido> notaPedido = ObtenerConsulta()
                                                    .Where(x => x.IdSucursal == idSucursal);

            if (estado.Count > 0)
                notaPedido = notaPedido.Where(x => estado.Contains(x.Estado));

            return notaPedido.Count();
        }
    }
}
