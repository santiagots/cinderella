Imports System.ServiceModel
Imports NotaPedidoModel = Ventas.Core.Model.NotaPedidoAgreggate
Imports BaseModel = Ventas.Core.Model.BaseAgreggate
Imports Entidades
Imports Common.Core.Helper
Imports Newtonsoft.Json

<ServiceBehavior(IncludeExceptionDetailInFaults:=True, UseSynchronizationContext:=False)>
Public Class NotaPedido
    Implements INotaPedido

    Public Delegate Function NuevaNotaPedidoDelegate() As Task
    Public Shared AgregarNotaPedidoService As NuevaNotaPedidoDelegate

    Sub AgregarNotaPedido(ByVal notaPedido As EntidadNotaPedido, ByVal EntConsumidorFinal As EntidadConsumidorFinal) Implements INotaPedido.AgregarNotaPedido
        Try
            Dim notaPedidoModel As NotaPedidoModel.NotaPedido = New NotaPedidoModel.NotaPedido(notaPedido.IdSucursal)
            notaPedidoModel.AgregarVendedor(notaPedido.IdEmpleado)
            notaPedidoModel.AgregarTipoCliente(notaPedido.TipoCliente)

            If (notaPedido.TipoCliente = Common.Core.Enum.TipoCliente.Mayorista) Then
                notaPedidoModel.AgregarClienteMayorista(notaPedido.IdCliente)
            Else
                If (EntConsumidorFinal IsNot Nothing) Then
                    Dim ClienteMinorista As BaseModel.ClienteMinorista = New BaseModel.ClienteMinorista(EntConsumidorFinal.Nombre, EntConsumidorFinal.Apellido)
                    Servicio.GuardarClienteMinorista(ClienteMinorista)

                    notaPedidoModel.AgregarClienteMinorista(ClienteMinorista.Id)
                End If
            End If

            For Each item As EntidadNotaPedidoItems In notaPedido.Items
                Dim producto As BaseModel.Producto = Servicio.ObtenerProductoPorCodigoCompleto(notaPedido.IdSucursal, item.CodigoProducto)
                notaPedidoModel.AgregaNotaPedidoItem(producto, item.Precio, item.Cantidad, item.PorcentajeBonificacion, 1, notaPedido.TipoCliente)
            Next

            'Doy de alta el consumidor final y lo relaciono a la nota de pedido
            Dim consumidorFinal As Entidades.ConsumidorFinal = New Entidades.ConsumidorFinal()

            Servicio.GuardarNotaPedido(notaPedidoModel)

            AgregarNotaPedidoService()
        Catch ex As Exception
            Log.Error(ex)
            Throw
        End Try
    End Sub
End Class
