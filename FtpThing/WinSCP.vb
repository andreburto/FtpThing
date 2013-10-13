Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Xml
Imports System.Xml.XPath

Public Class WinSCP

    Private _winSCP As String = ""
    Private _userid As String = ""
    Private _password As String = ""
    Private _type As String = ""
    Private _fingerprint As String = ""
    Private _domain As String = ""
    Private _port As String = ""
    Private _session As String = ""
    Private _openArgs As String = ""
    Private _remoteDir As String = ""
    Private _localFile As String = ""
    Private _localDir As String = ""
    Private _logFile As String = ""
    Private _consoleLog As String = ""

    Public Property UserId() As String
        Get
            Return Me._userid
        End Get
        Set(ByVal value As String)
            Me._userid = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return Me._password
        End Get
        Set(ByVal value As String)
            Me._password = value
        End Set
    End Property

    Public Property FtpType() As String
        Get
            Return Me._type
        End Get
        Set(ByVal value As String)
            Me._type = value
        End Set
    End Property

    Public Property Fingerprint() As String
        Get
            Return Me._fingerprint
        End Get
        Set(ByVal value As String)
            Me._fingerprint = value
        End Set
    End Property

    Public Property Domain() As String
        Get
            Return Me._domain
        End Get
        Set(ByVal value As String)
            Me._domain = value
        End Set
    End Property

    Public Property Port() As String
        Get
            Return Me._port
        End Get
        Set(ByVal value As String)
            Me._port = value
        End Set
    End Property

    Public Property Session() As String
        Get
            Return Me._session
        End Get
        Set(ByVal value As String)
            Me._session = value
        End Set
    End Property

    Public Property OpenArguments() As String
        Get
            Return Me._openArgs
        End Get
        Set(ByVal value As String)
            Me._openArgs = value
        End Set
    End Property

    Public Property RemoteDir() As String
        Get
            Return Me._remoteDir
        End Get
        Set(ByVal value As String)
            Me._remoteDir = value
        End Set
    End Property

    Public Property LocalFile() As String
        Get
            Return Me._localFile
        End Get
        Set(ByVal value As String)
            Me._localFile = value
        End Set
    End Property

    Public Property LocalDir() As String
        Get
            Return Me._localDir
        End Get
        Set(ByVal value As String)
            Me._localDir = value
        End Set
    End Property

    Public Property LogFile() As String
        Get
            Return Me._logFile
        End Get
        Set(ByVal value As String)
            Me._logFile = value
        End Set
    End Property

    Public ReadOnly Property ConsoleLog() As String
        Get
            Return Me._consoleLog
        End Get
    End Property

    Public Sub New()
        Me.New(Environment.CurrentDirectory + "\winscp.com", Environment.CurrentDirectory + "\log.xml")
    End Sub

    Public Sub New(ByVal winscp As String)
        Me.New(winscp, Environment.CurrentDirectory + "\log.xml")
    End Sub

    Public Sub New(ByVal winscp As String, ByVal log As String)
        Me._winSCP = winscp
        Me._logFile = log
    End Sub

#Region " ls "
    Public Function ListDir() As Collection
        Return Me.ListDir(Me._remoteDir)
    End Function

    Public Function ListDir(ByVal remotedir As String) As Collection
        Dim remoteList As Collection = New Collection
        Dim cmds As Collection = New Collection
        cmds.Add("option batch on")
        cmds.Add("option confirm on")
        cmds.Add("open " + CreateLogin())
        cmds.Add("cd " + remotedir)
        cmds.Add("ls")
        cmds.Add("exit")
        If ExecuteCmd(cmds) = True Then
            Dim doc As XPathDocument = New XPathDocument(Me._logFile)
            Dim nsman As XmlNamespaceManager = New XmlNamespaceManager(New NameTable)
            nsman.AddNamespace("w", "http://winscp.net/schema/session/1.0")
            Dim xpn As XPathNavigator = doc.CreateNavigator()
            Dim files As XPathNodeIterator = xpn.Select("//w:file", nsman)
            For Each f As XPathNavigator In files
                Dim fn As String = f.SelectSingleNode("w:filename/@value", nsman).Value
                Dim md As String = f.SelectSingleNode("w:modification/@value", nsman).Value
                If fn <> "." And fn <> ".." Then
                    remoteList.Add(New RemoteFile(fn, md))
                End If
            Next
        End If
        Return remoteList
    End Function
#End Region

#Region " open "
    Private Function CreateLogin() As String
        Dim retval As String = ""
        Dim bl As String = Me.BuildLogin()
        If bl.Length > 0 Then
            If Me._type.ToLower = "sftp" Then
                retval += "sftp://" + bl + " -hostkey=""" + Me._fingerprint + """"
            ElseIf Me._type.ToLower = "ftps" Then
                retval += "ftps://" + bl + " -implicit -certificate=""" + Me._fingerprint + """"
            ElseIf Me._type.ToLower = "scp" Then
                retval += "scp://" + bl + " -privatekey=" + Me._fingerprint
            Else
                retval += bl
            End If

            If Me._openArgs.Length > 0 Then
                retval += " " + Me._openArgs
            End If
        Else
            If Me._session.Length >= 0 Then
                retval = Me._session
            Else
                Me._consoleLog = "No session data was provided for login."
            End If
        End If
        Return retval
    End Function

    Private Function BuildLogin() As String
        Dim retval As String = ""
        If Me._userid.Length > 0 Then
            retval += Me._userid
        End If
        If Me._password.Length > 0 Then
            retval += ":" + Me._password
        End If
        If Me._domain.Length > 0 Then
            retval += "@" + Me._domain
        End If
        If Me._port.Length > 0 Then
            retval += ":" + Me._port
        End If
        Return retval
    End Function
#End Region

#Region " put "
    Public Function UploadFile() As Boolean
        Return Me.UploadFile(Me._localFile, Me._remoteDir)
    End Function

    Public Function UploadFile(ByVal f As String, ByVal path As String) As Boolean
        Dim loginString As String = CreateLogin()
        If Not loginString.Length > 0 Then Return False
        Dim cmds As Collection = New Collection
        cmds.Add("option batch on")
        cmds.Add("option confirm on")
        cmds.Add("open " + loginString)
        cmds.Add("cd " + Path)
        cmds.Add("put " + f)
        cmds.Add("exit")
        Return ExecuteCmd(cmds)
    End Function
#End Region

#Region " rm "
    Public Function DelFile(ByVal files() As String) As Boolean
        Return Me.DelFile(files, Me._remoteDir)
    End Function

    Public Function DelFile(ByVal files() As String, ByVal path As String) As Boolean
        Dim f As String = ""
        For Each temp As String In files
            f += " " + temp
        Next
        Return Me.DelFile(f, path)
    End Function

    Public Function DelFile(ByVal f As String) As Boolean
        Return Me.DelFile(f, Me._remoteDir)
    End Function

    Public Function DelFile(ByVal f As String, ByVal path As String) As Boolean
        Dim loginString As String = CreateLogin()
        If Not loginString.Length > 0 Then Return False
        Dim cmds As Collection = New Collection
        cmds.Add("option batch on")
        cmds.Add("option confirm on")
        cmds.Add("open " + loginString)
        cmds.Add("cd " + path)
        cmds.Add("rm " + f)
        cmds.Add("exit")
        Return ExecuteCmd(cmds)
    End Function
#End Region

    Public Function SyncLocal() As Boolean
        Return Me.Synchronize("local")
    End Function

    Public Function SyncRemote() As Boolean
        Return Me.Synchronize("remote")
    End Function

    Public Function SyncBoth() As Boolean
        Return Me.Synchronize("both")
    End Function

    Public Function Synchronize(ByVal type As String) As Boolean
        Dim loginString As String = CreateLogin()
        If Not loginString.Length > 0 Then Return False
        Dim cmds As Collection = New Collection
        cmds.Add("option batch on")
        cmds.Add("option confirm on")
        cmds.Add("open " + loginString)
        cmds.Add("synchronize " + type + " " + Me._localDir + " " + Me._remoteDir)
        cmds.Add("exit")
        Return ExecuteCmd(cmds)
    End Function

    Private Function GetResult() As Boolean
        Dim doc As XPathDocument = New XPathDocument(Me._logFile)
        Dim nsman As XmlNamespaceManager = New XmlNamespaceManager(New NameTable)
        nsman.AddNamespace("w", "http://winscp.net/schema/session/1.0")
        Dim xpn As XPathNavigator = doc.CreateNavigator()
        Dim success As String = xpn.SelectSingleNode("//w:result/@success", nsman).Value
        If success = "true" Then Return True Else Return False
    End Function

    Private Function ExecuteCmd(ByVal cmdlist As Collection) As Boolean
        Dim winscp As Process = New Process()
        winscp.StartInfo.FileName = Me._winSCP
        winscp.StartInfo.Arguments = "/log=" + Me._logFile
        winscp.StartInfo.UseShellExecute = False
        winscp.StartInfo.RedirectStandardInput = True
        winscp.StartInfo.RedirectStandardOutput = True
        winscp.StartInfo.CreateNoWindow = True
        winscp.Start()
        For Each c As String In cmdlist
            winscp.StandardInput.WriteLine(c)
        Next
        winscp.StandardInput.Close()
        Dim output As String = winscp.StandardOutput.ReadToEnd()
        winscp.WaitForExit()
        If Not winscp.ExitCode = 0 Then
            Me._consoleLog = output
            Return False
        End If
        winscp.Dispose()
        Return Me.GetResult()
    End Function
End Class