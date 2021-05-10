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


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("55, 77, 112")>  _
        Public Property Primary() As Global.System.Drawing.Color
            Get
                Return CType(Me("Primary"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Primary") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("235, 238, 245")>  _
        Public Property Secondary() As Global.System.Drawing.Color
            Get
                Return CType(Me("Secondary"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Secondary") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("255, 128, 128")>  _
        Public Property Deleted() As Global.System.Drawing.Color
            Get
                Return CType(Me("Deleted"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Deleted") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("255, 192, 128")>  _
        Public Property Deactivated() As Global.System.Drawing.Color
            Get
                Return CType(Me("Deactivated"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Deactivated") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Century Gothic, 8.25pt, style=Bold")>  _
        Public Property TableHeader() As Global.System.Drawing.Font
            Get
                Return CType(Me("TableHeader"),Global.System.Drawing.Font)
            End Get
            Set
                Me("TableHeader") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("50, 113, 240")>  _
        Public Property Selected() As Global.System.Drawing.Color
            Get
                Return CType(Me("Selected"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Selected") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Century Gothic, 8.25pt")>  _
        Public Property Font() As Global.System.Drawing.Font
            Get
                Return CType(Me("Font"),Global.System.Drawing.Font)
            End Get
            Set
                Me("Font") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Century Gothic, 9.75pt, style=Bold")>  _
        Public Property ButtonFont() As Global.System.Drawing.Font
            Get
                Return CType(Me("ButtonFont"),Global.System.Drawing.Font)
            End Get
            Set
                Me("ButtonFont") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Century Gothic, 20.25pt, style=Bold")>  _
        Public Property Header1() As Global.System.Drawing.Font
            Get
                Return CType(Me("Header1"),Global.System.Drawing.Font)
            End Get
            Set
                Me("Header1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Century Gothic, 18pt, style=Bold")>  _
        Public Property Header2() As Global.System.Drawing.Font
            Get
                Return CType(Me("Header2"),Global.System.Drawing.Font)
            End Get
            Set
                Me("Header2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Century Gothic, 15.75pt, style=Bold")>  _
        Public Property Header3() As Global.System.Drawing.Font
            Get
                Return CType(Me("Header3"),Global.System.Drawing.Font)
            End Get
            Set
                Me("Header3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Century Gothic, 14.25pt, style=Bold")>  _
        Public Property Header4() As Global.System.Drawing.Font
            Get
                Return CType(Me("Header4"),Global.System.Drawing.Font)
            End Get
            Set
                Me("Header4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Century Gothic, 12pt, style=Bold")>  _
        Public Property Header5() As Global.System.Drawing.Font
            Get
                Return CType(Me("Header5"),Global.System.Drawing.Font)
            End Get
            Set
                Me("Header5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Century Gothic, 6.75pt")>  _
        Public Property Substring() As Global.System.Drawing.Font
            Get
                Return CType(Me("Substring"),Global.System.Drawing.Font)
            End Get
            Set
                Me("Substring") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("188, 222, 232")>  _
        Public Property Editable() As Global.System.Drawing.Color
            Get
                Return CType(Me("Editable"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Editable") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("128, 255, 128")>  _
        Public Property Available() As Global.System.Drawing.Color
            Get
                Return CType(Me("Available"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Available") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("255, 192, 128")>  _
        Public Property Occupied() As Global.System.Drawing.Color
            Get
                Return CType(Me("Occupied"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Occupied") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("255, 128, 128")>  _
        Public Property Unavailable() As Global.System.Drawing.Color
            Get
                Return CType(Me("Unavailable"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Unavailable") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Brgy_36_MIS.My.MySettings
            Get
                Return Global.Brgy_36_MIS.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
