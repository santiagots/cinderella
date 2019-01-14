Imports FluentValidation

Namespace VistaModelo.frmVentas
    Public Class PagoValidator
        Inherits AbstractValidator(Of Venta)

        Public Sub New()
            Me.CascadeMode = CascadeMode.StopOnFirstFailure
            RuleFor(Function(x) x.FormaPagoSeleccionado).NotNull().WithMessage("Debe seleccionar una forma de pago.")
            RuleFor(Function(x) x.ListaBancoSeleccionado).GreaterThan(0).When(Function(x) x.FormaPagoSeleccionado = Entidades.FormaPago.TarjetaDebito OrElse Entidades.FormaPago.TarjetaCredito).WithMessage("Debe seleccionar un banco.")
            RuleFor(Function(x) x.ListaCuotaSeleccionado).GreaterThan(0).When(Function(x) x.ListaBancoSeleccionado > 0 AndAlso x.FormaPagoSeleccionado = Entidades.FormaPago.TarjetaCredito).WithMessage("Debe seleccionar una cantidad de cuotas.")
        End Sub

    End Class
End Namespace

