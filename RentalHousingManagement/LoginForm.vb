
Imports DAL
Imports Moudels
Imports MySql.Data.MySqlClient
Imports CommonClass

Public Class LoginForm

    Private AddressBook As DbAddressBook
    Private _currentIndex As Integer

    '获取当前的DbAddress 只读
    Private ReadOnly Property CurrentAddress As DBAddress
        Get
            Return AddressBook.Items(currentIndex - 1)
        End Get
    End Property

    '表示当前数据索引位置
    Private Property currentIndex As Integer
        Get
            Return _currentIndex
        End Get
        Set(value As Integer)
            _currentIndex = value
            OutPutText(CurrentAddress)
            OutPutList(AddressBook)
        End Set
    End Property

    Private ReadOnly Property DataFilename As String
        Get
            Dim folder As String
            folder = Environment.CurrentDirectory
            Return folder & "\AddressBook.xml"

        End Get
    End Property

    '将文本内容输入空的DBAddress对象
    Private Sub InputAddress(ByVal emptyDbAddress As DBAddress)
        emptyDbAddress.Account = StringSecurity.DESEncrypt(txtAccount.Text)
        emptyDbAddress.DataBaseName = StringSecurity.DESEncrypt(txtDbName.Text)
        emptyDbAddress.PassWord = StringSecurity.DESEncrypt(txtPassWord.Text)
        emptyDbAddress.Port = StringSecurity.DESEncrypt(txtPort.Text)
        emptyDbAddress.ServerAddress = StringSecurity.DESEncrypt(txtServerAddress.Text)
    End Sub

    '从DbAddress中输出到文本框
    Private Sub OutPutText(ByVal emptyDbAddress As DBAddress)
        txtAccount.Text = StringSecurity.DESDecrypt(emptyDbAddress.Account)
        txtDbName.Text = StringSecurity.DESDecrypt(emptyDbAddress.DataBaseName)
        txtPassWord.Text = StringSecurity.DESDecrypt(emptyDbAddress.PassWord)
        txtPort.Text = StringSecurity.DESDecrypt(emptyDbAddress.Port)
        txtServerAddress.Text = StringSecurity.DESDecrypt(emptyDbAddress.ServerAddress)
    End Sub

    Private Sub OutPutList(ByVal book As DbAddressBook)

        ListView1.Items.Clear()

        Dim i As Integer = 1
        For Each x As DBAddress In book.Items

            ListView1.Items.Add(New ListViewItem({i, StringSecurity.DESDecrypt(x.ServerAddress), StringSecurity.DESDecrypt(x.Port), StringSecurity.DESDecrypt(x.DataBaseName), StringSecurity.DESDecrypt(x.Account), StringSecurity.DESDecrypt(x.PassWord)}))
            i += 1
        Next
        ListView1.Items(currentIndex - 1).Selected = True


    End Sub

    '检查文本框是否有空
    Private Function CheckTextIsEmpty() As Boolean
        Return txtServerAddress.Text.Trim.Length > 0 AndAlso txtPort.Text.Trim.Length > 0 AndAlso txtDbName.Text.Trim.Length > 0 AndAlso txtAccount.Text.Trim.Length > 0 AndAlso txtPassWord.Text.Trim.Length > 0
    End Function

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        AddressBook.AddAddress()
        currentIndex = AddressBook.Items.Count

    End Sub
    Private Sub Load_LoadForm(sender As Object, e As EventArgs) Handles Me.Load

        AddressBook = DbAddressBook.Load(DataFilename, GetType(DbAddressBook))
        If AddressBook.Items.Count = 0 Then AddressBook.AddAddress()
        currentIndex = 1
        ListView1.Columns.Add("序号", 40)
        ListView1.Columns.Add("服务器", 150)
        ListView1.Columns.Add("端口", 40)
        ListView1.Columns.Add("数据库名")
        ListView1.Columns.Add("账户")
        ListView1.Columns.Add("密码")

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CheckTextIsEmpty() Then
            InputAddress(CurrentAddress)
            AddressBook.Save(DataFilename)

            currentIndex = _currentIndex
        Else
            MessageBox.Show("保存失败，请检查是否全部填写。")
        End If

    End Sub



    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        AddressBook.Items.Remove(CurrentAddress)
        If AddressBook.Items.Count = 0 Then AddressBook.AddAddress()
        currentIndex = 1
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        sqlhelp = New SQLHelper(CurrentAddress)



    End Sub

    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        currentIndex = ListView1.SelectedItems.Item(0).Text
    End Sub
End Class