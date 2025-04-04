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
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnRight = New Button()
        btnLeft = New Button()
        btnCenter = New Button()
        lblTitle = New Label()
        lblPrompt = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 2)
        TableLayoutPanel1.Controls.Add(lblPrompt, 0, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel1.Location = New Point(12, 6)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 27.272728F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 48.05195F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 24.0259743F))
        TableLayoutPanel1.Size = New Size(383, 154)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 7
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.16666651F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.7777767F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.16666651F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.7777767F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.16666651F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.7777767F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.16666651F))
        TableLayoutPanel2.Controls.Add(btnRight, 5, 0)
        TableLayoutPanel2.Controls.Add(btnLeft, 1, 0)
        TableLayoutPanel2.Controls.Add(btnCenter, 3, 0)
        TableLayoutPanel2.Location = New Point(3, 119)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(365, 31)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' btnRight
        ' 
        btnRight.Dock = DockStyle.Fill
        btnRight.Location = New Point(250, 3)
        btnRight.Name = "btnRight"
        btnRight.Size = New Size(95, 25)
        btnRight.TabIndex = 2
        btnRight.Text = "Button3"
        btnRight.UseVisualStyleBackColor = True
        ' 
        ' btnLeft
        ' 
        btnLeft.Dock = DockStyle.Fill
        btnLeft.Location = New Point(18, 3)
        btnLeft.Name = "btnLeft"
        btnLeft.Size = New Size(95, 25)
        btnLeft.TabIndex = 0
        btnLeft.Text = "Button1"
        btnLeft.UseVisualStyleBackColor = True
        ' 
        ' btnCenter
        ' 
        btnCenter.Dock = DockStyle.Fill
        btnCenter.Location = New Point(134, 3)
        btnCenter.Name = "btnCenter"
        btnCenter.Size = New Size(95, 25)
        btnCenter.TabIndex = 1
        btnCenter.Text = "Button2"
        btnCenter.UseVisualStyleBackColor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Location = New Point(49, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(325, 36)
        lblTitle.TabIndex = 4
        lblTitle.Text = "Label1"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPrompt
        ' 
        lblPrompt.AutoSize = True
        lblPrompt.Dock = DockStyle.Fill
        lblPrompt.Location = New Point(3, 42)
        lblPrompt.Name = "lblPrompt"
        lblPrompt.Size = New Size(377, 74)
        lblPrompt.TabIndex = 5
        lblPrompt.Text = "Label1"
        lblPrompt.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.2807016F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 87.7193F))
        TableLayoutPanel3.Controls.Add(lblTitle, 1, 0)
        TableLayoutPanel3.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(377, 36)
        TableLayoutPanel3.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 30)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' CustomMsgForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(411, 174)
        Controls.Add(TableLayoutPanel1)
        Name = "CustomMsgForm"
        Text = "CustomMsgForm"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnCenter As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPrompt As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
