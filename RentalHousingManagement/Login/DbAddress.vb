Public Class DBAddress
    Public ServerAddress As String
    Public Port As String
    Public DataBaseName As String
    Public Account As String
    Public PassWord As String
    Public Overrides Function ToString() As String
        Return String.Format("服务器地址：{0}；端口：{1}；数据库名：{2}；用户名：{3}；密码：{4}"， ServerAddress, Port, DataBaseName, Account, PassWord）
    End Function
    Public Function ToListViewItem(i As Integer) As ListViewItem
        Dim newListViewItem As New ListViewItem({i, ServerAddress, Port, DataBaseName, Account, PassWord})
        Return newListViewItem

    End Function
End Class
