Imports System.Xml

Public Class CustomInputForm

    Private configPath As String = "config.xml"

    Public Property InputText As String

    Public Sub New(title As String, prompt As String, Optional defStr As String = "")
        InitializeComponent()
        lblTitle.Text = title
        lblPromp.Text = prompt
        txtInput.Text = defStr

    End Sub

    ''' <summary>
    ''' ユーザーがOKボタンを押した時
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        InputText = txtInput.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ''' <summary>
    ''' キャンセルボタンを押した時
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        InputText = txtInput.Text
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CustomInpotForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If IO.File.Exists(configPath) Then
                Me.Size = LoadFormSize(configPath)
                Me.lblTitle.Font = LoadTitleFont(configPath) ' ← フォントも反映！
                Me.lblPromp.Font = LoadPromptFont(configPath) ' ← フォントも反映！
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

End Class