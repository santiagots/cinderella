Namespace VistaModelo.frmVentas

    Public Class Producto
        Inherits Common

        Private _Id As Integer
        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(ByVal value As Integer)
                _Id = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Codigo As String
        Public Property Codigo As String
            Get
                Return _Codigo
            End Get
            Set(ByVal value As String)
                _Codigo = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Nombre As String
        Public Property Nombre As String
            Get
                Return _Nombre
            End Get
            Set(ByVal value As String)
                _Nombre = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Cantidad As Integer
        Public Property Cantidad As Integer
            Get
                Return _Cantidad
            End Get
            Set(ByVal value As Integer)
                _Cantidad = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Precio As Double
        Public Property Precio As Double
            Get
                Return _Precio
            End Get
            Set(ByVal value As Double)
                _Precio = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _IVA As Double
        Public Property IVA As Double
            Get
                Return _IVA
            End Get
            Set(ByVal value As Double)
                _IVA = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Monto As Double
        Public Property Monto As Double
            Get
                Return _Monto
            End Get
            Set(ByVal value As Double)
                _Monto = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Subtotal As Double
        Public Property Subtotal As Double
            Get
                Return _Subtotal
            End Get
            Set(ByVal value As Double)
                _Subtotal = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Precio1 As Double
        Public Property Precio1 As Double
            Get
                Return _Precio1
            End Get
            Set(ByVal value As Double)
                _Precio1 = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Precio2 As Double
        Public Property Precio2 As Double
            Get
                Return _Precio2
            End Get
            Set(ByVal value As Double)
                _Precio2 = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Precio3 As Double
        Public Property Precio3 As Double
            Get
                Return _Precio3
            End Get
            Set(ByVal value As Double)
                _Precio3 = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Precio4 As Double
        Public Property Precio4 As Double
            Get
                Return _Precio4
            End Get
            Set(ByVal value As Double)
                _Precio4 = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Precio5 As Double
        Public Property Precio5 As Double
            Get
                Return _Precio5
            End Get
            Set(ByVal value As Double)
                _Precio5 = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Precio6 As Double
        Public Property Precio6 As Double
            Get
                Return _Precio6
            End Get
            Set(ByVal value As Double)
                _Precio6 = value
                NotifyPropertyChanged()
            End Set
        End Property
    End Class
End Namespace