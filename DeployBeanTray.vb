Option Strict Off

Imports System.Configuration
Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Threading
Imports System.Threading.Tasks


Public Class DeployBean





    Dim repoItems As New Dictionary(Of String, String)
    Dim repoSort As New Dictionary(Of String, String)
    Dim repoCache As Object = Nothing
    Dim repoCache2 As Object = Nothing
    Dim repoAccount As New Dictionary(Of String, Boolean)
    Dim commitCache As Object = Nothing
    Dim commitItems As New Dictionary(Of String, String)
    Dim enviroCache As Object = Nothing
    Dim enviroItems As New Dictionary(Of String, String)
    Dim repoId As String
    Dim revId As String
    Dim enviroId As String
    Dim toastMsg As String
    Dim lastEnviro As New Dictionary(Of String, String)
    Dim accountFlag As Boolean = False




    Private Function FetchBeanstalkData(ByVal getString As String, ByVal rev As String, ByVal second As Boolean) As Object
        Dim request As WebRequest
        Dim myCreds As New CredentialCache()
        Dim Creds As New NetworkCredential()
        'Set account creds
        If second = True Then
            Creds = New NetworkCredential(My.Settings.Username2, My.Settings.Password2)
            myCreds.Add(New Uri("http://" + My.Settings.Account2 + ".beanstalkapp.com"), "Basic", Creds)
            ' Create a request using a URL that can receive a post. 
            request = WebRequest.Create("http://" + My.Settings.Account2 + ".beanstalkapp.com" + getString)
        Else
            Creds = New NetworkCredential(My.Settings.Username, My.Settings.Password)
            myCreds.Add(New Uri("http://" + My.Settings.Account + ".beanstalkapp.com"), "Basic", Creds)
            ' Create a request using a URL that can receive a post. 
            request = WebRequest.Create("http://" + My.Settings.Account + ".beanstalkapp.com" + getString)
        End If

        'Console.WriteLine("http://" + My.Settings.Account + ".beanstalkapp.com" + getString)
        request.Credentials = myCreds
        ' Set the Method property of the request to POST.
        Dim dataStream As Stream
        If rev Is Nothing Then
            request.Method = "GET"
        Else
            request.Method = "POST"
            ' Create POST data and convert it to a byte array.
            Dim postData As String = "{""release"": {""revision"": """ + rev + """}}"
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            ' Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded"
            ' Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length
            ' Get the request stream.
            dataStream = request.GetRequestStream()
            ' Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length)
            ' Close the Stream object.
            dataStream.Close()
        End If

        ' Get the response.
        Dim response As WebResponse = request.GetResponse()
        ' Display the status.
        'DO SOMETHING HERE IF NOT OK
        'Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        ' Get the stream containing content returned by the server.
        dataStream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)
        ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()
        ' Display the content.
        'Console.WriteLine(responseFromServer)
        Dim serializer As JavaScriptSerializer
        serializer = New JavaScriptSerializer()
        Dim jsonResponse = Nothing
        Try
            jsonResponse = serializer.Deserialize(Of Object)(responseFromServer)
        Catch ex As Exception
        End Try

        ' Clean up the streams.
        reader.Close()
        dataStream.Close()
        response.Close()
        Return jsonResponse

    End Function


    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        'Settings
        DeployBeanSettings.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Shutdown()
    End Sub

    Private Sub Tray_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrayIcon.MouseClick
        If e.Button = MouseButtons.Left Then
            Start()
        End If
    End Sub
    Private Sub HideForm()
        'Fade out fast
        For iCount = 100 To 0 Step -10
            Me.Opacity = iCount / 100
            Me.Refresh()
            Threading.Thread.Sleep(10)
        Next
        Me.WindowState = FormWindowState.Minimized

        RemoveHandler Me.Deactivate, AddressOf HideForm
        Me.Hide()
    End Sub
    Private Sub Start()
        If My.Settings.Account <> "" Then
            Me.Opacity = 0
            Me.Show()

            RepoList.Show()
            RepoLabel.Show()
            CommitList.Hide()
            CommitLabel.Hide()
            EnviroList.Hide()
            EnviroLabel.Hide()
            DeployButton.Hide()
            DeployLabel.Hide()
            DeployCancelButton.Hide()
            DeployText.Hide()

            Me.WindowState = FormWindowState.Normal
            RepoList.Focus()

            AddHandler Me.Deactivate, AddressOf HideForm
            'Fade in real fast
            For iCount = 0 To 100 Step +10
                Me.Opacity = iCount / 100
                Me.Refresh()
                Threading.Thread.Sleep(10)
            Next

            Dim action As Action = AddressOf GetRepos
            Task.Factory.StartNew(action)
        End If
    End Sub
    Protected Sub Shutdown()
        ' It's a good idea to make the system tray icon invisible before ending
        ' the application, otherwise, it can linger in the tray when the application
        ' is no longer running.
        TrayIcon.Visible = False
        RemoveHandler Me.HotKeyPressed, AddressOf hotKey_Pressed
        Application.Exit()
    End Sub

    Private Sub DeployBean_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.Hide()

        If My.Settings.Account <> "" Then
            'get repo list for fast loading
            Dim action As Action = AddressOf GetRepos
            Task.Factory.StartNew(action)
        End If


        m_hotKeys = New HotKeyCollection(Me)
        If My.Settings.HotKey.Length > 0 Then

            AddHandler Me.HotKeyPressed, AddressOf hotKey_Pressed
            ' set the hotkey:

            Dim FirstHotKey As Integer = [Enum].Parse(GetType(Keys), My.Settings.HotKey)
            Dim htk As HotKey = New HotKey("DeployBean HotKey", FirstHotKey, Integer.Parse(My.Settings.HotKeyMod))
            Me.HotKeys.Add(htk)
        End If
    End Sub

    Private Sub hotKey_Pressed(ByVal sender As System.Object, ByVal e As HotKeyPressedEventArgs)

        'start the program
        Start()

    End Sub

    Private m_hotKeys As HotKeyCollection

    Public Event HotKeyPressed As HotKeyPressedEventHandler
    Public Event PrintWindowPressed As PrintWindowPressedEventHandler
    Public Event PrintDesktopPressed As PrintDesktopPressedEventHandler

    Public ReadOnly Property HotKeys() As HotKeyCollection
        Get
            HotKeys = m_hotKeys
        End Get
    End Property


    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        If (m.Msg = UnmanagedMethods.WM_HOTKEY) Then
            Dim hotKeyId As Integer = m.WParam.ToInt32()
            Select Case hotKeyId
                Case UnmanagedMethods.IDHOT_SNAPDESKTOP
                    Dim e As System.EventArgs = New System.EventArgs()
                    RaiseEvent PrintDesktopPressed(Me, e)

                Case UnmanagedMethods.IDHOT_SNAPWINDOW
                    Dim e As System.EventArgs = New System.EventArgs()
                    RaiseEvent PrintWindowPressed(Me, e)

                Case Else
                    Dim htk As HotKey
                    For Each htk In m_hotKeys
                        If (htk.AtomId.Equals(m.WParam)) Then
                            Dim e As HotKeyPressedEventArgs = New HotKeyPressedEventArgs(htk)
                            RaiseEvent HotKeyPressed(Me, e)
                        End If
                    Next
            End Select

        End If
    End Sub

    Protected Overrides Sub OnClosed(ByVal e As System.EventArgs)
        HotKeys.Clear()
        MyBase.OnClosed(e)
    End Sub

  

 

    Private Sub GetRepos()
        'get repos when shown - add only if changed from inital app load
        repoCache = FetchBeanstalkData("/api/repositories.json", Nothing, False)
        If My.Settings.Password2 <> "" Then
            repoCache2 = FetchBeanstalkData("/api/repositories.json", Nothing, True)
        End If

        Dim t As New Threading.Thread(AddressOf SetRepos)
        t.Start()
        
    End Sub

    Private Sub SetRepos()
        If repoCache Is Nothing Then
        Else
            If RepoList.InvokeRequired Then
                RepoList.BeginInvoke(New MethodInvoker(AddressOf SetRepos))
            Else
                repoSort.Clear()
                repoItems.Clear()

                For Each item As Object In repoCache
                    Dim repo = item("repository")
                    Dim title As String = repo("title")
                    Dim id As Integer = repo("id")
                    Dim update As String = repo("updated_at")
                    repoSort.Add(update, title)
                    repoItems.Add(id, title)
                    repoAccount.Add(id, False)
                Next

                If repoCache2 Is Nothing Then
                Else
                    For Each item As Object In repoCache2
                        Dim repo = item("repository")
                        Dim title As String = repo("title")
                        Dim id As Integer = repo("id")
                        Dim update As String = repo("updated_at")
                        repoSort.Add(update, title)
                        repoItems.Add(id, title)
                        repoAccount.Add(id, True)
                    Next
                End If

                Dim keys As List(Of String) = repoSort.Keys.ToList
                keys.Sort()

                Dim selected As String = Nothing

                If RepoList.SelectedIndex > -1 Then
                    selected = RepoList.Items(RepoList.SelectedIndex)
                End If


                RepoList.Items.Clear()
                For Each key As String In keys
                    Dim title As String = repoSort.Item(key)
                    Dim last As TimeSpan = Now - CType(key, DateTime)

                    Dim lastText As String
                    If last.TotalDays = 1 Then
                        If last.Days > 1 Then
                            lastText = last.Days.ToString + " days ago"
                        Else
                            lastText = last.Days.ToString + " day ago"
                        End If

                    ElseIf last.TotalHours >= 1 Then
                        If last.Hours > 1 Then
                            lastText = last.Hours.ToString + " hours ago"
                        Else
                            lastText = last.Hours.ToString + " hour ago"
                        End If

                    ElseIf last.TotalMinutes >= 1 Then
                        If last.Minutes > 1 Then
                            lastText = last.Minutes.ToString + " mins ago"
                        Else
                            lastText = last.Minutes.ToString + " min ago"
                        End If

                    Else
                        If last.Seconds > 1 Then
                            lastText = last.Seconds.ToString + " secs ago"
                        Else
                            lastText = last.Seconds.ToString + " sec ago"
                        End If

                    End If


                    Dim index As Integer = RepoList.Items.Add(title + " (" + lastText + ")")

                    If selected <> Nothing Then
                        If selected.IndexOf(title + " (") = 0 And selected.Length - title.Length >= 12 And selected.Length - title.Length <= 15 Then
                            'we need to select this one
                            RepoList.SelectedIndex = index
                        End If
                    End If

                Next
                End If
        End If
    End Sub

    Private Sub RepoList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepoList.Click
        If RepoList.SelectedIndex > -1 Then
            Dim selected As String = RepoList.Items(RepoList.SelectedIndex)
            For Each item As Object In repoItems
                Dim title As String = item.Value
                If selected.IndexOf(title + " (") = 0 And selected.Length - title.Length >= 12 And selected.Length - title.Length <= 15 Then
                    repoId = item.Key
                    accountFlag = repoAccount(repoId)
                    'Hide list and send repo id to next step
                    RepoList.Hide()
                    RepoLabel.Hide()
                    Dim action As Action = AddressOf GetCommits

                    Task.Factory.StartNew(action)
                    'Get server enviroments now!
                    action = AddressOf GetEnviros

                    Task.Factory.StartNew(action)
                    CommitList.Items.Clear()
                    CommitList.Items.Add("Loading...")
                    CommitList.Show()
                    CommitLabel.Show()
                    CommitList.Focus()




                    Exit For
                End If
            Next

        End If
    End Sub

    Private Sub GetCommits()
        If repoId <> Nothing Then
            commitCache = FetchBeanstalkData("/api/changesets/repository.json?repository_id=" + repoId, Nothing, accountFlag)
            Dim t As New Threading.Thread(AddressOf SetCommits)
            t.Start()
        End If

    End Sub

    Private Sub SetCommits()
        If commitCache Is Nothing Then
        Else
            If CommitList.InvokeRequired Then
                CommitList.BeginInvoke(New MethodInvoker(AddressOf SetCommits))
            Else
                CommitList.Items.Clear()
                commitItems.Clear()
                'load them into commit list
                For Each item As Object In commitCache
                    Dim rev = item("revision_cache")
                    Dim revision As String = rev("revision")
                    Dim author As String = rev("author")
                    Dim time As Date = rev("time")
                    Dim message As String = rev("message")
                    If message.Length > 25 Then
                        message = message.Substring(0, 25)
                    End If
                    Dim timetext As String = ""
                    If (Now.ToShortDateString = time.ToShortDateString) Then
                        timetext = time.ToString("t")
                    Else
                        timetext = time.ToString("M/d/yy")
                    End If

                    Dim title As String = ""
                    If message.Length > 0 Then
                        title = message + " (" + timetext + " " + author + ")"
                    Else
                        title = "No Message (" + timetext + " " + author + ")"
                    End If

                    CommitList.Items.Add(title)
                    commitItems.Add(revision, title)
                Next

                'select first
                CommitList.SelectedIndex = 0
            End If
        End If
    End Sub



    Private Sub GetEnviros()
        If repoId <> Nothing Then
            enviroCache = FetchBeanstalkData("/api/" + repoId + "/server_environments.json", Nothing, accountFlag)
            'Dim t As New Threading.Thread(AddressOf SetEnviros)
            't.Start()
        End If
    End Sub

    Private Sub SetEnviros()
        If enviroCache Is Nothing Then
        Else
            ' If EnviroList.InvokeRequired Then
            'EnviroList.BeginInvoke(New MethodInvoker(AddressOf SetEnviros))
            ' Else
            EnviroList.Enabled = True
            EnviroList.Items.Clear()
            enviroItems.Clear()

            Dim selected As String = CommitList.Items(CommitList.SelectedIndex)
            For Each item As Object In commitItems
                Dim title As String = item.Value
                If title = selected Then
                    revId = item.Key
                    Exit For
                End If
            Next

            'load them into commit list
            For Each item As Object In enviroCache
                Dim env = item("server_environment")
                Dim name As String = env("name")
                Dim updated_at As Date = env("updated_at")
                Dim id As String = env("id")
                Dim auto As Boolean = env("automatic")
                Dim current As String = env("current_version")
                If auto Then
                    name = name + " (Auto)"
                Else

                End If

                If (current <> revId) Then
                    EnviroList.Items.Add(name)
                    enviroItems.Add(id, name)
                End If



            Next

            If EnviroList.Items.Count = 0 Then
                EnviroList.Items.Add("All envrioments are current.")
                EnviroList.Enabled = False
                DeployCancelButton.Show()
                DeployCancelButton.Focus()
            Else
                If lastEnviro.ContainsKey(repoId) Then
                    Dim lastEnviroName As String = lastEnviro(repoId)
                    EnviroList.SelectedIndex = EnviroList.Items.IndexOf(lastEnviroName)
                Else
                    EnviroList.SelectedIndex = 0
                End If

            End If


            ' End If
        End If
    End Sub



    Private Sub CommitList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommitList.Click
        If CommitList.SelectedIndex > -1 Then
            SetEnviros()
            CommitList.Hide()
            CommitLabel.Hide()
            EnviroList.Show()
            EnviroLabel.Show()
            EnviroList.Focus()
        End If

    End Sub


    Private Sub CommitList_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CommitList.KeyUp
        If e.KeyCode = keys.Enter Or e.KeyCode = keys.Return Then
            CommitList_Click(sender, New System.EventArgs())
        End If
    End Sub

    Private Sub EnviroList_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EnviroList.KeyUp
        If e.KeyCode = keys.Enter Or e.KeyCode = keys.Return Then
            EnviroList_Click(sender, New System.EventArgs())
        End If
    End Sub

    Private Sub EnviroList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviroList.Click
        If EnviroList.SelectedIndex > -1 Then
            DeployText.Text = ""
            DeployText.AppendText("Please verify the following deployment:")
            DeployText.AppendText(Environment.NewLine)
            DeployText.AppendText(Environment.NewLine)
            DeployText.AppendText("Enviroment: ")
            DeployText.AppendText(EnviroList.Items(EnviroList.SelectedIndex))
            DeployText.AppendText(Environment.NewLine)
            DeployText.AppendText(Environment.NewLine)
            DeployText.AppendText("Commit: ")
            DeployText.AppendText(CommitList.Items(CommitList.SelectedIndex))
            DeployText.AppendText(Environment.NewLine)
            DeployText.AppendText(Environment.NewLine)

            DeployText.AppendText("Revision: ")
            DeployText.AppendText(revId)


            Dim envselected As String = EnviroList.Items(EnviroList.SelectedIndex)
            For Each item As Object In enviroItems
                Dim title As String = item.Value
                If title = envselected Then
                    enviroId = item.Key
                    Exit For
                End If
            Next

            If lastEnviro.ContainsKey(repoId) Then
            Else
                lastEnviro.Add(repoId, enviroId)
            End If

            EnviroList.Hide()
            EnviroLabel.Hide()
            DeployLabel.Show()
            DeployButton.Show()
            DeployCancelButton.Show()
            DeployText.Show()

            DeployButton.Focus()
        End If
    End Sub

    Private Sub RepoList_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RepoList.KeyUp
        If e.KeyCode = keys.Enter Or e.KeyCode = keys.Return Then
            RepoList_Click(sender, New System.EventArgs())
        End If
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeployCancelButton.Click
        HideForm()
    End Sub

    Private Sub CancelButton_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DeployCancelButton.KeyUp
        If e.KeyCode = keys.Enter Or e.KeyCode = keys.Return Then
            CancelButton_Click(sender, New System.EventArgs())
        End If
    End Sub
    Public Sub Toast()
        TrayIcon.BalloonTipText = toastMsg
        TrayIcon.ShowBalloonTip(5000)
    End Sub


    Public Sub Deploy()
        Dim thisAccountFlag = accountFlag
        Dim rev As String = revId
        Dim rep As String = repoId
        Dim env As String = enviroId
        Dim release As Object = FetchBeanstalkData("/api/" + rep + "/releases.json?environment_id=" + env, rev, thisAccountFlag)
        Dim releaseObj = release("release")
        Dim relError As String = Nothing

        For Each item As Object In releaseObj
            If item.Key = "errors" Then
                relError = item.Value
                Exit For
            End If
        Next

        If relError Is Nothing Then
        Else
            'Show error message in ballon
            toastMsg = "Deployment of revision " + rev + Environment.NewLine + "to " + enviroItems(env) + " failed."
            Dim setToast As New Threading.Thread(AddressOf Toast)
            setToast.Start()

            Exit Sub
        End If

        'Show deploying message in ballon

        toastMsg = "Deploying revision " + rev + Environment.NewLine + "to " + enviroItems(env) + "."

        Dim setToast1 As New Threading.Thread(AddressOf Toast)
        setToast1.Start()

        Dim rel As String = release("release")("id")
        Dim releaseData As Object

LineCheckRelease:

        Thread.Sleep(10000)
        releaseData = FetchBeanstalkData("/api/" + rep + "/releases/" + rel + ".json", Nothing, thisAccountFlag)
        If releaseData Is Nothing Then
        Else
            If releaseData("release")("state") = "waiting" Or releaseData("release")("state") = "pending" Then
                GoTo LineCheckRelease
            ElseIf releaseData("release")("state") = "failed" Then
                toastMsg = "Deployment of revision " + rev + Environment.NewLine + "to " + enviroItems(env) + " failed."
                Dim setToast2 As New Threading.Thread(AddressOf Toast)
                setToast2.Start()

                Exit Sub
            ElseIf releaseData("release")("state") = "success" Then
                toastMsg = "Revision " + rev + Environment.NewLine + "successfully deployed " + Environment.NewLine + "to " + enviroItems(env) + "."
                Dim setToast3 As New Threading.Thread(AddressOf Toast)
                setToast3.Start()

                Exit Sub
            ElseIf releaseData("release")("state") = "skipped" Then
                toastMsg = "Deployment of revision " + rev + Environment.NewLine + "to " + enviroItems(env) + " skipped."
                Dim setToast4 As New Threading.Thread(AddressOf Toast)
                setToast4.Start()

                Exit Sub
            End If
        End If
    End Sub

    Private Sub DeployButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeployButton.Click
        'start deployment
        Dim action As Action = AddressOf Deploy
        Task.Factory.StartNew(action)
        Me.WindowState = FormWindowState.Minimized
        Me.Hide()


    End Sub

    Private Sub DeployButton_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DeployButton.KeyUp
        If e.KeyCode = keys.Enter Or e.KeyCode = keys.Return Then
            DeployButton_KeyUp(sender, New System.EventArgs())
        End If
    End Sub


End Class

Public Delegate Sub HotKeyPressedEventHandler(ByVal sender As Object, ByVal e As HotKeyPressedEventArgs)
Public Delegate Sub PrintWindowPressedEventHandler(ByVal sender As Object, ByVal e As EventArgs)
Public Delegate Sub PrintDesktopPressedEventHandler(ByVal sender As Object, ByVal e As EventArgs)

Public Class HotKeyPressedEventArgs
    Inherits EventArgs
    Private m_hotKey As HotKey

    Public ReadOnly Property HotKey()
        Get
            HotKey = m_hotKey
        End Get
    End Property

    Friend Sub New(ByVal hotKey As HotKey)
        m_hotKey = hotKey
    End Sub

End Class

Public Class HotKeyCollection
    Inherits System.Collections.CollectionBase

    Private ownerForm As System.Windows.Forms.Form

    Protected Overrides Sub OnClear()
        Dim htk As HotKey
        For Each htk In Me.InnerList
            RemoveHotKey(htk)
        Next
        MyBase.OnClear()
    End Sub

    Protected Overrides Sub OnInsert(ByVal index As Integer, ByVal item As Object)
        ' validate item is a hot key:
        Dim htk As HotKey = New HotKey()
        If (item.GetType().IsInstanceOfType(htk)) Then
            ' check if the name, keycode and modifiers have been set up:
            htk = item
            ' throws ArgumentException if there is a problem:
            htk.Validate()
            ' throws Unable to add HotKeyException:
            AddHotKey(htk)
            ' ok
            MyBase.OnInsert(index, item)
        Else
            Throw New InvalidCastException("Invalid object.")
        End If

    End Sub


    Protected Overrides Sub OnRemove(ByVal index As Integer, ByVal item As Object)
        ' get the item to be removed:
        Dim htk As HotKey = item
        RemoveHotKey(htk)
        MyBase.OnRemove(index, item)
    End Sub

    Protected Overrides Sub OnSet(ByVal index As Integer, ByVal oldItem As Object, ByVal newItem As Object)
        ' remove old hot key:
        Dim htk As HotKey = oldItem
        RemoveHotKey(htk)

        ' add new hotkey:
        htk = newItem
        AddHotKey(htk)

        MyBase.OnSet(index, oldItem, newItem)
    End Sub

    Protected Overrides Sub OnValidate(ByVal item As Object)
        Dim htk As HotKey = item
        htk.Validate()
    End Sub

    Public Sub Add(ByVal hotKey As HotKey)
        ' throws argument exception:
        hotKey.Validate()
        ' throws unable to add hot key exception:
        AddHotKey(hotKey)
        ' assuming all is well:
        Me.InnerList.Add(hotKey)
    End Sub

    Default Public ReadOnly Property Item(ByVal index As Integer) As Integer
        Get
            Item = Me.InnerList.Item(index)
        End Get
    End Property

    Private Sub RemoveHotKey(ByVal hotKey As HotKey)
        '// remove the hot key:
        UnmanagedMethods.UnregisterHotKey(ownerForm.Handle, hotKey.AtomId.ToInt32())
        '// unregister the atom:
        UnmanagedMethods.GlobalDeleteAtom(hotKey.AtomId)
    End Sub


    Private Sub AddHotKey(ByVal hotKey As HotKey)
        ' generate the id:
        Dim atomName As String = hotKey.Name + "_" + UnmanagedMethods.GetTickCount().ToString()
        If (atomName.Length > 255) Then
            atomName = atomName.Substring(0, 255)
        End If
        ' Create a new atom:
        Dim id As IntPtr = UnmanagedMethods.GlobalAddAtom(atomName)
        If (id.Equals(IntPtr.Zero)) Then
            ' failed
            Throw New HotKeyAddException("Failed to add GlobalAtom for HotKey")
        Else
            ' succeeded:
            Dim ret As Boolean = UnmanagedMethods.RegisterHotKey( _
              ownerForm.Handle, _
              id.ToInt32(), _
              hotKey.Modifiers, _
              hotKey.KeyCode)
            If Not (ret) Then
                ' Remove the atom:
                UnmanagedMethods.GlobalDeleteAtom(id)
                ' failed
                Throw New HotKeyAddException("Failed to register HotKey")
            Else
                hotKey.AtomName = atomName
                hotKey.AtomId = id
            End If
        End If
    End Sub


    Public Sub New(ByVal ownerForm As System.Windows.Forms.Form)
        Me.ownerForm = ownerForm
    End Sub

End Class

Public Class HotKeyAddException
    Inherits System.Exception

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub

    Public Sub New(ByVal message As String, ByVal innerException As System.Exception)
        MyBase.New(message, innerException)
    End Sub
End Class

Public Class HotKey
    '[Flags]
    Public Enum HotKeyModifiers As Integer
        MOD_ALT = &H1
        MOD_CONTROL = &H2
        MOD_SHIFT = &H4
        MOD_WIN = &H8
    End Enum
    Private m_name As String
    Private m_atomName As String
    Private m_atomId As IntPtr
    Private m_keyCode As Keys
    Private m_modifiers As HotKeyModifiers

    Friend Property AtomId() As IntPtr
        Get
            AtomId = m_atomId
        End Get
        Set(ByVal Value As IntPtr)
            m_atomId = Value
        End Set
    End Property

    Friend Property AtomName() As String
        Get
            AtomName = m_atomName
        End Get
        Set(ByVal Value As String)
            m_atomName = Value
        End Set
    End Property

    Public Property Name() As String
        Get
            Name = m_name
        End Get
        Set(ByVal Value As String)
            m_name = Value
        End Set
    End Property

    Public Property KeyCode() As Keys
        Get
            KeyCode = m_keyCode
        End Get
        Set(ByVal Value As Keys)
            m_keyCode = Value
        End Set
    End Property

    Public Property Modifiers() As HotKeyModifiers
        Get
            Modifiers = m_modifiers
        End Get
        Set(ByVal Value As HotKeyModifiers)
            m_modifiers = Value
        End Set
    End Property

    Public Sub Validate()
        Dim msg As String = ""
        'If (Name Is Null) Then
        'msg = "Name parameter cannot be null"
        'End If
        If (m_name.Trim().Length = 0) Then
            msg = "Name parameter cannot be zero length"
        End If
        If ((KeyCode = Keys.Alt) Or _
         (KeyCode = Keys.Control) Or _
         (KeyCode = Keys.Shift) Or _
         (KeyCode = Keys.ShiftKey) Or _
         (KeyCode = Keys.ControlKey)) Then
            msg = "KeyCode cannot be set to a modifier key"
        End If
        If (msg.Length > 0) Then
            Throw New ArgumentException(msg)
        End If
    End Sub

    Public Sub New()

    End Sub

    Public Sub New( _
        ByVal name As String, _
        ByVal keyCode As Keys, _
        ByVal modifiers As HotKeyModifiers _
        )
        m_name = name
        m_keyCode = keyCode
        m_modifiers = modifiers
    End Sub

End Class

Friend Class UnmanagedMethods

    Friend Const IDHOT_SNAPWINDOW As Integer = -1 '/* SHIFT-PRINTSCRN  */
    Friend Const IDHOT_SNAPDESKTOP As Integer = -2         '/* PRINTSCRN        */
    Friend Const WM_HOTKEY As Integer = &H312

    Public Declare Auto Function RegisterHotKey Lib "user32" _
        (ByVal hWnd As IntPtr, _
        ByVal id As Integer, _
        ByVal fsModifiers As Integer, _
        ByVal vk As Integer _
        ) As Boolean
    Public Declare Auto Function UnregisterHotKey Lib "user32" _
        (ByVal hWnd As IntPtr, _
        ByVal id As Integer _
        ) As Boolean
    Public Declare Auto Function GlobalAddAtom Lib "kernel32" _
        (ByVal lpString As String _
        ) As IntPtr
    Public Declare Auto Function GlobalDeleteAtom Lib "kernel32" _
        (ByVal nAtom As IntPtr _
        ) As IntPtr
    Public Declare Auto Function GetTickCount Lib "kernel32" () As Integer
    Public Declare Auto Function SendMessage Lib "user32" _
        (ByVal hWnd As IntPtr, _
        ByVal wMsg As Integer, _
        ByVal wParam As Integer, _
        ByVal lParam As IntPtr _
        ) As Integer
    Friend Const WM_SYSCOMMAND As Integer = &H112
    Friend Const SC_RESTORE As Integer = &HF120

End Class
