Imports AutoMapper
Imports Model = Ventas.Core.Model

Namespace Formularios.MovimientoDetalle
    Public Class MapperProfile
        Inherits Profile

        Public Sub New()
            CreateMap(Of Model.VentaAggregate.Venta, MovimientoVenta)() _
            .ForMember(Function(des) des.Fecha, Sub(opt) opt.MapFrom(Function(src) String.Join(", ", src.Fecha))) _
            .ForMember(Function(des) des.Monto, Sub(opt) opt.MapFrom(Function(src) src.PagoTotal.Total)) _
            .ForMember(Function(des) des.Encargado, Sub(opt) opt.MapFrom(Function(src) src.Encargado.ApellidoYNombre)) _
            .ForMember(Function(des) des.Vendedro, Sub(opt) opt.MapFrom(Function(src) src.Vendedor.ApellidoYNombre)) _
            .ForMember(Function(des) des.TipoPago, Sub(opt) opt.MapFrom(Function(src) String.Join(", ", src.Pagos.Select(Function(x) x.TipoPago).ToList()))) _
            .ForMember(Function(des) des.TipoCliente, Sub(opt) opt.MapFrom(Function(src) src.TipoCliente)) _
            .ForMember(Function(des) des.TipoFactura, Sub(opt) opt.MapFrom(Function(src) If(src.Factura IsNot Nothing, src.Factura.TipoFactura, String.Empty))) _
            .ForMember(Function(des) des.NumeroFactura, Sub(opt) opt.MapFrom(Function(src) String.Join(", ", src.Factura.NumeroFactura.Select(Function(x) x.Numero).ToList())))

            CreateMap(Of Model.VentaAggregate.CierreCaja, MovimientoCaja)()
        End Sub
    End Class
End Namespace
