Imports System.Threading.Tasks
Imports Ventas.Core.Model.VentaAggregate
Imports Ventas.Core.Enum

Namespace Formularios.SucursalSaldo

    Public Class frmCierreCajaViewModel
        Inherits Comunes.Common

        Private NegUsuarios As New Negocio.Usuario
        Private IdSucursal As Integer
        Private IdCierreCaja As Long

        Private CierreCaja As CierreCaja

        Public Property Fecha As DateTime

        Public Property Estado As CierreCajaEstado?

        Public Property Situacion As CierreCajaSituacion?

        Public Property Monto As Decimal

        Public Property Diferencia As Decimal

        Public Property NombreUsuarioCierre As String

        Public Property NombreUsuarioReabre As String

        Public Property Comentario As String

        Public ReadOnly Property HabilitarRegistrar As Boolean
            Get
                Return Fecha.Date = DateTime.Now.Date Or (Fecha.Date >= DateTime.Now.AddDays(-1).Date AndAlso CierreCaja <> Nothing)
            End Get
        End Property

        Sub New(idSucursal As Integer, fecha As DateTime)
            Me.IdSucursal = idSucursal
            Me.Fecha = fecha
        End Sub

        Public Async Function ObtenerAsync() As Task
            CierreCaja = Await Task.Run(Function() Servicio.ObtenerCierreCaja(IdSucursal, Me.Fecha))

            If (CierreCaja <> Nothing) Then
                Dim usuarioCierre As Entidades.Usuario = Await Task.Run(Function() NegUsuarios.TraerUsuario(CierreCaja.IdUsuarioCierre))
                NombreUsuarioCierre = $"{usuarioCierre.Apellido}, {usuarioCierre.Nombre}"

                If (CierreCaja.IdUsuarioAbre.HasValue) Then
                    Dim usuarioCajaAbre As Entidades.Usuario = Await Task.Run(Function() NegUsuarios.TraerUsuario(CierreCaja.IdUsuarioAbre.Value))
                    NombreUsuarioReabre = $"{usuarioCajaAbre.Apellido}, {usuarioCajaAbre.Nombre}"
                End If

                Fecha = CierreCaja.Fecha
                Estado = CierreCaja.Estado
                Situacion = CierreCaja.Situacion
                Monto = CierreCaja.Monto
                Diferencia = CierreCaja.Diferencia
                Comentario = CierreCaja.Comentarios
            Else
                Estado = CierreCajaEstado.Abierta
                Situacion = Nothing
                Monto = 0
                Diferencia = 0
                Comentario = String.Empty
                NombreUsuarioCierre = String.Empty
                NombreUsuarioReabre = String.Empty
            End If

            NotifyPropertyChanged(NameOf(Me.Fecha))
            NotifyPropertyChanged(NameOf(Me.Estado))
            NotifyPropertyChanged(NameOf(Me.Situacion))
            NotifyPropertyChanged(NameOf(Me.Monto))
            NotifyPropertyChanged(NameOf(Me.Diferencia))
            NotifyPropertyChanged(NameOf(Me.Comentario))
            NotifyPropertyChanged(NameOf(Me.NombreUsuarioCierre))
            NotifyPropertyChanged(NameOf(Me.NombreUsuarioReabre))
        End Function

        Public Async Function RegistrarAsync() As Task(Of Boolean)
            CierreCaja = Await Task.Run(Function() Servicio.ObtenerCierreCaja(IdSucursal, Fecha))
            If CierreCaja IsNot Nothing Then
                If (MessageBox.Show($"Está seguro que desea modificar el cierre de caja diaria con fecha {Fecha.ToShortDateString()}?", "Cierre de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then
                    Return False
                End If
                If (CierreCaja.Estado = CierreCajaEstado.Cerrada) Then
                    CierreCaja.Abrir(VariablesGlobales.objUsuario.id_Usuario)
                End If
                CierreCaja.Cerrar(VariablesGlobales.objUsuario.id_Usuario, Monto, Comentario, True, CierreCaja.Fecha)
                Await Task.Run(Sub() Servicio.ActualizarCierreCaja(CierreCaja))
                Return True
            Else
                If (MessageBox.Show($"Está seguro que desea cerrar la caja diaria con fecha {Fecha.ToShortDateString()}?", "Cierre de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes = DialogResult.No) Then
                    Return False
                End If
                Dim nuevoCierreCaja As CierreCaja = New CierreCaja(IdSucursal)
                nuevoCierreCaja.Cerrar(VariablesGlobales.objUsuario.id_Usuario, Monto, Comentario, False, DateTime.Now)
                Await Task.Run(Sub() Servicio.GuardarCierreCaja(nuevoCierreCaja))
                CierreCaja = nuevoCierreCaja
                Return True
            End If
        End Function
    End Class
End Namespace
