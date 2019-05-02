Imports AutoMapper
Imports SistemaCinderella.Formularios.Reserva
Imports Ventas.Core.Enum
Imports Model = Ventas.Core.Model.VentaAggregate

Namespace Formularios.Reserva
    Public Class MapperProfile
        Inherits Profile

        Public Sub New()
            CreateMap(Of Model.Reserva, ReservaAdministracionItemsViewModel)() _
                .ForMember(Function(des) des.Nombre, Sub(opt) opt.MapFrom(Function(src) $"{src.Apellido} {src.Nombre}".Trim()))

            CreateMap(Of Model.Reserva, ReservaDetalleViewModel)() _
                .ForMember(Function(des) des.EnvioNovedades, Sub(opt) opt.Ignore()) _
                .ForMember(Function(des) des.NoEnvioNovedades, Sub(opt) opt.Ignore()) _
                .ForMember(Function(des) des.MetodoEntrega, Sub(opt) opt.Ignore()) _
                .ForMember(Function(des) des.MetodoEntregaSeleccionado, Sub(opt) opt.MapFrom(Function(src) New KeyValuePair(Of ReservaMetodoEntrega?, String)(src.MetodoEntrega, src.MetodoEntrega.ToString())))
        End Sub
    End Class
End Namespace
