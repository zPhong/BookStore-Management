Namespace BUS
    Public Class ChiTietHoaDonBUS


        Public Shared Sub insertCTHoaDon(cthd As DTO.DTO.ChiTietPhieuHoaDon)
            DAL.DAL.ChiTietHoaDonDAL.insertCTHoaDon(cthd)

        End Sub
    End Class

End Namespace
