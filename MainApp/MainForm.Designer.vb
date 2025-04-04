<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnOK = New Button()
        Button1 = New Button()
        Label1 = New Label()
        btnMsgCS = New Button()
        btnInpCS = New Button()
        SuspendLayout()
        ' 
        ' btnOK
        ' 
        btnOK.Location = New Point(275, 82)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(125, 33)
        btnOK.TabIndex = 1
        btnOK.Text = "InputBoxテスト(VB)"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(275, 43)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 33)
        Button1.TabIndex = 3
        Button1.Text = "msgBoxテスト(VB)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 4
        Label1.Text = "Label1"
        ' 
        ' btnMsgCS
        ' 
        btnMsgCS.Location = New Point(275, 121)
        btnMsgCS.Name = "btnMsgCS"
        btnMsgCS.Size = New Size(122, 27)
        btnMsgCS.TabIndex = 5
        btnMsgCS.Text = "msgBoxtestCS"
        btnMsgCS.UseVisualStyleBackColor = True
        ' 
        ' btnInpCS
        ' 
        btnInpCS.Location = New Point(277, 158)
        btnInpCS.Name = "btnInpCS"
        btnInpCS.Size = New Size(113, 28)
        btnInpCS.TabIndex = 6
        btnInpCS.Text = "InputBoxテストCS"
        btnInpCS.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(436, 195)
        Controls.Add(btnInpCS)
        Controls.Add(btnMsgCS)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(btnOK)
        Name = "MainForm"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnOK As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMsgCS As Button
    Friend WithEvents btnInpCS As Button

End Class
