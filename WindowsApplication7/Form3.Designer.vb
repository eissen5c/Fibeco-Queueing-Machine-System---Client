<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBeep = New System.Windows.Forms.Button()
        Me.lstPriority = New System.Windows.Forms.ListBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.txtOld = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.TextBox()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.btnserved = New System.Windows.Forms.Button()
        Me.lbltype = New System.Windows.Forms.TextBox()
        Me.lbldatenow = New System.Windows.Forms.TextBox()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(90, 40)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(71, 25)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBeep
        '
        Me.btnBeep.Enabled = False
        Me.btnBeep.Location = New System.Drawing.Point(90, 8)
        Me.btnBeep.Name = "btnBeep"
        Me.btnBeep.Size = New System.Drawing.Size(71, 25)
        Me.btnBeep.TabIndex = 1
        Me.btnBeep.Text = "Call"
        Me.btnBeep.UseVisualStyleBackColor = True
        '
        'lstPriority
        '
        Me.lstPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstPriority.Enabled = False
        Me.lstPriority.FormattingEnabled = True
        Me.lstPriority.Location = New System.Drawing.Point(10, 35)
        Me.lstPriority.Name = "lstPriority"
        Me.lstPriority.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstPriority.Size = New System.Drawing.Size(74, 54)
        Me.lstPriority.TabIndex = 8
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(10, 9)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(74, 24)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "Senior"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(244, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 25)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(244, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 25)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Change Password"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.txtNew)
        Me.Panel1.Controls.Add(Me.txtOld)
        Me.Panel1.Location = New System.Drawing.Point(-5, -10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 115)
        Me.Panel1.TabIndex = 9
        Me.Panel1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Old Password"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(249, 30)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 22)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(249, 59)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 22)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Change Password"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtNew
        '
        Me.txtNew.Location = New System.Drawing.Point(103, 61)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNew.Size = New System.Drawing.Size(129, 20)
        Me.txtNew.TabIndex = 2
        '
        'txtOld
        '
        Me.txtOld.Location = New System.Drawing.Point(103, 32)
        Me.txtOld.Name = "txtOld"
        Me.txtOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOld.Size = New System.Drawing.Size(129, 20)
        Me.txtOld.TabIndex = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(167, 9)
        Me.Label3.Multiline = True
        Me.Label3.Name = "Label3"
        Me.Label3.ReadOnly = True
        Me.Label3.Size = New System.Drawing.Size(71, 56)
        Me.Label3.TabIndex = 2
        Me.Label3.TabStop = False
        Me.Label3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer4
        '
        '
        'btnserved
        '
        Me.btnserved.Enabled = False
        Me.btnserved.Location = New System.Drawing.Point(90, 71)
        Me.btnserved.Name = "btnserved"
        Me.btnserved.Size = New System.Drawing.Size(71, 25)
        Me.btnserved.TabIndex = 10
        Me.btnserved.Text = "Serve"
        Me.btnserved.UseVisualStyleBackColor = True
        '
        'lbltype
        '
        Me.lbltype.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbltype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltype.Location = New System.Drawing.Point(167, 71)
        Me.lbltype.Multiline = True
        Me.lbltype.Name = "lbltype"
        Me.lbltype.ReadOnly = True
        Me.lbltype.Size = New System.Drawing.Size(71, 25)
        Me.lbltype.TabIndex = 12
        Me.lbltype.Text = "-"
        Me.lbltype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbldatenow
        '
        Me.lbldatenow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbldatenow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatenow.Location = New System.Drawing.Point(244, 8)
        Me.lbldatenow.Multiline = True
        Me.lbldatenow.Name = "lbldatenow"
        Me.lbldatenow.ReadOnly = True
        Me.lbldatenow.Size = New System.Drawing.Size(115, 25)
        Me.lbldatenow.TabIndex = 13
        Me.lbldatenow.Text = "-"
        Me.lbldatenow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer5
        '
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 101)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbldatenow)
        Me.Controls.Add(Me.lbltype)
        Me.Controls.Add(Me.btnserved)
        Me.Controls.Add(Me.lstPriority)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBeep)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Home"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnBeep As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lstPriority As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents txtOld As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.TextBox
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents btnserved As System.Windows.Forms.Button
    Friend WithEvents lbltype As System.Windows.Forms.TextBox
    Friend WithEvents lbldatenow As System.Windows.Forms.TextBox
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
End Class
