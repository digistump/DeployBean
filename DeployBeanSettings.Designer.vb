<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeployBeanSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeployBeanSettings))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Account = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.AcctLabel = New System.Windows.Forms.Label()
        Me.UsrLabel = New System.Windows.Forms.Label()
        Me.PassLabel = New System.Windows.Forms.Label()
        Me.PassLabel2 = New System.Windows.Forms.Label()
        Me.ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.BeanstalkInfo = New System.Windows.Forms.Label()
        Me.StartWithWindows = New System.Windows.Forms.CheckBox()
        Me.About = New System.Windows.Forms.Label()
        Me.LicenseLabel = New System.Windows.Forms.Label()
        Me.GNULink = New System.Windows.Forms.LinkLabel()
        Me.WebLabel = New System.Windows.Forms.Label()
        Me.UpdatesLabel = New System.Windows.Forms.Label()
        Me.WebLinks = New System.Windows.Forms.LinkLabel()
        Me.UpdatesLink = New System.Windows.Forms.LinkLabel()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.HotkeyLabel = New System.Windows.Forms.Label()
        Me.Hotkey = New System.Windows.Forms.TextBox()
        Me.HotkeyCombo = New System.Windows.Forms.ComboBox()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.HotkeyTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddSecond = New System.Windows.Forms.Button()
        Me.ConfirmPass2Label = New System.Windows.Forms.Label()
        Me.ConfirmPassword2 = New System.Windows.Forms.TextBox()
        Me.Pass2Label = New System.Windows.Forms.Label()
        Me.Username2Label = New System.Windows.Forms.Label()
        Me.Account2Label = New System.Windows.Forms.Label()
        Me.Password2 = New System.Windows.Forms.TextBox()
        Me.Username2 = New System.Windows.Forms.TextBox()
        Me.Account2 = New System.Windows.Forms.TextBox()
        Me.SecondLabel = New System.Windows.Forms.Label()
        Me.ClearSecond = New System.Windows.Forms.Button()
        Me.AccountTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(691, 264)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(169, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(3, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(78, 26)
        Me.OK_Button.TabIndex = 9
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(87, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(79, 26)
        Me.Cancel_Button.TabIndex = 10
        Me.Cancel_Button.Text = "Cancel"
        '
        'Account
        '
        Me.Account.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account.Location = New System.Drawing.Point(149, 48)
        Me.Account.Name = "Account"
        Me.Account.Size = New System.Drawing.Size(271, 26)
        Me.Account.TabIndex = 1
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(149, 80)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(271, 26)
        Me.Username.TabIndex = 2
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(149, 112)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(271, 26)
        Me.Password.TabIndex = 3
        '
        'AcctLabel
        '
        Me.AcctLabel.AutoSize = True
        Me.AcctLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcctLabel.Location = New System.Drawing.Point(25, 51)
        Me.AcctLabel.Name = "AcctLabel"
        Me.AcctLabel.Size = New System.Drawing.Size(118, 20)
        Me.AcctLabel.TabIndex = 4
        Me.AcctLabel.Text = "Account Name:"
        '
        'UsrLabel
        '
        Me.UsrLabel.AutoSize = True
        Me.UsrLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsrLabel.Location = New System.Drawing.Point(56, 83)
        Me.UsrLabel.Name = "UsrLabel"
        Me.UsrLabel.Size = New System.Drawing.Size(87, 20)
        Me.UsrLabel.TabIndex = 5
        Me.UsrLabel.Text = "Username:"
        '
        'PassLabel
        '
        Me.PassLabel.AutoSize = True
        Me.PassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassLabel.Location = New System.Drawing.Point(61, 115)
        Me.PassLabel.Name = "PassLabel"
        Me.PassLabel.Size = New System.Drawing.Size(82, 20)
        Me.PassLabel.TabIndex = 6
        Me.PassLabel.Text = "Password:"
        '
        'PassLabel2
        '
        Me.PassLabel2.AutoSize = True
        Me.PassLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassLabel2.Location = New System.Drawing.Point(2, 147)
        Me.PassLabel2.Name = "PassLabel2"
        Me.PassLabel2.Size = New System.Drawing.Size(141, 20)
        Me.PassLabel2.TabIndex = 8
        Me.PassLabel2.Text = "Confirm Password:"
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassword.Location = New System.Drawing.Point(149, 144)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassword.Size = New System.Drawing.Size(271, 26)
        Me.ConfirmPassword.TabIndex = 4
        '
        'BeanstalkInfo
        '
        Me.BeanstalkInfo.AutoSize = True
        Me.BeanstalkInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeanstalkInfo.Location = New System.Drawing.Point(2, 9)
        Me.BeanstalkInfo.Name = "BeanstalkInfo"
        Me.BeanstalkInfo.Size = New System.Drawing.Size(297, 24)
        Me.BeanstalkInfo.TabIndex = 9
        Me.BeanstalkInfo.Text = "Beanstalk Account Information:"
        '
        'StartWithWindows
        '
        Me.StartWithWindows.AutoSize = True
        Me.StartWithWindows.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartWithWindows.Location = New System.Drawing.Point(149, 208)
        Me.StartWithWindows.Name = "StartWithWindows"
        Me.StartWithWindows.Size = New System.Drawing.Size(219, 24)
        Me.StartWithWindows.TabIndex = 8
        Me.StartWithWindows.Text = "Start DeployBean on Login"
        Me.StartWithWindows.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.About.AutoSize = True
        Me.About.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.About.Location = New System.Drawing.Point(3, 271)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(242, 16)
        Me.About.TabIndex = 11
        Me.About.Text = "Created by Erik Tylek Kettenburg - 2012"
        '
        'LicenseLabel
        '
        Me.LicenseLabel.AutoSize = True
        Me.LicenseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenseLabel.Location = New System.Drawing.Point(3, 331)
        Me.LicenseLabel.Name = "LicenseLabel"
        Me.LicenseLabel.Size = New System.Drawing.Size(361, 16)
        Me.LicenseLabel.TabIndex = 12
        Me.LicenseLabel.Text = "This is Open Source Software released under the GNU GPL"
        '
        'GNULink
        '
        Me.GNULink.ActiveLinkColor = System.Drawing.Color.Blue
        Me.GNULink.AutoSize = True
        Me.GNULink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GNULink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.GNULink.LinkColor = System.Drawing.Color.Blue
        Me.GNULink.Location = New System.Drawing.Point(12, 347)
        Me.GNULink.Name = "GNULink"
        Me.GNULink.Size = New System.Drawing.Size(219, 16)
        Me.GNULink.TabIndex = 13
        Me.GNULink.TabStop = True
        Me.GNULink.Text = "http://www.gnu.org/licenses/gpl.html"
        Me.GNULink.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'WebLabel
        '
        Me.WebLabel.AutoSize = True
        Me.WebLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebLabel.Location = New System.Drawing.Point(26, 287)
        Me.WebLabel.Name = "WebLabel"
        Me.WebLabel.Size = New System.Drawing.Size(43, 16)
        Me.WebLabel.TabIndex = 14
        Me.WebLabel.Text = "Web: "
        '
        'UpdatesLabel
        '
        Me.UpdatesLabel.AutoSize = True
        Me.UpdatesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatesLabel.Location = New System.Drawing.Point(3, 303)
        Me.UpdatesLabel.Name = "UpdatesLabel"
        Me.UpdatesLabel.Size = New System.Drawing.Size(66, 16)
        Me.UpdatesLabel.TabIndex = 15
        Me.UpdatesLabel.Text = "Updates: "
        '
        'WebLinks
        '
        Me.WebLinks.AutoSize = True
        Me.WebLinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebLinks.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.WebLinks.Location = New System.Drawing.Point(75, 287)
        Me.WebLinks.Name = "WebLinks"
        Me.WebLinks.Size = New System.Drawing.Size(127, 16)
        Me.WebLinks.TabIndex = 11
        Me.WebLinks.TabStop = True
        Me.WebLinks.Text = "http://digistump.com"
        '
        'UpdatesLink
        '
        Me.UpdatesLink.AutoSize = True
        Me.UpdatesLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatesLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.UpdatesLink.Location = New System.Drawing.Point(75, 303)
        Me.UpdatesLink.Name = "UpdatesLink"
        Me.UpdatesLink.Size = New System.Drawing.Size(247, 16)
        Me.UpdatesLink.TabIndex = 12
        Me.UpdatesLink.TabStop = True
        Me.UpdatesLink.Text = "http://github.com/digistump/DeployBean"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorLabel.Location = New System.Drawing.Point(146, 231)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(0, 16)
        Me.ErrorLabel.TabIndex = 18
        '
        'HotkeyLabel
        '
        Me.HotkeyLabel.AutoSize = True
        Me.HotkeyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotkeyLabel.Location = New System.Drawing.Point(80, 179)
        Me.HotkeyLabel.Name = "HotkeyLabel"
        Me.HotkeyLabel.Size = New System.Drawing.Size(63, 20)
        Me.HotkeyLabel.TabIndex = 19
        Me.HotkeyLabel.Text = "Hotkey:"
        '
        'Hotkey
        '
        Me.Hotkey.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hotkey.Location = New System.Drawing.Point(274, 176)
        Me.Hotkey.Name = "Hotkey"
        Me.Hotkey.ReadOnly = True
        Me.Hotkey.Size = New System.Drawing.Size(48, 26)
        Me.Hotkey.TabIndex = 6
        '
        'HotkeyCombo
        '
        Me.HotkeyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HotkeyCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotkeyCombo.FormattingEnabled = True
        Me.HotkeyCombo.Items.AddRange(New Object() {"", "Alt+", "Ctrl+", "Ctrl+Alt+", "Shift+", "Alt+Shift+", "Ctrl+Shift+", "Ctrl+Alt+Shift+", "Win", "Win+Alt", "Win+Ctrl", "Win+Ctrl+Alt", "Win+Shift", "Win+Shift+Alt", "Win+Shift+Ctrl"})
        Me.HotkeyCombo.Location = New System.Drawing.Point(149, 176)
        Me.HotkeyCombo.Name = "HotkeyCombo"
        Me.HotkeyCombo.Size = New System.Drawing.Size(121, 28)
        Me.HotkeyCombo.TabIndex = 5
        '
        'ClearBtn
        '
        Me.ClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.Location = New System.Drawing.Point(328, 176)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(92, 26)
        Me.ClearBtn.TabIndex = 7
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'HotkeyTip
        '
        Me.HotkeyTip.ToolTipTitle = "Hotkeys"
        '
        'AddSecond
        '
        Me.AddSecond.Location = New System.Drawing.Point(393, 9)
        Me.AddSecond.Name = "AddSecond"
        Me.AddSecond.Size = New System.Drawing.Size(27, 23)
        Me.AddSecond.TabIndex = 20
        Me.AddSecond.Text = "+"
        Me.AddSecond.UseVisualStyleBackColor = True
        '
        'ConfirmPass2Label
        '
        Me.ConfirmPass2Label.AutoSize = True
        Me.ConfirmPass2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPass2Label.Location = New System.Drawing.Point(427, 147)
        Me.ConfirmPass2Label.Name = "ConfirmPass2Label"
        Me.ConfirmPass2Label.Size = New System.Drawing.Size(141, 20)
        Me.ConfirmPass2Label.TabIndex = 28
        Me.ConfirmPass2Label.Text = "Confirm Password:"
        Me.ConfirmPass2Label.Visible = False
        '
        'ConfirmPassword2
        '
        Me.ConfirmPassword2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassword2.Location = New System.Drawing.Point(574, 144)
        Me.ConfirmPassword2.Name = "ConfirmPassword2"
        Me.ConfirmPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassword2.Size = New System.Drawing.Size(271, 26)
        Me.ConfirmPassword2.TabIndex = 25
        Me.ConfirmPassword2.Visible = False
        '
        'Pass2Label
        '
        Me.Pass2Label.AutoSize = True
        Me.Pass2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass2Label.Location = New System.Drawing.Point(486, 115)
        Me.Pass2Label.Name = "Pass2Label"
        Me.Pass2Label.Size = New System.Drawing.Size(82, 20)
        Me.Pass2Label.TabIndex = 27
        Me.Pass2Label.Text = "Password:"
        Me.Pass2Label.Visible = False
        '
        'Username2Label
        '
        Me.Username2Label.AutoSize = True
        Me.Username2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username2Label.Location = New System.Drawing.Point(481, 83)
        Me.Username2Label.Name = "Username2Label"
        Me.Username2Label.Size = New System.Drawing.Size(87, 20)
        Me.Username2Label.TabIndex = 26
        Me.Username2Label.Text = "Username:"
        Me.Username2Label.Visible = False
        '
        'Account2Label
        '
        Me.Account2Label.AutoSize = True
        Me.Account2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account2Label.Location = New System.Drawing.Point(450, 51)
        Me.Account2Label.Name = "Account2Label"
        Me.Account2Label.Size = New System.Drawing.Size(118, 20)
        Me.Account2Label.TabIndex = 24
        Me.Account2Label.Text = "Account Name:"
        Me.Account2Label.Visible = False
        '
        'Password2
        '
        Me.Password2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password2.Location = New System.Drawing.Point(574, 112)
        Me.Password2.Name = "Password2"
        Me.Password2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password2.Size = New System.Drawing.Size(271, 26)
        Me.Password2.TabIndex = 23
        Me.Password2.Visible = False
        '
        'Username2
        '
        Me.Username2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username2.Location = New System.Drawing.Point(574, 80)
        Me.Username2.Name = "Username2"
        Me.Username2.Size = New System.Drawing.Size(271, 26)
        Me.Username2.TabIndex = 22
        Me.Username2.Visible = False
        '
        'Account2
        '
        Me.Account2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account2.Location = New System.Drawing.Point(574, 48)
        Me.Account2.Name = "Account2"
        Me.Account2.Size = New System.Drawing.Size(271, 26)
        Me.Account2.TabIndex = 21
        Me.Account2.Visible = False
        '
        'SecondLabel
        '
        Me.SecondLabel.AutoSize = True
        Me.SecondLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondLabel.Location = New System.Drawing.Point(450, 12)
        Me.SecondLabel.Name = "SecondLabel"
        Me.SecondLabel.Size = New System.Drawing.Size(146, 20)
        Me.SecondLabel.TabIndex = 29
        Me.SecondLabel.Text = "Second Account:"
        Me.SecondLabel.Visible = False
        '
        'ClearSecond
        '
        Me.ClearSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearSecond.Location = New System.Drawing.Point(628, 175)
        Me.ClearSecond.Name = "ClearSecond"
        Me.ClearSecond.Size = New System.Drawing.Size(156, 29)
        Me.ClearSecond.TabIndex = 30
        Me.ClearSecond.Text = "Clear Account"
        Me.ClearSecond.UseVisualStyleBackColor = True
        Me.ClearSecond.Visible = False
        '
        'AccountTip
        '
        Me.AccountTip.ToolTipTitle = "Add Second Account"
        '
        'DeployBeanSettings
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(875, 377)
        Me.Controls.Add(Me.ClearSecond)
        Me.Controls.Add(Me.SecondLabel)
        Me.Controls.Add(Me.ConfirmPass2Label)
        Me.Controls.Add(Me.ConfirmPassword2)
        Me.Controls.Add(Me.Pass2Label)
        Me.Controls.Add(Me.Username2Label)
        Me.Controls.Add(Me.Account2Label)
        Me.Controls.Add(Me.Password2)
        Me.Controls.Add(Me.Username2)
        Me.Controls.Add(Me.Account2)
        Me.Controls.Add(Me.AddSecond)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.HotkeyCombo)
        Me.Controls.Add(Me.Hotkey)
        Me.Controls.Add(Me.HotkeyLabel)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.UpdatesLink)
        Me.Controls.Add(Me.WebLinks)
        Me.Controls.Add(Me.UpdatesLabel)
        Me.Controls.Add(Me.WebLabel)
        Me.Controls.Add(Me.GNULink)
        Me.Controls.Add(Me.LicenseLabel)
        Me.Controls.Add(Me.About)
        Me.Controls.Add(Me.StartWithWindows)
        Me.Controls.Add(Me.BeanstalkInfo)
        Me.Controls.Add(Me.PassLabel2)
        Me.Controls.Add(Me.ConfirmPassword)
        Me.Controls.Add(Me.PassLabel)
        Me.Controls.Add(Me.UsrLabel)
        Me.Controls.Add(Me.AcctLabel)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Account)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeployBeanSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeployBean Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Account As System.Windows.Forms.TextBox
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents AcctLabel As System.Windows.Forms.Label
    Friend WithEvents UsrLabel As System.Windows.Forms.Label
    Friend WithEvents PassLabel As System.Windows.Forms.Label
    Friend WithEvents PassLabel2 As System.Windows.Forms.Label
    Friend WithEvents ConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents BeanstalkInfo As System.Windows.Forms.Label
    Friend WithEvents StartWithWindows As System.Windows.Forms.CheckBox
    Friend WithEvents About As System.Windows.Forms.Label
    Friend WithEvents LicenseLabel As System.Windows.Forms.Label
    Friend WithEvents GNULink As System.Windows.Forms.LinkLabel
    Friend WithEvents WebLabel As System.Windows.Forms.Label
    Friend WithEvents UpdatesLabel As System.Windows.Forms.Label
    Friend WithEvents WebLinks As System.Windows.Forms.LinkLabel
    Friend WithEvents UpdatesLink As System.Windows.Forms.LinkLabel
    Friend WithEvents ErrorLabel As System.Windows.Forms.Label
    Friend WithEvents HotkeyLabel As System.Windows.Forms.Label
    Friend WithEvents Hotkey As System.Windows.Forms.TextBox
    Friend WithEvents HotkeyCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents HotkeyTip As System.Windows.Forms.ToolTip
    Friend WithEvents AddSecond As System.Windows.Forms.Button
    Friend WithEvents ConfirmPass2Label As System.Windows.Forms.Label
    Friend WithEvents ConfirmPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents Pass2Label As System.Windows.Forms.Label
    Friend WithEvents Username2Label As System.Windows.Forms.Label
    Friend WithEvents Account2Label As System.Windows.Forms.Label
    Friend WithEvents Password2 As System.Windows.Forms.TextBox
    Friend WithEvents Username2 As System.Windows.Forms.TextBox
    Friend WithEvents Account2 As System.Windows.Forms.TextBox
    Friend WithEvents SecondLabel As System.Windows.Forms.Label
    Friend WithEvents ClearSecond As System.Windows.Forms.Button
    Friend WithEvents AccountTip As System.Windows.Forms.ToolTip

End Class
