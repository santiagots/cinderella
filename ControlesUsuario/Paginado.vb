Public Class Paginado
    Public Property PaginaTamaño As Integer = 1
    Private TotalElementos_ As Integer
    Public Property TotalElementos() As Integer
        Get
            Return TotalElementos_
        End Get
        Set(ByVal value As Integer)
            TotalElementos_ = value
            ActualizarLeyanda()
        End Set
    End Property
    Public Property OrdenColumna As String
    Public Property OrdenDireccion As SortOrder
    Public Property PaginaActual As Integer = 1
    Public ReadOnly Property TotalPaginas As Integer
        Get
            Return TotalElementos_ / PaginaTamaño
        End Get
    End Property

    Public Event btnInicioClick As EventHandler
    Public Event btnAnteriorClick As EventHandler
    Public Event btnProximaClick As EventHandler
    Public Event btnFinClick As EventHandler

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        PaginaActual = 1
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
        If (PaginaActual + 1 <= TotalPaginas) Then
            PaginaActual += 1
            ActualizarLeyanda()
            RaiseEvent btnProximaClick(Me, e)
        End If
    End Sub

    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        PaginaActual = TotalPaginas
        ActualizarLeyanda()
        RaiseEvent btnFinClick(Me, e)
    End Sub

    Private Sub ActualizarLeyanda()
        lblPaginas.Text = String.Format("Página {0} de {1}", PaginaActual, TotalPaginas)
    End Sub

End Class
