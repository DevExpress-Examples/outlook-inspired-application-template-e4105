﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Namespace TaskManager.TaskDatabase

    Partial Public Class Person
        Inherits XPLiteObject

        Private fPersonId As Integer
        <Key(True)> _
        Public Property PersonId() As Integer
            Get
                Return fPersonId
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("PersonId", fPersonId, value)
            End Set
        End Property
        Private fFirstName As String
        Public Property FirstName() As String
            Get
                Return fFirstName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("FirstName", fFirstName, value)
            End Set
        End Property
        Private fLastName As String
        Public Property LastName() As String
            Get
                Return fLastName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("LastName", fLastName, value)
            End Set
        End Property
        Private fTitle As String
        Public Property Title() As String
            Get
                Return fTitle
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Title", fTitle, value)
            End Set
        End Property
        Private fAddress As String
        Public Property Address() As String
            Get
                Return fAddress
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Address", fAddress, value)
            End Set
        End Property
        Private fCity As String
        Public Property City() As String
            Get
                Return fCity
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("City", fCity, value)
            End Set
        End Property
        Private fState As String
        Public Property State() As String
            Get
                Return fState
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("State", fState, value)
            End Set
        End Property
        Private fZip As String
        Public Property Zip() As String
            Get
                Return fZip
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Zip", fZip, value)
            End Set
        End Property
        Private fCountry As String
        Public Property Country() As String
            Get
                Return fCountry
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Country", fCountry, value)
            End Set
        End Property
        Private fBirthDate As Date
        Public Property BirthDate() As Date
            Get
                Return fBirthDate
            End Get
            Set(ByVal value As Date)
                SetPropertyValue(Of Date)("BirthDate", fBirthDate, value)
            End Set
        End Property
        Private fHireDate As Date
        Public Property HireDate() As Date
            Get
                Return fHireDate
            End Get
            Set(ByVal value As Date)
                SetPropertyValue(Of Date)("HireDate", fHireDate, value)
            End Set
        End Property
        Private fImage As System.Drawing.Image
        <Size(SizeAttribute.Unlimited), ValueConverter(GetType(DevExpress.Xpo.Metadata.ImageValueConverter))> _
        Public Property Image() As System.Drawing.Image
            Get
                Return fImage
            End Get
            Set(ByVal value As System.Drawing.Image)
                SetPropertyValue(Of System.Drawing.Image)("Image", fImage, value)
            End Set
        End Property
        Private fColor As Integer
        Public Property Color() As Integer
            Get
                Return fColor
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Color", fColor, value)
            End Set
        End Property
        <PersistentAlias("[FirstName] + ' ' + [LastName]")> _
        Public ReadOnly Property Name() As String
            Get
                Return CStr(EvaluateAlias("Name"))
            End Get
        End Property
        <Association("TaskReferencesPerson", GetType(Task))> _
        Public ReadOnly Property Tasks() As XPCollection(Of Task)
            Get
                Return GetCollection(Of Task)("Tasks")
            End Get
        End Property
    End Class

End Namespace
