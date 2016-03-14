Imports MySql.Data.MySqlClient
Imports Moudels

Public Class SQLHelper
    Private conn As MySqlConnection

    Public Sub New(ByVal dataBaseAddress As DBAddress)
        conn = New MySqlConnection(String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", dataBaseAddress.ServerAddress, dataBaseAddress.Port, dataBaseAddress.DataBaseName, dataBaseAddress.Account, dataBaseAddress.PassWord))
    End Sub

    Public Function Update(ByVal sqlString As String) As Integer
        Dim cmd As New MySqlCommand(sqlString, conn)
        Dim resulf As Integer = 0
        Try
            conn.Open()
            resulf = cmd.ExecuteNonQuery()

        Catch ex As Exception

        Finally
            conn.Close()
        End Try
        Return resulf

    End Function

    Public Function GetReader(ByVal sqlString As String) As MySqlDataReader
        Dim cmd As New MySqlCommand(sqlString, conn)
        Try
            conn.Open()
            Return cmd.ExecuteReader
        Catch ex As Exception

        Finally

        End Try


    End Function

    Public Function GetSingleResult(ByVal sqlString As String) As Object
        Dim cmd As New MySqlCommand(sqlString, conn)
        Dim myobj As New Object
        Try
            conn.Open()
            myobj = cmd.ExecuteScalar

        Catch ex As Exception

        Finally
            conn.Close()

        End Try

        Return myobj

    End Function

    Public Function GetDataTable(ByVal sqlString As String) As DataTable
        Dim ada As New MySqlDataAdapter(sqlString, conn)
        Try
            conn.Open()
            Dim newDT As New DataTable
            ada.Fill(newDT)
            Return newDT
        Catch ex As Exception

        Finally
            conn.Close()
        End Try
    End Function
End Class
