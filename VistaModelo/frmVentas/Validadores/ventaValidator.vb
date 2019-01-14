Imports FluentValidation


Namespace VistaModelo.frmVentas
    Public Class ventaValidator
        Inherits AbstractValidator(Of Venta)

        Public Sub New()
            Me.CascadeMode = CascadeMode.StopOnFirstFailure
            RuleFor(Function(x) x.Productos.Count).GreaterThan(0).WithMessage("No se encuentran productos cargados. Debe ingresar al menos un producto.")
            RuleFor(Function(x) x.Pagos.Count).GreaterThan(0).WithMessage("No se encuentran pagos registrados. Debe ingresar al menos un pago.")
            RuleFor(Function(x) x.VendedorSeleccionado).GreaterThan(0).WithMessage("No se encuentran un vendedor seleccionado. Debe seleccionar un vendedor.")
            RuleFor(Function(x) x.EncargadoSeleccionado).GreaterThan(0).WithMessage("No se encuentran un encargado seleccionado. Debe seleccionar un encargado.")
            RuleFor(Function(x) x.IdClienteMayorista).NotEmpty().When(Function(x) x.TipoClienteSeleccionado = Entidades.TipoCliente.Mayorista).WithMessage("No se encuentran un cliente seleccionado. Debe seleccionar un cliente.")
        End Sub
    End Class
End Namespace
