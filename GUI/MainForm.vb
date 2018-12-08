Imports System.Globalization

Public Class MainForm
    Private intlevel As Integer
    Protected Overrides Sub OnLoad(e As EventArgs)

        'Chọn màu của mdiClient và control theo form background
        Dim ctl As Control
        Dim ctlMDI As MdiClient
        For Each ctl In Me.Controls
            Try
                ctlMDI = CType(ctl, MdiClient)
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
            End Try
        Next

        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
        Me.WindowState = FormWindowState.Maximized

        'Ẩn tính năng khi chưa đang nhập
        pnlInfo.Hide()
        btnPhieuBaoCao.Hide()
        btnPhieuThuTien.Hide()
        btnPhieuNhapSach.Hide()
        btnChinhSuaQuyDinh.Hide()
        btnPhieuBanSach.Hide()

    End Sub

#Region "Xử lý các phím chức năng"
    Private Sub btnLapPhieuNhapSach_Click(sender As Object, e As EventArgs) Handles btnPhieuNhapSach.Click
        ReChooseButton()
        btnPhieuNhapSach.BackColor = Color.FromArgb(221, 221, 221)

        Dim formPhieuNhapSach As New PhieuNhapSach()
        formPhieuNhapSach.MdiParent = Me
        formPhieuNhapSach.Show()
        formPhieuNhapSach.WindowState = WindowState.Minimized
        formPhieuNhapSach.WindowState = WindowState.Maximized


    End Sub

    Private Sub btnLapPhieuBanSach_Click(sender As Object, e As EventArgs) Handles btnPhieuBanSach.Click
        ReChooseButton()
        btnPhieuBanSach.BackColor = Color.FromArgb(6, 168, 240)
        Dim formPhieuBanSach As New PhieuBanSach()
        formPhieuBanSach.MdiParent = Me
        formPhieuBanSach.Show()
        formPhieuBanSach.WindowState = WindowState.Minimized
        formPhieuBanSach.WindowState = WindowState.Maximized
    End Sub

    Private Sub btnTraCuuSach_Click(sender As Object, e As EventArgs) Handles btnPhieuTraCuu.Click
        ReChooseButton()
        btnPhieuTraCuu.BackColor = Color.Blue
        Dim formPhieuTraCuu As New PhieuTraCuu()
        formPhieuTraCuu.MdiParent = Me
        formPhieuTraCuu.Show()
        formPhieuTraCuu.WindowState = WindowState.Minimized
        formPhieuTraCuu.WindowState = WindowState.Maximized
    End Sub

    Private Sub btnPhieuThuTien_Click(sender As Object, e As EventArgs) Handles btnPhieuThuTien.Click
        ReChooseButton()
        btnPhieuThuTien.BackColor = Color.Blue
        Dim formPhieuThuTien As New PhieuThuTien()
        formPhieuThuTien.MdiParent = Me
        formPhieuThuTien.Show()
        formPhieuThuTien.WindowState = WindowState.Minimized
        formPhieuThuTien.WindowState = WindowState.Maximized
    End Sub

    Private Sub btnLapBaoCao_Click(sender As Object, e As EventArgs) Handles btnPhieuBaoCao.Click
        ReChooseButton()
        btnPhieuBaoCao.BackColor = Color.Blue

        Dim formPhieuBaoCao As New PhieuBaoCao()
        formPhieuBaoCao.MdiParent = Me
        formPhieuBaoCao.Show()
        formPhieuBaoCao.WindowState = WindowState.Minimized
        formPhieuBaoCao.WindowState = WindowState.Maximized
    End Sub

    Private Sub btnChinhSuaQuyDinh_Click_1(sender As Object, e As EventArgs) Handles btnChinhSuaQuyDinh.Click
        ReChooseButton()
        btnChinhSuaQuyDinh.BackColor = Color.Blue
        Dim formChinhSuaQuyDinh As New ChinhSuaQuyDinh()
        formChinhSuaQuyDinh.MdiParent = Me
        formChinhSuaQuyDinh.Show()
        formChinhSuaQuyDinh.WindowState = WindowState.Minimized
        formChinhSuaQuyDinh.WindowState = WindowState.Maximized
    End Sub

    Private Sub ReChooseButton()
        If (Me.MdiChildren.Length > 0) Then
            Me.ActiveMdiChild.Close()
        End If
        For Each btn In PanelButton.Controls
            btn.BackColor = Color.FromArgb(37, 44, 63)
        Next
    End Sub


#End Region


#Region "FormMainTitle Mode lại"

    Private boolDrag As Boolean = False
    Dim StartPoint As New Point


    Private Sub PanelTitle_MouseUp(sender As Object, e As EventArgs) Handles PanelTitle.MouseUp
        Me.boolDrag = False
    End Sub

    Private Sub PanelTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitle.MouseDown
        Me.StartPoint = e.Location
        boolDrag = True
    End Sub
    Private Sub Title_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitle.MouseMove
        If (Me.boolDrag) Then
            Dim p1 = New Point(e.X, e.Y)

            Dim p2 = Me.PointToScreen(p1)

            Dim p3 = New Point(p2.X - Me.StartPoint.X, p2.Y - Me.StartPoint.Y)

            Me.Location = p3
        End If
    End Sub

    Private Sub btnMiniMize_Click(sender As Object, e As EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub btnMaxiMize_Click(sender As Object, e As EventArgs) Handles btnMaxiMize.Click
        If (Me.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

#End Region

#Region "Xử lý  MenuStrip đang nhập và liện hệ"
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click

        Dim dlgResult = MessageBox.Show("Do you want to exit now ? ", "Exit", MessageBoxButtons.YesNo)
        If (dlgResult = DialogResult.Yes) Then




            pnlInfo.Hide()
            btnPhieuBaoCao.Hide()
            btnPhieuThuTien.Hide()
            btnPhieuNhapSach.Hide()
            btnChinhSuaQuyDinh.Hide()
            btnPhieuBanSach.Hide()
        End If

    End Sub

    Private Sub ButtonLienHe_Click(sender As Object, e As EventArgs) Handles btnLienHe.Click
        Dim formContact As New LienHe
        formContact.Show()

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim login As New LoginForm
        Dim dlgResult = login.ShowDialog()
        If (dlgResult = DialogResult.OK) Then
            lblID.Text = "ID: " + login.username
            ReChooseButton()
            Select Case login.intLevel
                Case 1
                    lblLevel.Text = "Job: Nhân viên"
                    btnPhieuBanSach.Show()
                    btnPhieuThuTien.Show()
                    btnPhieuBaoCao.Show()
                    picAvartar.Image = New Bitmap(My.Resources.imgEmployee)

                Case 2
                    lblLevel.Text = "Job: Quản lí"
                    btnPhieuNhapSach.Show()
                    picAvartar.Image = New Bitmap(My.Resources.imgManager)
                Case 3
                    lblLevel.Text = "Job: Giám đốc"
                    btnChinhSuaQuyDinh.Show()
                    picAvartar.Image = New Bitmap(My.Resources.imgCEO)
                Case 4
                    lblLevel.Text = "Job: Admin"
                    picAvartar.Image = New Bitmap(My.Resources.imgAdmin)

                Case Else
                    btnPhieuTraCuu.Show()

            End Select

            pnlInfo.Show()

        End If

    End Sub

#End Region

End Class