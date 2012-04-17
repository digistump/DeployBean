<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeployBean
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeployBean))
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepoList = New System.Windows.Forms.ListBox()
        Me.RepoLabel = New System.Windows.Forms.Label()
        Me.CommitList = New System.Windows.Forms.ListBox()
        Me.CommitLabel = New System.Windows.Forms.Label()
        Me.EnviroList = New System.Windows.Forms.ListBox()
        Me.EnviroLabel = New System.Windows.Forms.Label()
        Me.DeployCancelButton = New System.Windows.Forms.Button()
        Me.DeployButton = New System.Windows.Forms.Button()
        Me.DeployText = New System.Windows.Forms.TextBox()
        Me.DeployLabel = New System.Windows.Forms.Label()
        Me.DeployBeanLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeployVerifyLabel = New System.Windows.Forms.Label()
        Me.EnviroLink = New System.Windows.Forms.LinkLabel()
        Me.TrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenuStrip = Me.TrayMenu
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "DeployBean"
        Me.TrayIcon.Visible = True
        '
        'TrayMenu
        '
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.Size = New System.Drawing.Size(117, 48)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RepoList
        '
        Me.RepoList.BackColor = System.Drawing.Color.Silver
        Me.RepoList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RepoList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepoList.FormattingEnabled = True
        Me.RepoList.ItemHeight = 25
        Me.RepoList.Location = New System.Drawing.Point(12, 56)
        Me.RepoList.Name = "RepoList"
        Me.RepoList.Size = New System.Drawing.Size(501, 375)
        Me.RepoList.TabIndex = 1
        '
        'RepoLabel
        '
        Me.RepoLabel.AutoSize = True
        Me.RepoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepoLabel.Location = New System.Drawing.Point(7, 9)
        Me.RepoLabel.Name = "RepoLabel"
        Me.RepoLabel.Size = New System.Drawing.Size(178, 31)
        Me.RepoLabel.TabIndex = 2
        Me.RepoLabel.Text = "Repositories"
        '
        'CommitList
        '
        Me.CommitList.BackColor = System.Drawing.Color.Silver
        Me.CommitList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CommitList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommitList.FormattingEnabled = True
        Me.CommitList.ItemHeight = 25
        Me.CommitList.Location = New System.Drawing.Point(12, 56)
        Me.CommitList.Name = "CommitList"
        Me.CommitList.Size = New System.Drawing.Size(501, 375)
        Me.CommitList.TabIndex = 3
        Me.CommitList.Visible = False
        '
        'CommitLabel
        '
        Me.CommitLabel.AutoSize = True
        Me.CommitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommitLabel.Location = New System.Drawing.Point(7, 9)
        Me.CommitLabel.Name = "CommitLabel"
        Me.CommitLabel.Size = New System.Drawing.Size(128, 31)
        Me.CommitLabel.TabIndex = 4
        Me.CommitLabel.Text = "Commits"
        Me.CommitLabel.Visible = False
        '
        'EnviroList
        '
        Me.EnviroList.BackColor = System.Drawing.Color.Silver
        Me.EnviroList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EnviroList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnviroList.FormattingEnabled = True
        Me.EnviroList.ItemHeight = 25
        Me.EnviroList.Location = New System.Drawing.Point(13, 58)
        Me.EnviroList.Name = "EnviroList"
        Me.EnviroList.Size = New System.Drawing.Size(501, 375)
        Me.EnviroList.TabIndex = 6
        Me.EnviroList.Visible = False
        '
        'EnviroLabel
        '
        Me.EnviroLabel.AutoSize = True
        Me.EnviroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnviroLabel.Location = New System.Drawing.Point(7, 9)
        Me.EnviroLabel.Name = "EnviroLabel"
        Me.EnviroLabel.Size = New System.Drawing.Size(192, 31)
        Me.EnviroLabel.TabIndex = 7
        Me.EnviroLabel.Text = "Environments"
        Me.EnviroLabel.Visible = False
        '
        'DeployCancelButton
        '
        Me.DeployCancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeployCancelButton.Location = New System.Drawing.Point(78, 353)
        Me.DeployCancelButton.Name = "DeployCancelButton"
        Me.DeployCancelButton.Size = New System.Drawing.Size(177, 55)
        Me.DeployCancelButton.TabIndex = 8
        Me.DeployCancelButton.Text = "Cancel"
        Me.DeployCancelButton.UseVisualStyleBackColor = True
        Me.DeployCancelButton.Visible = False
        '
        'DeployButton
        '
        Me.DeployButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeployButton.Location = New System.Drawing.Point(271, 353)
        Me.DeployButton.Name = "DeployButton"
        Me.DeployButton.Size = New System.Drawing.Size(177, 55)
        Me.DeployButton.TabIndex = 9
        Me.DeployButton.Text = "Deploy"
        Me.DeployButton.UseVisualStyleBackColor = True
        Me.DeployButton.Visible = False
        '
        'DeployText
        '
        Me.DeployText.BackColor = System.Drawing.Color.Silver
        Me.DeployText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DeployText.Cursor = System.Windows.Forms.Cursors.Default
        Me.DeployText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeployText.Location = New System.Drawing.Point(13, 93)
        Me.DeployText.Multiline = True
        Me.DeployText.Name = "DeployText"
        Me.DeployText.ReadOnly = True
        Me.DeployText.Size = New System.Drawing.Size(501, 217)
        Me.DeployText.TabIndex = 10
        Me.DeployText.Visible = False
        '
        'DeployLabel
        '
        Me.DeployLabel.AutoSize = True
        Me.DeployLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeployLabel.Location = New System.Drawing.Point(6, 9)
        Me.DeployLabel.Name = "DeployLabel"
        Me.DeployLabel.Size = New System.Drawing.Size(121, 31)
        Me.DeployLabel.TabIndex = 11
        Me.DeployLabel.Text = "Release"
        Me.DeployLabel.Visible = False
        '
        'DeployBeanLabel
        '
        Me.DeployBeanLabel.BackColor = System.Drawing.Color.Transparent
        Me.DeployBeanLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeployBeanLabel.ForeColor = System.Drawing.Color.Black
        Me.DeployBeanLabel.Image = CType(resources.GetObject("DeployBeanLabel.Image"), System.Drawing.Image)
        Me.DeployBeanLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeployBeanLabel.Location = New System.Drawing.Point(417, 1)
        Me.DeployBeanLabel.Name = "DeployBeanLabel"
        Me.DeployBeanLabel.Size = New System.Drawing.Size(103, 54)
        Me.DeployBeanLabel.TabIndex = 12
        Me.DeployBeanLabel.Text = "DeployBean"
        Me.DeployBeanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(355, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 54)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Deploy  Bean"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeployVerifyLabel
        '
        Me.DeployVerifyLabel.AutoSize = True
        Me.DeployVerifyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeployVerifyLabel.Location = New System.Drawing.Point(12, 56)
        Me.DeployVerifyLabel.Name = "DeployVerifyLabel"
        Me.DeployVerifyLabel.Size = New System.Drawing.Size(373, 24)
        Me.DeployVerifyLabel.TabIndex = 14
        Me.DeployVerifyLabel.Text = "Please verify the following deployment:"
        Me.DeployVerifyLabel.Visible = False
        '
        'EnviroLink
        '
        Me.EnviroLink.AutoSize = True
        Me.EnviroLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnviroLink.Location = New System.Drawing.Point(13, 313)
        Me.EnviroLink.Name = "EnviroLink"
        Me.EnviroLink.Size = New System.Drawing.Size(106, 16)
        Me.EnviroLink.TabIndex = 15
        Me.EnviroLink.TabStop = True
        Me.EnviroLink.Text = "EnvironmentLink"
        Me.EnviroLink.Visible = False
        '
        'DeployBean
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(522, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.DeployVerifyLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EnviroLink)
        Me.Controls.Add(Me.DeployButton)
        Me.Controls.Add(Me.DeployCancelButton)
        Me.Controls.Add(Me.EnviroLabel)
        Me.Controls.Add(Me.CommitLabel)
        Me.Controls.Add(Me.RepoLabel)
        Me.Controls.Add(Me.DeployText)
        Me.Controls.Add(Me.DeployBeanLabel)
        Me.Controls.Add(Me.RepoList)
        Me.Controls.Add(Me.CommitList)
        Me.Controls.Add(Me.EnviroList)
        Me.Controls.Add(Me.DeployLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeployBean"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.TrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents TrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepoList As System.Windows.Forms.ListBox
    Friend WithEvents RepoLabel As System.Windows.Forms.Label
    Friend WithEvents CommitList As System.Windows.Forms.ListBox
    Friend WithEvents CommitLabel As System.Windows.Forms.Label
    Friend WithEvents EnviroList As System.Windows.Forms.ListBox
    Friend WithEvents EnviroLabel As System.Windows.Forms.Label
    Friend WithEvents DeployCancelButton As System.Windows.Forms.Button
    Friend WithEvents DeployButton As System.Windows.Forms.Button
    Friend WithEvents DeployText As System.Windows.Forms.TextBox
    Friend WithEvents DeployLabel As System.Windows.Forms.Label
    Friend WithEvents DeployBeanLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DeployVerifyLabel As System.Windows.Forms.Label
    Friend WithEvents EnviroLink As System.Windows.Forms.LinkLabel

End Class
