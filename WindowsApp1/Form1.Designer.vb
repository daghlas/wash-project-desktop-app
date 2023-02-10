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
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(205, 95)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(83, 20)
        Me.lbl_username.TabIndex = 0
        Me.lbl_username.Text = "Username"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(205, 155)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(78, 20)
        Me.lbl_password.TabIndex = 1
        Me.lbl_password.Text = "Password"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(339, 95)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(277, 26)
        Me.txt_username.TabIndex = 2
        Me.txt_username.Text = "Enter Email"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(339, 155)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(277, 26)
        Me.txt_password.TabIndex = 3
        Me.txt_password.Text = "Enter Password"
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(517, 229)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(98, 33)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(517, 280)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(97, 31)
        Me.btn_logout.TabIndex = 5
        Me.btn_logout.Text = "LogOut"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_username)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_logout As Button
End Class
