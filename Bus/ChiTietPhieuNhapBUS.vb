Imports DTO.DTO.SachDTO


Namespace BUS
    Public Class ChiTietPhieuNhapSachBUS


        Public Shared Sub insertChiTietPhieuNhap(chitietphieunhapDTO As DTO.DTO.CTPhieuNhapDTO)
            DAL.DAL.ChiTietPhieuNhapDAL.insertChiTietPhieuNhapSach(chitietphieunhapDTO)
        End Sub

    End Class
End Namespace
