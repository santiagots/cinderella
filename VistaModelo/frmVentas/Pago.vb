Imports Entidades

Namespace VistaModelo.frmVentas

    Public Class Pago
        Inherits Common

        Private _FormaPagoDescripcion As String
        Public Property FormaPagoDescripcion As String
            Get
                Return _FormaPagoDescripcion
            End Get
            Set(ByVal value As String)
                If (value <> _FormaPagoDescripcion) Then
                    _FormaPagoDescripcion = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _FormaPago As FormaPago
        Public Property FormaPago As FormaPago
            Get
                Return _FormaPago
            End Get
            Set(ByVal value As FormaPago)
                If (value <> _FormaPago) Then
                    _FormaPago = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _SubTotal As Double
        Public Property SubTotal As Double
            Get
                Return _SubTotal
            End Get
            Set(ByVal value As Double)
                If (value <> _SubTotal) Then
                    _SubTotal = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Descuento As Double
        Public Property Descuento As Double
            Get
                Return _Descuento
            End Get
            Set(ByVal value As Double)
                If (value <> _Descuento) Then
                    _Descuento = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _CostoFinanciero As Double
        Public Property CostoFinanciero As Double
            Get
                Return _CostoFinanciero
            End Get
            Set(ByVal value As Double)
                If (value <> _CostoFinanciero) Then
                    _CostoFinanciero = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _IVA As Double
        Public Property IVA As Double
            Get
                Return _IVA
            End Get
            Set(ByVal value As Double)
                If (value <> _IVA) Then
                    _IVA = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Total As Double
        Public Property Total As Double
            Get
                Return _Total
            End Get
            Set(ByVal value As Double)
                If (value <> _Total) Then
                    _Total = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private Property _TarjetaId As Integer
        Public Property TarjetaId As Integer
            Get
                Return _TarjetaId
            End Get
            Set(ByVal value As Integer)
                If (value <> _Total) Then
                    _TarjetaId = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private Property _CuotaId As Integer
        Public Property CuotaId As Integer
            Get
                Return _CuotaId
            End Get
            Set(ByVal value As Integer)
                If (value <> _CuotaId) Then
                    _CuotaId = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property
    End Class

End Namespace
