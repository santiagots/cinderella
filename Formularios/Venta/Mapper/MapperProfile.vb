Imports AutoMapper
Imports Model = Ventas.Core.Model.VentaAggregate

Namespace Formularios.Venta
    Public Class MapperProfile
        Inherits Profile

        Public Sub New()
            CreateMap(Of Model.Venta, VentaAdministracionItemViewModel)() _
            .ForMember(Function(des) des.NumeroFactura, Sub(opt) opt.MapFrom(Function(src) String.Join(", ", src.Factura.NumeroFactura.Select(Function(x) x.Numero).ToList()))) _
            .ForMember(Function(des) des.TipoPago, Sub(opt) opt.MapFrom(Function(src) String.Join(", ", src.Pagos.Select(Function(x) x.TipoPago).ToList()))) _
            .ForMember(Function(des) des.MontoTotal, Sub(opt) opt.MapFrom(Function(src) src.MontoTotal.Valor + src.MontoTotal.Iva)) _
            .ForMember(Function(des) des.TipoFactura, Sub(opt) opt.MapFrom(Function(src) src.Factura.TipoFactura)) _
            .ForMember(Function(des) des.NombreVendedor, Sub(opt) opt.MapFrom(Function(src) src.Vendedor.ApellidoYNombre)) _
            .ForMember(Function(des) des.NombreClienteMayorista, Sub(opt) opt.MapFrom(Function(src) src.ClienteMayorista.RazonSocial)) _
            .ForMember(Function(des) des.Anulado, Sub(opt) opt.MapFrom(Function(src) src.Anulado))
        End Sub
    End Class
End Namespace