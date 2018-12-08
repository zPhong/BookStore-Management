<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PhieuTraCuu
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
        Me.dgvSach = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnHienSach = New System.Windows.Forms.Button()
        Me.btnTimSach = New System.Windows.Forms.Button()
        Me.btnChonSach = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbbMaSach = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbbTenSach = New System.Windows.Forms.ComboBox()
        Me.cbbSoLuongTon = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbbTacGia = New System.Windows.Forms.ComboBox()
        Me.cbbTheLoai = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSach
        '
        Me.dgvSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSach.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSach.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvSach.Location = New System.Drawing.Point(87, 336)
        Me.dgvSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvSach.Name = "dgvSach"
        Me.dgvSach.Size = New System.Drawing.Size(933, 195)
        Me.dgvSach.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(88, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 36)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tra cứu sách"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnHienSach, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnTimSach, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnChonSach, 2, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(143, 267)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(836, 61)
        Me.TableLayoutPanel5.TabIndex = 53
        '
        'btnHienSach
        '
        Me.btnHienSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHienSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnHienSach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnHienSach.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnHienSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnHienSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnHienSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHienSach.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnHienSach.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnHienSach.Location = New System.Drawing.Point(4, 4)
        Me.btnHienSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHienSach.Name = "btnHienSach"
        Me.btnHienSach.Size = New System.Drawing.Size(270, 53)
        Me.btnHienSach.TabIndex = 47
        Me.btnHienSach.Text = "Hiện tất cả sách"
        Me.btnHienSach.UseVisualStyleBackColor = False
        '
        'btnTimSach
        '
        Me.btnTimSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTimSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnTimSach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnTimSach.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnTimSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnTimSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnTimSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimSach.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnTimSach.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnTimSach.Location = New System.Drawing.Point(282, 4)
        Me.btnTimSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTimSach.Name = "btnTimSach"
        Me.btnTimSach.Size = New System.Drawing.Size(270, 53)
        Me.btnTimSach.TabIndex = 45
        Me.btnTimSach.Text = "Tìm Sách"
        Me.btnTimSach.UseVisualStyleBackColor = False
        '
        'btnChonSach
        '
        Me.btnChonSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChonSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnChonSach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnChonSach.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnChonSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnChonSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnChonSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChonSach.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnChonSach.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnChonSach.Location = New System.Drawing.Point(560, 4)
        Me.btnChonSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnChonSach.Name = "btnChonSach"
        Me.btnChonSach.Size = New System.Drawing.Size(272, 53)
        Me.btnChonSach.TabIndex = 46
        Me.btnChonSach.Text = "Chọn sách"
        Me.btnChonSach.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label16, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cbbMaSach, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label22, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.cbbTenSach, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.cbbSoLuongTon, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label20, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.cbbTacGia, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cbbTheLoai, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label23, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label21, 2, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(96, 94)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(924, 141)
        Me.TableLayoutPanel4.TabIndex = 52
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(4, 0)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(130, 47)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Mã Sách"
        '
        'cbbMaSach
        '
        Me.cbbMaSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbMaSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbMaSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbMaSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbbMaSach.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbMaSach.FormattingEnabled = True
        Me.cbbMaSach.Location = New System.Drawing.Point(142, 4)
        Me.cbbMaSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbbMaSach.Name = "cbbMaSach"
        Me.cbbMaSach.Size = New System.Drawing.Size(315, 39)
        Me.cbbMaSach.TabIndex = 33
        '
        'Label22
        '
        Me.Label22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(4, 94)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(130, 47)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Thể Loại"
        '
        'cbbTenSach
        '
        Me.cbbTenSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbTenSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbTenSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbTenSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbbTenSach.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbTenSach.FormattingEnabled = True
        Me.cbbTenSach.Location = New System.Drawing.Point(142, 51)
        Me.cbbTenSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbbTenSach.Name = "cbbTenSach"
        Me.cbbTenSach.Size = New System.Drawing.Size(315, 39)
        Me.cbbTenSach.TabIndex = 40
        '
        'cbbSoLuongTon
        '
        Me.cbbSoLuongTon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbSoLuongTon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbSoLuongTon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbSoLuongTon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbbSoLuongTon.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbSoLuongTon.FormattingEnabled = True
        Me.cbbSoLuongTon.Location = New System.Drawing.Point(603, 51)
        Me.cbbSoLuongTon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbbSoLuongTon.Name = "cbbSoLuongTon"
        Me.cbbSoLuongTon.Size = New System.Drawing.Size(317, 39)
        Me.cbbSoLuongTon.TabIndex = 43
        '
        'Label20
        '
        Me.Label20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(4, 47)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(130, 47)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "Tên Sách"
        '
        'cbbTacGia
        '
        Me.cbbTacGia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbTacGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbTacGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbbTacGia.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbTacGia.FormattingEnabled = True
        Me.cbbTacGia.Location = New System.Drawing.Point(603, 4)
        Me.cbbTacGia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbbTacGia.Name = "cbbTacGia"
        Me.cbbTacGia.Size = New System.Drawing.Size(317, 39)
        Me.cbbTacGia.TabIndex = 42
        '
        'cbbTheLoai
        '
        Me.cbbTheLoai.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbTheLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbTheLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbbTheLoai.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbTheLoai.FormattingEnabled = True
        Me.cbbTheLoai.Location = New System.Drawing.Point(142, 98)
        Me.cbbTheLoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbbTheLoai.Name = "cbbTheLoai"
        Me.cbbTheLoai.Size = New System.Drawing.Size(315, 39)
        Me.cbbTheLoai.TabIndex = 41
        '
        'Label23
        '
        Me.Label23.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(465, 47)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(130, 47)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "Số lượng tồn"
        '
        'Label21
        '
        Me.Label21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(465, 0)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(130, 47)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Tác Giả"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 73)
        Me.Panel1.TabIndex = 54
        '
        'PhieuTraCuu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 548)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.dgvSach)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PhieuTraCuu"
        Me.Text = "PhieuTraCuu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvSach As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btnHienSach As Button
    Friend WithEvents btnTimSach As Button
    Friend WithEvents btnChonSach As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label16 As Label
    Friend WithEvents cbbMaSach As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbbTenSach As ComboBox
    Friend WithEvents cbbSoLuongTon As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cbbTacGia As ComboBox
    Friend WithEvents cbbTheLoai As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel1 As Panel
End Class
