Imports System.Windows.Forms
Imports Microsoft.Win32

Public Class DeployBeanSettings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        My.Settings.Account = Account.Text
        My.Settings.Username = Username.Text
        My.Settings.Password = Password.Text
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

    Private Sub Settings_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password.TextChanged, Username.TextChanged, ConfirmPassword.TextChanged, Account.TextChanged


        If Password.Text = "" Or Account.Text = "" Or Username.Text = "" Then
            OK_Button.Enabled = False
            ErrorLabel.Text = "Please fill in all fields"

        Else
            OK_Button.Enabled = True
            ErrorLabel.Text = ""
            If Password.Text <> ConfirmPassword.Text Then
                OK_Button.Enabled = False
                ErrorLabel.Text = "Passwords Don't Match"
            Else
                OK_Button.Enabled = True
                ErrorLabel.Text = ""
            End If
        End If

    End Sub

    Private Sub DeployBeanSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HotkeyTip.SetToolTip(Hotkey, "Select a modifier from the drop down (if desired) and then click" + Environment.NewLine + "the text box next to it and hit the key you would like to use." + Environment.NewLine + "Only keys which produce a character can be used.")
        HotkeyTip.SetToolTip(HotkeyCombo, "Select a modifier from the drop down (if desired) and then click" + Environment.NewLine + "the text box next to it and hit the key you would like to use." + Environment.NewLine + "Only keys which produce a character can be used.")
        HotkeyTip.SetToolTip(HotkeyLabel, "Select a modifier from the drop down (if desired) and then click" + Environment.NewLine + "the text box next to it and hit the key you would like to use." + Environment.NewLine + "Only keys which produce a character can be used.")
        HotkeyTip.SetToolTip(ClearBtn, "Select a modifier from the drop down (if desired) and then click" + Environment.NewLine + "the text box next to it and hit the key you would like to use." + Environment.NewLine + "Only keys which produce a character can be used.")
        Account.Text = My.Settings.Account
        Username.Text = My.Settings.Username
        Password.Text = My.Settings.Password
        ConfirmPassword.Text = My.Settings.Password

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
End Class


