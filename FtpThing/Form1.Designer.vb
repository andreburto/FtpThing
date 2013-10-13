<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWinSCP = New System.Windows.Forms.TextBox()
        Me.txtRemoteDir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFingerprint = New System.Windows.Forms.TextBox()
        Me.btnChooseFile = New System.Windows.Forms.Button()
        Me.txtLocalFile = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.openFileDlg = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDomain = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WinSCP loaction:"
        '
        'txtWinSCP
        '
        Me.txtWinSCP.Location = New System.Drawing.Point(12, 25)
        Me.txtWinSCP.Name = "txtWinSCP"
        Me.txtWinSCP.Size = New System.Drawing.Size(364, 20)
        Me.txtWinSCP.TabIndex = 1
        Me.txtWinSCP.Text = "C:\Program Files (x86)\WinSCP\WinSCP.com"
        '
        'txtRemoteDir
        '
        Me.txtRemoteDir.Location = New System.Drawing.Point(12, 64)
        Me.txtRemoteDir.Name = "txtRemoteDir"
        Me.txtRemoteDir.Size = New System.Drawing.Size(146, 20)
        Me.txtRemoteDir.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Remote directory:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Type:"
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"ftp", "ftps", "sftp"})
        Me.cmbType.Location = New System.Drawing.Point(12, 103)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(69, 21)
        Me.cmbType.TabIndex = 4
        Me.cmbType.Text = "sftp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fingerprint:"
        '
        'txtFingerprint
        '
        Me.txtFingerprint.Location = New System.Drawing.Point(90, 103)
        Me.txtFingerprint.Name = "txtFingerprint"
        Me.txtFingerprint.Size = New System.Drawing.Size(286, 20)
        Me.txtFingerprint.TabIndex = 5
        '
        'btnChooseFile
        '
        Me.btnChooseFile.Location = New System.Drawing.Point(283, 138)
        Me.btnChooseFile.Name = "btnChooseFile"
        Me.btnChooseFile.Size = New System.Drawing.Size(93, 25)
        Me.btnChooseFile.TabIndex = 7
        Me.btnChooseFile.Text = "Choose a file"
        Me.btnChooseFile.UseVisualStyleBackColor = True
        '
        'txtLocalFile
        '
        Me.txtLocalFile.Location = New System.Drawing.Point(12, 143)
        Me.txtLocalFile.Name = "txtLocalFile"
        Me.txtLocalFile.Size = New System.Drawing.Size(265, 20)
        Me.txtLocalFile.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Local file:"
        '
        'openFileDlg
        '
        Me.openFileDlg.Filter = "All files (*.*)|*.*"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 223)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 15, 3, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(364, 31)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "UPLOAD FILE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "UserID:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(12, 182)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(146, 20)
        Me.txtUser.TabIndex = 8
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(230, 182)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(146, 20)
        Me.txtPass.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(227, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Password:"
        '
        'txtDomain
        '
        Me.txtDomain.Location = New System.Drawing.Point(164, 64)
        Me.txtDomain.Name = "txtDomain"
        Me.txtDomain.Size = New System.Drawing.Size(212, 20)
        Me.txtDomain.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(161, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Domain:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 261)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 15, 3, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(202, 31)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "LIST REMOTE FILES"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(220, 261)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 15, 3, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(156, 31)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "RM FILE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 300)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 15, 3, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(364, 31)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "SYNCHRONIZE DIRECTORY"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 337)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtDomain)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLocalFile)
        Me.Controls.Add(Me.btnChooseFile)
        Me.Controls.Add(Me.txtFingerprint)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRemoteDir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtWinSCP)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upload Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtWinSCP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFingerprint As System.Windows.Forms.TextBox
    Friend WithEvents btnChooseFile As System.Windows.Forms.Button
    Friend WithEvents txtLocalFile As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRemoteDir As System.Windows.Forms.TextBox
    Friend WithEvents openFileDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDomain As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dlgFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
