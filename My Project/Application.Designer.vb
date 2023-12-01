﻿Option Strict On
Option Explicit On
'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.261
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System.IO
Imports System.Reflection
Imports AutoMapper

Namespace My

    'NOTA: este archivo se genera de forma automática; no lo modifique directamente. Para realizar cambios,
    ' o si detecta errores de compilación en este archivo, vaya al Diseñador de proyectos
    ' (vaya a Propiedades del proyecto o haga doble clic en el nodo My Project en el
    ' Explorador de soluciones) y realice cambios en la ficha Aplicación.
    '
    Partial Friend Class MyApplication

        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Public Sub New()
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = False
            Me.EnableVisualStyles = True
            Me.SaveMySettingsOnExit = True
            Me.ShutdownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub

        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Protected Overrides Sub OnCreateMainForm()

            Mapper.Initialize(Sub(x)
                                  x.AddProfile(Of Comunes.MapperProfile)()
                                  x.AddProfile(Of Formularios.CuentaBancaria.MapperProfile)()
                                  x.AddProfile(Of Formularios.Facturacion.MapperProfile)()
                                  x.AddProfile(Of Formularios.Venta.MapperProfile)()
                                  x.AddProfile(Of Formularios.Cheque.MapperProfile)()
                                  x.AddProfile(Of Formularios.Reserva.MapperProfile)()
                                  x.AddProfile(Of Formularios.MovimientoDetalle.MapperProfile)()
                                  x.AddProfile(Of Formularios.SucursalSaldo.MapperProfile)()
                                  x.AddProfile(Of Formularios.Producto.MapperProfile)()
                                  x.AddProfile(Of Formularios.Cliente.MapperProfile)()
                                  x.AddProfile(Of Formularios.Comex.MapperProfile)()
                                  x.AddProfile(Of Ventas.Suport.Mapper.MapperProfile)()
                                  x.AddProfile(Of Servicios.MapperProfile)()
                              End Sub)

            Try
                Dim rutaBaseDatos As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "DB")
                Datos.ConfigurarBaseDatos.Iniciar(Assembly.GetExecutingAssembly.GetName().Name, rutaBaseDatos)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
                Common.Core.Helper.Log.Error(ex)
            End Try

            Me.MainForm = Global.SistemaCinderella.frmLogin
        End Sub

        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Protected Overrides Sub OnCreateSplashScreen()
            Me.SplashScreen = Global.SistemaCinderella.SplashScreen
        End Sub
    End Class
End Namespace
