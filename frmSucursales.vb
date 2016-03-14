Public Class frmSucursales
    Dim NegSucursal As New Negocio.NegSucursales
    Dim NegProvincias As New Negocio.NegProvincias
    Dim NegDistritos As New Negocio.NegDistritos
    Dim NegLocalidades As New Negocio.NegLocalidades
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim ESucursales As New Entidades.Sucursales

#Region "Región de Validaciones"
    'Valido que ingrese el nombre.
    Private Sub txt_Nombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Nombre.Validating
        If txt_Nombre.Text = "" Then
            ErroresSucursal.SetError(txt_Nombre, "Debe completar el Nombre.")
        Else
            ErroresSucursal.SetError(txt_Nombre, Nothing)
        End If
    End Sub

    'Valido que ingrese la direccion.
    Private Sub txt_Direccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Direccion.Validating
        If txt_Direccion.Text = "" Then
            ErroresSucursal.SetError(txt_Direccion, "Debe completar la Dirección.")
        Else
            ErroresSucursal.SetError(txt_Direccion, Nothing)
        End If
    End Sub

    'Valido que ingrese el codigo postal.
    Private Sub txt_CodigoPostal_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_CodigoPostal.Validating
        If txt_CodigoPostal.Text = "" Then
            ErroresSucursal.SetError(txt_CodigoPostal, "Debe completar el Código Postal.")
        Else
            ErroresSucursal.SetError(txt_CodigoPostal, Nothing)
        End If
    End Sub

    'Valido que sea solo numeros.
    Private Sub txt_CodigoPostal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CodigoPostal.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que sea solo numeros. - MODIF.
    Private Sub txt_CodigoPostal_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CodigoPostal_mod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que ingrese el codigo postal. - MODIF.
    Private Sub txt_CodigoPostal_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_CodigoPostal_mod.Validating
        If txt_CodigoPostal_mod.Text = "" Then
            ErroresSucursal.SetError(txt_CodigoPostal_mod, "Debe completar el Código Postal.")
        Else
            ErroresSucursal.SetError(txt_CodigoPostal_mod, Nothing)
        End If
    End Sub

    'valido que ingrese la direccion. - MODIF.
    Private Sub txt_Direccion_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Direccion_mod.Validating
        If txt_Direccion_mod.Text = "" Then
            ErroresSucursal.SetError(txt_Direccion_mod, "Debe completar la Dirección.")
        Else
            ErroresSucursal.SetError(txt_Direccion_mod, Nothing)
        End If
    End Sub

    'valido que ingrese el nombre. - MODIF.
    Private Sub txt_Nombre_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Nombre_mod.Validating
        If txt_Nombre_mod.Text = "" Then
            ErroresSucursal.SetError(txt_Nombre_mod, "Debe completar el Nombre.")
        Else
            ErroresSucursal.SetError(txt_Nombre_mod, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión.
    Private Sub txt_ComisionEncargado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ComisionEncargado.Validating
        If txt_ComisionEncargado.Text = "" Then
            ErroresSucursal.SetError(txt_ComisionEncargado, "Debe completar la comisión.")
        Else
            ErroresSucursal.SetError(txt_ComisionEncargado, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión.
    Private Sub txt_ComisionEncargadoFeriado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ComisionEncargadoFeriado.Validating
        If txt_ComisionEncargadoFeriado.Text = "" Then
            ErroresSucursal.SetError(txt_ComisionEncargadoFeriado, "Debe completar la comisión.")
        Else
            ErroresSucursal.SetError(txt_ComisionEncargadoFeriado, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión.
    Private Sub txt_ComisionEncargadoMayor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ComisionEncargadoMayor.Validating
        If txt_ComisionEncargadoMayor.Text = "" Then
            ErroresSucursal.SetError(txt_ComisionEncargadoMayor, "Debe completar la comisión.")
        Else
            ErroresSucursal.SetError(txt_ComisionEncargadoMayor, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión.
    Private Sub txt_ComisionVendedorMayor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ComisionVendedorMayor.Validating
        If txt_ComisionVendedorMayor.Text = "" Then
            ErroresSucursal.SetError(txt_ComisionVendedorMayor, "Debe completar la comisión.")
        Else
            ErroresSucursal.SetError(txt_ComisionVendedorMayor, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión.
    Private Sub txt_ComisionVendedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ComisionVendedor.Validating
        If txt_ComisionVendedor.Text = "" Then
            ErroresSucursal.SetError(txt_ComisionVendedor, "Debe completar la comisión.")
        Else
            ErroresSucursal.SetError(txt_ComisionVendedor, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión.
    Private Sub txt_ComisionVendedorFeriado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ComisionVendedorFeriado.Validating
        If txt_ComisionVendedorFeriado.Text = "" Then
            ErroresSucursal.SetError(txt_ComisionVendedorFeriado, "Debe completar la comisión.")
        Else
            ErroresSucursal.SetError(txt_ComisionVendedorFeriado, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión. - MODIF.
    Private Sub txt_ComisionEncargado_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ComisionEncargado_mod.Validating
        If txt_ComisionEncargado_mod.Text = "" Then
            ErroresSucursal.SetError(txt_ComisionEncargado_mod, "Debe completar la comisión.")
        Else
            ErroresSucursal.SetError(txt_ComisionEncargado_mod, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión. - MODIF.
    Private Sub txt_ComisionEncargadoFeriado_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ComisionEncargadoFeriado_mod.Validating
        If txt_ComisionEncargadoFeriado_mod.Text = "" Then
            ErroresSucursal.SetError(txt_ComisionEncargadoFeriado_mod, "Debe completar la comisión.")
        Else
            ErroresSucursal.SetError(txt_ComisionEncargadoFeriado_mod, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión. - MODIF.
    Private Sub txt_ComisionEncargadoMayor_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ComisionEncargadoMayor_mod.Validating
        If txt_ComisionEncargadoMayor_mod.Text = "" Then
            ErroresSucursal.SetError(txt_ComisionEncargadoMayor_mod, "Debe completar la comisión.")
        Else
            ErroresSucursal.SetError(txt_ComisionEncargadoMayor_mod, Nothing)
        End If
    End Sub

    'valido que ingrese el codigo venta. - MODIF.
    Private Sub txt_CodigoVenta_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_CodigoVenta_mod.Validating
        If txt_CodigoVenta_mod.Text = "" Then
            ErroresSucursal.SetError(txt_CodigoVenta_mod, "Debe completar el código de venta.")
        Else
            ErroresSucursal.SetError(txt_CodigoVenta_mod, Nothing)
        End If
    End Sub

    'valido que ingrese el codigo venta.
    Private Sub txt_CodigoVenta_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_CodigoVenta.Validating
        If txt_CodigoVenta.Text = "" Then
            ErroresSucursal.SetError(txt_CodigoVenta, "Debe completar el código de venta.")
        Else
            ErroresSucursal.SetError(txt_CodigoVenta, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión. - MODIF.
    Private Sub txt_ComisionVendedor_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ComisionVendedor_mod.Validating
        If txt_ComisionVendedor_mod.Text = "" Then
            ErroresSucursal.SetError(txt_ComisionVendedor_mod, "Debe completar la comisión.")
        Else
            ErroresSucursal.SetError(txt_ComisionVendedor_mod, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión. - MODIF.
    Private Sub txt_ComisionVendedorFeriado_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ComisionVendedorFeriado_mod.Validating
        If txt_ComisionVendedorFeriado_mod.Text = "" Then
            ErroresSucursal.SetError(txt_ComisionVendedorFeriado_mod, "Debe completar la comisión.")
        Else
            ErroresSucursal.SetError(txt_ComisionVendedorFeriado_mod, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión. - MODIF.
    Private Sub txt_ComisionVendedorMayor_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ComisionVendedorMayor_mod.Validating
        If txt_ComisionVendedorMayor_mod.Text = "" Then
            ErroresSucursal.SetError(txt_ComisionVendedorMayor_mod, "Debe completar la comisión.")
        Else
            ErroresSucursal.SetError(txt_ComisionVendedorMayor_mod, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión en formato moneda.
    Private Sub txt_ComisionEncargado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ComisionEncargado.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErroresSucursal.SetError(txt_ComisionEncargado, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErroresSucursal.SetError(txt_ComisionEncargado, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión en formato moneda.
    Private Sub txt_ComisionEncargadoFeriado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ComisionEncargadoFeriado.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErroresSucursal.SetError(txt_ComisionEncargadoFeriado, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErroresSucursal.SetError(txt_ComisionEncargadoFeriado, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión en formato moneda.
    Private Sub txt_ComisionVendedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ComisionVendedor.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErroresSucursal.SetError(txt_ComisionVendedor, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErroresSucursal.SetError(txt_ComisionVendedor, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión en formato moneda.
    Private Sub txt_ComisionVendedorFeriado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ComisionVendedorFeriado.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErroresSucursal.SetError(txt_ComisionVendedorFeriado, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErroresSucursal.SetError(txt_ComisionVendedorFeriado, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión en formato moneda.
    Private Sub txt_ComisionVendedorMayor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ComisionVendedorMayor.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErroresSucursal.SetError(txt_ComisionVendedorMayor, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErroresSucursal.SetError(txt_ComisionVendedorMayor, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión en formato moneda.
    Private Sub txt_ComisionEncargadoMayor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ComisionEncargadoMayor.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErroresSucursal.SetError(txt_ComisionEncargadoMayor, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErroresSucursal.SetError(txt_ComisionEncargadoMayor, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión en formato moneda. - MODIF.
    Private Sub txt_ComisionEncargado_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ComisionEncargado_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErroresSucursal.SetError(txt_ComisionEncargado_mod, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErroresSucursal.SetError(txt_ComisionEncargado_mod, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión en formato moneda. - MODIF.
    Private Sub txt_ComisionEncargadoFeriado_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ComisionEncargadoFeriado_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErroresSucursal.SetError(txt_ComisionEncargadoFeriado_mod, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErroresSucursal.SetError(txt_ComisionEncargadoFeriado_mod, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión en formato moneda. - MODIF.
    Private Sub txt_ComisionVendedor_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ComisionVendedor_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErroresSucursal.SetError(txt_ComisionVendedor_mod, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErroresSucursal.SetError(txt_ComisionVendedor_mod, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión en formato moneda. - MODIF.
    Private Sub txt_ComisionVendedorFeriado_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ComisionVendedorFeriado_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErroresSucursal.SetError(txt_ComisionVendedorFeriado_mod, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErroresSucursal.SetError(txt_ComisionVendedorFeriado_mod, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión en formato moneda. - MODIF.
    Private Sub txt_ComisionVendedorMayor_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ComisionVendedorMayor_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErroresSucursal.SetError(txt_ComisionVendedorMayor_mod, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErroresSucursal.SetError(txt_ComisionVendedorMayor_mod, Nothing)
        End If
    End Sub

    'valido que ingrese la comisión en formato moneda. - MODIF.
    Private Sub txt_ComisionEncargadoMayor_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ComisionEncargadoMayor_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErroresSucursal.SetError(txt_ComisionEncargadoMayor_mod, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErroresSucursal.SetError(txt_ComisionEncargadoMayor_mod, Nothing)
        End If
    End Sub

    'valido que el codigo venta sea formato alfavetico. - MODIF.
    Private Sub txt_CodigoVenta_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CodigoVenta_mod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloLetras(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'valido que el codigo venta sea formato alfavetico.
    Private Sub txt_CodigoVenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CodigoVenta.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloLetras(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

#End Region

#Region "Región de Eventos"
    'Evento lanzado cuando carga el form.
    Private Sub frmSucursales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            TabSucursales.Cursor = Cursors.WaitCursor

            'seteo el font a 8px
            DG_Sucursales.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Sucursales.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Sucursales.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Sucursales.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'seteo las imagenes
            Dim ListaImagenes = New ImageList
            ListaImagenes.ImageSize = New Size(32, 32)
            ListaImagenes.TransparentColor = Color.Blue
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit

            ListaImagenes.Images.Add(My.Resources.Recursos.Sucursal)
            ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
            ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)

            TabSucursales.ImageList = ListaImagenes

            'icono de Sucursal
            TbListado.ImageIndex = 0
            'icono de alta
            TbAlta.ImageIndex = 1
            'icono de edicion
            TbMod.ImageIndex = 2

            'Cargo el datagrid
            Dim dsSucursales As New DataSet
            dsSucursales = NegSucursal.ListadoSucursalesCompleto()
            If (dsSucursales.Tables(0).Rows.Count > 0) Then
                DG_Sucursales.DataSource = dsSucursales.Tables(0)
                DG_Sucursales.AutoGenerateColumns = False
                DG_Sucursales.Columns("id_Sucursal").Visible = False
                DG_Sucursales.Columns("Nombre").DisplayIndex = 1
                DG_Sucursales.Columns("Direccion").DisplayIndex = 2
                DG_Sucursales.Columns("Telefono").DisplayIndex = 3
                DG_Sucursales.Columns("Habilitado").DisplayIndex = 4
                DG_Sucursales.Columns("Modificar").DisplayIndex = 5
                DG_Sucursales.Columns("Eliminar").DisplayIndex = 6
                DG_Sucursales.Refresh()
            End If

            'agregado para el funcionamiento de patentes
            Dim objusuario As New Negocio.Usuario
            '225 visualiza sucursal - si llego aca puede visualizarlos
            '223 crea sucursal
            If (objusuario.EsPatenteValida(223, VariablesGlobales.Patentes)) Then
            Else
                TabSucursales.TabPages.Remove(Me.TbAlta)
            End If
            '224 modifica sucursal
            If (objusuario.EsPatenteValida(224, VariablesGlobales.Patentes)) Then
            Else
                TabSucursales.TabPages.Remove(Me.TbMod)
                DG_Sucursales.Columns("Modificar").Visible = False
            End If
            '226 elimina sucursal
            If (objusuario.EsPatenteValida(226, VariablesGlobales.Patentes)) Then
            Else
                TabSucursales.TabPages.Remove(Me.TbMod)
                DG_Sucursales.Columns("Eliminar").Visible = False
            End If

            'Cambio el cursor a NORMAL.
            TabSucursales.Cursor = Cursors.Arrow
        Catch ex As Exception
            TabSucursales.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al listar las sucursales.", "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Evento lanzado cuando cambia de TAB.
    Private Sub TabSucursales_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabSucursales.Selected
        'Cambio el cursor a "WAIT"
        TabSucursales.Cursor = Cursors.WaitCursor

        If TabSucursales.SelectedIndex = 0 Then 'TAB LISTADO
            'Actualizo el datagrid si se selecciona el tab del listado
            Dim dsSucursales As New DataSet
            dsSucursales = NegSucursal.ListadoSucursalesCompleto()
            If (dsSucursales.Tables(0).Rows.Count > 0) Then
                DG_Sucursales.DataSource = dsSucursales.Tables(0)
                DG_Sucursales.AutoGenerateColumns = False
                DG_Sucursales.Columns("id_Sucursal").Visible = False
                DG_Sucursales.Columns("Nombre").DisplayIndex = 1
                DG_Sucursales.Columns("Direccion").DisplayIndex = 2
                DG_Sucursales.Columns("Telefono").DisplayIndex = 3
                DG_Sucursales.Columns("Habilitado").DisplayIndex = 4
                DG_Sucursales.Columns("Modificar").DisplayIndex = 5
                DG_Sucursales.Columns("Eliminar").DisplayIndex = 6
                DG_Sucursales.Refresh()
            End If

            'Limpio los formularios
            LimpiarFormAltaSucursales()
            LimpiarFormModificacionSucursales()

            'Seteo el id_CLiente en cero
            ESucursales.id_Sucursal = 0

        ElseIf TabSucursales.SelectedIndex = 1 Then 'TAB ALTA
            'Limpio el formulario de alta.
            LimpiarFormAltaSucursales()

        ElseIf TabSucursales.SelectedIndex = 2 Then 'TAB MODIFICACION
            If ESucursales.id_Sucursal > 0 Or ESucursales.id_Sucursal <> Nothing Then

            Else
                MessageBox.Show("Debe seleccionar previamente una sucursal.", "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                TabSucursales.SelectedIndex = 0
            End If
        End If

        'Cambio el cursor a NORMAL.
        TabSucursales.Cursor = Cursors.Arrow
    End Sub

    'Evento cuando realiza un Doble click en el DG_Sucursales.
    Private Sub DG_Sucursales_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Sucursales.CellDoubleClick
        Try
            'Cambio el cursor a "WAIT"
            TabSucursales.Cursor = Cursors.WaitCursor

            Dim id_Sucursal As Integer = DG_Sucursales.Rows(e.RowIndex).Cells("id_Sucursal").Value()
            ESucursales.id_Sucursal = id_Sucursal

            'lleno la entidad sucursales
            ESucursales = NegSucursal.TraerSucursal(id_Sucursal)

            'lleno los controls del tab_modificacion
            txt_Nombre_mod.Text = ESucursales.Nombre
            txt_Telefono_mod.Text = ESucursales.Telefono
            txt_CodigoPostal_mod.Text = ESucursales.Codigo_Postal
            txt_Direccion_mod.Text = ESucursales.Direccion
            txt_ComisionEncargado_mod.Text = ESucursales.ComisionEncargado
            txt_ComisionVendedor_mod.Text = ESucursales.ComisionVendedor
            txt_ComisionEncargadoFeriado_mod.Text = ESucursales.ComisionEncargadoFeriado
            txt_ComisionVendedorFeriado_mod.Text = ESucursales.ComisionVendedorFeriado
            txt_ComisionEncargadoMayor_mod.Text = ESucursales.ComisionEncargadoMayor
            txt_ComisionVendedorMayor_mod.Text = ESucursales.ComisionVendedorMayor
            txt_CodigoVenta_mod.Text = ESucursales.CodigoVenta

            'Cargo el combo de Provincias
            Dim dsProvincias As New DataSet
            dsProvincias = NegProvincias.ListadoProvincias()
            If (dsProvincias.Tables(0).Rows.Count > 0) Then
                cb_Provincia_mod.DataSource = Nothing
                cb_Provincia_mod.DataSource = dsProvincias.Tables(0)
                cb_Provincia_mod.DisplayMember = "Descripcion"
                cb_Provincia_mod.ValueMember = "id_Provincia"
                cb_Provincia_mod.SelectedValue = ESucursales.id_Provincia
                cb_Provincia_mod.Refresh()
            End If

            'Cargo el combo de Distritos
            Dim dsDistritos As New DataSet
            dsDistritos = NegDistritos.ListadoDistritos(ESucursales.id_Provincia)
            If (dsDistritos.Tables(0).Rows.Count > 0) Then
                cb_Distrito_mod.DataSource = Nothing
                cb_Distrito_mod.DataSource = dsDistritos.Tables(0)
                cb_Distrito_mod.DisplayMember = "Descripcion"
                cb_Distrito_mod.ValueMember = "id_Departamento"
                cb_Distrito_mod.SelectedValue = ESucursales.id_Distrito
                cb_Distrito_mod.Refresh()
            End If

            'Cargo el combo de Localidades
            Dim dsLocalidades As New DataSet
            dsLocalidades = NegLocalidades.ListadoLocalidades(ESucursales.id_Distrito)
            If (dsLocalidades.Tables(0).Rows.Count > 0) Then
                cb_Localidad_mod.DataSource = Nothing
                cb_Localidad_mod.DataSource = dsLocalidades.Tables(0)
                cb_Localidad_mod.DisplayMember = "Descripcion"
                cb_Localidad_mod.ValueMember = "id_Localidad"
                cb_Localidad_mod.SelectedValue = ESucursales.id_Localidad
                cb_Localidad_mod.Refresh()
            End If

            If ESucursales.Habilitado = "1" Then
                chk_Habilitado_mod.Checked = True
            Else
                chk_Habilitado_mod.Checked = False
            End If

            'Cambio el cursor a NORMAL.
            TabSucursales.Cursor = Cursors.Arrow

            'hago foco en el tab_modificacion 
            TabSucursales.SelectedIndex = 2
        Catch ex As Exception
            TabSucursales.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al recuperar la información acerca de la sucursal.", "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Evento cuando realiza un click en el DG_Sucursales.
    Private Sub DG_Sucursales_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Sucursales.CellContentClick
        If DG_Sucursales.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar la sucursal?", "Administración de Sucursales", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Try
                    Dim id_Sucursal As Integer = DG_Sucursales.Rows(e.RowIndex).Cells("id_Sucursal").Value
                    If id_Sucursal = 0 Then
                        'si no completo la descripcion, muestro un msg de error.
                        MessageBox.Show("No se puede eliminar la sucursal.", "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        'Si la sucursal está seteada en la aplicacion.
                        If id_Sucursal = My.Settings.Sucursal Then
                            MessageBox.Show("La sucursal no puede ser eliminada está siendo utilizanda por la aplicación.", "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else
                            'Cambiar cursor
                            Me.Cursor = Cursors.WaitCursor

                            'ejecuto el sp_EliminarColores.
                            MessageBox.Show(NegSucursal.EliminarSucursal(id_Sucursal), "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            'Cargo el datagrid de sucursales.
                            Dim dsSucursales As New DataSet
                            dsSucursales = NegSucursal.ListadoSucursalesCompleto()
                            If (dsSucursales.Tables(0).Rows.Count > 0) Then
                                DG_Sucursales.DataSource = dsSucursales.Tables(0)
                                DG_Sucursales.AutoGenerateColumns = False
                                DG_Sucursales.Columns("id_Sucursal").Visible = False
                                DG_Sucursales.Columns("Nombre").DisplayIndex = 1
                                DG_Sucursales.Columns("Direccion").DisplayIndex = 2
                                DG_Sucursales.Columns("Telefono").DisplayIndex = 3
                                DG_Sucursales.Columns("Habilitado").DisplayIndex = 4
                                DG_Sucursales.Columns("Modificar").DisplayIndex = 5
                                DG_Sucursales.Columns("Eliminar").DisplayIndex = 6
                                DG_Sucursales.Refresh()
                            End If

                            'Cambiar cursor
                            Me.Cursor = Cursors.Arrow
                        End If
                    End If
                Catch ex As Exception
                    Me.Cursor = Cursors.Arrow
                    MessageBox.Show("Se ha producido un error al eliminar la sucursal.", "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        ElseIf DG_Sucursales.Columns(e.ColumnIndex).Name = "Modificar" Then 'Si se hace click en el boton "modificar" de la fila.
            Try
                'Cambio el cursor a "WAIT"
                TabSucursales.Cursor = Cursors.WaitCursor

                Dim id_Sucursal As Integer = DG_Sucursales.Rows(e.RowIndex).Cells("id_Sucursal").Value()
                ESucursales.id_Sucursal = id_Sucursal

                'lleno la entidad sucursales
                ESucursales = NegSucursal.TraerSucursal(id_Sucursal)

                'lleno los controls del tab_modificacion
                txt_Nombre_mod.Text = ESucursales.Nombre
                txt_Telefono_mod.Text = ESucursales.Telefono
                txt_CodigoPostal_mod.Text = ESucursales.Codigo_Postal
                txt_Direccion_mod.Text = ESucursales.Direccion
                txt_ComisionEncargado_mod.Text = ESucursales.ComisionEncargado
                txt_ComisionVendedor_mod.Text = ESucursales.ComisionVendedor
                txt_ComisionEncargadoFeriado_mod.Text = ESucursales.ComisionEncargadoFeriado
                txt_ComisionVendedorFeriado_mod.Text = ESucursales.ComisionVendedorFeriado
                txt_ComisionEncargadoMayor_mod.Text = ESucursales.ComisionEncargadoMayor
                txt_ComisionVendedorMayor_mod.Text = ESucursales.ComisionVendedorMayor

                'Cargo el combo de Provincias
                Dim dsProvincias As New DataSet
                dsProvincias = NegProvincias.ListadoProvincias()
                If (dsProvincias.Tables(0).Rows.Count > 0) Then
                    cb_Provincia_mod.DataSource = Nothing
                    cb_Provincia_mod.DataSource = dsProvincias.Tables(0)
                    cb_Provincia_mod.DisplayMember = "Descripcion"
                    cb_Provincia_mod.ValueMember = "id_Provincia"
                    cb_Provincia_mod.SelectedValue = ESucursales.id_Provincia
                    cb_Provincia_mod.Refresh()
                End If

                'Cargo el combo de Distritos
                Dim dsDistritos As New DataSet
                dsDistritos = NegDistritos.ListadoDistritos(ESucursales.id_Provincia)
                If (dsDistritos.Tables(0).Rows.Count > 0) Then
                    cb_Distrito_mod.DataSource = Nothing
                    cb_Distrito_mod.DataSource = dsDistritos.Tables(0)
                    cb_Distrito_mod.DisplayMember = "Descripcion"
                    cb_Distrito_mod.ValueMember = "id_Departamento"
                    cb_Distrito_mod.SelectedValue = ESucursales.id_Distrito
                    cb_Distrito_mod.Refresh()
                End If

                'Cargo el combo de Localidades
                Dim dsLocalidades As New DataSet
                dsLocalidades = NegLocalidades.ListadoLocalidades(ESucursales.id_Distrito)
                If (dsLocalidades.Tables(0).Rows.Count > 0) Then
                    cb_Localidad_mod.DataSource = Nothing
                    cb_Localidad_mod.DataSource = dsLocalidades.Tables(0)
                    cb_Localidad_mod.DisplayMember = "Descripcion"
                    cb_Localidad_mod.ValueMember = "id_Localidad"
                    cb_Localidad_mod.SelectedValue = ESucursales.id_Localidad
                    cb_Localidad_mod.Refresh()
                End If

                If ESucursales.Habilitado = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'Cambio el cursor a NORMAL.
                TabSucursales.Cursor = Cursors.Arrow

                'hago foco en el tab_modificacion 
                TabSucursales.SelectedIndex = 2
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al recuperar la información acerca de la sucursal.", "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Boton Agregar Sucursal.
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        If txt_Direccion.Text = "" Or txt_CodigoPostal.Text = "" Or txt_Nombre.Text = "" Or cb_Provincia.SelectedItem Is Nothing Or cb_Distrito.SelectedItem Is Nothing Or cb_Localidad.SelectedItem Is Nothing Or txt_ComisionEncargado.Text = "" Or txt_ComisionEncargadoFeriado.Text = "" Or txt_ComisionVendedor.Text = "" Or txt_ComisionVendedorFeriado.Text = "" Or txt_ComisionEncargadoMayor.Text = "" Or txt_ComisionVendedorMayor.Text = "" Or txt_CodigoVenta.Text = "" Then
            MessageBox.Show("Debe completar los campos requeridos.", "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Cursor
                Me.Cursor = Cursors.WaitCursor

                'Lleno la entidad sucursales.
                ESucursales.Nombre = Trim(txt_Nombre.Text)
                ESucursales.Telefono = Trim(txt_Telefono.Text)
                ESucursales.Codigo_Postal = Trim(txt_CodigoPostal.Text)
                ESucursales.Direccion = Trim(txt_Direccion.Text)
                ESucursales.id_Provincia = cb_Provincia.SelectedValue
                ESucursales.id_Localidad = cb_Localidad.SelectedValue
                ESucursales.id_Distrito = cb_Distrito.SelectedValue
                ESucursales.ComisionVendedor = Trim(txt_ComisionVendedor.Text)
                ESucursales.ComisionEncargado = Trim(txt_ComisionEncargado.Text)
                ESucursales.ComisionVendedorFeriado = Trim(txt_ComisionVendedorFeriado.Text)
                ESucursales.ComisionEncargadoFeriado = Trim(txt_ComisionEncargadoFeriado.Text)
                ESucursales.ComisionVendedorMayor = Trim(txt_ComisionVendedorMayor.Text)
                ESucursales.ComisionEncargadoMayor = Trim(txt_ComisionEncargadoMayor.Text)
                ESucursales.CodigoVenta = Trim(txt_CodigoVenta.Text)

                If chk_Habilitado.Checked = True Then
                    ESucursales.Habilitado = 1
                Else
                    ESucursales.Habilitado = 0
                End If

                'Limpio el formulario
                LimpiarFormAltaSucursales()

                'Cursor
                Me.Cursor = Cursors.Arrow

                'Ejecuto el sp_Sucursales_Alta.
                MessageBox.Show(NegSucursal.AltaSucursal(ESucursales), "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al registrar la sucursal. Por favor, intente más tarde.", "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Boton Eliminar Sucursal.
    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Está seguro que desea eliminar la Sucursal?", "Administración de Sucursales", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
            Try
                If ESucursales.id_Sucursal = 0 Then
                    'si no se seteo la sucursal, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar la sucursal.", "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'Si la sucursal está seteada en la aplicacion.
                    If ESucursales.id_Sucursal = My.Settings.Sucursal Then
                        MessageBox.Show("La sucursal no puede ser eliminada está siendo utilizanda por la aplicación.", "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        'Cambiar cursor
                        Me.Cursor = Cursors.WaitCursor

                        'ejecuto el sp_Sucursales_Eliminar.
                        MessageBox.Show(NegSucursal.EliminarSucursal(ESucursales.id_Sucursal), "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Cargo el datagrid de sucursales.
                        Dim dsSucursales As New DataSet
                        dsSucursales = NegSucursal.ListadoSucursalesCompleto()
                        If (dsSucursales.Tables(0).Rows.Count > 0) Then
                            DG_Sucursales.DataSource = dsSucursales.Tables(0)
                            DG_Sucursales.AutoGenerateColumns = False
                            DG_Sucursales.Columns("id_Sucursal").Visible = False
                            DG_Sucursales.Columns("Nombre").DisplayIndex = 1
                            DG_Sucursales.Columns("Direccion").DisplayIndex = 2
                            DG_Sucursales.Columns("Telefono").DisplayIndex = 3
                            DG_Sucursales.Columns("Habilitado").DisplayIndex = 4
                            DG_Sucursales.Columns("Modificar").DisplayIndex = 5
                            DG_Sucursales.Columns("Eliminar").DisplayIndex = 6
                            DG_Sucursales.Refresh()
                        End If

                        'Cambiar cursor
                        Me.Cursor = Cursors.Arrow
                    End If

                    'hago foco en el tab_listado 
                    TabSucursales.SelectedIndex = 0
                End If
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al eliminar la sucursal.", "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Boton Modificar Sucursal.
    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click
        If txt_Direccion_mod.Text = "" Or txt_CodigoPostal_mod.Text = "" Or txt_Nombre_mod.Text = "" Or cb_Provincia_mod.SelectedItem Is Nothing Or cb_Distrito_mod.SelectedItem Is Nothing Or cb_Localidad_mod.SelectedItem Is Nothing Or txt_ComisionEncargado_mod.Text = "" Or txt_ComisionEncargadoFeriado_mod.Text = "" Or txt_ComisionVendedor_mod.Text = "" Or txt_ComisionVendedorFeriado_mod.Text = "" Or txt_ComisionVendedorMayor_mod.Text = "" Or txt_ComisionEncargadoMayor_mod.Text = "" Or txt_CodigoVenta_mod.Text = "" Then
            MessageBox.Show("Debe completar los campos requeridos.", "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Cursor
                Me.Cursor = Cursors.WaitCursor

                'Lleno la entidad sucursales.
                ESucursales.Nombre = Trim(txt_Nombre_mod.Text)
                ESucursales.Telefono = Trim(txt_Telefono_mod.Text)
                ESucursales.Codigo_Postal = Trim(txt_CodigoPostal_mod.Text)
                ESucursales.Direccion = Trim(txt_Direccion_mod.Text)
                ESucursales.id_Provincia = cb_Provincia_mod.SelectedValue
                ESucursales.id_Localidad = cb_Localidad_mod.SelectedValue
                ESucursales.id_Distrito = cb_Distrito_mod.SelectedValue
                ESucursales.ComisionVendedor = Trim(txt_ComisionVendedor_mod.Text)
                ESucursales.ComisionEncargado = Trim(txt_ComisionEncargado_mod.Text)
                ESucursales.ComisionVendedorFeriado = Trim(txt_ComisionVendedorFeriado_mod.Text)
                ESucursales.ComisionEncargadoFeriado = Trim(txt_ComisionEncargadoFeriado_mod.Text)
                ESucursales.ComisionVendedorMayor = Trim(txt_ComisionVendedorMayor_mod.Text)
                ESucursales.ComisionEncargadoMayor = Trim(txt_ComisionEncargadoMayor_mod.Text)
                ESucursales.CodigoVenta = Trim(txt_CodigoVenta_mod.Text)

                If chk_Habilitado_mod.Checked = True Then
                    ESucursales.Habilitado = 1
                Else
                    ESucursales.Habilitado = 0
                End If

                'Limpio el formulario
                LimpiarFormModificacionSucursales()

                'Cursor
                Me.Cursor = Cursors.Arrow

                'Ejecuto el sp_Sucursales_Modificar.
                MessageBox.Show(NegSucursal.ModificacionSucursal(ESucursales), "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Se ha producido un error al modificar la sucursal. Por favor, intente más tarde.", "Administración de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Redirecciono al listado
            TabSucursales.SelectedIndex = 0
        End If
    End Sub

    'Cargo el combo de Provincias.
    Private Sub cb_Provincia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Provincia.GotFocus
        Dim dsProvincias As New DataSet
        dsProvincias = NegProvincias.ListadoProvincias()
        If (dsProvincias.Tables(0).Rows.Count > 0) Then
            cb_Provincia.DataSource = Nothing
            cb_Provincia.DataSource = dsProvincias.Tables(0)
            cb_Provincia.DisplayMember = "Descripcion"
            cb_Provincia.ValueMember = "id_Provincia"
            cb_Provincia.Refresh()
            cb_Localidad.DataSource = Nothing
            cb_Localidad.Refresh()
        End If
    End Sub

    'Cargo el combo de Localidades.
    Private Sub cb_Distrito_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Distrito.SelectionChangeCommitted
        If cb_Provincia.SelectedValue <> 0 Then
            Dim dsLocalidades As New DataSet
            dsLocalidades = NegLocalidades.ListadoLocalidades(cb_Distrito.SelectedValue)
            If (dsLocalidades.Tables(0).Rows.Count > 0) Then
                cb_Localidad.DataSource = Nothing
                cb_Localidad.DataSource = dsLocalidades.Tables(0)
                cb_Localidad.DisplayMember = "Descripcion"
                cb_Localidad.ValueMember = "id_Localidad"
                cb_Localidad.Refresh()
            End If
        End If
    End Sub

    'Cargo el combo de Distritos.
    Private Sub cb_Provincia_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Provincia.SelectionChangeCommitted
        If cb_Provincia.SelectedValue <> 0 Then
            Dim dsDistritos As New DataSet
            dsDistritos = NegDistritos.ListadoDistritos(cb_Provincia.SelectedValue)
            If (dsDistritos.Tables(0).Rows.Count > 0) Then
                cb_Distrito.DataSource = Nothing
                cb_Distrito.DataSource = dsDistritos.Tables(0)
                cb_Distrito.DisplayMember = "Descripcion"
                cb_Distrito.ValueMember = "id_Departamento"
                cb_Distrito.Refresh()
            End If
        End If
    End Sub

    'Cargo el combo de Provincias. - MODIF.
    Private Sub cb_Provincia_mod_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Provincia_mod.GotFocus
        Dim dsProvincias As New DataSet
        dsProvincias = NegProvincias.ListadoProvincias()
        If (dsProvincias.Tables(0).Rows.Count > 0) Then
            cb_Provincia_mod.DataSource = Nothing
            cb_Provincia_mod.DataSource = dsProvincias.Tables(0)
            cb_Provincia_mod.DisplayMember = "Descripcion"
            cb_Provincia_mod.ValueMember = "id_Provincia"
            cb_Provincia_mod.Refresh()
            cb_Localidad_mod.DataSource = Nothing
            cb_Localidad_mod.Refresh()
        End If
    End Sub

    'Cargo el combo de Localidades. - MODIF.
    Private Sub cb_Distrito_mod_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Distrito_mod.SelectionChangeCommitted
        If cb_Provincia_mod.SelectedValue <> 0 Then
            Dim dsLocalidades As New DataSet
            dsLocalidades = NegLocalidades.ListadoLocalidades(cb_Distrito_mod.SelectedValue)
            If (dsLocalidades.Tables(0).Rows.Count > 0) Then
                cb_Localidad_mod.DataSource = Nothing
                cb_Localidad_mod.DataSource = dsLocalidades.Tables(0)
                cb_Localidad_mod.DisplayMember = "Descripcion"
                cb_Localidad_mod.ValueMember = "id_Localidad"
                cb_Localidad_mod.Refresh()
            End If
        End If
    End Sub

    'Cargo el combo de Distritos.
    Private Sub cb_Provincia_mod_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Provincia_mod.SelectionChangeCommitted
        If cb_Provincia_mod.SelectedValue <> 0 Then
            Dim dsDistritos As New DataSet
            dsDistritos = NegDistritos.ListadoDistritos(cb_Provincia_mod.SelectedValue)
            If (dsDistritos.Tables(0).Rows.Count > 0) Then
                cb_Distrito_mod.DataSource = Nothing
                cb_Distrito_mod.DataSource = dsDistritos.Tables(0)
                cb_Distrito_mod.DisplayMember = "Descripcion"
                cb_Distrito_mod.ValueMember = "id_Departamento"
                cb_Distrito_mod.Refresh()
            End If
        End If
    End Sub
#End Region

#Region "Región de Funciones"
    'Funcion que limpia el formulario de Alta.
    Sub LimpiarFormAltaSucursales()
        ErroresSucursal.Clear()
        txt_Nombre.Clear()
        txt_Direccion.Clear()
        txt_Telefono.Clear()
        txt_CodigoPostal.Clear()
        txt_ComisionEncargado.Clear()
        txt_ComisionVendedor.Clear()
        txt_ComisionEncargadoFeriado.Clear()
        txt_ComisionVendedorFeriado.Clear()
        txt_ComisionEncargadoMayor.Clear()
        txt_ComisionVendedorMayor.Clear()
        txt_CodigoVenta.Clear()
        cb_Provincia.SelectedItem = Nothing
        cb_Localidad.SelectedItem = Nothing
        cb_Distrito.SelectedItem = Nothing
        chk_Habilitado.Checked = True
    End Sub

    'Funcion que limpia el formulario de Modificacion.
    Sub LimpiarFormModificacionSucursales()
        ErroresSucursal.Clear()
        txt_Nombre_mod.Clear()
        txt_Direccion_mod.Clear()
        txt_Telefono_mod.Clear()
        txt_CodigoPostal_mod.Clear()
        txt_ComisionEncargado_mod.Clear()
        txt_ComisionVendedor_mod.Clear()
        txt_ComisionEncargadoFeriado_mod.Clear()
        txt_ComisionVendedorFeriado_mod.Clear()
        txt_ComisionEncargadoMayor_mod.Clear()
        txt_CodigoVenta_mod.Clear()
        txt_ComisionVendedorMayor_mod.Clear()
        cb_Provincia_mod.SelectedItem = Nothing
        cb_Localidad_mod.SelectedItem = Nothing
        cb_Distrito_mod.SelectedItem = Nothing
        chk_Habilitado_mod.Checked = True
    End Sub
#End Region

End Class