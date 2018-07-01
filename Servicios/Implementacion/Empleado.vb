Imports System.ServiceModel

<ServiceBehavior(IncludeExceptionDetailInFaults:=True, UseSynchronizationContext:=False)>
Public Class Empleado
    Implements IEmpleado

    Public Function GetEmpleadoPorUsuarioID(IdUsuario As Integer) As EntidadEmpleado Implements IEmpleado.GetEmpleadoPorUsuarioID

        Dim empleadoNegocio As Negocio.NegEmpleados = New Negocio.NegEmpleados()

        Dim empleado As Entidades.Empleados = empleadoNegocio.TraerEmpleadoPorIdUsuario(IdUsuario)

        Dim respuesta As EntidadEmpleado = New EntidadEmpleado()

        respuesta.Apellido = empleado.Apellido
        respuesta.id_Empleado = empleado.id_Empleado
        respuesta.Nombre = empleado.Nombre

        Return respuesta
    End Function
End Class
