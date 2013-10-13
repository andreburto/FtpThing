Public Class Form1

    Private Function SetupWscp() As WinSCP
        Dim wscp As WinSCP = New WinSCP(Me.txtWinSCP.Text)
        wscp.UserId = txtUser.Text
        wscp.Password = txtPass.Text
        wscp.FtpType = cmbType.Text
        wscp.Domain = txtDomain.Text
        wscp.Fingerprint = txtFingerprint.Text
        Return wscp
    End Function

    Private Sub btnChooseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseFile.Click
        If Me.openFileDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtLocalFile.Text = Me.openFileDlg.FileName
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Button1.Enabled = False
        Dim wscp As WinSCP = Me.SetupWscp()
        If wscp.UploadFile(txtLocalFile.Text, txtRemoteDir.Text) = True Then
            MessageBox.Show("Success!")
        Else
            MessageBox.Show("Error.")
        End If
        Me.Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Button2.Enabled = False
        Dim wscp As WinSCP = Me.SetupWscp()
        Dim fl As String = ""
        For Each rf As RemoteFile In wscp.ListDir(txtRemoteDir.Text)
            fl += rf.FileName + vbCrLf
        Next
        MessageBox.Show(fl)
        Me.Button2.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Button3.Enabled = False
        Dim wscp As WinSCP = Me.SetupWscp()
        Dim parts() As String = txtLocalFile.Text.Split("\")
        If wscp.DelFile(parts.Last(), txtRemoteDir.Text) = True Then
            MessageBox.Show("File gone.")
        Else
            MessageBox.Show(wscp.ConsoleLog)
        End If
        Me.Button3.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Not dlgFolder.ShowDialog = Windows.Forms.DialogResult.OK Then Exit Sub
        If dlgFolder.SelectedPath.Length = 0 Then Exit Sub
        Button4.Enabled = False
        Dim wscp As WinSCP = Me.SetupWscp()
        wscp.LocalDir = dlgFolder.SelectedPath
        If wscp.SyncBoth() = True Then
            MessageBox.Show("Directory sync'd.")
        Else
            MessageBox.Show(wscp.ConsoleLog)
        End If
        Button4.Enabled = True
    End Sub

    Private Sub txtDomain_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDomain.TextChanged

    End Sub
End Class
