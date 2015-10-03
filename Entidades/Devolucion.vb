Public Class Devolucion
    Private id_Devolucion_, id_Encargado_, id_Sucursal_, id_TipoPago_, id_Empleado_, id_TipoDevolucion_, id_Cliente_, CantidadTotal_, Habilitado_, NotaCredito_ As Integer
    Dim PrecioTotal_, Descuento_, Subtotal_ As Double
    Dim Fecha_ As Date
    Dim Detalle_ As List(Of Entidades.Devolucion_Detalle)

    Public Property id_Devolucion() As Integer
        Get
            Return id_Devolucion_
        End Get
        Set(ByVal value As Integer)
            id_Devolucion_ = value
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

    Public Property id_TipoDevolucion() As Integer
        Get
            Return id_TipoDevolucion_
        End Get
        Set(ByVal value As Integer)
            id_TipoDevolucion_ = value
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

        Public Property Habilitado() As Integer
            Get
                Return Habilitado_
            End Get
            Set(ByVal value As Integer)
                Habilitado_ = value
            End Set
        End Property

    Public Property NotaCredito() As Integer
        Get
            Return NotaCredito_
        End Get
        Set(ByVal value As Integer)
            NotaCredito_ = value
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

    Public Property Detalle() As List(Of Entidades.Devolucion_Detalle)
        Get
            Return Detalle_
        End Get
        Set(ByVal value As List(Of Entidades.Devolucion_Detalle))
            Detalle_ = value
        End Set
    End Property

End Class
