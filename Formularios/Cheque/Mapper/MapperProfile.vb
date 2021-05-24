Imports AutoMapper
Imports Model = Ventas.Core.Model.ChequeAggregate

Namespace Formularios.Cheque
    Public Class MapperProfile
        Inherits Profile

        Public Sub New()
            CreateMap(Of Model.Cheque, ChequeAdministracionItemViewModel)() _
            .ForMember(Function(des) des.BancoEmisor, Sub(opt) opt.MapFrom(Function(src) src.BancoEmisor.Nombre))

            CreateMap(Of Model.Cheque, ChequeDetalleViewModel)() _
            .ForMember(Function(des) des.BancoEmisorSeleccionado, Sub(opt) opt.MapFrom(Function(src) New KeyValuePair(Of Integer?, String)(src.BancoEmisor.Id, src.BancoEmisor.Nombre)))

            CreateMap(Of ChequeDetalleViewModel, ChequeAdministracionItemViewModel)() _
            .ForMember(Function(des) des.BancoEmisor, Sub(opt) opt.MapFrom(Function(src) src.BancoEmisorSeleccionado.Value))
        End Sub
    End Class
End Namespace