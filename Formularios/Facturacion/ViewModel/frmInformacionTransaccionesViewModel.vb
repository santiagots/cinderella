Namespace Formularios.Facturacion
    Public Class frmInformacionTransaccionesViewModel
        Inherits SistemaCinderella.VistaModelo.Common

        Public Property CintaTestigoDigitalDisponiblesDesde As Integer
        Public Property CintaTestigoDigitalDisponiblesHasta As Integer
        Public Property DescargarDuplicadosTipoADisponiblesDesde As Integer
        Public Property DescargarDuplicadosTipoADisponiblesHasta As Integer
        Public Property ResumenTotalesDisponiblesDesde As Integer
        Public Property ResumenTotalesDisponiblesHasta As Integer
        Public Property JornadasDescargadasCompletamenteDesde As Integer
        Public Property JornadasDescargadasCompletamenteHasta As Integer
        Public Property JornadasBorradasDesde As Integer
        Public Property JornadasBorradasHasta As Integer
        Public Property BorradasJornadasHasta As Integer

        Friend Sub ObtenerMemoriaTransacciones()
            Servicio.ObtenerMemoriaTransacciones(CintaTestigoDigitalDisponiblesDesde,
                                                 CintaTestigoDigitalDisponiblesHasta,
                                                 DescargarDuplicadosTipoADisponiblesDesde,
                                                 DescargarDuplicadosTipoADisponiblesHasta,
                                                 ResumenTotalesDisponiblesDesde,
                                                 ResumenTotalesDisponiblesHasta,
                                                 JornadasDescargadasCompletamenteDesde,
                                                 JornadasDescargadasCompletamenteHasta,
                                                 JornadasBorradasDesde,
                                                 JornadasBorradasHasta)

            NotifyPropertyChanged(NameOf(Me.CintaTestigoDigitalDisponiblesDesde))
            NotifyPropertyChanged(NameOf(Me.CintaTestigoDigitalDisponiblesHasta))
            NotifyPropertyChanged(NameOf(Me.DescargarDuplicadosTipoADisponiblesDesde))
            NotifyPropertyChanged(NameOf(Me.DescargarDuplicadosTipoADisponiblesHasta))
            NotifyPropertyChanged(NameOf(Me.ResumenTotalesDisponiblesDesde))
            NotifyPropertyChanged(NameOf(Me.ResumenTotalesDisponiblesHasta))
            NotifyPropertyChanged(NameOf(Me.JornadasDescargadasCompletamenteDesde))
            NotifyPropertyChanged(NameOf(Me.JornadasDescargadasCompletamenteHasta))
            NotifyPropertyChanged(NameOf(Me.JornadasBorradasDesde))
            NotifyPropertyChanged(NameOf(Me.JornadasBorradasHasta))
        End Sub

        Friend Sub BorrarJornada()
            Servicio.BorradoJornadasMemoriaTransacciones(BorradasJornadasHasta)
            ObtenerMemoriaTransacciones()
        End Sub
    End Class
End Namespace