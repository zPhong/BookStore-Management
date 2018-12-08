Imports Bus.BUS.PhieuNhapSachBUS
Imports DTO.DTO.ThamSoDTO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows
Imports System.Globalization


Public Class PhieuNhapSach

#Region "Khai báo các giá trị thông số cho xử lý"
    Dim isPhieuNhapValid As Boolean = False
    Dim buocnhayMS As Integer = 0
    Dim Finishinit As Boolean = False
    Dim provider As CultureInfo = CultureInfo.InvariantCulture
#End Region

#Region "Xử lý mở tắt form"

    Private Sub ToolTips()
        Dim toolbtnThemSach As New System.Windows.Forms.ToolTip()
        toolbtnThemSach.SetToolTip(btnThemSach, "Chọn từ danh sách các phiếu có sẵn hoặc tạo sách mới để có thể thêm")
    End Sub

    Private Sub PhieuNhapSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDataGrid()
        'Tao gia tri mac dinh khi form load
        txtNgayLap.Text = "/" + DateTime.Now.ToString("MM/yyyy")
        txtNgay.Text = DateTime.Now.Day.ToString
        txtMaPhieuNhap.Text = functionToUse.CreatePrimaryKey("phieunhapsach", "maphieunhap", "MPN", 0)
        txtMaSach.Text = functionToUse.CreatePrimaryKey("sach", "masach", "MS", 0)
        txtSoLuongNhap.Text = "0"
        txtSoLuongTonMax.Text = functionToUse.LoadThamSoQuyDinh(1).ToString()
        txtSoLuongNhapMin.Text = functionToUse.LoadThamSoQuyDinh(0).ToString()

        Finishinit = True

        'Hiệu ứng Mdi
        With Me
            .Opacity = 0
            .WindowState = FormWindowState.Maximized
            .Opacity = 100
        End With
        ToolTips()
    End Sub
    'Kiểm tra hợp lệ khi tắt form
    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        If (isPhieuNhapValid = False) Then
            Dim phieunhapDTO As New DTO.DTO.PhieuNhapSachDTO()
            phieunhapDTO.MaPhieuNhapSach = txtMaPhieuNhap.Text
            Bus.BUS.PhieuNhapSachBUS.deletePhieuNhap(phieunhapDTO)
        End If
    End Sub
#End Region

#Region "Xử lý chức năng phiếu nhập chính"
    Private Sub LoadDataGrid()
        'load bang tat ca sach trong bang sach vao datagridAllSach
        ReFreshDataAllSach()

        'Tao Bang Sach Trong Phieu voi cac columns
        dgvSach.ColumnCount = 7
        dgvSach.Columns(0).Name = "masach"
        dgvSach.Columns(1).Name = "tensach"
        dgvSach.Columns(2).Name = "theloai"
        dgvSach.Columns(3).Name = "tacgia"
        dgvSach.Columns(4).Name = "soluongnhap"
        dgvSach.Columns(5).Name = "soluongton"
        dgvSach.Columns(6).Name = "IsExistFromDatabase"
        dgvSach.Columns(6).Visible = False
        dgvSach.ReadOnly = True
    End Sub

    Private Sub ReFreshDataAllSach()
        Dim dttAllSach = functionToUse.LoadData("sach", "masach")
        dataGridAllSach.DataSource = dttAllSach
        dataGridAllSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dataGridAllSach.ReadOnly = True

        'Tao mau cho nhung sach hop le va khong hop le
        For Each row As DataGridViewRow In dataGridAllSach.Rows
            If (row.Cells(4).Value < functionToUse.LoadThamSoQuyDinh(1)) Then
                row.DefaultCellStyle.ForeColor = Color.Green
            Else
                row.DefaultCellStyle.ForeColor = Color.Red
            End If
        Next

        ClearAllItem_cbbSach()
        For Each row As DataRow In dttAllSach.Rows
            cbbMaSach.Items.Add(row(0))
            cbbTenSach.Items.Add(row(1))
            cbbTheLoai.Items.Add(row(2))
            cbbTacGia.Items.Add(row(3))
            cbbSoLuongTon.Items.Add(row(4))
        Next


    End Sub

    'Phiếu thêm sách vào phiếu, thêm phiếu nhập, lưu pheiu61
    Private Sub btnThemPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnThemPhieuNhap.Click
        If (dgvSach.RowCount - 1 < 0) Then
            MessageBox.Show("Phiếu chưa có sách nào")
        Else
            isPhieuNhapValid = True

            'insert phieu nhap
            Dim pnsDTO = New DTO.DTO.PhieuNhapSachDTO()
            pnsDTO.MaPhieuNhapSach = txtMaPhieuNhap.Text
            pnsDTO.NgayNhap = DateTime.ParseExact(txtNgay.Text.Trim + txtNgayLap.Text.Trim, "dd/MM/yyyy", provider)
            insertPhieuNhap(pnsDTO)

            'Bắt đầu thêm từng dòng
            For Each row As DataGridViewRow In dgvSach.Rows

                'tao sach
                Dim sachDTO = New DTO.DTO.SachDTO()
                Dim baocaotonDTO = New DTO.DTO.BaoCaoTonDTO()
                Dim thang = Integer.Parse(Today.Month)

                'Insert nếu chưa có ,cập nhật số lượng tồn, update nếu tồn tại
                If (row.Cells(6).Value.ToString = "NO") Then
                    'insert sach
                    sachDTO.Create(row.Cells(0).Value.ToString, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(3).Value.ToString, Integer.Parse(row.Cells(4).Value.ToString))
                    Bus.BUS.SachBUS.insertSach(sachDTO)
                    'insert baocaoton
                    baocaotonDTO.Create(functionToUse.CreatePrimaryKey("baocaoton", "maton", "MT", 0), row.Cells(0).Value.ToString, thang, 0, Integer.Parse(row.Cells(4).Value.ToString), Integer.Parse(row.Cells(4).Value.ToString))
                    Bus.BUS.BaoCaoTonBUS.insertBaoCaoTon(baocaotonDTO)

                Else
                    'update sach
                    Dim solgtonmoi As Integer = Integer.Parse(row.Cells(4).Value.ToString) + Integer.Parse(row.Cells(5).Value.ToString)
                    sachDTO.Create(row.Cells(0).Value.ToString, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(3).Value.ToString, solgtonmoi)
                    Bus.BUS.SachBUS.updateSach(sachDTO)

                    'Update bao cao ton
                    baocaotonDTO.MaTon = functionToUse.CreatePrimaryKey("baocaoton", "maton", "MT", 0)
                    baocaotonDTO.Thang = thang
                    baocaotonDTO.MaSach = row.Cells(0).Value.ToString
                    baocaotonDTO.TonCuoi = Integer.Parse(row.Cells(5).Value) + Integer.Parse(row.Cells(4).Value)

                    'Dữ liệu tồn tháng trước'''''-----------Du lieu ton thang truoc bi loi
                    Dim dttBaoCaoTon As DataTable = functionToUse.LoadData("baocaoton", "maton")
                    Dim dtSelectedLastMonth() As DataRow = dttBaoCaoTon.Select(String.Format("masach='{0}' AND thang={1}", row.Cells(0).Value.ToString, thang - 1))
                    'Dữ liệu tồn tháng này
                    dttBaoCaoTon = functionToUse.LoadData("baocaoton", "maton")
                    Dim dtSelectedThisMonth() As DataRow = dttBaoCaoTon.Select(String.Format("masach='{0}' AND thang={1}", row.Cells(0).Value.ToString, thang))

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
                        baocaotonDTO.Create(functionToUse.CreatePrimaryKey("baocaoton", "maton", "MT", 0), row.Cells(0).Value.ToString, thang, baocaotonDTO.TonDau, Integer.Parse(row.Cells(5).Value.ToString), baocaotonDTO.TonCuoi)
                        Bus.BUS.BaoCaoTonBUS.insertBaoCaoTon(baocaotonDTO)
                    End If
                End If

                'tao chi tiet phieu nhap 
                Dim ctpnDTO = New DTO.DTO.CTPhieuNhapDTO()
                ctpnDTO.MaCTPhieuNhap = functionToUse.CreatePrimaryKey("chitietphieunhap", "machitietphieunhap", "CPN", 0)
                ctpnDTO.MaPhieuNhapSach = txtMaPhieuNhap.Text
                ctpnDTO.MaSach = row.Cells(0).Value.ToString()
                ctpnDTO.SoLuongNhap = Integer.Parse(row.Cells(5).Value.ToString())
                Bus.BUS.ChiTietPhieuNhapSachBUS.insertChiTietPhieuNhap(ctpnDTO)

            Next
            '-------------------------
            'Giai đoạn xử lý sau khi thêm các hàng
            MessageBox.Show("Lưu phiếu " & txtMaPhieuNhap.Text & " thành công")

            'Tao lai phieu moi
            isPhieuNhapValid = False
            buocnhayMS = 0

            txtMaPhieuNhap.Text = functionToUse.CreatePrimaryKey("phieunhapsach", "maphieunhap", "MPN", 0)
            txtMaSach.Text = functionToUse.CreatePrimaryKey("sach", "masach", "MS", 0)
            txtTenSach.Text = ""
            txtTheLoai.Text = ""
            txtTacGia.Text = ""
            txtSoLuongTon.Text = "0"
            txtSoLuongNhap.Text = "0"
            dgvSach.Rows.Clear()
            ReFreshDataAllSach()
        End If
    End Sub

    'Xử lý xóa sách khỏi phiếu
    Private Sub btnXoa_Clicked(sender As Object, e As EventArgs) Handles btnXoa.Click
        'Khai báo hàng cần xóa
        Dim indexDeletingRow As Integer = dgvSach.CurrentCell.RowIndex

        'Kiểm tra hàng cần xóa là sách tạo mới hay chưa
        If (dgvSach.Rows(indexDeletingRow).Cells(6).Value.ToString = "NO") Then
            'Xóa hàng
            dgvSach.Rows.RemoveAt(dgvSach.CurrentCell.RowIndex)

            'Cập nhật bước nhảy (mã sách mới) cho từng sách mới tạo trong phiếu nhập(chưa có trong bảng sách)
            buocnhayMS = 0

            For Each row As DataGridViewRow In dgvSach.Rows
                If (row.Cells(6).Value.ToString = "NO") Then
                    row.Cells(0).Value = functionToUse.CreatePrimaryKey("sach", "masach", "MS", buocnhayMS)
                    buocnhayMS += 1
                End If
            Next

        Else
            'Xóa hàng
            dgvSach.Rows.RemoveAt(dgvSach.CurrentCell.RowIndex)
        End If
        'Cập nhật mã sách mới cho textbox
        txtMaSach.Text = functionToUse.CreatePrimaryKey("sach", "masach", "MS", buocnhayMS)
    End Sub

    'Xử lý khi tạo sách mới
    Private Sub BtnTaoMaSachMoi_ClickClicked(sender As Object, e As EventArgs) Handles btnTaoSach.Click
        txtMaSach.Text = functionToUse.CreatePrimaryKey("sach", "masach", "MS", buocnhayMS)
        txtTenSach.Enabled = True
        txtTheLoai.Enabled = True
        txtTacGia.Enabled = True
        txtTenSach.Text = ""
        txtTheLoai.Text = ""
        txtTacGia.Text = ""
        txtSoLuongTon.Text = "0"
        txtSoLuongNhap.Text = "0"
    End Sub

    'Xử lý thêm sách mới
    Private Sub btnThemSach_Click(sender As Object, e As EventArgs) Handles btnThemSach.Click

        'cắt khoảng trống đầu cuối trong textbox
        txtTheLoai.Text = txtTheLoai.Text.Trim
        txtTenSach.Text = txtTenSach.Text.Trim
        txtTacGia.Text = txtTacGia.Text.Trim
        txtSoLuongNhap.Text = txtSoLuongNhap.Text.Trim

        'nếu sách thỏa mãn điều kiện thì
        'nếu sách đã được thêm vào phiếu : checkExistFromPhieu=so thu tu cua hang => cộng dồn số lượng nhập, xóa hàng
        'nếu sách đã tồn tại trong bảng sách : IsExist=YES , else IsExist=NO
        If (txtMaSach.Text <> "" And txtTheLoai.Text <> "" And txtTenSach.Text <> "" And txtTacGia.Text <> "" And txtSoLuongNhap.Text <> "0") Then

            Dim idExistRowFromPhieu As Integer = -1
            Dim strcCheckExistFromSach As String = "NO"
            Dim row As String()
            Dim strMaSachTrongPhieu As String = ""

            'Tìm index hàng tồn tại trong phiếu
            For Each eachRow As DataGridViewRow In dgvSach.Rows
                If (eachRow.Cells(1).Value.ToString() = txtTenSach.Text And
                    eachRow.Cells(2).Value.ToString() = txtTheLoai.Text And
                    eachRow.Cells(3).Value.ToString() = txtTacGia.Text
                    ) Then
                    idExistRowFromPhieu = eachRow.Index
                    buocnhayMS -= 1
                    Exit For
                End If
            Next

            'Tìm xem sách được thêm có được lấy từ bảng sách hay là sách mới 
            For indexSach = 0 To dataGridAllSach.Rows.Count - 2
                If (dataGridAllSach.Rows(indexSach).Cells(0).Value.ToString() = txtMaSach.Text) Then
                    strcCheckExistFromSach = "YES"
                    Exit For
                End If
            Next

            If (idExistRowFromPhieu <> -1) Then
                'xóa hàng tồn tại
                'khai báo hàng mới có thuộc tính strCheck và cộng dồn
                Dim soluongtonCapNhat As Integer = Integer.Parse(txtSoLuongNhap.Text) + Integer.Parse(dgvSach.Rows(idExistRowFromPhieu).Cells(4).Value.ToString())
                strMaSachTrongPhieu = dgvSach.Rows(idExistRowFromPhieu).Cells(0).Value.ToString()
                row = New String() {strMaSachTrongPhieu, txtTenSach.Text, txtTheLoai.Text, txtTacGia.Text, soluongtonCapNhat.ToString, txtSoLuongTon.Text, strcCheckExistFromSach}
                dgvSach.Rows.RemoveAt(idExistRowFromPhieu)

            Else
                'khai báo hàng mới có thuộc tính strCheck đơn thuần
                strMaSachTrongPhieu = txtMaSach.Text
                row = New String() {strMaSachTrongPhieu, txtTenSach.Text, txtTheLoai.Text, txtTacGia.Text, txtSoLuongNhap.Text, txtSoLuongTon.Text, strcCheckExistFromSach}

            End If

            dgvSach.Rows.Add(row)
            If (strcCheckExistFromSach = "NO") Then
                buocnhayMS += 1
            End If
            txtMaSach.Text = functionToUse.CreatePrimaryKey("sach", "masach", "MS", buocnhayMS)

        Else
            MessageBox.Show("Thêm sách không hợp lệ")
            Return
        End If
    End Sub


#Region "Xử lý tính đúng đắn khi thay đổi đầu vào"
    'xử lý khi số lượng nhập rỗng
    Private Sub txtSoLongNhap_NotFocus(sender As Object, e As EventArgs) Handles txtSoLuongNhap.LostFocus
        If (txtSoLuongNhap.Text = "") Then
            txtSoLuongNhap.Text = 0
        End If
    End Sub

    'Kiểm soát số lượng nhập họp lệ
    Private Sub txtSoLuongNhap_TextChanged(sender As Object, e As EventArgs) Handles txtSoLuongNhap.TextChanged
        If (txtSoLuongNhap.Text <> "") Then

            If (Integer.Parse(txtSoLuongNhap.Text) < functionToUse.LoadThamSoQuyDinh(0)) Then
                txtSoLuongNhap.ForeColor = Color.Red
                btnThemSach.Enabled = False

            Else
                txtSoLuongNhap.ForeColor = Color.Black
                btnThemSach.Enabled = True

            End If
        End If
    End Sub

    'Kiểm soát kí tự nhập vào txtSoLuongNhap là số hay không
    Private Sub txtSoLuongNhap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoLuongNhap.KeyPress
        'kiểm tra các giá trị nhập vào slnhap có hợp lệ
        If (Char.IsDigit(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) OrElse e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back)) Then
            If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter)) Then
                btnThemSach.Focus()
            End If

            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


#Region "Kiểm soát ngày hợp lệ"
    'Cho phép chỉnh sửa
    Private Sub checkBoxDateTime_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            txtNgay.Enabled = True
        Else
            txtNgay.Enabled = False
        End If

    End Sub
    'Kiêm soát kí tự vào textbox
    Private Sub txtNgay_TextChanged(sender As Object, e As EventArgs) Handles txtNgay.TextChanged
        If (txtNgay.Text <> "") Then
            Dim maxday As Integer
            maxday = Date.DaysInMonth(Date.Today.Year, Date.Today.Month)
            If (Integer.Parse(txtNgay.Text) < 1 Or Integer.Parse(txtNgay.Text) > maxday) Then
                txtNgay.Text = maxday.ToString()

            End If
        End If
    End Sub
    'Kiểm soát khi textbox thay đổi
    Private Sub txtNgay_Leave(sender As Object, e As EventArgs) Handles txtNgay.Leave
        If (Integer.Parse(txtNgay.Text) < 10 And txtNgay.Text.Length < 2) Then
            txtNgay.Text = "0" + txtNgay.Text
        End If
    End Sub
#End Region

#End Region
#End Region

#Region "Xử lý chức năng panel Tra Cứu và chọn sách"
    'Xóa toàn cbb
    Private Sub ClearAllItem_cbbSach()
        cbbMaSach.Items.Clear()
        cbbTenSach.Items.Clear()
        cbbTacGia.Items.Clear()
        cbbSoLuongTon.Items.Clear()
        cbbTheLoai.Items.Clear()
    End Sub
    'Tìm sách
    Private Sub btnTimSach_Click(sender As Object, e As EventArgs) Handles btnTimSach.Click
        'Khai báo chuỗi tìm kiếm và bảng
        Dim dttSach = functionToUse.LoadData("sach", "masach")
        Dim strChuoiTimKiem As String = ""
        Dim intSoTuKhoa = 0
        'Thêm từ khóa vào chuỗi
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
        'Tiến hành tra cứu và cập nhật bảng
        If (intSoTuKhoa <> 0) Then
            strChuoiTimKiem = strChuoiTimKiem.Remove(strChuoiTimKiem.Length - 4, 4)

            Dim dtrTimKiemSach() As DataRow = dttSach.Select(strChuoiTimKiem)
            Dim dttSearch = dttSach.Clone()
            For Each row As DataRow In dtrTimKiemSach
                dttSearch.ImportRow(row)
            Next
            dataGridAllSach.SelectAll()
            dataGridAllSach.ClearSelection()
            dataGridAllSach.DataSource = dttSearch

        End If

    End Sub
    'Hiện toàn bộ sách
    Private Sub btnHienSach_Click(sender As Object, e As EventArgs) Handles btnHienSach.Click
        ReFreshDataAllSach()
        cbbMaSach.Text = ""
        cbbTenSach.Text = ""
        cbbTacGia.Text = ""
        cbbTheLoai.Text = ""
        cbbSoLuongTon.Text = ""
    End Sub
    'Chọn sách và thêm vào phiếu
    Private Sub btnChonSach_Click(sender As Object, e As EventArgs) Handles btnChonSach.Click
        If (Finishinit = True) Then
            Dim index As Integer
            index = dataGridAllSach.CurrentRow.Index

            'Nếu trong bảng có hàng nào không NULL và giá trị tồn nhỏ hơn giá trị tồn tối thiểu
            'thì fill những textbox và disable textbox
            If (index <> dataGridAllSach.RowCount - 1) Then
                If (dataGridAllSach.Rows(index).Cells(4).Value < functionToUse.LoadThamSoQuyDinh(1)) Then
                    txtMaSach.Text = dataGridAllSach.Rows(index).Cells(0).Value.ToString
                    txtTenSach.Text = dataGridAllSach.Rows(index).Cells(1).Value.ToString
                    txtTheLoai.Text = dataGridAllSach.Rows(index).Cells(2).Value.ToString
                    txtTacGia.Text = dataGridAllSach.Rows(index).Cells(3).Value.ToString
                    txtSoLuongTon.Text = dataGridAllSach.Rows(index).Cells(4).Value.ToString

                    txtTenSach.Enabled = False
                    txtTheLoai.Enabled = False
                    txtTacGia.Enabled = False
                End If
            End If
        End If

    End Sub
#End Region

End Class