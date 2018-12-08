
Namespace DTO
    Public Class PhieuHoaDon
#Region "Declare"
        Private strMaHD As String
        Private strMaKH As String
        Private dateNgayLapHD As DateTime

        Public Property MaHD() As String
            Get
                Return strMaHD
            End Get
            Set(value As String)
                strMaHD = value
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
        Public Property NgayLapHoaDon() As DateTime
            Get
                Return dateNgayLapHD
            End Get
            Set(value As DateTime)
                dateNgayLapHD = value
            End Set
        End Property
#End Region

#Region "Function"
        Public Sub Create()
            strMaHD = ""
            strMaKH = ""
            dateNgayLapHD = ""
        End Sub
        Public Sub Create(ByVal maphieuhoadon As String, ByVal makhachhang As String, ByVal ngaylaphoadon As DateTime)
            strMaHD = maphieuhoadon
            strMaKH = makhachhang
            dateNgayLapHD = ngaylaphoadon
        End Sub
#End Region

    End Class

    Public Class ChiTietPhieuHoaDon

#Region "DeClare"
        Private strMaCTHD As String
        Private strMaHD As String
        Private strMaSach As String
        Private intSoLuongBan As Integer
        Private dobDonGia As Double

        Public Property MaCTHD() As String
            Get
                Return strMaCTHD
            End Get
            Set(value As String)
                strMaCTHD = value
            End Set
        End Property
        Public Property MaHD() As String
            Get
                Return strMaHD
            End Get
            Set(value As String)
                strMaHD = value
            End Set
        End Property
        Public Property MaSach() As String
            Get
                Return strMaSach
            End Get
            Set(value As String)
                strMaSach = value
            End Set
        End Property
        Public Property SoLuongBan() As Integer
            Get
                Return intSoLuongBan
            End Get
            Set(value As Integer)
                intSoLuongBan = value
            End Set
        End Property

        Public Property DonGia() As Double
            Get
                Return dobDonGia
            End Get
            Set(value As Double)
                dobDonGia = value
            End Set
        End Property
#End Region

#Region "Function"

        Public Sub New()
            strMaCTHD = ""
            strMaHD = ""
            strMaSach = ""
            intSoLuongBan = 0
        End Sub
        Public Sub New(ByVal machitietphieuhoadon As String, ByVal maphieuhoadon As String, ByVal masach As String, ByVal soluongban As Integer)
            strMaCTHD = machitietphieuhoadon
            strMaHD = maphieuhoadon
            strMaSach = masach
            intSoLuongBan = soluongban
        End Sub

#End Region

    End Class

End Namespace
