Imports System.Windows.Forms
Imports System.Configuration
Imports System.Resources
Imports Servicios
Imports System.Threading
Imports System.Threading.Tasks
Imports Negocio
Imports Entidades
Imports System.ComponentModel

Public Class MDIContenedor
    Dim Funciones As New Funciones
    Dim objusuario As New Negocio.Usuario
    Dim NegPatentes As New Negocio.NegPatentes
    Dim id_Sucursal As Integer = CInt(My.Settings("Sucursal"))
    Dim negFunciones As New Negocio.Funciones
    Dim negMovimiento As New Negocio.NegMovimientos
    Dim negCaja As New Negocio.NegCajaInicial
    Dim negProveedores As New Negocio.NegProveedores
    Dim negStock As New Negocio.NegStock
    Dim negProducto As New Negocio.NegProductos
    Dim negEmpleados As New Negocio.NegEmpleados
    Dim negStockPedido As New Negocio.NegOrdenCompra



    Dim tiempoAcumuladoNotificaciones As Integer = 0
    Dim tiempoAcumuladoMensajes As Integer = 0
    Dim tiempoAcumuladoCheques As Integer = 0
    Dim tiempoAcumuladoNotasPedidos As Integer = 0
    Dim tiempoAcumuladoOrdenesCompra As Integer = 0

    Dim actualizarMemoriaCaheTimer As Threading.Timer

    Private Sub MDIContenedor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If VariablesGlobales.Notificaciones > 0 Then 'Si posee notificaciones pendientes.
            If MessageBox.Show("¿Posee " & VariablesGlobales.Notificaciones & " notificacion(es) pendiente(s). ¿Está seguro de que desea salir de la aplicación?", "Sistema de Gestión " & My.Settings("Empresa"),
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                frmLogin.Close()
            End If
        Else 'si no posee notificaciones pendientes.
            If MessageBox.Show("¿Está seguro de que desea salir de la aplicación?", "Sistema de Gestión " & My.Settings("Empresa"),
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                frmLogin.Close()
            End If
        End If
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración)) Then
            ToolsMenu.Visible = True
        Else
            ToolsMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cheques_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cheques_Administración_Modificar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cheques_Administración_Modificar_Salida) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cheques_Administración_Visualizar_Exportar)) Then
            AdministraciónToolStripMenuItem2.Visible = True
        Else
            AdministraciónToolStripMenuItem2.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cheques_Alta)) Then
            AltaToolStripMenuItem.Visible = True
        Else
            AltaToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cheques_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cheques_Administración_Modificar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cheques_Administración_Modificar_Salida) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cheques_Administración_Visualizar_Exportar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cheques_Alta)) Then
            ChequesToolStripMenuItem.Visible = True
            Menu_ChequesVencer.Visible = True
        Else
            ChequesToolStripMenuItem.Visible = False
            Menu_ChequesVencer.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cliente_Mayorista_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cliente_Mayorista_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cliente_Mayorista_Modificar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cliente_Mayorista_Eliminar)) Then
            ClienteMayoristaToolStripMenuItem.Visible = True
        Else
            ClienteMayoristaToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Administración_Detalle_Anular) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Administración_Detalle_NotaCrédito) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Administración_Detalle_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Administración_Detalle_Facturar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Devolución)) Then
            Btn_DevolucionesMenu.Visible = True
        Else
            Btn_DevolucionesMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Administración_Detalle_Anular) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Administración_Detalle_NotaCrédito) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Administración_Detalle_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Administración_Detalle_Facturar)) Then
            AdministracionDevolucionesMenu.Visible = True
        Else
            AdministracionDevolucionesMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Devolución)) Then
            DevolucionesMenu.Visible = True
            AccesoCambios.Visible = True
        Else
            DevolucionesMenu.Visible = False
            AccesoCambios.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_Administración_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_Administración_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_Administración_Modificar)) Then
            AdmDeEmpleadosToolStripMenuItem.Visible = True
        Else
            AdmDeEmpleadosToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_EstadoCuenta)) Then
            VisualizaciónDeSaldoToolStripMenuItem.Visible = True
        Else
            VisualizaciónDeSaldoToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_PagoAdicionales)) Then
            AdicionalesToolStripMenuItem.Visible = True
        Else
            AdicionalesToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_PagoAdelantos)) Then
            AdelantoEfectivoToolStripMenuItem.Visible = True
        Else
            AdelantoEfectivoToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_SueldoVacacionesAguinaldo)) Then
            ReciboDeSueldoToolStripMenuItem.Visible = True
        Else
            ReciboDeSueldoToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_Registro)) Then
            RegistroDeEmpleadosToolStripMenuItem.Visible = True
            RegistroDeEmpleadosToolStripMenuItem.Enabled = True
        Else
            RegistroDeEmpleadosToolStripMenuItem.Visible = False
            RegistroDeEmpleadosToolStripMenuItem.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_Administración_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_Administración_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_Administración_Modificar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_EstadoCuenta) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_PagoAdicionales) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_PagoAdelantos) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_SueldoVacacionesAguinaldo) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Empleados_Registro)) Then
            Btn_EmpleadosMenu.Visible = True
        Else
            Btn_EmpleadosMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Feriados)) Then
            Btn_FeriadosMenu.Visible = True
        Else
            Btn_FeriadosMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Etiquetas)) Then
            Btn_EtiquetasMenu.Visible = True
            Btn_EtiquetasMenu.Enabled = True
        Else
            Btn_EtiquetasMenu.Visible = False
            Btn_EtiquetasMenu.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Movimientos_ListadodeMovimientos)) Then
            ListadoDeMovimientosToolStripMenuItem.Visible = True
            AccesoMovimientos.Visible = True
        Else
            ListadoDeMovimientosToolStripMenuItem.Visible = False
            AccesoMovimientos.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Movimientos_Gastos)) Then
            GastosToolStripMenuItem.Visible = True
            AccesoGastos.Visible = True
        Else
            GastosToolStripMenuItem.Visible = False
            AccesoGastos.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Movimientos_EnvióOtrasSucursales)) Then
            EgresosToolStripMenuItem.Visible = True
            AccesoEgresos.Visible = True
        Else
            EgresosToolStripMenuItem.Visible = False
            AccesoEgresos.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Movimientos_Impuestos)) Then
            ImpuestosToolStripMenuItem.Visible = True
            AccesoImpuestos.Visible = True
        Else
            ImpuestosToolStripMenuItem.Visible = False
            AccesoImpuestos.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Movimientos_DiferenciaCaja)) Then
            DifDeCajaToolStripMenuItem.Visible = True
            AccesoDiferencia.Visible = True
        Else
            DifDeCajaToolStripMenuItem.Visible = False
            AccesoDiferencia.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Movimientos_RetiroSocios)) Then
            RetiroSociosToolStripMenuItem.Visible = True
            AccesoRetiro.Visible = True
        Else
            RetiroSociosToolStripMenuItem.Visible = False
            AccesoRetiro.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Movimientos_CajaFuerte)) Then
            CajaFuerteToolStripMenuItem.Visible = True
            AccesoCajaFuerte.Visible = True
        Else
            CajaFuerteToolStripMenuItem.Visible = False
            AccesoCajaFuerte.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Movimientos_ListadodeMovimientos) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Movimientos_Gastos) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Movimientos_EnvióOtrasSucursales) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Movimientos_Impuestos) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Movimientos_DiferenciaCaja) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Movimientos_RetiroSocios) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Movimientos_CajaFuerte)) Then
            MovimientosToolStripMenuItem.Visible = True
        Else
            MovimientosToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_NotaPedido_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_NotaPedido_Administración_Venta)) Then
            NotaPedidoToolStripMenuItem.Visible = True
            Menu_NotaPedidoVenta.Visible = True
        Else
            NotaPedidoToolStripMenuItem.Visible = False
            Menu_NotaPedidoVenta.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_AltaMasiva)) Then
            Btn_ProductosMasivosSubM.Visible = True
        Else
            Btn_ProductosMasivosSubM.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Exportar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Importar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Modificar)) Then
            Btn_ProductosSubM.Visible = True
            AccesosProductos.Visible = True
        Else
            Btn_ProductosSubM.Visible = False
            AccesosProductos.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Precios)) Then
            PreciosToolStripMenuItem.Visible = True
        Else
            PreciosToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Categorías_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Categorías_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Categorías_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Categorías_Modificar)) Then
            Btn_ProductosCatSubM.Visible = True
        Else
            Btn_ProductosCatSubM.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Subcategoría_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Subcategoría_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Subcategoría_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Subcategoría_Modificar)) Then
            Btn_ProductosSubcatSubM.Visible = True
        Else
            Btn_ProductosSubcatSubM.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_AltaMasiva) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Exportar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Importar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Modificar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Precios) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Categorías_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Categorías_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Categorías_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Categorías_Modificar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Subcategoría_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Subcategoría_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Subcategoría_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Subcategoría_Modificar)) Then
            Btn_ProductosMenu.Visible = True
        Else
            Btn_ProductosMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_Administración_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_Administración_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_Administración_Modificar)) Then
            AdministraciónToolStripMenuItem1.Visible = True
        Else
            AdministraciónToolStripMenuItem1.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_CuentaCorriente_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_CuentaCorriente_Detalle) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_CuentaCorriente_Mercadería) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_CuentaCorriente_Pagar)) Then
            CuentaCorrienteToolStripMenuItem.Visible = True
        Else
            CuentaCorrienteToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_Administración_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_Administración_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_Administración_Modificar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_CuentaCorriente_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_CuentaCorriente_Detalle) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_CuentaCorriente_Mercadería) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Proveedores_CuentaCorriente_Pagar)) Then
            Btn_ProveedoresMenu.Visible = True
        Else
            Btn_ProveedoresMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Administración_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Administración_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Administración_Modificar)) Then
            AdmDeStockToolStripMenuItem.Visible = True
        Else
            AdmDeStockToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Bitácora)) Then
            BitácoraToolStripMenuItem.Visible = True
        Else
            BitácoraToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_IngresoMercadería_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_IngresoMercadería_Ingreso) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_IngresoMercadería_Modificar)) Then
            AltaMasivaToolStripMenuItem.Visible = True
            AccesoMercaderias.Visible = True
        Else
            AltaMasivaToolStripMenuItem.Visible = False
            AccesoMercaderias.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Administración_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Administración_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Administración_Modificar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Bitácora) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_IngresoMercadería_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_IngresoMercadería_Ingreso) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_IngresoMercadería_Modificar)) Then
            Btn_StockMenu.Visible = True
        Else
            Btn_StockMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Sucursales_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Sucursales_Administración_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Sucursales_Administración_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Sucursales_Administración_Modificar)) Then
            AdmDeSucursalesToolStripMenuItem.Visible = True
        Else
            AdmDeSucursalesToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Sucursales_EstadoCuenta)) Then
            EstadoDeCuentaToolStripMenuItem.Visible = True
        Else
            EstadoDeCuentaToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Sucursales_HistorialDiferenciaCaja)) Then
            HistorialDeDifCajaToolStripMenuItem.Visible = True
        Else
            HistorialDeDifCajaToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Sucursales_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Sucursales_Administración_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Sucursales_Administración_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Sucursales_Administración_Modificar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Sucursales_EstadoCuenta) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Sucursales_HistorialDiferenciaCaja)) Then
            Btn_SucursalesMenu.Visible = True
        Else
            Btn_SucursalesMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_Anular) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_Facturar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_NotaCrédito) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_Visualizar)) Then
            AdministraciónToolStripMenuItem.Visible = True
        Else
            AdministraciónToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Venta)) Then
            VentasToolStripMenuItem1.Enabled = True
            VentasToolStripMenuItem1.Visible = True
            AccesoVentas.Visible = True
        Else
            VentasToolStripMenuItem1.Enabled = False
            VentasToolStripMenuItem1.Visible = False
            AccesoVentas.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_Anular) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_Facturar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_NotaCrédito) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Venta)) Then
            Btn_VentasMenu.Visible = True
        Else
            Btn_VentasMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Presupuesto_Administración_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Presupuesto_Administración_Detalle_Anular)) Then
            PresupuestoToolStripMenuItem.Visible = True
        Else
            PresupuestoToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_ResumenDiario)) Then
            AccesoResumen.Visible = True
        Else
            AccesoResumen.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Reservas_Administración_Reservas)) Then
            btn_AdminReservas.Visible = True
            Btn_Reservas.Visible = True
        Else
            btn_AdminReservas.Visible = False
            Btn_Reservas.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Planillas)) Then
            Btn_PlanillasMenu.Visible = True
        Else
            Btn_PlanillasMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Planillas_MovimientosSucursal_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Planillas_MovimientosSucursal_Exportar)
            ) Then
            SucursalesToolStripMenuItem.Visible = True
        Else
            SucursalesToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Planillas_MovimientosEntreSucursales)) Then
            MovEntreSucursalesToolStripMenuItem.Visible = True
        Else
            MovEntreSucursalesToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Planillas_SueldoEmpleados_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Planillas_SueldoEmpleados_Exportar)) Then
            SueldosDeEmpleadosToolStripMenuItem.Visible = True
        Else
            SueldosDeEmpleadosToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Planillas_Listasdeprecios)) Then
            ListasDePreciosToolStripMenuItem.Visible = True
        Else
            ListasDePreciosToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Seguridad)) Then
            SeguridadToolStripMenuItem.Visible = True
        Else
            SeguridadToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Seguridad_Perfiles_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Seguridad_Perfiles_Crear) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Seguridad_Perfiles_Modificar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Seguridad_Perfiles_Eliminar)) Then
            Btn_PerfilesMenu.Visible = True
        Else
            Btn_PerfilesMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Seguridad_Usuarios_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Seguridad_Usuarios_Eliminar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Seguridad_Usuarios_modificar)) Then
            Btn_UsuariosMenu.Visible = True
        Else
            Btn_UsuariosMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema)) Then
            Btn_SincronizacionMenu.Visible = True
        Else
            Btn_SincronizacionMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Sincronización)) Then
            Btn_SincronizaciónMenu.Visible = True
        Else
            Btn_SincronizaciónMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Alertas_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Alertas_Modificar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Facturación_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Facturación_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Host_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Host_Modificar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Internet_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Internet_Modificar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Mail_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Mail_Modificar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Precio_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Precio_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Sucursal_Visualizar) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Configuración_Sucursal_Modificar)) Then
            Btn_ConfiguracionMenu.Visible = True
        Else
            Btn_ConfiguracionMenu.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Notificación_Visualización) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Notificación_AceptarCancelar)) Then
            Btn_NotificacionesMenu.Visible = True
            Menu_Movimientos.Visible = True
        Else
            Btn_NotificacionesMenu.Visible = False
            Menu_Movimientos.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Controlador_Fiscal_EmitirCierreZdía) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Controlador_Fiscal_EmitirCierreZRangoFechas) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Controlador_Fiscal_BuscarTickets) Or
            VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Controlador_Fiscal_ExportarTickets)) Then
            ControladoraToolStripMenuItem.Visible = True
        Else
            ControladoraToolStripMenuItem.Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_CostoFinanciero_Administración)) Then
            CostoFinancieroToolStripMenuItem.Visible = True
        Else
            CostoFinancieroToolStripMenuItem.Visible = False
        End If


    End Sub

    Private Async Sub MDIContenedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Cursor
        Me.Cursor = Cursors.WaitCursor

        'Seteo la cultura del proyecto.
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        'Agrego un handler al servicio WCF de alta de notas de pedido para mostrar la pantalla cuando se genere una nota de pedido
        AddHandler Servicios.NotaPedido.onNevaNotaPedidoCompleted, AddressOf NuevaNotaPedido

        Negocio.Funciones.ActualizarEstadoConexionInternet = Sub(x) Funciones.ActualizarEstado(x, Me)

        Try
            'Inicio los servicios WCF
            Dim host As Host = New Host(My.Settings.IpHost, My.Settings.PuertoHost, My.Settings.NombreSucursal, My.Settings.NombreListaPrecio, My.Settings.Sucursal, My.Settings.ListaPrecio, My.Settings.DescuentoMinorista)
            host.Start()
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al iniciar el Host de servicios para los dispositivos móviles. Por favor, Comuníqueselo al administrador.", "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            EvaluarPermisos()
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar las permisos del usuario. Por favor, Comuníqueselo al administrador. ", "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If VariablesGlobales.HayConexion Then
            Try

                'Sincornizo las bases de datos local y remotas.
                SincornizarBasesDatos()

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha encontrado un error al sincronizar las bases de datos. Por favor, Comuníqueselo al administrador. ", "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        Try
            'Cierro las cajas Antiguas que no esten cerradas
            CerrarCajasAntiguas()
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al calcular las cajas pendientes. Por favor, Comuníqueselo al administrador. ", "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            'Compriebo si la caja diaria está abierta o cerrada.
            VerificarEstadoCaja()
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error obtener el estado de la caja diaria. Por favor, Comuníqueselo al administrador. ", "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Funcion que ejecuta en segundo plano procesos pesados que no hacen al correcto inicio de la aplicacion
        bgwEjecutarEnSegundoPlano.RunWorkerAsync()

        'Actualizo los mensajes del usuario
        Funciones.ActualizarMensajes()

        'Obtengo las notificaciones
        Funciones.ActualizarNotificaciones()

        'Obtengo los Cheuqes a Vencer notificaciones
        Funciones.ActualizarChequesVencer()

        'Obtengo las Notas de pedidos por ventas
        Funciones.ActualizarNotasPedidosVentas()

        'Obtengo las Notas de pedidos por stock
        Funciones.ActualizarOrdenesCompra()

        actualizarMemoriaCaheTimer = New System.Threading.Timer(AddressOf ActualizarMemoriaCache, Nothing, TimeSpan.Zero, TimeSpan.FromMinutes(My.Settings.TemporizadorActualizacionMemoriaCache))

        'Setea el nombre de la aplicacion.
        Me.Text = "Sistema de Gestion " & My.Settings.Empresa & " - " & My.Settings.NombreSucursal

        'Seteo los temporizadores.
        Temporizador.Interval = My.Settings.TemporizadorInternet
        Temporizador.Enabled = True

        TemporizadorSoncronizacion.Interval = My.Settings.TemporizadorSincronizacion
        TemporizadorSoncronizacion.Enabled = True

        'seteo el icono.
        Dim icono As System.Drawing.Icon
        icono = My.Resources.Recursos.Cinderella
        Me.Icon = icono

        'Actualizo el fondo.
        Me.BackgroundImageLayout = ImageLayout.Stretch

        'icono de notificacion
        NotifyIcon.Icon = icono
        NotifyIcon.Text = Me.Text

        'Refresco
        Me.Refresh()

        'Cursor
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub SincornizarBasesDatos()

        Dim NegSincronizacion As Negocio.NegSincronizacion = New Negocio.NegSincronizacion()
        Dim fecha As Date = NegSincronizacion.ObtenerUltimaSincronizacion(id_Sucursal)

        If (fecha.Date <> Date.Now.Date) Then
            Dim frmSincronizacion As frmSincronizacion = New frmSincronizacion()
            If (frmSincronizacion.conexionLocal AndAlso frmSincronizacion.conexionRemota) Then
                frmSincronizacion.Show()
                frmSincronizacion.Refresh()
                frmSincronizacion.btnSincronizar.PerformClick()
                frmSincronizacion.Close()
            Else
                If (Not frmSincronizacion.conexionLocal) Then
                    MessageBox.Show("No se ha podido conectar a la base de datos Local el proceso de sincronización se ha cancelo. Por favor, reintente más tarde desde el menú de sincronización  ", "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf (Not frmSincronizacion.conexionRemota) Then
                    MessageBox.Show("No se ha podido conectar a la base de datos Remota el proceso de sincronización se ha cancelo. Por favor, reintente más tarde desde el menú de sincronización  ", "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub VerificarEstadoCaja()
        'Muestro el detalle de la caja cerrada.
        Dim FNueva As String = ""
        Dim entCajaNueva As New Entidades.CajaInicial
        FNueva = Now.Date.ToString("yyyy/MM/dd")
        entCajaNueva = negCaja.ObtenerCaja(id_Sucursal, FNueva)

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
            Me.Btn_ResumenDiario.Visible = False
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Me.Refresh()
            VariablesGlobales.CajaCerrada = 0
        End If
    End Sub

    Private Function CrearOrdenesDeCompraAutomaticas() As String
        Try
            Dim cantidad As Integer = 0
            Dim proveedores As List(Of Proveedores) = negProveedores.TraerProveedor()
            Dim diaSemana As Integer = Date.Now().DayOfWeek
            Dim dsEncargado As DataSet = negEmpleados.ListadoEncargadosSucursal(My.Settings.Sucursal)

            For Each proveedor As Proveedores In proveedores

                Dim stockNotaPedidoAutomatica As OrdenCompra = New OrdenCompra() With {
                .Detalles = New List(Of OrdenCompraDetalle),
                .Estado = OrdenCompraPedidoEstado.Nuevo,
                .Fecha = Date.Now(),
                .idProveedor = proveedor.id_Proveedor,
                .idSucursal = My.Settings.Sucursal,
                .Tipo = OrdenCompraPedidoTipo.Automatico,
                .idEncargado = If(dsEncargado.Tables(0).Rows.Count = 0, -1, dsEncargado.Tables(0).Rows(0).Item("id_Empleado"))
                }

                'Si el proveedor recibe notas de pedido este dia
                If proveedor.DiaPreferentePedido = diaSemana Then
                    'Obtengo los productos en sotck de este proveedor
                    Dim stocks As List(Of Stock) = negStock.ListadoStock(My.Settings.Sucursal, proveedor.id_Proveedor)
                    For Each stock As Stock In stocks
                        'Verifico si tiene faltante de stock
                        If stock.Stock_Actual < stock.Stock_Minimo Then
                            'Creo el pedido
                            Dim producto As Productos = negProducto.TraerProducto(stock.id_Producto)
                            stockNotaPedidoAutomatica.Detalles.Add(New OrdenCompraDetalle() With {
                                .Codigo = producto.Codigo,
                                .idProducto = producto.id_Producto,
                                .Costo = producto.Costo,
                                .Nombre = producto.Nombre,
                                .Cantidad = stock.Stock_Optimo - stock.Stock_Actual + (stock.VentaMensual / 30 * proveedor.PlazoEntrega)})
                        End If
                    Next
                End If

                'Guardo el pedido en caso de que tenga elementos
                If stockNotaPedidoAutomatica.Detalles.Count > 0 Then
                    negStockPedido.Guardar(stockNotaPedidoAutomatica)
                    cantidad += 1
                End If
            Next
            If (cantidad > 0) Then
                Return $"Se han creado {cantidad} notas de pedido de forma automatica."
            Else
                Return String.Empty
            End If
        Catch ex As Exception
            Throw New Exception($"Ha ocurrido un error en la generacion de notas de pedido automaticas. Por favor, Comuníqueselo al administrador.{Environment.NewLine}{ex.Message}", ex)
        End Try
    End Function

    Private Function CalcularVentaMensualProducto() As String
        Try
            'Obtengo la ultima fecha en la que se calculo la venta mensual de cada producto
            Dim fechaUltimoCalculoMensual As Date? = negStock.ObtenerUltimoCalculoVentaMensual(My.Settings.Sucursal)

            'Si no hay fecha de ultimo calculo mensual o si ya se supero el periodo configurado
            If Not fechaUltimoCalculoMensual.HasValue OrElse fechaUltimoCalculoMensual.Value.AddDays(Integer.Parse(My.Settings.PeriodoCaulculoVentaMensual)) <= Date.Now() Then
                'Calculo el total de ventas de los poductos en sotck en los ultimos 30 dias
                negStock.CalculaVentaMensual(My.Settings.Sucursal, Date.Now().AddDays(-30), Date.Now())
                'Actualizo la fecha del calculo
                negStock.ActualizarUltimoCalculoVentaMensual(My.Settings.Sucursal)

                Return "Se han actualizado las ventas mensuales para los productos en stock de forma exitosa."
            End If

            Return String.Empty
        Catch ex As Exception
            Throw New Exception($"Ha ocurrido un error al actualizar las ventas mensuales para los productos en stock. Por favor, Comuníqueselo al administrador.{Environment.NewLine}{ex.Message}", ex)
        End Try
    End Function


    Private Sub EjecutarSegundoPlano_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles bgwEjecutarEnSegundoPlano.DoWork
        Dim bw As BackgroundWorker = TryCast(sender, BackgroundWorker)

        'Calculo las ventas acumuladas de los ultimos 30 dias de los productos en stock
        e.Result += CalcularVentaMensualProducto()

        If e.Result.ToString().Length > 0 Then
            e.Result += Environment.NewLine
        End If

        'Verifico el stock diponible por proveedro y genero nota de pedido.
        If My.Settings.GeneracionOrdenCompraAutomatica Then
            e.Result += CrearOrdenesDeCompraAutomaticas()
        End If

        If bw.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub EjecutarSegundoPlano_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles bgwEjecutarEnSegundoPlano.RunWorkerCompleted
        If e.Cancelled Then
            MessageBox.Show("La operación fue cancelada", "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf e.[Error] IsNot Nothing Then
            MessageBox.Show(e.Error.Message, "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not String.IsNullOrEmpty(e.Result.ToString().Trim()) Then
            MessageBox.Show(e.Result, "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub CerrarCajasAntiguas()
        'Compruebo que las cajas de fechas anteriores estén cerradas.
        Dim TotCajas As Integer = negCaja.ComprobarCajas(id_Sucursal)
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
                    entCajaCerrada.id_Movimiento = 0
                    entCajaCerrada.id_Sucursal = id_Sucursal
                    entCajaCerrada.Abierta = 0
                    entCajaCerrada.Empleado = VariablesGlobales.objUsuario.Usuario
                    entCajaCerrada.Monto = negCaja.ObtenerSaldo(id_Sucursal, FechaAnterior)
                    entCajaCerrada.Fecha = FechaAnterior
                    entCajaCerrada.Hora = Now
                    negCaja.CerrarCaja(entCajaCerrada, id_Sucursal)
                Next

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.Close()
                frmCargadorDeEspera.Dispose()
            End If
        End If
    End Sub

    Private Sub Temporizador_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Temporizador.Tick
        Funciones.ActualizarEstado(Negocio.Funciones.HayConexionInternet(), Me)
    End Sub

    Private Sub Btn_ColoresMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ColoresMenu.Click
        'para administrar colores es necesario esta online
        If (Not Negocio.Funciones.HayConexionInternet) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmColores).MdiParent = Me
            Funciones.ControlInstancia(frmColores).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub Btn_PerfilesMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PerfilesMenu.Click
        'para administrar perfiles es necesario esta online
        If (Not Negocio.Funciones.HayConexionInternet) Then
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
        If (Not Negocio.Funciones.HayConexionInternet) Then
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
        If (Not Negocio.Funciones.HayConexionInternet) Then
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
        If (Not Negocio.Funciones.HayConexionInternet) Then
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
        If (Not Negocio.Funciones.HayConexionInternet) Then
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
        If (Not Negocio.Funciones.HayConexionInternet) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMailNuevo).MdiParent = Me
            Funciones.ControlInstancia(frmMailNuevo).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub InformaciónPersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_InformaciónPersonalMenu.Click
        'para enviar mensajes es necesario esta online
        If (Not Negocio.Funciones.HayConexionInternet) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMiCuenta).MdiParent = Me
            Funciones.ControlInstancia(frmMiCuenta).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ProductosSubM.Click
        'para administrar productos es necesario esta online
        If (Not Negocio.Funciones.HayConexionInternet) Then
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
        If (Not Negocio.Funciones.HayConexionInternet) Then
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
        If (Not Negocio.Funciones.HayConexionInternet) Then
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
        If (Not Negocio.Funciones.HayConexionInternet) Then
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
        If (Not Negocio.Funciones.HayConexionInternet) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmFeriados).MdiParent = Me
            Funciones.ControlInstancia(frmFeriados).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AdmDeStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmDeStockToolStripMenuItem.Click

        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmStock).MdiParent = Me
        Funciones.ControlInstancia(frmStock).Show()
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub AltaMasivaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaMasivaToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmStockMasiva).MdiParent = Me
        Funciones.ControlInstancia(frmStockMasiva).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Btn_EtiquetasMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_EtiquetasMenu.Click
        If Btn_EtiquetasMenu.Enabled Then
            'Compruevo el acceso a internet para actualizar el MIDContenedor
            Negocio.Funciones.HayConexionInternet()

            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmEtiquetas).MdiParent = Me
            Funciones.ControlInstancia(frmEtiquetas).Show()
            Me.Cursor = Cursors.Arrow

        End If
    End Sub

    Private Sub AdmDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmDeEmpleadosToolStripMenuItem.Click
        'para administrar empelados es necesario esta online
        If (Not Negocio.Funciones.HayConexionInternet) Then

            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmEmpleados).MdiParent = Me
            Funciones.ControlInstancia(frmEmpleados).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub RegistroDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeEmpleadosToolStripMenuItem.Click
        If RegistroDeEmpleadosToolStripMenuItem.Enabled Then
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmEmpleadosRegistro).MdiParent = Me
            Funciones.ControlInstancia(frmEmpleadosRegistro).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AdelantoEfectivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdelantoEfectivoToolStripMenuItem.Click
        If AdelantoEfectivoToolStripMenuItem.Enabled Then
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmAdelantoEfectivo).MdiParent = Me
            Funciones.ControlInstancia(frmAdelantoEfectivo).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AdmDeSucursalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmDeSucursalesToolStripMenuItem.Click
        'para administrar sucursales es necesario esta online
        If (Not Negocio.Funciones.HayConexionInternet) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmSucursales).MdiParent = Me
            Funciones.ControlInstancia(frmSucursales).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub VisualizaciónDeSaldoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizaciónDeSaldoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmEmpleadosSaldos).MdiParent = Me
        Funciones.ControlInstancia(frmEmpleadosSaldos).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub VentasToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem1.Click
        If VentasToolStripMenuItem1.Enabled Then
            'para administrar ventas no es necesario esta online
            Me.Cursor = Cursors.WaitCursor
            Dim frmVentas As frmVentas = New frmVentas()
            frmVentas.MdiParent = Me
            frmVentas.Show()
            Me.Cursor = Cursors.Arrow
        End If
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
        If (Not Negocio.Funciones.HayConexionInternet) Then
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
        If (Not Negocio.Funciones.HayConexionInternet) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmProductos).MdiParent = Me
            Funciones.ControlInstancia(frmProductos).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AccesosPrecios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesosPrecios.Click
        'Compruevo el acceso a internet para actualizar el MIDContenedor
        Negocio.Funciones.HayConexionInternet()

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
        'Compruevo el acceso a internet para actualizar el MIDContenedor
        Negocio.Funciones.HayConexionInternet()

        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmPlanillaSucursales).MdiParent = Me
        Funciones.ControlInstancia(frmPlanillaSucursales).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub SueldosDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SueldosDeEmpleadosToolStripMenuItem.Click
        'Compruevo el acceso a internet para actualizar el MIDContenedor
        Negocio.Funciones.HayConexionInternet()

        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmPlanillaEmpleados).MdiParent = Me
        Funciones.ControlInstancia(frmPlanillaEmpleados).Show()
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub ReciboDeSueldoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReciboDeSueldoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmReciboSueldo).MdiParent = Me
        Funciones.ControlInstancia(frmReciboSueldo).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub MDIContenedor_MaximumSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MaximumSizeChanged
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub MDIContenedor_MinimumSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MinimumSizeChanged
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub AccesoGastos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoGastos.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmMovimientoGasto).MdiParent = Me
        Funciones.ControlInstancia(frmMovimientoGasto).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub AccesoEgresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoEgresos.Click
        'para administrar ésta seccion es necesario esta online
        If (Not Negocio.Funciones.HayConexionInternet) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoEgreso).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoEgreso).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AccesoImpuestos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoImpuestos.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmMovimientoImpuesto).MdiParent = Me
        Funciones.ControlInstancia(frmMovimientoImpuesto).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub AccesoDiferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoDiferencia.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmMovimientoCaja).MdiParent = Me
        Funciones.ControlInstancia(frmMovimientoCaja).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub AccesoRetiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoRetiro.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmMovimientoSocios).MdiParent = Me
        Funciones.ControlInstancia(frmMovimientoSocios).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub GastosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GastosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmMovimientoGasto).MdiParent = Me
        Funciones.ControlInstancia(frmMovimientoGasto).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub EgresosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EgresosToolStripMenuItem.Click
        'para administrar ésta seccion es necesario esta online
        If (Not Negocio.Funciones.HayConexionInternet) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmMovimientoEgreso).MdiParent = Me
            Funciones.ControlInstancia(frmMovimientoEgreso).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub ImpuestosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImpuestosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmMovimientoImpuesto).MdiParent = Me
        Funciones.ControlInstancia(frmMovimientoImpuesto).Show()
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub DifDeCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DifDeCajaToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmMovimientoCaja).MdiParent = Me
        Funciones.ControlInstancia(frmMovimientoCaja).Show()
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub RetiroSociosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetiroSociosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmMovimientoSocios).MdiParent = Me
        Funciones.ControlInstancia(frmMovimientoSocios).Show()
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub AccesoMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoMovimientos.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmMovimientoPlanilla).MdiParent = Me
        Funciones.ControlInstancia(frmMovimientoPlanilla).Show()
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub TemporizadorActualizaciones_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemporizadorActualizaciones.Tick

        'Acumulo el tiempo transcurrido
        tiempoAcumuladoNotificaciones += TemporizadorActualizaciones.Interval
        'En caso de que el tiempo acumulado sea mayo o igual al tiempo para mostrar la alertas de movimientos
        If (tiempoAcumuladoNotificaciones >= Integer.Parse(My.Settings("TemporizadorMovimientos")) AndAlso Menu_Movimientos.Visible) Then
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
        If (tiempoAcumuladoCheques >= Integer.Parse(My.Settings("TemporizadorCheques")) AndAlso Menu_ChequesVencer.Visible) Then
            'Muestro la alerta de cheques y reinicio el acumulador de tiempo
            Funciones.ActualizarChequesVencer()
            tiempoAcumuladoCheques = 0
        End If

        'Acumulo el tiempo transcurrido
        tiempoAcumuladoNotasPedidos += TemporizadorActualizaciones.Interval
        'En caso de que el tiempo acumulado sea mayo o igual al tiempo para mostrar la alertas de notas de pedios
        If (tiempoAcumuladoNotasPedidos >= Integer.Parse(My.Settings("TemporizadorNotasPedido")) AndAlso Menu_NotaPedidoVenta.Visible) Then
            'Muestro la alerta de cheques y reinicio el acumulador de tiempo
            Funciones.ActualizarNotasPedidosVentas()
            tiempoAcumuladoNotasPedidos = 0
        End If

        'Acumulo el tiempo transcurrido
        tiempoAcumuladoOrdenesCompra += TemporizadorActualizaciones.Interval
        'En caso de que el tiempo acumulado sea mayo o igual al tiempo para mostrar la alertas de notas de pedios
        If (tiempoAcumuladoOrdenesCompra >= Integer.Parse(My.Settings("TemporizadorOrdenesCompra")) AndAlso Menu_OrdenCompra.Visible) Then
            'Muestro la alerta de cheques y reinicio el acumulador de tiempo
            Funciones.ActualizarOrdenesCompra()
            tiempoAcumuladoOrdenesCompra = 0
        End If
    End Sub

    Private Sub TemporizadorSoncronizacion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemporizadorSoncronizacion.Tick
        TemporizadorSoncronizacion.Stop()
        If (Negocio.Funciones.HayConexionInternet() AndAlso Funciones.MostrarDialogSincronizar()) Then

            Try

                'Sincornizo las bases de datos local y remotas.
                Dim frmSincronizacion As frmSincronizacion = New frmSincronizacion()
                If (frmSincronizacion.conexionLocal AndAlso frmSincronizacion.conexionRemota) Then
                    frmSincronizacion.Show()
                    frmSincronizacion.Refresh()
                    frmSincronizacion.btnSincronizar.PerformClick()
                    frmSincronizacion.Close()
                End If

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha encontrado un error al sincronizar las bases de datos. Por favor, Comuníqueselo al administrador. ", "Sistema Cinderella", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            TemporizadorSoncronizacion.Interval = Integer.Parse(My.Settings.TemporizadorSincronizacion)
        Else
            TemporizadorSoncronizacion.Interval = 600000 '10 minutos
        End If
        TemporizadorSoncronizacion.Start()
    End Sub

    Private Sub Menu_Movimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Movimientos.Click
        'para administrar ésta seccion es necesario esta online
        If (Not Negocio.Funciones.HayConexionInternet) Then
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
        If (Not Negocio.Funciones.HayConexionInternet) Then
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

    Private Sub ControladoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControladoraToolStripMenuItem.Click
        'Compruevo el acceso a internet para actualizar el MIDContenedor
        Negocio.Funciones.HayConexionInternet()

        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmControladorFiscal).MdiParent = Me
        Funciones.ControlInstancia(frmControladorFiscal).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub NotificacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_NotificacionesMenu.Click
        'para administrar ésta seccion es necesario esta online
        If (Not Negocio.Funciones.HayConexionInternet) Then
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
        If (Not Negocio.Funciones.HayConexionInternet) Then
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
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmMovimientoPlanilla).MdiParent = Me
        Funciones.ControlInstancia(frmMovimientoPlanilla).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub ListasDePreciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListasDePreciosToolStripMenuItem.Click
        'Compruevo el acceso a internet para actualizar el MIDContenedor
        Negocio.Funciones.HayConexionInternet()

        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmPlanillaPrecios).MdiParent = Me
        Funciones.ControlInstancia(frmPlanillaPrecios).Show()
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoResumen.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmResumenDiario).MdiParent = Me
        Funciones.ControlInstancia(frmResumenDiario).Show()
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub AdministraciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministraciónToolStripMenuItem1.Click
        'para administrar proveedores es necesario esta online
        If (Not Negocio.Funciones.HayConexionInternet) Then
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
        If (Not Negocio.Funciones.HayConexionInternet) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmProveedoresCuentaCorriente).MdiParent = Me
            Funciones.ControlInstancia(frmProveedoresCuentaCorriente).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ResumenDiario.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmResumenDiario).MdiParent = Me
        Funciones.ControlInstancia(frmResumenDiario).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub CajaFuerteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaFuerteToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmMovimientoCajaFuerte).MdiParent = Me
        Funciones.ControlInstancia(frmMovimientoCajaFuerte).Show()
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub AccesoCajaFuerte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoCajaFuerte.Click
        'Compruevo el acceso a internet para actualizar el MIDContenedor
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmMovimientoCajaFuerte).MdiParent = Me
        Funciones.ControlInstancia(frmMovimientoCajaFuerte).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub BitácoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BitácoraToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmStockBitacora).MdiParent = Me
        Funciones.ControlInstancia(frmStockBitacora).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub HistorialDeDifCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialDeDifCajaToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmDiferenciasListado).MdiParent = Me
        Funciones.ControlInstancia(frmDiferenciasListado).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub AdicionalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionalesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmAdicionales).MdiParent = Me
        Funciones.ControlInstancia(frmAdicionales).Show()
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub DevolucionesMenu_Click(sender As Object, e As EventArgs) Handles DevolucionesMenu.Click
        'para administrar ventas no es necesario esta online
        Me.Cursor = Cursors.WaitCursor
        Dim frmDevoluciones As frmDevoluciones = New frmDevoluciones()
        frmDevoluciones.MdiParent = Me
        frmDevoluciones.Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub AdministracionDevolucionesMenu_Click(sender As Object, e As EventArgs) Handles AdministracionDevolucionesMenu.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmDevolucionesAdministracion).MdiParent = Me
        Funciones.ControlInstancia(frmDevolucionesAdministracion).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub AdministraciónToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AdministraciónToolStripMenuItem2.Click, Menu_ChequesVencer.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmChequesAdministracion).MdiParent = Me
        Funciones.ControlInstancia(frmChequesAdministracion).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmChequesAlta).MdiParent = Me
        Funciones.ControlInstancia(frmChequesAlta).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub AdministracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministracionToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmNotaPedidoAdministracion).MdiParent = Me
        Funciones.ControlInstancia(frmNotaPedidoAdministracion).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Menu_NotaPedido_Click(sender As Object, e As EventArgs) Handles Menu_NotaPedidoVenta.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmNotaPedidoAdministracion).MdiParent = Me
        Funciones.ControlInstancia(frmNotaPedidoAdministracion).Show()
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub Menu_NotaPedidoStock_Click(sender As Object, e As EventArgs) Handles Menu_OrdenCompra.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmOrdenCompra).MdiParent = Me
        Funciones.ControlInstancia(frmOrdenCompra).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub NuevaNotaPedido(EntNotaPedido As Entidades.NotaPedido, EntConsumidorFinal As Entidades.ConsumidorFinal)

        'abro la pantalla de notas de pedido, la ejecuta de esta forma para que no detenga la ejecucion del metodo
        Task.Run(Sub() SetMidParent())

    End Sub

    'Invoca el emtodo Menu_NotaPedido_Click y ActualizarNotasPedidos a travez de un delegado para que el hilo de la intefraz tenga acceso a sus propiedades
    Private Sub SetMidParent()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf SetMidParent))
            Return
        End If
        Menu_NotaPedido_Click(Nothing, Nothing)
        Funciones.ActualizarNotasPedidosVentas(False)
    End Sub

    Private Sub btn_AdminReservas_Click(sender As Object, e As EventArgs) Handles btn_AdminReservas.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmSeniaAdministracion).MdiParent = Me
        Funciones.ControlInstancia(frmSeniaAdministracion).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Btn_Facturas_Click(sender As Object, e As EventArgs) Handles Btn_Facturas.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmFacturaAdministracion).MdiParent = Me
        Funciones.ControlInstancia(frmFacturaAdministracion).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Btn_NotaCredito_Click(sender As Object, e As EventArgs) Handles Btn_NotaCredito.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmNotaCreditoAdministracion).MdiParent = Me
        Funciones.ControlInstancia(frmNotaCreditoAdministracion).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub ClienteMayoristaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteMayoristaToolStripMenuItem.Click
        'para administrar clientes es necesario esta online
        If (Not Negocio.Funciones.HayConexionInternet) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmClienteMayorista).MdiParent = Me
            Funciones.ControlInstancia(frmClienteMayorista).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AdministracionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdministracionToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmPresupuestoAdministracion).MdiParent = Me
        Funciones.ControlInstancia(frmPresupuestoAdministracion).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub CostoFinancieroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CostoFinancieroToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmCostoFinancieroAdministracion).MdiParent = Me
        Funciones.ControlInstancia(frmCostoFinancieroAdministracion).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'funcion encargada de actualizar las memorias cache que utiliza el sistema para mejorar los tiempos de carga
    Private Sub ActualizarMemoriaCache()
        If (My.Settings.UsarMemoriaCache) Then
            Dim negTipoPago As NegTipoPago = New NegTipoPago()
            negTipoPago.ListadoTiposPagosCache(False)

            NegTarjeta.TraerTarjetasCache(False)

            Dim negProductos As NegProductos = New NegProductos()
            negProductos.ListadoProductosCache(False)

            Dim negListasPrecio As NegListasPrecio = New NegListasPrecio()
            negListasPrecio.ListadoPreciosPorGrupo(My.Settings("ListaPrecio"))
        End If
    End Sub

    Private Sub NotaPedidoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NotaPedidoToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmOrdenCompra).MdiParent = Me
        Funciones.ControlInstancia(frmOrdenCompra).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'para administrar proveedores es necesario esta online
        If (Not Negocio.Funciones.HayConexionInternet) Then
            dialogoConexion.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            Funciones.ControlInstancia(frmInformeVentas).MdiParent = Me
            Funciones.ControlInstancia(frmInformeVentas).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub
End Class
