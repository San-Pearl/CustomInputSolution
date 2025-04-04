<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomInputForm
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
        lblPromp = New Label()
        btnOK = New Button()
        txtInput = New TextBox()
        tlpMain = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnCancel = New Button()
        lblTitle = New Label()
        tlpMain.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblPromp
        ' 
        lblPromp.AutoSize = True
        lblPromp.Dock = DockStyle.Fill
        lblPromp.Location = New Point(3, 29)
        lblPromp.Name = "lblPromp"
        lblPromp.Size = New Size(459, 73)
        lblPromp.TabIndex = 0
        lblPromp.Text = "lblPromp"
        lblPromp.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnOK
        ' 
        btnOK.Dock = DockStyle.Fill
        btnOK.Location = New Point(375, 3)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(81, 26)
        btnOK.TabIndex = 1
        btnOK.Text = "OK"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Dock = DockStyle.Fill
        txtInput.Location = New Point(3, 105)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(459, 23)
        txtInput.TabIndex = 2
        ' 
        ' tlpMain
        ' 
        tlpMain.ColumnCount = 1
        tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpMain.Controls.Add(lblPromp, 0, 1)
        tlpMain.Controls.Add(txtInput, 0, 2)
        tlpMain.Controls.Add(TableLayoutPanel1, 0, 3)
        tlpMain.Controls.Add(lblTitle, 0, 0)
        tlpMain.Dock = DockStyle.Fill
        tlpMain.Location = New Point(0, 0)
        tlpMain.Name = "tlpMain"
        tlpMain.RowCount = 4
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 41.6666679F))
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 20.833334F))
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 20.833334F))
        tlpMain.Size = New Size(465, 176)
        tlpMain.TabIndex = 3
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 62.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 18.75F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 18.75F))
        TableLayoutPanel1.Controls.Add(btnOK, 2, 0)
        TableLayoutPanel1.Controls.Add(btnCancel, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 141)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(459, 32)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' btnCancel
        ' 
        btnCancel.Dock = DockStyle.Fill
        btnCancel.Location = New Point(289, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(80, 26)
        btnCancel.TabIndex = 2
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Location = New Point(3, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(459, 29)
        lblTitle.TabIndex = 4
        lblTitle.Text = "lblTitle"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CustomInputForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(465, 176)
        Controls.Add(tlpMain)
        Name = "CustomInputForm"
        Text = "CustomInputForm"
        tlpMain.ResumeLayout(False)
        tlpMain.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblPromp As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTitle As Label
End Class
