﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Public Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SistemaCinderella.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Los datos se han borrado de forma correcta..
        '''</summary>
        Public ReadOnly Property BorradoOk() As String
            Get
                Return ResourceManager.GetString("BorradoOk", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Seleccione una opción.
        '''</summary>
        Public ReadOnly Property ComboOpcionSelecioneUnaOpcion() As String
            Get
                Return ResourceManager.GetString("ComboOpcionSelecioneUnaOpcion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Todos.
        '''</summary>
        Public ReadOnly Property ComboOpcionTodos() As String
            Get
                Return ResourceManager.GetString("ComboOpcionTodos", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Debe completar todos los campos requeridos..
        '''</summary>
        Public ReadOnly Property ErrorCamposRequeridos() As String
            Get
                Return ResourceManager.GetString("ErrorCamposRequeridos", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El CUIL ingresado es incorrecto..
        '''</summary>
        Public ReadOnly Property ErrorCuitInvalido() As String
            Get
                Return ResourceManager.GetString("ErrorCuitInvalido", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Los datos se han guardado de forma correcta..
        '''</summary>
        Public ReadOnly Property GuardadoOk() As String
            Get
                Return ResourceManager.GetString("GuardadoOk", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
