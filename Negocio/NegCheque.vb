Imports Entidades
Imports System.Data.SqlClient
Imports Datos

Public Class NegCheque


    'Funcion que inserta un nuevo registro en la tabla CHEQUES.
    Public Shared Function AltaCheque(ByVal Cheque As Entidades.Cheque) As Integer
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim ClsFunciones As New Funciones
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim clsDatos As New Datos.Conexion
        Dim idCheque As Integer
        Dim dsCheques As DataSet
        Dim Cheques As List(Of Cheque) = New List(Of Cheque)

        Try
            'Conecto a la bdd.
            If (HayInternet) Then
                dsCheques = clsDatos.ConsultarBaseRemoto("execute sp_Cheques_Consulta_Librados_Cheque_Banco @Libreador='" & Cheque.LibradorNombre & "', @NumeroCheque=" & Cheque.NumeroCheque.ToString & ", @IdBanco=" & Cheque.BancoEmisorId.ToString)
            Else
                dsCheques = clsDatos.ConsultarBaseLocal("execute sp_Cheques_Consulta_Librados_Cheque_Banco @Libreador='" & Cheque.LibradorNombre & "', @NumeroCheque=" & Cheque.NumeroCheque.ToString & ", @IdBanco=" & Cheque.BancoEmisorId.ToString)
            End If

            If dsCheques.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In dsCheques.Tables(0).Rows
                    Cheques.Add(GetChequeFromRow(row))
                Next
            End If

            'Si alguno de los queches ya ingresados tiene el mimo monto y fecha de vencimiento que el cheque que se esta cargando quiere decir que el cheque esta reingresando al sistema
            If (Cheques.Exists(Function(x) x.Importe = Cheque.Importe And x.FechaVencimiento.Date = Cheque.FechaVencimiento.Date)) Then
                Dim ChequeReingreso As Cheque = Cheques.Where(Function(x) x.Importe = Cheque.Importe And x.FechaVencimiento.Date = Cheque.FechaVencimiento.Date).First()

                'El cheque existe en la base entonces solo actualizo el estado a reingresado 
                ChequeReingreso.Estado = ChequeEstado.Reingresado

                cmd.Connection = clsDatos.ConectarLocal()
                ModificarCheque(ChequeReingreso, cmd)
                clsDatos.DesconectarLocal()

                If HayInternet Then
                    cmd = New SqlCommand()
                    cmd.Connection = clsDatos.ConectarRemoto()
                    ModificarCheque(ChequeReingreso, cmd)
                    clsDatos.DesconectarRemoto()
                End If
                Return ChequeReingreso.IdCheque
            Else
                'El cheque no existe en la base entonces lo doy de alta en la base con estado ingresado 
                cmd.Connection = clsDatos.ConectarLocal()
                idCheque = AltaCheque(Cheque, cmd)
                clsDatos.DesconectarLocal()

                If HayInternet Then
                    cmd = New SqlCommand()
                    cmd.Connection = clsDatos.ConectarRemoto()
                    idCheque = AltaCheque(Cheque, cmd)
                    clsDatos.DesconectarRemoto()
                Else

                End If
                'retorno valor
                Return idCheque
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function AltaCheque(Cheque As Cheque, ByRef cmd As SqlCommand)
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Cheques_Alta"
        With cmd.Parameters
            .AddWithValue("@BancoEmisorId", Cheque.BancoEmisorId)
            .AddWithValue("@ClienteId", Cheque.ClienteId)
            .AddWithValue("@ClienteNombre", Cheque.ClienteNombre)
            .AddWithValue("@FechaDesposito", Cheque.FechaDesposito)
            .AddWithValue("@FechaIngreso", Cheque.FechaIngreso)
            .AddWithValue("@FechaVencimiento", Cheque.FechaVencimiento)
            .AddWithValue("@Importe", Cheque.Importe)
            .AddWithValue("@LibradorId", Cheque.LibradorId)
            .AddWithValue("@LibradorNombre", Cheque.LibradorNombre)
            .AddWithValue("@MarcaFacturado", Cheque.MarcaFacturado)
            .AddWithValue("@NumeroCheque", Cheque.NumeroCheque)
            .AddWithValue("@NumeroOrden", Cheque.NumeroOrden)
            .AddWithValue("@SucursalId", Cheque.SucursalId)
        End With

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@IdCheque", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
    End Function

    'Funcion que inserta un nuevo registro en la tabla CHEQUES.
    Public Shared Function ModificacionCheque(ByVal Cheque As Entidades.Cheque) As String
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim ClsFunciones As New Funciones
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim clsDatos As New Datos.Conexion
        Dim msg As String = ""

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = ModificarCheque(Cheque, cmd)
            clsDatos.DesconectarLocal()

            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = ModificarCheque(Cheque, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return msg
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function ModificarCheque(Cheque As Cheque, ByRef cmd As SqlCommand) As String
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Cheques_Modificacion"
        With cmd.Parameters
            .AddWithValue("@BancoEmisorId", Cheque.BancoEmisorId)
            .AddWithValue("@ClienteId", Cheque.ClienteId)
            .AddWithValue("@ClienteNombre", Cheque.ClienteNombre)
            .AddWithValue("@DetalleSalida", If(Cheque.DetalleSalida Is Nothing, DBNull.Value, Cheque.DetalleSalida))
            .AddWithValue("@FechaDesposito", Cheque.FechaDesposito)
            .AddWithValue("@FechaIngreso", Cheque.FechaIngreso)
            .AddWithValue("@FechaSalida", If(Cheque.FechaSalida.HasValue, Cheque.FechaSalida, DBNull.Value))
            .AddWithValue("@FechaVencimiento", Cheque.FechaVencimiento)
            .AddWithValue("@Importe", Cheque.Importe)
            .AddWithValue("@LibradorId", Cheque.LibradorId)
            .AddWithValue("@LibradorNombre", Cheque.LibradorNombre)
            .AddWithValue("@MarcaFacturado", Cheque.MarcaFacturado)
            .AddWithValue("@NumeroCheque", Cheque.NumeroCheque)
            .AddWithValue("@NumeroOrden", Cheque.NumeroOrden)
            .AddWithValue("@SucursalId", Cheque.SucursalId)
            .AddWithValue("@Estado", Cheque.Estado)
            .AddWithValue("@DestinoSalida", Cheque.DestinoSalida)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    Public Shared Function EleminarCheque(ByVal idCheque As Integer) As String
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim ClsFunciones As New Funciones
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim clsDatos As New Datos.Conexion
        Dim msg As String = ""

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = EleminarCheque(idCheque, cmd)
            clsDatos.DesconectarLocal()

            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = EleminarCheque(idCheque, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return msg
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function EleminarCheque(idCheque As Integer, ByRef cmd As SqlCommand) As String
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Cheques_Eliminar"
        With cmd.Parameters
            .AddWithValue("@IdCheque", idCheque)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    Public Shared Function TraerCheque(ByVal NumeroOrden As Integer, ByVal SucursalId As Integer) As Cheque
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim ClsFunciones As New Funciones
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim clsDatos As New Datos.Conexion
        Dim msg As String = ""
        Dim dsCheques As DataSet
        Dim respuesta As Cheque = New Cheque()

        'Conecto a la bdd.
        If (HayInternet) Then
            dsCheques = clsDatos.ConsultarBaseRemoto("execute sp_Cheques_Consulta @NumeroOrden=" & NumeroOrden & ", @SucursalId=" & SucursalId)
        Else
            dsCheques = clsDatos.ConsultarBaseLocal("execute sp_Cheques_Consulta @NumeroOrden=" & NumeroOrden & ", @SucursalId=" & SucursalId)
        End If

        If dsCheques.Tables(0).Rows.Count > 0 Then
            respuesta = GetChequeFromRow(dsCheques.Tables(0).Rows(0))
        End If

        'retorno valor
        Return respuesta
    End Function

    Public Shared Function TraerCheques(ByVal SucursalId As Integer) As List(Of Cheque)
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim ClsFunciones As New Funciones
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim clsDatos As New Datos.Conexion
        Dim msg As String = ""
        Dim dsCheques As DataSet
        Dim respuesta As List(Of Cheque) = New List(Of Cheque)()

        'Conecto a la bdd.
        If (HayInternet) Then
            dsCheques = clsDatos.ConsultarBaseRemoto("execute sp_Cheques_Consulta_Sucursal @SucursalId=" & SucursalId)
        Else
            dsCheques = clsDatos.ConsultarBaseLocal("execute sp_Cheques_Consulta_Sucursal @SucursalId=" & SucursalId)
        End If

        If dsCheques.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dsCheques.Tables(0).Rows
                respuesta.Add(GetChequeFromRow(row))
            Next
        End If

        'retorno valor
        Return respuesta
    End Function

    Public Shared Function TraerCheque(ByVal ChequeId As Integer) As Cheque
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim ClsFunciones As New Funciones
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim clsDatos As New Datos.Conexion
        Dim msg As String = ""
        Dim dsCheques As DataSet
        Dim respuesta As Cheque = New Cheque()

        'Conecto a la bdd.
        If (HayInternet) Then
            dsCheques = clsDatos.ConsultarBaseRemoto("execute sp_Cheques_Consulta_Id @Id=" & ChequeId)
        Else
            dsCheques = clsDatos.ConsultarBaseLocal("execute sp_Cheques_Consulta_Id @Id=" & ChequeId)
        End If

        'retorno valor
        If (dsCheques.Tables(0).Rows.Count > 0) Then
            respuesta = GetChequeFromRow(dsCheques.Tables(0).Rows(0))
        End If
        Return respuesta
    End Function

    Public Shared Function TraerCheques() As List(Of Cheque)
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim ClsFunciones As New Funciones
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim clsDatos As New Datos.Conexion
        Dim msg As String = ""
        Dim dsCheques As DataSet
        Dim respuesta As List(Of Cheque) = New List(Of Cheque)()

        'Conecto a la bdd.
        If (HayInternet) Then
            dsCheques = clsDatos.ConsultarBaseRemoto("execute sp_Cheques_Listado")
        Else
            dsCheques = clsDatos.ConsultarBaseLocal("execute sp_Cheques_Listado")
        End If

        If dsCheques.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dsCheques.Tables(0).Rows
                respuesta.Add(GetChequeFromRow(row))
            Next
        End If

        'retorno valor
        Return respuesta
    End Function

    Public Shared Function TraerCheques(ByVal Librador As String, ByVal NumeroCheque As Integer, ByVal IdBanco As Integer) As List(Of Cheque)
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim ClsFunciones As New Funciones
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim clsDatos As New Datos.Conexion
        Dim msg As String = ""
        Dim dsCheques As DataSet
        Dim respuesta As List(Of Cheque) = New List(Of Cheque)()

        'Conecto a la bdd.
        If (HayInternet) Then
            dsCheques = clsDatos.ConsultarBaseRemoto("execute sp_Cheques_Consulta_Librados_Cheque_Banco @Libreador='" & Librador & "', @NumeroCheque=" & NumeroCheque.ToString & ", @IdBanco=" & IdBanco.ToString)
        Else
            dsCheques = clsDatos.ConsultarBaseLocal("execute sp_Cheques_Consulta_Librados_Cheque_Banco @Libreador='" & Librador & "', @NumeroCheque=" & NumeroCheque.ToString & ", @IdBanco=" & IdBanco.ToString)
        End If

        If dsCheques.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dsCheques.Tables(0).Rows
                respuesta.Add(GetChequeFromRow(row))
            Next
        End If

        'retorno valor
        Return respuesta
    End Function

    Private Shared Function GetChequeFromRow(ByVal row As DataRow) As Entidades.Cheque
        Dim cheque As Cheque = New Cheque
        cheque.IdCheque = row.Item("id_Cheque").ToString
        cheque.BancoEmisorId = row.Item("BancoEmisorId").ToString
        cheque.ClienteId = row.Item("ClienteId").ToString
        cheque.ClienteNombre = row.Item("ClienteNombre").ToString
        cheque.DetalleSalida = row.Item("DetalleSalida").ToString
        cheque.FechaDesposito = row.Item("FechaDesposito").ToString
        cheque.FechaIngreso = row.Item("FechaIngreso").ToString

        If (Not row.Item("FechaSalida") Is DBNull.Value) Then
            cheque.FechaSalida = row.Item("FechaSalida").ToString
        End If

        cheque.DetalleSalida = row.Item("DetalleSalida").ToString
        cheque.FechaVencimiento = row.Item("FechaVencimiento").ToString
        cheque.Importe = row.Item("Importe").ToString
        cheque.LibradorId = row.Item("LibradorId").ToString
        cheque.LibradorNombre = row.Item("LibradorNombre").ToString
        cheque.MarcaFacturado = row.Item("MarcaFacturado").ToString
        cheque.NumeroCheque = row.Item("NumeroCheque").ToString
        cheque.NumeroOrden = row.Item("NumeroOrden").ToString
        cheque.SucursalId = row.Item("SucursalId").ToString
        cheque.Estado = row.Item("Estado").ToString
        cheque.DestinoSalida = row.Item("DestinoSalida").ToString
        Return cheque
    End Function

End Class
