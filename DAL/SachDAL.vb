Imports System
Imports DTO.DTO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Namespace DAL

    Public Class SachDAL



        Public Shared Function insertSach(sa As SachDTO) As Integer
            Dim query As String = String.Empty
            query = String.Format("insert into sach (masach,tensach,theloai,tacgia,soluongton) values('{0}','{1}','{2}','{3}',{4})", sa.MaSach, sa.TenSach, sa.TheLoai, sa.TacGia, sa.SoLuongTon)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function

        Public Function deleteSach(sa As SachDTO) As Integer
            Dim query As String = String.Empty
            query &= "DELTE FROM sach WHERE masach="
            query &= sa.MaSach
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function

        Public Shared Function updateSach(sa As SachDTO) As Integer
            Dim query As String = String.Empty
            query = String.Format("UPDATE sach SET tensach='{0}',theloai='{1}', tacgia='{2}', soluongton={3} WHERE masach='{4}'", sa.TenSach, sa.TheLoai, sa.TacGia, sa.SoLuongTon, sa.MaSach)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function


    End Class
End Namespace
