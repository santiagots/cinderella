Imports AutoMapper
Imports Model = Common.Core.Model

Namespace Formularios.CuentaBancaria
    Public Class MapperProfile
        Inherits Profile

        Public Sub New()
            CreateMap(Of CuentaBancariaViewModel, Model.CuentaBancaria)() _
            .ForPath(Function(des) des.IdBanco, Sub(opt) opt.MapFrom(Function(src) src.BancoSeleccionado.Key.Id))

            CreateMap(Of Model.CuentaBancaria, CuentaBancariaViewModel)() _
            .ForPath(Function(des) des.BancoNombre, Sub(opt) opt.MapFrom(Function(src) src.Banco.Nombre)) _
            .ForMember(Function(des) des.BancoSeleccionado, Sub(opt) opt.MapFrom(Function(src) New KeyValuePair(Of Model.Banco, String)(src.Banco, src.Banco.Nombre)))
        End Sub
    End Class
End Namespace
