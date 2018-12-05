Imports System.ComponentModel
Imports Entidades

Namespace VistaModelo.frmVentas
    Public Class Venta
        Inherits Common

        Public Sub New()
            TipoCliente = New BindingList(Of KeyValuePair(Of TipoCliente, String))
            For Each i As Integer In [Enum].GetValues(GetType(TipoCliente))
                Dim tipoPago As Entidades.TipoCliente = i
                TipoCliente.Add(New KeyValuePair(Of TipoCliente, String)(tipoPago, tipoPago.ToString()))
            Next

            EncargadoSeleccionado = 0
            VendedorSeleccionado = 0
            ListaBancoSeleccionado = 0
            ListaCuotaSeleccionado = 0
            ListaPrecioSeleccionado = 0
            FormaPagoSeleccionado = 1
            TipoClienteSeleccionado = Entidades.TipoCliente.Minorista
            Pagos = New BindingList(Of Pago)()
            Productos = New BindingList(Of VistaModelo.frmVentas.Producto)()
            ProcentajeFacturacionClienteMayorista = 100
        End Sub

        Private _TipoCliente As BindingList(Of KeyValuePair(Of TipoCliente, String))
        Public Property TipoCliente As BindingList(Of KeyValuePair(Of TipoCliente, String))
            Get
                Return _TipoCliente
            End Get
            Set(ByVal value As BindingList(Of KeyValuePair(Of TipoCliente, String)))
                _TipoCliente = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _TipoClienteSeleccionado As TipoCliente
        Public Property TipoClienteSeleccionado As TipoCliente
            Get
                Return _TipoClienteSeleccionado
            End Get
            Set(ByVal value As TipoCliente)
                If (value <> _TipoClienteSeleccionado) Then
                    _TipoClienteSeleccionado = value
                End If
            End Set
        End Property

        Private _Encargado As BindingList(Of KeyValuePair(Of Integer, String))
        Public Property Encargado As BindingList(Of KeyValuePair(Of Integer, String))
            Get
                Return _Encargado
            End Get
            Set(ByVal value As BindingList(Of KeyValuePair(Of Integer, String)))
                _Encargado = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _EncargadoSeleccionado As Integer
        Public Property EncargadoSeleccionado As Integer
            Get
                Return _EncargadoSeleccionado
            End Get
            Set(ByVal value As Integer)
                If (value <> _TipoClienteSeleccionado) Then
                    _EncargadoSeleccionado = value
                End If
            End Set
        End Property

        Private _Vendedor As BindingList(Of KeyValuePair(Of Integer, String))
        Public Property Vendedor As BindingList(Of KeyValuePair(Of Integer, String))
            Get
                Return _Vendedor
            End Get
            Set(ByVal value As BindingList(Of KeyValuePair(Of Integer, String)))
                _Vendedor = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private Property _VendedorSeleccionado As Integer
        Public Property VendedorSeleccionado As Integer
            Get
                Return _VendedorSeleccionado
            End Get
            Set(ByVal value As Integer)
                If (value <> _VendedorSeleccionado) Then
                    _VendedorSeleccionado = value
                End If
            End Set
        End Property

        Private _FormasPagos As BindingList(Of KeyValuePair(Of Integer, String))
        Public Property FormasPagos As BindingList(Of KeyValuePair(Of Integer, String))
            Get
                Return _FormasPagos
            End Get
            Set(ByVal value As BindingList(Of KeyValuePair(Of Integer, String)))
                _FormasPagos = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _FormaPagoSeleccionado As Integer
        Public Property FormaPagoSeleccionado As Integer
            Get
                Return _FormaPagoSeleccionado
            End Get
            Set(ByVal value As Integer)
                If (value <> _FormaPagoSeleccionado) Then
                    _FormaPagoSeleccionado = value
                End If
            End Set
        End Property

        Private _ListaPrecios As BindingList(Of KeyValuePair(Of Integer, String))
        Public Property ListaPrecios As BindingList(Of KeyValuePair(Of Integer, String))
            Get
                Return _ListaPrecios
            End Get
            Set(ByVal value As BindingList(Of KeyValuePair(Of Integer, String)))
                _ListaPrecios = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _ListaPrecioSeleccionado As Integer
        Public Property ListaPrecioSeleccionado As Integer
            Get
                Return _ListaPrecioSeleccionado
            End Get
            Set(ByVal value As Integer)
                If (value <> _ListaPrecioSeleccionado) Then
                    _ListaPrecioSeleccionado = value
                End If
            End Set
        End Property

        Private _ListaBancos As BindingList(Of Tarjeta)
        Public Property ListaBancos As BindingList(Of Tarjeta)
            Get
                Return _ListaBancos
            End Get
            Set(ByVal value As BindingList(Of Tarjeta))
                _ListaBancos = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _ListaBancoSeleccionado As Integer
        Public Property ListaBancoSeleccionado As Integer
            Get
                Return _ListaBancoSeleccionado
            End Get
            Set(ByVal value As Integer)
                If (value <> _ListaBancoSeleccionado) Then
                    _ListaBancoSeleccionado = value
                End If
            End Set
        End Property

        Private _ListaCuotas As BindingList(Of CostoFinanciero)
        Public Property ListaCuotas As BindingList(Of CostoFinanciero)
            Get
                Return _ListaCuotas
            End Get
            Set(ByVal value As BindingList(Of CostoFinanciero))
                _ListaCuotas = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _ListaCuotaSeleccionado As Integer
        Public Property ListaCuotaSeleccionado As Integer
            Get
                Return _ListaCuotaSeleccionado
            End Get
            Set(ByVal value As Integer)
                If (value <> _ListaCuotaSeleccionado) Then
                    _ListaCuotaSeleccionado = value
                End If
            End Set
        End Property

        Private _IdClienteMayorista As Integer
        Public Property IdClienteMayorista As Integer
            Get
                Return _IdClienteMayorista
            End Get
            Set(ByVal value As Integer)
                If (value <> _IdClienteMayorista) Then
                    _IdClienteMayorista = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _NombreClienteMayorista As String
        Public Property NombreClienteMayorista As String
            Get
                Return _NombreClienteMayorista
            End Get
            Set(ByVal value As String)
                If (value <> _NombreClienteMayorista) Then
                    _NombreClienteMayorista = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _ProcentajeFacturacionClienteMayorista As Double
        Public Property ProcentajeFacturacionClienteMayorista As Double
            Get
                Return _ProcentajeFacturacionClienteMayorista
            End Get
            Set(ByVal value As Double)
                If (value <> _ProcentajeFacturacionClienteMayorista) Then
                    _ProcentajeFacturacionClienteMayorista = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _ProcentajeBonificacion As Double
        Public Property ProcentajeBonificacion As Double
            Get
                Return _ProcentajeBonificacion
            End Get
            Set(ByVal value As Double)
                If (value <> _ProcentajeBonificacion) Then
                    _ProcentajeBonificacion = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _ProductoIngresado As String
        Public Property ProductoIngresado As String
            Get
                Return _ProductoIngresado
            End Get
            Set(ByVal value As String)
                If (value <> _ProductoIngresado) Then
                    _ProductoIngresado = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Productos As BindingList(Of Producto)
        Public Property Productos As BindingList(Of Producto)
            Get
                Return _Productos
            End Get
            Set(ByVal value As BindingList(Of Producto))
                _Productos = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Pagos As BindingList(Of Pago)
        Public Property Pagos As BindingList(Of Pago)
            Get
                Return _Pagos
            End Get
            Set(ByVal value As BindingList(Of Pago))
                _Pagos = value
                NotifyPropertyChanged()
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

        Property _Senia As Double
        Public Property Senia As Double
            Get
                Return _Senia
            End Get
            Set(ByVal value As Double)
                If (value <> _Senia) Then
                    _Senia = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property


        Private _ImporteAbonar As Double
        Public Property ImporteAbonar As Double
            Get
                Return _ImporteAbonar
            End Get
            Set(ByVal value As Double)
                If (value <> _ImporteAbonar) Then
                    _ImporteAbonar = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _MontoPago As Double
        Public Property MontoPago As Double
            Get
                Return _MontoPago
            End Get
            Set(ByVal value As Double)
                If (value <> _MontoPago) Then
                    _MontoPago = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _TotalPago As Double
        Public Property TotalPago As Double
            Get
                Return _TotalPago
            End Get
            Set(ByVal value As Double)
                If (value <> _TotalPago) Then
                    _TotalPago = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property
    End Class
End Namespace