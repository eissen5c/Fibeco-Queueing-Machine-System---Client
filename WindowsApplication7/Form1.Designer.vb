<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.txtOld = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.txtNew)
        Me.Panel1.Controls.Add(Me.txtOld)
        Me.Panel1.Location = New System.Drawing.Point(-49, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 93)
        Me.Panel1.TabIndex = 10
        Me.Panel1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Old Password"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(71, 64)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 22)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(194, 64)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(108, 22)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Change Password"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtNew
        '
        Me.txtNew.Location = New System.Drawing.Point(137, 38)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNew.Size = New System.Drawing.Size(163, 20)
        Me.txtNew.TabIndex = 2
        '
        'txtOld
        '
        Me.txtOld.Location = New System.Drawing.Point(137, 10)
        Me.txtOld.Name = "txtOld"
        Me.txtOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOld.Size = New System.Drawing.Size(163, 20)
        Me.txtOld.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Change Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(135, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 27)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Logout All Teller"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(135, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Reset Counter"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 83)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Admin Panel"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents txtOld As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
