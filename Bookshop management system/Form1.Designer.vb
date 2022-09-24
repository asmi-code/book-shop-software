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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Myprogress = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Myprogress.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(335, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BookShop Software"
        '
        'Myprogress
        '
        Me.Myprogress.Controls.Add(Me.Label2)
        Me.Myprogress.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Myprogress.FillThickness = 10
        Me.Myprogress.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Myprogress.ForeColor = System.Drawing.Color.White
        Me.Myprogress.Location = New System.Drawing.Point(376, 107)
        Me.Myprogress.Minimum = 0
        Me.Myprogress.Name = "Myprogress"
        Me.Myprogress.ProgressThickness = 10
        Me.Myprogress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Myprogress.Size = New System.Drawing.Size(255, 255)
        Me.Myprogress.TabIndex = 2
        Me.Myprogress.Text = "Guna2CircleProgressBar1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(112, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 40)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(422, 410)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Project by Group ""A"""
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(994, 533)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Myprogress)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "form1"
        Me.Myprogress.ResumeLayout(False)
        Me.Myprogress.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Myprogress As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
End Class
