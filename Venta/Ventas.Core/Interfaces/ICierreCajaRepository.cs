using System;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Interfaces
{
    public interface ICierreCajaRepository
    {
        void Alta(CierreCaja cierreCaja);

        void Actualizar(CierreCaja cierreCaja);

        CierreCaja Obtener(int idSucursal, DateTime fecha);

        CierreCaja ObtenerUltima(int idSucursal);
    }
}   
