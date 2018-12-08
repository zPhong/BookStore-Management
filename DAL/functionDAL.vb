Imports System.Data.SqlClient
Imports System.Windows.Forms
Namespace DAL
    Public Class functionDAL
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
    End Class
End Namespace
