Imports AutoMapper
Imports Common.Core.Model
Imports Producto.Core.Model.ProductoAgreggate
Imports Model = Producto.Core.Model.ProductoAgreggate


Namespace Formularios.Producto
    Public Class MapperProfile
        Inherits Profile

        Public Sub New()
            CreateMap(Of Model.Producto, ProductoItemViewModel)() _
            .ForMember(Function(des) des.Categoria, Sub(opt) opt.MapFrom(Function(src) src.Categoria.Descripcion)) _
            .ForMember(Function(des) des.Subcategoria, Sub(opt) opt.MapFrom(Function(src) src.Subcategoria.Descripcion)) _
            .ForMember(Function(des) des.Proveedore, Sub(opt) opt.MapFrom(Function(src) src.Proveedor.RazonSocial)) _
            .AfterMap(Sub(src As Model.Producto, des As ProductoItemViewModel)
                          des.ListaTigre = If(src.Precios.Count >= 1, src.Precios(0).Monto, 0)
                          des.PorcentajeDescuentoTigre = If(src.Precios.Count >= 2, src.Precios(1).Monto, 0)
                          des.ListaCapital = If(src.Precios.Count >= 3, src.Precios(2).Monto, 0)
                          des.PorcentajeDescuentoCapital = If(src.Precios.Count >= 4, src.Precios(3).Monto, 0)
                          des.Mayorista = If(src.Precios.Count >= 5, src.Precios(4).Monto, 0)
                          des.Alternativo = If(src.Precios.Count >= 6, src.Precios(5).Monto, 0)
                      End Sub)

            CreateMap(Of Model.Producto, ProductoDetalleViewModel)() _
            .ForMember(Function(des) des.FotoRuta, Sub(opt) opt.MapFrom(Function(src) src.Foto)) _
            .ForMember(Function(des) des.Foto, Sub(opt) opt.Ignore()) _
            .AfterMap(Sub(src As Model.Producto, des As ProductoDetalleViewModel)
                          des.ListaTigre = If(src.Precios.Count >= 1, src.Precios(0).Monto, 0)
                          des.PorcentajeDescuentoTigre = If(src.Precios.Count >= 2, src.Precios(1).Monto, 0)
                          des.ListaCapital = If(src.Precios.Count >= 3, src.Precios(2).Monto, 0)
                          des.PorcentajeDescuentoCapital = If(src.Precios.Count >= 4, src.Precios(3).Monto, 0)
                          des.Mayorista = If(src.Precios.Count >= 5, src.Precios(4).Monto, 0)
                          des.Alternativo = If(src.Precios.Count >= 6, src.Precios(5).Monto, 0)
                      End Sub)

            CreateMap(Of SubCategoria, SubcategoriaItemViewModel)() _
            .ForMember(Function(des) des.CategoriaNombre, Sub(opt) opt.MapFrom(Function(src) src.Categoria.Descripcion)) _
            .ForMember(Function(des) des.SubcategoriaNombre, Sub(opt) opt.MapFrom(Function(src) src.Descripcion)) _
            .ForMember(Function(des) des.IVA, Sub(opt) opt.MapFrom(Function(src) src.IVA.Valor.ToString("p")))


            CreateMap(Of Model.Color, ColorItemViewModel)().ReverseMap()

            CreateMap(Of Model.TipoProducto, TipoProductoItemViewModel)().ReverseMap()

            CreateMap(Of Supplier, SupplierItemViewModel)().ReverseMap()

        End Sub
    End Class
End Namespace
