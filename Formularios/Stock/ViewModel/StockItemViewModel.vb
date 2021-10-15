Imports Model = Stock.Core.Model.BaseAgreggate

Namespace Formularios.Stock
    Public Class StockItemViewModel
        Public Property Stock As Model.Stock

        Public Property NombreUsuario As String

        Public Property Codigo As String

        Public Property Nombre As String

        Public Property Categoria As String

        Public Property Minimo As Integer

        Public Property Optimo As Integer

        Public Property Actual As Integer

        Public Property VentaMensual As Integer

        Public Property Reservado As Integer

        Public Property Disponible As Integer

        Public Property Habilitado As Boolean

        Public Property NuevaModificacionFecha As Date

        Public Property NuevaModificacionUsuario As String

        Public Property NuevaModificacionMotivo As String

        Public ReadOnly Property UltimaModificacionFecha As Date
            Get
                Return Stock.FechaModificacion
            End Get
        End Property

        Public ReadOnly Property UltimaModificacionUsuario As String
            Get
                Return Stock.Usuario.UsuarioNombre
            End Get
        End Property

        Public ReadOnly Property UltimaModificacionMotivo As String
            Get
                Return Stock.MotivoModificacion
            End Get
        End Property


        Sub New(stock As Model.Stock, nombreUsuario As String)
            Me.Stock = stock
            Me.Codigo = stock.Producto.Codigo
            Me.Nombre = stock.Producto.Nombre
            Me.Categoria = stock.Producto.Categoria.Descripcion
            Me.NombreUsuario = nombreUsuario
            Me.Minimo = stock.Minimo
            Me.Optimo = stock.Optimo
            Me.Actual = stock.Cantidad
            Me.VentaMensual = stock.VentaMensual
            Me.Reservado = stock.Reservado
            Me.Disponible = stock.Disponible
            Me.Habilitado = stock.Habilitado
            Me.NuevaModificacionFecha = Date.Now
            Me.NuevaModificacionUsuario = nombreUsuario
        End Sub

        Sub New(nombreUsuario As String)
            Me.Stock = New Model.Stock()
            Me.NombreUsuario = nombreUsuario
            Me.Habilitado = True
            Me.NuevaModificacionFecha = Date.Now
            Me.NuevaModificacionUsuario = nombreUsuario
        End Sub

        Public Sub limpiar()
            Me.Codigo = String.Empty
            Me.Minimo = 0
            Me.Optimo = 0
            Me.Actual = 0
            Me.Reservado = 0
            Me.Disponible = 0
            Me.VentaMensual = 0
            Me.Habilitado = True
        End Sub
    End Class
End Namespace
