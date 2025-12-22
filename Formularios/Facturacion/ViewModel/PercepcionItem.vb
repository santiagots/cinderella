Imports Common.Core.Model
Namespace Formularios.Facturacion
    Public Class PercepcionItem

        Property PercepcionModel As Percepcion

        Public ReadOnly Property TipoCliente As String
            Get
                Return PercepcionModel.TipoCliente.ToString()
            End Get
        End Property
        Public ReadOnly Property TipoPercepcion As String
            Get
                Return PercepcionModel.TipoPercepcion.ToString()
            End Get
        End Property

        Public ReadOnly Property ProvinciaDescripcion As String
            Get
                Return If(PercepcionModel.Provincia Is Nothing, String.Empty, PercepcionModel.Provincia.Descripcion)
            End Get
        End Property
        Public ReadOnly Property Comcepto As String
            Get
                Return PercepcionModel.Comcepto
            End Get
        End Property
        Public ReadOnly Property MontoDesde As Decimal
            Get
                Return PercepcionModel.MontoDesde
            End Get
        End Property
        Public ReadOnly Property Alicuota As Decimal
            Get
                Return PercepcionModel.Alicuota
            End Get
        End Property
        Public ReadOnly Property Habilitado As String
            Get
                Return If(PercepcionModel.Habilitado, "Si", "No")
            End Get
        End Property

        Sub New(percepcion As Percepcion)
            PercepcionModel = percepcion
        End Sub
    End Class
End Namespace
