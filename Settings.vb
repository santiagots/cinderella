
Imports System.Configuration
Imports Common.Core.Helper
Imports Common.Device
Imports Common.Device.Printer

Namespace My

    'Esta clase le permite controlar eventos específicos en la clase de configuración:
    ' El evento SettingChanging se desencadena antes de cambiar un valor de configuración.
    ' El evento PropertyChanged se desencadena después de cambiar el valor de configuración.
    ' El evento SettingsLoaded se desencadena después de cargar los valores de configuración.
    ' El evento SettingsSaving se desencadena antes de guardar los valores de configuración.
    Partial Friend NotInheritable Class MySettings

        Private Sub MySettings_SettingChanging(ByVal sender As Object, ByVal e As SettingChangingEventArgs) Handles Me.SettingChanging
            Dim settings As MySettings = sender
            If (e.SettingName = NameOf(settings.Sucursal)) Then
                IdGenerator.ID_SUCURSAL = e.NewValue
            End If
            If (e.SettingName = NameOf(settings.ConexionControladora)) Then
                EpsonFP.TIPO_CONEXION = e.NewValue
            End If
        End Sub

        Private Sub MySettings_SettingsLoaded(ByVal sender As Object, ByVal e As SettingsLoadedEventArgs) Handles Me.SettingsLoaded
            Dim settings As MySettings = sender
            IdGenerator.ID_SUCURSAL = settings.Sucursal
            EpsonFP.TIPO_CONEXION = settings.ConexionControladora
        End Sub
    End Class
End Namespace
