
Imports System
Imports DTO.DTO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Globalization

Namespace DAL
    Public Class PhieuThuTienDAL



        Public Shared Function insertPhieuThu(pt As DTO.DTO.PhieuThuTien) As Integer

            Dim query As String = String.Empty
            Dim provider As CultureInfo = CultureInfo.InvariantCulture

            query = String.Format("insert into phieuthutien (maphieuthu,makhachhang,ngaylap,sotienthu) values('{0}','{1}',{2},{3})", pt.MaPhieuThu, pt.MaKH, DateTime.ParseExact(pt.NgayThuTien.ToShortDateString, "dd/MM/yyyy", provider).ToShortDateString(), pt.SoTienThu)

            functionDAL.CreateConnect()

            Return functionDAL.ExecuteQuery(query)

        End Function

    End Class

End Namespace

