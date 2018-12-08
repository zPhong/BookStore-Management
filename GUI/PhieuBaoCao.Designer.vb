<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhieuBaoCao
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
        Me.cbbMonth = New System.Windows.Forms.ComboBox()
        Me.cbbType = New System.Windows.Forms.ComboBox()
        Me.dgvBaoCao = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbbNam = New System.Windows.Forms.ComboBox()
        Me.btnIn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvBaoCao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbbMonth
        '
        Me.cbbMonth.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbMonth.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbMonth.FormattingEnabled = True
        Me.cbbMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbbMonth.Location = New System.Drawing.Point(162, 3)
        Me.cbbMonth.Name = "cbbMonth"
        Me.cbbMonth.Size = New System.Drawing.Size(153, 33)
        Me.cbbMonth.TabIndex = 0
        '
        'cbbType
        '
        Me.cbbType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbType.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbType.FormattingEnabled = True
        Me.cbbType.Items.AddRange(New Object() {"Tồn", "Công Nợ"})
        Me.cbbType.Location = New System.Drawing.Point(162, 69)
        Me.cbbType.Name = "cbbType"
        Me.cbbType.Size = New System.Drawing.Size(153, 33)
        Me.cbbType.TabIndex = 1
        '
        'dgvBaoCao
        '
        Me.dgvBaoCao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBaoCao.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoCao.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvBaoCao.Location = New System.Drawing.Point(12, 208)
        Me.dgvBaoCao.Name = "dgvBaoCao"
        Me.dgvBaoCao.Size = New System.Drawing.Size(702, 216)
        Me.dgvBaoCao.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Phiếu Báo Cáo"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tháng"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 34)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Báo cáo"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbbNam, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbbType, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbbMonth, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 111)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(318, 100)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 33)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Năm"
        '
        'cbbNam
        '
        Me.cbbNam.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbNam.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbNam.FormattingEnabled = True
        Me.cbbNam.Location = New System.Drawing.Point(162, 36)
        Me.cbbNam.Name = "cbbNam"
        Me.cbbNam.Size = New System.Drawing.Size(153, 33)
        Me.cbbNam.TabIndex = 9
        '
        'btnIn
        '
        Me.btnIn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnIn.Enabled = False
        Me.btnIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnIn.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnIn.Location = New System.Drawing.Point(273, 441)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(206, 39)
        Me.btnIn.TabIndex = 7
        Me.btnIn.Text = "In Báo Cáo"
        Me.btnIn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 92)
        Me.Panel1.TabIndex = 8
        '
        'PhieuBaoCao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(726, 492)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnIn)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.dgvBaoCao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PhieuBaoCao"
        Me.Text = "PhieuBaoCao"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvBaoCao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbbMonth As ComboBox
    Friend WithEvents cbbType As ComboBox
    Friend WithEvents dgvBaoCao As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnIn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents cbbNam As ComboBox
End Class
