using Common.Core.Enum;
using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Dynamic;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.InformeAggregate;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Data.Repository
{
    public class InformeVentaRepository : BaseRepository<VentaContext>, IInformeVentaRepository
    {
        public InformeVentaRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public IList<InformeVentaPorTipoVenta> InformeVentaPorTipoVenta(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta)
        {
            var datos = InformeVentaFiltrarVentas(idSucursales, fechaDesde, fechaHasta)
                                                    .GroupBy(x => new { x.TipoCliente, Facturada = x.Factura != null ? true : false })
                                                    .Select(g => new
                                                    {
                                                        g.Key.TipoCliente,
                                                        g.Key.Facturada,
                                                        MontoTotal = g.Sum(x => x.Pagos.Sum(y => y.MontoPago.Monto - y.MontoPago.Descuento + y.MontoPago.CFT + y.MontoPago.IVA)),
                                                        CantidadTotal = g.Count()
                                                    })
                                                    .ToList();

            List<InformeVentaPorTipoVenta> informeVentaPorTipoCliente = new List<InformeVentaPorTipoVenta>();
            datos.ForEach(x => informeVentaPorTipoCliente.Add(new InformeVentaPorTipoVenta(x.TipoCliente, x.Facturada, x.MontoTotal, x.CantidadTotal)));

            return informeVentaPorTipoCliente;
        }

        public IList<InformeVentaPorTipoPago> InformeVentaPorTipoPago(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta)
        {
            var datos = InformeVentaFiltrarPagos(idSucursales, fechaDesde, fechaHasta)
                                                    .GroupBy(x => new { x.Venta.TipoCliente, x.TipoPago, x.NumeroCuotas })
                                                    .Select(g => new
                                                    {
                                                        g.Key.TipoCliente,
                                                        g.Key.TipoPago,
                                                        g.Key.NumeroCuotas,
                                                        MontoTotal = g.Sum(x => x.MontoPago.Monto - x.MontoPago.Descuento + x.MontoPago.CFT + x.MontoPago.IVA),
                                                        CantidadTotal = g.Count()
                                                    })
                                                    .ToList();

            List<InformeVentaPorTipoPago> informeVentaPorTipoPago = new List<InformeVentaPorTipoPago>();
            datos.ForEach(x => informeVentaPorTipoPago.Add(new InformeVentaPorTipoPago(x.TipoPago, x.TipoCliente, x.NumeroCuotas, x.MontoTotal, x.CantidadTotal)));

            return informeVentaPorTipoPago;
        }

        public IList<InformeVentaPorFecha> InformeVentaPorFecha(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems)
        {
            var datos = InformeVentaFiltrarVentas(idSucursales, fechaDesde, fechaHasta)
                                                    .GroupBy(x => DbFunctions.TruncateTime(x.Fecha).Value )
                                                    .Select(g => new
                                                    {
                                                        Fecha = g.Key,
                                                        Monto = g.Sum(x => (decimal?) x.Pagos.Sum(y => y.MontoPago.Monto - y.MontoPago.Descuento + y.MontoPago.CFT + y.MontoPago.IVA) ?? 0),
                                                        Cantidad = g.Count()
                                                    })
                                                    .OrderBy($"{ordenadoPor} {ordenarDireccion.ToString()}")
                                                    .Skip(itemsPorPagina * (pagina - 1))
                                                    .Take(itemsPorPagina)
                                                    .ToList();

            List<InformeVentaPorFecha> informeVentaPorFecha = new List<InformeVentaPorFecha>();
            datos.ForEach(x => informeVentaPorFecha.Add(new InformeVentaPorFecha(x.Fecha, x.Monto, x.Cantidad)));

            totalItems = InformeVentaFiltrarVentas(idSucursales, fechaDesde, fechaHasta)
                                                .GroupBy(x => DbFunctions.TruncateTime(x.Fecha).Value)
                                                .Count();

            return informeVentaPorFecha;
        }

        public IList<InformeVentaPorProducto> InformeProductoPorFecha(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, int? idProducto, Categoria categoria, SubCategoria subcategoria, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems)
        {
            var datos = InformeVentaFiltrarProducto(idSucursales, fechaDesde, fechaHasta, idProducto, categoria, subcategoria)
                                    .GroupBy(x => new { DbFunctions.TruncateTime(x.Venta.Fecha).Value })
                                    .Select(g => new
                                    {
                                        Nombre = g.Key,
                                        Monto = g.Sum(x => x.MontoProducto.Valor + x.MontoProducto.Iva),
                                        Cantidad = g.Sum(x => x.Cantidad)
                                    })
                                    .OrderBy($"{ordenadoPor} {ordenarDireccion.ToString()}")
                                    .Skip(itemsPorPagina * (pagina - 1))
                                    .Take(itemsPorPagina)
                                    .ToList();

            List<InformeVentaPorProducto> informeVentaPorProducto = new List<InformeVentaPorProducto>();
            datos.ForEach(x => informeVentaPorProducto.Add(new InformeVentaPorProducto(x.Nombre.Value.ToShortDateString(), 0, x.Monto, x.Cantidad)));

            totalItems = InformeVentaFiltrarProducto(idSucursales, fechaDesde, fechaHasta, idProducto, categoria, subcategoria)
                                    .GroupBy(x => new { DbFunctions.TruncateTime(x.Venta.Fecha).Value })
                                    .Count();

            return informeVentaPorProducto;
        }

        public IList<InformeVentaPorProducto> InformeProductoPorNombre(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, int? idProducto, Categoria categoria, SubCategoria subcategoria, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems)
        {
            var datos = InformeVentaFiltrarProducto(idSucursales, fechaDesde, fechaHasta, idProducto, categoria, subcategoria)
                                    .GroupBy(x => new { x.Producto.Nombre  })
                                    .Select(g => new
                                    {
                                        Nombre = g.Key.ToString(),
                                        g.FirstOrDefault().IdProducto,
                                        Monto = g.Sum(x => (x.MontoProducto.Valor + x.MontoProducto.Iva) * x.Cantidad),
                                        Cantidad = g.Sum(x => x.Cantidad)
                                    })
                                    .OrderBy($"{ordenadoPor} {ordenarDireccion.ToString()}")
                                    .Skip(itemsPorPagina * (pagina - 1))
                                    .Take(itemsPorPagina)
                                    .ToList();

            List<InformeVentaPorProducto> informeVentaPorProducto = new List<InformeVentaPorProducto>();
            datos.ForEach(x => informeVentaPorProducto.Add(new InformeVentaPorProducto(x.Nombre, x.IdProducto, x.Monto, x.Cantidad)));

            totalItems = InformeVentaFiltrarProducto(idSucursales, fechaDesde, fechaHasta, idProducto, categoria, subcategoria)
                                    .GroupBy(x => new { x.Producto.Nombre })
                                    .Count();

            return informeVentaPorProducto;
        }

        public IList<InformeVentaPorProducto> InformeProductoPorCategoria(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, int? idProducto, Categoria categoria, SubCategoria subcategoria, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems)
        {
            var datos = InformeVentaFiltrarProducto(idSucursales, fechaDesde, fechaHasta, idProducto, categoria, subcategoria)
                                    .GroupBy(x => new { x.Producto.Categoria.Descripcion })
                                    .Select(g => new
                                    {
                                        Nombre = g.Key.Descripcion,
                                        Monto = g.Sum(x => (x.MontoProducto.Valor + x.MontoProducto.Iva) * x.Cantidad),
                                        Cantidad = g.Sum(x => x.Cantidad)
                                    })
                                    .OrderBy($"{ordenadoPor} {ordenarDireccion.ToString()}")
                                    .Skip(itemsPorPagina * (pagina - 1))
                                    .Take(itemsPorPagina)
                                    .ToList();

            List<InformeVentaPorProducto> informeVentaPorProducto = new List<InformeVentaPorProducto>();
            datos.ForEach(x => informeVentaPorProducto.Add(new InformeVentaPorProducto(x.Nombre, 0,  x.Monto, x.Cantidad)));

            totalItems = InformeVentaFiltrarProducto(idSucursales, fechaDesde, fechaHasta, idProducto, categoria, subcategoria)
                                    .GroupBy(x => new { x.Producto.Categoria.Descripcion })
                                    .Count();

            return informeVentaPorProducto;
        }

        public IList<InformeVentaPorProducto> InformeProductoPorSubCategoria(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, int? idProducto, Categoria categoria, SubCategoria subcategoria, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems)
        {
            var datos = InformeVentaFiltrarProducto(idSucursales, fechaDesde, fechaHasta, idProducto, categoria, subcategoria)
                                    .GroupBy(x => new { x.Producto.SubCategoria.Descripcion })
                                    .Select(g => new
                                    {
                                        Nombre = g.Key.Descripcion,
                                        Monto = g.Sum(x => (x.MontoProducto.Valor + x.MontoProducto.Iva) * x.Cantidad),
                                        Cantidad = g.Sum(x => x.Cantidad)
                                    })
                                    .OrderBy($"{ordenadoPor} {ordenarDireccion.ToString()}")
                                    .Skip(itemsPorPagina * (pagina - 1))
                                    .Take(itemsPorPagina)
                                    .ToList();

            List<InformeVentaPorProducto> informeVentaPorProducto = new List<InformeVentaPorProducto>();
            datos.ForEach(x => informeVentaPorProducto.Add(new InformeVentaPorProducto(x.Nombre, 0, x.Monto, x.Cantidad)));

            totalItems = InformeVentaFiltrarProducto(idSucursales, fechaDesde, fechaHasta, idProducto, categoria, subcategoria)
                        .GroupBy(x => new { x.Producto.SubCategoria.Descripcion })
                        .Count();

            return informeVentaPorProducto;
        }

        public IList<InformeVentaEgresos> InformeCostos(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta)
        {
            string sql = $@" with GASTOS as (
		                    select
			                    T.Tipo Nombre,
			                    ISNULL(sum(G.Monto),0) Monto
		                    from MOVIMIENTOS_GASTOS G 
			                    inner join MOVIMIENTOS_TIPOS T on g.id_Tipo = t.id_Tipo
		                    where 
			                    G.Borrado = 0
			                    and (CAST(G.Fecha AS DATE) between @FDesde and @FHasta)
			                    and (G.Id_Sucursal in ({string.Join(", ", idSucursales)}))
			                    and G.id_Tipo <> 20 --Mercaderías
		                    group by
			                    T.Tipo 
			
		                    Union
		
                            select 'Mercaderías' Nombre,
	                            COALESCE(SUM(P.Costo * VD.Cantidad),0) Monto
                            from 
	                            NUEVA_VENTAS V
	                            inner join NUEVA_VENTA_ITEMS VD on V.id = VD.IdVenta
	                            inner join PRODUCTOS P on VD.IdProducto = P.id_Producto
		                    where 
			                    V.Anulado = 0
			                    and V.Fecha between @FDesde and @FHasta
			                    and V.IdSucursal in ({string.Join(", ", idSucursales)})
		                    )

	                    select Nombre, CAST(COALESCE(sum(Monto),0) AS DECIMAL(18,2)) Monto  
	                    from gastos
	                    group by Nombre";

            return _context.Database.SqlQuery<InformeVentaEgresos>(sql,
                new SqlParameter("@FDesde", fechaDesde),
                new SqlParameter("@FHasta", fechaHasta)
                ).ToList();
        }

        public IList<InformeVentaEgresos> InformeGastos(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta)
        {
            string sql = $@" with GASTOS as (
		                            select 			
			                            T.Tipo Nombre,
			                            ISNULL(sum(G.Monto),0) Monto
		                            from MOVIMIENTOS_GASTOS G 
			                            inner join MOVIMIENTOS_TIPOS T on g.id_Tipo = t.id_Tipo
		                            where 
			                            G.Borrado = 0
			                            and (CAST(G.Fecha AS DATE) between @FDesde and @FHasta)
			                            and (G.id_Sucursal in ({string.Join(", ", idSucursales)}))
		                            group by
			                            T.Tipo 
			
		                            Union
		
		                            select MOVSUB.Subtipo Nombre,
			                            ISNULL(SUM(MOVEG.Monto),0) Monto
		                            from MOVIMIENTOS_EGRESOS MOVEG 
			                            INNER JOIN MOVIMIENTOS_TIPOS MOVTIP ON MOVEG.id_Tipo = MOVTIP.id_Tipo 
			                            INNER JOIN MOVIMIENTOS_SUBTIPOS MOVSUB ON MOVEG.id_Subtipo = MOVSUB.id_Subtipo  
			                            INNER JOIN MOVIMIENTOS_SECCIONES MOVSEC ON MOVSEC.id_Seccion = MOVTIP.id_Seccion 
		                            where (Monto > 0) 
			                            and (MOVEG.id_Tipo=16 or MOVEG.id_Tipo=17)
			                            and (Aceptado=1) 
			                            and (MOVSUB.id_Seccion=1)
			                            and (CAST(MOVEG.Fecha AS DATE) between @FDesde and @FHasta)
			                            and (MOVEG.id_Sucursal in ({string.Join(", ", idSucursales)}))
		                            group by MOVSUB.Subtipo
		                            )

	                    select Nombre, CAST(COALESCE(sum(Monto),0) AS DECIMAL(18,2)) Monto  
	                    from gastos
	                    group by Nombre";

            return _context.Database.SqlQuery<InformeVentaEgresos>(sql,
                new SqlParameter("@FDesde", fechaDesde),
                new SqlParameter("@FHasta", fechaHasta)
                ).ToList();
        }

        public IList<InformeVentaEgresos> InformeMercaderia(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems)
        {
            string sqlCount = $@"   {SqlMercaderia(idSucursales)} 
                                    select count(1) 
                                    from MERCADERIA";

            string sqlSelect = $@"  {SqlMercaderia(idSucursales)} 
                                    select Nombre, sum(Monto) Monto
                                    from MERCADERIA
                                    group by
			                            Nombre
                                    Order by
	                                    {ordenadoPor} {ordenarDireccion.ToString()}
	                                OFFSET @PaginaTamaño * (@PaginaNumero - 1) ROWS
	                                FETCH NEXT @PaginaTamaño ROWS ONLY";



            totalItems = _context.Database.SqlQuery<int>(sqlCount,
                                                        new SqlParameter("@FDesde", fechaDesde),
                                                        new SqlParameter("@FHasta", fechaHasta)).Single();
		                    

            return _context.Database.SqlQuery<InformeVentaEgresos>(sqlSelect,
                                                                    new SqlParameter("@FDesde", fechaDesde),
                                                                    new SqlParameter("@FHasta", fechaHasta),
                                                                    new SqlParameter("@PaginaTamaño", itemsPorPagina),
                                                                    new SqlParameter("@PaginaNumero", pagina)).ToList();
        }

        public decimal TotalVenta(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta) 
            => InformeVentaFiltrarPagos(idSucursales, fechaDesde, fechaHasta).Sum(x => x.MontoPago.Monto - x.MontoPago.Descuento + x.MontoPago.CFT + x.MontoPago.IVA);

        public decimal TotalMercaderia(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta)
        {
            string sqlCount = $@"   {SqlMercaderia(idSucursales)} 
                                    select SUM(Monto) 
                                    from MERCADERIA";

            decimal? total = _context.Database.SqlQuery<decimal?>(sqlCount,
                                                    new SqlParameter("@FDesde", fechaDesde),
                                                    new SqlParameter("@FHasta", fechaHasta)).Single();

            return total ?? 0;
        }

        private IQueryable<Pago> InformeVentaFiltrarPagos(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta) =>
            _context.Pago.Where(x => x.Venta.Anulado == false &&
                               idSucursales.Contains(x.Venta.IdSucursal) &&
                               DbFunctions.TruncateTime(x.Venta.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                               DbFunctions.TruncateTime(x.Venta.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);
        

        private IQueryable<Venta> InformeVentaFiltrarVentas(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta) =>   
            _context.Venta.Where(x => x.Anulado == false &&
                                 idSucursales.Contains(x.IdSucursal) &&
                                 DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                                 DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);
        

        private IQueryable<VentaItem> InformeVentaFiltrarProducto(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, int? idProducto, Categoria categoria, SubCategoria subcategoria)
        {
            IQueryable<VentaItem> productos = _context.VentaItem.Where(x => !x.Venta.Anulado &&
                                              !x.EsDevolucion &&
                                              idSucursales.Contains(x.Venta.IdSucursal) &&
                                              DbFunctions.TruncateTime(x.Venta.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                                              DbFunctions.TruncateTime(x.Venta.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);

            if (idProducto.HasValue)
                productos = productos.Where(x => x.Producto.Id == idProducto.Value);
            if (categoria != null)
                productos = productos.Where(x => x.Producto.IdCategoria == categoria.Id);
            if (subcategoria != null)
                productos = productos.Where(x => x.Producto.IdSubcategoria == subcategoria.Id);

            return productos;
        }

        private string SqlMercaderia(IEnumerable<int> idSucursales) 
            => $@"with MERCADERIA as (  select 
			                                P.RazonSocial Nombre,
			                                CAST(COALESCE(Sum(M.MontoTotal),0) AS DECIMAL(18,2)) Monto
		                                from MERCADERIAS M 
                                                inner join PROVEEDORES P on P.id_Proveedor = M.id_Proveedor
		                                where 
			                                M.Habilitado = 1
			                                and M.Fecha between @FDesde and @FHasta
			                                and M.id_Sucursal in ({string.Join(", ", idSucursales)})
			                            group by
			                                P.RazonSocial)";
        
    }
}
