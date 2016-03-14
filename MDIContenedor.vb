Imports System.Windows.Forms
Imports System.Configuration
Imports System.Resources

Public Class MDIContenedor
    Dim Funciones As New Funciones
    Dim objusuario As New Negocio.Usuario
    Dim NegPatentes As New Negocio.NegPatentes
    Dim id_Sucursal As Integer = CInt(My.Settings("Sucursal"))
    Dim negFunciones As New Negocio.Funciones
    Dim negMovimiento As New Negocio.NegMovimientos
    Dim NegCaja As New Negocio.NegCajaInicial

    Dim tiempoAcumuladoNotificaciones As Integer = 0
    Dim tiempoAcumuladoMensajes As Integer = 0
    Dim tiempoAcumuladoCheques As Integer = 0

    Private Sub MDIContenedor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If VariablesGlobales.Notificaciones > 0 Then 'Si posee notificaciones pendientes.
            If MessageBox.Show("¿Posee " & VariablesGlobales.Notificaciones & " notificacion(es) pendiente(s). ¿Está seguro de que desea salir de la aplicación?", "Sistema de Gestión " & My.Settings("Empresa"), _
    MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
    MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                frmLogin.Close()
            End If
        Else 'si no posee notificaciones pendientes.
            If MessageBox.Show("¿Está seguro de que desea salir de la aplicación?", "Sistema de Gestión " & My.Settings("Empresa"), _
    MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
    MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                frmLogin.Close()
            End If
        End If
    End Sub

    Sub SetearVisualesPatentes()
        Try
            'Cursor
            Me.Cursor = Cursors.WaitCursor

            'Total de Patentes
            Dim TotalPatentes As Integer = 25

            'Muestro todas las barras
            Me.MenuSuperior.Visible = True
            Me.MenuInferior.Visible = True
            Me.MenuAccesosRapidos.Visible = True

            'Muestro el form de espera..
            frmCargadorAltaProductos.Show()
            frmCargadorAltaProductos.Text = "Cargando Patentes del Usuario " & VariablesGlobales.objUsuario.Usuario & " ..."
            frmCargadorAltaProductos.BarraProgreso.Minimum = 0
            frmCargadorAltaProductos.BarraProgreso.Maximum = TotalPatentes

            'Dependiendo de las patentes del usuario muestro u oculto los botones.
            'AROMAS
            If Not (objusuario.EsPatenteValida(207, VariablesGlobales.Patentes)) Then
                Me.Btn_AromasMenu.Visible = False
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'RECIBOS DE SUELDO
            If Not (objusuario.EsPatenteValida(232, VariablesGlobales.Patentes)) Then
                Me.ReciboDeSueldoToolStripMenuItem.Visible = False
            Else
                Me.ReciboDeSueldoToolStripMenuItem.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'MOVIMIENTOS
            If Not (objusuario.EsPatenteValida(233, VariablesGlobales.Patentes)) Then
                Me.MovimientosToolStripMenuItem.Visible = False
                Me.HistorialDeDifCajaToolStripMenuItem.Visible = False
                Me.AccesoCajaFuerte.Visible = False
                Me.AccesoGastos.Visible = False
                Me.AccesoEgresos.Visible = False
                Me.AccesoDiferencia.Visible = False
                Me.AccesoImpuestos.Visible = False
                Me.AccesoRetiro.Visible = False
                Me.AccesoMovimientos.Visible = False
            Else
                Me.MovimientosToolStripMenuItem.Visible = True
                Me.HistorialDeDifCajaToolStripMenuItem.Visible = True
                Me.AccesoCajaFuerte.Visible = True
                Me.AccesoGastos.Visible = True
                Me.AccesoEgresos.Visible = True
                Me.AccesoDiferencia.Visible = True
                Me.AccesoImpuestos.Visible = True
                Me.AccesoRetiro.Visible = True
                Me.AccesoMovimientos.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'REGISTROS DE EMPLEADOS
            If Not (objusuario.EsPatenteValida(229, VariablesGlobales.Patentes)) Then
                Me.RegistroDeEmpleadosToolStripMenuItem.Visible = False
            Else
                Me.RegistroDeEmpleadosToolStripMenuItem.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'COLORES
            If Not (objusuario.EsPatenteValida(151, VariablesGlobales.Patentes)) Then
                Me.Btn_ColoresMenu.Visible = False
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'MATERIALES
            If Not (objusuario.EsPatenteValida(203, VariablesGlobales.Patentes)) Then
                Me.Btn_MaterialesMenu.Visible = False
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'PRODUCTOS
            If Not (objusuario.EsPatenteValida(11, VariablesGlobales.Patentes)) Then
                Me.Btn_ProductosSubM.Visible = False
                Me.AccesosProductos.Visible = False
            Else
                Me.Btn_ProductosSubM.Visible = True
                Me.AccesosProductos.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'PLANILLAS
            If Not (objusuario.EsPatenteValida(231, VariablesGlobales.Patentes)) Then
                Me.Btn_PlanillasMenu.Visible = False
            Else
                Me.Btn_PlanillasMenu.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'CAMBIOS Y DEVOLUCIONES
            If Not (objusuario.EsPatenteValida(230, VariablesGlobales.Patentes)) Then
                Me.Btn_DevolucionesMenu.Visible = False
                Me.AccesoCambios.Visible = False
            Else
                Me.Btn_DevolucionesMenu.Visible = True
                Me.AccesoCambios.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'PRODUCTOS - CATEGORIAS
            If Not (objusuario.EsPatenteValida(211, VariablesGlobales.Patentes)) Then
                Me.Btn_ProductosCatSubM.Visible = False
            Else
                Me.Btn_ProductosCatSubM.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'PRODUCTOS - SUBCATEGORIAS
            If Not (objusuario.EsPatenteValida(215, VariablesGlobales.Patentes)) Then
                Me.Btn_ProductosSubcatSubM.Visible = False
            Else
                Me.Btn_ProductosSubcatSubM.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'PRODUCTOS - ALTA MASIVA
            If Not (objusuario.EsPatenteValida(222, VariablesGlobales.Patentes)) Then
                Me.Btn_ProductosMasivosSubM.Visible = False
                Me.AccesoMercaderias.Visible = False
            Else
                Me.Btn_ProductosMasivosSubM.Visible = True
                Me.AccesoMercaderias.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'PROVEEDORES
            If Not (objusuario.EsPatenteValida(218, VariablesGlobales.Patentes)) Then
                Me.Btn_ProveedoresMenu.Visible = False
            Else
                Me.Btn_ProveedoresMenu.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'PERFILES
            If Not (objusuario.EsPatenteValida(155, VariablesGlobales.Patentes)) Then
                Me.Btn_PerfilesMenu.Visible = False
            Else
                Me.Btn_PerfilesMenu.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'CUENTAS CORRIENTES
            If Not (objusuario.EsPatenteValida(299, VariablesGlobales.Patentes)) Then
                Me.CuentaCorrienteToolStripMenuItem.Visible = False
            Else
                Me.CuentaCorrienteToolStripMenuItem.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'USUARIOS
            If Not (objusuario.EsPatenteValida(3, VariablesGlobales.Patentes)) Then
                Me.Btn_UsuariosMenu.Visible = False
            Else
                Me.Btn_UsuariosMenu.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'RESUMEN DIARIO
            If Not (objusuario.EsPatenteValida(298, VariablesGlobales.Patentes)) Then
                Me.AccesoResumen.Visible = False
            Else
                Me.AccesoResumen.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'SUCURSALES
            If Not (objusuario.EsPatenteValida(225, VariablesGlobales.Patentes)) Then
                Me.Btn_SucursalesMenu.Visible = False
            Else
                Me.Btn_SucursalesMenu.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'FERIADOS
            If Not (objusuario.EsPatenteValida(227, VariablesGlobales.Patentes)) Then
                Me.Btn_FeriadosMenu.Visible = False
            Else
                Me.Btn_FeriadosMenu.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'CONFIGURACION DEL SISTEMA
            If Not (objusuario.EsPatenteValida(217, VariablesGlobales.Patentes)) Then
                Me.Btn_ConfiguracionMenu.Visible = False
            Else
                Me.Btn_ConfiguracionMenu.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1


            'SINCRONIZACIÓN DE BDD
            If Not (objusuario.EsPatenteValida(301, VariablesGlobales.Patentes)) Then
                Me.Btn_SincronizaciónMenu.Visible = False
            Else
                Me.Btn_SincronizaciónMenu.Visible = True
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'STOCK
            'Traigo todas las patentes dependiendo de la sucursal y el tipo
            Dim Pat2 As DataSet = NegPatentes.ListadoPatentesPorTipo(2, 4, id_Sucursal)
            If Pat2.Tables(0).Rows.Count > 0 Then
                For Each p In Pat2.Tables(0).Rows
                    Dim id_Patente As Integer = CInt(p.item("id_Patente"))
                    If Not (objusuario.EsPatenteValida(id_Patente, VariablesGlobales.Patentes)) Then
                        Me.Btn_StockMenu.Visible = False
                    Else
                        Me.Btn_StockMenu.Visible = True
                    End If
                Next
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'EMPLEADOS
            'Traigo todas las patentes dependiendo de la sucursal y el tipo
            Dim Pat3 As DataSet = NegPatentes.ListadoPatentesPorTipo(3, 4, id_Sucursal)
            If Pat3.Tables(0).Rows.Count > 0 Then
                For Each p In Pat3.Tables(0).Rows
                    Dim id_Patente As Integer = CInt(p.item("id_Patente"))
                    If Not (objusuario.EsPatenteValida(id_Patente, VariablesGlobales.Patentes)) Then
                        Me.Btn_EmpleadosMenu.Visible = False
                    Else
                        Me.Btn_EmpleadosMenu.Visible = True
                    End If
                Next
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1

            'VENTAS
            'Traigo todas las patentes dependiendo de la sucursal y el tipo
            Dim Pat4 As DataSet = NegPatentes.ListadoPatentesPorTipo(4, 4, id_Sucursal)
            If Pat4.Tables(0).Rows.Count > 0 Then
                For Each p In Pat4.Tables(0).Rows
                    Dim id_Patente As Integer = CInt(p.item("id_Patente"))
                    If Not (objusuario.EsPatenteValida(id_Patente, VariablesGlobales.Patentes)) Then
                        Me.Btn_VentasMenu.Visible = False
                        Me.AccesoVentas.Visible = False
                    Else
                        Me.Btn_VentasMenu.Visible = True
                        Me.AccesoVentas.Visible = True
                    End If
                Next
            End If
            'Voy seteando la barra de progreso
            frmCargadorAltaProductos.BarraProgreso.Value += 1
            frmCargadorAltaProductos.Close()
            frmCargadorAltaProductos.Dispose()

            'Cursor
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            frmCargadorAltaProductos.Close()
            frmCargadorAltaProductos.Dispose()
        End Try
    End Sub

    Private Sub MDIContenedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cursor
            Me.Cursor = Cursors.WaitCursor

            'Setea el nombre de la aplicacion.
            Me.Text = "Sistema de Gestion " & My.Settings.Empresa & " - " & My.Settings.NombreSucursal

            'Seteo la cultura del proyecto.
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")

            'Seteo los temporizadores.
            Temporizador.Interval = My.Settings.TemporizadorInternet

            'seteo el icono.
            Dim icono As System.Drawing.Icon
            icono = My.Resources.Recursos.Cinderella
            Me.Icon = icono

            'Actualizo el fondo.
            Me.BackgroundImageLayout = ImageLayout.Stretch

            'icono de notificacion
            NotifyIcon.Icon = icono
            NotifyIcon.Text = Me.Text

            SetearVisualesPatentes()

            'Cursor
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar las permisos del usuario. Por favor, Comuníqueselo al administrador. ", "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            'Cursor
            Me.Cursor = Cursors.WaitCursor

            'Compruebo que las cajas de fechas anteriores estén cerradas.
            Dim TotCajas As Integer = NegCaja.ComprobarCajas(id_Sucursal)
            Dim FechaHoy As Date = Now

            If TotCajas > 0 Then
                'Sino lo están, las calculo
                If (MessageBox.Show("Se han encontrado " & TotCajas & " cajas diarias pendientes." & vbCrLf & "Presione OK para comenzar a calcular los cierres de caja pendientes. Ésta operación puede tardar unos minutos.", "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = vbOK) Then
                    'Si la cant. de dias es mayor a cero, voy calculando las cajas.

                    'Muestro el form de espera..
                    frmCargadorDeEspera.Show()
                    frmCargadorDeEspera.Text = "Calculando Cajas Pendientes... "
                    frmCargadorDeEspera.lbl_Descripcion.Text = "Iniciando... "
                    frmCargadorDeEspera.BarraProgreso.Minimum = 0
                    frmCargadorDeEspera.BarraProgreso.Maximum = TotCajas + 1
                    frmCargadorDeEspera.BarraProgreso.Value = 1
                    frmCargadorDeEspera.Refresh()

                    'Disminuyo el dia de hoy hasta que cumpla con la cantidad de dias faltantes.
                    For d = TotCajas To 1 Step -1
                        'Fecha anterior.
                        Dim FechaAnterior As Date
                        Dim Resultado As Integer = 0
                        Dim entCajaCerrada As New Entidades.CajaInicial
                        Dim di As Integer = 0

                        di = (d * -1)
                        FechaAnterior = FechaHoy.AddDays(di)

                        'Voy seteando la barra de progreso
                        frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo Cierre de Caja del " & FechaAnterior.ToString("dd/MM/yyyy")
                        frmCargadorDeEspera.BarraProgreso.Value += 1
                        frmCargadorDeEspera.Refresh()

                        'Calculo la caja para la fecha dada.
                        entCajaCerrada.id_Empleado = VariablesGlobales.objUsuario.id_Usuario
                        entCajaCerrada.id_Sucursal = id_Sucursal
                        entCajaCerrada.Abierta = 0
                        entCajaCerrada.Empleado = VariablesGlobales.objUsuario.Usuario
                        entCajaCerrada.Monto = NegCaja.ObtenerSaldo(id_Sucursal, FechaAnterior)
                        entCajaCerrada.Fecha = FechaAnterior
                        entCajaCerrada.Hora = Now
                        NegCaja.CerrarCaja(entCajaCerrada)
                    Next

                    'Voy seteando la barra de progreso
                    frmCargadorDeEspera.Close()
                    frmCargadorDeEspera.Dispose()
                End If
            End If

            'Compriebo si la caja diaria está abierta o cerrada.
            'Muestro el detalle de la caja cerrada.
            Dim FNueva As String = ""
            Dim entCajaNueva As New Entidades.CajaInicial
            FNueva = Now.Date.ToString("yyyy/MM/dd")
            entCajaNueva = NegCaja.ObtenerCaja(id_Sucursal, FNueva)

            If entCajaNueva.id_Caja > 0 Then
                Me.MenuAccesosRapidos.Visible = False
                Me.ToolsMenu.Visible = False
                Me.SeguridadToolStripMenuItem.Visible = False
                Me.Btn_SincronizacionMenu.Visible = False
                Me.Btn_ResumenDiario.Visible = True
                Me.BackgroundImageLayout = ImageLayout.Stretch
                Me.Refresh()
                VariablesGlobales.CajaCerrada = 1
            Else
                Me.MenuAccesosRapidos.Visible = True
                Me.ToolsMenu.Visible = True
                Me.SeguridadToolStripMenuItem.Visible = True
                Me.Btn_SincronizacionMenu.Visible = True
                Me.Btn_ResumenDiario.Visible = False
                Me.BackgroundImageLayout = ImageLayout.Stretch
                Me.Refresh()
                VariablesGlobales.CajaCerrada = 0
            End If

            'Refresco
            Me.Refresh()

            'Cursor
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al calcular las cajas pendientes. Por favor, Comuníqueselo al administrador. ", "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Temporizador_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Temporizador.Tick
        Funciones.ActualizarEstado()
    End Sub

    Private Sub Btn_ColoresMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ColoresMenu.Click
        'para administrar colores es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmColores).MdiParent = Me
            Funciones.ControlInstancia(frmColores).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub Btn_ClientesMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ClientesMenu.Click
        'para administrar clientes es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmClientes).MdiParent = Me
            Funciones.ControlInstancia(frmClientes).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub Btn_PerfilesMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PerfilesMenu.Click
        'para administrar perfiles es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmPerfiles).MdiParent = Me
            Funciones.ControlInstancia(frmPerfiles).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub Btn_UsuariosMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_UsuariosMenu.Click
        'para administrar usuarios es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmUsuarios).MdiParent = Me
            Funciones.ControlInstancia(frmUsuarios).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub MaterialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_MaterialesMenu.Click
        'para administrar materiales es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMateriales).MdiParent = Me
            Funciones.ControlInstancia(frmMateriales).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub Btn_AromasMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AromasMenu.Click
        'para administrar aromas es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmAromas).MdiParent = Me
            Funciones.ControlInstancia(frmAromas).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub BandejaDeEntradaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_BandejaDeEntradaMenu.Click
        'para administrar mensajes es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMailBandeja).MdiParent = Me
            Funciones.ControlInstancia(frmMailBandeja).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub NuevoMensajeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_NuevoMensajeMenu.Click
        'para enviar mensajes es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMailNuevo).MdiParent = Me
            Funciones.ControlInstancia(frmMailNuevo).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub InformaciónPersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_InformaciónPersonalMenu.Click
        'para ver el perfil no es necesario esta online
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmMiCuenta).MdiParent = Me
        Funciones.ControlInstancia(frmMiCuenta).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ProductosSubM.Click
        'para administrar productos es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmProductos).MdiParent = Me
            Funciones.ControlInstancia(frmProductos).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ProductosCatSubM.Click
        'para administrar categorias de productos es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmProductosCat).MdiParent = Me
            Funciones.ControlInstancia(frmProductosCat).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub SubcategoriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ProductosSubcatSubM.Click
        'para administrar subcategorias de productos es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmProductosSubcat).MdiParent = Me
            Funciones.ControlInstancia(frmProductosSubcat).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AltaMasivaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ProductosMasivosSubM.Click
        'para hacer un alta masiva de productos es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmProductosMasiva).MdiParent = Me
            Funciones.ControlInstancia(frmProductosMasiva).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        'Oculto todos los menus.
        Me.MenuSuperior.Visible = False
        Me.MenuInferior.Visible = False
        Me.MenuAccesosRapidos.Visible = False
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.Refresh()

        'Seteo en cero todas las variables globales.
        VariablesGlobales.Patentes = Nothing
        VariablesGlobales.objUsuario = Nothing
        VariablesGlobales.Notificaciones = 0
        VariablesGlobales.Mensajes = 0
        VariablesGlobales.HayConexion = False
        VariablesGlobales.CajaCerrada = 0

        'Cierro todos los formularios abiertos.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

        'Abro el form de login.
        frmLogin.Show()
        frmLogin.txtUsuario.Focus()
    End Sub

    Private Sub FeriadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_FeriadosMenu.Click
        'para administrar feriados es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmFeriados).MdiParent = Me
            Funciones.ControlInstancia(frmFeriados).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AdmDeStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmDeStockToolStripMenuItem.Click
        'para administrar stock no es necesario esta online
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmStock).MdiParent = Me
        Funciones.ControlInstancia(frmStock).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub AltaMasivaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaMasivaToolStripMenuItem.Click
        'para administrar stock no es necesario esta online
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmStockMasiva).MdiParent = Me
        Funciones.ControlInstancia(frmStockMasiva).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Btn_EtiquetasMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_EtiquetasMenu.Click
        'para administrar feriados es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmEtiquetas).MdiParent = Me
            Funciones.ControlInstancia(frmEtiquetas).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AdmDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmDeEmpleadosToolStripMenuItem.Click
        'para administrar empelados es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmEmpleados).MdiParent = Me
            Funciones.ControlInstancia(frmEmpleados).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub RegistroDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeEmpleadosToolStripMenuItem.Click
        'para administrar empelados es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmEmpleadosRegistro).MdiParent = Me
            Funciones.ControlInstancia(frmEmpleadosRegistro).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AdelantoDeEfectivoAEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'para administrar empelados es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmAdelantoEfectivo).MdiParent = Me
            Funciones.ControlInstancia(frmAdelantoEfectivo).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AdmDeSucursalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmDeSucursalesToolStripMenuItem.Click
        'para administrar sucursales es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmSucursales).MdiParent = Me
            Funciones.ControlInstancia(frmSucursales).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub VisualizaciónDeSaldoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizaciónDeSaldoToolStripMenuItem.Click
        'para visualizar saldos de empleados es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmEmpleadosSaldos).MdiParent = Me
            Funciones.ControlInstancia(frmEmpleadosSaldos).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub VentasToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem1.Click
        'para administrar ventas no es necesario esta online
        Me.Cursor = Cursors.WaitCursor
        Dim frmVentas As frmVentas = New frmVentas()
        frmVentas.MdiParent = Me
        frmVentas.Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub AdministraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministraciónToolStripMenuItem.Click
        'para administrar ventas no es necesario esta online
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmVentasAdministracion).MdiParent = Me
        Funciones.ControlInstancia(frmVentasAdministracion).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub EstadoDeCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadoDeCuentaToolStripMenuItem.Click
        'para administrar ventas no es necesario esta online
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmSucursalesSaldos).MdiParent = Me
        Funciones.ControlInstancia(frmSucursalesSaldos).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub PreciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreciosToolStripMenuItem.Click
        'para modificar los precios de los productos es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmProductosPrecios).MdiParent = Me
            Funciones.ControlInstancia(frmProductosPrecios).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoVentas.Click
        'para administrar ventas no es necesario esta online
        Me.Cursor = Cursors.WaitCursor
        Dim frmVentas As frmVentas = New frmVentas()
        frmVentas.MdiParent = Me
        frmVentas.Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub AccesosProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesosProductos.Click
        'para administrar productos es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmProductos).MdiParent = Me
            Funciones.ControlInstancia(frmProductos).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AccesosPrecios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesosPrecios.Click
        'para buscar precios no es necesario esta online
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmBuscarPrecioProductos).MdiParent = Me
        Funciones.ControlInstancia(frmBuscarPrecioProductos).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub VerOcultarAccesosRápidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerOcultarAccesosRápidosToolStripMenuItem.Click
        Me.BackgroundImageLayout = ImageLayout.Stretch
        If MenuAccesosRapidos.Visible Then
            MenuAccesosRapidos.Visible = False
            VerOcultarAccesosRápidosToolStripMenuItem.Checked = False
        Else
            MenuAccesosRapidos.Visible = True
            VerOcultarAccesosRápidosToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub CambiosYDevolucionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'para administrar cambios no es necesario esta online
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmDevoluciones).MdiParent = Me
        Funciones.ControlInstancia(frmDevoluciones).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub AccesoCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoCambios.Click
        'para administrar cambios no es necesario esta online
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmDevoluciones).MdiParent = Me
        Funciones.ControlInstancia(frmDevoluciones).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucursalesToolStripMenuItem.Click
        'para administrar productos es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmPlanillaSucursales).MdiParent = Me
            Funciones.ControlInstancia(frmPlanillaSucursales).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub SueldosDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SueldosDeEmpleadosToolStripMenuItem.Click
        'para administrar productos es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmPlanillaEmpleados).MdiParent = Me
            Funciones.ControlInstancia(frmPlanillaEmpleados).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub ReciboDeSueldoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReciboDeSueldoToolStripMenuItem.Click
        'para administrar recibo de sueldo es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmReciboSueldo).MdiParent = Me
            Funciones.ControlInstancia(frmReciboSueldo).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub MDIContenedor_MaximumSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MaximumSizeChanged
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub MDIContenedor_MinimumSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MinimumSizeChanged
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub AccesoGastos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoGastos.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoGasto).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoGasto).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AccesoEgresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoEgresos.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoEgreso).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoEgreso).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AccesoImpuestos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoImpuestos.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoImpuesto).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoImpuesto).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AccesoDiferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoDiferencia.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoCaja).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoCaja).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AccesoRetiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoRetiro.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoSocios).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoSocios).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub GastosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GastosToolStripMenuItem.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoGasto).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoGasto).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub EgresosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EgresosToolStripMenuItem.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoEgreso).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoEgreso).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub ImpuestosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImpuestosToolStripMenuItem.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoImpuesto).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoImpuesto).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub DifDeCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DifDeCajaToolStripMenuItem.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoCaja).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoCaja).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub RetiroSociosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetiroSociosToolStripMenuItem.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoSocios).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoSocios).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AccesoMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoMovimientos.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoPlanilla).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoPlanilla).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub TemporizadorActualizaciones_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemporizadorActualizaciones.Tick

        'Acumulo el tiempo transcurrido
        tiempoAcumuladoNotificaciones += TemporizadorActualizaciones.Interval
        'En caso de que el tiempo acumulado sea mayo o igual al tiempo para mostrar la alertas de movimientos
        If (tiempoAcumuladoNotificaciones >= Integer.Parse(My.Settings("TemporizadorMovimientos"))) Then
            'Muestro la alerta de movimientos y reinicio el acumulador de tiempo
            Funciones.ActualizarNotificaciones("Full")
            tiempoAcumuladoNotificaciones = 0
        End If

        'Acumulo el tiempo transcurrido
        tiempoAcumuladoMensajes += TemporizadorActualizaciones.Interval
        'En caso de que el tiempo acumulado sea mayo o igual al tiempo para mostrar la alertas de mensajes
        If (tiempoAcumuladoMensajes >= Integer.Parse(My.Settings("TemporizadorMensajes"))) Then
            'Muestro la alerta de mensajes y reinicio el acumulador de tiempo
            Funciones.ActualizarMensajes()
            tiempoAcumuladoMensajes = 0
        End If

        'Acumulo el tiempo transcurrido
        tiempoAcumuladoCheques += TemporizadorActualizaciones.Interval
        'En caso de que el tiempo acumulado sea mayo o igual al tiempo para mostrar la alertas de cheques
        If (tiempoAcumuladoCheques >= Integer.Parse(My.Settings("TemporizadorCheques"))) Then
            'Muestro la alerta de cheques y reinicio el acumulador de tiempo
            Funciones.ActualizarChequesVencer()
            tiempoAcumuladoCheques = 0
        End If

    End Sub

    Private Sub Menu_Movimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Movimientos.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmNotificacionesListado).MdiParent = Me
            Funciones.ControlInstancia(frmNotificacionesListado).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub SincronizaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SincronizaciónMenu.Click
        'para sincronizar el sistema es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmSincronizacion).MdiParent = Me
            Funciones.ControlInstancia(frmSincronizacion).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub Btn_ConfiguracionMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ConfiguracionMenu.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmConfiguracion).MdiParent = Me
        Funciones.ControlInstancia(frmConfiguracion).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub NotificacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_NotificacionesMenu.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmNotificacionesListado).MdiParent = Me
            Funciones.ControlInstancia(frmNotificacionesListado).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub CerrarTodoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarTodoToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MosaicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MosaicoToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MosaicoVerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MosaicoVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MovEntreSucursalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovEntreSucursalesToolStripMenuItem.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmPlanillaEntreSucursales).MdiParent = Me
            Funciones.ControlInstancia(frmPlanillaEntreSucursales).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AccesoMercaderias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoMercaderias.Click
        'para administrar stock no es necesario esta online
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmStockMasiva).MdiParent = Me
        Funciones.ControlInstancia(frmStockMasiva).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub ListadoDeMovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeMovimientosToolStripMenuItem.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoPlanilla).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoPlanilla).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub ListasDePreciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListasDePreciosToolStripMenuItem.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmPlanillaPrecios).MdiParent = Me
            Funciones.ControlInstancia(frmPlanillaPrecios).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoResumen.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmResumenDiario).MdiParent = Me
            Funciones.ControlInstancia(frmResumenDiario).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AdministraciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministraciónToolStripMenuItem1.Click
        'para administrar proveedores es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmProveedores).MdiParent = Me
            Funciones.ControlInstancia(frmProveedores).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub CuentaCorrienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentaCorrienteToolStripMenuItem.Click
        'para administrar proveedores es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmProveedoresCuentaCorriente).MdiParent = Me
            Funciones.ControlInstancia(frmProveedoresCuentaCorriente).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ResumenDiario.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmResumenDiario).MdiParent = Me
            Funciones.ControlInstancia(frmResumenDiario).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub CajaFuerteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaFuerteToolStripMenuItem.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoCajaFuerte).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoCajaFuerte).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AccesoCajaFuerte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoCajaFuerte.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoCajaFuerte).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoCajaFuerte).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub BitácoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BitácoraToolStripMenuItem.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmStockBitacora).MdiParent = Me
            Funciones.ControlInstancia(frmStockBitacora).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub HistorialDeDifCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialDeDifCajaToolStripMenuItem.Click
        'para administrar ésta seccion es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmDiferenciasListado).MdiParent = Me
            Funciones.ControlInstancia(frmDiferenciasListado).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AdicionalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionalesToolStripMenuItem.Click
        'para administrar empelados es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmAdicionales).MdiParent = Me
            Funciones.ControlInstancia(frmAdicionales).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub DevolucionesMenu_Click(sender As Object, e As EventArgs) Handles DevolucionesMenu.Click
        'para administrar cambios no es necesario esta online
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmDevoluciones).MdiParent = Me
        Funciones.ControlInstancia(frmDevoluciones).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub AdministracionDevolucionesMenu_Click(sender As Object, e As EventArgs) Handles AdministracionDevolucionesMenu.Click
        'para administrar devoluciones es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmDevolucionesAdministracion).MdiParent = Me
            Funciones.ControlInstancia(frmDevolucionesAdministracion).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AdministraciónToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AdministraciónToolStripMenuItem2.Click, Menu_ChequesVencer.Click
        'para administrar cheques es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmChequesAdministracion).MdiParent = Me
            Funciones.ControlInstancia(frmChequesAdministracion).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        'para agregar cheques es necesario esta online
        If (VariablesGlobales.HayConexion = False) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmChequesAlta).MdiParent = Me
            Funciones.ControlInstancia(frmChequesAlta).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub
End Class
