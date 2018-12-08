Public Class PhieuTraCuu

    'Tạo dự liệu datatable tra cứu sách
    Dim dttSach As DataTable = functionToUse.LoadData("sach", "masach")

    'Khởi tạo 
    Protected Overrides Sub OnLoad(e As EventArgs)
        dgvSach.DataSource = dttSach

        Dim dttAllSach = functionToUse.LoadData("sach", "masach")
        ClearAllItem_cbbSach()
        dgvSach.SelectAll()
        dgvSach.ClearSelection()
        dgvSach.DataSource = dttAllSach

        'Thêm các thành phần vào combobox tương ứng
        For Each row As DataRow In dttAllSach.Rows
            cbbMaSach.Items.Add(row(0))
            cbbTenSach.Items.Add(row(1))
            cbbTheLoai.Items.Add(row(2))
            cbbTacGia.Items.Add(row(3))
            cbbSoLuongTon.Items.Add(row(4))
        Next

        'Hiệu ứng MDI Form
        With Me
            .Opacity = 0
            .WindowState = FormWindowState.Maximized
            .Opacity = 100
        End With

    End Sub

    'Tìm sách
    Private Sub btnTimSach_Click(sender As Object, e As EventArgs) Handles btnTimSach.Click
        'Khai báo chuỗi tìm kiếm
        Dim dttSach = functionToUse.LoadData("sach", "masach")
        Dim strChuoiTimKiem As String = ""
        Dim intSoTuKhoa = 0

        'Load dữ liệu từ các thành phần tương ứng vào chuỗi tìm kiếm
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

        'Tiến hành tìm từ chuỗi tìm kiếm
        If (intSoTuKhoa <> 0) Then
            strChuoiTimKiem = strChuoiTimKiem.Remove(strChuoiTimKiem.Length - 4, 4)

            Dim dtrTimKiemSach() As DataRow = dttSach.Select(strChuoiTimKiem)
            Dim dttSearch = dttSach.Clone()

            For Each row As DataRow In dtrTimKiemSach
                dttSearch.ImportRow(row)
            Next

            dgvSach.SelectAll()
            dgvSach.ClearSelection()
            dgvSach.DataSource = dttSearch
        End If

    End Sub

    'Hiển thị toàn bộ sách
    Private Sub btnHienSach_Click(sender As Object, e As EventArgs) Handles btnHienSach.Click
        'Lấy data từ bảng sách
        Dim dttAllSach = functionToUse.LoadData("sach", "masach")
        ClearAllItem_cbbSach()
        dgvSach.SelectAll()
        dgvSach.ClearSelection()
        dgvSach.DataSource = dttAllSach

        'Load data vào combobox
        For Each row As DataRow In dttAllSach.Rows
            cbbMaSach.Items.Add(row(0))
            cbbTenSach.Items.Add(row(1))
            cbbTheLoai.Items.Add(row(2))
            cbbTacGia.Items.Add(row(3))
            cbbSoLuongTon.Items.Add(row(4))
        Next

        'Xóa combobox text
        cbbMaSach.Text = ""
        cbbTenSach.Text = ""
        cbbTacGia.Text = ""
        cbbTheLoai.Text = ""
        cbbSoLuongTon.Text = ""
    End Sub

    'Xóa toàn bộ dữ liệu trong combobox
    Private Sub ClearAllItem_cbbSach()
        cbbMaSach.Items.Clear()
        cbbTenSach.Items.Clear()
        cbbTacGia.Items.Clear()
        cbbSoLuongTon.Items.Clear()
        cbbTheLoai.Items.Clear()
    End Sub

End Class