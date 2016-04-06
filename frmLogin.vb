Imports Entidades
Imports Negocio
Imports System.Configuration
Imports System.Resources

Public Class frmLogin
    Dim encripta As New ClsEncriptacion
    Dim entUsuario As New Entidades.Usuario
    Dim objUsuario As New Negocio.Usuario
    Dim negFunciones As New Negocio.Funciones
    Dim Functions As New Funciones

    'Cuando el usuario hace click en "Aceptar".
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            'Seteo el cursor
            Me.Cursor = Cursors.WaitCursor

            'Declaracion de Variables.
            Dim usuario As String
            Dim pwd As String
            Dim Sucursal As String

            'Seteo de Variables.
            usuario = Trim(txtUsuario.Text.ToLower)
            pwd = encripta.EncriptarMD5(Trim(txtPWD.Text.ToLower))
            Sucursal = My.Settings("Sucursal")

            'Oculto los Controles.
            OcultarControlesLogin()

            'Actualizo el estado de la conexion.
            Functions.ActualizarEstado()

            If Not (VariablesGlobales.HayConexion) Then
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("No se ha encontrado conexión a internet. Se iniciará el sistema de forma local.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            'Seteo el cursor
            Me.Cursor = Cursors.WaitCursor

            'Realizo el login.
            entUsuario = objUsuario.Login(usuario, pwd)

            'Si se logueo correctamente.
            If (entUsuario.id_Usuario <> 0) Then

                'Asigno el usuario a la barra de estado.
                MDIContenedor.Usuario.Text = entUsuario.Nombre & " " & entUsuario.Apellido & " |"

                'Almaceno las patentes.
                VariablesGlobales.Patentes = objUsuario.CargarPatentes(entUsuario.id_Usuario, Sucursal)

                'Almaceno el usuario logueado.
                VariablesGlobales.objUsuario = entUsuario

                'Actualizo los mensajes del usuario
                Functions.ActualizarMensajes()

                'Obtengo las notificaciones
                Functions.ActualizarNotificaciones()

                'Obtengo los Cheuqes a Vencer notificaciones
                Functions.ActualizarChequesVencer()

                'Obtengo los Cheuqes a Vencer notificaciones
                Functions.ActualizarNotasPedidos()

                'Seteo a default el cursor.
                Me.Cursor = Cursors.Default

                'oculto el login.
                Me.Visible = False

                'Muestro el form mdi
                MDIContenedor.Show()
                MDIContenedor.WindowState = 2
                MDIContenedor.MenuSuperior.Visible = True
                MDIContenedor.MenuInferior.Visible = True
                MDIContenedor.MenuAccesosRapidos.Visible = True
                RestaurarControlesLogin()
            Else
                RestaurarControlesLogin()
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Los datos ingresados no son validos.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            RestaurarControlesLogin()
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se produjo un error en el acceso al sistema. Contacte al administrador.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Cuando el usuario hace click en "Cancelar".
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    'Funcion que restaura todos los controles del formulario.
    Sub RestaurarControlesLogin()
        'Muestro los controles
        txtPWD.Clear()
        txtUsuario.Clear()
        txtPWD.Visible = True
        txtUsuario.Visible = True
        UsernameLabel.Visible = True
        PasswordLabel.Visible = True
        lbl_Cargando.Visible = False
        OK.Visible = True
        OK.Enabled = True
        txtUsuario.Focus()
        Me.Refresh()
    End Sub

    'Funcion que oculta todos los controles del formulario.
    Sub OcultarControlesLogin()
        txtPWD.Visible = False
        txtUsuario.Visible = False
        UsernameLabel.Visible = False
        PasswordLabel.Visible = False
        lbl_Cargando.Visible = True
        OK.Visible = False
        OK.Enabled = False
        Me.Refresh()
    End Sub

    'Chequea que sólo haya una instancia del sistema corriendose.
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Usamos la clase Process para sacar información de procesos en ejecución.
        'Definimos una matríz de procesos    
        Dim MisProcesos() As Process

        'Asignamos a la matríz todos los procesos en ejecución 
        'que tengan por nombre el de nuestra aplicación.
        MisProcesos = Process.GetProcessesByName(Application.ProductName.ToString)

        'MisProcesos.Length nunca es cero, porque
        'este mismo proceso cuenta;
        'por eso miramos si solo hay una coincidencia.
        If MisProcesos.Length <= 1 Then
        Else 'Hay más de un proceso ejecutandose
            MessageBox.Show("La aplicación ya se está ejecutando.", "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If
    End Sub
End Class
