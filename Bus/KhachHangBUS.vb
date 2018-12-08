Namespace BUS

    Public Class KhachHangBUS


        Public Shared Sub insertKhachHang(kh As DTO.DTO.KhachHangDTO)
            DAL.DAL.KhachHangDAL.insertKhachHang(kh)
        End Sub

        Public Shared Sub updateKhachHang(kh As DTO.DTO.KhachHangDTO)
            DAL.DAL.KhachHangDAL.updateKhachHang(kh)
        End Sub


        Public Shared Sub updateTienNoKhachHang(kh As DTO.DTO.KhachHangDTO)
            DAL.DAL.KhachHangDAL.updateTienNoKhachHang(kh)
        End Sub


    End Class


End Namespace
