Public Class CustomMsgForm


    Public Sub New(title As String, prompt As String)
        InitializeComponent()
        lblTitle.Text = title
        lblPrompt.Text = prompt
        'PictureBox1.Image =
        Dim imagePath As String = IO.Path.Combine(Application.StartupPath, "img\inf.png")

    If IO.File.Exists(imagePath) Then
            PictureBox1.Image = Image.FromFile(imagePath)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom ' または StretchImage など
        Else
            MessageBox.Show("画像ファイルが見つかりません: " & imagePath)
        End If

        'txtInput.Text = defStr

    End Sub



End Class