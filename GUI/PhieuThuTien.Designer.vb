<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PhieuThuTien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvKhachHang = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSoTienThu = New System.Windows.Forms.TextBox()
        Me.txtTienNo = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNgayLap = New System.Windows.Forms.TextBox()
        Me.txtMaPhieuThu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbQuyDinh = New System.Windows.Forms.ComboBox()
        Me.txtNgay = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panelDate = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnHienKH = New System.Windows.Forms.Button()
        Me.btnChonKH = New System.Windows.Forms.Button()
        Me.btnTimKH = New System.Windows.Forms.Button()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbbHoTen = New System.Windows.Forms.ComboBox()
        Me.cbbSDT = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbbDiaChi = New System.Windows.Forms.ComboBox()
        Me.cbbTienNo = New System.Windows.Forms.ComboBox()
        Me.cbbEmail = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbbMaKhachHang = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnIn = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PanelKhachHang = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.dgvKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelDate.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.PanelKhachHang.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvKhachHang
        '
        Me.dgvKhachHang.AllowUserToDeleteRows = False
        Me.dgvKhachHang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvKhachHang.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvKhachHang.Location = New System.Drawing.Point(14, 220)
        Me.dgvKhachHang.Name = "dgvKhachHang"
        Me.dgvKhachHang.ReadOnly = True
        Me.dgvKhachHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKhachHang.Size = New System.Drawing.Size(505, 209)
        Me.dgvKhachHang.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 38)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mã Khách Hàng"
        '
        'txtSoTienThu
        '
        Me.txtSoTienThu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSoTienThu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSoTienThu.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtSoTienThu.HideSelection = False
        Me.txtSoTienThu.Location = New System.Drawing.Point(81, 117)
        Me.txtSoTienThu.MaxLength = 7
        Me.txtSoTienThu.Name = "txtSoTienThu"
        Me.txtSoTienThu.Size = New System.Drawing.Size(176, 23)
        Me.txtSoTienThu.TabIndex = 9
        '
        'txtTienNo
        '
        Me.txtTienNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTienNo.BackColor = System.Drawing.Color.White
        Me.txtTienNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTienNo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTienNo.HideSelection = False
        Me.txtTienNo.Location = New System.Drawing.Point(81, 79)
        Me.txtTienNo.Name = "txtTienNo"
        Me.txtTienNo.ReadOnly = True
        Me.txtTienNo.Size = New System.Drawing.Size(176, 23)
        Me.txtTienNo.TabIndex = 9
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiaChi.BackColor = System.Drawing.Color.White
        Me.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiaChi.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDiaChi.HideSelection = False
        Me.txtDiaChi.Location = New System.Drawing.Point(341, 41)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(176, 23)
        Me.txtDiaChi.TabIndex = 2
        '
        'txtSDT
        '
        Me.txtSDT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSDT.BackColor = System.Drawing.Color.White
        Me.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSDT.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtSDT.HideSelection = False
        Me.txtSDT.Location = New System.Drawing.Point(341, 79)
        Me.txtSDT.MaxLength = 12
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.ReadOnly = True
        Me.txtSDT.Size = New System.Drawing.Size(176, 23)
        Me.txtSDT.TabIndex = 3
        '
        'txtMaKH
        '
        Me.txtMaKH.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaKH.BackColor = System.Drawing.Color.White
        Me.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMaKH.Enabled = False
        Me.txtMaKH.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaKH.HideSelection = False
        Me.txtMaKH.Location = New System.Drawing.Point(81, 3)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.ReadOnly = True
        Me.txtMaKH.Size = New System.Drawing.Size(176, 23)
        Me.txtMaKH.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtEmail.HideSelection = False
        Me.txtEmail.Location = New System.Drawing.Point(341, 3)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(176, 23)
        Me.txtEmail.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Họ Tên"
        '
        'txtHoTen
        '
        Me.txtHoTen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoTen.BackColor = System.Drawing.Color.White
        Me.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHoTen.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtHoTen.HideSelection = False
        Me.txtHoTen.Location = New System.Drawing.Point(81, 41)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.ReadOnly = True
        Me.txtHoTen.Size = New System.Drawing.Size(176, 23)
        Me.txtHoTen.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(290, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(30, 0, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(3, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 38)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Số Tiền Thu"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(3, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 19)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Tiền Nợ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(290, 38)
        Me.Label11.Margin = New System.Windows.Forms.Padding(30, 0, 3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 38)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Địa Chỉ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(290, 76)
        Me.Label7.Margin = New System.Windows.Forms.Padding(30, 0, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "SĐT"
        '
        'txtNgayLap
        '
        Me.txtNgayLap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNgayLap.BackColor = System.Drawing.Color.White
        Me.txtNgayLap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNgayLap.Enabled = False
        Me.txtNgayLap.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtNgayLap.HideSelection = False
        Me.txtNgayLap.Location = New System.Drawing.Point(27, 0)
        Me.txtNgayLap.Margin = New System.Windows.Forms.Padding(0)
        Me.txtNgayLap.Name = "txtNgayLap"
        Me.txtNgayLap.ReadOnly = True
        Me.txtNgayLap.Size = New System.Drawing.Size(82, 23)
        Me.txtNgayLap.TabIndex = 18
        '
        'txtMaPhieuThu
        '
        Me.txtMaPhieuThu.BackColor = System.Drawing.Color.White
        Me.txtMaPhieuThu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMaPhieuThu.Enabled = False
        Me.txtMaPhieuThu.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaPhieuThu.HideSelection = False
        Me.txtMaPhieuThu.Location = New System.Drawing.Point(150, 67)
        Me.txtMaPhieuThu.Name = "txtMaPhieuThu"
        Me.txtMaPhieuThu.ReadOnly = True
        Me.txtMaPhieuThu.Size = New System.Drawing.Size(119, 23)
        Me.txtMaPhieuThu.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Ngày Lập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Mã Phiếu"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(184, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Phiếu Thu Tiền"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(11, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 19)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Quy Định Thu Tiền :"
        '
        'cbQuyDinh
        '
        Me.cbQuyDinh.Enabled = False
        Me.cbQuyDinh.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbQuyDinh.FormattingEnabled = True
        Me.cbQuyDinh.Items.AddRange(New Object() {"Được Phép thu tiền vượt số tiền nợ", "Không Được phép thu tiền vượt số tiền nợ"})
        Me.cbQuyDinh.Location = New System.Drawing.Point(155, 128)
        Me.cbQuyDinh.Name = "cbQuyDinh"
        Me.cbQuyDinh.Size = New System.Drawing.Size(377, 31)
        Me.cbQuyDinh.TabIndex = 26
        '
        'txtNgay
        '
        Me.txtNgay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNgay.BackColor = System.Drawing.Color.White
        Me.txtNgay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNgay.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtNgay.HideSelection = False
        Me.txtNgay.Location = New System.Drawing.Point(0, 0)
        Me.txtNgay.Margin = New System.Windows.Forms.Padding(0)
        Me.txtNgay.MaxLength = 2
        Me.txtNgay.Name = "txtNgay"
        Me.txtNgay.ReadOnly = True
        Me.txtNgay.Size = New System.Drawing.Size(27, 23)
        Me.txtNgay.TabIndex = 27
        Me.txtNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtNgayLap, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNgay, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(109, 20)
        Me.TableLayoutPanel1.TabIndex = 28
        '
        'panelDate
        '
        Me.panelDate.BackColor = System.Drawing.Color.White
        Me.panelDate.Controls.Add(Me.TableLayoutPanel1)
        Me.panelDate.Location = New System.Drawing.Point(150, 99)
        Me.panelDate.Name = "panelDate"
        Me.panelDate.Size = New System.Drawing.Size(119, 26)
        Me.panelDate.TabIndex = 29
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(288, 104)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 30
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.btnHienKH, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnChonKH, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnTimKH, 2, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(21, 179)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(484, 35)
        Me.TableLayoutPanel7.TabIndex = 35
        '
        'btnHienKH
        '
        Me.btnHienKH.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHienKH.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnHienKH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnHienKH.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnHienKH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnHienKH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnHienKH.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnHienKH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnHienKH.Location = New System.Drawing.Point(366, 3)
        Me.btnHienKH.Name = "btnHienKH"
        Me.btnHienKH.Size = New System.Drawing.Size(115, 29)
        Me.btnHienKH.TabIndex = 31
        Me.btnHienKH.Text = "Hiện tất cả khách"
        Me.btnHienKH.UseVisualStyleBackColor = False
        '
        'btnChonKH
        '
        Me.btnChonKH.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChonKH.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnChonKH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnChonKH.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnChonKH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnChonKH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnChonKH.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnChonKH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnChonKH.Location = New System.Drawing.Point(3, 3)
        Me.btnChonKH.Name = "btnChonKH"
        Me.btnChonKH.Size = New System.Drawing.Size(115, 29)
        Me.btnChonKH.TabIndex = 30
        Me.btnChonKH.Text = "Chọn Khách Hàng"
        Me.btnChonKH.UseVisualStyleBackColor = False
        '
        'btnTimKH
        '
        Me.btnTimKH.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTimKH.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnTimKH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnTimKH.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnTimKH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnTimKH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnTimKH.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnTimKH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnTimKH.Location = New System.Drawing.Point(245, 3)
        Me.btnTimKH.Name = "btnTimKH"
        Me.btnTimKH.Size = New System.Drawing.Size(115, 29)
        Me.btnTimKH.TabIndex = 29
        Me.btnTimKH.Text = "Tìm Khách Hàng"
        Me.btnTimKH.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 4
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label15, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.cbbHoTen, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.cbbSDT, 3, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label17, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.cbbDiaChi, 3, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.cbbTienNo, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.cbbEmail, 3, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label16, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label19, 2, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label18, 2, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.cbbMaKhachHang, 1, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(14, 80)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(495, 93)
        Me.TableLayoutPanel6.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(3, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 31)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Mã KH"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(3, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 31)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Họ Tên"
        '
        'cbbHoTen
        '
        Me.cbbHoTen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbHoTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbHoTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbHoTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbbHoTen.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbHoTen.FormattingEnabled = True
        Me.cbbHoTen.Location = New System.Drawing.Point(77, 34)
        Me.cbbHoTen.Name = "cbbHoTen"
        Me.cbbHoTen.Size = New System.Drawing.Size(167, 25)
        Me.cbbHoTen.TabIndex = 24
        '
        'cbbSDT
        '
        Me.cbbSDT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbSDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbSDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbSDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbbSDT.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbSDT.FormattingEnabled = True
        Me.cbbSDT.Location = New System.Drawing.Point(324, 65)
        Me.cbbSDT.Name = "cbbSDT"
        Me.cbbSDT.Size = New System.Drawing.Size(168, 25)
        Me.cbbSDT.TabIndex = 28
        '
        'Label17
        '
        Me.Label17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(3, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 31)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Tiền Nợ"
        '
        'cbbDiaChi
        '
        Me.cbbDiaChi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbDiaChi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbDiaChi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbDiaChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbbDiaChi.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbDiaChi.FormattingEnabled = True
        Me.cbbDiaChi.Location = New System.Drawing.Point(324, 34)
        Me.cbbDiaChi.Name = "cbbDiaChi"
        Me.cbbDiaChi.Size = New System.Drawing.Size(168, 25)
        Me.cbbDiaChi.TabIndex = 27
        '
        'cbbTienNo
        '
        Me.cbbTienNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbTienNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbTienNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbbTienNo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbTienNo.FormattingEnabled = True
        Me.cbbTienNo.Location = New System.Drawing.Point(77, 65)
        Me.cbbTienNo.Name = "cbbTienNo"
        Me.cbbTienNo.Size = New System.Drawing.Size(167, 25)
        Me.cbbTienNo.TabIndex = 25
        '
        'cbbEmail
        '
        Me.cbbEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbbEmail.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbEmail.FormattingEnabled = True
        Me.cbbEmail.Location = New System.Drawing.Point(324, 3)
        Me.cbbEmail.Name = "cbbEmail"
        Me.cbbEmail.Size = New System.Drawing.Size(168, 25)
        Me.cbbEmail.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(250, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 31)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Email"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(250, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 31)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "SĐT"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(250, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 31)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Địa Chỉ"
        '
        'cbbMaKhachHang
        '
        Me.cbbMaKhachHang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbMaKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbMaKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbMaKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbbMaKhachHang.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbMaKhachHang.FormattingEnabled = True
        Me.cbbMaKhachHang.Location = New System.Drawing.Point(77, 3)
        Me.cbbMaKhachHang.Name = "cbbMaKhachHang"
        Me.cbbMaKhachHang.Size = New System.Drawing.Size(167, 25)
        Me.cbbMaKhachHang.TabIndex = 17
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtSDT, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDiaChi, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSoTienThu, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEmail, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtTienNo, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMaKH, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtHoTen, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 166)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(520, 152)
        Me.TableLayoutPanel2.TabIndex = 36
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnRefresh, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnIn, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnSave, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(93, 324)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(330, 43)
        Me.TableLayoutPanel3.TabIndex = 38
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnRefresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnRefresh.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnRefresh.Image = Global.GUI.My.Resources.Resources.imgRefresh
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.Location = New System.Drawing.Point(3, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(104, 37)
        Me.btnRefresh.TabIndex = 23
        Me.btnRefresh.Text = "Làm Mới"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnIn
        '
        Me.btnIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnIn.Enabled = False
        Me.btnIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnIn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnIn.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnIn.Image = Global.GUI.My.Resources.Resources.imgExcel
        Me.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIn.Location = New System.Drawing.Point(223, 3)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(104, 37)
        Me.btnIn.TabIndex = 37
        Me.btnIn.Text = "     In"
        Me.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIn.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnSave.Image = Global.GUI.My.Resources.Resources.imgComplete1
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(113, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 37)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Hoàn Tất"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'PanelKhachHang
        '
        Me.PanelKhachHang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelKhachHang.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelKhachHang.Controls.Add(Me.Panel5)
        Me.PanelKhachHang.Controls.Add(Me.dgvKhachHang)
        Me.PanelKhachHang.Controls.Add(Me.TableLayoutPanel6)
        Me.PanelKhachHang.Controls.Add(Me.TableLayoutPanel7)
        Me.PanelKhachHang.Location = New System.Drawing.Point(571, 10)
        Me.PanelKhachHang.Margin = New System.Windows.Forms.Padding(10)
        Me.PanelKhachHang.Name = "PanelKhachHang"
        Me.PanelKhachHang.Size = New System.Drawing.Size(541, 452)
        Me.PanelKhachHang.TabIndex = 39
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(541, 59)
        Me.Panel5.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(192, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(239, 29)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Danh sách khách hàng"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.cbQuyDinh)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.panelDate)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.txtMaPhieuThu)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 452)
        Me.Panel1.TabIndex = 40
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(541, 59)
        Me.Panel4.TabIndex = 39
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.PanelKhachHang, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 66)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 472.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1122, 472)
        Me.TableLayoutPanel4.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1119, 70)
        Me.Panel3.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label13.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(16, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(250, 54)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Phiếu Thu Tiền"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1119, 540)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PhieuThuTien"
        Me.Text = "PhieuThuTien"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelDate.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.PanelKhachHang.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvKhachHang As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTienNo As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNgayLap As TextBox
    Friend WithEvents txtMaPhieuThu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSoTienThu As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbQuyDinh As ComboBox
    Friend WithEvents txtNgay As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents panelDate As Panel
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents btnChonKH As Button
    Friend WithEvents btnTimKH As Button
    Friend WithEvents btnHienKH As Button
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbbHoTen As ComboBox
    Friend WithEvents cbbSDT As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cbbDiaChi As ComboBox
    Friend WithEvents cbbTienNo As ComboBox
    Friend WithEvents cbbEmail As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cbbMaKhachHang As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnIn As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PanelKhachHang As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label13 As Label
End Class
