Imports Bus.BUS.PhieuThuTienBUS
Imports DTO.DTO.ThamSoDTO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows
Imports System.Globalization
Imports Microsoft.Office.Interop.Excel

Public Class PhieuThuTien

    'Biến khởi tạo giá trị bảng
    Dim isFinishInit As Boolean = False

    Private Sub PhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Giá trị mặc định textbox
        txtNgayLap.Text = "/" + DateTime.Now.ToString("MM/yyyy")
        txtNgay.Text = DateTime.Now.Day.ToString
        txtMaPhieuThu.Text = functionToUse.CreatePrimaryKey("phieuthutien", "maphieuthu", "MPT", 0)

        ReFreshDataKH()
        cbQuyDinh.SelectedIndex = functionToUse.LoadThamSoQuyDinh(4)
        isFinishInit = True

        'Chỉnh hiệu ứng mdi
        With Me
            .Opacity = 0
            .WindowState = FormWindowState.Maximized
            .Opacity = 100
        End With

    End Sub

#Region "Chức năng panel Tra cứu khách hàng"
    Private Sub ClearAllItem_cbbKH()
        cbbMaKhachHang.Items.Clear()
        cbbHoTen.Items.Clear()
        cbbDiaChi.Items.Clear()
        cbbEmail.Items.Clear()
        cbbSDT.Items.Clear()
        cbbTienNo.Items.Clear()
    End Sub

    'Chức năng tìm kiếm
    Private Sub BtnTimKH_Click(sender As Object, e As EventArgs) Handles btnTimKH.Click
        'Khai báo chuỗi tìm kiếm và bảng cần tìm
        Dim dttKH = functionToUse.LoadData("khachhang", "makh")
        Dim strChuoiTimKiem As String = ""
        Dim intSoTuKhoa = 0

        'Thêm vào chuỗi tìm kiếm các từ khóa
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

        'Tiến hành tìm kiếm
        If (intSoTuKhoa <> 0) Then
            strChuoiTimKiem = strChuoiTimKiem.Remove(strChuoiTimKiem.Length - 4, 4)
            Dim dtrTimKiemKH() As DataRow = dttKH.Select(strChuoiTimKiem)
            Dim dttSearch = dttKH.Clone()
            For Each row As DataRow In dtrTimKiemKH
                dttSearch.ImportRow(row)
            Next

            'Cập nhật dữ liệu trng combobox
            ClearAllItem_cbbKH()

            For Each row As DataRow In dttSearch.Rows
                cbbMaKhachHang.Items.Add(row(0))
                cbbHoTen.Items.Add(row(1))
                cbbDiaChi.Items.Add(row(2))
                cbbEmail.Items.Add(row(3))
                cbbSDT.Items.Add(row(4))
                cbbTienNo.Items.Add(row(4))
            Next

            'Cập nhật dữ liệu trong bảng khách hàng
            dgvKhachHang.SelectAll()
            dgvKhachHang.ClearSelection()
            dgvKhachHang.DataSource = dttSearch

            'Cập nhật lại trang thái logic của nút chọn
            If (dgvKhachHang.Rows.Count <= 1) Then
                btnChonKH.Enabled = False
            Else
                btnChonKH.Enabled = True
            End If
        End If

    End Sub

    'Hiển thị toàn bộ khách hàng
    Private Sub btnHienKH_Click(sender As Object, e As EventArgs) Handles btnHienKH.Click
        ReFreshDataKH()
        cbbMaKhachHang.Text = ""
        cbbHoTen.Text = ""
        cbbEmail.Text = ""
        cbbDiaChi.Text = ""
        cbbTienNo.Text = ""
        cbbSDT.Text = ""
    End Sub

    'Chọn khách hàng
    Private Sub btnChonKH_Click(sender As Object, e As EventArgs) Handles btnChonKH.Click
        Dim index As Integer
        index = dgvKhachHang.CurrentRow.Index
        'Thêm khách hàng đã chọn vào textbox từ bảng kh
        If (index <> dgvKhachHang.RowCount - 1) Then
            txtMaKH.Text = dgvKhachHang.Rows(index).Cells(0).Value.ToString
            txtHoTen.Text = dgvKhachHang.Rows(index).Cells(1).Value.ToString
            txtDiaChi.Text = dgvKhachHang.Rows(index).Cells(2).Value.ToString
            txtEmail.Text = dgvKhachHang.Rows(index).Cells(3).Value.ToString
            txtSDT.Text = dgvKhachHang.Rows(index).Cells(4).Value.ToString
            txtTienNo.Text = dgvKhachHang.Rows(index).Cells(5).Value.ToString
        End If
    End Sub
#End Region

#Region "Chức năng panel Phiếu thu tiền"

#Region "Kiem soat tinh dung dan cua du lieu nhap vao"
    'Chỉnh lại số tiền thu theo đúng quy định
    Private Sub txtSoTienThu_Leave(sender As Object, e As EventArgs) Handles txtSoTienThu.Leave, txtSoTienThu.TextChanged
        If (txtSoTienThu.Text <> "") Then

            Dim tienthu As Integer = Integer.Parse(txtSoTienThu.Text)

            If (tienthu > Integer.Parse(txtTienNo.Text)) Then
                If (cbQuyDinh.SelectedIndex = 1) Then 'khong duoc phep thu qua tien
                    txtSoTienThu.Text = txtTienNo.Text
                End If
            End If

        End If
    End Sub

    'Kiểm soát Email hợp lệ
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If (functionToUse.IsValidEmail(txtEmail.Text)) Then
            txtEmail.ForeColor = Color.Black
        Else
            txtEmail.ForeColor = Color.Red
        End If
    End Sub

    'Kiểm soát địa chỉ hợp lệ
    Private Sub txtDiaChi_LostFocus(sender As Object, e As EventArgs) Handles txtDiaChi.LostFocus
        txtDiaChi.Text = functionToUse.FixedAddress(txtDiaChi.Text)
    End Sub

    'Kiểm soát số điện thoại hợp lệ
    Private Sub txtSDT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSDT.KeyPress, txtNgay.KeyPress, txtSoTienThu.KeyPress
        If (Char.IsDigit(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) OrElse e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

#Region "Kiem soat ngay nhap hop le"
    Private Sub txtNgay_TextChanged(sender As Object, e As EventArgs) Handles txtNgay.TextChanged
        If (txtNgay.Text <> "") Then

            Dim maxday = Date.DaysInMonth(Date.Today.Year, Date.Today.Month)

            If (Integer.Parse(txtNgay.Text) < 1 Or Integer.Parse(txtNgay.Text) > maxday) Then
                txtNgay.Text = maxday.ToString()
            End If
        End If
    End Sub
    Private Sub txtNgay_Leave(sender As Object, e As EventArgs) Handles txtNgay.Leave
        If (Integer.Parse(txtNgay.Text) < 10 And txtNgay.Text.Length < 2) Then
            txtNgay.Text = "0" + txtNgay.Text
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.CheckState = CheckState.Checked) Then
            txtNgay.ReadOnly = False
        Else
            txtNgay.ReadOnly = True
        End If
    End Sub
#End Region

#End Region

    'Làm mới dữ liệu
    Private Sub ReFreshDataKH()

        Dim dttKH = functionToUse.LoadData("khachhang", "makhachhang")
        dgvKhachHang.DataSource = dttKH
        dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKhachHang.Columns(0).Visible = False
        dgvKhachHang.ReadOnly = True


        dgvKhachHang.Columns(0).Name = "MaKH"
        dgvKhachHang.Columns(1).Name = "HoTen"
        dgvKhachHang.Columns(2).Name = "DiaChi"
        dgvKhachHang.Columns(3).Name = "Email"
        dgvKhachHang.Columns(4).Name = "SDT"
        dgvKhachHang.Columns(5).Name = "TienNo"

        ClearAllItem_cbbKH()

        For Each row As DataRow In dttKH.Rows
            cbbMaKhachHang.Items.Add(row(0))
            cbbHoTen.Items.Add(row(1))
            cbbDiaChi.Items.Add(row(2))
            cbbEmail.Items.Add(row(3))
            cbbSDT.Items.Add(row(4))
            cbbTienNo.Items.Add(row(5))
        Next

    End Sub

    'Làm mới bảng
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ClearForm()
        btnIn.Enabled = False
    End Sub

    'Lưu dữ liệu
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (txtSoTienThu.Text <> "") Then
            Dim provider As CultureInfo = CultureInfo.InvariantCulture

            'Tạo phiếu thu mới vào bảng
            Dim pt As New DTO.DTO.PhieuThuTien
            pt.MaPhieuThu = txtMaPhieuThu.Text
            pt.MaKH = txtMaKH.Text
            pt.NgayThuTien = DateTime.ParseExact(txtNgay.Text.Trim + txtNgayLap.Text.Trim, "dd/MM/yyyy", provider)
            pt.SoTienThu = Integer.Parse(txtSoTienThu.Text)
            Bus.BUS.PhieuThuTienBUS.insertPhieuThu(pt)

            'Update tiền nợ khách hàng, và công nợ trong báo cáo công nợ
            Dim kh As New DTO.DTO.KhachHangDTO
            kh.MaKH = txtMaKH.Text
            kh.SoTienNo = Integer.Parse(txtTienNo.Text)
            functionToUse.UpdateTienNo(-Integer.Parse(txtSoTienThu.Text), Today.Month, kh)

            'Cập nhật dữ liệu cho form
            txtMaPhieuThu.Text = functionToUse.CreatePrimaryKey("phieuthutien", "maphieuthu", "MPT", 0)
            MessageBox.Show("Thanh Cong")
            btnIn.Enabled = True
            ReFreshDataKH()

        Else
            MessageBox.Show("Vui lòng nhập số tiền thu !")
        End If


    End Sub


    'Xuát phiếu file Excel
    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        'Khai báo excel
        Dim appExcel As New Microsoft.Office.Interop.Excel.Application
        appExcel.Application.Workbooks.Add(Type.Missing)
        appExcel.Columns.ColumnWidth = 15

        'Truyền dữ liệu vào excel
        appExcel.Cells(1, 1) = "PHIẾU THU TIỀN"
        appExcel.Cells(2, 1) = "Mã phiếu : " + txtMaPhieuThu.Text
        appExcel.Cells(3, 1) = "Ngày lập phiếu : " + txtNgay.Text + txtNgayLap.Text
        appExcel.Cells(4, 1) = "Mã khách : " + txtMaKH.Text
        appExcel.Cells(5, 1) = "Họ tên khách hàng : " + txtHoTen.Text
        appExcel.Cells(6, 1) = "Địa chỉ khách hàng : " + txtDiaChi.Text
        appExcel.Cells(7, 1) = "Email : " + txtEmail.Text
        appExcel.Cells(8, 1) = "Số điện thoại : " + txtSDT.Text
        appExcel.Cells(9, 1) = "Tiền nợ : " + txtTienNo.Text
        appExcel.Cells(10, 1) = "Số tiền thu : " + txtSoTienThu.Text

        'Tạo save dialog
        Dim browser As New SaveFileDialog()
        browser.Filter = "Excel files (*.xlsx)|*.xlsx"
        Dim fileName = ""
        If (browser.ShowDialog() = DialogResult.OK) Then
            fileName = browser.FileName
        End If
        'Tiến hành save
        appExcel.ActiveWorkbook.SaveCopyAs(fileName)
        appExcel.ActiveWorkbook.Saved = True

    End Sub


    Public Sub ClearForm()
        txtMaKH.Text = ""
        txtHoTen.Text = ""
        txtEmail.Text = ""
        txtSDT.Text = ""
        txtDiaChi.Text = ""
        txtTienNo.Text = "0"
        txtSoTienThu.Text = "0"

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    'Xóa toàn bộ trong cbb Khách hàng

#End Region

End Class