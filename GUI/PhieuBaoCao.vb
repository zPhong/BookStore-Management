
Imports System.Windows
Imports Microsoft.Office.Interop.Excel
Public Class PhieuBaoCao

    Private Sub PhieuBaoCao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbbNam.Items.Add((Today.Year - 2).ToString())
        cbbNam.Items.Add((Today.Year - 1).ToString())
        cbbNam.Items.Add((Today.Year).ToString())


        'Hiệu ứng mdi khi mở form
        With Me
            .Opacity = 0
            .WindowState = FormWindowState.Maximized
            .Opacity = 100
        End With

        btnIn.Enabled = False
    End Sub

    'Khi người dùng chọn lại combobox
    Private Sub cbb_SelectedChanged(sender As Object, e As EventArgs) Handles cbbMonth.SelectedIndexChanged, cbbType.SelectedIndexChanged
        RefreshBaoCao()
    End Sub


    'Chinh lai du lieu datagridview baocao
    Private Sub RefreshBaoCao()
        If (cbbType.SelectedItem = Nothing) Then

            Return
        End If

        'Xóa bảng và khai báo lại datagridview
        dgvBaoCao.Columns.Clear()
        Dim dttBaoCao As New System.Data.DataTable

        'Chọn bảng được lấy từ database
        If (cbbType.SelectedIndex = 0) Then
            dttBaoCao = functionToUse.LoadData("baocaoton", "maton")
        Else
            dttBaoCao = functionToUse.LoadData("baocaocongno", "macongno")
        End If

        'Chọn tháng cần select từ bảng
        Dim dttBaoCaoTheoThang As New System.Data.DataTable
        Dim Rows() As DataRow = dttBaoCao.Select(String.Format("thang = {0}", cbbMonth.SelectedItem.ToString))

        'Them cot ten sach hoac ten khachhang, cập nhật bảng nếu danh sách không trống
        If (Rows.Count >= 1) Then

            dttBaoCaoTheoThang = dttBaoCao.Select(String.Format("thang = {0}", cbbMonth.SelectedItem.ToString)).CopyToDataTable()
            dgvBaoCao.DataSource = dttBaoCaoTheoThang

            Dim dttBangTen = New System.Data.DataTable
            Dim dttTen = New System.Data.DataTable
            Dim col As New DataGridViewTextBoxColumn

            dgvBaoCao.Columns.Insert(3, col)


            If (cbbType.SelectedIndex = 0) Then
                'Thêm cột tên sách nếu chọn bảng sách
                col.Name = "tensach"
                dttBangTen = functionToUse.LoadData("sach", "masach")

                For i As Integer = 0 To Rows.Count - 1
                    Dim row = dgvBaoCao.Rows(i)
                    Dim dataRows() As DataRow = dttBangTen.Select(String.Format("masach='{0}'", row.Cells(2).Value.ToString()))
                    Dim order = row.Index()
                    row.Cells(3).Value = dataRows(0)(1)
                Next
                'Xóa mã tồn
                dgvBaoCao.Columns.Remove("maton")

            Else

                'Thêm cột tên khách hàng nếu là mã khách hàng
                col.Name = "tenkhachhang"
                dttBangTen = functionToUse.LoadData("khachhang", "makhachhang")

                For i As Integer = 0 To Rows.Count - 1
                    Dim row = dgvBaoCao.Rows(i)
                    Dim dataRows() As DataRow = dttBangTen.Select(String.Format("makhachhang='{0}'", row.Cells(2).Value.ToString()))
                    Dim order = row.Index()
                    row.Cells(3).Value = dataRows(0)(1)
                Next

                'Xóa cột mã công nợ
                dgvBaoCao.Columns.Remove("macongno")

            End If

            btnIn.Enabled = True

        Else

            dgvBaoCao.DataSource = vbNull
            btnIn.Enabled = False

        End If
    End Sub

    'XỬ lý tính năng export
    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        'Khai báo Excel
        Dim appExcel As New Microsoft.Office.Interop.Excel.Application
        appExcel.Application.Workbooks.Add(Type.Missing)
        appExcel.Columns.ColumnWidth = 15

        'Tiêu đề file Excel
        appExcel.Cells(1, 1) = "Báo cáo " + cbbType.Text
        appExcel.Cells(2, 1) = "Tháng " + cbbMonth.Text + "   Năm " + cbbNam.Text

        'Tên các cột trong file
        For i As Integer = 1 To dgvBaoCao.DisplayedColumnCount(True)
            appExcel.Cells(3, i) = dgvBaoCao.Columns(i - 1).HeaderText
        Next

        'Nhập dữ liệu từ bảng
        For i As Integer = 0 To dgvBaoCao.Rows.Count - 1
            For j As Integer = 0 To dgvBaoCao.DisplayedColumnCount(True) - 1

                appExcel.Cells(i + 4, j + 1) = dgvBaoCao.Rows(i).Cells(j).Value

            Next
        Next

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


End Class