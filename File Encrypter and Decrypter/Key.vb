Public Class Key
    Private Sub Key_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButCopy_Click(sender As Object, e As EventArgs) Handles ButCopy.Click
        Clipboard.SetText(txtKey.Text)
        Application.Exit()
        End
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtKey.TextChanged

    End Sub
End Class