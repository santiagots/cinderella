Imports System.Configuration
Public Class frmConfiguracion
    Dim NSucursales As New Negocio.NegSucursales
    Dim NListas As New Negocio.NegListasPrecio

    'Load del formulario.
    Private Sub frmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Sucursal Cargada en el app.config.
        lbl_NombreSucursalActual.Text = My.Settings("NombreSucursal")

        'Lista de Precios cargada en el app.config.
        lbl_NombreListaActual.Text = My.Settings("NombreListaPrecio")

        'Cargo el listado de sucursales.
        If (NSucursales.ListadoSucursales().Tables.Count <> 0) Then
            Cb_Sucursales.DataSource = NSucursales.ListadoSucursales().Tables(0)
            Cb_Sucursales.DisplayMember = "Nombre"
            Cb_Sucursales.ValueMember = "id_Sucursal"
            Cb_Sucursales.SelectedValue = My.Settings("Sucursal")
            Cb_Sucursales.Refresh()
        End If

        'Cargo el listado de Precios.
        If (NListas.ListadoGrupoPrecios().Tables.Count <> 0) Then
            cb_Precios.DataSource = NListas.ListadoGrupoPrecios().Tables(0)
            cb_Precios.DisplayMember = "ListaPrecio"
            cb_Precios.ValueMember = "id_Lista"
            cb_Precios.SelectedValue = My.Settings("ListaPrecio")
            cb_Precios.Refresh()
        End If

        'Cargo los valores de Mailing.
        txtPort.Text = My.Settings("MailPort")
        txtSmtp.Text = My.Settings("MailHost")
        txtUsuario.Text = My.Settings("MailUsuario")
        txtPassword.Text = My.Settings("MailPassword")

        'Cargo los valores del Controlador.
        If My.Settings("ControladorStatus") = "SI" Then
            RContrSI.Checked = True
        Else
            RContrNO.Checked = False
        End If
        txt_MontoControlador.Text = My.Settings("ControladorMontoTope")

        'Comprobacion de notificaciones.
        Cb_Segundos.SelectedItem = CStr(CInt((My.Settings("TemporizadorNotificacion") / 1000)))

        'Comprobacion de internet.
        Cb_SegundosInternet.SelectedItem = CStr(CInt((My.Settings("TemporizadorInternet") / 1000)))
        If My.Settings("Internet") Then
            Rb1.Checked = True
        Else
            Rb2.Checked = False
        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Actualizo la sucursal.
    Private Sub Btn_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Actualizar.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If Cb_Sucursales.SelectedValue <> 0 Then

                My.Settings.Sucursal = Cb_Sucursales.SelectedValue
                My.Settings.NombreSucursal = Cb_Sucursales.SelectedItem("Nombre").ToString
                My.Settings.Save()
                MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Debe seleccionar una sucursal.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Actualizo el listado de precios
    Private Sub Btn_Precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Precios.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If cb_Precios.SelectedValue <> 0 Then
                My.Settings.ListaPrecio = cb_Precios.SelectedValue
                My.Settings.NombreListaPrecio = cb_Precios.SelectedItem("ListaPrecio").ToString
                My.Settings.Save()
                MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Debe seleccionar una lista de precios.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Actualizo los datos de mailing.
    Private Sub BtnMailing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMailing.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If txtPort.Text <> "" And txtSmtp.Text <> "" And txtUsuario.Text <> "" And txtPassword.Text <> "" Then
                My.Settings.MailPort = Trim(txtPort.Text)
                My.Settings.MailHost = Trim(txtSmtp.Text)
                My.Settings.MailUsuario = Trim(txtUsuario.Text)
                My.Settings.MailPassword = Trim(txtPassword.Text)
                My.Settings.Save()
                MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Debe completar todos los campos.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Actualizo los datos del controlador.
    Private Sub Btn_Controlador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Controlador.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If (RContrSI.Checked Or RContrNO.Checked) And (txt_MontoControlador.Text <> "") Then
                If RContrSI.Checked Then
                    My.Settings.ControladorStatus = "SI"
                Else
                    My.Settings.ControladorStatus = "NO"
                End If
                My.Settings.ControladorMontoTope = Trim(txt_MontoControlador.Text)
                My.Settings.Save()
                MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Debe completar todos los campos.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub RContrSI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RContrSI.CheckedChanged
        If RContrSI.Checked = True Then
            RContrNO.Checked = False
        Else
            RContrNO.Checked = True
        End If
    End Sub

    Private Sub RContrNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RContrNO.CheckedChanged
        If RContrNO.Checked = True Then
            RContrSI.Checked = False
        Else
            RContrSI.Checked = True
        End If
    End Sub

    'Actualizo el periodo de comprobacion de notificaciones
    Private Sub BtnNotificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotificaciones.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If Cb_Segundos.SelectedItem IsNot Nothing Then
                My.Settings.TemporizadorNotificacion = (Cb_Segundos.SelectedItem * 10000)
                My.Settings.Save()
                MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Debe seleccionar una opción.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Actualizo el periodo de comprobacion de internet
    Private Sub BtnInternet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInternet.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If (Rb1.Checked Or Rb2.Checked) And Cb_SegundosInternet.SelectedItem IsNot Nothing Then
                If Rb1.Checked Then
                    My.Settings.Internet = True
                Else
                    My.Settings.Internet = False
                End If
                My.Settings.TemporizadorInternet = (Cb_SegundosInternet.SelectedItem * 10000)
                My.Settings.Save()
                MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Debe seleccionar una opción.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Rb1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rb1.CheckedChanged
        If Rb1.Checked = True Then
            Rb2.Checked = False
        Else
            Rb2.Checked = True
        End If
    End Sub

    Private Sub Rb2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rb2.CheckedChanged
        If Rb2.Checked = True Then
            Rb1.Checked = False
        Else
            Rb1.Checked = True
        End If
    End Sub
End Class