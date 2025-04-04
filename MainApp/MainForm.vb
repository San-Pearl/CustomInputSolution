Public Class MainForm
    Inherits Form
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim inp As New CustomInputBox.CustomInputForm("名前を入力してください", "入力")
        If inp.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("入力された名前：" & inp.InputText)
        End If

    End Sub
End Class
