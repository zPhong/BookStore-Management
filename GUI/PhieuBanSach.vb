Imports Bus.BUS.PhieuNhapSachBUS
Imports DTO.DTO.ThamSoDTO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows
Imports System.Globalization
Public Class PhieuBanSach

#Region "Khai báo các thông số xử lý"
    Dim ts As New DTO.DTO.ThamSoDTO
    Dim intCountedClick_AddKH As String = 0
    Dim isHoaDonValid As Boolean = False
    Dim isFinishInit As Boolean = False
    Dim provider As CultureInfo = CultureInfo.InvariantCulture

#End Region


    Private Sub PhieuBanSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ts.Create()
        ReFreshDataKH()
        ReFreshDataAllSach()

        LoadDataGrid()
        'Tao gia tri mac dinh khi form load
        txtNgayLap.Text = "/" + DateTime.Now.ToString("MM/yyyy")
        txtNgay.Text = DateTime.Now.Day.ToString
        txtMaPhieuBan.Text = functionToUse.CreatePrimaryKey("hoadon", "mahoadon", "MHD", 0)
        dgvHD.AutoGenerateColumns = False
        isFinishInit = True

        'Xử lý hiệu ứng mdi
        With Me
            .Opacity = 0
            .WindowState = FormWindowState.Maximized
            .Opacity = 100
        End With

    End Sub

#Region "Xử lý nội dung chính phiếu bán sách"
    Public Sub ClearKH()
        txtMaKH.Text = ""
        txtHoTen.Text = ""
        txtEmail.Text = ""
        txtSDT.Text = ""
        txtDiaChi.Text = ""
        txtTienNo.Text = "0"

        txtHoTen.ReadOnly = True
        txtEmail.ReadOnly = True
        txtDiaChi.ReadOnly = True
        txtSDT.ReadOnly = True
        dgvHD.SelectAll()
        dgvHD.ClearSelection()

        intCountedClick_AddKH = 0
        btnAddKH.Text = "Nhập Khách Hàng Mới"

        txtThanhTienNum.Text = "0"
        txtThanhTienChar.Text = "khong"

    End Sub

    Private Sub LoadDataGrid()
        'Tao Bang Sach Trong Phieu voi cac columns
        dgvHD.ColumnCount = 9
        dgvHD.Columns(0).Name = "MaSach"
        dgvHD.Columns(1).Name = "TenSach"
        dgvHD.Columns(2).Name = "TheLoai"
        dgvHD.Columns(3).Name = "TacGia"
        dgvHD.Columns(5).Name = "DonGia"
        dgvHD.Columns(6).Name = "SoLuong"
        dgvHD.Columns(4).Name = "SoLuongTon"
        dgvHD.Columns(7).Name = "ThanhTien"
        dgvHD.Columns(8).Name = "Ton"


        dgvSach.Columns(0).Name = "MaSach"
        dgvSach.Columns(1).Name = "TenSach"
        dgvSach.Columns(2).Name = "TheLoai"
        dgvSach.Columns(3).Name = "TacGia"
        dgvSach.Columns(4).Name = "SoLuong"


    End Sub

    Private Sub BtnAddKH_Click(sender As Object, e As EventArgs) Handles btnAddKH.Click

        If (intCountedClick_AddKH = 0) Then
            ClearKH()
            btnAddKH.Text = "Lưu Khách Hàng"

            txtMaKH.Text = functionToUse.CreatePrimaryKey("khachhang", "makhachhang", "KH", 0)
            txtHoTen.ReadOnly = False
            txtEmail.ReadOnly = False
            txtDiaChi.ReadOnly = False
            txtSDT.ReadOnly = False
            txtTienNo.Text = "0"
            intCountedClick_AddKH = 1
        Else

            If (txtHoTen.Text.Trim <> "" And txtDiaChi.Text.Trim <> "" And txtEmail.Text.Trim <> "" And txtSDT.Text.Trim <> "") Then
                intCountedClick_AddKH = 0
                btnAddKH.Text = "Nhập Khách Hàng Mới"
                Dim KHDTO = New DTO.DTO.KhachHangDTO


                KHDTO.MaKH = txtMaKH.Text.Trim
                KHDTO.HoTen = txtHoTen.Text.Trim
                KHDTO.Email = txtEmail.Text.Trim
                KHDTO.DiaChi = txtDiaChi.Text.Trim
                KHDTO.DienThoai = txtSDT.Text.Trim
                KHDTO.SoTienNo = 0

                Bus.BUS.KhachHangBUS.insertKhachHang(KHDTO)

                ReFreshDataKH()
                ClearKH()
            Else
                MessageBox.Show("Vui lòng điền thông tin")
            End If

        End If


    End Sub

    Private Sub btnChuyenBang_Click(sender As Object, e As EventArgs) Handles btnChuyenBang.Click

        If (intCountedClick_AddKH = 1) Then
            btnAddKH.Text = "Nhập Khách Hàng Mới"
            intCountedClick_AddKH = 0
        End If
        If (PanelKhachHang.Visible = False) Then
            ' btnChuyenBang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            btnChuyenBang.Text = "Qua bảng sách"
            PanelKhachHang.Visible = True

        Else
            btnChuyenBang.Text = "Qua bảng khách hàng"
            PanelKhachHang.Visible = False
        End If

    End Sub


    Private Sub dgvHD_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHD.CellEndEdit
        ' chinh lai so luong ton hien thi
        Dim soluongmax As Integer = Int32.Parse(dgvHD.Item("Ton", e.RowIndex).Value) - ts.SoLuongTonMin
        If (dgvHD.Columns(e.ColumnIndex).Name = "SoLuong") Then
            dgvHD.Item("SoLuongTon", e.RowIndex).Value = dgvHD.Item("Ton", e.RowIndex).Value
            If (dgvHD.Item("SoLuong", e.RowIndex).Value > soluongmax) Then
                dgvHD.Item("SoLuong", e.RowIndex).Value = soluongmax
                dgvHD.Item("SoLuongTon", e.RowIndex).Value = ts.SoLuongTonMin
                dgvHD.Item("SoLuongTon", e.RowIndex).Style.BackColor = Color.Red

            Else
                dgvHD.Item("SoLuongTon", e.RowIndex).Style.BackColor = Color.White
                dgvHD.Item("SoLuongTon", e.RowIndex).Value -= dgvHD.Item("SoLuong", e.RowIndex).Value
            End If
        End If

        ''tinh thanh tien cua tung row
        Dim TT As Integer = Int32.Parse(dgvHD.Item("DonGia", e.RowIndex).Value) * Int32.Parse(dgvHD.Item("SoLuong", e.RowIndex).Value)
        If (dgvHD.Columns(e.ColumnIndex).Name = "DonGia" Or dgvHD.Columns(e.ColumnIndex).Name = "SoLuong") Then
            dgvHD.Item("ThanhTien", e.RowIndex).Value = TT
        End If

        ''tinh thanh tien cua phieu
        Dim sum As Long = 0

        For Each eachRow As DataGridViewRow In dgvHD.Rows
            sum += eachRow.Cells(7).Value
        Next

        txtThanhTienNum.Text = sum.ToString
        txtThanhTienChar.Text = functionToUse.Num2Text(sum.ToString)
    End Sub



    Private Sub btnXoaTrongPhieu_Click(sender As Object, e As EventArgs) Handles btnXoaTrongPhieu.Click
        'Xóa hàng dc chọn
        If (dgvHD.Rows.Count > 1) Then
            dgvHD.Rows.RemoveAt(dgvHD.CurrentCell.RowIndex)
        End If
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ClearKH()
        ' clear gridbox HD 
        dgvHD.Rows.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'KHi thành tiền rỗng
        If (txtThanhTienNum.Text = "0") Then
            MessageBox.Show("Vui lòng mua ít nhất 1 sản phẩm")
            Return
        End If

        If (txtHoTen.Text.Trim <> "" And txtDiaChi.Text.Trim <> "" And txtEmail.Text.Trim <> "" And txtSDT.Text.Trim <> "") Then
            If (Integer.Parse(txtTienNo.Text) <= functionToUse.LoadThamSoQuyDinh(3)) Then
                'add Data
                Dim index As Integer = dgvHD.Rows.Count

                If (index > 1) Then

                    'Khai báo hóa đơn mới
                    Dim hd As New DTO.DTO.PhieuHoaDon
                    hd.MaHD = txtMaPhieuBan.Text
                    hd.MaKH = txtMaKH.Text
                    hd.NgayLapHoaDon = DateTime.ParseExact(txtNgay.Text.Trim + txtNgayLap.Text.Trim, "dd/MM/yyyy", provider)

                    'Biến kiểm tra hóa đơn hợp lệ số lượng nhập và đơn giá bán có rỗng hoặc=0
                    Dim checkValid As Boolean = True

                    For i As Integer = 0 To dgvHD.Rows.Count - 2
                        If (dgvHD.Rows(i).Cells(7).Value.ToString() = "0" Or dgvHD.Rows(i).Cells(7).Value.ToString() = "") Then
                            checkValid = False
                            Exit For
                        End If
                    Next

                    If (checkValid = False) Then
                        MessageBox.Show("Hóa đơn không hợp lệ, kiểm tra lại thành tiền, đơn giá, số lượng ")
                        Return
                    End If

                    'Insert sau khi hợp lệ
                    Bus.BUS.HoaDonBUS.insertHoaDon(hd)


                    For i As Integer = 0 To dgvHD.Rows.Count - 2
                        'Khai báo chi tiết hóa đơn
                        Dim cthd As New DTO.DTO.ChiTietPhieuHoaDon
                        Dim sachDTO As New DTO.DTO.SachDTO
                        Dim bctDTO As New DTO.DTO.BaoCaoTonDTO

                        'Insert Chi tiết hóa đơn mới
                        cthd.MaCTHD = functionToUse.CreatePrimaryKey("chitiethoadon", "machitiethoadon", "CHD", 0)
                        cthd.MaHD = txtMaPhieuBan.Text
                        cthd.MaSach = dgvHD.Rows(i).Cells(0).Value.ToString()
                        cthd.DonGia = dgvHD.Rows(i).Cells(5).Value.ToString()
                        cthd.SoLuongBan = dgvHD.Rows(i).Cells(6).Value.ToString()
                        Bus.BUS.ChiTietHoaDonBUS.insertCTHoaDon(cthd)

                        'Cập nhật lại sách 
                        sachDTO.MaSach = dgvHD.Rows(i).Cells(0).Value.ToString()
                        sachDTO.TenSach = dgvHD.Rows(i).Cells(1).Value.ToString()
                        sachDTO.TheLoai = dgvHD.Rows(i).Cells(3).Value.ToString()
                        sachDTO.TacGia = dgvHD.Rows(i).Cells(2).Value.ToString()
                        sachDTO.SoLuongTon = Integer.Parse(dgvHD.Rows(i).Cells(4).Value.ToString())
                        Bus.BUS.SachBUS.updateSach(sachDTO)

                        'Update bao cao ton

                        Dim baocaotonDTO As New DTO.DTO.BaoCaoTonDTO
                        Dim thang = Today.Month
                        Dim Row = dgvHD.Rows(i)

                        baocaotonDTO.MaTon = functionToUse.CreatePrimaryKey("baocaoton", "maton", "MT", 0)
                        baocaotonDTO.Thang = Today.Month
                        baocaotonDTO.MaSach = Row.Cells(0).Value.ToString
                        baocaotonDTO.TonCuoi = Integer.Parse(Row.Cells(4).Value)

                        'Dữ liệu tồn tháng trước'
                        Dim dttBaoCaoTon As DataTable = functionToUse.LoadData("baocaoton", "maton")
                        Dim dtSelectedLastMonth() As DataRow = dttBaoCaoTon.Select(String.Format("masach='{0}' AND thang={1}", Row.Cells(0).Value.ToString, thang - 1))

                        'Dữ liệu tồn tháng này
                        dttBaoCaoTon = functionToUse.LoadData("baocaoton", "maton")
                        Dim dtSelectedThisMonth() As DataRow = dttBaoCaoTon.Select(String.Format("masach='{0}' AND thang={1}", Row.Cells(0).Value.ToString, thang))

                        'Nếu tồn tại tháng trước
                        If (dtSelectedLastMonth.Count >= 1) Then
                            baocaotonDTO.TonDau = Integer.Parse(dtSelectedLastMonth(0)(5).ToString())
                        Else
                            baocaotonDTO.TonDau = 0
                        End If

                        'Rut ton phat sinh tu thang hien tai

                        If (dtSelectedThisMonth.Count >= 1) Then
                            'baocaotonDTO.TonPhatSinh = Integer.Parse(dtSelectedThisMonth(0)(4).ToString()) + Integer.Parse(row.Cells(4).Value)
                            baocaotonDTO.TonPhatSinh = baocaotonDTO.TonCuoi - baocaotonDTO.TonDau
                            Bus.BUS.BaoCaoTonBUS.updateBaoCaoTon(baocaotonDTO)
                        Else
                            baocaotonDTO.Create(functionToUse.CreatePrimaryKey("baocaoton", "maton", "MT", 0), Row.Cells(0).Value.ToString, thang, baocaotonDTO.TonDau, baocaotonDTO.TonCuoi - baocaotonDTO.TonDau, baocaotonDTO.TonCuoi)
                            Bus.BUS.BaoCaoTonBUS.insertBaoCaoTon(baocaotonDTO)
                        End If
                    Next

                    'Cập nhậ tiền nợ kh
                    Dim kh As New DTO.DTO.KhachHangDTO
                    kh.MaKH = txtMaKH.Text
                    kh.SoTienNo = Integer.Parse(txtTienNo.Text)
                    functionToUse.UpdateTienNo(Integer.Parse(txtThanhTienNum.Text), Today.Month, kh)


                    'Khởi tạo giá trị mới cho form
                    MessageBox.Show("Thanh toán thành công ")
                    txtMaPhieuBan.Text = functionToUse.CreatePrimaryKey("hoadon", "mahoadon", "MHD", 0)
                    ReFreshDataKH()
                    ReFreshDataAllSach()

                    btnRefresh_Click(sender, e)
                Else
                    MessageBox.Show("Ít nhất mua 1 sản phẩm")
                End If
            Else
                MessageBox.Show("Khách hàng nợ quá nhiều !!!!")
            End If
        Else

            MessageBox.Show("Vui lòng nhập khách hàng !")

        End If

    End Sub


#End Region


#Region "Xủ lý chức năng panel tra cứu và chọn sách"

    Private Sub btnHienSach_Click(sender As Object, e As EventArgs) Handles btnHienSach.Click
        ReFreshDataAllSach()
        cbbMaSach.Text = ""
        cbbTenSach.Text = ""
        cbbTacGia.Text = ""
        cbbTheLoai.Text = ""
        cbbSoLuongTon.Text = ""
    End Sub

    Private Sub ClearAllItem_cbbSach()
        cbbMaSach.Items.Clear()
        cbbTenSach.Items.Clear()
        cbbTacGia.Items.Clear()
        cbbSoLuongTon.Items.Clear()
        cbbTheLoai.Items.Clear()
    End Sub

    Private Sub ReFreshDataAllSach()
        Dim dttAllSach = functionToUse.LoadData("sach", "masach")
        dgvSach.DataSource = dttAllSach
        dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSach.ReadOnly = True
        If (dgvSach.Rows.Count > 0) Then
            dgvSach.Rows(0).Selected = True
            btnChonSach.Enabled = True
            btnTimSach.Enabled = True
        Else
            btnChonSach.Enabled = False
            btnTimSach.Enabled = False
        End If

        ClearAllItem_cbbSach()
        For Each row As DataRow In dttAllSach.Rows
            cbbMaSach.Items.Add(row(0))
            cbbTenSach.Items.Add(row(1))
            cbbTheLoai.Items.Add(row(2))
            cbbTacGia.Items.Add(row(3))
            cbbSoLuongTon.Items.Add(row(4))
        Next
    End Sub
    'Xử lý khi chọn sách
    Private Sub btnChonSach_Click(sender As Object, e As EventArgs) Handles btnChonSach.Click

        If (isFinishInit) Then
            'Khai báo hàng vừa chọn
            Dim isExistFromPhieu As Boolean = True
            Dim index As Integer
            Dim sachDTO = New DTO.DTO.SachDTO()
            index = dgvSach.CurrentRow.Index

            'Nếu bảng sách có dữ liệu
            If (index <> dgvSach.RowCount - 1) Then

                'Nếu số lượng tồn của sách hợp lệ
                If (dgvSach.Rows(index).Cells(4).Value > ts.SoLuongTonMin) Then

                    'Khai báo dữ liệu sách DTO
                    sachDTO.MaSach = dgvSach.Rows(index).Cells(0).Value.ToString
                    sachDTO.TenSach = dgvSach.Rows(index).Cells(1).Value.ToString
                    sachDTO.TheLoai = dgvSach.Rows(index).Cells(3).Value.ToString
                    sachDTO.TacGia = dgvSach.Rows(index).Cells(2).Value.ToString
                    sachDTO.SoLuongTon = dgvSach.Rows(index).Cells(4).Value.ToString

                    ''kiem tra sach co sẵn trong HD ko
                    For Each eachRow As DataGridViewRow In dgvHD.Rows
                        If (dgvHD.RowCount > 1 And eachRow.Index < dgvHD.RowCount - 1) Then
                            If (eachRow.Cells(0).Value.ToString() = sachDTO.MaSach) Then
                                isExistFromPhieu = True
                                Exit For
                            End If
                        Else
                            isExistFromPhieu = False
                        End If
                    Next

                    'Tạo lại sách với số lượng tồn=0 nếu sách không có sẵn
                    If (isExistFromPhieu = False) Then

                        Dim row As String()
                        row = New String() {sachDTO.MaSach,
                                             sachDTO.TenSach, sachDTO.TheLoai,
                                              sachDTO.TacGia, sachDTO.SoLuongTon,
                                                 "0", "0", "0", sachDTO.SoLuongTon}

                        'Thêm sách vào háo đon
                        dgvHD.Rows.Add(row)

                    End If
                End If

            End If

        End If

    End Sub
    'Xử lý tìm kiếm sách
    Private Sub btnTimSach_Click(sender As Object, e As EventArgs) Handles btnTimSach.Click
        'Khai báo chuỗi tìm kiếm và bảng sách
        Dim dttSach = functionToUse.LoadData("sach", "masach")
        Dim strChuoiTimKiem As String = ""
        Dim intSoTuKhoa = 0

        'Thêm từ khóa vào chuỗi tim kiếm
        If (cbbMaSach.Text <> "") Then
            strChuoiTimKiem &= "masach='" & cbbMaSach.Text & "' AND "
            intSoTuKhoa += 1
        End If

        If (cbbTenSach.Text <> "") Then
            strChuoiTimKiem &= "tensach='" & cbbTenSach.Text & "' AND "
            intSoTuKhoa += 1
        End If

        If (cbbTheLoai.Text <> "") Then
            strChuoiTimKiem &= "theloai='" + cbbTheLoai.Text + "' AND "
            intSoTuKhoa += 1
        End If

        If (cbbTacGia.Text <> "") Then
            strChuoiTimKiem &= "tacgia='" + cbbTacGia.Text + "' AND "
            intSoTuKhoa += 1
        End If

        If (cbbSoLuongTon.Text <> "") Then
            strChuoiTimKiem &= "soluongton=" & cbbSoLuongTon.Text & " AND "
            intSoTuKhoa += 1
        End If

        'Tiến hành tìm kiếm
        If (intSoTuKhoa <> 0) Then
            strChuoiTimKiem = strChuoiTimKiem.Remove(strChuoiTimKiem.Length - 4, 4)

            Dim dtrTimKiemSach() As DataRow = dttSach.Select(strChuoiTimKiem)
            Dim dttSearch = dttSach.Clone()
            For Each row As DataRow In dtrTimKiemSach
                dttSearch.ImportRow(row)
            Next
            'Cập nhật panel
            dgvSach.SelectAll()
            dgvSach.ClearSelection()
            dgvSach.DataSource = dttSearch


            If (dgvSach.Rows.Count <= 1) Then
                btnChonSach.Enabled = False
            Else
                btnChonSach.Enabled = True
            End If
        End If

    End Sub


#End Region



#Region "Xử lý bảng tra cứu khách hàng"

    Private Sub btnHienKH_Click(sender As Object, e As EventArgs) Handles btnHienKH.Click
        ReFreshDataKH()
        cbbMaKhachHang.Text = ""
        cbbHoTen.Text = ""
        cbbEmail.Text = ""
        cbbDiaChi.Text = ""
        cbbTienNo.Text = ""
        cbbSDT.Text = ""

    End Sub

    Private Sub ReFreshDataKH()
        'Câp nhat bảng kh
        Dim dttKH = functionToUse.LoadData("khachhang", "makhachhang")
        dgvKhachHang.DataSource = dttKH
        dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKhachHang.ReadOnly = True
        If (dgvKhachHang.Rows.Count > 0) Then
            dgvKhachHang.Rows(0).Selected = True
            btnChonKH.Enabled = True
            btnTimKH.Enabled = True
        Else
            btnChonKH.Enabled = False
            btnTimKH.Enabled = False
        End If
        ClearAllItem_cbbKH()
        'Cập nhật cbb liên quan
        For Each row As DataRow In dttKH.Rows
            cbbMaKhachHang.Items.Add(row(0))
            cbbHoTen.Items.Add(row(1))
            cbbDiaChi.Items.Add(row(2))
            cbbEmail.Items.Add(row(3))
            cbbSDT.Items.Add(row(4))
            cbbTienNo.Items.Add(row(5))
        Next
    End Sub

    Private Sub btnChonKH_Click(sender As Object, e As EventArgs) Handles btnChonKH.Click
        dgvHD.Rows.Clear()
        If (isFinishInit) Then
            ClearKH()
            Dim index As Integer
            index = dgvKhachHang.CurrentRow.Index
            'Nếu bảng hông trống
            If (index <> dgvKhachHang.RowCount - 1) Then
                txtMaKH.Text = dgvKhachHang.Rows(index).Cells(0).Value.ToString
                txtHoTen.Text = dgvKhachHang.Rows(index).Cells(1).Value.ToString
                txtDiaChi.Text = dgvKhachHang.Rows(index).Cells(2).Value.ToString
                txtEmail.Text = dgvKhachHang.Rows(index).Cells(3).Value.ToString
                txtSDT.Text = dgvKhachHang.Rows(index).Cells(4).Value.ToString
                txtTienNo.Text = dgvKhachHang.Rows(index).Cells(5).Value.ToString


                txtHoTen.ReadOnly = True
                txtEmail.ReadOnly = True
                txtDiaChi.ReadOnly = True
                txtSDT.ReadOnly = True
                btnAddKH.Text = "Nhập Khách Hàng Mới"
                intCountedClick_AddKH = 0
            End If

        End If
    End Sub

    Private Sub ClearAllItem_cbbKH()
        cbbMaKhachHang.Items.Clear()
        cbbHoTen.Items.Clear()
        cbbDiaChi.Items.Clear()
        cbbEmail.Items.Clear()
        cbbSDT.Items.Clear()
        cbbTienNo.Items.Clear()
    End Sub

    Private Sub BtnTimKH_Click(sender As Object, e As EventArgs) Handles btnTimKH.Click
        'Khai báo chuỗi tìm kiếm khách hàng
        Dim dttKH = functionToUse.LoadData("khachhang", "makh")
        Dim strChuoiTimKiem As String = ""
        Dim intSoTuKhoa = 0

        'Thêm từ khóa vào khách hàng
        If (cbbMaKhachHang.Text <> "") Then
            strChuoiTimKiem &= "makhachhang='" & cbbMaKhachHang.Text & "' AND "
            intSoTuKhoa += 1
        End If
        If (cbbHoTen.Text <> "") Then
            strChuoiTimKiem &= "hotenkhachhang='" & cbbHoTen.Text & "' AND "
            intSoTuKhoa += 1
        End If
        If (cbbDiaChi.Text <> "") Then
            strChuoiTimKiem &= "diachi='" + cbbDiaChi.Text + "' AND "
            intSoTuKhoa += 1
        End If
        If (cbbEmail.Text <> "") Then
            strChuoiTimKiem &= "email='" + cbbEmail.Text + "' AND "
            intSoTuKhoa += 1
        End If
        If (cbbSDT.Text <> "") Then
            strChuoiTimKiem &= "sodienthoai='" & cbbSDT.Text & "' AND "
            intSoTuKhoa += 1
        End If
        If (cbbTienNo.Text <> "") Then
            strChuoiTimKiem &= "tiennokhachhang=" & cbbTienNo.Text & " AND "
            intSoTuKhoa += 1
        End If

        'Tiến hành tìmkiem61
        If (intSoTuKhoa <> 0) Then
            strChuoiTimKiem = strChuoiTimKiem.Remove(strChuoiTimKiem.Length - 4, 4)
            Dim dtrTimKiemKH() As DataRow = dttKH.Select(strChuoiTimKiem)
            Dim dttSearch = dttKH.Clone()
            For Each row As DataRow In dtrTimKiemKH
                dttSearch.ImportRow(row)
            Next
            'Cập nhật cbb và dgv KH
            ClearAllItem_cbbKH()
            For Each row As DataRow In dttSearch.Rows
                cbbMaKhachHang.Items.Add(row(0))
                cbbHoTen.Items.Add(row(1))
                cbbDiaChi.Items.Add(row(2))
                cbbEmail.Items.Add(row(3))
                cbbSDT.Items.Add(row(4))
                cbbTienNo.Items.Add(row(4))
            Next

            dgvKhachHang.SelectAll()
            dgvKhachHang.ClearSelection()
            dgvKhachHang.DataSource = dttSearch
            If (dgvKhachHang.Rows.Count <= 1) Then
                btnChonKH.Enabled = False
            Else
                btnChonKH.Enabled = True
            End If
        End If

    End Sub

#End Region



#Region "Xử lý các logic"

#Region "Xử lý ngày nhập"
    'Kiểm soát kí tự truyền vào ngày nhập
    Private Sub txtNgay_TextChanged(sender As Object, e As EventArgs) Handles txtNgay.TextChanged
        If (txtNgay.Text <> "") Then
            Dim maxday As Integer
            maxday = Date.DaysInMonth(Date.Today.Year, Date.Today.Month)
            If (Integer.Parse(txtNgay.Text) < 1 Or Integer.Parse(txtNgay.Text) > maxday) Then
                txtNgay.Text = maxday.ToString()

            End If
        End If
    End Sub
    'Xử lý khi ngày nhập không hợp lệ
    Private Sub txtNgay_Leave(sender As Object, e As EventArgs) Handles txtNgay.Leave
        If (Integer.Parse(txtNgay.Text) < 10 And txtNgay.Text.Length < 2) Then
            txtNgay.Text = "0" + txtNgay.Text
        End If
    End Sub
    'Checkbox cho phép nhập
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged
        If (CheckBox1.CheckState = CheckState.Checked) Then
            txtNgay.ReadOnly = False
        Else
            txtNgay.ReadOnly = True
        End If
    End Sub
#End Region

    'Xử lý khi tiền nợ thay đổi
    Private Sub txtTienNo_TextChanged(sender As Object, e As EventArgs) Handles txtTienNo.TextChanged

        If (txtTienNo.Text = "0") Then
            txtTienNo.ForeColor = Color.Gray
        Else
            If (Int32.Parse(txtTienNo.Text) < functionToUse.LoadThamSoQuyDinh(3)) Then
                txtTienNo.ForeColor = Color.Green
            Else
                txtTienNo.ForeColor = Color.Red
            End If
        End If

    End Sub
    'KIểm soát email hợp lệ
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If (functionToUse.IsValidEmail(txtEmail.Text)) Then
            txtEmail.ForeColor = Color.Black
        Else
            txtEmail.ForeColor = Color.Red
        End If
    End Sub
    'Kiểm soát sđt hợp lệ
    Private Sub txtSDT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSDT.KeyPress, txtNgay.KeyPress
        'kiểm tra các giá trị nhập vào slnhap có hợp lệ
        If (Char.IsDigit(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) OrElse e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
#End Region



End Class
