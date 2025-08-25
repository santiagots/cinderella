Imports System.ComponentModel
Imports Newtonsoft.Json

Namespace Formularios.Comun
    Public Class frmConfiguracionFacturacionImpuestosViewModel
        Inherits Comunes.Common

        Public Property Inpuestos As BindingList(Of FacturacionImpuestosViewModel) = New BindingList(Of FacturacionImpuestosViewModel)
        Public Property EncabezadoImpuestos As String
        Public Property HabilitarImpuestosSi As Boolean
        Public Property HabilitarImpuestosNo As Boolean
        Public Property IVADescripcion As String
        Public Property IVADiscirimiarSi As Boolean
        Public Property IVADiscirimiarNo As Boolean
        Public Property ImpuestoDescripcion As String
        Public Property ImpuestoPorcentaje As Decimal
        Public Property ImpuestoMonto As Decimal
        Public Property InpuestoSeleccionado As FacturacionImpuestosViewModel

        Friend Sub Inicializar()
            If Not String.IsNullOrEmpty(My.Settings.FacturaImpuestos) Then
                Inpuestos = JsonConvert.DeserializeObject(Of BindingList(Of FacturacionImpuestosViewModel))(My.Settings.FacturaImpuestos)
            End If
            HabilitarImpuestosSi = My.Settings.FacturaHabilitarImpuestos
            HabilitarImpuestosNo = Not HabilitarImpuestosSi
            EncabezadoImpuestos = My.Settings.FacturaEncabezadoImpuestos

            IVADiscirimiarSi = My.Settings.FacturaIVADiscirimiar
            IVADiscirimiarNo = Not IVADiscirimiarSi
            IVADescripcion = My.Settings.FacturaIVADescripcion

        End Sub

        Public Sub GuardarConfiguracion()
            My.Settings.FacturaImpuestos = JsonConvert.SerializeObject(Inpuestos)

            My.Settings.FacturaHabilitarImpuestos = HabilitarImpuestosSi
            My.Settings.FacturaEncabezadoImpuestos = EncabezadoImpuestos

            My.Settings.FacturaIVADiscirimiar = IVADiscirimiarSi
            My.Settings.FacturaIVADescripcion = IVADescripcion
            My.Settings.Save()
        End Sub

        Public Sub GuardarImpuesto()
            If (InpuestoSeleccionado IsNot Nothing) Then
                InpuestoSeleccionado.Descripcion = ImpuestoDescripcion
                InpuestoSeleccionado.Porcentaje = ImpuestoPorcentaje
                InpuestoSeleccionado.Monto = ImpuestoMonto
            Else
                Dim inpuesto As FacturacionImpuestosViewModel = New FacturacionImpuestosViewModel() With {
                    .Id = Inpuestos.Count,
                    .Descripcion = ImpuestoDescripcion,
                    .Porcentaje = ImpuestoPorcentaje,
                    .Monto = ImpuestoMonto}

                Inpuestos.Add(inpuesto)
            End If

            InpuestoSeleccionado = Nothing
            ImpuestoDescripcion = String.Empty
            ImpuestoPorcentaje = 0
            ImpuestoMonto = 0

            NotifyPropertyChanged(NameOf(Me.Inpuestos))
            NotifyPropertyChanged(NameOf(Me.ImpuestoDescripcion))
            NotifyPropertyChanged(NameOf(Me.ImpuestoPorcentaje))
            NotifyPropertyChanged(NameOf(Me.ImpuestoMonto))
        End Sub

        Friend Sub EliminarImpuesto(impuesto As FacturacionImpuestosViewModel)
            Dim inpuesto As FacturacionImpuestosViewModel = Inpuestos.FirstOrDefault(Function(x) x.Id = impuesto.Id)
            If inpuesto IsNot Nothing Then
                Inpuestos.Remove(inpuesto)
                NotifyPropertyChanged(NameOf(Me.Inpuestos))
            End If
        End Sub

        Friend Sub ModificarImpuesto(impuesto As FacturacionImpuestosViewModel)
            InpuestoSeleccionado = impuesto
            ImpuestoDescripcion = impuesto.Descripcion
            ImpuestoPorcentaje = impuesto.Porcentaje
            ImpuestoMonto = impuesto.Monto

            NotifyPropertyChanged(NameOf(Me.ImpuestoDescripcion))
            NotifyPropertyChanged(NameOf(Me.ImpuestoPorcentaje))
            NotifyPropertyChanged(NameOf(Me.ImpuestoMonto))
        End Sub

        Friend Sub Refrescar()
            If (HabilitarImpuestosNo) Then
                IVADiscirimiarSi = False
                IVADiscirimiarNo = True
            End If

            NotifyPropertyChanged(NameOf(Me.HabilitarImpuestosSi))
            NotifyPropertyChanged(NameOf(Me.HabilitarImpuestosNo))
            NotifyPropertyChanged(NameOf(Me.IVADiscirimiarSi))
            NotifyPropertyChanged(NameOf(Me.IVADiscirimiarNo))
        End Sub
    End Class
End Namespace
