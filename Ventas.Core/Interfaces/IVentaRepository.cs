using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Interfaces
{
    public interface IVentaRepository
    {
        void Guardar(Venta venta);

        int Cantidad(int idSucursal);
    }
}
