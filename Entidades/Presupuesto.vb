Public Class Presupuesto
    Private id_venta_, id_Presupuesto_, id_Encargado_, id_Sucursal_, id_TipoPago_, id_Empleado_, id_TipoVenta_, id_ClienteMayorista_, id_ClienteMinorista_, id_Tarjeta_, CantidadTotal_, Habilitado_, Facturado_, CantidadCuotas_ As Integer
    Dim total_, Descuento_, Subtotal_, CostoFinanciero_ As Double
    Dim Fecha_, FechaAnulado_ As Date
    Dim DescripcionAnulado_, NombreSucursal_, descripcionTipoPago_ As String
    Dim Anulado_ As Boolean

    Public Property id_Presupuesto() As Integer
        Get
            Return id_Presupuesto_
        End Get
        Set(ByVal value As Integer)
            id_Presupuesto_ = value
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

    Public Property NombreSucursal() As String
        Get
            Return NombreSucursal_
        End Get
        Set(ByVal value As String)
            NombreSucursal_ = value
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
    Public Property id_Tarjeta() As Integer
        Get
            Return id_Tarjeta_
        End Get
        Set(ByVal value As Integer)
            id_Tarjeta_ = value
        End Set
    End Property

    Public Property CantidadCuotas() As Integer
        Get
            Return CantidadCuotas_
        End Get
        Set(ByVal value As Integer)
            CantidadCuotas_ = value
        End Set
    End Property

    Public Property DescripcionTipoPago() As String
        Get
            Return descripcionTipoPago_
        End Get
        Set(ByVal value As String)
            descripcionTipoPago_ = value
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

    Private vendedorNombreyApellido_ As String
    Public Property VendedorNombreyApellido() As String
        Get
            Return vendedorNombreyApellido_
        End Get
        Set(ByVal value As String)
            vendedorNombreyApellido_ = value
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

    Public Property id_Venta() As Integer
        Get
            Return id_venta_
        End Get
        Set(ByVal value As Integer)
            id_venta_ = value
        End Set
    End Property

    Private encargadoNombreyApellido_ As String
    Public Property EncargadoNombreyApellido() As String
        Get
            Return encargadoNombreyApellido_
        End Get
        Set(ByVal value As String)
            encargadoNombreyApellido_ = value
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

    Private id_ListaPrecio_ As Integer
    Public Property id_ListaPrecio() As Integer
        Get
            Return id_ListaPrecio_
        End Get
        Set(ByVal value As Integer)
            id_ListaPrecio_ = value
        End Set
    End Property

    Public Property id_ClienteMayorista() As Integer
        Get
            Return id_ClienteMayorista_
        End Get
        Set(ByVal value As Integer)
            id_ClienteMayorista_ = value
        End Set
    End Property

    Private razonSocuialClienteMayorista_ As String

    Public Property RazonSocialClienteMayorista() As String
        Get
            Return razonSocuialClienteMayorista_
        End Get
        Set(ByVal value As String)
            razonSocuialClienteMayorista_ = value
        End Set
    End Property

    Public Property id_ClienteMinorista() As Integer
        Get
            Return id_ClienteMinorista_
        End Get
        Set(ByVal value As Integer)
            id_ClienteMinorista_ = value
        End Set
    End Property

    Public Property Anulado() As Boolean
        Get
            Return Anulado_
        End Get
        Set(ByVal value As Boolean)
            Anulado_ = value
        End Set
    End Property

    Public Property DescripcionAnulado() As String
        Get
            Return DescripcionAnulado_
        End Get
        Set(ByVal value As String)
            DescripcionAnulado_ = value
        End Set
    End Property

    Public Property Total() As Double
        Get
            Return total_
        End Get
        Set(ByVal value As Double)
            total_ = value
        End Set
    End Property

    Public Property Descuento() As Double
        Get
            Return Descuento_
        End Get
        Set(ByVal value As Double)
            Descuento_ = value
        End Set
    End Property

    Public Property CostoFinanciero() As Double
        Get
            Return CostoFinanciero_
        End Get
        Set(ByVal value As Double)
            CostoFinanciero_ = value
        End Set
    End Property

    Public Property SubTotal() As Double
        Get
            Return Subtotal_
        End Get
        Set(ByVal value As Double)
            Subtotal_ = value
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

    Public Property FechaAnulado() As Date
        Get
            Return FechaAnulado_
        End Get
        Set(ByVal value As Date)
            FechaAnulado_ = value
        End Set
    End Property




End Class
