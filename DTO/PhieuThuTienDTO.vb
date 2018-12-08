Namespace DTO

    Public Class PhieuThuTien
#Region "Declare"

        Private strMaPhieuThu As String
        Private dobSoTienThu As Double
        Private dateNgayThuTien As DateTime
        Private strMaKH As String

        Public Property MaPhieuThu() As String
            Get
                Return strMaPhieuThu
            End Get
            Set(value As String)
                strMaPhieuThu = value
            End Set
        End Property
        Public Property SoTienThu() As Double
            Get
                Return dobSoTienThu
            End Get
            Set(value As Double)
                dobSoTienThu = value
            End Set
        End Property
        Public Property NgayThuTien() As DateTime
            Get
                Return dateNgayThuTien
            End Get
            Set(value As DateTime)
                dateNgayThuTien = value
            End Set
        End Property
        Public Property MaKH() As String
            Get
                Return strMaKH
            End Get
            Set(value As String)
                strMaKH = value
            End Set
        End Property
#End Region


    End Class

End Namespace
