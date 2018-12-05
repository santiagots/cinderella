Public Class ClienteMayorista

    Public Id As Integer
    Public RazonSocial As String
    Public Nombre As String
    Public Cuit As String
    Public IdCondicionIva As Integer
    Public Comision As Integer?
    Public IdCorredor As Integer
    Public Transporte As String
    Public Bonificacion As Integer?
    Public Lista As Integer?
    Public CondicionPago As String
    Public IdEmpresa As Integer
    Public IdListaPrecio As Integer
    Public Observaciones As String
    Public IdDireccionFacturacion As Integer
    Public IdDireccionEntrega As Integer
    Public Habilitado As Boolean
    Public SaldoNotaPedido As Decimal
    Public SaldoCuentaCorriente As Decimal

    Sub New()
        Id = 0
        RazonSocial = String.Empty
        Nombre = String.Empty
        Cuit = Nothing
        IdCondicionIva = 0
        Comision = Nothing
        IdCorredor = 0
        Transporte = String.Empty
        Bonificacion = Nothing
        Lista = Nothing
        CondicionPago = String.Empty
        IdEmpresa = 0
        IdListaPrecio = 0
        Observaciones = String.Empty
        IdDireccionFacturacion = 0
        IdDireccionEntrega = 0
        Habilitado = False
        SaldoNotaPedido = 0
        SaldoCuentaCorriente = 0
    End Sub

End Class
