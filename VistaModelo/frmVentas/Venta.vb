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
            TipoClienteSeleccionado = Entidades.TipoCliente.Minorista
            EncargadoSeleccionado = 0
            VendedorSeleccionado = 0
            ListaBancoSeleccionado = 0
            ListaCuotaSeleccionado = 0
            ListaPrecioSeleccionado = 0
            FormaPagoSeleccionado = 1

            ListaBancos = New BindingList(Of Tarjeta)()
            ListaCuotas = New BindingList(Of CostoFinanciero)()
            Vendedores = New BindingList(Of KeyValuePair(Of Integer, String))()
            Encargados = New BindingList(Of KeyValuePair(Of Integer, String))()
            ListaPrecios = New BindingList(Of KeyValuePair(Of Integer, String))()
            Pagos = New BindingList(Of Pago)()
            TotalPagos = New BindingList(Of Pago)()
            Productos = New BindingList(Of VistaModelo.frmVentas.Producto)()
            TotalProductos = New BindingList(Of VistaModelo.frmVentas.Producto)()

            ProcentajeFacturacionClienteMayorista = 100
            Me.ActualizarTotalProducto(Me.TipoClienteSeleccionado)
            Me.ActualizarTotalPagos()
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
        Public Property Encargados As BindingList(Of KeyValuePair(Of Integer, String))
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
        Public Property Vendedores As BindingList(Of KeyValuePair(Of Integer, String))
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

        Private _FormasPagos As BindingList(Of KeyValuePair(Of FormaPago, String))
        Public Property FormasPagos As BindingList(Of KeyValuePair(Of FormaPago, String))
            Get
                Return _FormasPagos
            End Get
            Set(ByVal value As BindingList(Of KeyValuePair(Of FormaPago, String)))
                _FormasPagos = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _FormaPagoSeleccionado As FormaPago
        Public Property FormaPagoSeleccionado As FormaPago
            Get
                Return _FormaPagoSeleccionado
            End Get
            Set(ByVal value As FormaPago)
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

        Private _CFTCuota As Double
        Public Property CFTCuota As Double
            Get
                Return _CFTCuota
            End Get
            Set(ByVal value As Double)
                If (value <> _CFTCuota) Then
                    _CFTCuota = value
                    NotifyPropertyChanged()
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

        Private _ProcentajeBonificacionClienteMayorista As Double
        Public Property ProcentajeBonificacionClienteMayorista As Double
            Get
                Return _ProcentajeBonificacionClienteMayorista
            End Get
            Set(ByVal value As Double)
                If (value <> _ProcentajeBonificacionClienteMayorista) Then
                    _ProcentajeBonificacionClienteMayorista = value
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

        Private _TotalProductos As BindingList(Of Producto)
        Public Property TotalProductos As BindingList(Of Producto)
            Get
                Return _TotalProductos
            End Get
            Set(ByVal value As BindingList(Of Producto))
                _TotalProductos = value
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

        Private _TotalPagos As BindingList(Of Pago)
        Public Property TotalPagos As BindingList(Of Pago)
            Get
                Return _TotalPagos
            End Get
            Set(ByVal value As BindingList(Of Pago))
                _TotalPagos = value
                NotifyPropertyChanged()
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
                    'CalcularTotal(value)
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
                    'CalcularSubtotal(value)
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Public Function CuotaPorcentajeRecargo() As Double
            If (Me.FormaPagoSeleccionado = FormaPago.TarjetaCredito) Then
                Dim costoFinanciero As CostoFinanciero = Me.ListaCuotas.FirstOrDefault(Function(x) x.CostoFinancieroId = Me.ListaCuotaSeleccionado)
                If (costoFinanciero Is Nothing) Then
                    Return 0
                Else
                    Return costoFinanciero.PorcentajeRecargo
                End If
            Else
                Return 0
            End If
        End Function

        Public Function ObtenerSubTotalFaltantePago() As Double
            Dim subTotalFaltantePago As Double = 0
            For Each producto As Producto In Me.Productos.Where(Function(x) Not x.Pago)
                subTotalFaltantePago += producto.ObtenerFaltentePago(Me.TipoClienteSeleccionado)
            Next
            Return subTotalFaltantePago
        End Function

        Public Sub CalcularSubtotal(total As Double)
            If TipoClienteSeleccionado = Entidades.TipoCliente.Minorista Then
                Me.CalcularSubtotalMinorista(total)
            Else
                Me.CalcularSubtotalMayorista(total)
            End If
        End Sub

        Public Sub CalcularSubtotalMayorista(total As Double)

            Dim PorcentajeFacturacion As Double = Me.ProcentajeFacturacionClienteMayorista / 100
            Dim descuento As Double = 0
            Dim costoFinanciero As Double = 0
            Dim IVA As Double = 0

            Dim monto As Double = total / (1.21 * PorcentajeFacturacion)

            For Each producto As Producto In Me.Productos.Where(Function(x) Not x.Pago)
                Dim restantePago = producto.Precio * producto.Cantidad * (1 - producto.PorcentajePago)

                If (Me.FormaPagoSeleccionado = FormaPago.Efectivo) Then
                    restantePago = restantePago * (1 - producto.PorcentajeBonificacion)
                Else
                    restantePago = restantePago * (1 + CFTCuota)
                End If

                If (monto < restantePago) Then
                    restantePago = monto
                End If

                Dim subtotal As Double = 0

                If (Me.FormaPagoSeleccionado = FormaPago.Efectivo) Then
                    subtotal = restantePago / (1 - producto.PorcentajeBonificacion)
                    descuento += subtotal * producto.PorcentajeBonificacion
                Else
                    subtotal = restantePago / (1 + CFTCuota)
                    costoFinanciero += subtotal * CFTCuota
                End If

                IVA += (subtotal - descuento + costoFinanciero) * (0.21 * PorcentajeFacturacion)
                monto -= restantePago

                If (monto <= 0) Then
                    Exit For
                End If


            Next

            Me.Descuento = Math.Round(descuento, 2, MidpointRounding.ToEven)
            Me.CostoFinanciero = Math.Round(costoFinanciero, 2, MidpointRounding.ToEven)
            Me.IVA = Math.Round(IVA, 2, MidpointRounding.ToEven)
            Me.SubTotal = Math.Round(total - IVA - costoFinanciero + descuento, 2, MidpointRounding.ToEven)
        End Sub

        Public Sub CalcularSubtotalMinorista(total As Double)
            Dim descuento As Double = 0
            Dim costoFinanciero As Double = 0

            Dim monto As Double = total
            For Each producto As Producto In Me.Productos.Where(Function(x) Not x.Pago)
                Dim restantePago = producto.Subtotal * (1 - producto.PorcentajePago)

                If (Me.FormaPagoSeleccionado = FormaPago.Efectivo) Then
                    restantePago = restantePago * (1 - producto.PorcentajeBonificacion)
                Else
                    restantePago = restantePago * (1 + CFTCuota)
                End If

                If (monto < restantePago) Then
                    restantePago = monto
                End If

                Dim subtotal As Double = 0

                If (Me.FormaPagoSeleccionado = FormaPago.Efectivo) Then
                    subtotal = restantePago / (1 - producto.PorcentajeBonificacion)
                    descuento += subtotal * producto.PorcentajeBonificacion
                Else
                    subtotal = restantePago / (1 + CFTCuota)
                    costoFinanciero += subtotal * CFTCuota
                End If
                monto -= restantePago

                If (monto <= 0) Then
                    Exit For
                End If


            Next

            Me.Descuento = Math.Round(descuento, 2, MidpointRounding.ToEven)
            Me.CostoFinanciero = Math.Round(costoFinanciero, 2, MidpointRounding.ToEven)
            Me.SubTotal = Math.Round(total + descuento - costoFinanciero, 2, MidpointRounding.ToEven)
            Me.IVA = 0

        End Sub

        Public Sub CalcularTotal(subtotal As Double)
            If TipoClienteSeleccionado = Entidades.TipoCliente.Minorista Then
                Me.CalcularTotalMinorista(subtotal)
            Else
                Me.CalcularTotalMayorista(subtotal)
            End If
        End Sub

        Public Sub CalcularTotalMayorista(subtotal As Double)
            Dim PorcentajeFacturacion As Double = Me.ProcentajeFacturacionClienteMayorista / 100
            Dim descuento As Double = 0
            Dim costoFinanciero As Double = 0
            Dim monto As Double = subtotal

            For Each producto As Producto In Me.Productos.Where(Function(x) Not x.Pago)
                Dim restantePago = producto.Precio * producto.Cantidad * (1 - producto.PorcentajePago)

                If (monto < restantePago) Then
                    restantePago = monto
                End If

                If (Me.FormaPagoSeleccionado = FormaPago.Efectivo) Then
                    descuento += restantePago * producto.PorcentajeBonificacion
                Else
                    costoFinanciero += restantePago * CFTCuota
                End If
                monto -= restantePago

                If (monto <= 0) Then
                    Exit For
                End If
            Next

            If descuento > subtotal Then
                descuento = subtotal
            End If

            Me.Descuento = Math.Round(descuento, 2, MidpointRounding.ToEven)
            Me.CostoFinanciero = Math.Round(costoFinanciero, 2, MidpointRounding.ToEven)
            Me.IVA = Math.Round((Me.SubTotal - Me.Descuento + Me.CostoFinanciero) * (0.21 * PorcentajeFacturacion), 2, MidpointRounding.ToEven)
            Me.Total = Math.Round(Me.SubTotal - Me.Descuento + Me.CostoFinanciero + Me.IVA, 2, MidpointRounding.ToEven)
        End Sub

        Public Sub CalcularTotalMinorista(subtotal As Double)
            Dim descuento As Double = 0
            Dim costoFinanciero As Double = 0
            Dim monto As Double = subtotal

            For Each producto As Producto In Me.Productos.Where(Function(x) Not x.Pago)
                Dim restantePago = producto.Subtotal * (1 - producto.PorcentajePago)

                If (monto < restantePago) Then
                    restantePago = monto
                End If

                If (Me.FormaPagoSeleccionado = FormaPago.Efectivo) Then
                    descuento += restantePago * producto.PorcentajeBonificacion
                Else
                    costoFinanciero += restantePago * CFTCuota
                End If
                monto -= restantePago

                If (monto <= 0) Then
                    Exit For
                End If
            Next

            If CDbl(descuento) > subtotal Then
                descuento = subtotal
            End If

            Me.Descuento = Math.Round(descuento, 2, MidpointRounding.ToEven)
            Me.CostoFinanciero = Math.Round(costoFinanciero, 2, MidpointRounding.ToEven)
            Me.IVA = 0
            Me.Total = Math.Round(subtotal - Me.Descuento + Me.CostoFinanciero, 2, MidpointRounding.ToEven)
        End Sub

        Public Sub ActualizarProductos()
            Dim precio As Double = 0
            Dim PorcentajeFacturacion As Double = Me.ProcentajeFacturacionClienteMayorista / 100
            For Each producto As VistaModelo.frmVentas.Producto In Me.Productos.Where(Function(x) Not x.Pago)
                producto.Actualizar(Me.TipoClienteSeleccionado, Me.ListaPrecioSeleccionado, PorcentajeFacturacion)
            Next
        End Sub

        Public Sub ActualizarTotalProducto(tipoCliente As TipoCliente)
            Me.TotalProductos.Clear()

            If (tipoCliente = TipoCliente.Minorista) Then
                Me.TotalProductos.Add(New Producto() With {
                    .Cantidad = Me.Productos.Sum(Function(x) x.Cantidad),
                    .IVA = 0,
                    .Monto = Me.Productos.Sum(Function(x) x.Monto * x.Cantidad),
                    .Subtotal = Me.Productos.Sum(Function(x) x.Subtotal),
                    .Precio = 0,
                    .Nombre = "Total"})
            Else
                Me.TotalProductos.Add(New Producto() With {
                    .Cantidad = Me.Productos.Sum(Function(x) x.Cantidad),
                    .IVA = Me.Productos.Sum(Function(x) x.IVA * x.Cantidad),
                    .Monto = Me.Productos.Sum(Function(x) x.Monto * x.Cantidad),
                    .Subtotal = Me.Productos.Sum(Function(x) x.Subtotal),
                    .Precio = Me.Productos.Sum(Function(x) x.Precio * x.Cantidad),
                    .Nombre = "Total"})
            End If
        End Sub

        Public Sub ActualizarTotalPagos()
            Me.TotalPagos.Clear()
            Me.TotalPagos.Add(New Pago() With {
                    .FormaPago = FormaPago.Efectivo,
                    .CostoFinanciero = Me.Pagos.Sum(Function(x) x.CostoFinanciero),
                    .IVA = Me.Pagos.Sum(Function(x) x.IVA),
                    .Descuento = Me.Pagos.Sum(Function(x) x.Descuento),
                    .SubTotal = Me.Pagos.Sum(Function(x) x.SubTotal),
                    .Total = Me.Pagos.Sum(Function(x) x.Total),
                    .FormaPagoDescripcion = "Total"})
        End Sub

        Public Sub AgregarProducto(cantidad As Integer, productoEntidad As Entidades.Productos)
            Me.Productos.Add(New Producto(cantidad, productoEntidad, TipoClienteSeleccionado, ListaPrecioSeleccionado, Me.ProcentajeFacturacionClienteMayorista / 100, Me.ProcentajeBonificacionClienteMayorista / 100))
            Me.ActualizarTotalProducto(Me.TipoClienteSeleccionado)
        End Sub

        Public Sub QuitarProducto(producto As Producto)
            Me.Productos.Remove(producto)
            Me.ActualizarTotalProducto(Me.TipoClienteSeleccionado)
        End Sub

        Public Sub AgregarPago()
            Dim formaPagoSeleccionada As KeyValuePair(Of FormaPago, String) = Me.FormasPagos.First(Function(x) x.Key = Me.FormaPagoSeleccionado)
            Dim tarjetaSeleccionada As Tarjeta = Nothing
            Dim cuotaSeleccionada As CostoFinanciero = Nothing

            'Quito la froma de pago Efectivo si se realizo un pago de esta manera
            If (formaPagoSeleccionada.Value = "Efectivo") Then
                Me.FormasPagos.Remove(formaPagoSeleccionada)
            End If

            'Registro el pago en el listado de pagos
            Dim formaPagoDescripcion As String = String.Empty
            Select Case formaPagoSeleccionada.Key
                Case FormaPago.TarjetaCredito
                    tarjetaSeleccionada = Me.ListaBancos.First(Function(x) x.TarjetaId = Me.ListaBancoSeleccionado)
                    cuotaSeleccionada = Me.ListaCuotas.First(Function(x) x.CostoFinancieroId = Me.ListaCuotaSeleccionado)
                    formaPagoDescripcion = String.Format("{0} {1} {2} Cuotas", formaPagoSeleccionada.Value, tarjetaSeleccionada.Nombre, cuotaSeleccionada.NumeroCuotas)
                Case FormaPago.TarjetaDebito
                    tarjetaSeleccionada = Me.ListaBancos.First(Function(x) x.TarjetaId = Me.ListaBancoSeleccionado)
                    formaPagoDescripcion = String.Format("{0} {1}", formaPagoSeleccionada.Value, tarjetaSeleccionada.Nombre)
                Case Else
                    formaPagoDescripcion = formaPagoSeleccionada.Value
            End Select

            Dim pago As VistaModelo.frmVentas.Pago = New VistaModelo.frmVentas.Pago() With {
                                                        .FormaPagoDescripcion = formaPagoDescripcion,
                                                        .FormaPago = formaPagoSeleccionada.Key,
                                                        .TarjetaId = If(tarjetaSeleccionada IsNot Nothing, tarjetaSeleccionada.TarjetaId, 0),
                                                        .CuotaId = If(cuotaSeleccionada IsNot Nothing, cuotaSeleccionada?.CostoFinancieroId, 0),
                                                        .CostoFinanciero = Me.CostoFinanciero,
                                                        .Descuento = Me.Descuento,
                                                        .IVA = Me.IVA,
                                                        .SubTotal = Me.SubTotal,
                                                        .Total = Me.Total
                                                        }

            Me.Pagos.Add(pago)

            'Agrego el pago en el producto
            Dim monto As Double = pago.SubTotal
            For Each producto As Producto In Me.Productos.Where(Function(x) Not x.Pago)
                If (monto = 0) Then
                    Exit For
                End If

                monto = producto.AgregarPago(pago.FormaPago, Me.TipoClienteSeleccionado, pago.TarjetaId, pago.CuotaId, monto)
            Next

            Me.SubTotal = Me.ObtenerSubTotalFaltantePago()
            Me.CalcularTotal(Me.SubTotal)
        End Sub

        Public Sub QuitarPago(pago As Pago)

            Me.Pagos.Remove(pago)

            'Quito el pago en el producto
            For Each producto As Producto In Me.Productos
                producto.QuitarPago(pago)
            Next

            ActualizarProductos()

            Me.SubTotal = Me.ObtenerSubTotalFaltantePago()

            Me.CalcularTotal(Me.SubTotal)

            If (pago.FormaPago = FormaPago.Efectivo) Then
                Me.FormasPagos.Add(New KeyValuePair(Of FormaPago, String)(pago.FormaPago, pago.FormaPago.ToString()))
                Me.FormasPagos = New BindingList(Of KeyValuePair(Of FormaPago, String))(Me.FormasPagos.OrderBy(Function(x) x.Key).ToList())
            End If

        End Sub
    End Class
End Namespace