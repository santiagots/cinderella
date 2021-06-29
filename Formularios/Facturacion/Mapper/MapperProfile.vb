Imports AutoMapper
Imports Model = Ventas.Core.Model.VentaAggregate
Imports Ventas.Core.Model.RemitoAgreggate

Namespace Formularios.Facturacion
    Public Class MapperProfile
        Inherits Profile

        Public Sub New()
            CreateMap(Of Model.Factura, DocumentoFiscalViewModel)() _
            .ForMember(Function(des) des.Numero, Sub(opt) opt.MapFrom(Function(src) String.Join(", ", src.NumeroFactura.Select(Function(x) x.Numero).ToList()))) _
            .ForMember(Function(des) des.FechaVenciminetoCAE, Sub(opt) opt.MapFrom(Function(src) src.FechaVencimientoCAE))

            CreateMap(Of Model.NotaCredito, DocumentoFiscalViewModel)() _
            .ForMember(Function(des) des.Numero, Sub(opt) opt.MapFrom(Function(src) String.Join(", ", src.NumeroNotaCredito.Select(Function(x) x.Numero).ToList()))) _
            .ForMember(Function(des) des.FechaVenciminetoCAE, Sub(opt) opt.MapFrom(Function(src) src.FechaVencimientoCAE))
        End Sub
    End Class
End Namespace
