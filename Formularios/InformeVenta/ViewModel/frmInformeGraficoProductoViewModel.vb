Imports System.Threading.Tasks
Imports Ventas.Core.Model.InformeAggregate

Namespace Formularios.InformeVenta
    Public Class frmInformeGraficoProductoViewModel
        Inherits Comunes.Common

        Private IdSucursales As IEnumerable(Of Integer)
        Private FechaDesde As DateTime
        Private FechaHasta As DateTime

        Public Property ProductoPorNombreTopMonto As DataTable
        Public Property ProductoPorNombreTopCantidad As DataTable
        Public Property ProductoPorCategoriaTopMonto As DataTable
        Public Property ProductoPorCategoriaTopCantidad As DataTable
        Public Property ProductoSubCategoriaTopMonto As DataTable
        Public Property ProductoSubCategoriaTopCantidad As DataTable

        Sub New(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime)
            Me.IdSucursales = idSucursales
            Me.FechaDesde = fechaDesde
            Me.FechaHasta = fechaHasta

            ProductoPorNombreTopMonto = New DataTable()
            ProductoPorNombreTopMonto.Columns.Add("Detalle")
            ProductoPorNombreTopMonto.Columns.Add("Monto")

            ProductoPorNombreTopCantidad = New DataTable()
            ProductoPorNombreTopCantidad.Columns.Add("Detalle")
            ProductoPorNombreTopCantidad.Columns.Add("Monto")

            ProductoPorCategoriaTopMonto = New DataTable()
            ProductoPorCategoriaTopMonto.Columns.Add("Detalle")
            ProductoPorCategoriaTopMonto.Columns.Add("Monto")

            ProductoPorCategoriaTopCantidad = New DataTable()
            ProductoPorCategoriaTopCantidad.Columns.Add("Detalle")
            ProductoPorCategoriaTopCantidad.Columns.Add("Monto")

            ProductoSubCategoriaTopMonto = New DataTable()
            ProductoSubCategoriaTopMonto.Columns.Add("Detalle")
            ProductoSubCategoriaTopMonto.Columns.Add("Monto")

            ProductoSubCategoriaTopCantidad = New DataTable()
            ProductoSubCategoriaTopCantidad.Columns.Add("Detalle")
            ProductoSubCategoriaTopCantidad.Columns.Add("Monto")
        End Sub

        Friend Async Function CargarAsync() As Task
            Dim tareas As List(Of Task) = New List(Of Task) From {
                CargarProductoPorNombreTopMontoAsync(),
                CargarProductoPorNombreTopCantidadAsync(),
                CargarProductoPorCategoriaTopMontoAsync(),
                CargarProductoPorCategoriaTopCantidadAsync(),
                CargarProductoPorSubCategoriaTopMontoAsync(),
                CargarProductoPorSubCategoriaTopCantidadAsync()
            }

            Await Task.WhenAll(tareas)
        End Function

        Private Async Function CargarProductoPorNombreTopMontoAsync() As Task
            ProductoPorNombreTopMonto = Await CargarDatos(Async Function() As Task(Of List(Of InformeVentaPorProducto))
                                                              Dim totalItemsProductoPorNombre As Integer = 0
                                                              Return Await Task.Run(Function() Servicio.BuscarInformeProductoPorNombre(IdSucursales, FechaDesde, FechaHasta, Nothing, Nothing, Nothing, "Monto", Common.Core.Enum.OrdenadoDireccion.DESC, 10, 1, totalItemsProductoPorNombre))
                                                          End Function)
        End Function

        Private Async Function CargarProductoPorNombreTopCantidadAsync() As Task
            ProductoPorNombreTopCantidad = Await CargarDatos(Async Function() As Task(Of List(Of InformeVentaPorProducto))
                                                                 Dim totalItemsProductoPorNombre As Integer = 0
                                                                 Return Await Task.Run(Function() Servicio.BuscarInformeProductoPorNombre(IdSucursales, FechaDesde, FechaHasta, Nothing, Nothing, Nothing, "Cantidad", Common.Core.Enum.OrdenadoDireccion.DESC, 10, 1, totalItemsProductoPorNombre))
                                                             End Function)
        End Function

        Private Async Function CargarProductoPorCategoriaTopMontoAsync() As Task
            ProductoPorCategoriaTopMonto = Await CargarDatos(Async Function() As Task(Of List(Of InformeVentaPorProducto))
                                                                 Dim totalItemsProductoPorNombre As Integer = 0
                                                                 Return Await Task.Run(Function() Servicio.BuscarInformeProductoPorCategoria(IdSucursales, FechaDesde, FechaHasta, Nothing, Nothing, Nothing, "Monto", Common.Core.Enum.OrdenadoDireccion.DESC, 10, 1, totalItemsProductoPorNombre))
                                                             End Function)

        End Function

        Private Async Function CargarProductoPorCategoriaTopCantidadAsync() As Task
            ProductoPorCategoriaTopCantidad = Await CargarDatos(Async Function() As Task(Of List(Of InformeVentaPorProducto))
                                                                    Dim totalItemsProductoPorNombre As Integer = 0
                                                                    Return Await Task.Run(Function() Servicio.BuscarInformeProductoPorCategoria(IdSucursales, FechaDesde, FechaHasta, Nothing, Nothing, Nothing, "Cantidad", Common.Core.Enum.OrdenadoDireccion.DESC, 10, 1, totalItemsProductoPorNombre))
                                                                End Function)
        End Function

        Private Async Function CargarProductoPorSubCategoriaTopMontoAsync() As Task
            ProductoSubCategoriaTopMonto = Await CargarDatos(Async Function() As Task(Of List(Of InformeVentaPorProducto))
                                                                 Dim totalItemsProductoPorNombre As Integer = 0
                                                                 Return Await Task.Run(Function() Servicio.BuscarInformeProductoPorSubCategoria(IdSucursales, FechaDesde, FechaHasta, Nothing, Nothing, Nothing, "Monto", Common.Core.Enum.OrdenadoDireccion.DESC, 10, 1, totalItemsProductoPorNombre))
                                                             End Function)
        End Function

        Private Async Function CargarProductoPorSubCategoriaTopCantidadAsync() As Task
            ProductoSubCategoriaTopCantidad = Await CargarDatos(Async Function() As Task(Of List(Of InformeVentaPorProducto))
                                                                    Dim totalItemsProductoPorNombre As Integer = 0
                                                                    Return Await Task.Run(Function() Servicio.BuscarInformeProductoPorSubCategoria(IdSucursales, FechaDesde, FechaHasta, Nothing, Nothing, Nothing, "Cantidad", Common.Core.Enum.OrdenadoDireccion.DESC, 10, 1, totalItemsProductoPorNombre))
                                                                End Function)
        End Function

        Private Async Function CargarDatos(accion As Func(Of Task(Of List(Of InformeVentaPorProducto)))) As Task(Of DataTable)
            Dim informeProductoPorNombre As List(Of InformeVentaPorProducto) = Await accion()

            Dim datos As List(Of Tuple(Of String, Decimal, Integer)) = informeProductoPorNombre.Select(Function(x)
                                                                                                           Return New Tuple(Of String, Decimal, Integer)(
                                                                                                                    x.Nombre,
                                                                                                                    x.Monto,
                                                                                                                    x.Cantidad)
                                                                                                       End Function).ToList()

            Return ObtenerDT("Nombre", "Monto", "Cantidad", datos)
        End Function


        Private Function ObtenerDT(NombreColumna1 As String, NombreColumna2 As String, NombreColumna3 As String, datos As List(Of Tuple(Of String, Decimal, Integer))) As DataTable
            Dim dt As DataTable = New DataTable()
            dt.Columns.Add(NombreColumna1, GetType(String))
            dt.Columns.Add(NombreColumna2, GetType(Decimal))
            dt.Columns.Add(NombreColumna3, GetType(Integer))

            datos.ForEach(Sub(x) dt.Rows.Add(x.Item1, x.Item2, x.Item3))
            Return dt
        End Function
    End Class
End Namespace
