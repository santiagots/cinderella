using Common.Core.Enum;
using Common.Core.Model;
using Common.Data.Repository;
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
            string sqlSelect = $@"  {InformeVentaFiltrarVentas(idSucursales)} 
                                    Select	V.TipoCliente,
		                                    cast(1 as bit) Facturado,
		                                    sum (P.Monto - P.Descuento + P.CFT + P.IVA) Monto,
		                                    count(DISTINCT V.Id) Cantidad
                                    from
	                                    ventas_filtro V
	                                    Inner Join NUEVA_VENTA_PAGOS P on V.Id = P.IdVenta
                                    group by V.TipoCliente";

            return _context.Database.SqlQuery<InformeVentaPorTipoVenta>(sqlSelect,
                                                        new SqlParameter("@FDesde", fechaDesde),
                                                        new SqlParameter("@FHasta", fechaHasta)).ToList();
        }

        public IList<InformeVentaPorTipoVenta> InformeVentaPorFacturacion(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta)
        {
            string sqlSelect = $@"  {InformeVentaFiltrarVentas(idSucursales)} 
                                    Select	sum (P.Monto - P.Descuento + P.CFT + P.IVA) Monto,
		                                    count(DISTINCT V.Id) Cantidad
                                    from
	                                    ventas_filtro V
                                        Inner Join NUEVA_FACTURA F on V.Id = F.IdVenta
	                                    Inner Join NUEVA_VENTA_PAGOS P on V.Id = P.IdVenta
                                    group by V.TipoCliente";

            return _context.Database.SqlQuery<InformeVentaPorTipoVenta>(sqlSelect,
                                            new SqlParameter("@FDesde", fechaDesde),
                                            new SqlParameter("@FHasta", fechaHasta)).ToList();
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
            string sqlCount = $@"   {InformeVentaFiltrarVentas(idSucursales)} 
									select count(1)
									from 
										(select 1 fila
										from ventas_filtro
										group by cast(fecha As Date)) datos";

            string sqlSelect = $@"{InformeVentaFiltrarVentas(idSucursales)} 
                                    Select cast(V.fecha As Date) fecha,
		                                    sum(P.Monto - P.Descuento + P.CFT + P.IVA) Monto,
		                                    count(DISTINCT V.Id) Cantidad
                                    from
                                        ventas_filtro V
                                        Inner Join NUEVA_VENTA_PAGOS P on V.Id = P.IdVenta
                                    group by cast(V.fecha As Date)
                                    Order by
	                                    {ordenadoPor} {ordenarDireccion.ToString()}
	                                OFFSET @PaginaTamaño * (@PaginaNumero - 1) ROWS
	                                FETCH NEXT @PaginaTamaño ROWS ONLY";


            totalItems = _context.Database.SqlQuery<int>(sqlCount,
                                                        new SqlParameter("@FDesde", fechaDesde),
                                                        new SqlParameter("@FHasta", fechaHasta)).Single();


            return _context.Database.SqlQuery<InformeVentaPorFecha>(sqlSelect,
                                                                    new SqlParameter("@FDesde", fechaDesde),
                                                                    new SqlParameter("@FHasta", fechaHasta),
                                                                    new SqlParameter("@PaginaTamaño", itemsPorPagina),
                                                                    new SqlParameter("@PaginaNumero", pagina)).ToList();
        }

        public IList<InformeVentaPorProducto> InformeProductoPorFecha(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, int? idProducto, Categoria categoria, SubCategoria subcategoria, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems)
        {
            string sqlCount = $@"   {InformeVentaFiltrarProducto(idSucursales)} 
                                    select count(1)
									from 
										(select 1 fila
										from Productos_filtro
										Group by Fecha) as dato";

            string sqlSelect = $@"  {InformeVentaFiltrarProducto(idSucursales)} 
                                    select  CAST(Fecha as varchar) Nombre,
		                                    Sum(Monto) Monto,
		                                    Sum(Cantidad) Cantidad
									from
										Productos_filtro
                                    Group by
	                                    Fecha
                                    Order by
	                                    {ordenadoPor} {ordenarDireccion.ToString()}
	                                OFFSET @PaginaTamaño * (@PaginaNumero - 1) ROWS
	                                FETCH NEXT @PaginaTamaño ROWS ONLY";

            totalItems = _context.Database.SqlQuery<int>(sqlCount,
                                                        new SqlParameter("@FDesde", fechaDesde),
                                                        new SqlParameter("@FHasta", fechaHasta),
                                                        new SqlParameter("@idProducto", (object)idProducto ?? DBNull.Value),
                                                        new SqlParameter("@idCategoria", categoria != null ? (object)categoria.Id : DBNull.Value),
                                                        new SqlParameter("@idSubcategoria", subcategoria != null ? (object)subcategoria.Id : DBNull.Value)).Single();

            return _context.Database.SqlQuery<InformeVentaPorProducto>(sqlSelect,
                                                        new SqlParameter("@FDesde", fechaDesde),
                                                        new SqlParameter("@FHasta", fechaHasta),
                                                        new SqlParameter("@idProducto", (object)idProducto ?? DBNull.Value),
                                                        new SqlParameter("@idCategoria", categoria != null ? (object)categoria.Id : DBNull.Value),
                                                        new SqlParameter("@idSubcategoria", subcategoria != null ? (object)subcategoria.Id : DBNull.Value),
                                                        new SqlParameter("@PaginaTamaño", itemsPorPagina),
                                                        new SqlParameter("@PaginaNumero", pagina)).ToList();
        }

        public IList<InformeVentaPorProducto> InformeProductoPorNombre(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, int? idProducto, Categoria categoria, SubCategoria subcategoria, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems)
        {
            string sqlCount = $@"   {InformeVentaFiltrarProducto(idSucursales)} 
                                    select count(1)
									from 
										(select 1 fila
										from Productos_filtro
										Group by Nombre, idProducto) as dato";

            string sqlSelect = $@"  {InformeVentaFiltrarProducto(idSucursales)} 
                                    select  Nombre,
                                            idProducto,
		                                    Sum(Monto) Monto,
		                                    Sum(Cantidad) Cantidad
									from
										Productos_filtro
                                    Group by
	                                    Nombre, idProducto
                                    Order by
	                                    {ordenadoPor} {ordenarDireccion.ToString()}
	                                OFFSET @PaginaTamaño * (@PaginaNumero - 1) ROWS
	                                FETCH NEXT @PaginaTamaño ROWS ONLY";

            totalItems = _context.Database.SqlQuery<int>(sqlCount,
                                                        new SqlParameter("@FDesde", fechaDesde),
                                                        new SqlParameter("@FHasta", fechaHasta),
                                                        new SqlParameter("@idProducto", (object)idProducto ?? DBNull.Value),
                                                        new SqlParameter("@idCategoria", categoria != null ? (object)categoria.Id : DBNull.Value),
                                                        new SqlParameter("@idSubcategoria", subcategoria != null ? (object)subcategoria.Id : DBNull.Value)).Single();

            return _context.Database.SqlQuery<InformeVentaPorProducto>(sqlSelect,
                                                        new SqlParameter("@FDesde", fechaDesde),
                                                        new SqlParameter("@FHasta", fechaHasta),
                                                        new SqlParameter("@idProducto", (object)idProducto?? DBNull.Value),
                                                        new SqlParameter("@idCategoria", categoria != null? (object)categoria.Id: DBNull.Value),
                                                        new SqlParameter("@idSubcategoria", subcategoria != null? (object)subcategoria.Id: DBNull.Value),
                                                        new SqlParameter("@PaginaTamaño", itemsPorPagina),
                                                        new SqlParameter("@PaginaNumero", pagina)).ToList();
        }

        public IList<InformeVentaPorProducto> InformeProductoPorCategoria(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, int? idProducto, Categoria categoria, SubCategoria subcategoria, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems)
        {
            string sqlCount = $@"   {InformeVentaFiltrarProducto(idSucursales)} 
                                    select count(1)
									from 
										(select 1 fila
										from Productos_filtro
										Group by Categoria) as dato";

            string sqlSelect = $@"  {InformeVentaFiltrarProducto(idSucursales)} 
                                    select  Categoria as Nombre,
		                                    Sum(Monto) Monto,
		                                    Sum(Cantidad) Cantidad
									from
										Productos_filtro
                                    Group by
	                                    Categoria
                                    Order by
	                                    {ordenadoPor} {ordenarDireccion.ToString()}
	                                OFFSET @PaginaTamaño * (@PaginaNumero - 1) ROWS
	                                FETCH NEXT @PaginaTamaño ROWS ONLY";

            totalItems = _context.Database.SqlQuery<int>(sqlCount,
                                                        new SqlParameter("@FDesde", fechaDesde),
                                                        new SqlParameter("@FHasta", fechaHasta),
                                                        new SqlParameter("@idProducto", (object)idProducto ?? DBNull.Value),
                                                        new SqlParameter("@idCategoria", categoria != null ? (object)categoria.Id : DBNull.Value),
                                                        new SqlParameter("@idSubcategoria", subcategoria != null ? (object)subcategoria.Id : DBNull.Value)).Single();

            return _context.Database.SqlQuery<InformeVentaPorProducto>(sqlSelect,
                                                        new SqlParameter("@FDesde", fechaDesde),
                                                        new SqlParameter("@FHasta", fechaHasta),
                                                        new SqlParameter("@idProducto", (object)idProducto ?? DBNull.Value),
                                                        new SqlParameter("@idCategoria", categoria != null ? (object)categoria.Id : DBNull.Value),
                                                        new SqlParameter("@idSubcategoria", subcategoria != null ? (object)subcategoria.Id : DBNull.Value),
                                                        new SqlParameter("@PaginaTamaño", itemsPorPagina),
                                                        new SqlParameter("@PaginaNumero", pagina)).ToList();
        }

        public IList<InformeVentaPorProducto> InformeProductoPorSubCategoria(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta, int? idProducto, Categoria categoria, SubCategoria subcategoria, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int itemsPorPagina, int pagina, out int totalItems)
        {
            string sqlCount = $@"   {InformeVentaFiltrarProducto(idSucursales)} 
                                    select count(1)
									from 
										(select 1 fila
										from Productos_filtro
										Group by Subcategoria) as dato";

            string sqlSelect = $@"  {InformeVentaFiltrarProducto(idSucursales)} 
                                    select  Subcategoria as Nombre,
		                                    Sum(Monto) Monto,
		                                    Sum(Cantidad) Cantidad
									from
										Productos_filtro
                                    Group by
	                                    Subcategoria
                                    Order by
	                                    {ordenadoPor} {ordenarDireccion.ToString()}
	                                OFFSET @PaginaTamaño * (@PaginaNumero - 1) ROWS
	                                FETCH NEXT @PaginaTamaño ROWS ONLY";

            totalItems = _context.Database.SqlQuery<int>(sqlCount,
                                                        new SqlParameter("@FDesde", fechaDesde),
                                                        new SqlParameter("@FHasta", fechaHasta),
                                                        new SqlParameter("@idProducto", (object)idProducto ?? DBNull.Value),
                                                        new SqlParameter("@idCategoria", categoria != null ? (object)categoria.Id : DBNull.Value),
                                                        new SqlParameter("@idSubcategoria", subcategoria != null ? (object)subcategoria.Id : DBNull.Value)).Single();

            return _context.Database.SqlQuery<InformeVentaPorProducto>(sqlSelect,
                                                        new SqlParameter("@FDesde", fechaDesde),
                                                        new SqlParameter("@FHasta", fechaHasta),
                                                        new SqlParameter("@idProducto", (object)idProducto ?? DBNull.Value),
                                                        new SqlParameter("@idCategoria", categoria != null ? (object)categoria.Id : DBNull.Value),
                                                        new SqlParameter("@idSubcategoria", subcategoria != null ? (object)subcategoria.Id : DBNull.Value),
                                                        new SqlParameter("@PaginaTamaño", itemsPorPagina),
                                                        new SqlParameter("@PaginaNumero", pagina)).ToList();
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
        {
            string sqlSelect = $@"  {InformeVentaFiltrarVentas(idSucursales)} 
                                    Select	sum (P.Monto - P.Descuento + P.CFT + P.IVA) Monto
                                    from
	                                    ventas_filtro V
                                        Inner Join NUEVA_VENTA_PAGOS P on V.Id = P.IdVenta";
                                    
            return _context.Database.SqlQuery<decimal>(sqlSelect,
                                            new SqlParameter("@FDesde", fechaDesde),
                                            new SqlParameter("@FHasta", fechaHasta)).Single();
        }

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

        private IQueryable<VentaPago> InformeVentaFiltrarPagos(IEnumerable<int> idSucursales, DateTime fechaDesde, DateTime fechaHasta) =>
            _context.VentaPago.Where(x => x.Venta.Anulado == false &&
                               idSucursales.Contains(x.Venta.IdSucursal) &&
                               DbFunctions.TruncateTime(x.Venta.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                               DbFunctions.TruncateTime(x.Venta.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);


        private string InformeVentaFiltrarVentas(IEnumerable<int> idSucursales)
            => $@"WITH ventas_filtro AS(
                            select *
                            from NUEVA_VENTAS V
                            where
                                Anulado = 0
                                and V.Fecha between @FDesde and @FHasta
			                    and V.IdSucursal in ({string.Join(", ", idSucursales)})
			                    )";

        private string InformeVentaFiltrarProducto(IEnumerable<int> idSucursales)
            => $@"with ventas_filtro AS(
                            select *
                            from NUEVA_VENTAS V
                            where
                                Anulado = 0
                                and V.Fecha between @FDesde and @FHasta
                                and V.IdSucursal in ({string.Join(", ", idSucursales)})
			                    ),
	                    Productos_filtro as (
                            select CAST(V.Fecha AS DATE) Fecha,
			                    VI.idProducto,
			                    P.Nombre,
			                    C.Descripcion Categoria,
                                SC.Descripcion Subcategoria,
			                    (VI.Monto + VI.IVA) * VI.Cantidad Monto,
                                VI.Cantidad
                            from
                                ventas_filtro V
                                Inner Join NUEVA_VENTA_ITEMS VI on V.Id = VI.IdVenta
                                Inner Join PRODUCTOS P on P.id_Producto = VI.IdProducto
                                Inner Join PRODUCTOS_CATEGORIAS C on C.id_Categoria = P.id_Categoria
                                Inner Join PRODUCTOS_SUBCATEGORIAS SC on SC.id_Subcategoria = P.id_Subcategoria
                            where
			                    (@idProducto IS NULL OR P.id_Producto = @idProducto) AND
			                    (@idCategoria IS NULL OR P.id_Categoria = @idCategoria) AND
			                    (@idSubcategoria IS NULL OR P.id_Subcategoria = @idSubcategoria)
			                    )";

        private string SqlMercaderia(IEnumerable<int> idSucursales) 
            => $@"with MERCADERIA as (  
                                select 
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
