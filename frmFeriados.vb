Public Class frmFeriados
    Dim NegFeriados As New Negocio.NegFeriados
    Dim dsFechas As DataSet
    'Inicio de formulario.
    Private Sub frmFeriados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor.
        Me.Cursor = Cursors.WaitCursor

        'Seteo la fecha minima para mostrar en el calendario.
        Calendario.MaxDate = New System.DateTime(Date.Now.Year, 12, 31, 0, 0, 0, 0)

        'Seteo la fecha maxima para mostrar en el calendario.
        Calendario.MinDate = New System.DateTime(Date.Now.Year, 1, 1, 0, 0, 0, 0)

        'Numero maximo de seleccion: 1
        Calendario.MaxSelectionCount = 1

        'Si hay fechas almacenadas, las muestro
        dsFechas = NegFeriados.ListadoFeriados
        If dsFechas.Tables(0).Rows.Count > 0 Then
            lbl_Cant.Text = dsFechas.Tables(0).Rows.Count 'Actualizo el numero de fechas seleccionadas.
            For Each f In dsFechas.Tables(0).Rows
                Calendario.AddBoldedDate(String.Format("{0:dd/MM/yyyy}", f.item("FechaCorta")))
                Calendario.UpdateBoldedDates()
            Next
            'Muestro Msg.
            MessageBox.Show("Se cargaron los feriados almacenados en el sistema.", "Administración de Feriados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Cambio el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Al seleccionar una fecha.
    Private Sub Calendario_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged
        If Calendario.BoldedDates.Contains(e.Start.ToShortDateString()) Then
            FechaSeleccionada.Text = "-" 'Seteo a cero el label de ultima fecha seleccionada.
            Calendario.RemoveBoldedDate(e.Start.ToShortDateString) 'Quito la fecha seleccionada.
            lbl_Cant.Text = Calendario.BoldedDates.Length 'Actualizo el numero de fechas seleccionadas.
            Calendario.UpdateBoldedDates() 'Actualizo el calendario.
        Else
            FechaSeleccionada.Text = e.Start.ToShortDateString() 'Seteo el label de ultima fecha seleccionada.
            Calendario.AddBoldedDate(e.Start.ToShortDateString()) 'Agrego la fecha seleccionada.
            lbl_Cant.Text = Calendario.BoldedDates.Length 'Actualizo el numero de fechas seleccionadas.
            Calendario.UpdateBoldedDates() 'Actualizo el calendario.
        End If
    End Sub

    Private Sub abc()
        Calendario.UpdateBoldedDates()
    End Sub


    'Cuando hace click en "Ver Lista".
    Private Sub link_Visualizar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_Visualizar.LinkClicked
        'Declaracion de variables
        Dim stringfechas As String = ""
        Dim num As Integer = 1

        'Si hay fechas seleccionadas.
        If Calendario.BoldedDates.Length > 0 Then
            'Recorro las fechas seleccionadas, armo el string y lo muestro.
            For Each d In Calendario.BoldedDates
                stringfechas += "Fecha " & num & ": " & d.ToLongDateString & vbCrLf
                num += 1
            Next
            MessageBox.Show(stringfechas, "Administración de Feriados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se encontraron fechas seleccionadas.", "Administración de Feriados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Limpio el formulario integramente.
    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        Calendario.RemoveAllBoldedDates() 'Remuevo todas las fechas seleccionadas.
        Calendario.UpdateBoldedDates() 'Actualizo el formulario.
        FechaSeleccionada.Text = "-" 'Seteo a cero el label a cero.
        lbl_Cant.Text = "0" 'Actualizo el numero de fechas seleccionadas a cero.

    End Sub

    'Guardo las fechas en la base de datos.
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        'Si hay fechas seleccionadas.
        If Calendario.BoldedDates.Length > 0 Then
            Try
                If MessageBox.Show("¿Está seguro que desea guardar las fechas seleccionadas?. Las fechas guardadas con anterioridad serán eliminadas.", "Administración de Feriados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                    'Cambio el cursor.
                    Me.Cursor = Cursors.WaitCursor

                    'Borro todas las fechas guardadas.
                    NegFeriados.BorrarFeriados()

                    'Recorro las fechas seleccionadas y almaceno.
                    For Each d In Calendario.BoldedDates
                        NegFeriados.AgregarFeriado(d.ToString("yyyy/MM/dd"), d.ToLongDateString)
                    Next

                    'Cambio el cursor.
                    Me.Cursor = Cursors.Arrow

                    'Muestro Msg.
                    MessageBox.Show("Las fechas seleccionadas han sido almacenadas con éxito.", "Administración de Feriados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                'Cambio el cursor.
                Me.Cursor = Cursors.Arrow

                'Muestro Msg.
                MessageBox.Show("Se encontro un error al guardar las fechas seleccionadas.", "Administración de Feriados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            'Muestro Msg.
            MessageBox.Show("No se encontraron fechas seleccionadas para almacenar.", "Administración de Feriados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Calendario_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Calendario.DateSelected
        sender.UpdateBoldedDates() 'Actualizo el calendario.
    End Sub
End Class