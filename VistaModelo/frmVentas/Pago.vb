Namespace VistaModelo.frmVentas

    Public Class Pago
        Inherits Common

        Private _FormaPagoId As Integer
        Public Property FormaPagoId As Integer
            Get
                Return _FormaPagoId
            End Get
            Set(ByVal value As Integer)
                If (value <> _FormaPagoId) Then
                    _FormaPagoId = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _FormaPago As String
        Public Property FormaPago As String
            Get
                Return _FormaPago
            End Get
            Set(ByVal value As String)
                If (value <> _FormaPago) Then
                    _FormaPago = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Monto As Double
        Public Property Monto As Double
            Get
                Return _Monto
            End Get
            Set(ByVal value As Double)
                If (value <> _Monto) Then
                    _Monto = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _DescuentoRecargo As Double
        Public Property DescuentoRecargo As Double
            Get
                Return _DescuentoRecargo
            End Get
            Set(ByVal value As Double)
                If (value <> _DescuentoRecargo) Then
                    _DescuentoRecargo = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Subtotal As Double
        Public Property Subtotal As Double
            Get
                Return _Subtotal
            End Get
            Set(ByVal value As Double)
                If (value <> _Subtotal) Then
                    _Subtotal = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property
    End Class

End Namespace
