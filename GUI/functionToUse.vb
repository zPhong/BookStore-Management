Imports System
Imports DTO.DTO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports Geocoding
Imports Geocoding.Google
Imports System.Linq


Public Class functionToUse

#Region "Declare Connection And funtion Execute"
    Public Shared sqlCon As New SqlConnection

    Public Shared Sub CreateConnect()
        Dim strConnect As String = "Data Source=" + SystemInformation.ComputerName + "\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True"

        If (sqlCon.State = ConnectionState.Open) Then
            sqlCon.Close()
        End If
        sqlCon.ConnectionString = strConnect
        sqlCon.Open()
    End Sub

    Public Shared Function ExecuteQuery(query As String) As Integer
        Using comm As New SqlCommand(query, sqlCon)
            If (sqlCon.State = ConnectionState.Open) Then
                comm.ExecuteNonQuery()
                Return 1
            Else
                MessageBox.Show("Insert Failed. Connection is closing ")
                sqlCon.Close()
                Return 0
            End If
        End Using
    End Function

#End Region

    Public Shared Function CreatePrimaryKey(ByVal tenbang As String, ByVal tenthuoctinhkhoa As String, ByVal prefix As String, ByVal buocnhay As Integer) As String
        'Load du lieu khoa tu bang
        CreateConnect()
        Dim data As DataTable = LoadData(tenbang, tenthuoctinhkhoa)
        Dim khoa As String = String.Empty
        Dim lengthMax As Integer = 6
        If (tenbang = "chitiethoadon" Or tenbang = "chitietphieunhap") Then
            lengthMax = 10
        End If

        'Tao khoa
        '  Neu chua co du lieu
        If data.Rows.Count = 0 Then
            If (lengthMax = 6) Then
                If prefix.Length = 1 Then
                    khoa = prefix + "00000"
                End If
                If prefix.Length = 2 Then
                    khoa = prefix + "0000"
                End If
                If prefix.Length = 3 Then
                    khoa = prefix + "000"
                End If
                If prefix.Length = 4 Then
                    khoa = prefix + "00"
                End If
            Else
                If prefix.Length = 1 Then
                    khoa = prefix + "000000000"
                End If
                If prefix.Length = 2 Then
                    khoa = prefix + "00000000"
                End If
                If prefix.Length = 3 Then
                    khoa = prefix + "0000000"
                End If
                If prefix.Length = 4 Then
                    khoa = prefix + "000000"
                End If
            End If
        End If
        '  Neu da co du lieu
        Dim sokhoa(data.Rows.Count) As Integer

        For i = 0 To data.Rows.Count - 1
            Dim str As String
            str = data.Rows(i)(0)
            str = str.Remove(0, prefix.Length) 'Loai bo prefix
            sokhoa(i) = Integer.Parse(str)
        Next
        ' Tim so lon nhat trong khoa
        Dim max As Integer = sokhoa(0)
        For Each i As Integer In sokhoa
            If max < i Then
                max = i
            End If
        Next
        Dim chisokhoaLenght As Integer
        chisokhoaLenght = (max + 1 + buocnhay).ToString().Length
        Dim strChuoiSo0 As String = ""
        For i = 0 To (lengthMax - chisokhoaLenght - prefix.Length - 1)
            strChuoiSo0 += "0"
        Next
        khoa = (prefix + strChuoiSo0 + (max + 1 + buocnhay).ToString())
        Return khoa
    End Function


    Public Shared Function LoadData(strTableName As String, strPrimaryKey As String) As DataTable
        Dim query As String
        query = "Select * from " & strTableName
        CreateConnect()
        Dim ds As New DataTable
        Dim adapter As New SqlDataAdapter(query, sqlCon)
        adapter.Fill(ds)
        adapter.Update(ds)
        Return ds
    End Function

    Public Shared Function Num2Text(S As String) As String
        Dim So() As String
        Dim So1() As String
        Dim Hang() As String
        So = Split("khong mot hai ba bon nam sau bay tam chin", " ")
        So1 = Split("linh mot bon lam muoi muoi", " ")
        Hang = Split(" nghin trieu ty", " ")
        Dim I, J, Donvi, Chuc, Tram As Integer
        Dim StrValue$, S1$
        Hang(0) = ""
        StrValue = ""
        For I = 1 To Len(S)
            If IsNumeric(Mid(S, I, 1)) Then
                S1 = S1 & Mid(S, I, 1)
            ElseIf Mid(S, I, 1) = "," Then
                Exit For
            End If
        Next
        S = S1
        If Len(S) = 0 Then Exit Function
        If S = "0" Then
            Return "khong"
            Exit Function
        End If
        While Left(S, 1) = "0"
            S = Right(S, Len(S) - 1)
        End While
        I = Len(S)
        J = 0
        Do While I > 0
            Donvi = Int(Mid(S, I, 1))
            I = I - 1
            If I > 0 Then
                Chuc = Int(Mid(S, I, 1))
            Else
                Chuc = -1
            End If
            I = I - 1
            If I > 0 Then
                Tram = Int(Mid(S, I, 1))
            Else
                Tram = -1
            End If
            I = I - 1
            If Donvi > 0 Or Chuc > 0 Or Tram > 0 Or J = 3 Then
                StrValue = Hang(J) & " " & StrValue
            End If
            J = J + 1
            If J > 3 Then
                J = 1
            End If
            If Donvi = 1 And Chuc > 1 Then
                StrValue = So1(1) & " " & StrValue
            ElseIf Donvi = 4 And Chuc > 1 Then
                StrValue = So1(2) & " " & StrValue
            Else
                If Donvi = 5 And Chuc > 0 Then
                    StrValue = So1(3) & " " & StrValue
                ElseIf Donvi > 0 Then
                    StrValue = So(Donvi) & " " & StrValue
                End If
            End If
            If Chuc < 0 Then
                Exit Do
            Else
                If Chuc = 0 And Donvi > 0 Then
                    StrValue = So1(0) & " " & StrValue
                ElseIf Chuc = 1 Then
                    StrValue = So1(4) & " " & StrValue
                ElseIf Chuc > 1 Then
                    StrValue = So(Chuc) & " " & So1(5) & " " & StrValue
                End If
            End If
            If Tram < 0 Then
                Exit Do
            Else
                If Tram > 0 Or Chuc > 0 Or Donvi > 0 Then
                    StrValue = So(Tram) & " trăm " & StrValue
                End If
            End If
        Loop
        For I = 1 To 3
            StrValue = Replace(StrValue, Hang(I), Hang(I) & ",")
        Next
        StrValue = Replace(StrValue, ", " & Hang(3), " " & Hang(3))
        StrValue = Trim(StrValue)
        If Right(StrValue, 1) = "," Then StrValue = Left(StrValue, Len(StrValue) - 1)
        StrValue = UCase(Left(StrValue, 1)) & Right(StrValue, Len(StrValue) - 1)
        Return StrValue
    End Function



    Public Shared Function LoadThamSoQuyDinh(cot As Integer) As Integer
        Dim query As String
        query = "Select * from thamso"
        CreateConnect()
        Dim dataset As New DataSet
        Dim adapter As New SqlDataAdapter(query, functionToUse.sqlCon)
        adapter.Fill(dataset)
        adapter.Update(dataset)
        Return Integer.Parse(dataset.Tables(0).Rows(0)(cot).ToString())
    End Function

    Public Shared Function FixedAddress(ByVal addr As String) As String
        Dim geocoder As IGeocoder
        geocoder = New GoogleGeocoder("AIzaSyDACOr7cCwQXdN3RizokCbPzeqFcBH297Y")
        Dim addresses As IEnumerable(Of Address) = geocoder.Geocode(addr)
        Return addresses.First().FormattedAddress
    End Function

    Public Shared Function IsValidPhoneNumber(ByVal phonenumber As String) As Boolean
        If (FormatChecking.CheckValid.IsValidPhoneNumber(phonenumber, FormatChecking.CountryCode.Vietnam)) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function IsValidEmail(ByVal emailadd As String) As Boolean
        If (FormatChecking.CheckValid.IsValidEmail(emailadd)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Sub UpdateTienNo(ByVal tienphatsinh As Integer, ByVal thang As Integer, ByVal khDTO As KhachHangDTO)
        '
        khDTO.SoTienNo += tienphatsinh
        Bus.BUS.KhachHangBUS.updateTienNoKhachHang(khDTO)



        Dim baocaocongnoDTO As New DTO.DTO.BaoCaoCongNoDTO

        'Update bao cao nợ
        baocaocongnoDTO.MaCongNo = functionToUse.CreatePrimaryKey("baocaocongno", "macongno", "MCN", 0)
        baocaocongnoDTO.Thang = thang
        baocaocongnoDTO.MaKhachHang = khDTO.MaKH
        baocaocongnoDTO.NoCuoi = khDTO.SoTienNo

        'Dữ liệu nợ tháng trước'''''-----------Du lieu nợ thang truoc bi loi
        Dim dttBaoCaoCongNo As DataTable = functionToUse.LoadData("baocaocongno", "macongno")
        Dim dtSelectedLastMonth() As DataRow = dttBaoCaoCongNo.Select(String.Format("makhachhang='{0}' AND thang={1}", khDTO.MaKH, thang - 1))
        'Dữ liệu tồn tháng này
        dttBaoCaoCongNo = functionToUse.LoadData("baocaocongno", "macongno")
        Dim dtSelectedThisMonth() As DataRow = dttBaoCaoCongNo.Select(String.Format("makhachhang='{0}' AND thang={1}", khDTO.MaKH, thang))

        'Nếu tồn tại tháng trước
        If (dtSelectedLastMonth.Count >= 1) Then
            baocaocongnoDTO.NoDau = Integer.Parse(dtSelectedLastMonth(0)(5).ToString())
        Else
            baocaocongnoDTO.NoDau = 0
        End If

        baocaocongnoDTO.NoPhatSinh = baocaocongnoDTO.NoCuoi - baocaocongnoDTO.NoDau

        'Rut nợ phat sinh tu thang hien tai
        If (dtSelectedThisMonth.Count >= 1) Then
            'baocaotonDTO.TonPhatSinh = Integer.Parse(dtSelectedThisMonth(0)(4).ToString()) + Integer.Parse(row.Cells(4).Value)
            Bus.BUS.BaoCaoCongNoBUS.updateBaoCaoCongNo(baocaocongnoDTO)
        Else
            baocaocongnoDTO.Create(functionToUse.CreatePrimaryKey("baocaocongno", "macongno", "MCN", 0), khDTO.MaKH, thang, baocaocongnoDTO.NoDau, baocaocongnoDTO.NoPhatSinh, baocaocongnoDTO.NoCuoi)
            Bus.BUS.BaoCaoCongNoBUS.insertBaoCaoCongNo(baocaocongnoDTO)
        End If













    End Sub

    Public Shared Sub UpdateBaoCaoTon(ByVal thang As Integer, ByVal sachDTO As DTO.DTO.SachDTO, ByVal tonphatsinh As Integer)

    End Sub
    Public Shared Function LoadDataWithQuery(strTableName As String, query As String) As DataTable
        CreateConnect()
        Dim ds As New DataTable
        Dim adapter As New SqlDataAdapter(query, sqlCon)
        adapter.Fill(ds)
        adapter.Update(ds)
        Return ds
    End Function

End Class
