Imports System.Configuration
Imports Common.Core.Helper
Imports Factura.Device.Printer
Imports Factura.ExternalService

Namespace My

    'Esta clase le permite controlar eventos específicos en la clase de configuración:
    ' El evento SettingChanging se desencadena antes de cambiar un valor de configuración.
    ' El evento PropertyChanged se desencadena después de cambiar el valor de configuración.
    ' El evento SettingsLoaded se desencadena después de cargar los valores de configuración.
    ' El evento SettingsSaving se desencadena antes de guardar los valores de configuración.
    Partial Friend NotInheritable Class MySettings

        Private Sub MySettings_SettingChanging(ByVal sender As Object, ByVal e As SettingChangingEventArgs) Handles Me.SettingChanging
            Dim settings As MySettings = sender

            Select Case e.SettingName
                Case NameOf(settings.Sucursal)
                    IdGenerator.ID_SUCURSAL = e.NewValue
                Case NameOf(settings.ConexionControladora)
                    EpsonPrinter.TIPO_CONEXION = e.NewValue
                Case NameOf(settings.ModeloControladora)
                    EpsonPrinter.MODELO_CONTROLADORA_FISCAL = e.NewValue
                Case NameOf(settings.PuntoVentaFacturacionTicket)
                    EpsonPrinter.PUNTO_VENTA = e.NewValue
                Case NameOf(settings.DatosFiscalCUIT)
                    Dim cuit As Long = 0
                    Long.TryParse(e.NewValue.DatosFiscalCUIT.Replace("-", ""), cuit)
                    AfipFacturacionElectronicaService.CUIT_FACTURACION = cuit
                Case NameOf(settings.PuntoVentaFacturacionElectronica)
                    AfipFacturacionElectronicaService.PUNTO_VENTA = e.NewValue
            End Select
        End Sub

        Private Sub MySettings_SettingsLoaded(ByVal sender As Object, ByVal e As SettingsLoadedEventArgs) Handles Me.SettingsLoaded
            Dim settings As MySettings = sender
            IdGenerator.ID_SUCURSAL = settings.Sucursal
            EpsonPrinter.TIPO_CONEXION = settings.ConexionControladora
            EpsonPrinter.MODELO_CONTROLADORA_FISCAL = settings.ModeloControladora
            EpsonPrinter.PUNTO_VENTA = settings.PuntoVentaFacturacionTicket

            Dim cuit As Long = 0
            Long.TryParse(settings.DatosFiscalCUIT.Replace("-", ""), cuit)
            AfipFacturacionElectronicaService.CUIT_FACTURACION = cuit
            AfipFacturacionElectronicaService.PUNTO_VENTA = settings.PuntoVentaFacturacionElectronica
        End Sub
    End Class
End Namespace
