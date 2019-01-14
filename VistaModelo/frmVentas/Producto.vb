Imports Entidades

Namespace VistaModelo.frmVentas

    Public Class Producto
        Inherits Common

        Public Sub New()
            Me.Pagos = New List(Of ProductoPago)()
        End Sub

        Public Sub New(Cantidad As Integer, ProductoEntidad As Entidades.Productos, TipoCliente As Entidades.TipoCliente, ListaPrecio As Integer, PorcentajeFacturacion As Double, PorcentajeBonificacionMayorista As Double, Optional Devolucion As Boolean = False)
            Dim Precio As Double = 0
            Dim PorcentajeBonificacion As Double = 0
            Select Case ListaPrecio
                Case "1"
                    Precio = ProductoEntidad.Precio1
                    PorcentajeBonificacion = ProductoEntidad.Precio2
                Case "3"
                    Precio = ProductoEntidad.Precio3
                    PorcentajeBonificacion = ProductoEntidad.Precio4
                Case "5"
                    Precio = ProductoEntidad.Precio5
                Case "6"
                    Precio = ProductoEntidad.Precio6
                Case Else
                    Precio = 0
            End Select

            Dim Monto As Double = 0
            Dim IVA As Double = 0

            'Los precios que componen la lista de precios minorista incluyen el IVA
            'Los precios que componen la lista de precios mayoristas NO incluyen el IVA
            If TipoCliente = Entidades.TipoCliente.Minorista Then
                Me.Codigo = ProductoEntidad.Codigo
                Me.Id = ProductoEntidad.id_Producto
                Me.Monto = Precio
                Me.PorcentajeBonificacion = PorcentajeBonificacion
                Me.Subtotal = Precio * Cantidad
                Me.Nombre = ProductoEntidad.Nombre
                Me.Cantidad = Cantidad

            Else
                IVA = Precio * 0.21 * PorcentajeFacturacion
                Monto = Precio + IVA

                Me.Codigo = ProductoEntidad.Codigo
                Me.Id = ProductoEntidad.id_Producto
                Me.PorcentajeBonificacion = PorcentajeBonificacionMayorista
                Me.Precio = Precio
                Me.PorcentajeBonificacion = PorcentajeBonificacion
                Me.IVA = IVA
                Me.Monto = Monto
                Me.Subtotal = Monto * Cantidad
                Me.Nombre = ProductoEntidad.Nombre
                Me.Cantidad = Cantidad
            End If

            Me.Precio1 = ProductoEntidad.Precio1
            Me.Precio2 = ProductoEntidad.Precio2
            Me.Precio3 = ProductoEntidad.Precio3
            Me.Precio4 = ProductoEntidad.Precio4
            Me.Precio5 = ProductoEntidad.Precio5
            Me.Precio6 = ProductoEntidad.Precio6
            Me.Devolucion = Devolucion

            If (Devolucion) Then
                Me.Precio *= -1
                Me.Monto *= -1
                Me.Subtotal *= -1
                Me.IVA *= -1
                Me.Precio1 *= -1
                Me.Precio3 *= -1
                Me.Precio5 *= -1
                Me.Precio6 *= -1
            End If

            Me.Pagos = New List(Of ProductoPago)()
        End Sub

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

        Private _PorcentajeBonificacion As Double
        Public Property PorcentajeBonificacion As Double
            Get
                Return _PorcentajeBonificacion
            End Get
            Set(ByVal value As Double)
                _PorcentajeBonificacion = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _PorcentajePago As Double
        Public Property PorcentajePago As Double
            Get
                Return _PorcentajePago
            End Get
            Set(ByVal value As Double)
                _PorcentajePago = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Pagos As List(Of ProductoPago)
        Public Property Pagos As List(Of ProductoPago)
            Get
                Return _Pagos
            End Get
            Set(ByVal value As List(Of ProductoPago))
                _Pagos = value
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

        Private _Devolucion As Boolean
        Public Property Devolucion As Boolean
            Get
                Return _Devolucion
            End Get
            Set(ByVal value As Boolean)
                _Devolucion = value
                NotifyPropertyChanged()
            End Set
        End Property

        Public Sub ActualizarPrecio(TipoCliente As Entidades.TipoCliente, ListaPrecio As Integer, PorcentajeFacturacion As Double)
            Dim precio As Double = 0
            Dim porcentajeBonificacion As Double = 0
            'Actualizo el precio de cada item segun la nueva lista de precios seleccioanda
            Select Case ListaPrecio
                Case "1"
                    precio = Me.Precio1
                    porcentajeBonificacion = Me.Precio2
                Case "3"
                    precio = Me.Precio3
                    porcentajeBonificacion = Me.Precio4
                Case "5"
                    precio = Me.Precio5
                Case "6"
                    precio = Me.Precio6
            End Select
            Me.PorcentajeBonificacion = porcentajeBonificacion

            If (TipoCliente = Entidades.TipoCliente.Minorista) Then
                Me.Monto = precio
            Else
                Me.Precio = precio
            End If

            ActualizarSubtotal(TipoCliente, PorcentajeFacturacion)
        End Sub

        Public Sub ActualizarSubtotal(TipoCliente As Entidades.TipoCliente, PorcentajeFacturacion As Double)
            If (TipoCliente = Entidades.TipoCliente.Minorista) Then
                Me.Monto = Precio
                Me.Precio = 0
                Me.IVA = 0
                Me.Subtotal = Me.Monto * Me.Cantidad
            Else
                Me.Precio = Precio
                Me.IVA = Precio * (0.21 * PorcentajeFacturacion)
                Me.Monto = (Me.Precio + Me.IVA)
                Me.Subtotal = Me.Monto * Me.Cantidad

            End If
        End Sub


        Public Function AgregarPago(FormaPago As FormaPago, tipoCliente As TipoCliente, TarjetaId As Integer, CuotaId As Integer, Monto As Double) As Double

            Dim subTotalFaltantePago As Double = Me.ObtenerFaltentePago(tipoCliente)

            If subTotalFaltantePago <= Monto Then
                Pagos.Add(New ProductoPago() With {
                    .FormaPago = FormaPago,
                    .TarjetaId = TarjetaId,
                    .CuotaId = CuotaId,
                    .Monto = subTotalFaltantePago,
                    .PorcentajePago = Math.Round(1 - Pagos.Sum(Function(x) x.PorcentajePago), 4)})
                Me.PorcentajePago = 1
                Return Monto - subTotalFaltantePago
            Else
                Dim porcentajePago As Double = 0
                If (tipoCliente = TipoCliente.Minorista) Then
                    porcentajePago = Math.Round(Monto / Me.Subtotal, 4)
                Else
                    porcentajePago = Math.Round(Monto / (Me.Precio * Me.Cantidad), 4)
                End If

                Pagos.Add(New ProductoPago() With {
                    .FormaPago = FormaPago,
                    .TarjetaId = TarjetaId,
                    .CuotaId = CuotaId,
                    .Monto = Monto,
                    .PorcentajePago = porcentajePago})
                Me.PorcentajePago = Pagos.Sum(Function(x) x.PorcentajePago)
                    Return 0
                End If
        End Function

        Public Sub QuitarPago(pago As Pago)
            Dim pagoPrducto As ProductoPago = Me.Pagos.FirstOrDefault(Function(x) x.FormaPago = pago.FormaPago AndAlso x.TarjetaId = pago.TarjetaId AndAlso x.CuotaId = pago.CuotaId)
            If pagoPrducto IsNot Nothing Then
                Pagos.Remove(pagoPrducto)
                Me.PorcentajePago = Math.Round(Pagos.Sum(Function(x) x.PorcentajePago), 4)
            End If
        End Sub

        Public Function Pago() As Boolean
            Return Pagos.Sum(Function(x) x.PorcentajePago) = 1
        End Function

        Public Function ObtenerFaltentePago(tipoCliente As TipoCliente) As Double
            If (tipoCliente = TipoCliente.Minorista) Then
                Return Me.Subtotal * (1 - Me.PorcentajePago)
            Else
                Return Me.Precio * Me.Cantidad * (1 - Me.PorcentajePago)
            End If
        End Function

    End Class
End Namespace