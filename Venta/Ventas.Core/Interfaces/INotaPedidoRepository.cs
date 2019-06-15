using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Core.Enum;
using Ventas.Core.Enum;
using Ventas.Core.Model.NotaPedidoAgreggate;

namespace Ventas.Core.Interfaces
{
    public interface INotaPedidoRepository
    {
        void Guardar(NotaPedido notaPedido);
        List<NotaPedido> Obtener(NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente);
        void Actualizar(NotaPedido notaPedido);
    }
}
