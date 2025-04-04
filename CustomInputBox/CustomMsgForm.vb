Imports System.Xml

Public Enum UserChoice
    None
    Left
    Center
    Right
End Enum

Public Class CustomMsgForm

    Private configPath As String = "config.xml"

    Public Property Choice As UserChoice = UserChoice.None

    Public Sub New(title As String, prompt As String, btnLtxt As String, btnCtxt As String, btnRtxt As String)
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

    Private Sub CustomMsgForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If IO.File.Exists(configPath) Then
                Me.Size = LoadFormSize(configPath)
                Me.lblTitle.Font = LoadTitleFont(configPath) ' ← フォントも反映！
                Me.lblPrompt.Font = LoadPromptFont(configPath) ' ← フォントも反映！
            End If
        Catch ex As Exception
            MessageBox.Show("設定ファイル読み込み失敗: " & ex.Message)
        End Try
    End Sub

    Function LoadFormSize(configPath) As Size
        Dim doc As New XmlDocument()
        doc.Load(configPath)

        Dim sizeNode = doc.SelectSingleNode("config/SettingInp/FormSize")
        If sizeNode Is Nothing Then Throw New Exception("FormSizeノードがありません")

        Dim width As Integer = Integer.Parse(sizeNode.Attributes("Width").Value)
        Dim height As Integer = Integer.Parse(sizeNode.Attributes("Height").Value)

        Return New Size(width, height)
    End Function

    Function LoadTitleFont(configpath) As Font
        Dim doc As New Xml.XmlDocument()
        doc.Load(configpath)

        Dim fontNode = doc.SelectSingleNode("config/SettingInp/FontTitle")
        If fontNode Is Nothing Then
            Return SystemFonts.DefaultFont
        End If

        Dim name = fontNode.Attributes("Name")?.Value
        Dim size = Single.Parse(fontNode.Attributes("Size")?.Value)

        Return New Font(name, size)
    End Function

    Function LoadPromptFont(configpath) As Font
        Dim doc As New Xml.XmlDocument()
        doc.Load(configpath)

        Dim fontNode = doc.SelectSingleNode("config/SettingInp/FontPrompt")
        If fontNode Is Nothing Then
            Return SystemFonts.DefaultFont
        End If

        Dim name = fontNode.Attributes("Name")?.Value
        Dim size = Single.Parse(fontNode.Attributes("Size")?.Value)

        Return New Font(name, size)
    End Function

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click

        Me.Choice = UserChoice.Left
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub btnCenter_Click(sender As Object, e As EventArgs) Handles btnCenter.Click
        Me.Choice = UserChoice.Center
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        Me.Choice = UserChoice.Right
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class