Public Enum ImpresoraFiscalModelo
    U220AFII = 0
    T900FA = 1
End Enum

Public Class ControladorFiscal

    Public Property MODELO As ImpresoraFiscalModelo
    Public Property NCOMP1 As String
    Public Property NCOMP2 As String
    Public Property DCOMP1 As String
    Public Property DCOMP2 As String
    Public Property DCOMP3 As String
    Public Property DE1 As String
    Public Property DE2 As String
    Public Property DE3 As String
    Public Property DE4 As String
    Public Property DPPAL As String
    Public Property CANTIDAD As String
    Public Property PUNITARIO As String
    Public Property TIVA As String
    Public Property IIF As String
    Public Property IIP As String
    Public Property COLAR1 As String
    Public Property COLAR2 As String
    Public Property COLAR3 As String
    Public Property CUIT As String
    Public Property NCUIT As String
    Public Property RI As String
    Public Property LREMITO1 As String
    Public Property LREMITO2 As String
    Public Property LREMITO3 As String
    Public Property COMPROBANTEORIGEN As String
    Public Property UnidadReferianciaMTX As String
    Public Property CodigoItemMTX As String
    Public Property CodigoItem As String
    Public Property CodigoUnidadMedida As String
    Public Property CodigoCondicionIva As String
    Public Property TasaIVADescuentoAjuste As String
    Public Property CondicionIVADescuentoAjuste As String

End Class
