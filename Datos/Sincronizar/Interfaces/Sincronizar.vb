﻿Imports System.Data.SqlClient
Imports Datos

Public Interface Sincronizar
    Sub procesar(tabla As Tabla, valorBusqueda As String, conexionLocal As SqlConnection, conexionRemota As SqlConnection, transaccionRemota As SqlTransaction, transaccionLocal As SqlTransaction)
End Interface
