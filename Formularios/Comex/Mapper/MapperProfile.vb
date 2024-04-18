Imports AutoMapper
Imports Model = Comex.Core.Model.ComexAggregate

Namespace Formularios.Comex
    Public Class MapperProfile
        Inherits Profile

        Public Sub New()
            CreateMap(Of Model.OrdenCompraItem, ComexOrdenCompraItemsViewModel)() _
                .ForMember(Function(des) des.Nombre, Sub(opt) opt.MapFrom(Function(src) src.Producto.Nombre)) _
                .ForMember(Function(des) des.Codigo, Sub(opt) opt.MapFrom(Function(src) src.Producto.Codigo)) _
                .ForMember(Function(des) des.Modelo, Sub(opt) opt.MapFrom(Function(src) src.Producto.Modelo)) _
                .ForMember(Function(des) des.BoxQTY, Sub(opt) opt.MapFrom(Function(src) src.CantidadCajas)) _
                .ForMember(Function(des) des.SupplierCode, Sub(opt) opt.MapFrom(Function(src) src.Producto.SupplierProductCode)) _
                .ForMember(Function(des) des.ProductType, Sub(opt) opt.MapFrom(Function(src) src.Producto.ProductType.Nombre)) _
                .ForMember(Function(des) des.Color, Sub(opt) opt.MapFrom(Function(src) src.Producto.Color.Nombre)) _
                .ForMember(Function(des) des.BoxSize, Sub(opt) opt.MapFrom(Function(src) $"{src.Producto.BoxSize.X} X {src.Producto.BoxSize.Y} X {src.Producto.BoxSize.Z}")) _
                .ForMember(Function(des) des.ProductSize, Sub(opt) opt.MapFrom(Function(src) $"{src.Producto.ProductSize.X} X {src.Producto.ProductSize.Y} X {src.Producto.ProductSize.Z}"))
        End Sub

    End Class

End Namespace
