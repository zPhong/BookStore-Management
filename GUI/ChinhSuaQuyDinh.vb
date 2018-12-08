Imports Bus.BUS.ThamSoBUS
Imports DTO.DTO.ThamSoDTO
Public Class ChinhSuaQuyDinh

    Protected Overrides Sub OnLoad(e As EventArgs)
        'Không cho phéo chỉnh sửa
        txtSoLuongNhapToiThieu.ReadOnly = True
        txtSoLuongTonToiDaDuocNhap.ReadOnly = True
        txtSoLuongTonToiThieu.ReadOnly = True
        txtTienNoToiDa.ReadOnly = True

        'Load các tham số
        txtSoLuongNhapToiThieu.Text = functionToUse.LoadThamSoQuyDinh(0)
        txtSoLuongTonToiDaDuocNhap.Text = functionToUse.LoadThamSoQuyDinh(1)
        txtSoLuongTonToiThieu.Text = functionToUse.LoadThamSoQuyDinh(2)
        txtTienNoToiDa.Text = functionToUse.LoadThamSoQuyDinh(3)
        cbbPhuongThucNhap.SelectedIndex = functionToUse.LoadThamSoQuyDinh(4)

        'Hiệu ứng mdi
        With Me
            .Opacity = 0
            .WindowState = FormWindowState.Maximized
            .Opacity = 100
        End With

    End Sub

#Region "Hiệu ứng textbox quy định"
    Private Sub TextBox_Click(sender As Object, e As EventArgs) Handles txtSoLuongNhapToiThieu.DoubleClick, txtSoLuongTonToiDaDuocNhap.DoubleClick, txtSoLuongTonToiThieu.DoubleClick, txtTienNoToiDa.DoubleClick
        CType(sender, TextBox).ReadOnly = False
    End Sub

    Private Sub TextBox_NotFocus(sender As Object, e As EventArgs) Handles txtSoLuongNhapToiThieu.LostFocus, txtSoLuongTonToiDaDuocNhap.LostFocus, txtSoLuongTonToiThieu.LostFocus, txtTienNoToiDa.LostFocus
        If (CType(sender, TextBox).ReadOnly = False) Then
            CType(sender, TextBox).ReadOnly = True
        End If
    End Sub

    'Kiểm soát kí tự nhập vào textbox
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoLuongNhapToiThieu.KeyPress, txtSoLuongTonToiDaDuocNhap.KeyPress, txtSoLuongTonToiThieu.KeyPress, txtTienNoToiDa.KeyPress
        'kiểm tra các giá trị nhập vào slnhap có hợp lệ
        If (Char.IsDigit(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) OrElse e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

#End Region

    'Lưu lại quy định
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim thamsoluu As New DTO.DTO.ThamSoDTO
        thamsoluu.PhuongThucThuTien = Integer.Parse(cbbPhuongThucNhap.SelectedIndex)
        thamsoluu.SoLuongNhapMin = Integer.Parse(txtSoLuongNhapToiThieu.Text)
        thamsoluu.SoLuongTonMax = Integer.Parse(txtSoLuongTonToiDaDuocNhap.Text)
        thamsoluu.TienNoMax = Integer.Parse(txtTienNoToiDa.Text)
        thamsoluu.SoLuongTonMin = Integer.Parse(txtSoLuongTonToiThieu.Text)
        updateThamSo(thamsoluu)
        MessageBox.Show("Lưu quy định thành công")
    End Sub


End Class