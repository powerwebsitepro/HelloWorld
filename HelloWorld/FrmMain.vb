Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If txtName.Text.Trim.Length > 0 Then
            MessageBox.Show("Hi " & txtName.Text.Trim & "!")
        Else
            MessageBox.Show("Please enter your name.")
        End If
    End Sub
End Class
