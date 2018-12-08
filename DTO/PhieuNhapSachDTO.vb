
Namespace DTO

    Public Class PhieuNhapSachDTO

#Region "Declare"

        Private strMaPhieuNhapSach As String
        Private dateNgayNhap As DateTime

        Public Property MaPhieuNhapSach() As String
            Get
                Return strMaPhieuNhapSach
            End Get
            Set(value As String)
                strMaPhieuNhapSach = value
            End Set
        End Property
        Public Property NgayNhap() As Date
            Get
                Return dateNgayNhap
            End Get
            Set(value As Date)
                dateNgayNhap = value
            End Set
        End Property
#End Region



    End Class

    Public Class CTPhieuNhapDTO
#Region "Declare"
        Private strMaCTPhieuNhap As String
        Private strMaPhieuNhapSach As String
        Private strMaSach As String
        Private intSoLuongNhap As Integer

        Property SoLuongNhap() As Integer
            Get
                Return intSoLuongNhap


            End Get
            Set(value As Integer)
                intSoLuongNhap = value
            End Set
        End Property

        Public Property MaPhieuNhapSach As String
            Get
                Return strMaPhieuNhapSach
            End Get
            Set(value As String)
                strMaPhieuNhapSach = value
            End Set
        End Property

        Public Property MaCTPhieuNhap As String
            Get
                Return strMaCTPhieuNhap
            End Get
            Set(value As String)
                strMaCTPhieuNhap = value
            End Set
        End Property

        Public Property MaSach As String
            Get
                Return strMaSach
            End Get
            Set(value As String)
                strMaSach = value
            End Set
        End Property

#End Region

#Region "Function"
        Public Sub Create()
            strMaCTPhieuNhap = ""
            strMaPhieuNhapSach = ""
            strMaSach = ""
            intSoLuongNhap = 0
        End Sub

        Public Sub Create(ByVal mactphieunhap As String, ByVal maphieunhap As String, ByVal masach As String, ByVal soluongnhap As Integer)
            strMaCTPhieuNhap = mactphieunhap
            strMaPhieuNhapSach = maphieunhap
            strMaSach = masach
            intSoLuongNhap = soluongnhap

        End Sub
#End Region
    End Class

End Namespace
