
Imports System
Imports DTO.DTO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms


Namespace DAL
    Public Class ThamSoDAL




        Public Shared Function updateThamSo(ts As ThamSoDTO) As Integer
            Dim query As String = String.Empty
            functionDAL.CreateConnect()
            If (deleteThamSo() = 1) Then
                Return insertThamSo(ts)
            End If
            Return 0
        End Function

        Public Shared Function insertThamSo(ts As ThamSoDTO) As Integer
            Dim query As String = String.Empty
            query = String.Format("INSERT into thamso (soluongnhaptoithieu,soluongtontoidaduocnhap,soluongtontoithieu,tiennotoida,phuongthucthutien) values ({0},{1},{2},{3},{4})", ts.SoLuongNhapMin, ts.SoLuongTonMax, ts.SoLuongTonMin, ts.TienNoMax, ts.PhuongThucThuTien)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function

        Public Shared Function deleteThamSo() As Integer
            Dim query As String = String.Empty
            query = "DELETE  from thamso"
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function
    End Class
End Namespace
