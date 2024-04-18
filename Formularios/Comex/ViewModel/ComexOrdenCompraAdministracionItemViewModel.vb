Imports Comex.Core.Enum
Imports Comex.Core.Model.ComexAggregate

Namespace Formularios.Comex
    Public Class ComexOrdenCompraAdministracionItemViewModel

        Public ReadOnly OrdenCompra As OrdenCompra

        Public ReadOnly Property Numero As String
            Get
                Return OrdenCompra.Id
            End Get
        End Property

        Public ReadOnly Property Sucursal As String
            Get
                Return OrdenCompra.Sucursal.Nombre
            End Get
        End Property

        Public ReadOnly Property Usuario As String
            Get
                Return OrdenCompra.Encargado.ToString()
            End Get
        End Property

        Public ReadOnly Property Supplier As String
            Get
                Return OrdenCompra.Supplier.Nombre
            End Get
        End Property

        Public ReadOnly Property Fecha As DateTime
            Get
                Return OrdenCompra.Fecha
            End Get
        End Property

        Public ReadOnly Property TerminosDePago As String
            Get
                Return OrdenCompra.TerminosDePago
            End Get
        End Property

        Public ReadOnly Property PenalidadesPorDemora As String
            Get
                Return OrdenCompra.PenalidadesPorDemora
            End Get
        End Property

        Public ReadOnly Property FechaDeEnvio As String
            Get
                Return OrdenCompra.FechaDeEnvio
            End Get
        End Property

        Public ReadOnly Property Estado As EstadoOrdenCompra
            Get
                Return OrdenCompra.Estado
            End Get
        End Property

        Sub New(ordenCompra As OrdenCompra)
            Me.OrdenCompra = ordenCompra
        End Sub
    End Class
End Namespace
