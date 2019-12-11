Imports Ventas.Core.Interfaces
Imports VentaModel = Ventas.Core.Model.VentaAggregate
Imports BaseModel = Ventas.Core.Model.BaseAgreggate
Imports PedidoModelNota = Ventas.Core.Model.NotaPedidoAgreggate
Imports Ventas.Data
Imports Ventas.Data.Repository

Public Class Servicio
    Public Shared Function ObtenerListaProductos() As IList(Of BaseModel.Producto)
        Dim listaProducto As IList(Of BaseModel.Producto) = New List(Of BaseModel.Producto)
        Using context As VentaContext = New VentaContext()
            Dim productoRepository As IProductoRepository = New ProductoRepository(context)
            listaProducto = productoRepository.Obtener()
        End Using

        Return listaProducto
    End Function

    Public Shared Function ObtenerProductoCompleto(idSucursal As Integer, idProducto As Integer) As BaseModel.Producto
        Using context As VentaContext = New VentaContext()
            Dim productoRepository As IProductoRepository = New ProductoRepository(context)
            Return productoRepository.Obtener(idSucursal, idProducto)
        End Using
    End Function

    Public Shared Function ObtenerProductoPorCodigoBarrasCompleto(idSucursal As Integer, codigoBarra As String) As BaseModel.Producto
        Using context As VentaContext = New VentaContext()
            Dim productoRepository As IProductoRepository = New ProductoRepository(context)
            Return productoRepository.ObtenerPorCodigoBarras(idSucursal, codigoBarra)
        End Using
    End Function

    Public Shared Function ObtenerProductoPorCodigoCompleto(idSucursal As Integer, codigo As String) As BaseModel.Producto
        Using context As VentaContext = New VentaContext()
            Dim productoRepository As IProductoRepository = New ProductoRepository(context)
            Return productoRepository.ObtenerPorCodigo(idSucursal, codigo)
        End Using
    End Function

    Friend Shared Sub GuardarNotaPedido(notaPedidoModel As PedidoModelNota.NotaPedido)
        Using context As VentaContext = New VentaContext()
            Dim notaPedidoRepository As INotaPedidoRepository = New NotaPedidoRepository(context)
            notaPedidoRepository.Guardar(notaPedidoModel)
        End Using
    End Sub

    Public Shared Sub GuardarClienteMinorista(clienteMinorista As BaseModel.ClienteMinorista)
        Using context As VentaContext = New VentaContext()
            Dim clienteMinoristaRepository As IClienteMinoristaRepository = New ClienteMinoristaRepository(context)
            clienteMinoristaRepository.Guardar(clienteMinorista)
        End Using
    End Sub
End Class
