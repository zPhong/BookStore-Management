<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.picAvartar = New System.Windows.Forms.PictureBox()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMiniMize = New System.Windows.Forms.Button()
        Me.btnMaxiMize = New System.Windows.Forms.Button()
        Me.TablePanelTop = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelMenuStrip = New System.Windows.Forms.Panel()
        Me.btnLienHe = New System.Windows.Forms.Button()
        Me.PanelIntro = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelButton = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnPhieuNhapSach = New System.Windows.Forms.Button()
        Me.btnPhieuBanSach = New System.Windows.Forms.Button()
        Me.btnPhieuTraCuu = New System.Windows.Forms.Button()
        Me.btnPhieuThuTien = New System.Windows.Forms.Button()
        Me.btnPhieuBaoCao = New System.Windows.Forms.Button()
        Me.btnChinhSuaQuyDinh = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        CType(Me.picAvartar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TablePanelTop.SuspendLayout()
        Me.PanelMenuStrip.SuspendLayout()
        Me.PanelIntro.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnlInfo)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(596, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 81)
        Me.Panel1.TabIndex = 9
        '
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.pnlInfo.Controls.Add(Me.picAvartar)
        Me.pnlInfo.Controls.Add(Me.lblLevel)
        Me.pnlInfo.Controls.Add(Me.lblID)
        Me.pnlInfo.Controls.Add(Me.btnSignOut)
        Me.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlInfo.Location = New System.Drawing.Point(3, 0)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(223, 81)
        Me.pnlInfo.TabIndex = 10
        '
        'picAvartar
        '
        Me.picAvartar.Location = New System.Drawing.Point(4, 4)
        Me.picAvartar.Name = "picAvartar"
        Me.picAvartar.Size = New System.Drawing.Size(74, 74)
        Me.picAvartar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAvartar.TabIndex = 13
        Me.picAvartar.TabStop = False
        '
        'lblLevel
        '
        Me.lblLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblLevel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblLevel.Location = New System.Drawing.Point(84, 36)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(43, 19)
        Me.lblLevel.TabIndex = 1
        Me.lblLevel.Text = "Job : "
        '
        'lblID
        '
        Me.lblID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblID.Location = New System.Drawing.Point(84, 11)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(30, 19)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID :"
        '
        'btnSignOut
        '
        Me.btnSignOut.FlatAppearance.BorderSize = 0
        Me.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSignOut.ForeColor = System.Drawing.Color.White
        Me.btnSignOut.Location = New System.Drawing.Point(84, 52)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(110, 28)
        Me.btnSignOut.TabIndex = 14
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogin.Location = New System.Drawing.Point(54, 18)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(124, 44)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'PanelTitle
        '
        Me.PanelTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.PanelTitle.Controls.Add(Me.Label1)
        Me.PanelTitle.Controls.Add(Me.PictureBox1)
        Me.PanelTitle.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelTitle.ForeColor = System.Drawing.Color.White
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(822, 30)
        Me.PanelTitle.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "PHẦN MỀM QUẢN LÝ NHÀ SÁCH"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GUI.My.Resources.Resources.LogoCNPM
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMiniMize, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMaxiMize, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(722, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(100, 30)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnClose.Location = New System.Drawing.Point(66, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(34, 30)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMiniMize
        '
        Me.btnMiniMize.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMiniMize.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.btnMiniMize.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnMiniMize.FlatAppearance.BorderSize = 0
        Me.btnMiniMize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnMiniMize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMiniMize.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnMiniMize.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnMiniMize.Location = New System.Drawing.Point(0, 0)
        Me.btnMiniMize.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMiniMize.Name = "btnMiniMize"
        Me.btnMiniMize.Size = New System.Drawing.Size(33, 30)
        Me.btnMiniMize.TabIndex = 9
        Me.btnMiniMize.Text = "__"
        Me.btnMiniMize.UseVisualStyleBackColor = False
        '
        'btnMaxiMize
        '
        Me.btnMaxiMize.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaxiMize.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.btnMaxiMize.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnMaxiMize.FlatAppearance.BorderSize = 0
        Me.btnMaxiMize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnMaxiMize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaxiMize.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnMaxiMize.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnMaxiMize.Location = New System.Drawing.Point(33, 0)
        Me.btnMaxiMize.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMaxiMize.Name = "btnMaxiMize"
        Me.btnMaxiMize.Size = New System.Drawing.Size(33, 30)
        Me.btnMaxiMize.TabIndex = 10
        Me.btnMaxiMize.Text = "🗖"
        Me.btnMaxiMize.UseVisualStyleBackColor = False
        '
        'TablePanelTop
        '
        Me.TablePanelTop.ColumnCount = 1
        Me.TablePanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TablePanelTop.Controls.Add(Me.PanelTitle, 0, 0)
        Me.TablePanelTop.Controls.Add(Me.PanelMenuStrip, 0, 1)
        Me.TablePanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.TablePanelTop.Location = New System.Drawing.Point(0, 0)
        Me.TablePanelTop.Name = "TablePanelTop"
        Me.TablePanelTop.RowCount = 2
        Me.TablePanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TablePanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TablePanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TablePanelTop.Size = New System.Drawing.Size(822, 111)
        Me.TablePanelTop.TabIndex = 3
        '
        'PanelMenuStrip
        '
        Me.PanelMenuStrip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.PanelMenuStrip.Controls.Add(Me.btnLienHe)
        Me.PanelMenuStrip.Controls.Add(Me.PanelIntro)
        Me.PanelMenuStrip.Controls.Add(Me.Panel1)
        Me.PanelMenuStrip.Location = New System.Drawing.Point(0, 30)
        Me.PanelMenuStrip.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelMenuStrip.Name = "PanelMenuStrip"
        Me.PanelMenuStrip.Size = New System.Drawing.Size(822, 81)
        Me.PanelMenuStrip.TabIndex = 3
        '
        'btnLienHe
        '
        Me.btnLienHe.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnLienHe.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnLienHe.FlatAppearance.BorderSize = 0
        Me.btnLienHe.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.btnLienHe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnLienHe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnLienHe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLienHe.Font = New System.Drawing.Font("Candara", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLienHe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLienHe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLienHe.Location = New System.Drawing.Point(199, 3)
        Me.btnLienHe.Name = "btnLienHe"
        Me.btnLienHe.Size = New System.Drawing.Size(63, 74)
        Me.btnLienHe.TabIndex = 14
        Me.btnLienHe.Text = "☏" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Liên hệ"
        Me.btnLienHe.UseVisualStyleBackColor = False
        '
        'PanelIntro
        '
        Me.PanelIntro.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.PanelIntro.Controls.Add(Me.Label3)
        Me.PanelIntro.Controls.Add(Me.Label2)
        Me.PanelIntro.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIntro.Location = New System.Drawing.Point(0, 0)
        Me.PanelIntro.Name = "PanelIntro"
        Me.PanelIntro.Size = New System.Drawing.Size(193, 81)
        Me.PanelIntro.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Because You're Worth It"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SouthWind Company"
        '
        'PanelButton
        '
        Me.PanelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PanelButton.Controls.Add(Me.btnPhieuNhapSach)
        Me.PanelButton.Controls.Add(Me.btnPhieuBanSach)
        Me.PanelButton.Controls.Add(Me.btnPhieuTraCuu)
        Me.PanelButton.Controls.Add(Me.btnPhieuThuTien)
        Me.PanelButton.Controls.Add(Me.btnPhieuBaoCao)
        Me.PanelButton.Controls.Add(Me.btnChinhSuaQuyDinh)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelButton.Location = New System.Drawing.Point(0, 111)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(190, 389)
        Me.PanelButton.TabIndex = 12
        '
        'btnPhieuNhapSach
        '
        Me.btnPhieuNhapSach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPhieuNhapSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnPhieuNhapSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPhieuNhapSach.FlatAppearance.BorderSize = 0
        Me.btnPhieuNhapSach.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.btnPhieuNhapSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnPhieuNhapSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnPhieuNhapSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPhieuNhapSach.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnPhieuNhapSach.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPhieuNhapSach.Image = Global.GUI.My.Resources.Resources.BookStoreIcon1
        Me.btnPhieuNhapSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPhieuNhapSach.Location = New System.Drawing.Point(3, 3)
        Me.btnPhieuNhapSach.Name = "btnPhieuNhapSach"
        Me.btnPhieuNhapSach.Size = New System.Drawing.Size(190, 55)
        Me.btnPhieuNhapSach.TabIndex = 0
        Me.btnPhieuNhapSach.Text = "           Lập phiếu nhập sách"
        Me.btnPhieuNhapSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPhieuNhapSach.UseVisualStyleBackColor = False
        '
        'btnPhieuBanSach
        '
        Me.btnPhieuBanSach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPhieuBanSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnPhieuBanSach.FlatAppearance.BorderSize = 0
        Me.btnPhieuBanSach.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.btnPhieuBanSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnPhieuBanSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnPhieuBanSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPhieuBanSach.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnPhieuBanSach.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPhieuBanSach.Image = Global.GUI.My.Resources.Resources.imgBan
        Me.btnPhieuBanSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPhieuBanSach.Location = New System.Drawing.Point(3, 64)
        Me.btnPhieuBanSach.Name = "btnPhieuBanSach"
        Me.btnPhieuBanSach.Size = New System.Drawing.Size(190, 55)
        Me.btnPhieuBanSach.TabIndex = 1
        Me.btnPhieuBanSach.Text = "          Lập phiếu bán sách"
        Me.btnPhieuBanSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPhieuBanSach.UseVisualStyleBackColor = False
        '
        'btnPhieuTraCuu
        '
        Me.btnPhieuTraCuu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPhieuTraCuu.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnPhieuTraCuu.FlatAppearance.BorderSize = 0
        Me.btnPhieuTraCuu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.btnPhieuTraCuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnPhieuTraCuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnPhieuTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPhieuTraCuu.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnPhieuTraCuu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPhieuTraCuu.Image = Global.GUI.My.Resources.Resources.imgSearch
        Me.btnPhieuTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPhieuTraCuu.Location = New System.Drawing.Point(3, 125)
        Me.btnPhieuTraCuu.Name = "btnPhieuTraCuu"
        Me.btnPhieuTraCuu.Size = New System.Drawing.Size(190, 55)
        Me.btnPhieuTraCuu.TabIndex = 4
        Me.btnPhieuTraCuu.Text = "           Tra cứu sách"
        Me.btnPhieuTraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPhieuTraCuu.UseVisualStyleBackColor = False
        '
        'btnPhieuThuTien
        '
        Me.btnPhieuThuTien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPhieuThuTien.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnPhieuThuTien.FlatAppearance.BorderSize = 0
        Me.btnPhieuThuTien.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.btnPhieuThuTien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnPhieuThuTien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnPhieuThuTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPhieuThuTien.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnPhieuThuTien.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPhieuThuTien.Image = Global.GUI.My.Resources.Resources.imgThuTien2
        Me.btnPhieuThuTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPhieuThuTien.Location = New System.Drawing.Point(3, 186)
        Me.btnPhieuThuTien.Name = "btnPhieuThuTien"
        Me.btnPhieuThuTien.Size = New System.Drawing.Size(190, 55)
        Me.btnPhieuThuTien.TabIndex = 1
        Me.btnPhieuThuTien.Text = "           Lập Phiếu Thu Tiền"
        Me.btnPhieuThuTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPhieuThuTien.UseVisualStyleBackColor = False
        '
        'btnPhieuBaoCao
        '
        Me.btnPhieuBaoCao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPhieuBaoCao.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnPhieuBaoCao.FlatAppearance.BorderSize = 0
        Me.btnPhieuBaoCao.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.btnPhieuBaoCao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnPhieuBaoCao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnPhieuBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPhieuBaoCao.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnPhieuBaoCao.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPhieuBaoCao.Image = Global.GUI.My.Resources.Resources.imgBaoCao
        Me.btnPhieuBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPhieuBaoCao.Location = New System.Drawing.Point(3, 247)
        Me.btnPhieuBaoCao.Name = "btnPhieuBaoCao"
        Me.btnPhieuBaoCao.Size = New System.Drawing.Size(190, 55)
        Me.btnPhieuBaoCao.TabIndex = 3
        Me.btnPhieuBaoCao.Text = "           Lập Báo Cáo"
        Me.btnPhieuBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPhieuBaoCao.UseVisualStyleBackColor = False
        '
        'btnChinhSuaQuyDinh
        '
        Me.btnChinhSuaQuyDinh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChinhSuaQuyDinh.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnChinhSuaQuyDinh.FlatAppearance.BorderSize = 0
        Me.btnChinhSuaQuyDinh.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.btnChinhSuaQuyDinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnChinhSuaQuyDinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnChinhSuaQuyDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChinhSuaQuyDinh.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnChinhSuaQuyDinh.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnChinhSuaQuyDinh.Image = Global.GUI.My.Resources.Resources.imgLaw
        Me.btnChinhSuaQuyDinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChinhSuaQuyDinh.Location = New System.Drawing.Point(3, 308)
        Me.btnChinhSuaQuyDinh.Name = "btnChinhSuaQuyDinh"
        Me.btnChinhSuaQuyDinh.Size = New System.Drawing.Size(190, 55)
        Me.btnChinhSuaQuyDinh.TabIndex = 2
        Me.btnChinhSuaQuyDinh.Text = "           Chỉnh sửa quy định"
        Me.btnChinhSuaQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChinhSuaQuyDinh.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(822, 500)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.TablePanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Quản Lý Nhà Sách"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.Panel1.ResumeLayout(False)
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        CType(Me.picAvartar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TablePanelTop.ResumeLayout(False)
        Me.PanelMenuStrip.ResumeLayout(False)
        Me.PanelIntro.ResumeLayout(False)
        Me.PanelIntro.PerformLayout()
        Me.PanelButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPhieuNhapSach As Button
    Friend WithEvents btnPhieuBanSach As Button
    Friend WithEvents btnChinhSuaQuyDinh As Button
    Friend WithEvents btnPhieuThuTien As Button
    Friend WithEvents btnPhieuBaoCao As Button
    Friend WithEvents btnPhieuTraCuu As Button
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents TablePanelTop As TableLayoutPanel
    Friend WithEvents PanelMenuStrip As Panel
    Friend WithEvents btnMiniMize As Button
    Friend WithEvents btnMaxiMize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents lblLevel As Label
    Friend WithEvents lblID As Label
    Friend WithEvents PanelIntro As Panel
    Friend WithEvents btnSignOut As Button
    Friend WithEvents picAvartar As PictureBox
    Friend WithEvents PanelButton As FlowLayoutPanel
    Friend WithEvents btnLienHe As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
