﻿Public Class Perfiles

    Private id_Perfil_, Habilitado_ As Integer
    Private Descripcion_ As String
    Private Patentes_ As List(Of Patentes)

    Public Property id_Perfil() As Integer
        Get
            Return id_Perfil_
        End Get
        Set(ByVal value As Integer)
            id_Perfil_ = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
        End Set
    End Property

    Public Property Habilitado() As Integer
        Get
            Return Habilitado_
        End Get
        Set(ByVal value As Integer)
            Habilitado_ = value
        End Set
    End Property

    Public Property Patentes() As List(Of Patentes)
        Get
            Return Patentes_
        End Get
        Set(ByVal value As List(Of Patentes))
            Patentes_ = value
        End Set
    End Property

End Class
