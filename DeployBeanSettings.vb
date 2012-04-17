Imports System.Windows.Forms
Imports Microsoft.Win32

Public Class DeployBeanSettings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        My.Settings.Account = Account.Text
        My.Settings.Username = Username.Text
        My.Settings.Password = Password.Text
        My.Settings.Account2 = Account2.Text
        My.Settings.Username2 = Username2.Text
        My.Settings.Password2 = Password2.Text
        Dim oldHotkey As String = My.Settings.HotKey
        Dim oldHotkeyMod As Integer = My.Settings.HotKeyMod



        My.Settings.HotKey = Hotkey.Text.Trim.ToUpper



        If Integer.TryParse(Hotkey.Text, Nothing) Then
            My.Settings.HotKey = "D" & Hotkey.Text.Trim()
        End If

        If Hotkey.Text.Trim <> "" And HotkeyCombo.SelectedIndex > 0 Then
            My.Settings.HotKeyMod = HotkeyCombo.SelectedIndex
        Else
            My.Settings.HotKeyMod = 0
        End If

        My.Settings.Save()


        If oldHotkey <> My.Settings.HotKey Or oldHotkeyMod <> My.Settings.HotKeyMod Then
            MessageBox.Show("DeployBean will now restart to apply you HotKey settings.", _
            "Restart Program", _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Exclamation, _
            MessageBoxDefaultButton.Button1)
            Application.Restart()
        End If



        If StartWithWindows.Checked Then
            Dim regKey As RegistryKey
            regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.SetValue("DeployBean", Application.ExecutablePath)
            regKey.Close()
        Else
            Dim regKey As RegistryKey
            regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.DeleteValue("DeployBean", False)
            regKey.Close()
        End If

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Settings_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password.TextChanged, Username.TextChanged, ConfirmPassword.TextChanged, Account.TextChanged, Account2.TextChanged, Username2.TextChanged, Password2.TextChanged, ConfirmPassword2.TextChanged


        If Password.Text = "" Or Account.Text = "" Or Username.Text = "" Then
            OK_Button.Enabled = False
            ErrorLabel.Text = "Please fill in all fields"

        Else
            If Password.Text <> ConfirmPassword.Text Then
                OK_Button.Enabled = False
                ErrorLabel.Text = "Passwords Don't Match"
            Else
                If Password2.Text <> ConfirmPassword2.Text Then
                    OK_Button.Enabled = False
                    ErrorLabel.Text = "Secondary Passwords Don't Match"
                Else
                    If Password2.Text <> "" And (Account2.Text = "" Or Username2.Text = "") Then
                        OK_Button.Enabled = False
                        ErrorLabel.Text = "Please fill in all fields"

                    Else
                        OK_Button.Enabled = True
                        ErrorLabel.Text = ""
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub DeployBeanSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(441, 405)
        HotkeyTip.SetToolTip(Hotkey, "Select a modifier from the drop down (if desired) and then click" + Environment.NewLine + "the text box next to it and hit the key you would like to use." + Environment.NewLine + "Only keys which produce a character can be used.")
        HotkeyTip.SetToolTip(HotkeyCombo, "Select a modifier from the drop down (if desired) and then click" + Environment.NewLine + "the text box next to it and hit the key you would like to use." + Environment.NewLine + "Only keys which produce a character can be used.")
        HotkeyTip.SetToolTip(HotkeyLabel, "Select a modifier from the drop down (if desired) and then click" + Environment.NewLine + "the text box next to it and hit the key you would like to use." + Environment.NewLine + "Only keys which produce a character can be used.")
        HotkeyTip.SetToolTip(ClearBtn, "Select a modifier from the drop down (if desired) and then click" + Environment.NewLine + "the text box next to it and hit the key you would like to use." + Environment.NewLine + "Only keys which produce a character can be used.")
        AccountTip.SetToolTip(AddSecond, "Add a second account to log into two accounts simultaneously.")
        Account.Text = My.Settings.Account
        Username.Text = My.Settings.Username
        Password.Text = My.Settings.Password
        ConfirmPassword.Text = My.Settings.Password

        If My.Settings.Password2 <> "" Then
            AddSecond_Click(sender, New System.EventArgs)
        End If

        If My.Settings.HotKeyMod > 0 Then
            HotkeyCombo.SelectedIndex = My.Settings.HotKeyMod
        End If

        If My.Settings.HotKey.Contains("D") And My.Settings.HotKey <> "D" Then
            Hotkey.Text = My.Settings.HotKey.Substring(1)
        Else
            Hotkey.Text = My.Settings.HotKey
        End If

        Dim regKey As RegistryKey
        regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        If regKey.GetValue("DeployBean") Is Nothing Then
        Else
            StartWithWindows.Checked = True
        End If
        regKey.Close()
    End Sub

    Private Sub WebLinks_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles WebLinks.LinkClicked
        System.Diagnostics.Process.Start("http://digistump.com")
    End Sub

    Private Sub UpdatesLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles UpdatesLink.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/digistump")
    End Sub

    Private Sub GNULink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GNULink.LinkClicked
        System.Diagnostics.Process.Start("http://www.gnu.org/licenses/gpl.html")
    End Sub

    Private Sub Hotkey_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Hotkey.KeyPress
        Hotkey.Text = e.KeyChar.ToString()
    End Sub


    Private Sub ClearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearBtn.Click
        Hotkey.Text = ""
        HotkeyCombo.SelectedIndex = 0
    End Sub

    Private Sub AddSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSecond.Click
        Me.Size = New Size(881, 405)
        AddSecond.Hide()
        Account2.Text = My.Settings.Account2
        Username2.Text = My.Settings.Username2
        Password2.Text = My.Settings.Password2
        ConfirmPassword2.Text = My.Settings.Password2
        Account2.Show()
        Username2.Show()
        Password2.Show()
        ConfirmPassword2.Show()
        Account2Label.Show()
        Username2Label.Show()
        Pass2Label.Show()
        ConfirmPass2Label.Show()
        ClearSecond.Show()
        SecondLabel.Show()

    End Sub

    Private Sub ClearSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearSecond.Click
        Account2.Text = ""
        Username2.Text = ""
        Password2.Text = ""
        ConfirmPassword2.Text = ""
        Account2.Hide()
        Username2.Hide()
        Password2.Hide()
        ConfirmPassword2.Hide()
        Account2Label.Hide()
        Username2Label.Hide()
        Pass2Label.Hide()
        ConfirmPass2Label.Hide()
        ClearSecond.Hide()
        SecondLabel.Hide()
        AddSecond.Show()
        Me.Size = New Size(441, 405)
        Settings_TextChanged(sender, New System.EventArgs)

    End Sub
End Class


