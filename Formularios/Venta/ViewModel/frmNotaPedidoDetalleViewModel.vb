Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports SistemaCinderella.Comunes
Imports SistemaCinderella.Formularios.Venta.frmVentasViewModel
Imports Ventas.Core.Enum
Imports Ventas.Core.Model.BaseAgreggate
Imports Ventas.Core.Model.NotaPedidoAgreggate
Imports Ventas.Core.Model.ValueObjects
Imports Ventas.Data.Service
Imports ModelBase = Ventas.Core.Model.BaseAgreggate

Namespace Formularios.Venta
    Public Class frmNotaPedidoDetalleViewModel
        Inherits Comunes.Common

        Private NotaPedidoModel As NotaPedido
        Private Productos As List(Of ModelBase.Producto) = New List(Of ModelBase.Producto)
        Private IdPrecioLista As Integer
        Private IdSucursal As Integer

        Private StockInsuficienteEvent As StockInsuficienteDelegate
        Private CargarProductoNombreyCodigoEvent As CargarProductoNombreyCodigoDelegate

        Private newPropertyValue As String
        Public ReadOnly Property Numero As Integer
            Get
                Return NotaPedidoModel.Numero
            End Get
        End Property

        Public ReadOnly Property Estado As NotaPedidoEstado
            Get
                Return NotaPedidoModel.Estado
            End Get
        End Property

        Public ReadOnly Property TipoCliente As TipoCliente
            Get
                Return NotaPedidoModel.TipoCliente
            End Get
        End Property

        Public ReadOnly Property Fecha As DateTime
            Get
                Return NotaPedidoModel.Fecha
            End Get
        End Property

        Public ReadOnly Property Cliente As String
            Get
                Return NotaPedidoModel.ClienteMayorista?.RazonSocial
            End Get
        End Property

        Public ReadOnly Property PorcentajeFacturacion As Decimal
            Get
                Return NotaPedidoModel.PorcentajeFacturacion
            End Get
        End Property

        Public ReadOnly Property Vendedor As String
            Get
                Return NotaPedidoModel.Vendedor.ApellidoYNombre
            End Get
        End Property

        Public ReadOnly Property Encargado As String
            Get
                Return NotaPedidoModel.Encargado?.ApellidoYNombre
            End Get
        End Property

        Public ReadOnly Property NotaPedidoItems As BindingList(Of VentaItemViewModel)
            Get
                Return New BindingList(Of VentaItemViewModel)(Mapper.Map(Of List(Of VentaItemViewModel))(NotaPedidoModel.NotaPedidoItems.Where(Function(x) Not x.Borrado)))
            End Get
        End Property

        Public ReadOnly Property TotalNotaPedidoItems As BindingList(Of VentaItemViewModel)
            Get
                Dim VentaItemViewModel As VentaItemViewModel = New VentaItemViewModel() With {
                    .Nombre = "Total",
                    .Iva = NotaPedidoModel.MontoTotal.Iva,
                    .Monto = NotaPedidoModel.MontoTotal.Valor,
                    .Total = NotaPedidoModel.MontoTotal.toDecimal()
                    }
                Dim list As BindingList(Of VentaItemViewModel) = New BindingList(Of VentaItemViewModel)

                list.Add(VentaItemViewModel)
                Return list
            End Get
        End Property

        Public Property PorcentajeBonificacion As Decimal

        Public Property NombreCodigoProductoBusqueda As String

        Public ReadOnly Property HistorialComentarios As String
            Get
                Return NotaPedidoModel.Comentarios
            End Get
        End Property

        Public ReadOnly Property HabilitarModificar As Boolean
            Get
                Return NotaPedidoModel.Estado = NotaPedidoEstado.Ingresada
            End Get
        End Property

        Public ReadOnly Property HabilitarAnular As Boolean
            Get
                Return NotaPedidoModel.Estado <> NotaPedidoEstado.Anulada AndAlso
                                (NotaPedidoModel.Estado = NotaPedidoEstado.Ingresada OrElse
                                 NotaPedidoModel.Estado = NotaPedidoEstado.Venta OrElse
                                 NotaPedidoModel.Estado = NotaPedidoEstado.Envio)
            End Get
        End Property

        Public ReadOnly Property HabilitarArmado As Boolean
            Get
                Return NotaPedidoModel.Estado = NotaPedidoEstado.Ingresada
            End Get
        End Property

        Public ReadOnly Property HabilitarVolverAArmado As Boolean
            Get
                Return NotaPedidoModel.Estado = NotaPedidoEstado.Venta
            End Get
        End Property

        Public ReadOnly Property HabilitarVenta As Boolean
            Get
                Return NotaPedidoModel.Estado = NotaPedidoEstado.Venta
            End Get
        End Property

        Public ReadOnly Property HabilitarEnvio As Boolean
            Get
                Return NotaPedidoModel.Estado = NotaPedidoEstado.Envio
            End Get
        End Property

        Public ReadOnly Property HabilitarEdicionDeProductos As Boolean
            Get
                Return NotaPedidoModel.Estado = NotaPedidoEstado.Ingresada OrElse NotaPedidoModel.Estado = NotaPedidoEstado.Venta
            End Get
        End Property

        Public Property Comentario As String = String.Empty

        Dim _Visible As Boolean
        Public Property Visible As Boolean
            Set(value As Boolean)
                _Visible = value
                NotifyPropertyChanged(NameOf(Me.Visible))
            End Set
            Get
                Return _Visible
            End Get
        End Property

        Sub New(idSucursal As Integer, notaPedido As NotaPedido, idListaPrecioMinorista As Integer, idListaPrecioMayorista As Integer, cargarProductoNombreyCodigo As CargarProductoNombreyCodigoDelegate, stockInsuficiente As StockInsuficienteDelegate)
            Visible = True
            Me.IdSucursal = idSucursal
            NotaPedidoModel = notaPedido
            IdPrecioLista = If(notaPedido.TipoCliente = TipoCliente.Mayorista, idListaPrecioMayorista, idListaPrecioMinorista)
            Me.CargarProductoNombreyCodigoEvent = cargarProductoNombreyCodigo
            Me.StockInsuficienteEvent = stockInsuficiente
        End Sub

        Friend Sub AgregaItemNotaPedido()
            Dim producto As ModelBase.Producto = Productos.FirstOrDefault(Function(x) x.Codigo.ToUpper() = NombreCodigoProductoBusqueda.ToUpper() _
                                                                                        OrElse x.Nombre.ToUpper() = NombreCodigoProductoBusqueda.ToUpper() _
                                                                                        OrElse x.CodigoBarra.ToUpper() = NombreCodigoProductoBusqueda.ToUpper())

            If (producto Is Nothing) Then
                Throw New NegocioException("El producto ingresado no existe")
            End If

            producto = GuardarProductoCompletoEnListaDeProductos(producto)

            Dim CantidadUnidadesDeProducto As Integer = NotaPedidoModel.ObtenerCantidadDeUnidadesDeProducto(producto.Codigo) + 1
            If Not HaySotck(producto, CantidadUnidadesDeProducto) Then
                Exit Sub
            End If

            If (CantidadUnidadesDeProducto = 0) Then
                NotaPedidoModel.QuitarNotaPedidoItems(producto.Codigo)
            Else
                Dim montoProducto As MontoProducto = producto.ObtenerMonto(IdPrecioLista, TipoCliente, PorcentajeFacturacion)

                Dim porcentejeBonificacion As Decimal = 0
                If (TipoCliente = TipoCliente.Minorista) Then
                    porcentejeBonificacion = producto.ObtenerBonificacion(IdPrecioLista, TipoCliente)
                Else
                    porcentejeBonificacion = NotaPedidoModel.NotaPedidoItems?.First().PorcentajeBonificacion
                End If

                NotaPedidoModel.AgregaNotaPedidoItem(producto, montoProducto, CantidadUnidadesDeProducto, porcentejeBonificacion, PorcentajeFacturacion, TipoCliente)
            End If

            NombreCodigoProductoBusqueda = String.Empty

            AgregarComentario($"Se agrega el producto {producto.Codigo}.")

            NotifyPropertyChanged(NameOf(Me.NotaPedidoItems))
            NotifyPropertyChanged(NameOf(Me.TotalNotaPedidoItems))
            NotifyPropertyChanged(NameOf(Me.NombreCodigoProductoBusqueda))

        End Sub

        Friend Sub ActualizarItemNotaPedido(ventaItemViewModel As VentaItemViewModel, verificarStock As Boolean)
            Dim producto As ModelBase.Producto = Productos.FirstOrDefault(Function(x) x.Codigo = ventaItemViewModel.Codigo)

            If verificarStock AndAlso Not HaySotck(producto, ventaItemViewModel.Cantidad) Then
                Exit Sub
            End If

            NotaPedidoModel.ActualizaNotaPedidoItem(ventaItemViewModel.Codigo,
                                               ventaItemViewModel.Monto,
                                               ventaItemViewModel.Cantidad,
                                               ventaItemViewModel.PorcentajeBonificacion,
                                               PorcentajeFacturacion,
                                               TipoCliente)

            AgregarComentario($"Se modifica el producto {producto.Codigo}.")

            NotifyPropertyChanged(NameOf(Me.NotaPedidoItems))
            NotifyPropertyChanged(NameOf(Me.TotalNotaPedidoItems))
        End Sub

        Friend Sub QuitarItemNotaPedido(ventaItemViewModel As VentaItemViewModel)

            AgregarComentario($"Se quita el producto {ventaItemViewModel.Codigo}.")

            NotaPedidoModel.QuitarNotaPedidoItems(ventaItemViewModel.Codigo)
            NotifyPropertyChanged(NameOf(Me.NotaPedidoItems))
            NotifyPropertyChanged(NameOf(Me.TotalNotaPedidoItems))
        End Sub

        Friend Async Function CargarProductoNombreYCodigoAsync() As Task
            If (CargarProductoNombreyCodigoEvent IsNot Nothing) Then

                Productos = Await Task.Run(Function() Servicio.ObtenerListaProductos())

                Dim NombreCodigoProductos As List(Of String) = New List(Of String)
                Productos.ToList().ForEach(Sub(x) NombreCodigoProductos.Add(x.Codigo))
                Productos.ToList().ForEach(Sub(x) NombreCodigoProductos.Add(x.Nombre))

                CargarProductoNombreyCodigoEvent(NombreCodigoProductos)
            End If
        End Function

        Friend Async Function Anular() As Task
            NotaPedidoModel.Anular(Comentario, VariablesGlobales.objUsuario.Usuario)
            Await NotaPedidoService.ActualizarAsync(NotaPedidoModel)
        End Function

        Friend Async Function GuardarFinalizadoAsync() As Task
            NotaPedidoModel.Actualizar(Comentario, VariablesGlobales.objUsuario.Usuario)
            Await NotaPedidoService.ActualizarAsync(NotaPedidoModel)
        End Function

        Friend Async Function ArmadoFinalizadoAsync() As Task
            NotaPedidoModel.ArmadoFinalizado(Comentario, VariablesGlobales.objUsuario.Usuario)
            Await NotaPedidoService.ActualizarAsync(NotaPedidoModel)

            Comentario = String.Empty

            NotifyPropertyChanged(NameOf(Me.NotaPedidoItems))
        End Function

        Friend Sub PorcentajeBonificacionChange(porcentajeBonificacion As Decimal)
            If (Me.PorcentajeBonificacion <> porcentajeBonificacion) Then
                Me.PorcentajeBonificacion = porcentajeBonificacion

                For Each notaPedidoItem As NotaPedidoItem In NotaPedidoModel.NotaPedidoItems
                    NotaPedidoModel.ActualizaNotaPedidoItem(notaPedidoItem.Producto.Codigo, notaPedidoItem.MontoProducto.Valor, notaPedidoItem.Cantidad, porcentajeBonificacion, PorcentajeFacturacion, TipoCliente)
                    AgregarComentario($"Se modifica el producto {notaPedidoItem.Producto.Codigo}.")
                Next

                NotifyPropertyChanged(NameOf(Me.NotaPedidoItems))
            End If
        End Sub

        Friend Sub RealizarVenta(mdiParent As Form)
            Dim frmVentas As frmVentas = New frmVentas(NotaPedidoModel, AddressOf RealizarVentaCallback)
            frmVentas.MdiParent = mdiParent
            frmVentas.Show()
            Visible = False
        End Sub

        Friend Async Function EnvioFinalizadoAsync() As Task
            NotaPedidoModel.EnvioFinalizado(Comentario, VariablesGlobales.objUsuario.Usuario)
            Await NotaPedidoService.ActualizarAsync(NotaPedidoModel)

            Comentario = String.Empty

            NotifyPropertyChanged(NameOf(Me.NotaPedidoItems))
        End Function

        Friend Sub ImprimirNotaPedido(MdiParent As Form)
            Dim frmReporteResumenReserva As frmReporteTransaccion = New frmReporteTransaccion("Resumen de Nota Pedido",
                                                                                                    1,
                                                                                                    NotaPedidoModel.TipoCliente,
                                                                                                    NotaPedidoModel.Vendedor.ApellidoYNombre,
                                                                                                    If(NotaPedidoModel.ClienteMinorista IsNot Nothing, NotaPedidoModel.ClienteMinorista.ApellidoYNombre, If(NotaPedidoModel.ClienteMayorista IsNot Nothing, NotaPedidoModel.ClienteMayorista.RazonSocial, "")),
                                                                                                    NotaPedidoModel.Fecha,
                                                                                                    NotaPedidoModel.NotaPedidoItems.Cast(Of TransaccionItem).ToList(),
                                                                                                    Nothing)
            frmReporteResumenReserva.MdiParent = MdiParent
            frmReporteResumenReserva.Show()
        End Sub

        Friend Async Function VolverAEstadoIngresadoAsync() As Task
            NotaPedidoModel.VolverAIngresada(Comentario, VariablesGlobales.objUsuario.Usuario)
            Await NotaPedidoService.ActualizarAsync(NotaPedidoModel)

            Comentario = String.Empty

            NotifyPropertyChanged(NameOf(Me.NotaPedidoItems))
        End Function

        Private Function GuardarProductoCompletoEnListaDeProductos(producto As ModelBase.Producto) As ModelBase.Producto
            If (producto.Stock Is Nothing) Then
                Dim productoCompleto As ModelBase.Producto = Servicio.ObtenerProductoCompleto(IdSucursal, producto.Id)
                Productos(Productos.IndexOf(producto)) = productoCompleto
                producto = productoCompleto
            End If

            Return producto
        End Function

        Private Function HaySotck(producto As ModelBase.Producto, ByRef CantidadUnidadesDeProducto As Integer) As Boolean
            Dim stockInsuficienteConfirmacion As Boolean = False

            If (CantidadUnidadesDeProducto > 0 AndAlso Not producto.HayStock(CantidadUnidadesDeProducto)) Then
                stockInsuficienteConfirmacion = StockInsuficienteEvent(producto.Codigo, CantidadUnidadesDeProducto, producto.Stock.Cantidad)
            End If

            Return True
        End Function

        Private Sub AgregarComentario(nuevoComentario As String)
            nuevoComentario = If(Not String.IsNullOrWhiteSpace(Comentario), Environment.NewLine, String.Empty) + nuevoComentario
            If (Not Comentario.Contains(nuevoComentario)) Then
                Comentario += nuevoComentario
            End If
        End Sub

        Public Async Function RealizarVentaCallback() As Task
            Visible = True
            NotaPedidoModel = Await NotaPedidoService.ObtenerAsync(NotaPedidoModel.Id)

            NotifyPropertyChanged(NameOf(Me.NotaPedidoItems))
        End Function
    End Class
End Namespace
