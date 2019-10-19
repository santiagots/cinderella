Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Common.Core.Enum
Imports Model = Ventas.Core.Model.VentaAggregate

Namespace Formularios.Facturacion

    Public Class frmNotaCreditoAdministracionViewModel
        Inherits Comunes.Common

        Private IdSucursal As Integer
        Private MdiParent As Form

        Public Property NumeroNotaCredito As Integer?
        Public Property MontoDesde As Decimal?
        Public Property MontoHasta As Decimal?
        Public Property Nombre As String
        Public Property Cuit As Integer?
        Public Property FechaDesde As DateTime?
        Public Property FechaHasta As DateTime?
        Public Property FacturaManual As Boolean
        Public Property FacturaTicket As Boolean
        Public Property FacturaElectronica As Boolean
        Private _NotaCredito As List(Of Model.NotaCredito)
        Public ReadOnly Property NotaCredito As BindingList(Of DocumentoFiscalViewModel)
            Get
                Return New BindingList(Of DocumentoFiscalViewModel)(Mapper.Map(Of List(Of DocumentoFiscalViewModel))(_NotaCredito))
            End Get
        End Property
        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not NotaCredito.Any()
            End Get
        End Property

        Public Sub New(idSucursal As Integer, mdiParent As Form)
            Me.IdSucursal = idSucursal
            _NotaCredito = New List(Of Model.NotaCredito)
            Me.MdiParent = mdiParent
            Inicializar()
        End Sub

        Friend Async Function MostrarFacturaDetalle(documentoFiscalViewModel As DocumentoFiscalViewModel) As Task
            Dim notaCreditoSeleccionada As Model.NotaCredito = _NotaCredito.FirstOrDefault(Function(x) x.Id = documentoFiscalViewModel.Id)
            Dim ventaModel As Model.Venta = Await Task.Run(Function() Comunes.Servicio.ObtenerVenta(notaCreditoSeleccionada.IdVenta))
            Dim frmVerDocumentoFiscal As frmVerDocumentoFiscal = New frmVerDocumentoFiscal(ventaModel.Factura.Id, TipoDocumentoFiscal.Factura)
            frmVerDocumentoFiscal.ShowDialog()
        End Function

        Friend Async Function BuscarAsync() As Task
            Dim tiposFacturas As List(Of TipoFactura) = New List(Of TipoFactura)()

            If FacturaManual Then
                tiposFacturas.Add(TipoFactura.Manual)
            End If
            If FacturaTicket Then
                tiposFacturas.Add(TipoFactura.Ticket)
            End If
            If FacturaElectronica Then
                tiposFacturas.Add(TipoFactura.Electronica)
            End If

            _NotaCredito = Await Task.Run(Function() Servicio.BuscarNotaCredito(IdSucursal, NumeroNotaCredito, MontoDesde, MontoHasta, Nombre, Cuit, FechaDesde, FechaHasta, tiposFacturas))

            NotifyPropertyChanged(NameOf(Me.NotaCredito))
        End Function

        Private Sub Inicializar()
            FechaDesde = DateTime.Now.AddDays(-7)
            FechaHasta = DateTime.Now
            MontoDesde = Nothing
            MontoHasta = Nothing
            FacturaManual = False
            FacturaTicket = False
            FacturaElectronica = False
        End Sub
    End Class
End Namespace
