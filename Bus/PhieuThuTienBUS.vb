Imports DTO.DTO
Imports DAL.DAL
Imports System.Collections.Generic

Namespace BUS

    Public Class PhieuThuTienBUS

        Public Shared Sub insertPhieuThu(pt As PhieuThuTien)
            DAL.DAL.PhieuThuTienDAL.insertPhieuThu(pt)
        End Sub

    End Class

End Namespace

