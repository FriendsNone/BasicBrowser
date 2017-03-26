Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Search = 1 Then
            RadioButton1.Checked = True
        End If
        If My.Settings.Search = 2 Then
            RadioButton2.Checked = True
        End If
        If My.Settings.Search = 3 Then
            RadioButton3.Checked = True
        End If
        If My.Settings.Search = 4 Then
            RadioButton3.Checked = True
        End If
        TextBox1.Text = My.Settings.Homepage
    End Sub

    Private Sub Btn_set_Click(sender As Object, e As EventArgs) Handles Btn_set.Click
        My.Settings.Homepage = TextBox1.Text
        MsgBox("Finshed Setting Homepage")
    End Sub

    Private Sub Btn_def_Click(sender As Object, e As EventArgs) Handles Btn_def.Click
        My.Settings.Homepage = ("https://github.com/FriendsNone")
        MsgBox("Finshed Resetting Homepage")
    End Sub

    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles Btn_close.Click
        Me.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        My.Settings.Search = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        My.Settings.Search = 2
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        My.Settings.Search = 3
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        My.Settings.Search = 4
    End Sub
End Class