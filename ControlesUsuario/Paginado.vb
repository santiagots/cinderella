Public Class Paginado
    Public Property PaginaTamaño As Integer
    Public Property TotalPagina As Integer
    Public Property PaginaActual As Integer

    Public Event btnInicioClick As EventHandler
    Public Event btnAnteriorClick As EventHandler
    Public Event btnProximaClick As EventHandler
    Public Event btnFinClick As EventHandler

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click

        PaginaActual = 0
        ActualizarLeyanda()
        RaiseEvent btnInicioClick(Me, e)
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If (PaginaActual - 1 > 0) Then
            PaginaActual -= 1
            ActualizarLeyanda()
            RaiseEvent btnAnteriorClick(Me, e)
        End If
    End Sub

    Private Sub btnProxima_Click(sender As Object, e As EventArgs) Handles btnProxima.Click
        If (PaginaActual + 1 < TotalPagina) Then
            PaginaActual += 1
            ActualizarLeyanda()
            RaiseEvent btnProximaClick(Me, e)
        End If
    End Sub

    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        PaginaActual = TotalPagina
        ActualizarLeyanda()
        RaiseEvent btnFinClick(Me, e)
    End Sub

    Private Sub ActualizarLeyanda()
        lblPaginas.Text = String.Format("Página {0} de {1}", PaginaActual, TotalPagina)
    End Sub

End Class
