<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGirl = New System.Windows.Forms.Button()
        Me.btnFriend = New System.Windows.Forms.Button()
        Me.btnLoser = New System.Windows.Forms.Button()
        Me.txtresult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGirl
        '
        Me.btnGirl.Location = New System.Drawing.Point(17, 24)
        Me.btnGirl.Name = "btnGirl"
        Me.btnGirl.Size = New System.Drawing.Size(75, 23)
        Me.btnGirl.TabIndex = 0
        Me.btnGirl.Text = "Girl"
        Me.btnGirl.UseVisualStyleBackColor = True
        '
        'btnFriend
        '
        Me.btnFriend.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnFriend.Location = New System.Drawing.Point(129, 24)
        Me.btnFriend.Name = "btnFriend"
        Me.btnFriend.Size = New System.Drawing.Size(75, 23)
        Me.btnFriend.TabIndex = 1
        Me.btnFriend.Text = "Friend"
        Me.btnFriend.UseVisualStyleBackColor = True
        '
        'btnLoser
        '
        Me.btnLoser.Location = New System.Drawing.Point(242, 24)
        Me.btnLoser.Name = "btnLoser"
        Me.btnLoser.Size = New System.Drawing.Size(75, 23)
        Me.btnLoser.TabIndex = 2
        Me.btnLoser.Text = "Loser"
        Me.btnLoser.UseVisualStyleBackColor = True
        '
        'txtresult
        '
        Me.txtresult.Location = New System.Drawing.Point(17, 69)
        Me.txtresult.Multiline = True
        Me.txtresult.Name = "txtresult"
        Me.txtresult.Size = New System.Drawing.Size(300, 181)
        Me.txtresult.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 262)
        Me.Controls.Add(Me.txtresult)
        Me.Controls.Add(Me.btnLoser)
        Me.Controls.Add(Me.btnFriend)
        Me.Controls.Add(Me.btnGirl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGirl As System.Windows.Forms.Button
    Friend WithEvents btnFriend As System.Windows.Forms.Button
    Friend WithEvents btnLoser As System.Windows.Forms.Button
    Friend WithEvents txtresult As System.Windows.Forms.TextBox

End Class
