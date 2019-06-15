using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Enum;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Interfaces
{
    public interface IReservaRepository
    {
        void Guardar(Reserva reserva);
        IEnumerable<Reserva> Buscar(int idSucursal, bool entregada, string nombre, DateTime? fechaAlta, DateTime? fechaRetiro, ReservaMetodoEntrega? metodoEntrega);
        Reserva Obtener(long idReserva);
        void Eliminar(long id);
        Reserva ObtenerPorIdVenta(long idVenta);
    }
}
