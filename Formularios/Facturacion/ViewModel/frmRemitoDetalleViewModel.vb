Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Model
Imports Common.Data.Service
Imports SistemaCinderella.Comunes
Imports Ventas.Core.Model.RemitoAgreggate
Imports Common.Core.Extension
Imports VentaModel = Ventas.Core.Model.VentaAggregate
Imports Ventas.Core.Model.ValueObjects
Imports Ventas.Data.Service
Imports Common.Core.Exceptions

Namespace Formularios.Facturacion

    Public Class frmRemitoDetalleViewModel
        Inherits Comunes.Common

        Private VentaModel As VentaModel.Venta
        Private RemitoModel As Remito

        Public Property RemitoItems As BindingList(Of RemitoItemViewModel) = New BindingList(Of RemitoItemViewModel)()

        Public ReadOnly Property TotalRemitoItems As BindingList(Of RemitoItemViewModel)
            Get
                Dim RemitoItemViewModel As RemitoItemViewModel = New RemitoItemViewModel() With {.Nombre = "Total",
                                                                                              .Cantidad = RemitoItems.Sum(Function(x) x.Cantidad),
                                                                                              .Monto = RemitoItems.Sum(Function(x) x.Monto),
                                                                                              .Total = RemitoItems.Sum(Function(x) x.Total)}
                Dim list As BindingList(Of RemitoItemViewModel) = New BindingList(Of RemitoItemViewModel)

                list.Add(RemitoItemViewModel)
                Return list
            End Get
        End Property

        Public Property Numero As Integer
        Public Property ClienteNombre As String
        Public ReadOnly Property ClienteCondicionIva As BindingList(Of CondicionIVA)
            Get
                Return New BindingList(Of CondicionIVA)([Enum](Of CondicionIVA).ToList())
            End Get
        End Property
        Public Property ClienteCondicionIvaSeleccionada As CondicionIVA
        Public Property ClienteCUIT As String
        Public Property ClienteDireccion As String
        Public Property ClienteLocalidad As String

        Public Property DespachoImportacion As String

        Public Property TrasporteNombre As String
        Public Property TrasporteDireccion As String
        Public Property TrasporteLocalidad As String

        Public Property CantidadBultos As Integer
        Public Property IncluyeFactura As Boolean

        Public ReadOnly Property HabilitarImprimir As Boolean
            Get
                Return RemitoModel IsNot Nothing
            End Get
        End Property

        Public ReadOnly Property HabilitarGuardar As Boolean
            Get
                Return RemitoModel Is Nothing
            End Get
        End Property

        Sub New(venta As VentaModel.Venta)
            VentaModel = venta
        End Sub

        Sub New(remito As Remito, venta As VentaModel.Venta)
            RemitoModel = remito
            VentaModel = venta
        End Sub

        Friend Sub ActualizarItemRemito(RemitoItemViewModel As RemitoItemViewModel)

            Dim index As Integer = RemitoItems.ToList().FindIndex(Function(x) x.Codigo = RemitoItemViewModel.Codigo)
            If (index <> -1) Then
                RemitoItems(index).Codigo = RemitoItemViewModel.Codigo
                RemitoItems(index).Nombre = RemitoItemViewModel.Nombre
                RemitoItems(index).Cantidad = RemitoItemViewModel.Cantidad
                RemitoItems(index).Monto = RemitoItemViewModel.Monto
                RemitoItems(index).Total = RemitoItemViewModel.Cantidad * RemitoItemViewModel.Monto
            End If

            NotifyPropertyChanged(NameOf(Me.RemitoItems))
            NotifyPropertyChanged(NameOf(Me.TotalRemitoItems))
        End Sub

        Friend Sub AgregarTrasporte(transporte As Transporte)
            TrasporteNombre = transporte.RazonSocial
            TrasporteDireccion = transporte.Domicilio.Direccion
            TrasporteLocalidad = $"{transporte.Domicilio.Localidad.Descripcion} - {transporte.Domicilio.Provincia.Descripcion} ({transporte.Domicilio.CodigoPostal})"

            NotifyPropertyChanged(NameOf(Me.TrasporteNombre))
        End Sub

        Friend Async Function InicializarDatosAsync() As Task
            If (RemitoModel IsNot Nothing) Then 'cargo un remito existente
                AgregarProductosDesdeRemito()
                CargarClienteMayoristaDesdeRemito()
            Else 'cargo un remito nuevo
                AgregarProductosDesdeVenta()

                If VentaModel.TipoCliente = TipoCliente.Mayorista Then
                    Await CargarClienteMayoristaDesdeVentaAsync()
                End If
            End If
        End Function

        Private Sub AgregarProductosDesdeVenta()
            RemitoItems.Add(New RemitoItemViewModel With {.Codigo = "XXX",
                                                              .Nombre = "Artículos de Decoración Varios",
                                                              .Cantidad = 1,
                                                              .Monto = VentaModel.MontoTotal.toDecimal(),
                                                              .Total = VentaModel.MontoTotal.toDecimal()})
        End Sub

        Private Sub AgregarProductosDesdeRemito()

            For Each RemitoItem As RemitoItem In RemitoModel.RemitoItems
                RemitoItems.Add(New RemitoItemViewModel With {.Id = RemitoItem.Id,
                                                  .Codigo = RemitoItem.Codigo,
                                                  .Nombre = RemitoItem.Nombre,
                                                  .Cantidad = RemitoItem.Cantidad,
                                                  .Monto = RemitoItem.Monto.Valor,
                                                  .Total = RemitoItem.Total.Valor})
            Next
        End Sub

        Public Async Function CargarClienteMayoristaDesdeVentaAsync() As Task
            Dim clienteMayorista As ClienteMayorista = Await ClienteMayoristaService.ObtenerAsync(TipoBase.Local, VentaModel.ClienteMayorista.Id)

            ClienteNombre = clienteMayorista.RazonSocial
            ClienteCondicionIvaSeleccionada = clienteMayorista.CondicionIVA
            ClienteCUIT = clienteMayorista.Cuit
            DespachoImportacion = String.Empty

            If (clienteMayorista.DomicilioEntrega IsNot Nothing) Then
                ClienteDireccion = clienteMayorista.DomicilioEntrega.Direccion
                ClienteLocalidad = $"{clienteMayorista.DomicilioEntrega.Localidad.Descripcion} - {clienteMayorista.DomicilioEntrega.Provincia.Descripcion} ({clienteMayorista.DomicilioEntrega.CodigoPostal})"
            End If
            If (clienteMayorista.Transporte IsNot Nothing) Then
                TrasporteNombre = clienteMayorista.Transporte.RazonSocial
                TrasporteDireccion = clienteMayorista.Transporte.Domicilio.Direccion
                TrasporteLocalidad = $"{clienteMayorista.Transporte.Domicilio.Localidad.Descripcion} - {clienteMayorista.Transporte.Domicilio.Provincia.Descripcion} ({clienteMayorista.Transporte.Domicilio.CodigoPostal})"
            End If

            NotifyPropertyChanged(NameOf(Me.ClienteNombre))
        End Function

        Public Sub CargarClienteMayoristaDesdeRemito()
            Numero = RemitoModel.Numero

            ClienteNombre = RemitoModel.NombreYApellido
            ClienteCondicionIvaSeleccionada = RemitoModel.CondicionIVA
            ClienteCUIT = RemitoModel.CUIT
            ClienteDireccion = RemitoModel.Direccion
            ClienteLocalidad = RemitoModel.Localidad

            CantidadBultos = RemitoModel.CantidadBultos
            IncluyeFactura = RemitoModel.IncluyeFactura

            DespachoImportacion = RemitoModel.DespachoImportacion

            TrasporteNombre = RemitoModel.RazonSocialTransporte
            TrasporteDireccion = RemitoModel.DireccionTransporte
            TrasporteLocalidad = RemitoModel.LocalidadTransporte

            NotifyPropertyChanged(NameOf(Me.ClienteNombre))
        End Sub

        Friend Async Function GuardarAsync() As Task
            RemitoModel = CrearRemitoModel()

            Await RemitoService.GuardarAsync(RemitoModel)

            NotifyPropertyChanged(NameOf(Me.HabilitarImprimir))
            NotifyPropertyChanged(NameOf(Me.HabilitarGuardar))
        End Function

        Private Function CrearRemitoModel() As Remito

            Dim remitoModelAux As Remito
            If (RemitoModel Is Nothing) Then
                Dim remitoItemsModel As List(Of RemitoItem) = RemitoItems.Select(Function(x) New RemitoItem(x.Codigo, x.Nombre, x.Cantidad, New MontoProducto(x.Total, 0))).ToList()

                remitoModelAux = New Remito(VentaModel,
                                    Numero,
                                    ClienteCondicionIvaSeleccionada,
                                    ClienteNombre,
                                    ClienteCUIT,
                                    ClienteDireccion,
                                    ClienteLocalidad,
                                    TrasporteNombre,
                                    TrasporteDireccion,
                                    TrasporteLocalidad,
                                    CantidadBultos,
                                    IncluyeFactura,
                                    DespachoImportacion,
                                    remitoItemsModel)
            Else

                Dim remitoItemsModel As List(Of RemitoItem) = RemitoItems.Select(Function(x) New RemitoItem(x.Id, RemitoModel.Id, x.Codigo, x.Nombre, x.Cantidad, New MontoProducto(x.Total, 0))).ToList()

                remitoModelAux = New Remito(RemitoModel.Id,
                                        VentaModel,
                                        Numero,
                                        ClienteCondicionIvaSeleccionada,
                                        ClienteNombre,
                                        ClienteCUIT,
                                        ClienteDireccion,
                                        ClienteLocalidad,
                                        TrasporteNombre,
                                        TrasporteDireccion,
                                        TrasporteLocalidad,
                                        CantidadBultos,
                                        IncluyeFactura,
                                        DespachoImportacion,
                                        remitoItemsModel)
            End If

            Return remitoModelAux
        End Function

        Friend Sub ImprimirRemito()
            Dim frmReporteRemito As frmReporteRemito = New frmReporteRemito(RemitoModel)
            frmReporteRemito.ShowDialog()
        End Sub

        Friend Sub ImprimirBulto()
            If (RemitoModel.CantidadBultos <= 0) Then
                Throw New NegocioException("Error al imprimir las etiquetas para los bultos. Debe ingresar un total de bultos.")
            End If

            Dim frmReporteBulto As frmReporteBulto = New frmReporteBulto(RemitoModel)
            frmReporteBulto.ShowDialog()
        End Sub
    End Class

End Namespace
