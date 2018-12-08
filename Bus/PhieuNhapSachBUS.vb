Imports DTO.DTO
Imports DAL.DAL
Imports System.Collections.Generic

Namespace BUS
    Public Class PhieuNhapSachBUS

        Public ListphieuNhapDTO As New List(Of DTO.DTO.PhieuNhapSachDTO)
        Public Shared Sub insertPhieuNhap(phieunhapDTO As PhieuNhapSachDTO)
            DAL.DAL.PhieuNhapSachDAL.insertPhieuNhapSach(phieunhapDTO)
        End Sub

        Public Shared Sub deletePhieuNhap(phieunhapDTO As PhieuNhapSachDTO)
            DAL.DAL.PhieuNhapSachDAL.deletePhieuNhapSach(phieunhapDTO)
        End Sub

        Public Function isVail_SoLuongNhap(pn As DTO.DTO.CTPhieuNhapDTO, ts As DTO.DTO.ThamSoDTO)
            If (pn.SoLuongNhap >= ts.SoLuongNhapMin) Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function isVail_SoLuongTon(ByRef sa As DTO.DTO.SachDTO, ts As DTO.DTO.ThamSoDTO, ctpn As CTPhieuNhapDTO)

            sa.SoLuongTon += ctpn.SoLuongNhap
            If (sa.SoLuongTon >= ts.SoLuongTonMax) Then
                Return False
            Else
                Return True
            End If
        End Function



    End Class

End Namespace