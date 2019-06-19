Imports EpsonFPHostControlX
Imports System.Windows.Forms.Application
Imports Entidades

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

        If (Control.MODELO = Entidades.ImpresoraFiscalModelo.U220AFII) Then
            Return AbrirTicket_U220AFII(Control)
        Else
            Control.LREMITO1 = "081-00001-00000027"
            Return AbrirTicket_T900FA(Control)
        End If
    End Function
    Public Function AbrirTicket_U220AFII(ByVal Control As Entidades.ControladorFiscal) As Boolean
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

    Public Function AbrirTicket_T900FA(ByVal Control As Entidades.ControladorFiscal) As Boolean
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
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.LREMITO3)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("")
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que Abre una Nota de Credito.
    Public Function AbrirNotaCredito(ByVal Control As Entidades.ControladorFiscal) As Boolean

        If (Control.MODELO = Entidades.ImpresoraFiscalModelo.U220AFII) Then
            Return AbrirNotaCredito_U220AFII(Control)
        Else
            Return AbrirNotaCredito_T900FA(Control)
        End If
    End Function

    Public Function AbrirNotaCredito_U220AFII(ByVal Control As Entidades.ControladorFiscal) As Boolean
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

    Public Function AbrirNotaCredito_T900FA(ByVal Control As Entidades.ControladorFiscal) As Boolean
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
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.LREMITO3)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.COMPROBANTEORIGEN)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function


    'Funcion que Cierra un Tique.
    Public Function CerrarTicket(ByVal Control As Entidades.ControladorFiscal) As Integer

        If (Control.MODELO = Entidades.ImpresoraFiscalModelo.U220AFII) Then
            Return CerrarTicket_U220AFII(Control)
        Else
            Return CerrarTicket_T900FA(Control)
        End If
    End Function

    Public Function CerrarTicket_U220AFII(ByVal Control As Entidades.ControladorFiscal) As Integer
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
            Return CType(oEpsonFP.GetExtraField(1), Integer)
        End If

    End Function

    Public Function CerrarTicket_T900FA(ByVal Control As Entidades.ControladorFiscal) As Integer
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
            Return CType(oEpsonFP.GetExtraField(1), Integer)
        End If

    End Function

    'Funcion que Cierra un Tique.
    Public Function CerrarNotaCredito(ByVal Control As Entidades.ControladorFiscal) As Integer

        If (Control.MODELO = Entidades.ImpresoraFiscalModelo.U220AFII) Then
            Return CerrarNotaCredito_U220AFII(Control)
        Else
            Return CerrarNotaCredito_T900FA(Control)
        End If
    End Function

    Public Function CerrarNotaCredito_U220AFII(ByVal Control As Entidades.ControladorFiscal) As Integer
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
            Return CType(oEpsonFP.GetExtraField(1), Integer)
        End If
    End Function

    Public Function CerrarNotaCredito_T900FA(ByVal Control As Entidades.ControladorFiscal) As Integer
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
            Return CType(oEpsonFP.GetExtraField(1), Integer)
        End If
    End Function

    'Funcion que obtiene el subtotal de un Tique.
    Public Function SubtotalTicket(ByVal Control As Entidades.ControladorFiscal) As String

        If (Control.MODELO = Entidades.ImpresoraFiscalModelo.U220AFII) Then
            Return SubtotalTicket_U220AFII()
        Else
            Return SubtotalTicket_T900FA()
        End If
    End Function

    Public Function SubtotalTicket_U220AFII() As String
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

    Public Function SubtotalTicket_T900FA() As String
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
    Public Function SubtotalNotaCredito(ByVal Control As Entidades.ControladorFiscal) As String

        If (Control.MODELO = Entidades.ImpresoraFiscalModelo.U220AFII) Then
            Return SubtotalNotaCredito_U220AFII()
        Else
            Return SubtotalNotaCredito_T900FA()
        End If
    End Function

    Public Function SubtotalNotaCredito_U220AFII() As String
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

    Public Function SubtotalNotaCredito_T900FA() As String
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
    Public Function DescuentosTicket(ByVal descrip As String, ByVal descuento As String, modelo As ImpresoraFiscalModelo, tasaIVA As String, CondicionFrenteIva As String) As Boolean

        If (modelo = ImpresoraFiscalModelo.U220AFII) Then
            Return DescuentosTicket_U220AFII(descrip, descuento)
        Else
            Return DescuentosTicket_T900FA(descrip, descuento, tasaIVA, CondicionFrenteIva)
        End If
    End Function

    Public Function DescuentosTicket_U220AFII(ByVal descrip As String, ByVal descuento As String)
        Dim bAnswer As Boolean = False

        bAnswer = oEpsonFP.AddDataField(Chr(&HB) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descrip)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descuento)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Public Function DescuentosTicket_T900FA(ByVal descrip As String, ByVal descuento As String, tasaIVA As String, CondicionFrenteIva As String)
        Dim bAnswer As Boolean = False

        bAnswer = oEpsonFP.AddDataField(Chr(&HB) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descrip)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descuento)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(tasaIVA)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("0")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(CondicionFrenteIva)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que Agrega descuentos.
    Public Function RecargosTicket(ByVal descrip As String, ByVal descuento As String, modelo As ImpresoraFiscalModelo, tasaIVA As String, CondicionFrenteIva As String) As Boolean

        If (modelo = ImpresoraFiscalModelo.U220AFII) Then
            Return RecargosTicket_U220AFII(descrip, descuento)
        Else
            Return RecargosTicket_T900FA(descrip, descuento, tasaIVA, CondicionFrenteIva)
        End If
    End Function

    Public Function RecargosTicket_U220AFII(ByVal descrip As String, ByVal descuento As String)
        Dim bAnswer As Boolean = False

        bAnswer = oEpsonFP.AddDataField(Chr(&HB) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descrip)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descuento)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Public Function RecargosTicket_T900FA(ByVal descrip As String, ByVal descuento As String, tasaIVA As String, CondicionFrenteIva As String)
        Dim bAnswer As Boolean = False

        bAnswer = oEpsonFP.AddDataField(Chr(&HB) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descrip)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descuento)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(tasaIVA)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("0")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(CondicionFrenteIva)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que Agrega descuentos a la nota de credito.
    Public Function DescuentosNotaCredito(ByVal descrip As String, ByVal descuento As String, modelo As ImpresoraFiscalModelo, tasaIVA As String, CondicionFrenteIva As String) As Boolean

        If (modelo = ImpresoraFiscalModelo.U220AFII) Then
            Return DescuentosNotaCredito_U220AFII(descrip, descuento)
        Else
            Return DescuentosNotaCredito_T900FA(descrip, descuento, tasaIVA, CondicionFrenteIva)
        End If
    End Function

    Public Function DescuentosNotaCredito_U220AFII(ByVal descrip As String, ByVal descuento As String)
        Dim bAnswer As Boolean = False

        bAnswer = oEpsonFP.AddDataField(Chr(&HD) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descrip)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descuento)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Public Function DescuentosNotaCredito_T900FA(ByVal descrip As String, ByVal descuento As String, tasaIVA As String, CondicionFrenteIva As String)
        Dim bAnswer As Boolean = False

        bAnswer = oEpsonFP.AddDataField(Chr(&HD) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descrip)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descuento)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(tasaIVA)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("0")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(CondicionFrenteIva)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que Agrega descuentos.
    Public Function RecargosNotaCredito(ByVal descrip As String, ByVal descuento As String, modelo As ImpresoraFiscalModelo, tasaIVA As String, CondicionFrenteIva As String) As Boolean

        If (modelo = ImpresoraFiscalModelo.U220AFII) Then
            Return RecargosNotaCredito_U220AFII(descrip, descuento)
        Else
            Return RecargosNotaCredito_T900FA(descrip, descuento, tasaIVA, CondicionFrenteIva)
        End If
    End Function

    Public Function RecargosNotaCredito_U220AFII(ByVal descrip As String, ByVal descuento As String)
        Dim bAnswer As Boolean = False

        bAnswer = oEpsonFP.AddDataField(Chr(&HD) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descrip)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descuento)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Public Function RecargosNotaCredito_T900FA(ByVal descrip As String, ByVal descuento As String, tasaIVA As String, CondicionFrenteIva As String)
        Dim bAnswer As Boolean = False

        bAnswer = oEpsonFP.AddDataField(Chr(&HD) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descrip)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descuento)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(tasaIVA)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("0")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(CondicionFrenteIva)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que Paga un Tique.
    Public Function PagarTicket(ByVal TipoPago As String, ByVal MontoPago As String, modelo As ImpresoraFiscalModelo) As Boolean

        If (modelo = ImpresoraFiscalModelo.U220AFII) Then
            Return PagarTicket_U220AFII(TipoPago, MontoPago)
        Else
            TipoPago = obtenerCodigoPago(TipoPago)
            Return PagarTicket_T900FA(TipoPago, MontoPago)
        End If
    End Function

    Public Function PagarTicket_U220AFII(ByVal TipoPago As String, ByVal MontoPago As String)
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

    Public Function PagarTicket_T900FA(ByVal TipoPago As String, ByVal MontoPago As String)
        Dim bAnswer As Boolean = False
        'Send Payment
        bAnswer = oEpsonFP.AddDataField(Chr(&HB) + Chr(&H5))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField("")
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(TipoPago)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(MontoPago)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que Agrega un item a un Tique.
    Public Function AgregarItemTicket(ByVal Control As Entidades.ControladorFiscal) As Boolean

        If (Control.MODELO = ImpresoraFiscalModelo.U220AFII) Then
            Return AgregarItemTicket_U220AFII(Control)
        Else
            Return AgregarItemTicket_T900FA(Control)
        End If
    End Function

    Public Function AgregarItemTicket_U220AFII(ByVal Control As Entidades.ControladorFiscal)
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

    Public Function AgregarItemTicket_T900FA(ByVal Control As Entidades.ControladorFiscal)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&HB) + Chr(&H2))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H40) + Chr(&H10))
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
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.UnidadReferianciaMTX)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.CodigoItemMTX)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.CodigoItem)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.CodigoUnidadMedida)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.CodigoCondicionIva)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que Agrega un item a una Nota de Credito.
    Public Function AgregarItemNotaCredito(ByVal Control As Entidades.ControladorFiscal) As Boolean

        If (Control.MODELO = ImpresoraFiscalModelo.U220AFII) Then
            Return AgregarItemNotaCredito_U220AFII(Control)
        Else
            Return AgregarItemNotaCredito_T900FA(Control)
        End If
    End Function

    Public Function AgregarItemNotaCredito_U220AFII(ByVal Control As Entidades.ControladorFiscal)
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

    Public Function AgregarItemNotaCredito_T900FA(ByVal Control As Entidades.ControladorFiscal)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&HD) + Chr(&H2))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H40) + Chr(&H10))
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
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.UnidadReferianciaMTX)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.CodigoItemMTX)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.CodigoItem) 'TODO
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.CodigoUnidadMedida) 'TODO
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Control.CodigoCondicionIva) 'TODO
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que emite el Cierre X en la controladora
    Public Function CierreX(ByVal Modelo As ImpresoraFiscalModelo) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Return CierreX_U220AFII()
        Else
            Return CierreX_T900FA()
        End If
    End Function

    Public Function CierreX_U220AFII()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H2))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Public Function CierreX_T900FA()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H2))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    'Funcion que emite el Cierre Z en la controladora
    Public Function CierreZ(ByVal Modelo As ImpresoraFiscalModelo) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Return CierreZ_U220AFII()
        Else
            Return CierreZ_T900FA()
        End If
    End Function

    Public Function CierreZ_U220AFII()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&HC) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Public Function CierreZ_T900FA()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Public Function CierreZPorRangoDeFecha(ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime, ByVal Modelo As ImpresoraFiscalModelo) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Return CierreZPorRangoDeFecha_U220AFII(fechaDesde, fechaHasta)
        Else
            Return CierreZPorRangoDeFecha_T900FA(fechaDesde, fechaHasta)
        End If
    End Function

    Public Function CierreZPorRangoDeFecha_U220AFII(ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H10))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaDesde.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaHasta.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand
        FPDelay()
        Return bAnswer
    End Function

    Public Function CierreZPorRangoDeFecha_T900FA(ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H12))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaDesde.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaHasta.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand
        FPDelay()
        Return bAnswer
    End Function

    Public Function Informacionjornada(ByVal Modelo As ImpresoraFiscalModelo) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Return Informacionjornada_U220AFII()
        Else
            Return Informacionjornada_T900FA()
        End If
    End Function

    Public Function Informacionjornada_U220AFII()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H3))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&HC) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Public Function Informacionjornada_T900FA()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H3))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&HC) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

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

    Private Function obtenerCodigoPago(tipoPago As String) As String
        Select Case tipoPago.ToUpper()
            Case "EFECTIVO"
                Return "8"
            Case "CREDITO"
            Case "TARJETA DE CRÉDITO"
                Return "20"
            Case "DEBITO"
            Case "TARJETA DE DÉBITO"
                Return "21"
            Case "CHEQUE"
                Return "3"
            Case "DEPOSITO"
                Return "7"
            Case Else

        End Select
    End Function
End Class
