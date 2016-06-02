<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Key
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButCopy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(16, 29)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(164, 20)
        Me.txtKey.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Copy this somewhere safe so you can decrypt later!"
        '
        'ButCopy
        '
        Me.ButCopy.Location = New System.Drawing.Point(186, 29)
        Me.ButCopy.Name = "ButCopy"
        Me.ButCopy.Size = New System.Drawing.Size(75, 23)
        Me.ButCopy.TabIndex = 2
        Me.ButCopy.Text = "Copy"
        Me.ButCopy.UseVisualStyleBackColor = True
        '
        'Key
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 74)
        Me.Controls.Add(Me.ButCopy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKey)
        Me.Name = "Key"
        Me.Text = "Key"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKey As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButCopy As Button
End Class
