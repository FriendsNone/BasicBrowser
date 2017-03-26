Imports Awesomium.Core

Public Class Tab
    Private Sub Tab_Load(sender As Object, e As EventArgs) Handles Me.Load
        WebControl1.Source = New Uri(My.Settings.Homepage)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Settings.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WebControl1.CanGoBack Then
            WebControl1.GoBack()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WebControl1.CanGoForward Then
            WebControl1.GoForward()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If WebControl1.IsNavigating Then
            WebControl1.Stop()
            PictureBox1.Visible = False
            Parent.Text = "Stopped"
            Button3.Text = "Reload"
        End If
        If Not WebControl1.IsNavigating Then
            WebControl1.Reload(ignoreCache:=True)
            If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Then
                Try
                    WebControl1.Source = New Uri(TextBox1.Text)
                Catch ex As System.UriFormatException
                    WebControl1.Source = New Uri("http://" + TextBox1.Text)
                    TextBox1.Text = ("http://" + TextBox1.Text)
                End Try
            Else
                If My.Settings.Search = 1 Then
                    WebControl1.Source = New Uri("https://www.google.com/search?q=" + TextBox1.Text)
                End If
                If My.Settings.Search = 2 Then
                    WebControl1.Source = New Uri("https://www.bing.com/search?pc=cosp&ptag=AD6C08C471A&form=CONBDF&conlogo=CT3210127&q=" + TextBox1.Text)
                End If
                If My.Settings.Search = 3 Then
                    WebControl1.Source = New Uri("https://search.yahoo.com/yhs/search?hspart=mnet&hsimp=yhs-001&type=570113137&p=" + TextBox1.Text)
                End If
                If My.Settings.Search = 4 Then
                    WebControl1.Source = New Uri("https://duckduckgo.com/?q=" + TextBox1.Text)
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Then
                Try
                    WebControl1.Source = New Uri(TextBox1.Text)
                Catch ex As System.UriFormatException
                    WebControl1.Source = New Uri("http://" + TextBox1.Text)
                    TextBox1.Text = ("http://" + TextBox1.Text)
                End Try
            Else
                If My.Settings.Search = 1 Then
                    WebControl1.Source = New Uri("https://www.google.com/search?q=" + TextBox1.Text)
                End If
                If My.Settings.Search = 2 Then
                    WebControl1.Source = New Uri("https://www.bing.com/search?pc=cosp&ptag=AD6C08C471A&form=CONBDF&conlogo=CT3210127&q=" + TextBox1.Text)
                End If
                If My.Settings.Search = 3 Then
                    WebControl1.Source = New Uri("https://search.yahoo.com/yhs/search?hspart=mnet&hsimp=yhs-001&type=570113137&p=" + TextBox1.Text)
                End If
                If My.Settings.Search = 4 Then
                    WebControl1.Source = New Uri("https://duckduckgo.com/?q=" + TextBox1.Text)
                End If
            End If
        End If
    End Sub

    Private Sub WebControl1_LoadingFrameComplete(sender As Object, e As FrameEventArgs) Handles WebControl1.LoadingFrameComplete
        Button3.Text = "Reload"
        PictureBox1.Visible = False
        Parent.Text = WebControl1.Title
        TextBox1.Text = WebControl1.Source.ToString
    End Sub

    Private Sub WebControl1_LoadingFrame(sender As Object, e As LoadingFrameEventArgs) Handles WebControl1.LoadingFrame
        Button3.Text = "Stop"
        PictureBox1.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tab As New TabPage
        Dim newtab As New Tab
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        tab.Controls.Add(newtab)
        Form1.TabControl1.TabPages.Add(tab)
        Form1.TabControl1.SelectedTab = tab
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Form1.TabControl1.TabCount = 1 Then
            Dim tab As New TabPage
            Dim newtab As New Tab
            newtab.Show()
            newtab.Dock = DockStyle.Fill
            newtab.TopLevel = False
            tab.Controls.Add(newtab)
            Form1.TabControl1.TabPages.Add(tab)
            Form1.TabControl1.SelectedTab = tab
            Form1.TabControl1.SelectedTab.Dispose()
        Else : Form1.TabControl1.SelectedTab.Dispose()
        End If
    End Sub
End Class