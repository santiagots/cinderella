Imports Negocio
Imports Entidades
Imports System.ServiceModel

<ServiceBehavior(IncludeExceptionDetailInFaults:=True)>
Public Class Listas
    Implements ILista

    Public Function FormasPago() As List(Of KeyValuePair(Of Integer, String)) Implements ILista.FormasPago

        Dim respuesta As List(Of KeyValuePair(Of Integer, String)) = New List(Of KeyValuePair(Of Integer, String))
        Dim negocioTipoPago As Negocio.NegTipoPago = New Negocio.NegTipoPago()

        Dim dsTiposPago As DataSet = negocioTipoPago.ListadoTiposPagos()

        For Each dr As DataRow In dsTiposPago.Tables(0).Rows
            If (dr("Habilitado") = 1) Then
                Dim item As KeyValuePair(Of Integer, String) = New KeyValuePair(Of Integer, String)(dr("id_TipoPago"), dr("descripcion"))
                respuesta.Add(item)
            End If
        Next

        Return respuesta
    End Function

    Public Function TiposPrecio() As List(Of TipoPrecios) Implements ILista.TiposPrecio

        Dim respuesta As List(Of TipoPrecios) = New List(Of TipoPrecios)
        Dim negrocioListaPago As Negocio.NegListasPrecio = New Negocio.NegListasPrecio()

        Dim dsListaPagos As DataSet = negrocioListaPago.ListadoListasPrecios()

        For Each dr As DataRow In dsListaPagos.Tables(0).Rows
            Dim item As TipoPrecios = New TipoPrecios()
            item.Id = dr("id_Lista")
            item.Descripcion = dr("ListaPrecio")
            item.Grupo = dr("id_ListaGrupo")
            respuesta.Add(item)
        Next

        Return respuesta
    End Function

    Public Function GruposPrecio() As List(Of KeyValuePair(Of Integer, String)) Implements ILista.GruposPrecio

        Dim respuesta As List(Of KeyValuePair(Of Integer, String)) = New List(Of KeyValuePair(Of Integer, String))
        Dim negrocioListaPago As Negocio.NegListasPrecio = New Negocio.NegListasPrecio()

        Dim dsGrupoPrecios As DataSet = negrocioListaPago.ListadoGrupoPrecios()

        For Each dr As DataRow In dsGrupoPrecios.Tables(0).Rows
            Dim item As KeyValuePair(Of Integer, String) = New KeyValuePair(Of Integer, String)(dr("id_Lista"), dr("ListaPrecio"))
            respuesta.Add(item)
        Next

        Return respuesta
    End Function

    Public Function Sucursales() As List(Of KeyValuePair(Of Integer, String)) Implements ILista.Sucursales

        Dim respuesta As List(Of KeyValuePair(Of Integer, String)) = New List(Of KeyValuePair(Of Integer, String))
        Dim negrocioSucursales As Negocio.NegSucursales = New Negocio.NegSucursales()

        Dim dsListadoSucursales As DataSet = negrocioSucursales.ListadoSucursales()

        For Each dr As DataRow In dsListadoSucursales.Tables(0).Rows
            Dim item As KeyValuePair(Of Integer, String) = New KeyValuePair(Of Integer, String)(dr("id_Sucursal"), dr("Nombre"))
            respuesta.Add(item)
        Next

        Return respuesta
    End Function

    Public Function Vendedores(ByVal idSucursal As Integer) As List(Of KeyValuePair(Of Integer, String)) Implements ILista.Vendedores

        Dim respuesta As List(Of KeyValuePair(Of Integer, String)) = New List(Of KeyValuePair(Of Integer, String))
        Dim negrocioEmpleados As Negocio.NegEmpleados = New Negocio.NegEmpleados()

        Dim dsListadoVendedores As DataSet = negrocioEmpleados.ListadoVendedoresSucursal(idSucursal)

        For Each dr As DataRow In dsListadoVendedores.Tables(0).Rows
            Dim item As KeyValuePair(Of Integer, String) = New KeyValuePair(Of Integer, String)(dr("id_Empleado"), dr("NombreCompleto"))
            respuesta.Add(item)
        Next

        Return respuesta
    End Function
End Class
