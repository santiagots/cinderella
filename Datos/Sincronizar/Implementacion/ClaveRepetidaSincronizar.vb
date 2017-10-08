Imports System.Data.SqlClient
Imports Datos

Public Class ClaveRepetidaSincronizar
    Implements Sincronizar

    Dim encripta As New ClsEncriptacion
    Dim clsDatos As New Datos.Conexion


    Private Function ObtenerDatosLocales(ByRef Tabla As Tabla, valorBusqueda As String) As Boolean Implements Sincronizar.ObtenerDatosLocales
        Dim Respuesta As IList(Of DataTable) = New List(Of DataTable)
        Dim tablaLocal As DataTable
        Dim tablaRemota As DataTable

        If (Not String.IsNullOrEmpty(Tabla.ColumnaSeleccion)) Then

            'Selecciono todas las filas de la base local 
            tablaLocal = CType(clsDatos.ConsultarBaseLocal(String.Format("select * from {0} where {1} = {2}", Tabla.Nombre, Tabla.ColumnaSeleccion, valorBusqueda)), DataSet).Tables(0)

            'Selecciono todas las filas de la base remota
            tablaRemota = CType(clsDatos.ConsultarBaseRemoto(String.Format("select * from {0} where {1} = {2}", Tabla.Nombre, Tabla.ColumnaSeleccion, valorBusqueda)), DataSet).Tables(0)
        Else

            'Selecciono todas las filas de la base local 
            tablaLocal = CType(clsDatos.ConsultarBaseLocal(String.Format("select * from {0}", Tabla.Nombre)), DataSet).Tables(0)

            'Selecciono todas las filas de la base remota
            tablaRemota = CType(clsDatos.ConsultarBaseRemoto(String.Format("select * from {0}", Tabla.Nombre)), DataSet).Tables(0)

        End If
        Dim ClavePrimaria As String = Tabla.ClavePrimaria

        'Obtengo un listado de todos los ID de la base remota
        Dim ListaIdBaseRemota As List(Of Integer) = tablaRemota.Rows.Cast(Of DataRow).Select(Function(x) CType(x(ClavePrimaria), Integer)).ToList()
        Dim ListaIdBaseLocal As List(Of Integer) = tablaLocal.Rows.Cast(Of DataRow).Select(Function(x) CType(x(ClavePrimaria), Integer)).ToList()

        'Si la base de datos remota tiene mas datos que la base de datos local no tengo que actualizar mis valores locales. Esta situacion solo se da cuando el sistema tiene datos remoto y por algun motivo la base de datos local esta bacia 
        If (ListaIdBaseRemota.Count > ListaIdBaseLocal.Count Or ListaIdBaseLocal.Count = 0) Then
            Return False
        End If

        'Obtengo el ultimo ID de la base remota
        Dim ultimoValor As Integer = ObtenerUltimoIdBaseRemota(Tabla.Nombre)

        'Recorro todas las rows de la base local
        For Each rowLocal As DataRow In tablaLocal.Rows
            'Si el ID de la base local no exite en la base remota quiere decir que esta row fue generada en modo offline
            If Not ListaIdBaseRemota.Contains(rowLocal(Tabla.ClavePrimaria)) Then

                Tabla.IdAcualizados.Add(New KeyValuePair(Of Integer, Integer)(rowLocal(Tabla.ClavePrimaria), ultimoValor))

                'Por lo tanto tengo que actualizar su ID con el ultimo ID de la base remota
                rowLocal(Tabla.ClavePrimaria) = ultimoValor
                ultimoValor += 1
            End If
        Next

        Tabla.DatosSincronizar = tablaLocal

        'Recorro todas las tablas relacionadas a la actualizada para actualizar sus IDs y claves foraneas
        For Each tablaForanea As Tabla In Tabla.TablaRelacionada
            ActualizarClavesForaneas(ListaIdBaseLocal, ListaIdBaseRemota, Tabla.IdAcualizados, tablaForanea)
        Next

        Return True

    End Function

    Private Sub ActualizarClavesForaneas(IdForaneosLocal As List(Of Integer), IdForaneosRemota As List(Of Integer), IdActualizados As IList(Of KeyValuePair(Of Integer, Integer)), ByRef TablaForanea As Tabla)

        'Selecciono todas las filas de la base local 
        Dim tablaForaneaLocal As DataTable
        If (IdForaneosLocal.Count = 0) Then
            tablaForaneaLocal = CType(clsDatos.ConsultarBaseLocal(String.Format("select * from {0}", TablaForanea.Nombre)), DataSet).Tables(0)
        Else
            tablaForaneaLocal = CType(clsDatos.ConsultarBaseLocal(String.Format("select * from {0} where {1} in ({2})", TablaForanea.Nombre, TablaForanea.ColumnaSeleccion, String.Join(",", IdForaneosLocal))), DataSet).Tables(0)
        End If

        'Selecciono todas las filas de la base remota
        Dim tablaForaneaRemota As DataTable
        If (IdForaneosRemota.Count = 0) Then
            tablaForaneaRemota = CType(clsDatos.ConsultarBaseRemoto(String.Format("select * from {0}", TablaForanea.Nombre)), DataSet).Tables(0)
        Else
            tablaForaneaRemota = CType(clsDatos.ConsultarBaseRemoto(String.Format("select * from {0} where {1} in ({2})", TablaForanea.Nombre, TablaForanea.ColumnaSeleccion, String.Join(",", IdForaneosRemota))), DataSet).Tables(0)
        End If

        Dim ClavePrimaria As String = TablaForanea.ClavePrimaria

        'Obtengo un listado de todos los ID de la base remota
        Dim tablaForaneaRemotaListaPrimariKey As List(Of Integer) = tablaForaneaRemota.Rows.Cast(Of DataRow).Select(Function(x) CType(x(ClavePrimaria), Integer)).ToList()

        'Obtengo el ultimo ID de la base remota
        Dim ultimoValor As Integer = ObtenerUltimoIdBaseRemota(TablaForanea.Nombre)

        'Recorro todas las rows de la base local
        For Each rowLocal As DataRow In tablaForaneaLocal.Rows
            'Si el ID de la base local no exite en la base remota quiere decir que esta row fue generada en modo offline
            If Not tablaForaneaRemotaListaPrimariKey.Contains(rowLocal(TablaForanea.ClavePrimaria)) Then
                TablaForanea.IdAcualizados.Add(New KeyValuePair(Of Integer, Integer)(rowLocal(TablaForanea.ClavePrimaria), ultimoValor))
                'Por lo tanto tengo que actualizar su ID con el ultimo ID de la base remota
                rowLocal(TablaForanea.ClavePrimaria) = ultimoValor
                ultimoValor += 1
            End If
        Next

        'Actualizo las claves foranesa de las rows
        For Each claveForanea As String In TablaForanea.ClaveForanea
            For Each IdForaneoActualizado As KeyValuePair(Of Integer, Integer) In IdActualizados
                Dim rows As DataRow() = tablaForaneaLocal.Select(String.Format("{0} = {1}", claveForanea, IdForaneoActualizado.Key))
                For Each row As DataRow In rows
                    row(claveForanea) = IdForaneoActualizado.Value
                Next
            Next
        Next
        TablaForanea.DatosSincronizar = tablaForaneaLocal

    End Sub

    Private Sub GuardarDatos(Tabla As Tabla, conexion As SqlConnection, transaction As SqlTransaction) Implements Sincronizar.GuardarDatos
        Dim estado As Integer = 0

        'Selecciono todas las filas de la base remota
        Dim tablaRemota As DataTable = CType(clsDatos.ConsultarBaseRemoto(String.Format("select * from {0} where {1} = {2}", Tabla.Nombre, Tabla.ColumnaSeleccion, Tabla.valorBusqueda)), DataSet).Tables(0)

        Dim ClavePrimaria As String = Tabla.ClavePrimaria
        Dim ListaIdBaseRemota As List(Of Integer) = tablaRemota.Rows.Cast(Of DataRow).Select(Function(x) CType(x(ClavePrimaria), Integer)).ToList()

        Dim commandEliminoData As SqlCommand = New SqlCommand(String.Format("Delete from {0} where {1} = {2}", Tabla.Nombre, Tabla.ColumnaSeleccion, Tabla.valorBusqueda), conexion, transaction)
        commandEliminoData.ExecuteNonQuery()

        'copio los datos a base local
        Dim BulkCopy As New SqlBulkCopy(conexion, SqlBulkCopyOptions.KeepIdentity, transaction)
        BulkCopy.DestinationTableName = Tabla.Nombre


        BulkCopy.WriteToServer(Tabla.DatosSincronizar)

        'Recorro todas las tablas relacionadas para sincronizar
        For Each tablaForanea As Tabla In Tabla.TablaRelacionada

            SincronizarForanea(tablaForanea, ListaIdBaseRemota, conexion, transaction)
        Next
    End Sub

    Private Sub SincronizarForanea(TablaForanea As Tabla, IdForaneosRemota As List(Of Integer), conexion As SqlConnection, transaction As SqlTransaction)
        For Each claveForanea As String In TablaForanea.ClaveForanea
            If (IdForaneosRemota.Count <> 0) Then
                Dim commandEliminoData As SqlCommand = New SqlCommand(String.Format("Delete from {0} where {1} in ({2})", TablaForanea.Nombre, claveForanea, String.Join(",", IdForaneosRemota)), conexion, transaction)
                commandEliminoData.ExecuteNonQuery()
            End If
        Next

        'copio los datos a base local
        Using BulkCopy As New SqlBulkCopy(conexion, SqlBulkCopyOptions.KeepIdentity, transaction)
            BulkCopy.DestinationTableName = TablaForanea.Nombre
            BulkCopy.WriteToServer(TablaForanea.DatosSincronizar)
        End Using
    End Sub

    Function ObtenerUltimoIdBaseRemota(nombreTabla As String) As Integer
        Dim ds As DataSet
        ds = clsDatos.ConsultarBaseRemoto(String.Format("Select IDENT_CURRENT('{0}') as id", nombreTabla))

        If ds.Tables(0).Rows.Count = 1 And CInt(ds.Tables(0).Rows(0).Item("id")) > 0 Then
            Return ds.Tables(0).Rows(0).Item("id") + 1
        Else
            Return 1
        End If
    End Function

    Public Sub sincronizarALocal(tabla As Tabla, valorBusqueda As String, conexionLocal As SqlConnection, conexionRemota As SqlConnection, transaccionRemota As SqlTransaction, transaccionLocal As SqlTransaction) Implements Sincronizar.sincronizarALocal

    End Sub

    Public Sub sincronizarARemota(tabla As Tabla, valorBusqueda As String, conexionLocal As SqlConnection, conexionRemota As SqlConnection, transaccionRemota As SqlTransaction, transaccionLocal As SqlTransaction) Implements Sincronizar.sincronizarARemota
        If (tabla.Sincronizar.ObtenerDatosLocales(tabla, valorBusqueda)) Then
            tabla.Sincronizar.GuardarDatos(tabla, conexionRemota, transaccionRemota)
        End If
    End Sub
End Class
