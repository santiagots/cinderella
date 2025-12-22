Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Extension
Imports Common.Core.Model
Imports Common.Data.Service

Namespace Formularios.Facturacion
    Public Class frmPercepcionesViewModel
        Inherits Comunes.Common

        Public Property Percepciones As BindingList(Of PercepcionItem) = New BindingList(Of PercepcionItem)()
        Public Property PercepcionNueva As PercepcionDetalleViewModel = New PercepcionDetalleViewModel()
        Public Property PercepcionModificacion As PercepcionDetalleViewModel = New PercepcionDetalleViewModel()

        Public Async Function InicializarAsync() As Task
            Await CargarProvinciasAsync()
            CargarTipoCliente()
            CargarPrecepcion()
            CargarTipoCondicionIVA()
        End Function

        Public Async Function CargarProvinciasAsync() As Task
            Dim provinciasModel As List(Of Provincia) = Await DomicilioService.ObtenerProvinciaAsync()
            Dim keyValueProvincias As List(Of KeyValuePair(Of Provincia, String)) = provinciasModel.Select(Function(x) New KeyValuePair(Of Provincia, String)(x, x.Descripcion)).ToList()
            keyValueProvincias.Insert(0, New KeyValuePair(Of Provincia, String)(Nothing, "Seleccione una opción"))
            Dim Provincias As BindingList(Of KeyValuePair(Of Provincia, String)) = New BindingList(Of KeyValuePair(Of Provincia, String))(keyValueProvincias)

            PercepcionNueva.Provincias = Provincias
            PercepcionNueva.ProvinciaSeleccionado = Provincias.First()

            PercepcionModificacion.Provincias = Provincias
            PercepcionModificacion.ProvinciaSeleccionado = Provincias.First()

            NotifyPropertyChanged(NameOf(Me.PercepcionNueva.ProvinciaSeleccionado))
            NotifyPropertyChanged(NameOf(Me.PercepcionModificacion.ProvinciaSeleccionado))
        End Function

        Private Sub CargarTipoCliente()
            Dim tiposCliente As List(Of KeyValuePair(Of TipoCliente?, String)) = [Enum](Of TipoCliente).ToKeyValuePairList()
            tiposCliente.Insert(0, New KeyValuePair(Of TipoCliente?, String)(Nothing, "Seleccione una opción"))

            PercepcionNueva.TiposCliente = New BindingList(Of KeyValuePair(Of TipoCliente?, String))(tiposCliente)
            PercepcionNueva.TipoClienteSeleccionado = PercepcionNueva.TiposCliente.First()

            PercepcionModificacion.TiposCliente = New BindingList(Of KeyValuePair(Of TipoCliente?, String))(tiposCliente)
            PercepcionModificacion.TipoClienteSeleccionado = PercepcionModificacion.TiposCliente.First()

            NotifyPropertyChanged(NameOf(Me.PercepcionNueva.TipoClienteSeleccionado))
            NotifyPropertyChanged(NameOf(Me.PercepcionModificacion.TipoClienteSeleccionado))
        End Sub

        Private Sub CargarTipoCondicionIVA()
            Dim condicionIVA As List(Of KeyValuePair(Of CondicionIVA?, String)) = [Enum](Of CondicionIVA).ToKeyValuePairList()
            condicionIVA.Insert(0, New KeyValuePair(Of CondicionIVA?, String)(Nothing, "Seleccione una opción"))

            PercepcionNueva.TipoCondicionIVA = New BindingList(Of KeyValuePair(Of CondicionIVA?, String))(condicionIVA)
            PercepcionNueva.TipoCondicionIVASeleccionado = PercepcionNueva.TipoCondicionIVA.First()

            PercepcionModificacion.TipoCondicionIVA = New BindingList(Of KeyValuePair(Of CondicionIVA?, String))(condicionIVA)
            PercepcionModificacion.TipoCondicionIVASeleccionado = PercepcionModificacion.TipoCondicionIVA.First()

            NotifyPropertyChanged(NameOf(Me.PercepcionNueva.TipoCondicionIVASeleccionado))
            NotifyPropertyChanged(NameOf(Me.PercepcionModificacion.TipoCondicionIVASeleccionado))
        End Sub

        Private Sub CargarPrecepcion()
            Dim tiposPrecepcion As List(Of KeyValuePair(Of TipoPercepcionFactura?, String)) = [Enum](Of TipoPercepcionFactura).ToKeyValuePairList()
            tiposPrecepcion.Insert(0, New KeyValuePair(Of TipoPercepcionFactura?, String)(Nothing, "Seleccione una opción"))

            PercepcionNueva.TiposPrecepcion = New BindingList(Of KeyValuePair(Of TipoPercepcionFactura?, String))(tiposPrecepcion)
            PercepcionNueva.TipoPrecepcionSeleccionado = PercepcionNueva.TiposPrecepcion.First()

            PercepcionModificacion.TiposPrecepcion = New BindingList(Of KeyValuePair(Of TipoPercepcionFactura?, String))(tiposPrecepcion)
            PercepcionModificacion.TipoPrecepcionSeleccionado = PercepcionModificacion.TiposPrecepcion.First()

            NotifyPropertyChanged(NameOf(Me.PercepcionNueva.TipoClienteSeleccionado))
            NotifyPropertyChanged(NameOf(Me.PercepcionModificacion.TipoClienteSeleccionado))
        End Sub

        Friend Async Function Guardar(percepcion As PercepcionDetalleViewModel) As Task
            If percepcion.TipoClienteSeleccionado.Key Is Nothing Then
                Throw New NegocioException("Error al guardar la percepción. El tipo de cliente no puede estar vacía.")
            End If

            If percepcion.TipoCondicionIVASeleccionado.Key Is Nothing Then
                Throw New NegocioException("Error al guardar la percepción. El tipo de condición IVA no puede estar vacía.")
            End If

            If percepcion.TipoPrecepcionSeleccionado.Key Is Nothing Then
                Throw New NegocioException("Error al guardar la percepción. El tipo de percepción no puede estar vacía.")
            End If

            If percepcion.HabilitarProvincia AndAlso percepcion.ProvinciaSeleccionado.Key Is Nothing Then
                Throw New NegocioException("Error al guardar la percepción. La provincia no puede esta vacía.")
            End If

            If String.IsNullOrWhiteSpace(percepcion.Descripcion) Then
                Throw New NegocioException("Error al guardar la percepción. La descripción no puede esta vacía.")
            End If

            If percepcion.Alicuota <= 0 Then
                Throw New NegocioException("Error al guardar la percepción. La alicuota debe ser mayor a cero.")
            End If

            Dim percepcionModel As Percepcion = New Percepcion(percepcion.Id, percepcion.TipoClienteSeleccionado.Key, percepcion.TipoCondicionIVASeleccionado.Key, percepcion.TipoPrecepcionSeleccionado.Key, percepcion.ProvinciaSeleccionado.Key, percepcion.Descripcion, percepcion.MontoDesde, percepcion.Alicuota, percepcion.Habilitada)
            Await PercepcionService.Guardar(percepcionModel)
            Percepciones.Add(New PercepcionItem(percepcionModel))

            percepcion.ProvinciaSeleccionado = percepcion.Provincias.First()
            percepcion.TipoClienteSeleccionado = percepcion.TiposCliente.First()
            percepcion.TipoPrecepcionSeleccionado = percepcion.TiposPrecepcion.First()
            percepcion.Descripcion = String.Empty
            percepcion.Alicuota = 0
        End Function

        Friend Async Function Cargar() As Task
            Percepciones.Clear()
            Dim percepcionsModel As List(Of Percepcion) = Await PercepcionService.Buscar(TipoBase.Remota)
            For Each percepcionModel As Percepcion In percepcionsModel
                Percepciones.Add(New PercepcionItem(percepcionModel))
            Next
        End Function

        Friend Sub AltaTipoPercepcionChange(tipoPercepcionFacturaSeleccionado As KeyValuePair(Of TipoPercepcionFactura?, String))
            PercepcionNueva.TipoPrecepcionSeleccionado = tipoPercepcionFacturaSeleccionado
            PercepcionNueva.HabilitarProvincia = tipoPercepcionFacturaSeleccionado.Key.HasValue AndAlso tipoPercepcionFacturaSeleccionado.Key = TipoPercepcionFactura.Provincial_Ingresos_Brutos
            If (Not PercepcionNueva.HabilitarProvincia) Then
                PercepcionNueva.ProvinciaSeleccionado = PercepcionNueva.Provincias.First()
            End If

            NotifyPropertyChanged(NameOf(Me.PercepcionNueva.HabilitarProvincia))
            NotifyPropertyChanged(NameOf(Me.PercepcionNueva.ProvinciaSeleccionado))
        End Sub

        Friend Sub ModificacionTipoPercepcionChange(tipoPercepcionFacturaSeleccionado As KeyValuePair(Of TipoPercepcionFactura?, String))
            PercepcionModificacion.TipoPrecepcionSeleccionado = tipoPercepcionFacturaSeleccionado
            PercepcionModificacion.HabilitarProvincia = tipoPercepcionFacturaSeleccionado.Key.HasValue AndAlso tipoPercepcionFacturaSeleccionado.Key = TipoPercepcionFactura.Provincial_Ingresos_Brutos
            If (Not PercepcionModificacion.HabilitarProvincia) Then
                PercepcionModificacion.ProvinciaSeleccionado = PercepcionNueva.Provincias.First()
            End If

            NotifyPropertyChanged(NameOf(Me.PercepcionModificacion.HabilitarProvincia))
            NotifyPropertyChanged(NameOf(Me.PercepcionModificacion.ProvinciaSeleccionado))
        End Sub

        Friend Async Function Eliminar(percepcion As PercepcionItem) As Task
            Await PercepcionService.Borrar(percepcion.PercepcionModel)
        End Function

        Friend Sub Cargar(percepcion As Percepcion)
            PercepcionModificacion.Id = percepcion.Id
            PercepcionModificacion.ProvinciaSeleccionado = If(percepcion.Provincia IsNot Nothing, PercepcionModificacion.Provincias.First(Function(x) x.Key = percepcion.Provincia), PercepcionModificacion.Provincias.First())
            PercepcionModificacion.TipoClienteSeleccionado = PercepcionModificacion.TiposCliente.First(Function(x) x.Key.HasValue AndAlso x.Key = percepcion.TipoCliente)
            PercepcionModificacion.TipoCondicionIVASeleccionado = PercepcionModificacion.TipoCondicionIVA.First(Function(x) x.Key.HasValue AndAlso x.Key = percepcion.CondicionIVA)
            PercepcionModificacion.TipoPrecepcionSeleccionado = PercepcionModificacion.TiposPrecepcion.First(Function(x) x.Key.HasValue AndAlso x.Key = percepcion.TipoPercepcion)
            PercepcionModificacion.HabilitarProvincia = percepcion.TipoPercepcion = TipoPercepcionFactura.Provincial_Ingresos_Brutos
            PercepcionModificacion.Descripcion = percepcion.Comcepto
            PercepcionModificacion.MontoDesde = percepcion.MontoDesde
            PercepcionModificacion.Alicuota = percepcion.Alicuota
            PercepcionModificacion.Habilitada = percepcion.Habilitado
        End Sub
    End Class
End Namespace
