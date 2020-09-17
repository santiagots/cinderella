using Common.Core.Enum;
using Common.Core.Extension;
using Common.Core.Interfaces;
using Common.Core.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Data.Repository
{
    public class ClienteMayoristaRepository : BaseRepository<CommonContext>, IClienteMayoristaRepository
    {
        public ClienteMayoristaRepository(CommonContext commonContext) : base(commonContext)
        {
        }

        public Task<List<ClienteMayorista>> BuscarAsync(string razonSocial, string cuit, CondicionIVA? condicionIva, int? IdlistaPrecio, int? idCorredor, int? idEmpresa, bool? habilitado, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            IQueryable<ClienteMayorista> ClientesMayoristas = ObtenerConsulta();

            if (!string.IsNullOrEmpty(razonSocial))
                ClientesMayoristas = ClientesMayoristas.Where(x => x.RazonSocial.Contains(razonSocial));

            if (!string.IsNullOrEmpty(cuit))
                ClientesMayoristas = ClientesMayoristas.Where(x => x.Cuit.Contains(cuit));

            if (condicionIva != null)
                ClientesMayoristas = ClientesMayoristas.Where(x => x.CondicionIVA == condicionIva);

            if (IdlistaPrecio != null)
                ClientesMayoristas = ClientesMayoristas.Where(x => x.IdListaPrecio == IdlistaPrecio);

            if (habilitado != null)
                ClientesMayoristas = ClientesMayoristas.Where(x => x.Habilitado == habilitado);

            return ClientesMayoristas.Paginar(ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos).ToListAsync();
        }

        public Task GuardarAsync(ClienteMayorista cliente)
        {
            AttachCliente(ref cliente);

            _context.ClienteMayorista.Add(cliente);

            return _context.SaveChangesAsync();
        }

        public Task ActualizarAsync(ClienteMayorista cliente)
        {
            AttachCliente(ref cliente);

            _context.Entry(cliente.DomicilioFacturacion).State = EntityState.Modified;
            _context.Entry(cliente.DomicilioEntrega).State = EntityState.Modified;
            _context.Entry(cliente).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }

        public Task<ClienteMayorista> Obtener(int id)
        {
            return ObtenerConsulta()
                        .FirstOrDefaultAsync(x => x.Id == id);
        }

        private IQueryable<ClienteMayorista> ObtenerConsulta()
        {
            return _context.ClienteMayorista
                                    .Include(x => x.ListaPrecio)
                                    .Include(x => x.DomicilioFacturacion)
                                    .Include(x => x.DomicilioFacturacion.Localidad)
                                    .Include(x => x.DomicilioFacturacion.Provincia)
                                    .Include(x => x.DomicilioFacturacion.Distrito)
                                    .Include(x => x.DomicilioEntrega)
                                    .Include(x => x.DomicilioEntrega.Localidad)
                                    .Include(x => x.DomicilioEntrega.Provincia)
                                    .Include(x => x.DomicilioEntrega.Distrito);
        }

        private void AttachCliente(ref ClienteMayorista cliente)
        {
            cliente.ListaPrecio = (ListaPrecio)_context.Attach(cliente.ListaPrecio);

            cliente.DomicilioEntrega.Localidad = (Localidad)_context.Attach(cliente.DomicilioEntrega.Localidad);
            cliente.DomicilioEntrega.Distrito = (Distrito)_context.Attach(cliente.DomicilioEntrega.Distrito);
            cliente.DomicilioEntrega.Provincia = (Provincia)_context.Attach(cliente.DomicilioEntrega.Provincia);

            cliente.DomicilioFacturacion.Localidad = (Localidad)_context.Attach(cliente.DomicilioFacturacion.Localidad);
            cliente.DomicilioFacturacion.Distrito = (Distrito)_context.Attach(cliente.DomicilioFacturacion.Distrito);
            cliente.DomicilioFacturacion.Provincia = (Provincia)_context.Attach(cliente.DomicilioFacturacion.Provincia);
        }
    }
}
