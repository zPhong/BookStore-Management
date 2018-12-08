Imports System
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class LoginForm
    Public intLevel As Integer
    Private dTable As DataTable
    Public username As String
    Private Function checklogin(user As String, pass As String) As Boolean


        Dim query As String = String.Format("select * from taikhoan where username ='{0}'and password ='{1}'", user, pass)

        dTable = functionToUse.LoadDataWithQuery("taikhoan", query)
        If (dTable.Rows.Count > 0) Then
            intLevel = Integer.Parse(dTable.Rows(0).ItemArray(2).ToString())
            username = dTable.Rows(0).ItemArray(0).ToString()
            Return True
        End If

        Return False

    End Function

    Private Function isempty() As Boolean

        Return String.IsNullOrEmpty(txtUserName.Text) OrElse String.IsNullOrEmpty(txtPass.Text)

    End Function
    Public result = ""

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (isempty()) Then
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng")
        Else
            If (checklogin(txtUserName.Text, txtPass.Text)) Then
                ' MessageBox.Show("Dang nhap thanh cong , level = " + intLevel.ToString())
                DialogResult = DialogResult.OK
            Else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng")
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub LoginForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserName.KeyPress, txtPass.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter)) Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub cbHidePass_CheckedChanged(sender As Object, e As EventArgs) Handles cbHidePass.CheckedChanged
        If (cbHidePass.CheckState = CheckState.Checked) Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub


End Class