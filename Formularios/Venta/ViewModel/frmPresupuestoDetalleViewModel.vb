Imports System.ComponentModel
Imports AutoMapper
Imports Common.Core.Enum
Imports SistemaCinderella.Comunes
Imports Ventas.Core.Model.PresupuestoAgreggate

Namespace Formularios.Venta
    Public Class frmPresupuestoDetalleViewModel

        Public PresupuestoModel As Presupuesto

        Public ReadOnly Property Numero As Integer
            Get
                Return PresupuestoModel.Numero
            End Get
        End Property

        Public ReadOnly Property Estado As String
            Get
                Return If(PresupuestoModel.Anulado, "Anulada", "Vigente")
            End Get
        End Property

        Public ReadOnly Property CondicionPago As String
            Get
                Return PresupuestoModel.CondicionPago.ToString()
            End Get
        End Property

        Public ReadOnly Property TipoCliente As TipoCliente
            Get
                Return PresupuestoModel.TipoCliente
            End Get
        End Property

        Public ReadOnly Property Fecha As DateTime
            Get
                Return PresupuestoModel.Fecha
            End Get
        End Property

        Public ReadOnly Property IdClienteMayorista As Integer?
            Get
                Return PresupuestoModel.ClienteMayorista?.Id
            End Get
        End Property

        Public ReadOnly Property NombreClienteMayorista As String
            Get
                Return PresupuestoModel.ClienteMayorista?.RazonSocial
            End Get
        End Property

        Public ReadOnly Property EsClienteMayorista As Integer
            Get
                Return PresupuestoModel.TipoCliente = TipoCliente.Mayorista
            End Get
        End Property

        Public ReadOnly Property Vendedor As String
            Get
                Return PresupuestoModel.Vendedor.ApellidoYNombre
            End Get
        End Property

        Public ReadOnly Property Encargado As String
            Get
                Return PresupuestoModel.Encargado?.ApellidoYNombre
            End Get
        End Property

        Public Property AnuladaMotivo As String

        Public ReadOnly Property AnuladaMotivoHabilitado As Boolean
            Get
                Return Not PresupuestoModel.Anulado
            End Get
        End Property

        Public ReadOnly Property PresupuestoItems As BindingList(Of VentaItemViewModel)
            Get
                Return New BindingList(Of VentaItemViewModel)(Mapper.Map(Of List(Of VentaItemViewModel))(PresupuestoModel.PresupuestoItems))
            End Get
        End Property

        Public ReadOnly Property TotalPresupuestoItems As BindingList(Of VentaItemViewModel)
            Get
                Dim VentaItemViewModel As VentaItemViewModel = New VentaItemViewModel() With {
                    .Nombre = "Total",
                    .Iva = PresupuestoModel.MontoTotal.Iva,
                    .Monto = PresupuestoModel.MontoTotal.Valor,
                    .Total = PresupuestoModel.MontoTotal.toDecimal(),
                    .Cantidad = PresupuestoModel.PresupuestoItems.Sum(Function(x) x.Cantidad)
                    }
                Dim list As BindingList(Of VentaItemViewModel) = New BindingList(Of VentaItemViewModel)

                list.Add(VentaItemViewModel)
                Return list
            End Get
        End Property

        Sub New(presupuesto As Presupuesto)
            PresupuestoModel = presupuesto
            AnuladaMotivo = presupuesto.MotivoAnulado
        End Sub

    End Class
End Namespace
