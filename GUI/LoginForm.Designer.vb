<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cbHidePass = New System.Windows.Forms.CheckBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Đăng nhập"
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.White
        Me.pnlLogin.Controls.Add(Me.Label1)
        Me.pnlLogin.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogin.ForeColor = System.Drawing.Color.Coral
        Me.pnlLogin.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(551, 75)
        Me.pnlLogin.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(125, 218)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(140, 35)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Đăng Nhập"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(290, 218)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(139, 35)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Thoát"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'cbHidePass
        '
        Me.cbHidePass.AutoSize = True
        Me.cbHidePass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHidePass.ForeColor = System.Drawing.Color.White
        Me.cbHidePass.Location = New System.Drawing.Point(318, 169)
        Me.cbHidePass.Name = "cbHidePass"
        Me.cbHidePass.Size = New System.Drawing.Size(174, 28)
        Me.cbHidePass.TabIndex = 9
        Me.cbHidePass.Text = "Hiển thị mật khẩu"
        Me.cbHidePass.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(241, 133)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(251, 30)
        Me.txtPass.TabIndex = 6
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtUserName
        '
        Me.txtUserName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(241, 93)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(251, 30)
        Me.txtUserName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mật Khẩu"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tên Đăng Nhập"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(551, 284)
        Me.Controls.Add(Me.cbHidePass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.pnlLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Đăng nhập"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cbHidePass As CheckBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
