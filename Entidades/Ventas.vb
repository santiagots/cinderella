Public Class Ventas
    Private id_Venta_, id_Encargado_, id_Sucursal_, id_TipoPago_, id_Empleado_, id_TipoVenta_, id_Cliente_, CantidadTotal_, Anulado_, Habilitado_, Facturado_ As Integer
    Dim PrecioTotal_, Descuento_, Subtotal_ As Double
    Dim Fecha_ As Date

    Public Property id_Venta() As Integer
        Get
            Return id_Venta_
        End Get
        Set(ByVal value As Integer)
            id_Venta_ = value
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

    Public Property id_Empleado() As Integer
        Get
            Return id_Empleado_
        End Get
        Set(ByVal value As Integer)
            id_Empleado_ = value
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

    Public Property id_Cliente() As Integer
        Get
            Return id_Cliente_
        End Get
        Set(ByVal value As Integer)
            id_Cliente_ = value
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

    Public Property Anulado() As Integer
        Get
            Return Anulado_
        End Get
        Set(ByVal value As Integer)
            Anulado_ = value
        End Set
    End Property

    Public Property Habilitado() As Integer
        Get
            Return Habilitado_
        End Get
        Set(ByVal value As Integer)
            Habilitado_ = value
        End Set
    End Property

    Public Property Facturado() As Integer
        Get
            Return Facturado_
        End Get
        Set(ByVal value As Integer)
            Facturado_ = value
        End Set
    End Property

    Public Property CantidadTotal() As Integer
        Get
            Return CantidadTotal_
        End Get
        Set(ByVal value As Integer)
            CantidadTotal_ = value
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

    Public Property Descuento() As Double
        Get
            Return Descuento_
        End Get
        Set(ByVal value As Double)
            Descuento_ = value
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

    Private DiferenciaPagoCheque_ As Double
    Public Property DiferenciaPagoCheque() As Double
        Get
            Return DiferenciaPagoCheque_
        End Get
        Set(ByVal value As Double)
            DiferenciaPagoCheque_ = value
        End Set
    End Property

    Private MontoSenia_ As Double
    Public Property MontoSenia() As Double
        Get
            Return MontoSenia_
        End Get
        Set(ByVal value As Double)
            MontoSenia_ = value
        End Set
    End Property

    Private Senia_ As Boolean
    Public Property Senia() As Boolean
        Get
            Return Senia_
        End Get
        Set(ByVal value As Boolean)
            Senia_ = value
        End Set
    End Property

End Class
