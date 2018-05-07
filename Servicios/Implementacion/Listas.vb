Imports System.ServiceModel
<ServiceBehavior(IncludeExceptionDetailInFaults:=True, UseSynchronizationContext:=False)>
Public Class Listas
    Implements ILista

    Public Function FormasPago() As List(Of KeyValuePair(Of Integer, String)) Implements ILista.FormasPago

        Negocio.Funciones.HayConexionInternet()

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

    Public Function TiposPrecio() As List(Of EntidadTipoPrecios) Implements ILista.TiposPrecio

        Negocio.Funciones.HayConexionInternet()

        Dim respuesta As List(Of EntidadTipoPrecios) = New List(Of EntidadTipoPrecios)
        Dim negrocioListaPago As Negocio.NegListasPrecio = New Negocio.NegListasPrecio()

        Dim dsListaPagos As DataSet = negrocioListaPago.ListadoListasPrecios()

        For Each dr As DataRow In dsListaPagos.Tables(0).Rows
            Dim item As EntidadTipoPrecios = New EntidadTipoPrecios()
            item.Id = dr("id_Lista")
            item.Descripcion = dr("ListaPrecio")
            item.Grupo = dr("id_ListaGrupo")
            respuesta.Add(item)
        Next

        Return respuesta
    End Function

    Public Function GruposPrecio() As List(Of KeyValuePair(Of Integer, String)) Implements ILista.GruposPrecio

        Negocio.Funciones.HayConexionInternet()

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

        Negocio.Funciones.HayConexionInternet()

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

        Negocio.Funciones.HayConexionInternet()

        Dim respuesta As List(Of KeyValuePair(Of Integer, String)) = New List(Of KeyValuePair(Of Integer, String))
        Dim negrocioEmpleados As Negocio.NegEmpleados = New Negocio.NegEmpleados()

        Dim dsListadoVendedores As DataSet = negrocioEmpleados.ListadoVendedoresSucursal(idSucursal)

        For Each dr As DataRow In dsListadoVendedores.Tables(0).Rows
            Dim item As KeyValuePair(Of Integer, String) = New KeyValuePair(Of Integer, String)(dr("id_Empleado"), dr("NombreCompleto"))
            respuesta.Add(item)
        Next

        Return respuesta
    End Function

    Public Function Configuracion() As EntidadConfiguracion Implements ILista.Configuracion

        Negocio.Funciones.HayConexionInternet()

        Dim entCofiguracion As EntidadConfiguracion = New EntidadConfiguracion()

        entCofiguracion.NombreSucursal = Host.NombreSucursal
        entCofiguracion.NombreGrupoPrecio = Host.NombreListaPrecio
        entCofiguracion.Id_Sucursal = Host.Id_Sucursal
        entCofiguracion.Id_GrupoPrecio = Host.Id_GrupoPrecio
        entCofiguracion.DecuentoClienteMinorista = Host.DecuentoClienteMinorista

        Return entCofiguracion

    End Function

End Class
