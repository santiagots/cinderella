Public Class ClienteMayorista

    Public Property Id As Integer
    Public Property RazonSocial As String
    Public Property Nombre As String
    Public Property Cuit As String
    Public Property IdCondicionIva As Integer
    Public Property Comision As Integer?
    Public Property IdCorredor As Integer
    Public Property Transporte As String
    Public Property Bonificacion As Integer?
    Public Property Lista As Integer?
    Public Property CondicionPago As String
    Public Property IdEmpresa As Integer
    Public Property IdListaPrecio As Integer
    Public Property Observaciones As String
    Public Property IdDireccionFacturacion As Integer
    Public Property IdDireccionEntrega As Integer
    Public Property Habilitado As Boolean
    Public Property SaldoNotaPedido As Decimal
    Public Property SaldoCuentaCorriente As Decimal

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
