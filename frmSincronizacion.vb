Imports Negocio

Public Class frmSincronizacion

    Private Sub frmSincronizacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'seteo el icono
        Dim icono As System.Drawing.Icon
        icono = My.Resources.Recursos.Cinderella
        Me.Icon = icono

        ListaEstado.Columns(0).Width = 370
        ListaEstado.Columns(1).Width = 156
        ListaEstado.StateImageList = ImageList1

        Dim negFunciones As New Negocio.Funciones
        Dim negSincronizacion As New Negocio.NegSincronizacion
        'indico los estados de conexion de ambas bases
        'conexion remota
        If Not (negFunciones.GotInternet) Then
            MessageBox.Show("No se ha encontrado una conexión a internet. No es posible realizar una sincronizacion en este momento.", "Sincronizacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If negSincronizacion.ProbarConectarRemoto Then
            lblEstadoRemota.Text = "CONECTADO"
        Else
            lblEstadoRemota.Text = "ERROR AL CONECTAR"
        End If

        'conexion local
        If negSincronizacion.ProbarConectarLocal Then
            lblEstadoLocal.Text = "CONECTADO"
        Else
            lblEstadoLocal.Text = "ERROR AL CONECTAR"
        End If
    End Sub

    Private Sub btnSincronizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSincronizar.Click
        'limpio la lista
        ListaEstado.Items.Clear()

        Dim sincronizacion As New NegSincronizacion
        Dim estado As Integer = 0
        Dim contador As Integer = 0
        Dim actualizado As New ListViewItem
        btnSincronizar.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        'indico la cantidad de tablas para la barra de progreso
        Dim tablas As Integer = 51
        Dim indicadorprogreso As Integer = Progreso.Maximum / tablas

        'inicio el proceso
        actualizado.Text = "Inicializacion de actualizacion"
        actualizado.SubItems.Add("INICIADO")
        actualizado.StateImageIndex = 2
        ListaEstado.Items.Add(actualizado)

        'actualizo USUARIOS
        estado = sincronizacion.Sincronizar("USUARIOS")
        Dim itemusuarios As New ListViewItem
        itemusuarios.Text = "Actualizacion de USUARIOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemusuarios.StateImageIndex = 0
            itemusuarios.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemusuarios.StateImageIndex = 0
            itemusuarios.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemusuarios.StateImageIndex = 1
            itemusuarios.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemusuarios)
        ListaEstado.Refresh()

        'actualizo ADELANTOS
        estado = sincronizacion.Sincronizar("ADELANTOS")
        Dim itemadelantos As New ListViewItem
        itemadelantos.Text = "Actualizacion de ADELANTOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemadelantos.StateImageIndex = 0
            itemadelantos.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemadelantos.StateImageIndex = 0
            itemadelantos.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemadelantos.StateImageIndex = 1
            itemadelantos.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemadelantos)
        ListaEstado.Refresh()

        'actualizo CUENTA_CORRIENTE
        estado = sincronizacion.Sincronizar("CUENTA_CORRIENTE")
        Dim itemCuenta As New ListViewItem
        itemCuenta.Text = "Actualizacion de CUENTA_CORRIENTE"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemCuenta.StateImageIndex = 0
            itemCuenta.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemCuenta.StateImageIndex = 0
            itemCuenta.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemCuenta.StateImageIndex = 1
            itemCuenta.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemCuenta)
        ListaEstado.Refresh()

        'actualizo CAJA_INICIAL
        estado = sincronizacion.Sincronizar("CAJA_INICIAL")
        Dim itemCaja As New ListViewItem
        itemCaja.Text = "Actualizacion de CAJA_INICIAL"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemCaja.StateImageIndex = 0
            itemCaja.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemCaja.StateImageIndex = 0
            itemCaja.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemCaja.StateImageIndex = 1
            itemCaja.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemCaja)
        ListaEstado.Refresh()

        'actualizo CLIENTES
        estado = sincronizacion.Sincronizar("CLIENTES")
        Dim itemclientes As New ListViewItem
        itemclientes.Text = "Actualizacion de CLIENTES"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemclientes.StateImageIndex = 0
            itemclientes.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemclientes.StateImageIndex = 0
            itemclientes.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemclientes.StateImageIndex = 1
            itemclientes.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemclientes)
        ListaEstado.Refresh()

        'actualizo AROMAS
        estado = sincronizacion.Sincronizar("AROMAS")
        Dim itemaromas As New ListViewItem
        itemaromas.Text = "Actualizacion de AROMAS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemaromas.StateImageIndex = 0
            itemaromas.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemaromas.StateImageIndex = 0
            itemaromas.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemaromas.StateImageIndex = 1
            itemaromas.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemaromas)
        ListaEstado.Refresh()

        'actualizo MATERIALES
        estado = sincronizacion.Sincronizar("MATERIALES")
        Dim itemmateriales As New ListViewItem
        itemmateriales.Text = "Actualizacion de MATERIALES"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemmateriales.StateImageIndex = 0
            itemmateriales.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemmateriales.StateImageIndex = 0
            itemmateriales.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemmateriales.StateImageIndex = 1
            itemmateriales.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemmateriales)
        ListaEstado.Refresh()

        'actualizo MOVIMIENTOS
        estado = sincronizacion.Sincronizar("MOVIMIENTOS")
        Dim itemm As New ListViewItem
        itemm.Text = "Actualizacion de MOVIMIENTOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemm.StateImageIndex = 0
            itemm.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemm.StateImageIndex = 0
            itemm.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemm.StateImageIndex = 1
            itemm.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemm)
        ListaEstado.Refresh()

        'actualizo MOVIMIENTOS_CAJA
        estado = sincronizacion.Sincronizar("MOVIMIENTOS_CAJA")
        Dim itemMov1 As New ListViewItem
        itemMov1.Text = "Actualizacion de MOVIMIENTOS_CAJA"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemMov1.StateImageIndex = 0
            itemMov1.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemMov1.StateImageIndex = 0
            itemMov1.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemMov1.StateImageIndex = 1
            itemMov1.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemMov1)
        ListaEstado.Refresh()

        'actualizo MOVIMIENTOS_EGRESOS
        estado = sincronizacion.Sincronizar("MOVIMIENTOS_EGRESOS")
        Dim itemMov2 As New ListViewItem
        itemMov2.Text = "Actualizacion de MOVIMIENTOS_EGRESOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemMov2.StateImageIndex = 0
            itemMov2.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemMov2.StateImageIndex = 0
            itemMov2.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemMov2.StateImageIndex = 1
            itemMov2.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemMov2)
        ListaEstado.Refresh()

        'actualizo MOVIMIENTOS_GASTOS
        estado = sincronizacion.Sincronizar("MOVIMIENTOS_GASTOS")
        Dim itemMov3 As New ListViewItem
        itemMov3.Text = "Actualizacion de MOVIMIENTOS_GASTOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemMov3.StateImageIndex = 0
            itemMov3.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemMov3.StateImageIndex = 0
            itemMov3.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemMov3.StateImageIndex = 1
            itemMov3.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemMov3)
        ListaEstado.Refresh()

        'actualizo MOVIMIENTOS_IMPUESTOS
        estado = sincronizacion.Sincronizar("MOVIMIENTOS_IMPUESTOS")
        Dim itemMov4 As New ListViewItem
        itemMov4.Text = "Actualizacion de MOVIMIENTOS_IMPUESTOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemMov4.StateImageIndex = 0
            itemMov4.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemMov4.StateImageIndex = 0
            itemMov4.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemMov4.StateImageIndex = 1
            itemMov4.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemMov4)
        ListaEstado.Refresh()

        'actualizo MOVIMIENTOS_MERCADERIAS
        estado = sincronizacion.Sincronizar("MOVIMIENTOS_MERCADERIAS")
        Dim itemMov5 As New ListViewItem
        itemMov5.Text = "Actualizacion de MOVIMIENTOS_MERCADERIAS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemMov5.StateImageIndex = 0
            itemMov5.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemMov5.StateImageIndex = 0
            itemMov5.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemMov5.StateImageIndex = 1
            itemMov5.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemMov5)
        ListaEstado.Refresh()

        'actualizo MOVIMIENTOS_MERCADERIAS
        estado = sincronizacion.Sincronizar("MOVIMIENTOS_MERCADERIAS")
        Dim itemMov6 As New ListViewItem
        itemMov6.Text = "Actualizacion de MOVIMIENTOS_MERCADERIAS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemMov6.StateImageIndex = 0
            itemMov6.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemMov6.StateImageIndex = 0
            itemMov6.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemMov6.StateImageIndex = 1
            itemMov6.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemMov6)
        ListaEstado.Refresh()

        'actualizo MOVIMIENTOS_RETIROS
        estado = sincronizacion.Sincronizar("MOVIMIENTOS_RETIROS")
        Dim itemMov7 As New ListViewItem
        itemMov7.Text = "Actualizacion de MOVIMIENTOS_RETIROS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemMov7.StateImageIndex = 0
            itemMov7.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemMov7.StateImageIndex = 0
            itemMov7.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemMov7.StateImageIndex = 1
            itemMov7.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemMov7)
        ListaEstado.Refresh()

        'actualizo MOVIMIENTOS_SECCIONES
        estado = sincronizacion.Sincronizar("MOVIMIENTOS_SECCIONES")
        Dim itemMov8 As New ListViewItem
        itemMov8.Text = "Actualizacion de MOVIMIENTOS_SECCIONES"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemMov8.StateImageIndex = 0
            itemMov8.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemMov8.StateImageIndex = 0
            itemMov8.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemMov8.StateImageIndex = 1
            itemMov8.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemMov8)
        ListaEstado.Refresh()

        'actualizo MOVIMIENTOS_SUBTIPOS
        estado = sincronizacion.Sincronizar("MOVIMIENTOS_SUBTIPOS")
        Dim itemMov9 As New ListViewItem
        itemMov9.Text = "Actualizacion de MOVIMIENTOS_SUBTIPOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemMov9.StateImageIndex = 0
            itemMov9.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemMov9.StateImageIndex = 0
            itemMov9.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemMov9.StateImageIndex = 1
            itemMov9.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemMov9)
        ListaEstado.Refresh()

        'actualizo MOVIMIENTOS_TIPOS
        estado = sincronizacion.Sincronizar("MOVIMIENTOS_TIPOS")
        Dim itemMov10 As New ListViewItem
        itemMov10.Text = "Actualizacion de MOVIMIENTOS_TIPOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemMov10.StateImageIndex = 0
            itemMov10.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemMov10.StateImageIndex = 0
            itemMov10.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemMov10.StateImageIndex = 1
            itemMov10.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemMov10)
        ListaEstado.Refresh()

        'actualizo MERCADERIAS
        estado = sincronizacion.Sincronizar("MERCADERIAS")
        Dim itemmerca As New ListViewItem
        itemmerca.Text = "Actualizacion de MERCADERIAS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemmerca.StateImageIndex = 0
            itemmerca.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemmerca.StateImageIndex = 0
            itemmerca.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemmerca.StateImageIndex = 1
            itemmerca.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemmerca)
        ListaEstado.Refresh()

        'actualizo MERCADERIAS_DETALLE
        estado = sincronizacion.Sincronizar("MERCADERIAS_DETALLE")
        Dim itemmercadetalle As New ListViewItem
        itemmercadetalle.Text = "Actualizacion de MERCADERIAS_DETALLE"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemmercadetalle.StateImageIndex = 0
            itemmercadetalle.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemmercadetalle.StateImageIndex = 0
            itemmercadetalle.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemmercadetalle.StateImageIndex = 1
            itemmercadetalle.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemmercadetalle)
        ListaEstado.Refresh()

        'actualizo CONDICIONES_IVA
        estado = sincronizacion.Sincronizar("CONDICIONES_IVA")
        Dim itemiva As New ListViewItem
        itemiva.Text = "Actualizacion de CONDICIONES_IVA"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemiva.StateImageIndex = 0
            itemiva.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemiva.StateImageIndex = 0
            itemiva.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemiva.StateImageIndex = 1
            itemiva.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemiva)
        ListaEstado.Refresh()

        'actualizo COMISIONES
        estado = sincronizacion.Sincronizar("COMISIONES")
        Dim itemcomisiones As New ListViewItem
        itemcomisiones.Text = "Actualizacion de COMISIONES"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemcomisiones.StateImageIndex = 0
            itemcomisiones.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemcomisiones.StateImageIndex = 0
            itemcomisiones.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemcomisiones.StateImageIndex = 1
            itemcomisiones.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemcomisiones)
        ListaEstado.Refresh()

        'actualizo FACTURACION
        estado = sincronizacion.Sincronizar("FACTURACION")
        Dim itemfacturacion As New ListViewItem
        itemfacturacion.Text = "Actualizacion de FACTURACION"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemfacturacion.StateImageIndex = 0
            itemfacturacion.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemfacturacion.StateImageIndex = 0
            itemfacturacion.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemfacturacion.StateImageIndex = 1
            itemfacturacion.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemfacturacion)
        ListaEstado.Refresh()

        'actualizo COLORES
        estado = sincronizacion.Sincronizar("COLORES")
        Dim itemcolores As New ListViewItem
        itemcolores.Text = "Actualizacion de COLORES"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemcolores.StateImageIndex = 0
            itemcolores.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemcolores.StateImageIndex = 0
            itemcolores.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemcolores.StateImageIndex = 1
            itemcolores.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemcolores)
        ListaEstado.Refresh()

        'actualizo PRODUCTOS
        estado = sincronizacion.Sincronizar("PRODUCTOS")
        Dim itemproductos As New ListViewItem
        itemproductos.Text = "Actualizacion de PRODUCTOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemproductos.StateImageIndex = 0
            itemproductos.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemproductos.StateImageIndex = 0
            itemproductos.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemproductos.StateImageIndex = 1
            itemproductos.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemproductos)
        ListaEstado.Refresh()

        'actualizo DEPARTAMENTOS
        estado = sincronizacion.Sincronizar("DEPARTAMENTOS")
        Dim itemdepartamentos As New ListViewItem
        itemdepartamentos.Text = "Actualizacion de DEPARTAMENTOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemdepartamentos.StateImageIndex = 0
            itemdepartamentos.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemdepartamentos.StateImageIndex = 0
            itemdepartamentos.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemdepartamentos.StateImageIndex = 1
            itemdepartamentos.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemdepartamentos)
        ListaEstado.Refresh()

        'actualizo EMPLEADOS
        estado = sincronizacion.Sincronizar("EMPLEADOS")
        Dim itemempleados As New ListViewItem
        itemempleados.Text = "Actualizacion de EMPLEADOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemempleados.StateImageIndex = 0
            itemempleados.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemempleados.StateImageIndex = 0
            itemempleados.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemempleados.StateImageIndex = 1
            itemempleados.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemempleados)
        ListaEstado.Refresh()

        'actualizo EMPLEADOS_TIPOS
        estado = sincronizacion.Sincronizar("EMPLEADOS_TIPOS")
        Dim itemempleadostipo As New ListViewItem
        itemempleadostipo.Text = "Actualizacion de EMPLEADOS_TIPOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemempleadostipo.StateImageIndex = 0
            itemempleadostipo.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemempleadostipo.StateImageIndex = 0
            itemempleadostipo.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemempleadostipo.StateImageIndex = 1
            itemempleadostipo.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemempleadostipo)
        ListaEstado.Refresh()

        'actualizo EMPLEADOS_REGISTROS
        estado = sincronizacion.Sincronizar("EMPLEADOS_REGISTROS")
        Dim itemempleadosreg As New ListViewItem
        itemempleadosreg.Text = "Actualizacion de EMPLEADOS_REGISTROS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemempleadosreg.StateImageIndex = 0
            itemempleadosreg.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemempleadosreg.StateImageIndex = 0
            itemempleadosreg.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemempleadosreg.StateImageIndex = 1
            itemempleadosreg.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemempleadosreg)
        ListaEstado.Refresh()

        'actualizo EMPLEADOS_RECIBOS
        estado = sincronizacion.Sincronizar("EMPLEADOS_RECIBOS")
        Dim itemempleadosrec As New ListViewItem
        itemempleadosrec.Text = "Actualizacion de EMPLEADOS_RECIBOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemempleadosrec.StateImageIndex = 0
            itemempleadosrec.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemempleadosrec.StateImageIndex = 0
            itemempleadosrec.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemempleadosrec.StateImageIndex = 1
            itemempleadosrec.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemempleadosrec)
        ListaEstado.Refresh()

        'actualizo FERIADOS
        estado = sincronizacion.Sincronizar("FERIADOS")
        Dim itemferiados As New ListViewItem
        itemferiados.Text = "Actualizacion de FERIADOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemferiados.StateImageIndex = 0
            itemferiados.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemferiados.StateImageIndex = 0
            itemferiados.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemferiados.StateImageIndex = 1
            itemferiados.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemferiados)
        ListaEstado.Refresh()

        'actualizo LISTA_PRECIO
        estado = sincronizacion.Sincronizar("LISTA_PRECIO")
        Dim itemlistaprecio As New ListViewItem
        itemlistaprecio.Text = "Actualizacion de LISTA_PRECIO"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemlistaprecio.StateImageIndex = 0
            itemlistaprecio.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemlistaprecio.StateImageIndex = 0
            itemlistaprecio.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemlistaprecio.StateImageIndex = 1
            itemlistaprecio.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemlistaprecio)
        ListaEstado.Refresh()

        'actualizo PATENTES
        estado = sincronizacion.Sincronizar("PATENTES")
        Dim itempatentes As New ListViewItem
        itempatentes.Text = "Actualizacion de PATENTES"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itempatentes.StateImageIndex = 0
            itempatentes.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itempatentes.StateImageIndex = 0
            itempatentes.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itempatentes.StateImageIndex = 1
            itempatentes.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itempatentes)
        ListaEstado.Refresh()

        'actualizo PATENTES_ACCIONES
        estado = sincronizacion.Sincronizar("PATENTES_ACCIONES")
        Dim itempatentesacciones As New ListViewItem
        itempatentesacciones.Text = "Actualizacion de PATENTES_ACCIONES"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itempatentesacciones.StateImageIndex = 0
            itempatentesacciones.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itempatentesacciones.StateImageIndex = 0
            itempatentesacciones.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itempatentesacciones.StateImageIndex = 1
            itempatentesacciones.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itempatentesacciones)
        ListaEstado.Refresh()

        'actualizo PATENTES_TIPOS
        estado = sincronizacion.Sincronizar("PATENTES_TIPOS")
        Dim itempatentestipos As New ListViewItem
        itempatentestipos.Text = "Actualizacion de PATENTES_TIPOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itempatentestipos.StateImageIndex = 0
            itempatentestipos.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itempatentestipos.StateImageIndex = 0
            itempatentestipos.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itempatentestipos.StateImageIndex = 1
            itempatentestipos.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itempatentestipos)
        ListaEstado.Refresh()

        'actualizo PERFILES
        estado = sincronizacion.Sincronizar("PERFILES")
        Dim itemperfiles As New ListViewItem
        itemperfiles.Text = "Actualizacion de PERFILES"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemperfiles.StateImageIndex = 0
            itemperfiles.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemperfiles.StateImageIndex = 0
            itemperfiles.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemperfiles.StateImageIndex = 1
            itemperfiles.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemperfiles)
        ListaEstado.Refresh()

        'actualizo PRECIOS
        estado = sincronizacion.Sincronizar("PRECIOS")
        Dim itemprecios As New ListViewItem
        itemprecios.Text = "Actualizacion de PRECIOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemprecios.StateImageIndex = 0
            itemprecios.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemprecios.StateImageIndex = 0
            itemprecios.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemprecios.StateImageIndex = 1
            itemprecios.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemprecios)
        ListaEstado.Refresh()

        'actualizo PRODUCTOS_CATEGORIAS
        estado = sincronizacion.Sincronizar("PRODUCTOS_CATEGORIAS")
        Dim itemproductos_categorias As New ListViewItem
        itemproductos_categorias.Text = "Actualizacion de PRODUCTOS_CATEGORIAS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemproductos_categorias.StateImageIndex = 0
            itemproductos_categorias.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemproductos_categorias.StateImageIndex = 0
            itemproductos_categorias.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemproductos_categorias.StateImageIndex = 1
            itemproductos_categorias.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemproductos_categorias)
        ListaEstado.Refresh()

        'actualizo PRODUCTOS_SUBCATEGORIAS
        estado = sincronizacion.Sincronizar("PRODUCTOS_SUBCATEGORIAS")
        Dim itemproductos_subcategorias As New ListViewItem
        itemproductos_subcategorias.Text = "Actualizacion de PRODUCTOS_SUBCATEGORIAS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemproductos_subcategorias.StateImageIndex = 0
            itemproductos_subcategorias.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemproductos_subcategorias.StateImageIndex = 0
            itemproductos_subcategorias.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemproductos_subcategorias.StateImageIndex = 1
            itemproductos_subcategorias.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemproductos_subcategorias)
        ListaEstado.Refresh()

        'actualizo PROVEEDORES
        estado = sincronizacion.Sincronizar("PROVEEDORES")
        Dim itemproveedores As New ListViewItem
        itemproveedores.Text = "Actualizacion de PROVEEDORES"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemproveedores.StateImageIndex = 0
            itemproveedores.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemproveedores.StateImageIndex = 0
            itemproveedores.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemproveedores.StateImageIndex = 1
            itemproveedores.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemproveedores)
        ListaEstado.Refresh()

        'actualizo PROVINCIAS
        estado = sincronizacion.Sincronizar("PROVINCIAS")
        Dim itemprovincias As New ListViewItem
        itemprovincias.Text = "Actualizacion de PROVINCIAS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemprovincias.StateImageIndex = 0
            itemprovincias.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemprovincias.StateImageIndex = 0
            itemprovincias.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemprovincias.StateImageIndex = 1
            itemprovincias.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemprovincias)
        ListaEstado.Refresh()

        'actualizo REL_PERFILES_PATENTES
        estado = sincronizacion.Sincronizar("REL_PERFILES_PATENTES")
        Dim itemrel_perfiles_patentes As New ListViewItem
        itemrel_perfiles_patentes.Text = "Actualizacion de REL_PERFILES_PATENTES"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemrel_perfiles_patentes.StateImageIndex = 0
            itemrel_perfiles_patentes.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemrel_perfiles_patentes.StateImageIndex = 0
            itemrel_perfiles_patentes.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemrel_perfiles_patentes.StateImageIndex = 1
            itemrel_perfiles_patentes.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemrel_perfiles_patentes)
        ListaEstado.Refresh()

        'actualizo REL_PRODUCTOS_AROMAS
        estado = sincronizacion.Sincronizar("REL_PRODUCTOS_AROMAS")
        Dim itemrelaromas As New ListViewItem
        itemrelaromas.Text = "Actualizacion de REL_PRODUCTOS_AROMAS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemrelaromas.StateImageIndex = 0
            itemrelaromas.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemrelaromas.StateImageIndex = 0
            itemrelaromas.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemrelaromas.StateImageIndex = 1
            itemrelaromas.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemrelaromas)
        ListaEstado.Refresh()

        'actualizo REL_PRODUCTOS_COLORES
        estado = sincronizacion.Sincronizar("REL_PRODUCTOS_COLORES")
        Dim itemrelcolores As New ListViewItem
        itemrelcolores.Text = "Actualizacion de REL_PRODUCTOS_COLORES"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemrelcolores.StateImageIndex = 0
            itemrelcolores.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemrelcolores.StateImageIndex = 0
            itemrelcolores.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemrelcolores.StateImageIndex = 1
            itemrelcolores.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemrelcolores)
        ListaEstado.Refresh()

        'actualizo REL_PRODUCTOS_MATERIALES
        estado = sincronizacion.Sincronizar("REL_PRODUCTOS_MATERIALES")
        Dim itemrelmateriales As New ListViewItem
        itemrelmateriales.Text = "Actualizacion de REL_PRODUCTOS_MATERIALES"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemrelmateriales.StateImageIndex = 0
            itemrelmateriales.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemrelmateriales.StateImageIndex = 0
            itemrelmateriales.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemrelmateriales.StateImageIndex = 1
            itemrelmateriales.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemrelmateriales)
        ListaEstado.Refresh()

        'actualizo REL_USUARIOS_PERFILES
        estado = sincronizacion.Sincronizar("REL_USUARIOS_PERFILES")
        Dim itemrelusuarios As New ListViewItem
        itemrelusuarios.Text = "Actualizacion de REL_USUARIOS_PERFILES"
        Progreso.Increment(indicadorprogreso)
        If (estado) Then
            contador += 1
            itemrelusuarios.StateImageIndex = 0
            itemrelusuarios.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemrelaromas.StateImageIndex = 0
            itemrelaromas.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemrelusuarios.StateImageIndex = 1
            itemrelusuarios.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemrelusuarios)
        ListaEstado.Refresh()

        'actualizo REL_USUARIOS_PERFILES
        estado = sincronizacion.Sincronizar("REL_REGISTRO_EMPLEADOS")
        Dim itemreluregemp As New ListViewItem
        itemreluregemp.Text = "Actualizacion de REL_REGISTRO_EMPLEADOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemreluregemp.StateImageIndex = 0
            itemreluregemp.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemreluregemp.StateImageIndex = 0
            itemreluregemp.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemreluregemp.StateImageIndex = 1
            itemreluregemp.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemreluregemp)
        ListaEstado.Refresh()

        'actualizo SUCURSALES
        estado = sincronizacion.Sincronizar("SUCURSALES")
        Dim itemsucursales As New ListViewItem
        itemsucursales.Text = "Actualizacion de SUCURSALES"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemsucursales.StateImageIndex = 0
            itemsucursales.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemsucursales.StateImageIndex = 0
            itemsucursales.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemsucursales.StateImageIndex = 1
            itemsucursales.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemsucursales)
        ListaEstado.Refresh()

        'actualizo TIPOS_COMISIONES
        estado = sincronizacion.Sincronizar("TIPOS_COMISIONES")
        Dim itemtipos_comisiones As New ListViewItem
        itemtipos_comisiones.Text = "Actualizacion de TIPOS_COMISIONES"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemtipos_comisiones.StateImageIndex = 0
            itemtipos_comisiones.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemtipos_comisiones.StateImageIndex = 0
            itemtipos_comisiones.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemtipos_comisiones.StateImageIndex = 1
            itemtipos_comisiones.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemtipos_comisiones)
        ListaEstado.Refresh()

        'actualizo TIPOS_EGRESOS
        estado = sincronizacion.Sincronizar("TIPOS_EGRESOS")
        Dim itemtipos_egresos As New ListViewItem
        itemtipos_egresos.Text = "Actualizacion de TIPOS_EGRESOS"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemtipos_egresos.StateImageIndex = 0
            itemtipos_egresos.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemtipos_egresos.StateImageIndex = 0
            itemtipos_egresos.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemtipos_egresos.StateImageIndex = 1
            itemtipos_egresos.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemtipos_egresos)
        ListaEstado.Refresh()

        'actualizo TIPOS_PAGO
        estado = sincronizacion.Sincronizar("TIPOS_PAGO")
        Dim itemtipos_pagos As New ListViewItem
        itemtipos_pagos.Text = "Actualizacion de TIPOS_PAGO"
        Progreso.Increment(indicadorprogreso)
        If estado = 1 Then
            contador += 1
            itemtipos_pagos.StateImageIndex = 0
            itemtipos_pagos.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            contador += 1
            itemtipos_pagos.StateImageIndex = 0
            itemtipos_pagos.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            itemtipos_pagos.StateImageIndex = 1
            itemtipos_pagos.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemtipos_pagos)
        ListaEstado.Refresh()

        'finalizacion de proceso
        Dim item As New ListViewItem
        item.Text = "Se sincronizaron " + contador.ToString + " de " + tablas.ToString + " tablas disponibles."
        item.SubItems.Add("FINALIZADO")
        item.StateImageIndex = 2
        ListaEstado.Items.Add(item)
        ListaEstado.Refresh()

        Progreso.Value = 100
        btnSincronizar.Enabled = True
        Me.Cursor = Cursors.Default
        btn_Cerrar.Visible = True

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

End Class