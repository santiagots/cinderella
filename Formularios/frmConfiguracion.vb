﻿Imports System.Configuration
Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports Common.Core.Helper
Imports Datos
Imports Negocio

Public Class frmConfiguracion
    Dim NSucursales As New NegSucursales
    Dim NListas As New NegListasPrecio
    Dim NegErrores As New NegManejadorErrores
    Dim NStock As New NegStock

    'Load del formulario.
    Private Sub frmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Sucursal Cargada en el app.config.
            lbl_NombreSucursalActual.Text = My.Settings("NombreSucursal")

            'Lista de Precios cargada en el app.config.
            lbl_NombreListaActual.Text = My.Settings("NombreListaPrecio")

            txt_DatosFiscalNombreFantasia.Text = My.Settings.DatosFiscalNombreFantasia
            FontDialog.Font = My.Settings.DatosFiscalNombreFantasiaFuente
            txt_DatosFiscalRazonSocial.Text = My.Settings.DatosFiscalRazonSocial
            txt_DatosFiscalDireccion.Text = My.Settings.DatosFiscalDireccion
            txt_DatosFiscalLocalidad.Text = My.Settings.DatosFiscalLocalidad
            txt_DatosFiscalTelefono.Text = My.Settings.DatosFiscalTel
            txt_DatosFiscalEmail.Text = My.Settings.DatosFiscalEmail
            txt_DatosFiscalCUIT.Text = My.Settings.DatosFiscalCUIT
            txt_DatosFiscalIIBB.Text = My.Settings.DatosFiscalIIBB
            dt_DatosFiscalInicioActividad.Value = If(My.Settings.DatosFiscalInicioActividad = Date.MinValue, Date.Now, My.Settings.DatosFiscalInicioActividad)

            'Cargo el listado de sucursales.
            If (NSucursales.ListadoSucursales().Tables.Count <> 0) Then
                Cb_Sucursales.DataSource = NSucursales.ListadoSucursales().Tables(0)
                Cb_Sucursales.DisplayMember = "Nombre"
                Cb_Sucursales.ValueMember = "id_Sucursal"
                Cb_Sucursales.SelectedValue = My.Settings("Sucursal")
                Cb_Sucursales.Refresh()
            End If

            If (Not Negocio.Funciones.HayInternet) Then
                Cb_Sucursales.Enabled = False
            End If

            'Cargo el listado de Precios.
            If (NListas.ListadoGrupoPrecios().Tables.Count <> 0) Then
                cb_Precios.DataSource = NListas.ListadoGrupoPrecios().Tables(0)
                cb_Precios.DisplayMember = "ListaPrecio"
                cb_Precios.ValueMember = "id_Lista"
                cb_Precios.SelectedValue = My.Settings("ListaPrecio")
                cb_Precios.Refresh()
            End If

            txt_descuentoMinorista.Text = My.Settings("DescuentoMinorista")

            'Cargo los valores de Mailing.
            txtPort.Text = My.Settings("MailPort")
            txtSmtp.Text = My.Settings("MailHost")

            If My.Settings.MailSLL Then
                rbUtilizaSSLSi.Checked = True
            Else
                rbUtilizaSSLNo.Checked = True
            End If

            'Cargo los valores del Controlador.
            If My.Settings("ControladorStatus") = "SI" Then
                RContrSI.Checked = True
            Else
                RContrNO.Checked = True
            End If

            If My.Settings("HabilitarExentoSinIVA") = "SI" Then
                RExentoSinIvaSI.Checked = True
            Else
                RExentoSinIvaNo.Checked = True
            End If

            Cb_ModeloControladora.SelectedIndex = My.Settings.ModeloControladora
            Cb_ConexionControladora.SelectedItem = My.Settings.ConexionControladora.ToString()
            txt_MontoTopeTicket.Text = My.Settings.MontoTopeFaturacionTicket
            txt_MontoTopeManual.Text = My.Settings.MontoTopeFacturacionManual
            txt_MontoTopeElectronico.Text = My.Settings.MontoTopeFacturacionElectronica

            txt_MontoMaximoNotaCredito.Text = My.Settings("MontoMaximoNotaCredito")

            txt_PuntoVentaElectronica.Text = My.Settings.PuntoVentaFacturacionElectronica
            txt_PuntoVentaControladora.Text = My.Settings.PuntoVentaFacturacionTicket
            txt_PuntoVentaManual.Text = My.Settings.PuntoVentaFacturacionManual

            If (File.Exists(RutaCertificadoFacturacionElectronica)) Then
                txt_facturacionElectronicaCertificadoNombre.Text = CertificadosX509.ObtenerCN(RutaCertificadoFacturacionElectronica, PasswordCertificadoFacturacionElectronica)
                txt_facturacionElectronicaCertificadoVencimiento.Text = CertificadosX509.ObtenerVencimiento(RutaCertificadoFacturacionElectronica, PasswordCertificadoFacturacionElectronica).ToLongDateString()
            End If

            'Comprobacion de notificaciones.
            Cb_TiempoComprobacionMensajes.SelectedItem = CStr(CInt((My.Settings("TemporizadorMensajes") / 60000)))
            Cb_TiempoComprobacionMovimientos.SelectedItem = CStr(CInt((My.Settings("TemporizadorMovimientos") / 60000)))
            Cb_TiempoComprobacionCheques.SelectedItem = CStr(CInt((My.Settings("TemporizadorCheques") / 60000)))


            'Comprobacion de internet.
            Cb_SegundosInternet.SelectedItem = CStr(CInt((My.Settings("TemporizadorInternet") / 1000)))
            Cb_HorasSincronizacion.SelectedItem = CStr(CInt((My.Settings("TemporizadorSincronizacion") / 3600000)))
            txt_IpPing.Text = My.Settings.IpPing
            Cb_TimeOut.SelectedItem = My.Settings.IpTimeOut.ToString()
            If My.Settings("Internet") Then
                Rb1.Checked = True
            Else
                Rb2.Checked = False
            End If

            'cargo los valoes del tab Host
            txtIPHost.Text = My.Settings.IpHost
            txtPuertoHost.Text = My.Settings.PuertoHost

            'cargo los valoes del tab Stock
            If My.Settings.GeneracionOrdenCompraAutomatica Then
                ROrdenCompraAutomaticaSI.Checked = True
            Else
                ROrdenCompraAutomaticaNo.Checked = True
            End If
            CbPeriodoActualizacionVentaMensual.SelectedItem = My.Settings.PeriodoCaulculoVentaMensual

            Dim fechaUltimoCalculo As Date? = NStock.ObtenerUltimoCalculoVentaMensual(My.Settings.Sucursal)

            If (fechaUltimoCalculo.HasValue) Then
                txtFechaUltimoCalculoventaMensual.Text = fechaUltimoCalculo.Value.ToString("yyyy/MM/dd")
            Else
                txtFechaUltimoCalculoventaMensual.Text = "No calculado"
            End If

            EvaluarPermisos()
        Catch ex As Exception
            MessageBox.Show("Se ha encontrado un error obtener la configuración. Por favor, Comuníqueselo al administrador.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    'Actualizo la sucursal.
    Private Sub Btn_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Actualizar.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        If Cb_Sucursales.SelectedValue = 0 OrElse
           String.IsNullOrWhiteSpace(txt_DatosFiscalNombreFantasia.Text) OrElse
           String.IsNullOrWhiteSpace(txt_DatosFiscalRazonSocial.Text) OrElse
           String.IsNullOrWhiteSpace(txt_DatosFiscalDireccion.Text) OrElse
           String.IsNullOrWhiteSpace(txt_DatosFiscalLocalidad.Text) OrElse
           String.IsNullOrWhiteSpace(txt_DatosFiscalTelefono.Text) OrElse
           String.IsNullOrWhiteSpace(txt_DatosFiscalCUIT.Text) OrElse
           String.IsNullOrWhiteSpace(txt_DatosFiscalIIBB.Text) Then
            MessageBox.Show("Debe completar los campos requeridos", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If Not Cuit.EsValido(txt_DatosFiscalCUIT.Text) Then
            MessageBox.Show("El CUIL ingresado es incorrecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Try
            My.Settings.Sucursal = Cb_Sucursales.SelectedValue
            My.Settings.NombreSucursal = Cb_Sucursales.SelectedItem("Nombre").ToString
            My.Settings.DatosFiscalNombreFantasia = txt_DatosFiscalNombreFantasia.Text
            My.Settings.DatosFiscalRazonSocial = txt_DatosFiscalRazonSocial.Text
            My.Settings.DatosFiscalDireccion = txt_DatosFiscalDireccion.Text
            My.Settings.DatosFiscalLocalidad = txt_DatosFiscalLocalidad.Text
            My.Settings.DatosFiscalTel = txt_DatosFiscalTelefono.Text
            My.Settings.DatosFiscalEmail = txt_DatosFiscalEmail.Text
            My.Settings.DatosFiscalCUIT = txt_DatosFiscalCUIT.Text
            My.Settings.DatosFiscalIIBB = txt_DatosFiscalIIBB.Text
            My.Settings.DatosFiscalInicioActividad = dt_DatosFiscalInicioActividad.Value
            My.Settings.Save()

            MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            If cb_Precios.SelectedValue <> 0 And Not String.IsNullOrEmpty(txt_descuentoMinorista.Text) Then
                My.Settings.ListaPrecio = cb_Precios.SelectedValue
                My.Settings.NombreListaPrecio = cb_Precios.SelectedItem("ListaPrecio").ToString
                My.Settings.DescuentoMinorista = txt_descuentoMinorista.Text
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

    'Actualizo los datos de mailing.
    Private Sub BtnMailing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMailing.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If txtPort.Text <> "" And txtSmtp.Text <> "" Then
                My.Settings.MailPort = Trim(txtPort.Text)
                My.Settings.MailHost = Trim(txtSmtp.Text)
                My.Settings.MailSLL = rbUtilizaSSLSi.Checked

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
            If (RContrSI.Checked Or RContrNO.Checked) And (txt_MontoTopeTicket.Text <> "" And txt_MontoTopeManual.Text <> "" And txt_PuntoVentaElectronica.Text <> "" And txt_PuntoVentaControladora.Text <> "" And txt_PuntoVentaElectronica.Text <> "" And txt_PuntoVentaManual.Text <> "") Then
                If RContrSI.Checked Then
                    My.Settings.ControladorStatus = "SI"
                Else
                    My.Settings.ControladorStatus = "NO"
                End If
                If RExentoSinIvaSI.Checked Then
                    My.Settings.HabilitarExentoSinIVA = "SI"
                Else
                    My.Settings.HabilitarExentoSinIVA = "NO"
                End If
                My.Settings.ModeloControladora = Cb_ModeloControladora.SelectedIndex
                My.Settings.ConexionControladora = Cb_ConexionControladora.SelectedItem
                My.Settings.MontoTopeFaturacionTicket = Trim(txt_MontoTopeTicket.Text)
                My.Settings.MontoTopeFacturacionManual = Trim(txt_MontoTopeManual.Text)
                My.Settings.MontoTopeFacturacionElectronica = Trim(txt_MontoTopeElectronico.Text)
                My.Settings.MontoMaximoNotaCredito = Trim(txt_MontoMaximoNotaCredito.Text)
                My.Settings.PuntoVentaFacturacionElectronica = Integer.Parse(Trim(txt_PuntoVentaElectronica.Text))
                My.Settings.PuntoVentaFacturacionTicket = Integer.Parse(Trim(txt_PuntoVentaControladora.Text))
                My.Settings.PuntoVentaFacturacionManual = Integer.Parse(Trim(txt_PuntoVentaManual.Text))
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



    'Actualizo el periodo de comprobacion de notificaciones
    Private Sub BtnNotificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotificaciones.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If Cb_TiempoComprobacionMensajes.SelectedItem IsNot Nothing AndAlso Cb_TiempoComprobacionMovimientos.SelectedItem IsNot Nothing AndAlso Cb_TiempoComprobacionCheques.SelectedItem IsNot Nothing Then
                My.Settings.TemporizadorMensajes = (Cb_TiempoComprobacionMensajes.SelectedItem * 60000)
                My.Settings.TemporizadorMovimientos = (Cb_TiempoComprobacionMovimientos.SelectedItem * 60000)
                My.Settings.TemporizadorCheques = (Cb_TiempoComprobacionCheques.SelectedItem * 60000)

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
        Try
            If (Cb_SegundosInternet.SelectedItem Is Nothing) Then
                MessageBox.Show("Debe seleccionar una opción en Período de Comprobación.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If (Cb_HorasSincronizacion.SelectedItem Is Nothing) Then
                MessageBox.Show("Debe seleccionar una opción en Período de Sincronización.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If (Cb_TimeOut.SelectedItem Is Nothing) Then
                MessageBox.Show("Debe seleccionar una opción en Tiempo de espera.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If (String.IsNullOrEmpty(txt_IpPing.Text) Or Not IPAddress.TryParse(txt_IpPing.Text, Nothing)) Then
                MessageBox.Show("La Ip ingresada es invalida. Verifique que el formato sea el correcto", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            Me.Cursor = Cursors.WaitCursor

            If Rb1.Checked Then
                My.Settings.Internet = True
            Else
                My.Settings.Internet = False
            End If
            My.Settings.TemporizadorInternet = (Cb_SegundosInternet.SelectedItem * 1000)
            My.Settings.TemporizadorSincronizacion = (Cb_HorasSincronizacion.SelectedItem * 3600000)
            My.Settings.IpPing = txt_IpPing.Text
            My.Settings.IpTimeOut = Cb_TimeOut.SelectedItem
            My.Settings.Save()

            Negocio.Funciones.Ip = My.Settings.IpPing
            Negocio.Funciones.TimeOut = My.Settings.IpTimeOut

            MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

        Cb_SegundosInternet.Enabled = Rb1.Checked
        Cb_HorasSincronizacion.Enabled = Rb1.Checked
        txt_IpPing.Enabled = Rb1.Checked
        Cb_TimeOut.Enabled = Rb1.Checked
        btnVerificarDNS.Enabled = Rb1.Checked
    End Sub

    Private Sub txt_PuntoVentaControladora_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PuntoVentaControladora.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_PuntoVentaManual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PuntoVentaManual.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_PuntoVentaElectronica_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PuntoVentaElectronica.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnModificarHost_Click(sender As Object, e As EventArgs) Handles btnModificarHost.Click

        If (Cb_SegundosInternet.SelectedItem Is Nothing) Then
            MessageBox.Show("Debe seleccionar una opción en Período de Comprobación.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If (Not Integer.TryParse(txtPuertoHost.Text, Nothing)) Then
            MessageBox.Show("El Puerto ingresada es invalida. Verifique que el formato sea el correcto", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If (String.IsNullOrEmpty(txtIPHost.Text) Or Not IPAddress.TryParse(txtIPHost.Text, Nothing)) Then
            MessageBox.Show("La Ip ingresada es invalida. Verifique que el formato sea el correcto", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            My.Settings.IpHost = Trim(txtIPHost.Text)
            My.Settings.PuertoHost = Trim(txtPuertoHost.Text)
            My.Settings.Save()
            MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnModificarStock_Click(sender As Object, e As EventArgs) Handles btnModificarStock.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            If ROrdenCompraAutomaticaSI.Checked Then
                My.Settings.GeneracionOrdenCompraAutomatica = True
            Else
                My.Settings.GeneracionOrdenCompraAutomatica = False
            End If
            My.Settings.PeriodoCaulculoVentaMensual = CbPeriodoActualizacionVentaMensual.SelectedItem
            MessageBox.Show("Los cambios se han realizado correctamente." & vbCrLf & "Reinicie la aplicación para que surjan efecto.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub txtPuertoHost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPuertoHost.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Sucursal_Visualizar)) Then

        Else
            TabControl1.TabPages.Remove(TabControl1.TabPages("TabSucursal"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Sucursal_Modificar)) Then
            Btn_Actualizar.Enabled = True
        Else
            Btn_Actualizar.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Precio_Visualizar)) Then

        Else
            TabControl1.TabPages.Remove(TabControl1.TabPages("TabPrecios"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Precio_Modificar)) Then
            Btn_Precios.Enabled = True
        Else
            Btn_Precios.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Mail_Visualizar)) Then

        Else
            TabControl1.TabPages.Remove(TabControl1.TabPages("TabMail"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Mail_Modificar)) Then
            BtnMailing.Enabled = True
        Else
            BtnMailing.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Facturación_Visualizar)) Then

        Else
            TabControl1.TabPages.Remove(TabControl1.TabPages("TabFacturacion"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Facturación_Modificar)) Then
            Btn_Controlador.Enabled = True
        Else
            Btn_Controlador.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Alertas_Visualizar)) Then

        Else
            TabControl1.TabPages.Remove(TabControl1.TabPages("TabNotificaciones"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Alertas_Modificar)) Then
            BtnNotificaciones.Enabled = True
        Else
            BtnNotificaciones.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Internet_Visualizar)) Then

        Else
            TabControl1.TabPages.Remove(TabControl1.TabPages("TabInternet"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Internet_Modificar)) Then
            BtnInternet.Enabled = True
        Else
            BtnInternet.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Host_Visualizar)) Then

        Else
            TabControl1.TabPages.Remove(TabControl1.TabPages("Host"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Host_Modificar)) Then
            btnModificarHost.Enabled = True
        Else
            btnModificarHost.Enabled = False
        End If
    End Sub

    Private Sub btnCalcularVentaMensualProducto_Click(sender As Object, e As EventArgs) Handles btnCalcularVentaMensualProducto.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            'Calculo el total de ventas de los poductos en sotck en los ultimos 30 dias
            NStock.CalculaVentaMensual(My.Settings.Sucursal, Date.Now().AddDays(-30), Date.Now())
            'Actualizo la fecha del calculo
            NStock.ActualizarUltimoCalculoVentaMensual(My.Settings.Sucursal)

            txtFechaUltimoCalculoventaMensual.Text = Date.Now.ToString("yyyy/MM/dd")

            MessageBox.Show("Se han actualizado las ventas mensuales para los productos en stock de forma exitosa.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al actualizar las ventas mensuales para los productos en stock. Por favor, Comuníqueselo al administrador", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub btnVerificarDNS_Click(sender As Object, e As EventArgs) Handles btnVerificarDNS.Click

        If (Cb_TimeOut.SelectedItem Is Nothing) Then
            MessageBox.Show("Debe seleccionar una opción en Tiempo de espera.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If (String.IsNullOrEmpty(txt_IpPing.Text) Or Not IPAddress.TryParse(txt_IpPing.Text, Nothing)) Then
            MessageBox.Show("La Ip ingresada es invalida. Verifique que el formato sea el correcto", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Try
            Dim myPing As Ping = New Ping()
            Dim buffer(23) As Byte
            Dim PingOptions As PingOptions = New PingOptions()
            Dim reply As PingReply = myPing.Send(txt_IpPing.Text, Cb_TimeOut.SelectedItem, buffer, PingOptions)

            MessageBox.Show($"Respuesta del DNS: {reply.Status.ToString()}", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Catch ex As Exception
            MessageBox.Show($"Se genero un error al verificar el DNS. Por favor, Comuníqueselo al administrador.{Environment.NewLine}{ex.ToString()} ", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txt_DatosFiscalNombreFantasiaFuente_Click(sender As Object, e As EventArgs) Handles txt_DatosFiscalNombreFantasiaFuente.Click
        If (FontDialog.ShowDialog() = DialogResult.OK) Then
            My.Settings.DatosFiscalNombreFantasiaFuente = FontDialog.Font
        End If
    End Sub

    Private Sub btnObtenerArchivoCSR_Click(sender As Object, e As EventArgs) Handles btnObtenerArchivoCSR.Click
        If String.IsNullOrWhiteSpace(My.Settings.DatosFiscalCUIT) OrElse String.IsNullOrWhiteSpace(My.Settings.DatosFiscalRazonSocial) OrElse String.IsNullOrWhiteSpace(My.Settings.DatosFiscalNombreFantasia) Then
            MessageBox.Show("Error al generar el archivo CSR. Verifique que los datos de Razón Social, Nombre Fantasía y CUIT de la solapa Sucursal se encuentren cargados y guardados.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
        saveFileDialog.DefaultExt = "csr"
        saveFileDialog.FileName = "MiPedidoCSR"
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        saveFileDialog.RestoreDirectory = True
        saveFileDialog.Filter = "Solicitud de firma de certificado (*.csr)|*.csr"
        saveFileDialog.DefaultExt = "csr"
        saveFileDialog.AddExtension = True

        If saveFileDialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim nombreArchivoCSR As String = saveFileDialog.FileName
        Dim nombreArchivoKey As String = RutaArchivoKeyFacturacionElectronica

        Try
            Dim argumento As String = $"genrsa -passout pass:{PasswordCertificadoFacturacionElectronica} -out {nombreArchivoKey} 2048"
            EjecutarComando("openssl.exe", argumento, ".\Libs")

            argumento = $"req -new -config openssl.cnf -key {nombreArchivoKey} -subj ""/C=AR/O={My.Settings.DatosFiscalRazonSocial}/CN={My.Settings.DatosFiscalNombreFantasia}/serialNumber=CUIT {My.Settings.DatosFiscalCUIT}"" -out ""{nombreArchivoCSR}"""
            EjecutarComando("openssl.exe", argumento, ".\Libs")

            MessageBox.Show("El archivo se ha generado de forma exitosa", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCargarCertificadoAFIP_Click(sender As Object, e As EventArgs) Handles btnCargarCertificadoAFIP.Click
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
        openFileDialog.DefaultExt = "csr"
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        openFileDialog.RestoreDirectory = True
        openFileDialog.Filter = "Certificado (*.crt)|*.crt"
        openFileDialog.DefaultExt = "crt"
        openFileDialog.AddExtension = True

        If openFileDialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim nombreArchivoCRT As String = openFileDialog.FileName
        Dim nombreArchivoKey As String = RutaArchivoKeyFacturacionElectronica
        Dim nombreArchivoP12 As String = RutaCertificadoFacturacionElectronica
        Dim info As ProcessStartInfo = New ProcessStartInfo()

        Try
            Dim argumento As String = $"pkcs12 -export -in ""{nombreArchivoCRT}"" -password pass:{PasswordCertificadoFacturacionElectronica} -inkey ""{nombreArchivoKey}"" -out ""{nombreArchivoP12}"""
            EjecutarComando("openssl.exe", argumento, ".\Libs")

            txt_facturacionElectronicaCertificadoNombre.Text = CertificadosX509.ObtenerCN(RutaCertificadoFacturacionElectronica, PasswordCertificadoFacturacionElectronica)
            txt_facturacionElectronicaCertificadoVencimiento.Text = CertificadosX509.ObtenerVencimiento(RutaCertificadoFacturacionElectronica, PasswordCertificadoFacturacionElectronica).ToLongDateString()

            MessageBox.Show("El certificado de la AFIP se ha registrado de forma exitosa", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Se ha producido un error al obtener los datos del certificado. Por favor, verifique que el mismo este correcto o que se encuentre la clave provada del mismo. En caso de que el error persista genere un nuevo certificado en la AFIP.", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EjecutarComando(comando As String, argumentos As String, directorio As String)
        Dim info As ProcessStartInfo = New ProcessStartInfo()
        info.RedirectStandardOutput = True
        info.UseShellExecute = False
        info.CreateNoWindow = True
        info.WindowStyle = ProcessWindowStyle.Hidden
        info.FileName = $"{directorio}\{comando}"
        info.WorkingDirectory = directorio
        info.Arguments = argumentos

        Dim proc As Process = New Process()
        proc.StartInfo = info
        proc.Start()
        proc.WaitForExit()
        Dim result As String = proc.StandardOutput.ReadToEnd()
    End Sub

    Private Sub btn_ConfigurarBaseDatos_Click(sender As Object, e As EventArgs) Handles btn_ConfigurarBaseDatos.Click
        Dim frmConfiguracionBaseDatos As frmConfiguracionBaseDatos = New frmConfiguracionBaseDatos()
        frmConfiguracionBaseDatos.ShowDialog()
    End Sub
End Class