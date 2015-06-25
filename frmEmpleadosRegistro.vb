Public Class frmEmpleadosRegistro
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim NegRegistros As New Negocio.NegRegistros
    Dim ERegistros As New Entidades.Registros
    Dim fuc As New Funciones
    Dim id_Sucursal As String

    'Load del formulario
    Private Sub frmEmpleadosRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Sucursal default
        id_Sucursal = My.Settings("Sucursal")

        'seteo las imagenes
        Dim ListaImagenes = New ImageList
        ListaImagenes.ImageSize = New Size(32, 32)
        ListaImagenes.TransparentColor = Color.Blue
        ListaImagenes.ColorDepth = ColorDepth.Depth32Bit
        ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
        ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)
        Tcontrol.ImageList = ListaImagenes

        'icono de clientes
        TabIngresar.ImageIndex = 0
        'icono de alta
        TabVisualizar.ImageIndex = 1

        'Cargo los empleados
        Dim DsEmpleados As New DataSet
        DsEmpleados = NegEmpleados.ListadoEmpleadosSucursal(id_Sucursal)
        
        'Cargo el checkboxlist
        If (DsEmpleados.Tables(0).Rows.Count > 0) Then
            CheckListEmpleados.DataSource = DsEmpleados.Tables(0)
            CheckListEmpleados.DisplayMember = "Apellido"
            CheckListEmpleados.ValueMember = "id_Empleado"
            CheckListEmpleados.Refresh()
        End If

        'Cargo el checkboxlistEdit
        If (DsEmpleados.Tables(0).Rows.Count > 0) Then
            CheckListEmpleadosEdit.DataSource = DsEmpleados.Tables(0)
            CheckListEmpleadosEdit.DisplayMember = "Apellido"
            CheckListEmpleadosEdit.ValueMember = "id_Empleado"
            CheckListEmpleadosEdit.Refresh()
        End If

        'Cargo el listbox
        Dim DsRegistros As New DataSet
        DsRegistros = NegRegistros.ListadoRegistrosSucursal(id_Sucursal)
        If (DsRegistros.Tables(0).Rows.Count > 0) Then
            LstFechas.DataSource = DsRegistros.Tables(0)
            LstFechas.DisplayMember = "Resultado"
            LstFechas.ValueMember = "id_Registro"
            LstFechas.Refresh()
        End If

        'Seteo en Cero los checkboxs
        fuc.SetearCheckboxlist(CheckListEmpleados, False)
        fuc.SetearCheckboxlist(CheckListEmpleadosEdit, False)
        LstFechas.SelectedIndex = -1
        CheckListEmpleados.SelectedIndex = -1
        CheckListEmpleadosEdit.SelectedIndex = -1

        'Seteo el ID a 0.
        ERegistros.id_Registro = 0

        'Cambio el cursor a "NORMAL"
        Me.Cursor = Cursors.Arrow
    End Sub

    'Agrega empleados a la fecha seleccionada.
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        Try
            If CheckListEmpleados.CheckedItems.Count < 1 Then
                MessageBox.Show("Debe seleccionar al menos un empleado.", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                ERegistros.id_Sucursal = id_Sucursal
                ERegistros.Fecha = DT_Fecha.Value.ToString("yyyy/MM/dd")
                ERegistros.Empleados = CheckListEmpleados

                'Ejecuto el sp_Registros_Alta
                MessageBox.Show(NegRegistros.AgregarRegistro(ERegistros), "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Cargo el listbox
                Dim DsRegistros As New DataSet
                DsRegistros = NegRegistros.ListadoRegistrosSucursal(id_Sucursal)
                If (DsRegistros.Tables(0).Rows.Count > 0) Then
                    LstFechas.DataSource = DsRegistros.Tables(0)
                    LstFechas.DisplayMember = "Resultado"
                    LstFechas.ValueMember = "id_Registro"
                    LstFechas.Refresh()
                End If

                'Limpio los Controles
                LimpiarCampos()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                'Seteo el tab que se visualiza
                Tcontrol.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al registrar el registro de empleados. Por favor, intente más tarde.", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    'Marca los empleados dependiendo en donde se ha realizado click.
    Private Sub LstFechas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstFechas.Click

        If LstFechas.SelectedValue <> 0 And LstFechas.SelectedValue <> Nothing Then
            fuc.SetearCheckboxlist(CheckListEmpleadosEdit, False)
            Dim dsRegistro As DataSet = NegRegistros.ListadoRegistrosFecha(LstFechas.SelectedValue, id_Sucursal)

            'Obtengo el Registro.
            ERegistros = NegRegistros.TraerRegistro(LstFechas.SelectedValue)

            'Seteo la fecha.
            DT_FechaEdit.Value = String.Format("{0:dd/MM/yyyy}", ERegistros.Fecha)

            'checkeo los items de empleados que corresponden a  la fecha.
            For i As Integer = 0 To CheckListEmpleadosEdit.Items.Count - 1
                For j As Integer = 0 To dsRegistro.Tables(0).Rows.Count - 1
                    If dsRegistro.Tables(0).Rows.Count > 0 Then
                        If DirectCast(CheckListEmpleadosEdit.Items(i), System.Data.DataRowView).Row.ItemArray(0) = dsRegistro.Tables(0).Rows(j).Item(0) Then
                            CheckListEmpleadosEdit.SetItemChecked(i, True)
                        End If
                    End If
                Next j
            Next i

            'Muestro El tabVisualizar.
            Tcontrol.SelectedIndex = 1
        End If

    End Sub

    'Cuando elimina una fecha del listbox.
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
        Try
            If LstFechas.SelectedValue < 1 Then
                MessageBox.Show("Debe seleccionar una fecha.", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim Result As DialogResult
                Result = MessageBox.Show("¿Está seguro que desea eliminar el registro de empleados seleccionado?", "Registro de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar 
                    MessageBox.Show(NegRegistros.EliminarRegistro(LstFechas.SelectedValue), "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Cargo el listbox
                    Dim DsRegistros As New DataSet
                    DsRegistros = NegRegistros.ListadoRegistrosSucursal(id_Sucursal)
                    If (DsRegistros.Tables(0).Rows.Count > 0) Then
                        LstFechas.DataSource = DsRegistros.Tables(0)
                        LstFechas.DisplayMember = "Resultado"
                        LstFechas.ValueMember = "id_Registro"
                        LstFechas.Refresh()
                    End If

                    'Limpio los Controles
                    LimpiarCampos()

                    'Seteo el tab que se visualiza
                    Tcontrol.SelectedIndex = 0
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al eliminar la fecha seleccionada. Por favor, intente más tarde.", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Cuando cambia el TAB.
    Private Sub Tcontrol_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles Tcontrol.Selected
        If Tcontrol.SelectedIndex = 0 Then 'TAB INGRESO
            'Limpio los Controles
            LimpiarCampos()

            'Seteo el ID a 0.
            ERegistros.id_Registro = 0
        Else
            If ERegistros.id_Registro > 0 Or ERegistros.id_Registro <> Nothing Then

            Else
                MessageBox.Show("Debe seleccionar previamente una fecha.", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Tcontrol.SelectedIndex = 0
            End If
        End If
    End Sub

    'Funcion limpiar
    Sub LimpiarCampos()
        'Seteo la fecha.
        DT_Fecha.Value = String.Format("{0:dd/MM/yyyy}", Date.Now)

        'Seteo en Cero los checkboxs
        fuc.SetearCheckboxlist(CheckListEmpleados, False)
        fuc.SetearCheckboxlist(CheckListEmpleadosEdit, False)
        LstFechas.SelectedIndex = -1
        CheckListEmpleados.SelectedIndex = -1
        CheckListEmpleadosEdit.SelectedIndex = -1
    End Sub

    'Edita los empleados de la fecha seleccionada.
    Private Sub Btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Editar.Click
        Try
            If CheckListEmpleadosEdit.CheckedItems.Count < 1 Then
                MessageBox.Show("Debe seleccionar al menos un empleado.", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                ERegistros.id_Sucursal = id_Sucursal
                ERegistros.Fecha = DT_FechaEdit.Value.ToString("yyyy/MM/dd")
                ERegistros.Empleados = CheckListEmpleadosEdit

                'Ejecuto el sp_Registros_Alta
                MessageBox.Show(NegRegistros.ModificacionRegistro(ERegistros), "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Cargo el listbox
                Dim DsRegistros As New DataSet
                DsRegistros = NegRegistros.ListadoRegistrosSucursal(id_Sucursal)
                If (DsRegistros.Tables(0).Rows.Count > 0) Then
                    LstFechas.DataSource = DsRegistros.Tables(0)
                    LstFechas.DisplayMember = "Resultado"
                    LstFechas.ValueMember = "id_Registro"
                    LstFechas.Refresh()
                End If

                'Limpio los Controles
                LimpiarCampos()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                'Seteo el tab que se visualiza
                Tcontrol.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al modificar el registro de empleados. Por favor, intente más tarde.", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class