Public Class Paginado

    Private _TotalElementos As Integer = 0
    Public Event PaginaInicalClick As EventHandler
    Public Event PaginaAnteriorClick As EventHandler
    Public Event PaginaSiguienteClick As EventHandler
    Public Event PaginaFinalClick As EventHandler

    Public ReadOnly Property ElementosPorPagina As Integer
        Get
            Return My.Settings.PaginacionItemsPagina
        End Get
    End Property

    Public Property PaginaActual As Integer = 1

    Public Property TotalElementos As Integer
        Get
            Return _TotalElementos
        End Get
        Set(ByVal value As Integer)
            _TotalElementos = value
            ActualizarBotones()
            ActualizarLeyenda()
        End Set
    End Property

    Public ReadOnly Property TotalPaginas As Integer
        Get
            Return If(TotalElementos Mod ElementosPorPagina > 0, (TotalElementos \ ElementosPorPagina) + 1, TotalElementos \ ElementosPorPagina)
        End Get
    End Property

    Public Property Leyenda As String = "{0} de {1}"

    Private Sub Paginado_Load(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarLeyenda()
    End Sub

    Private Sub btnPaginaInical_Click(sender As Object, e As EventArgs) Handles btnPaginaInical.Click
        PaginaActual = 1
        RaiseEvent PaginaInicalClick(sender, e)
        ActualizarBotones()
        ActualizarLeyenda()
    End Sub

    Private Sub btnPaginaAnterior_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPaginaAnterior.Click
        PaginaActual -= 1
        RaiseEvent PaginaAnteriorClick(sender, e)
        ActualizarBotones()
        ActualizarLeyenda()
    End Sub

    Private Sub btnPaginaSiguiente_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPaginaSiguiente.Click
        PaginaActual += 1
        RaiseEvent PaginaSiguienteClick(sender, e)
        ActualizarBotones()
        ActualizarLeyenda()
    End Sub

    Private Sub btnPaginaFinal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPaginaFinal.Click
        PaginaActual = TotalPaginas
        RaiseEvent PaginaFinalClick(sender, e)
        ActualizarBotones()
        ActualizarLeyenda()
    End Sub

    Private Sub ActualizarBotones()
        btnPaginaInical.Enabled = PaginaActual <> 1 AndAlso TotalPaginas > 1
        btnPaginaAnterior.Enabled = PaginaActual > 1 AndAlso TotalPaginas > 1
        btnPaginaSiguiente.Enabled = PaginaActual < TotalPaginas AndAlso TotalPaginas > 1
        btnPaginaFinal.Enabled = PaginaActual <> TotalPaginas AndAlso TotalPaginas > 1
    End Sub

    Private Sub ActualizarLeyenda()
        Me.lbTotalPaginas.Text = String.Format(Leyenda, PaginaActual, TotalPaginas)
    End Sub
End Class
