Public Class NegFeriados
    Dim clsDatos As New Datos.Conexion

    'Inserta un nuevo registro en la tabla "Feriados".
    Sub AgregarFeriado(ByVal FechaCorta As String, ByVal FechaLarga As String)
        clsDatos.ModificarBaseRemoto("insert into FERIADOS(FechaCorta,FechaLarga) values ('" & FechaCorta & "','" & FechaLarga & "')")
    End Sub

    'Borra todos los registros de la tabla "Feriados".
    Sub BorrarFeriados()
        clsDatos.ModificarBaseRemoto("Delete from FERIADOS") 'Borra la tabla.
        clsDatos.ModificarBaseRemoto("DBCC CHECKIDENT('FERIADOS', RESEED, 1)") 'Pongo en cero el autoincrement.
    End Sub

    'Lista todos los feriados almacenados.
    Function ListadoFeriados() As DataSet
        Return clsDatos.ConsultarBaseRemoto("select * from FERIADOS")
    End Function
End Class
