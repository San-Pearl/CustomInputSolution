Public Class CustomInputForm

    Public Property InputText As String

    Public Sub New(prompt As String, title As String)
        InitializeComponent()
        Me.Text = title
        lblPromp.Text = prompt
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        InputText = txtInput.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub


End Class