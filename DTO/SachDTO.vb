
Namespace DTO

    Public Class SachDTO

#Region "Declare"

        Private strMaSach As String
        Private strTenSach As String
        Private strTacGia As String
        Private strTheLoai As String

        Private intSoLuongTon As Integer
        'Private dobDonGia As Double
        Property MaSach() As String
            Get
                Return strMaSach
            End Get
            Set(value As String)
                strMaSach = value
            End Set
        End Property
        Property SoLuongTon() As Integer
            Get
                Return intSoLuongTon
            End Get
            Set(value As Integer)
                intSoLuongTon = value
            End Set
        End Property

        Property TacGia() As String
            Get
                Return strTacGia
            End Get
            Set(value As String)
                strTacGia = value
            End Set
        End Property

        Property TenSach() As String
            Get
                Return strTenSach
            End Get
            Set(value As String)
                strTenSach = value
            End Set
        End Property

        Property TheLoai() As String
            Get
                Return strTheLoai
            End Get
            Set(value As String)
                strTheLoai = value
            End Set
        End Property

        '  Public Property DonGia() As Double
        'Get
        '        Return dobDonGia
        '    End Get
        '    Set(value As Double)
        '        dobDonGia = value
        '    End Set
        'End Property

#End Region

#Region "Function"

        Public Sub Create()
            strMaSach = ""
            strTenSach = ""
            strTheLoai = ""
            strTacGia = ""
            intSoLuongTon = 0
            'dobDonGia = 0
        End Sub
        'Public Sub Create(ByVal masach As String, ByVal tensach As String, ByVal theloai As String, ByVal tacgia As String, ByVal soluongton As Integer, ByVal dongia As Double)

        Public Sub Create(ByVal masach As String, ByVal tensach As String, ByVal theloai As String, ByVal tacgia As String, ByVal soluongton As Integer)
            strMaSach = masach
            strTenSach = tensach
            strTheLoai = theloai
            strTacGia = tacgia
            intSoLuongTon = soluongton
            'dobDonGia = dongia
        End Sub
#End Region

    End Class

End Namespace
