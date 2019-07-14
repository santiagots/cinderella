﻿Imports EpsonFPHostControlX
Imports System.Windows.Forms.Application
Imports Entidades
Imports Datos

Public Class NegControladorFiscal : Implements IDisposable
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
            Control.LREMITO1 = "903-00001-00000001"
            Return AbrirTicket_T900FA(Control)
        End If
    End Function
    Private Function AbrirTicket_U220AFII(ByVal Control As Entidades.ControladorFiscal) As Boolean
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

    Private Function AbrirTicket_T900FA(ByVal Control As Entidades.ControladorFiscal) As Boolean
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

    Private Function AbrirNotaCredito_U220AFII(ByVal Control As Entidades.ControladorFiscal) As Boolean
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

    Private Function AbrirNotaCredito_T900FA(ByVal Control As Entidades.ControladorFiscal) As Boolean
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

    Private Function CerrarTicket_U220AFII(ByVal Control As Entidades.ControladorFiscal) As Integer
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

    Private Function CerrarTicket_T900FA(ByVal Control As Entidades.ControladorFiscal) As Integer
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

    Private Function CerrarNotaCredito_U220AFII(ByVal Control As Entidades.ControladorFiscal) As Integer
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

    Private Function CerrarNotaCredito_T900FA(ByVal Control As Entidades.ControladorFiscal) As Integer
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

    Private Function SubtotalTicket_U220AFII() As String
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

    Private Function SubtotalTicket_T900FA() As String
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

    Private Function SubtotalNotaCredito_U220AFII() As String
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

    Private Function SubtotalNotaCredito_T900FA() As String
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

    Private Function DescuentosTicket_U220AFII(ByVal descrip As String, ByVal descuento As String)
        Dim bAnswer As Boolean = False

        bAnswer = oEpsonFP.AddDataField(Chr(&HB) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descrip)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descuento)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Private Function DescuentosTicket_T900FA(ByVal descrip As String, ByVal descuento As String, tasaIVA As String, CondicionFrenteIva As String)
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

    Private Function RecargosTicket_U220AFII(ByVal descrip As String, ByVal descuento As String)
        Dim bAnswer As Boolean = False

        bAnswer = oEpsonFP.AddDataField(Chr(&HB) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descrip)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descuento)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Private Function RecargosTicket_T900FA(ByVal descrip As String, ByVal descuento As String, tasaIVA As String, CondicionFrenteIva As String)
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

    Private Function DescuentosNotaCredito_U220AFII(ByVal descrip As String, ByVal descuento As String)
        Dim bAnswer As Boolean = False

        bAnswer = oEpsonFP.AddDataField(Chr(&HD) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descrip)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descuento)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Private Function DescuentosNotaCredito_T900FA(ByVal descrip As String, ByVal descuento As String, tasaIVA As String, CondicionFrenteIva As String)
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

    Private Function RecargosNotaCredito_U220AFII(ByVal descrip As String, ByVal descuento As String)
        Dim bAnswer As Boolean = False

        bAnswer = oEpsonFP.AddDataField(Chr(&HD) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descrip)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(descuento)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Private Function RecargosNotaCredito_T900FA(ByVal descrip As String, ByVal descuento As String, tasaIVA As String, CondicionFrenteIva As String)
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

    Private Function PagarTicket_U220AFII(ByVal TipoPago As String, ByVal MontoPago As String)
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

    Private Function PagarTicket_T900FA(ByVal TipoPago As String, ByVal MontoPago As String)
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

    Private Function AgregarItemTicket_U220AFII(ByVal Control As Entidades.ControladorFiscal)
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

    Private Function AgregarItemTicket_T900FA(ByVal Control As Entidades.ControladorFiscal)
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

    Private Function AgregarItemNotaCredito_U220AFII(ByVal Control As Entidades.ControladorFiscal)
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

    Private Function AgregarItemNotaCredito_T900FA(ByVal Control As Entidades.ControladorFiscal)
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

    Private Function CierreX_U220AFII()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H2))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Private Function CierreX_T900FA()
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

    Private Function CierreZ_U220AFII()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&HC) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Private Function CierreZ_T900FA()
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

    Private Function CierreZPorRangoDeFecha_U220AFII(ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H10))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaDesde.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaHasta.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand
        FPDelay()
        Return bAnswer
    End Function

    Private Function CierreZPorRangoDeFecha_T900FA(ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H12))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H3))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaDesde.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaHasta.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand
        FPDelay()

        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H15))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand
        FPDelay()
        Return bAnswer
    End Function

    Public Function CierreZPorRangoDeJornada(ByVal jornadaDesde As Integer, ByVal jornadaHasta As Integer, ByVal Modelo As ImpresoraFiscalModelo) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Return CierreZPorRangoDeJornada_U220AFII(jornadaDesde, jornadaHasta)
        Else
            Return CierreZPorRangoDeJornada_T900FA(jornadaDesde, jornadaHasta)
        End If
    End Function

    Private Function CierreZPorRangoDeJornada_U220AFII(ByVal jornadaDesde As Integer, ByVal jornadaHasta As Integer)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H11))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H1))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(jornadaDesde.ToString())
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(jornadaHasta.ToString())
        If bAnswer Then bAnswer = oEpsonFP.SendCommand
        FPDelay()
        Return bAnswer
    End Function

    Private Function CierreZPorRangoDeJornada_T900FA(ByVal jornadaDesde As Integer, ByVal jornadaHasta As Integer)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H13))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H3))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(jornadaDesde.ToString())
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(jornadaHasta.ToString())
        If bAnswer Then bAnswer = oEpsonFP.SendCommand
        FPDelay()

        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H14))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand
        FPDelay()

        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H15))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
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

    Private Function Informacionjornada_U220AFII()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H3))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&HC) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Private Function Informacionjornada_T900FA()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H8) + Chr(&H3))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&HC) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        Return bAnswer
    End Function

    Public Function CintaTestigoDigitalPorRangoDeFecha(ByVal Modelo As ImpresoraFiscalModelo, ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime, ByRef nombreArchivo As String) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Throw New InvalidOperationException("Comando no implementado para el modelo de impresora seleccionada")
        Else
            Return CintaTestigoDigitalPorRangoDeFecha_T900FA(fechaDesde, fechaHasta, nombreArchivo)
        End If
    End Function

    Private Function CintaTestigoDigitalPorRangoDeFecha_T900FA(ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime, ByRef nombreArchivo As String)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H9) + Chr(&H51))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaDesde.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaHasta.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        nombreArchivo = oEpsonFP.GetExtraField(1)
        EvaluarCodigoDeError()
        Return bAnswer
    End Function

    Public Function CintaTestigoDigitalPorRangoDeJornada(ByVal Modelo As ImpresoraFiscalModelo, ByVal jornadaDesde As Integer, ByVal jornadaHasta As Integer, ByRef nombreArchivo As String) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Throw New InvalidOperationException("Comando no implementado para el modelo de impresora seleccionada")
        Else
            Return CintaTestigoDigitalPorRangoDeJornada_T900FA(jornadaDesde, jornadaHasta, nombreArchivo)
        End If
    End Function

    Private Function CintaTestigoDigitalPorRangoDeJornada_T900FA(ByVal jornadaDesde As Integer, ByVal jornadaHasta As Integer, ByRef nombreArchivo As String)

        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H9) + Chr(&H52))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(jornadaDesde)
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(jornadaHasta)
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        nombreArchivo = oEpsonFP.GetExtraField(1)

        EvaluarCodigoDeError()
        Return bAnswer
    End Function

    Public Function DuplicadosDocumentosTipoAPorRangoDeFecha(ByVal Modelo As ImpresoraFiscalModelo, ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime, ByRef nombreArchivo As String) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Throw New InvalidOperationException("Comando no implementado para el modelo de impresora seleccionada")
        Else
            Return DuplicadosDocumentosTipoAPorRangoDeFecha_T900FA(fechaDesde, fechaHasta, nombreArchivo)
        End If
    End Function

    Private Function DuplicadosDocumentosTipoAPorRangoDeFecha_T900FA(ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime, ByRef nombreArchivo As String)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H9) + Chr(&H51))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H2))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaDesde.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaHasta.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        nombreArchivo = oEpsonFP.GetExtraField(1)
        EvaluarCodigoDeError()
        Return bAnswer
    End Function

    Public Function DuplicadosDocumentosTipoAPorRangoDeJornada(ByVal Modelo As ImpresoraFiscalModelo, ByVal jornadaDesde As Integer, ByVal jornadaHasta As Integer, ByRef nombreArchivo As String) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Throw New InvalidOperationException("Comando no implementado para el modelo de impresora seleccionada")
        Else
            Return DuplicadosDocumentosTipoAPorRangoDeJornada_T900FA(jornadaDesde, jornadaHasta, nombreArchivo)
        End If
    End Function

    Private Function DuplicadosDocumentosTipoAPorRangoDeJornada_T900FA(ByVal jornadaDesde As Integer, ByVal jornadaHasta As Integer, ByRef nombreArchivo As String)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H9) + Chr(&H52))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H2))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(jornadaDesde.ToString())
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(jornadaHasta.ToString())
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        nombreArchivo = oEpsonFP.GetExtraField(1)
        EvaluarCodigoDeError()
        Return bAnswer
    End Function

    Public Function ResumenTotalesPorRangoDeFechas(ByVal Modelo As ImpresoraFiscalModelo, ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime, ByRef nombreArchivo As String) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Throw New InvalidOperationException("Comando no implementado para el modelo de impresora seleccionada")
        Else
            Return ResumenTotalesPorRangoDeFechas_T900FA(fechaDesde, fechaHasta, nombreArchivo)
        End If
    End Function

    Private Function ResumenTotalesPorRangoDeFechas_T900FA(ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime, ByRef nombreArchivo As String)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H9) + Chr(&H51))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaDesde.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(fechaHasta.ToString("ddMMyy"))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        nombreArchivo = oEpsonFP.GetExtraField(1)
        EvaluarCodigoDeError()
        Return bAnswer
    End Function

    Public Function ResumenTotalesPorRangoDeJornadas(ByVal Modelo As ImpresoraFiscalModelo, ByVal jornadaDesde As Integer, ByVal jornadaHasta As Integer, ByRef nombreArchivo As String) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Throw New InvalidOperationException("Comando no implementado para el modelo de impresora seleccionada")
        Else
            Return ResumenTotalesPorRangoDeJornadas_T900FA(jornadaDesde, jornadaHasta, nombreArchivo)
        End If
    End Function

    Private Function ResumenTotalesPorRangoDeJornadas_T900FA(ByVal jornadaDesde As Integer, ByVal jornadaHasta As Integer, ByRef nombreArchivo As String)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H9) + Chr(&H52))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H4))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(jornadaDesde.ToString())
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(jornadaHasta.ToString())
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        nombreArchivo = oEpsonFP.GetExtraField(1)
        EvaluarCodigoDeError()
        Return bAnswer
    End Function

    Public Function DescargaReporteMemoriaTransacciones(ByVal Modelo As ImpresoraFiscalModelo, ByRef datos As String, ByRef continuar As String) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Throw New InvalidOperationException("Comando no implementado para el modelo de impresora seleccionada")
        Else
            Return DescargaReporteMemoriaTransacciones_T900FA(datos, continuar)
        End If
    End Function

    Private Function DescargaReporteMemoriaTransacciones_T900FA(ByRef datos As String, ByRef continuar As String)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H9) + Chr(&H70))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        datos = oEpsonFP.GetExtraField(1)
        FPDelay()
        continuar = oEpsonFP.GetExtraField(2)
        EvaluarCodigoDeError()
        Return bAnswer
    End Function

    Public Function FinalizarDescargaReporteMemoriaTransacciones(ByVal Modelo As ImpresoraFiscalModelo) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Throw New InvalidOperationException("Comando no implementado para el modelo de impresora seleccionada")
        Else
            Return FinalizarDescargaReporteMemoriaTransacciones_T900FA()
        End If
    End Function

    Private Function FinalizarDescargaReporteMemoriaTransacciones_T900FA()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H9) + Chr(&H71))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        EvaluarCodigoDeError()
        Return bAnswer
    End Function

    Public Function CancelarDescargaReporteMemoriaTransacciones(ByVal Modelo As ImpresoraFiscalModelo) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Throw New InvalidOperationException("Comando no implementado para el modelo de impresora seleccionada")
        Else
            Return CancelarDescargaReporteMemoriaTransacciones_T900FA()
        End If
    End Function

    Private Function CancelarDescargaReporteMemoriaTransacciones_T900FA()
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H9) + Chr(&H72))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        EvaluarCodigoDeError()
        Return bAnswer
    End Function


    Public Function BorradoJornadasMemoriaTransacciones(ByVal Modelo As ImpresoraFiscalModelo, BorrarHastaJornadaFiscalNumero As Integer) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Throw New InvalidOperationException("Comando no implementado para el modelo de impresora seleccionada")
        Else
            Return BorradoJornadasMemoriaTransacciones_T900FA(BorrarHastaJornadaFiscalNumero)
        End If
    End Function

    Private Function BorradoJornadasMemoriaTransacciones_T900FA(BorrarHastaJornadaFiscalNumero As Integer)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H9) + Chr(&H10))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(BorrarHastaJornadaFiscalNumero.ToString())
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()
        EvaluarCodigoDeError()
        Return bAnswer
    End Function

    Public Function InformacionMemoriaTransacciones(ByVal Modelo As ImpresoraFiscalModelo, ByRef DescargarCintaTestigoDigitalDesde As String, ByRef DescargarCintaTestigoDigitalHasta As String,
                                                           ByRef DescargarDuplicadosTipoADesde As String, ByRef DescargarDuplicadosTipoAHasta As String,
                                                           ByRef DescargarResumenTotalesDesde As String, ByRef DescargarResumenTotalesHasta As String,
                                                           ByRef JornadasDescargadasCompletamenteDesde As String, ByRef JornadasDescargadasCompletamenteHasta As String,
                                                           ByRef JornadasBorradasDesde As String, ByRef JornadasBorradasHasta As String) As Boolean

        If (Modelo = ImpresoraFiscalModelo.U220AFII) Then
            Throw New InvalidOperationException("Comando no implementado para el modelo de impresora seleccionada")
        Else
            Return InformacionMemoriaTransacciones_T900FA(DescargarCintaTestigoDigitalDesde, DescargarCintaTestigoDigitalHasta,
                                                                       DescargarDuplicadosTipoADesde, DescargarDuplicadosTipoAHasta,
                                                                       DescargarResumenTotalesDesde, DescargarResumenTotalesHasta,
                                                                       JornadasDescargadasCompletamenteDesde, JornadasDescargadasCompletamenteHasta,
                                                                       JornadasBorradasDesde, JornadasBorradasHasta)
        End If
    End Function

    Private Function InformacionMemoriaTransacciones_T900FA(ByRef DescargarCintaTestigoDigitalDesde As String, ByRef DescargarCintaTestigoDigitalHasta As String,
                                                           ByRef DescargarDuplicadosTipoADesde As String, ByRef DescargarDuplicadosTipoAHasta As String,
                                                           ByRef DescargarResumenTotalesDesde As String, ByRef DescargarResumenTotalesHasta As String,
                                                           ByRef JornadasDescargadasCompletamenteDesde As String, ByRef JornadasDescargadasCompletamenteHasta As String,
                                                           ByRef JornadasBorradasDesde As String, ByRef JornadasBorradasHasta As String)
        Dim bAnswer As Boolean = False
        bAnswer = oEpsonFP.AddDataField(Chr(&H9) + Chr(&H15))
        If bAnswer Then bAnswer = oEpsonFP.AddDataField(Chr(&H0) + Chr(&H0))
        If bAnswer Then bAnswer = oEpsonFP.SendCommand()
        FPDelay()

        DescargarCintaTestigoDigitalDesde = oEpsonFP.GetExtraField(1)
        DescargarCintaTestigoDigitalHasta = oEpsonFP.GetExtraField(2)
        DescargarDuplicadosTipoADesde = oEpsonFP.GetExtraField(3)
        DescargarDuplicadosTipoAHasta = oEpsonFP.GetExtraField(4)
        DescargarResumenTotalesDesde = oEpsonFP.GetExtraField(5)
        DescargarResumenTotalesHasta = oEpsonFP.GetExtraField(6)
        JornadasDescargadasCompletamenteDesde = oEpsonFP.GetExtraField(7)
        JornadasDescargadasCompletamenteHasta = oEpsonFP.GetExtraField(8)
        JornadasBorradasDesde = oEpsonFP.GetExtraField(9)
        JornadasBorradasHasta = oEpsonFP.GetExtraField(10)

        EvaluarCodigoDeError()
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

    Private Sub EvaluarCodigoDeError()
        LogHelper.WriteLog(String.Format("INFO Metodo: EvaluarCodigoDeError ReturnCode'{0}' FiscalStatus'{1}' PrinterStatus'{2}'", ReturnCode(), FiscalStatus(), PrinterStatus))
        Select Case ReturnCode()
            Case "0801"
                Throw New InvalidOperationException("Cod. Error 0801 Requiere período de actividades iniciado")
            Case "0802"
                Throw New InvalidOperationException("Cod. Error 0802 Require un Cierre Z")
            Case "0803"
                Throw New InvalidOperationException("Cod. Error 0803 Memoria fiscal llena")
            Case "0804"
                Throw New InvalidOperationException("Cod. Error 0804 Requiere jornada fiscal abierta")
            Case "0807"
                Throw New InvalidOperationException("Cod. Error 0807 Período auditado sin datos")
            Case "0808"
                Throw New InvalidOperationException("Cod. Error 0808 Rango auditado inválido")
            Case "0809"
                Throw New InvalidOperationException("Cod. Error 0809 Restan datos por auditar/descargar")
            Case "080A"
                Throw New InvalidOperationException("Cod. Error 080A No hay más datos a descargar")
            Case "080B"
                Throw New InvalidOperationException("Cod. Error 080B No es posible abrir la jornada fiscal")
            Case "080C"
                Throw New InvalidOperationException("Cod. Error 080C No es posible cerrar la jornada fiscal")
            Case "0810"
                Throw New InvalidOperationException("Cod. Error 0810 Tipo de documento solicitado inválido")
            Case "0811"
                Throw New InvalidOperationException("Cod. Error 0811 Número de documento solicitado inválido")
            Case "0812"
                Throw New InvalidOperationException("Cod. Error 0812 Documento solicitado no existente")
            Case "0813"
                Throw New InvalidOperationException("Cod. Error 0813 La copia del documento solicitado fue borrada")
            Case "0814"
                Throw New InvalidOperationException("Cod. Error 0814 Tipo de documento no soportado")
            Case "0815"
                Throw New InvalidOperationException("Cod. Error 0815 Registrado para emitir documentos normales")
            Case "0816"
                Throw New InvalidOperationException("Cod. Error 0816 Registrado para emitir documentos M")
            Case "0817"
                Throw New InvalidOperationException("Cod. Error 0817 Falta descargar jornadas previas")
            Case "0818"
                Throw New InvalidOperationException("Cod. Error 0818 Sólo se puede imprimir el cambio una única vez dentro de la jornada")
            Case "0819"
                Throw New InvalidOperationException("Cod. Error 0819 Requiere que se encuentre establecida la línea de inicio de actividades")
        End Select
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        CerrarPuerto()
        GC.SuppressFinalize(Me)
    End Sub
End Class
