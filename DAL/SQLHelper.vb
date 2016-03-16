Imports MySql.Data.MySqlClient
Imports Moudels
Imports CommonClass

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
            Return resulf
        Catch ex As Exception
            ErrorLogService.SaveErrorMessage(ex.Message)
            Return resulf
        Finally
            conn.Close()
        End Try


    End Function

    Public Function GetReader(ByVal sqlString As String) As MySqlDataReader
        Dim cmd As New MySqlCommand(sqlString, conn)
        Try
            conn.Open()
            Return cmd.ExecuteReader
        Catch ex As Exception
            ErrorLogService.SaveErrorMessage(ex.Message)
        Finally

        End Try


    End Function

    Public Function GetSingleResult(ByVal sqlString As String) As Object
        Dim cmd As New MySqlCommand(sqlString, conn)
        Dim myobj As New Object
        Try
            conn.Open()
            myobj = cmd.ExecuteScalar
            Return myobj
        Catch ex As Exception
            ErrorLogService.SaveErrorMessage(ex.Message)
            Return myobj
        Finally
            conn.Close()

        End Try



    End Function

    Public Function GetDataTable(ByVal sqlString As String) As DataTable
        Dim ada As New MySqlDataAdapter(sqlString, conn)
        Dim newDT As New DataTable
        Try
            conn.Open()

            ada.Fill(newDT)
            Return newDT
        Catch ex As Exception
            ErrorLogService.SaveErrorMessage(ex.Message)
            Return newDT
        Finally
            conn.Close()
        End Try
    End Function
End Class
