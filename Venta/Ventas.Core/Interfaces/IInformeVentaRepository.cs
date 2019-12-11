using Common.Core.Enum;
using Common.Core.Model;
using System;
using System.Collections.Generic;
using Ventas.Core.Model.InformeAggregate;

namespace Ventas.Core.Interfaces
{
    public interface IInformeVentaRepository
    {
        IList<InformeVentaPorTipoVenta> InformeVentaPorTipoVenta(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta);
        IList<InformeVentaPorTipoPago> InformeVentaPorTipoPago(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta);
        IList<InformeVentaPorFecha> InformeVentaPorFecha(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems);
        IList<InformeVentaPorProducto> InformeProductoPorFecha(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, int? idProducto, Categoria categoria, SubCategoria subcategoria, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems);
        IList<InformeVentaPorProducto> InformeProductoPorNombre(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, int? idProducto, Categoria categoria, SubCategoria subcategoria, string ordenadoPor, OrdenadoDireccion ordenadoDireccion, int itemsPorPagina, int pagina, out int totalItems);
        IList<InformeVentaPorProducto> InformeProductoPorCategoria(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, int? idProducto, Categoria categoria, SubCategoria subcategoria, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems);
        IList<InformeVentaPorProducto> InformeProductoPorSubCategoria(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, int? idProducto, Categoria categoria, SubCategoria subcategoria, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems);
        IList<InformeVentaEgresos> InformeCostos(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta);
        IList<InformeVentaEgresos> InformeGastos(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta);
        IList<InformeVentaEgresos> InformeMercaderia(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems);
        decimal TotalVenta(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta);
        decimal TotalMercaderia(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta);
    }
}
