Imports System
Imports System.DateTime

Public Class RemoteFile

    Private _fileName As String = ""
    Private _mdate As String = ""

    Public ReadOnly Property FileName() As String
        Get
            Return Me._fileName
        End Get
    End Property

    Public ReadOnly Property Modified() As String
        Get
            Return Me._mdate
        End Get
    End Property

    Public ReadOnly Property MTicks() As Long
        Get
            Dim md As Date = DateTime.Parse(Me._mdate)
            Return md.Ticks
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal fn As String, ByVal md As String)
        Me._fileName = fn
        Me._mdate = md
    End Sub
End Class
