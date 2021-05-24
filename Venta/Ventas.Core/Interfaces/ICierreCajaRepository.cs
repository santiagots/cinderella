using System;
using System.Collections.Generic;
using Ventas.Core.Enum;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Interfaces
{
    public interface ICierreCajaRepository
    {
        void Alta(CierreCaja cierreCaja);

        void Actualizar(CierreCaja cierreCaja);

        IEnumerable<CierreCaja> Buscar(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, CierreCajaSituacion? situacionCaja);

        CierreCaja Obtener(int idSucursal, DateTime fecha);

        decimal ObtenerTotal(int idSucursal, DateTime fechaDesde, DateTime fechaHasta);

        decimal ObtenerTotalDiferencia(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, CierreCajaSituacion situacionCaja);

        CierreCaja ObtenerUltima(int idSucursal);
    }
}   
