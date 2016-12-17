Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports System.Media
Imports Entidades
Public Class Funciones

    Public Property ControlInstancia(ByVal formulario As Form) As Form
        Get
            If formulario Is Nothing OrElse formulario.IsDisposed Then
                formulario = New Form
            Else
                formulario.BringToFront()
            End If
            Return formulario
        End Get
        Set(ByVal value As Form)
            formulario = value
        End Set
    End Property

    'Funcion que actualiza el estado de internet de la aplicacion.
    Public Sub ActualizarEstado(Internete As Boolean, MDIContenedor As MDIContenedor)
        If Not VariablesGlobales.HayConexion = Internete Then
            If Internete Then
                MDIContenedor.Conectado.Text = "Conectado a Internet"
                MDIContenedor.Conectado.Image = My.Resources.Recursos.Internet_32
                VariablesGlobales.HayConexion = True

                'Form Notify.
                ControlInstancia(frmNotificaciones).MdiParent = MDIContenedor
                frmNotificaciones.Text = "Conexión a Internet"
                frmNotificaciones.lblConexion.Text = "Sistema con conexión a internet."
                frmNotificaciones.PictureBox1.Image = My.Resources.Recursos.Internet_64
                ControlInstancia(frmNotificaciones).Show()

                'Sonidito.
                SystemSounds.Asterisk.Play()
            Else
                MDIContenedor.Conectado.Text = "Sin Conexión a Internet"
                MDIContenedor.Conectado.Image = My.Resources.Recursos.NoInternet_32
                VariablesGlobales.HayConexion = False

                'Form Notify.
                ControlInstancia(frmNotificaciones).MdiParent = MDIContenedor
                frmNotificaciones.Text = "Sin Conexión a Internet"
                frmNotificaciones.lblConexion.Text = "No se ha encontrado conexión a internet."
                frmNotificaciones.PictureBox1.Image = My.Resources.Recursos.NoInternet_64
                ControlInstancia(frmNotificaciones).Show()

                'Sonidito.
                SystemSounds.Exclamation.Play()
            End If

        End If
    End Sub

    'Funcion que actualiza los estados de las notificaciones.
    Public Sub ActualizarNotificaciones(Optional ByVal TypeFunction As String = "Standard")
        If My.Settings.Internet Then 'Internet Permitido.
            'Si hay conexion compruebo las notificaciones.
            If VariablesGlobales.HayConexion Then
                Dim negMovimiento As New Negocio.NegMovimientos
                Dim TotalNotif As Integer = negMovimiento.ObtenerNotificaciones(My.Settings.Sucursal)

                If (VariablesGlobales.Notificaciones = TotalNotif) Then
                    'no hace nada..
                Else
                    If TotalNotif > 0 Then 'Si hay notificaciones.
                        'Menu Bottom.
                        MDIContenedor.Menu_Movimientos.Text = "(" & TotalNotif & ") Notificaciones |"
                        MDIContenedor.Menu_Movimientos.ToolTipText = "Hace click aquí si deseas ver las Notificaciones pendientes."
                        MDIContenedor.Menu_Movimientos.Font = New Font(MDIContenedor.Menu_Movimientos.Font, FontStyle.Bold)
                        VariablesGlobales.Notificaciones = TotalNotif

                        If frmNotificacionesListado.Visible Then
                            frmNotificacionesListado.CargarPlanilla()
                        End If

                        'Menu Top.
                        MDIContenedor.Btn_NotificacionesMenu.Text = "(" & TotalNotif & ") Notificaciones |"

                        If TypeFunction = "Full" Then
                            'Form Notify.
                            ControlInstancia(frmNotificaciones).MdiParent = MDIContenedor
                            frmNotificaciones.Text = "(" & TotalNotif & ") Notificaciones de otras sucursales"
                            ControlInstancia(frmNotificaciones).Show()

                            'Sonidito.
                            SystemSounds.Asterisk.Play()
                        End If
                    Else
                        'Menu Top.
                        MDIContenedor.Btn_NotificacionesMenu.Text = "Notificaciones"

                        'Menu Bottom.
                        MDIContenedor.Menu_Movimientos.Text = "(0) Notificaciones |"
                        MDIContenedor.Menu_Movimientos.ToolTipText = "Sin Notificaciones."
                        MDIContenedor.Menu_Movimientos.Font = New Font(MDIContenedor.Menu_Movimientos.Font, FontStyle.Regular)
                        VariablesGlobales.Notificaciones = 0
                    End If
                End If
            Else 'Si no hay conexion no hago nada.
                'Menu Top.
                MDIContenedor.Btn_NotificacionesMenu.Text = "Notificaciones"

                'Menu Bottom.
                MDIContenedor.Menu_Movimientos.Text = "(-) Notificaciones |"
                MDIContenedor.Menu_Movimientos.ToolTipText = "No se pudo comprobar las Notificaciones."
                MDIContenedor.Menu_Movimientos.Font = New Font(MDIContenedor.Menu_Movimientos.Font, FontStyle.Regular)
                VariablesGlobales.Notificaciones = 0
            End If
        Else
            'Menu Top.
            MDIContenedor.Btn_NotificacionesMenu.Text = "Notificaciones"

            'Menu Bottom.
            MDIContenedor.Menu_Movimientos.Text = "(-) Notificaciones |"
            MDIContenedor.Menu_Movimientos.ToolTipText = "No se pudo comprobar las Notificaciones."
            MDIContenedor.Menu_Movimientos.Font = New Font(MDIContenedor.Menu_Movimientos.Font, FontStyle.Regular)
            VariablesGlobales.Notificaciones = 0
        End If
    End Sub

    Sub ActualizarChequesVencer()
        If My.Settings.Internet Then 'Internet Permitido.
            'Si hay conexion compruebo los cheques
            If VariablesGlobales.HayConexion Then
                Dim ChequesVencer As List(Of Cheque) = Negocio.NegCheque.TraerCheques(My.Settings.Sucursal).Where(Function(x) x.Estado <> ChequeEstado.Salido AndAlso x.FechaVencimiento.Date >= Date.Now.Date AndAlso x.FechaVencimiento.Date < Date.Now.AddDays(7).Date).ToList()
                If ChequesVencer.Count >= 1 Then
                    MDIContenedor.Menu_ChequesVencer.Text = "(" & ChequesVencer.Count & ") Cheques por vencer |"
                    MDIContenedor.Menu_ChequesVencer.ToolTipText = "Hace click aquí si deseas ir al administrador de cheques."
                    MDIContenedor.Menu_ChequesVencer.Font = New Font(MDIContenedor.Menu_Movimientos.Font, FontStyle.Bold)

                    'Form Notify.
                    ControlInstancia(frmNotificaciones).MdiParent = MDIContenedor
                    frmNotificaciones.lblConexion.Text = "(" & ChequesVencer.Count & ") Cheques por vencer."
                    frmNotificaciones.PictureBox1.Image = My.Resources.Recursos.Mi_Cuenta_Salir
                    frmNotificaciones.Text = "(" & ChequesVencer.Count & ") Cheques por vencer en los proximos 7 días."

                    ControlInstancia(frmNotificaciones).Show()

                    'Sonidito.
                    SystemSounds.Asterisk.Play()

                Else
                    MDIContenedor.Menu_ChequesVencer.Text = "(0) Cheques por vencer |"
                    MDIContenedor.Menu_ChequesVencer.Font = New Font(MDIContenedor.Menu_Movimientos.Font, FontStyle.Regular)
                End If
            Else 'Si no hay conexion no hago nada.
                MDIContenedor.Menu_ChequesVencer.Text = "(-) Cheques por vencer |"
                MDIContenedor.Menu_ChequesVencer.ToolTipText = "No se pudo comprobar los Mensajes"
                MDIContenedor.Menu_ChequesVencer.Font = New Font(MDIContenedor.Menu_Movimientos.Font, FontStyle.Regular)
            End If
        Else
            MDIContenedor.Menu_Mensajes.Text = "(-) Cheques por vencer |"
            MDIContenedor.Menu_Mensajes.ToolTipText = "No se pudo comprobar los Mensajes"
            MDIContenedor.Menu_ChequesVencer.Font = New Font(MDIContenedor.Menu_Movimientos.Font, FontStyle.Regular)
        End If
    End Sub

    Sub ActualizarNotasPedidos(Optional ByVal mostrarAlerta As Boolean = True)
        If My.Settings.Internet Then 'Internet Permitido.
            'Si hay conexion compruebo los cheques
            If VariablesGlobales.HayConexion Then
                Dim negNotaPedido As Negocio.NegNotaPedido = New Negocio.NegNotaPedido()
                Dim notaPedidos As List(Of NotaPedido) = negNotaPedido.TraerNotas(My.Settings.Sucursal)
                If notaPedidos.Count >= 1 Then
                    MDIContenedor.Menu_NotaPedido.Text = "(" & notaPedidos.Count & ") Notas de pedidos"
                    MDIContenedor.Menu_NotaPedido.ToolTipText = "Hace click aquí si deseas ir al administrador de notas de pedidos."
                    MDIContenedor.Menu_NotaPedido.Font = New Font(MDIContenedor.Menu_Movimientos.Font, FontStyle.Bold)

                    If (mostrarAlerta) Then
                        'Form Notify.
                        ControlInstancia(frmNotificaciones).MdiParent = MDIContenedor
                        frmNotificaciones.lblConexion.Text = "(" & notaPedidos.Count & ") Notas de pedidos pendientes."
                        frmNotificaciones.PictureBox1.Image = My.Resources.Recursos.Mi_Cuenta_Salir
                        frmNotificaciones.Text = "(" & notaPedidos.Count & ") Notas de pedidos."

                        ControlInstancia(frmNotificaciones).Show()

                        'Sonidito.
                        SystemSounds.Asterisk.Play()
                    End If
                Else
                    MDIContenedor.Menu_NotaPedido.Text = "(0) Notas de pedidos"
                    MDIContenedor.Menu_NotaPedido.Font = New Font(MDIContenedor.Menu_Movimientos.Font, FontStyle.Regular)
                End If
            Else 'Si no hay conexion no hago nada.
                MDIContenedor.Menu_NotaPedido.Text = "(-) Notas de pedidos"
                MDIContenedor.Menu_NotaPedido.ToolTipText = "No se pudo comprobar las notas de pedidos pendientes"
                MDIContenedor.Menu_NotaPedido.Font = New Font(MDIContenedor.Menu_Movimientos.Font, FontStyle.Regular)
            End If
        Else
            MDIContenedor.Menu_NotaPedido.Text = "(-) Notas de pedidos"
            MDIContenedor.Menu_NotaPedido.ToolTipText = "No se pudo comprobar las notas de pedidos pendientes"
            MDIContenedor.Menu_NotaPedido.Font = New Font(MDIContenedor.Menu_Movimientos.Font, FontStyle.Regular)
        End If
    End Sub

    'Funcion que actualiza los mensajes.
    Public Sub ActualizarMensajes()
        If My.Settings.Internet Then 'Internet Permitido.
            'Si hay conexion compruebo los mensajes.
            If VariablesGlobales.HayConexion Then
                Dim negMensajes As New Negocio.NegMensajes
                Dim Numero_Correo As Integer
                Numero_Correo = negMensajes.ComprobarMensajes(VariablesGlobales.objUsuario.id_Usuario)
                If Numero_Correo >= 1 Then
                    MDIContenedor.Menu_Mensajes.Text = "(" & Numero_Correo & ") Mensajes |"
                    MDIContenedor.Menu_Mensajes.ToolTipText = "Nuevos mensajes!"

                    'Form Notify.
                    ControlInstancia(frmNotificaciones).MdiParent = MDIContenedor
                    frmNotificaciones.lblConexion.Text = "(" & Numero_Correo & ") Mensajes recibidos."
                    frmNotificaciones.PictureBox1.Image = My.Resources.Recursos.Mail_Importante
                    frmNotificaciones.Text = "(" & Numero_Correo & ") Mensajes recibidos"
                    ControlInstancia(frmNotificaciones).Show()

                    'Sonidito.
                    SystemSounds.Asterisk.Play()

                Else
                    MDIContenedor.Menu_Mensajes.Text = "(0) Mensajes |"
                    MDIContenedor.Menu_Mensajes.ToolTipText = "Sin Mensajes"
                End If
            Else 'Si no hay conexion no hago nada.
                MDIContenedor.Menu_Mensajes.Text = "(-) Mensajes |"
                MDIContenedor.Menu_Mensajes.ToolTipText = "No se pudo comprobar los Mensajes"
            End If
        Else
            MDIContenedor.Menu_Mensajes.Text = "(-) Mensajes |"
            MDIContenedor.Menu_Mensajes.ToolTipText = "No se pudo comprobar los Mensajes"
        End If
    End Sub

    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function

    Public Sub SetearCheckboxlist(ByVal clb As CheckedListBox, ByVal check_items As Boolean)
        For i As Integer = 0 To clb.Items.Count - 1
            clb.SetItemChecked(i, check_items)
        Next i
    End Sub

    'Funcion que Envia un correo electronico.
    Public Function EnviarMail(ByVal eMail As Entidades.Mail) As String
        Try
            'Declaracion de Variables.
            Dim SmtpServer As New SmtpClient()
            Dim PORT As String = My.Settings("MailPort")
            Dim HOST As String = My.Settings("MailHost")
            Dim USER As String = My.Settings("MailUsuario")
            Dim PASS As String = My.Settings("MailPassword")

            'Configuracion del Servidor SMTP
            SmtpServer.Credentials = New Net.NetworkCredential(USER, PASS)
            SmtpServer.Port = PORT
            SmtpServer.Host = HOST

            'Creo una instancia de la clase mail.
            Dim mail As New MailMessage()
            mail = New MailMessage()

            'De.
            mail.From = New MailAddress(eMail.Fromm)

            'Para.
            mail.To.Add(eMail.Too)

            'Asunto
            mail.Subject = eMail.Subject

            'Prioridad.
            mail.Priority = MailPriority.Normal

            'Cuerpo del mail.
            mail.IsBodyHtml = True
            mail.Body = eMail.Body

            'Si hay mail para CCO.
            If Not eMail.CCO Is Nothing And eMail.CCO <> String.Empty Then
                mail.Bcc.Add(New MailAddress(eMail.CCO))
            End If

            'Si se hay mail para CC.
            If Not eMail.CC Is Nothing And eMail.CC <> String.Empty Then
                mail.CC.Add(New MailAddress(eMail.CC))
            End If

            'Si se hay mail para ReplyTo.
            If Not eMail.ReplyTo Is Nothing And eMail.ReplyTo <> String.Empty Then
                mail.ReplyToList.Add(New MailAddress(eMail.ReplyTo))
            End If

            'Envio de Mail.
            SmtpServer.Send(mail)

            'Limpio.
            SmtpServer.Dispose()
            mail.Dispose()

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Funcion que reemplaza los caracteres para la controladora.
    Public Function ReemplazarCaracteres(ByVal Cadena As String)
        Dim CadenaFinal As String = ""
        CadenaFinal = Cadena.ToLower()                  'Paso a minuscula todo el string.
        CadenaFinal = Replace(CadenaFinal, "í", "¡")    'Reemplazo i.
        CadenaFinal = Replace(CadenaFinal, "ó", "¢")    'Reemplazo ó.
        CadenaFinal = Replace(CadenaFinal, "á", " ")    'Reemplazo á.
        CadenaFinal = Replace(CadenaFinal, "é", "‚")    'Reemplazo é.
        CadenaFinal = Replace(CadenaFinal, "ú", "£")    'Reemplazo ú.
        CadenaFinal = Replace(CadenaFinal, "ñ", "¤")    'Reemplazo ñ.
        Return CadenaFinal
    End Function

    'Formateo Importe.
    Public Function FormatearPrecio(ByVal num As String, Optional ByVal pot As Integer = 4)
        Dim SinComas, SinPuntos As String
        Dim NumeroFinal As Integer
        num = (num * (10 ^ pot))
        SinComas = Replace(num, ",", "")
        SinPuntos = Replace(SinComas, ".", "")
        NumeroFinal = Integer.Parse(SinPuntos)
        Return NumeroFinal
    End Function

    'Formateo Cantidad.
    Public Function FormatearCantidad(ByVal cant As String)
        Dim CantidadFinal As Integer
        CantidadFinal = (cant * 10000)
        CantidadFinal = Integer.Parse(CantidadFinal)
        Return CantidadFinal
    End Function

    'Dependiendo del nombre del dia me devuelve el valor.
    Public Function ObtenerNumeroMes(ByVal mes As String)
        Dim value As Integer = 1
        Select Case mes
            Case "enero" : value = 1
            Case "febrero" : value = 2
            Case "marzo" : value = 3
            Case "abril" : value = 4
            Case "mayo" : value = 5
            Case "junio" : value = 6
            Case "julio" : value = 7
            Case "agosto" : value = 8
            Case "septiembre" : value = 9
            Case "octubre" : value = 10
            Case "noviembre" : value = 11
            Case "diciembre" : value = 12
        End Select

        Return value
    End Function

    'Dependiendo del nombre del periodo me devuelve el valor.
    Public Function ObtenerNumeroPeriodo(ByVal Periodo As String)
        Dim value As Integer = 0
        Select Case Periodo
            Case "Mes completo" : value = 0
            Case "Primera Quincena" : value = 1
            Case "Segunda Quincena" : value = 2
        End Select

        Return value
    End Function

    'Limpia el objeto.
    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    'Carga un combo con años del 2011 +10.
    Public Sub CargarComboAnios(ByVal combo As ComboBox)
        'Cargo el combo con los anios.
        For j = 2011 To (Now.Year + 10)
            combo.Items.Add(j)
        Next
        combo.SelectedItem = Now.Year
    End Sub

    'Carga un combo con todos los meses del año.
    Public Sub CargarComboMeses(ByVal combo As ComboBox)
        'Cargo el combo con los meses.
        For I As Integer = 1 To 12
            combo.Items.Add(MonthName(I))
        Next
        Dim datetimeFormat = Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat
        combo.SelectedItem = datetimeFormat.GetMonthName(Date.Today.Month)
    End Sub

    'Funcion que crea un datatable dependiendo del dataset enviado.
    Function CrearDataTable(ByVal NameID As String, ByVal NameDescr As String, ByVal Datos As DataSet, Optional ByVal Item As String = "Seleccione una opción") As DataTable
        Dim dt As New DataTable

        'Creo La columna de Identificacion
        Dim column As New Data.DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = NameID
        dt.Columns.Add(column)

        'Creo la columna de Descripcion
        Dim column2 As New Data.DataColumn
        column2.DataType = Type.GetType("System.String")
        column2.ColumnName = NameDescr
        dt.Columns.Add(column2)

        'Fila default.
        Dim rowdefault As Data.DataRow
        rowdefault = dt.NewRow
        rowdefault.Item(NameID) = "0"
        rowdefault.Item(NameDescr) = Item
        dt.Rows.Add(rowdefault)

        'Inserto las filas
        For Each filas In Datos.Tables(0).Rows
            Dim row As Data.DataRow
            row = dt.NewRow
            row.Item(NameID) = filas.item(NameID).ToString
            row.Item(NameDescr) = filas.item(NameDescr).ToString
            dt.Rows.Add(row)
        Next
        Return dt
    End Function

End Class
