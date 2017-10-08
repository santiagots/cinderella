Imports System.Data.SqlClient
Imports Datos

Public Interface Sincronizar
    Function ObtenerDatosLocales(ByRef Tabla As Tabla, valorBusqueda As String) As Boolean
    Sub GuardarDatos(Tabla As Tabla, conexion As SqlConnection, transaction As SqlTransaction)
    Sub sincronizarALocal(tabla As Tabla, valorBusqueda As String, conexionLocal As SqlConnection, conexionRemota As SqlConnection, transaccionRemota As SqlTransaction, transaccionLocal As SqlTransaction)
    Sub sincronizarARemota(tabla As Tabla, valorBusqueda As String, conexionLocal As SqlConnection, conexionRemota As SqlConnection, transaccionRemota As SqlTransaction, transaccionLocal As SqlTransaction)
End Interface
