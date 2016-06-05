Imports EpsonFPHostControlX
Imports System.Windows.Forms.Application
Public Class NegControladorFiscal
    Public oEpsonFP As EpsonFPHostControl

    'Constructor.
    Sub New(TipoConexion As String)
        oEpsonFP = New EpsonFPHostControl()

        If (TipoConexion = "USB") Then
            oEpsonFP.CommPort = TxCommPort.USB
        Else
            oEpsonFP.CommPort = TxCommPort.Com1
            oEpsonFP.BaudRate = TxBaudRate.br9600
        End If

        oEpsonFP.ProtocolType = TxProtocolType.protocol_Extended
    End Sub

    'Funcion que Abre un Tique.
    Public Function AbrirTicket(ByVal Control As Entidades.ControladorFiscal) As Boolean
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&HB) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.NCOMP1)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.NCOMP2)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DCOMP1)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DCOMP2)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DCOMP3)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.CUIT)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.NCUIT)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.RI)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.LREMITO1)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.LREMITO2)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("")
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que Abre una Nota de Credito.
    Public Function AbrirNotaCredito(ByVal Control As Entidades.ControladorFiscal) As Boolean
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&HD) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.NCOMP1)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.NCOMP2)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DCOMP1)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DCOMP2)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DCOMP3)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.CUIT)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.NCUIT)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.RI)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.LREMITO1)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.LREMITO2)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.COMPROBANTEORIGEN)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function


    'Funcion que Cierra un Tique.
    Public Function CerrarTicket(ByVal Control As Entidades.ControladorFiscal)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&HB) + Chr(&H6))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H3))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("1")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.COLAR1)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("2")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.COLAR2)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("3")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.COLAR3)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        If oEpsonFP.GetExtraField(1) = "" Then
            Return 0
        Else
            Return oEpsonFP.GetExtraField(1)
        End If

    End Function

    'Funcion que Cierra un Tique.
    Public Function CerrarNotaCredito(ByVal Control As Entidades.ControladorFiscal)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&HD) + Chr(&H6))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H3))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("1")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.COLAR1)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("2")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.COLAR2)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("3")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.COLAR3)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("")
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        If oEpsonFP.GetExtraField(1) = "" Then
            Return 0
        Else
            Return oEpsonFP.GetExtraField(1)
        End If
    End Function

    'Funcion que obtiene el subtotal de un Tique.
    Public Function SubtotalTicket()
        Dim sSubtotal As String = ""
        Dim bAnswer As Boolean = False

        'Get Subtotal
        bAnswer = oEpsonFP.AddDataField(Chr(&HB) + Chr(&H3))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H8))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        sSubtotal = oEpsonFP.GetExtraField(1)
        FPDelay()
        Return sSubtotal
    End Function

    'Funcion que obtiene el subtotal de una Nota de Credito.
    Public Function SubtotalNotaCredito()
        Dim sSubtotal As String = ""
        Dim bAnswer As Boolean = False

        'Get Subtotal
        bAnswer = oEpsonFP.AddDataField(Chr(&HD) + Chr(&H3))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        sSubtotal = oEpsonFP.GetExtraField(1)
        FPDelay()
        Return sSubtotal
    End Function

    'Funcion que Agrega descuentos.
    Public Function DescuentosTicket(ByVal descrip As String, ByVal descuento As String)
        Dim bAnswer As Boolean = False

        bAnswer = oEpsonFP.AddDataField(Chr(&HB) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descrip)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descuento)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que Agrega descuentos a la nota de credito.
    Public Function DescuentosNotaCredito(ByVal descrip As String, ByVal descuento As String)
        Dim bAnswer As Boolean = False

        bAnswer = oEpsonFP.AddDataField(Chr(&HD) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descrip)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descuento)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que Paga un Tique.
    Public Function PagarTicket(ByVal TipoPago As String, ByVal MontoPago As String)
        Dim bAnswer As Boolean = False
        'Send Payment
        bAnswer = oEpsonFP.AddDataField(Chr(&HB) + Chr(&H5))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(TipoPago)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(MontoPago)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que Agrega un item a un Tique.
    Public Function AgregarItemTicket(ByVal Control As Entidades.ControladorFiscal)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&HB) + Chr(&H2))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H18))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DE1)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DE2)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DE3)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DE4)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DPPAL)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.CANTIDAD)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.PUNITARIO)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.TIVA)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.IIF)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.IIP)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que Agrega un item a una Nota de Credito.
    Public Function AgregarItemNotaCredito(ByVal Control As Entidades.ControladorFiscal)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&HD) + Chr(&H2))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H18))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DE1)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DE2)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DE3)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DE4)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.DPPAL)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.CANTIDAD)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.PUNITARIO)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.TIVA)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.IIF)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.IIP)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que emite el Cierre X en la controladora
    Public Sub CierreX()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H2))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
    End Sub

    'Funcion que emite el Cierre Z en la controladora
    Public Sub CierreZ()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&HC) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
    End Sub

    Public Sub CierreZPorRangoDeFecha(ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H10))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaDesde.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaHasta.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand
        FPDelay()
    End Sub

    Public Sub Informacionjornada()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H3))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&HC) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
    End Sub

    'Funcion que abre los puertos de la impresora.
    Public Function AbrirPuerto() As Boolean
        Dim state As Boolean = False
        If (oEpsonFP.OpenPort = True) Then
            state = True
        Else
            state = False
        End If
        Return state
    End Function

    'Funcion que abre cerrar los puertos de la impresora.
    Public Function CerrarPuerto()
        oEpsonFP.ClosePort()
    End Function

    Public Function PrinterStatus()
        Return Hex(oEpsonFP.PrinterStatus).PadLeft(4, "0"c)
    End Function

    Public Function FiscalStatus()
        Return Hex(oEpsonFP.FiscalStatus).PadLeft(4, "0"c)
    End Function

    Public Function ReturnCode()
        Return Hex(oEpsonFP.ReturnCode).PadLeft(4, "0"c)
    End Function

    Public Sub FPDelay()
        While (oEpsonFP.State = TxFiscalState.EFP_S_Busy)
            DoEvents()
        End While
    End Sub
End Class
