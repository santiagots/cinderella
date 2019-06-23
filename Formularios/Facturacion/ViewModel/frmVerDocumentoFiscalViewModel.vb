Imports System.Threading.Tasks
Imports AutoMapper
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Ventas.Core.Model.VentaAggregate

Namespace Formularios.Facturacion
    Public Class frmVerFacturaViewModel
        Inherits SistemaCinderella.VistaModelo.Common

        Private IdDocuemtnoFiscal As Long
        Private TipoDocumentoFiscal As TipoDocumentoFiscal

        Public Property DocumentoFiscalViewModel As DocumentoFiscalViewModel

        Sub New(idDocumentoFiscal As Long, tipoDocumentoFiscal As TipoDocumentoFiscal)
            Me.IdDocuemtnoFiscal = idDocumentoFiscal
            Me.TipoDocumentoFiscal = tipoDocumentoFiscal
        End Sub

        Friend Async Function CargarDatosAsync() As Task
            Select Case TipoDocumentoFiscal
                Case TipoDocumentoFiscal.Factura
                    Await CargarDatosDesdeFacturaAsync(IdDocuemtnoFiscal)

                Case TipoDocumentoFiscal.NotaCredito
                    Await CargarDatosNotaCreditoAsync(IdDocuemtnoFiscal)
                Case Else
                    Throw New NegocioException($"el tipo de documento {TipoDocumentoFiscal} es invalido para esta operacion.")
            End Select
        End Function

        Private Async Function CargarDatosNotaCreditoAsync(idDocuemtnoFiscal As Long) As Task
            Dim notaCredito As NotaCredito = Await Task.Run(Function() Servicio.ObtenerNotaCredito(idDocuemtnoFiscal))
            DocumentoFiscalViewModel = Mapper.Map(Of DocumentoFiscalViewModel)(notaCredito)
            NotifyPropertyChanged(NameOf(DocumentoFiscalViewModel))
        End Function

        Private Async Function CargarDatosDesdeFacturaAsync(idDocuemtnoFiscal As Long) As Task
            Dim factura As Factura = Await Task.Run(Function() Servicio.ObtenerFactura(idDocuemtnoFiscal))
            DocumentoFiscalViewModel = Mapper.Map(Of DocumentoFiscalViewModel)(factura)
            NotifyPropertyChanged(NameOf(DocumentoFiscalViewModel))
        End Function
    End Class
End Namespace