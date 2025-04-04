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
        SuspendLayout()
        ' 
        ' lblPromp
        ' 
        lblPromp.AutoSize = True
        lblPromp.Location = New Point(19, 37)
        lblPromp.Name = "lblPromp"
        lblPromp.Size = New Size(55, 15)
        lblPromp.TabIndex = 0
        lblPromp.Text = "lblPromp"
        ' 
        ' btnOK
        ' 
        btnOK.Location = New Point(165, 46)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(75, 23)
        btnOK.TabIndex = 1
        btnOK.Text = "OK"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(18, 79)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(87, 23)
        txtInput.TabIndex = 2
        ' 
        ' CustomInputForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtInput)
        Controls.Add(btnOK)
        Controls.Add(lblPromp)
        Name = "CustomInputForm"
        Text = "CustomInputForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPromp As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents txtInput As TextBox
End Class
