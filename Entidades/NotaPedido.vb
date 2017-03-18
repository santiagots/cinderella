Public Class NotaPedido

    Private id_NotaPedido_, id_Sucursal_, id_TipoPago_, id_Empleado_, id_TipoVenta_, id_Cliente_, id_Encargado_ As Integer
    Dim PrecioTotal_ As Double
    Dim Fecha_ As Date

    Public Property id_NotaPedido() As Integer
        Get
            Return id_NotaPedido_
        End Get
        Set(ByVal value As Integer)
            id_NotaPedido_ = value
        End Set
    End Property

    Public Property id_Sucursal() As Integer
        Get
            Return id_Sucursal_
        End Get
        Set(ByVal value As Integer)
            id_Sucursal_ = value
        End Set
    End Property

    Public Property id_TipoPago() As Integer
        Get
            Return id_TipoPago_
        End Get
        Set(ByVal value As Integer)
            id_TipoPago_ = value
        End Set
    End Property

    Public Property id_Encargado() As Integer
        Get
            Return id_Encargado_
        End Get
        Set(ByVal value As Integer)
            id_Encargado_ = value
        End Set
    End Property

    Public Property id_Empleado() As Integer
        Get
            Return id_Empleado_
        End Get
        Set(ByVal value As Integer)
            id_Empleado_ = value
        End Set
    End Property

    Private empleadoNombreyApellido_ As String
    Public Property EmpleadoNombreyApellido() As String
        Get
            Return empleadoNombreyApellido_
        End Get
        Set(ByVal value As String)
            empleadoNombreyApellido_ = value
        End Set
    End Property


    Public Property id_TipoVenta() As Integer
        Get
            Return id_TipoVenta_
        End Get
        Set(ByVal value As Integer)
            id_TipoVenta_ = value
        End Set
    End Property

    Public Property id_Cliente() As Integer
        Get
            Return id_Cliente_
        End Get
        Set(ByVal value As Integer)
            id_Cliente_ = value
        End Set
    End Property

    Private razonSocialCliente_ As String
    Public Property RazonSocialCliente() As String
        Get
            Return razonSocialCliente_
        End Get
        Set(ByVal value As String)
            razonSocialCliente_ = value
        End Set
    End Property

    Private PorcentajeFacturacion_ As Double
    Public Property PorcentajeFacturacion() As Double
        Get
            Return PorcentajeFacturacion_
        End Get
        Set(ByVal value As Double)
            PorcentajeFacturacion_ = value
        End Set
    End Property

    Public Property PrecioTotal() As Double
        Get
            Return PrecioTotal_
        End Get
        Set(ByVal value As Double)
            PrecioTotal_ = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return Fecha_
        End Get
        Set(ByVal value As Date)
            Fecha_ = value
        End Set
    End Property

    Private id_ConsumidorFinal_ As Integer
    Public Property Id_ConsumidorFinal() As Integer
        Get
            Return id_ConsumidorFinal_
        End Get
        Set(ByVal value As Integer)
            id_ConsumidorFinal_ = value
        End Set
    End Property

    Private consumidorFinalNombreYApellido_ As String
    Public Property ConsumidorFinalNombreYApellido() As String
        Get
            Return consumidorFinalNombreYApellido_
        End Get
        Set(ByVal value As String)
            consumidorFinalNombreYApellido_ = value
        End Set
    End Property


    Private vendida_ As Boolean
    Public Property Vendida() As Boolean
        Get
            Return vendida_
        End Get
        Set(ByVal value As Boolean)
            vendida_ = value
        End Set
    End Property

    Private TipoVentaDescripcion_ As String
    Public Property TipoVentaDescripcion() As String
        Get
            Return TipoVentaDescripcion_
        End Get
        Set(ByVal value As String)
            TipoVentaDescripcion_ = value
        End Set
    End Property


    Private TipoPagoDescripcion_ As String
    Public Property TipoPagoDescripcion() As String
        Get
            Return TipoPagoDescripcion_
        End Get
        Set(ByVal value As String)
            TipoPagoDescripcion_ = value
        End Set
    End Property

    Private id_ListaPrecio_ As Integer
    Public Property id_ListaPrecio() As Integer
        Get
            Return id_ListaPrecio_
        End Get
        Set(ByVal value As Integer)
            id_ListaPrecio_ = value
        End Set
    End Property




End Class
