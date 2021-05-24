Imports AutoMapper
Imports Modelo = Ventas.Core.Model.BaseAgreggate

Public Class MapperProfile
    Inherits Profile

    Public Sub New()
        CreateMap(Of Modelo.Producto, EntidadProductoReducido)()

        CreateMap(Of Modelo.Producto, EntidadProducto)() _
        .ForMember(Function(des) des.PrecioTigre, Sub(opt) opt.MapFrom(Function(src) src.Precios(0).Monto)) _
        .ForMember(Function(des) des.DescuentoTigre, Sub(opt) opt.MapFrom(Function(src) src.Precios(1).Monto)) _
        .ForMember(Function(des) des.PrecioCapital, Sub(opt) opt.MapFrom(Function(src) src.Precios(2).Monto)) _
        .ForMember(Function(des) des.DescuentoCapital, Sub(opt) opt.MapFrom(Function(src) src.Precios(3).Monto)) _
        .ForMember(Function(des) des.Mayorista, Sub(opt) opt.MapFrom(Function(src) src.Precios(4).Monto)) _
        .ForMember(Function(des) des.Alternativo, Sub(opt) opt.MapFrom(Function(src) src.Precios(5).Monto))
    End Sub
End Class
