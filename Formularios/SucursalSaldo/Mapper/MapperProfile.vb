Imports AutoMapper
Imports Model = Ventas.Core.Model

Namespace Formularios.SucursalSaldo
    Public Class MapperProfile
        Inherits Profile

        Public Sub New()
            CreateMap(Of Model.VentaAggregate.CierreCaja, CierreCajaItem)()
        End Sub
    End Class
End Namespace
