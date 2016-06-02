<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ButEncrypt = New System.Windows.Forms.Button()
        Me.TxtEncrypt = New System.Windows.Forms.TextBox()
        Me.ButBrowseEnc = New System.Windows.Forms.Button()
        Me.ButDecrypt = New System.Windows.Forms.Button()
        Me.ButBrowseDec = New System.Windows.Forms.Button()
        Me.TxtKey = New System.Windows.Forms.TextBox()
        Me.TxtDecrypt = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(259, 100)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButBrowseEnc)
        Me.TabPage1.Controls.Add(Me.TxtEncrypt)
        Me.TabPage1.Controls.Add(Me.ButEncrypt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(251, 74)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Encrypt"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TxtDecrypt)
        Me.TabPage2.Controls.Add(Me.TxtKey)
        Me.TabPage2.Controls.Add(Me.ButBrowseDec)
        Me.TabPage2.Controls.Add(Me.ButDecrypt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(251, 74)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Decrypt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        '
        'ButEncrypt
        '
        Me.ButEncrypt.Location = New System.Drawing.Point(7, 7)
        Me.ButEncrypt.Name = "ButEncrypt"
        Me.ButEncrypt.Size = New System.Drawing.Size(238, 23)
        Me.ButEncrypt.TabIndex = 0
        Me.ButEncrypt.Text = "Encrypt"
        Me.ButEncrypt.UseVisualStyleBackColor = True
        '
        'TxtEncrypt
        '
        Me.TxtEncrypt.Enabled = False
        Me.TxtEncrypt.Location = New System.Drawing.Point(7, 40)
        Me.TxtEncrypt.Name = "TxtEncrypt"
        Me.TxtEncrypt.Size = New System.Drawing.Size(150, 20)
        Me.TxtEncrypt.TabIndex = 1
        '
        'ButBrowseEnc
        '
        Me.ButBrowseEnc.Location = New System.Drawing.Point(170, 38)
        Me.ButBrowseEnc.Name = "ButBrowseEnc"
        Me.ButBrowseEnc.Size = New System.Drawing.Size(75, 23)
        Me.ButBrowseEnc.TabIndex = 2
        Me.ButBrowseEnc.Text = "Browse"
        Me.ButBrowseEnc.UseVisualStyleBackColor = True
        '
        'ButDecrypt
        '
        Me.ButDecrypt.Location = New System.Drawing.Point(170, 7)
        Me.ButDecrypt.Name = "ButDecrypt"
        Me.ButDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.ButDecrypt.TabIndex = 0
        Me.ButDecrypt.Text = "Decrypt"
        Me.ButDecrypt.UseVisualStyleBackColor = True
        '
        'ButBrowseDec
        '
        Me.ButBrowseDec.Location = New System.Drawing.Point(169, 45)
        Me.ButBrowseDec.Name = "ButBrowseDec"
        Me.ButBrowseDec.Size = New System.Drawing.Size(75, 23)
        Me.ButBrowseDec.TabIndex = 1
        Me.ButBrowseDec.Text = "Browse"
        Me.ButBrowseDec.UseVisualStyleBackColor = True
        '
        'TxtKey
        '
        Me.TxtKey.Location = New System.Drawing.Point(6, 10)
        Me.TxtKey.Name = "TxtKey"
        Me.TxtKey.Size = New System.Drawing.Size(158, 20)
        Me.TxtKey.TabIndex = 2
        '
        'TxtDecrypt
        '
        Me.TxtDecrypt.Location = New System.Drawing.Point(6, 47)
        Me.TxtDecrypt.Name = "TxtDecrypt"
        Me.TxtDecrypt.Size = New System.Drawing.Size(158, 20)
        Me.TxtDecrypt.TabIndex = 3
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 127)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Main"
        Me.Text = "Encrypter and Decrypter"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ButEncrypt As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents ButBrowseEnc As Button
    Friend WithEvents TxtEncrypt As TextBox
    Friend WithEvents TxtDecrypt As TextBox
    Friend WithEvents TxtKey As TextBox
    Friend WithEvents ButBrowseDec As Button
    Friend WithEvents ButDecrypt As Button
End Class
