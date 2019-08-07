using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Core.Enum;
using Ventas.Core.Enum;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.NotaPedidoAgreggate;
using System.Data.Entity;

namespace Ventas.Data.Repository
{
    public class NotaPedidoRepository : BaseRepository<VentaContext>, INotaPedidoRepository
    {
        public NotaPedidoRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public void Guardar(NotaPedido notaPedido)
        {
            NotaPedido UltimaNotaPedido = _context.NotaPedido
                                        .Where(x => x.IdSucursal == notaPedido.IdSucursal)
                                        .OrderBy(x => x.Numero)
                                        .FirstOrDefault();

            if(UltimaNotaPedido == null)
                notaPedido.AgregarNumero(1);
            else
                notaPedido.AgregarNumero(UltimaNotaPedido.Numero + 1);

            _context.Entry(notaPedido.Encargado).State = System.Data.Entity.EntityState.Unchanged;
            _context.Entry(notaPedido.Vendedor).State = System.Data.Entity.EntityState.Unchanged;
            _context.NotaPedido.Add(notaPedido);
            _context.SaveChanges();
        }

        public void Actualizar(NotaPedido notaPedido)
        {
            _context.NotaPedido.Attach(notaPedido);
            _context.Entry(notaPedido).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public List<NotaPedido> Obtener(NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente)
        {
            IQueryable<NotaPedido> notaPedido = _context.NotaPedido
                                                    .Where(x => !x.Borrado)
                                                    .Include(x => x.NotaPedidoItems)
                                                    .Include(x => x.Vendedor)
                                                    .Include(x => x.Encargado)
                                                    .Include(x => x.ClienteMayorista)
                                                    .Include(x => x.ClienteMinorista);

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

            return notaPedido.ToList();
        }
    }
}
