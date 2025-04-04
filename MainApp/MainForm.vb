Public Class MainForm
    Inherits Form


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim inp As New CustomInputBox.CustomInputForm("氏名入力", "名前を入力してください。", "")
        Dim ans As DialogResult = inp.ShowDialog()

        If ans = DialogResult.OK Then
            Label1.Text = "入力された名前は、" & inp.InputText & "です。"
        ElseIf ans = DialogResult.Cancel Then
            Label1.Text = "キャンセルが押されました。"
        End If

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inp As New CustomInputBox.CustomMsgForm("タイトル", "プロンプト")
        If inp.ShowDialog() = DialogResult.OK Then
            'MessageBox.Show("入力された名前：" & inp.InputText)
        End If
    End Sub
End Class
