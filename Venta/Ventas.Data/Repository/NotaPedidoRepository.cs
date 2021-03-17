using Common.Core.Enum;
using Common.Core.Extension;
using Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Ventas.Core.Enum;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.NotaPedidoAgreggate;
using Z.EntityFramework.Plus;

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

            if (UltimaNotaPedido == null)
                notaPedido.AgregarNumero(1);
            else
                notaPedido.AgregarNumero(UltimaNotaPedido.Numero + 1);

            notaPedido.EstadoEntidad = EstadoEntidad.Nuevo;
            foreach (NotaPedidoItem notaPedidoItem in notaPedido.NotaPedidoItems)
                notaPedidoItem.EstadoEntidad = EstadoEntidad.Nuevo;

            _context.AttachRecursive(notaPedido);

            return _context.SaveChangesAsync();
        }

        public Task ActualizarAsync(NotaPedido notaPedido)
        {
            notaPedido.EstadoEntidad = EstadoEntidad.Modificado;

            foreach (NotaPedidoItem notaPedidoItem in notaPedido.NotaPedidoItems)
            {
                if (notaPedidoItem.NotaPedido == null) //si la nata de pedido que contiene el item es null quiere decir que se agrego el item
                    notaPedidoItem.EstadoEntidad = EstadoEntidad.Nuevo;
                else
                    notaPedidoItem.EstadoEntidad = EstadoEntidad.Modificado;
            }

            _context.AttachRecursive(notaPedido);

            return _context.SaveChangesAsync();
        }

        public Task<NotaPedido> Obtener(long idNotaPedido)
        {
            return _context.NotaPedido
                           .IncludeFilter(x => x.NotaPedidoItems.Where(y => !y.Borrado))
                           .IncludeFilter(x => x.NotaPedidoItems.Select(y => y.Producto.SubCategoria.IVA))
                           .IncludeFilter(x => x.Vendedor)
                           .IncludeFilter(x => x.Encargado)
                           .IncludeFilter(x => x.ClienteMayorista)
                           .IncludeFilter(x => x.ClienteMinorista)
                           .FirstOrDefaultAsync(x => x.Id == idNotaPedido);
        }

        public Task<List<NotaPedido>> ObtenerAsync(int idSucursal, int? numero, NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            IQueryable<NotaPedido> notaPedido = ObtenerConsulta()
                                                    .Where(x => x.IdSucursal == idSucursal);

            notaPedido = Filtrar(numero, estado, tipoCliente, fechaDesde, fechaHasta, idVendedor, nombreCliente, notaPedido);

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

        public int ObtenerCantidad(int idSucursal, List<NotaPedidoEstado> estado)
        {
            IQueryable<NotaPedido> notaPedido = ObtenerConsulta()
                                                    .Where(x => x.IdSucursal == idSucursal);

            if (estado.Count > 0)
                notaPedido = notaPedido.Where(x => estado.Contains(x.Estado));

            return notaPedido.Count();
        }

        public Task<decimal?> ObtenerMontoTotalSinIva(int idSucursal, int? numero, NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente)
        {
            IQueryable<NotaPedido> notaPedido = _context.NotaPedido.Where(x => !x.Borrado && x.IdSucursal == idSucursal);

            notaPedido = Filtrar(numero, estado, tipoCliente, fechaDesde, fechaHasta, idVendedor, nombreCliente, notaPedido);

            return notaPedido.SelectMany(x => x.NotaPedidoItems.Where(y => !y.Borrado))
                             .SumAsync(x => (decimal?)(x.MontoProducto.Valor * x.Cantidad));
        }

        public Task<decimal?> ObtenerMontoTotal(int idSucursal, int? numero, NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente)
        {
            IQueryable<NotaPedido> notaPedido = _context.NotaPedido.Where(x => !x.Borrado && x.IdSucursal == idSucursal);

            notaPedido = Filtrar(numero, estado, tipoCliente, fechaDesde, fechaHasta, idVendedor, nombreCliente, notaPedido);

            return notaPedido.SelectMany(x => x.NotaPedidoItems.Where(y => !y.Borrado))
                             .SumAsync(x => (decimal?)((x.MontoProducto.Valor + x.MontoProducto.Iva) * x.Cantidad));
        }

        private IQueryable<NotaPedido> ObtenerConsulta()
        {
            return _context.NotaPedido
                            .Where(x => !x.Borrado)
                           .IncludeFilter(x => x.NotaPedidoItems.Where(y => !y.Borrado))
                           .IncludeFilter(x => x.NotaPedidoItems.Select(y => y.Producto))
                           .IncludeFilter(x => x.NotaPedidoItems.Select(y => y.Producto.SubCategoria))
                           .IncludeFilter(x => x.NotaPedidoItems.Select(y => y.Producto.SubCategoria.IVA))
                           .IncludeFilter(x => x.Vendedor)
                           .IncludeFilter(x => x.Encargado)
                           .IncludeFilter(x => x.ClienteMayorista)
                           .IncludeFilter(x => x.ClienteMinorista);
        }

        private static IQueryable<NotaPedido> Filtrar(int? numero, NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente, IQueryable<NotaPedido> notaPedido)
        {
            if (numero.HasValue)
                notaPedido = notaPedido.Where(x => x.Numero == numero.Value);

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
            return notaPedido;
        }
    }
}
