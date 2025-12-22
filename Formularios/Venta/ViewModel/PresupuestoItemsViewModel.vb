Imports Ventas.Core.Model.PresupuestoAgreggate

Namespace Formularios.Venta
    Public Class PresupuestoItemsViewModel
        Public ReadOnly PresupuestoModel As Presupuesto

        Public ReadOnly Property Id As Long
            Get
                Return PresupuestoModel.Id
            End Get
        End Property

        Public ReadOnly Property Numero As Integer
            Get
                Return PresupuestoModel.Numero
            End Get
        End Property

        Public ReadOnly Property Cliente As String
            Get
                Return If(PresupuestoModel.ClienteMayorista IsNot Nothing, PresupuestoModel.ClienteMayorista.RazonSocial, "")
            End Get
        End Property

        Public ReadOnly Property MontoTotal As Decimal
            Get
                Return PresupuestoModel.MontoTotal.toDecimal()
            End Get
        End Property

        Public ReadOnly Property Anulada As String
            Get
                Return If(PresupuestoModel.Anulado, "Si", "No")
            End Get
        End Property

        Public ReadOnly Property Fecha As DateTime
            Get
                Return PresupuestoModel.Fecha
            End Get
        End Property


        Sub New(presupuesto As Presupuesto)
            PresupuestoModel = presupuesto
        End Sub

    End Class
End Namespace
