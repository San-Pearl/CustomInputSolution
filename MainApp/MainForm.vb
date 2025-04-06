Public Class MainForm
    Inherits Form

    'Dim dlg As New CustomInputBox()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'title As String, prompt As String, Optional btnLtxt As String = "", Optional btnCtxt As String = "OK", Optional btnRtxt As String = "", Optional img As Integer = 0
        Dim inp As New CustomInputBox.CustomMsgForm(title:="タイトル", prompt:="プロンプト", btnLtxt:="", btnCtxt:="", btnRtxt:="了解", img:=0)
        'Dim inp As New CustomInputBox.CustomMsgForm("タイトル", "プロンプト", "了解", 1)
        'Dim inp As New CustomInputBox.CustomMsgForm(title:="タイトル", prompt:="メッセージ", btnCtxt:="了解", img:=1)
        If inp.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("押下したボタンは、" & inp.Choice)
        End If
    End Sub
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

    ''' <summary>
    ''' C#のカスタムインプットボックス
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnInpCS_Click(sender As Object, e As EventArgs) Handles btnInpCS.Click
        Dim inp As New CustomInputBoxCshrp.CustomInputForm("氏名入力", "名前を入力してください。", "")
        Dim ans As DialogResult = inp.ShowDialog()

        If ans = DialogResult.OK Then
            Label1.Text = "入力された名前は、" & inp.InputText & "です。"
        ElseIf ans = DialogResult.Cancel Then
            Label1.Text = "キャンセルが押されました。"
        End If
    End Sub
End Class
