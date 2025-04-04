<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomMsgForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        tlpMain = New TableLayoutPanel()
        tlpButton = New TableLayoutPanel()
        btnRight = New Button()
        btnLeft = New Button()
        btnCenter = New Button()
        lblPrompt = New Label()
        tlpTitle = New TableLayoutPanel()
        lblTitle = New Label()
        PictureBox1 = New PictureBox()
        tlpMain.SuspendLayout()
        tlpButton.SuspendLayout()
        tlpTitle.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tlpMain
        ' 
        tlpMain.ColumnCount = 1
        tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpMain.Controls.Add(tlpButton, 0, 2)
        tlpMain.Controls.Add(lblPrompt, 0, 1)
        tlpMain.Controls.Add(tlpTitle, 0, 0)
        tlpMain.Dock = DockStyle.Fill
        tlpMain.Location = New Point(0, 0)
        tlpMain.Name = "tlpMain"
        tlpMain.RowCount = 3
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 27.450983F))
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 48.3660126F))
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 24.1830063F))
        tlpMain.Size = New Size(411, 174)
        tlpMain.TabIndex = 0
        ' 
        ' tlpButton
        ' 
        tlpButton.ColumnCount = 7
        tlpButton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.16666651F))
        tlpButton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.7777767F))
        tlpButton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.16666651F))
        tlpButton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.7777767F))
        tlpButton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.16666651F))
        tlpButton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.7777767F))
        tlpButton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.16666651F))
        tlpButton.Controls.Add(btnRight, 5, 0)
        tlpButton.Controls.Add(btnLeft, 1, 0)
        tlpButton.Controls.Add(btnCenter, 3, 0)
        tlpButton.Dock = DockStyle.Fill
        tlpButton.Location = New Point(3, 134)
        tlpButton.Name = "tlpButton"
        tlpButton.RowCount = 1
        tlpButton.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpButton.Size = New Size(405, 37)
        tlpButton.TabIndex = 3
        ' 
        ' btnRight
        ' 
        btnRight.Dock = DockStyle.Fill
        btnRight.Location = New Point(275, 3)
        btnRight.Name = "btnRight"
        btnRight.Size = New Size(106, 31)
        btnRight.TabIndex = 2
        btnRight.Text = "Button3"
        btnRight.UseVisualStyleBackColor = True
        ' 
        ' btnLeft
        ' 
        btnLeft.Dock = DockStyle.Fill
        btnLeft.Location = New Point(19, 3)
        btnLeft.Name = "btnLeft"
        btnLeft.Size = New Size(106, 31)
        btnLeft.TabIndex = 0
        btnLeft.Text = "Button1"
        btnLeft.UseVisualStyleBackColor = True
        ' 
        ' btnCenter
        ' 
        btnCenter.Dock = DockStyle.Fill
        btnCenter.Location = New Point(147, 3)
        btnCenter.Name = "btnCenter"
        btnCenter.Size = New Size(106, 31)
        btnCenter.TabIndex = 1
        btnCenter.Text = "Button2"
        btnCenter.UseVisualStyleBackColor = True
        ' 
        ' lblPrompt
        ' 
        lblPrompt.AutoSize = True
        lblPrompt.Dock = DockStyle.Fill
        lblPrompt.Location = New Point(3, 47)
        lblPrompt.Name = "lblPrompt"
        lblPrompt.Size = New Size(405, 84)
        lblPrompt.TabIndex = 5
        lblPrompt.Text = "Label1"
        lblPrompt.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tlpTitle
        ' 
        tlpTitle.ColumnCount = 2
        tlpTitle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.2807016F))
        tlpTitle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 87.7193F))
        tlpTitle.Controls.Add(lblTitle, 1, 0)
        tlpTitle.Controls.Add(PictureBox1, 0, 0)
        tlpTitle.Dock = DockStyle.Fill
        tlpTitle.Location = New Point(3, 3)
        tlpTitle.Name = "tlpTitle"
        tlpTitle.RowCount = 1
        tlpTitle.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpTitle.Size = New Size(405, 41)
        tlpTitle.TabIndex = 6
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Location = New Point(52, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(350, 41)
        lblTitle.TabIndex = 4
        lblTitle.Text = "Label1"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(43, 35)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' CustomMsgForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(411, 174)
        Controls.Add(tlpMain)
        Name = "CustomMsgForm"
        Text = "CustomMsgForm"
        tlpMain.ResumeLayout(False)
        tlpMain.PerformLayout()
        tlpButton.ResumeLayout(False)
        tlpTitle.ResumeLayout(False)
        tlpTitle.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnCenter As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents tlpButton As TableLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPrompt As Label
    Friend WithEvents tlpTitle As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
