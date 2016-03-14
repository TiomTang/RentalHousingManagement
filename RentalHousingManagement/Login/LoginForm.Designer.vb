<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"111", "222", "333"}, -1)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServerAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDbName = New System.Windows.Forms.TextBox()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.txtPassWord = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "连接地址"
        '
        'txtServerAddress
        '
        Me.txtServerAddress.Location = New System.Drawing.Point(85, 23)
        Me.txtServerAddress.Name = "txtServerAddress"
        Me.txtServerAddress.Size = New System.Drawing.Size(170, 21)
        Me.txtServerAddress.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "连接端口"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(85, 58)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(67, 21)
        Me.txtPort.TabIndex = 3
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(18, 91)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "新建连接"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(180, 91)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "保存连接"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(269, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "数据库名称"
        '
        'txtDbName
        '
        Me.txtDbName.Location = New System.Drawing.Point(338, 23)
        Me.txtDbName.Name = "txtDbName"
        Me.txtDbName.Size = New System.Drawing.Size(100, 21)
        Me.txtDbName.TabIndex = 8
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(99, 91)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 9
        Me.btnDel.Text = "删除连接"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(269, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "账号"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(269, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "密码"
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(338, 58)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(100, 21)
        Me.txtAccount.TabIndex = 12
        '
        'txtPassWord
        '
        Me.txtPassWord.Location = New System.Drawing.Point(338, 93)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.Size = New System.Drawing.Size(100, 21)
        Me.txtPassWord.TabIndex = 13
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(191, 264)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 14
        Me.btnLogin.Text = "登录"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView1.LabelWrap = False
        Me.ListView1.Location = New System.Drawing.Point(18, 120)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(420, 130)
        Me.ListView1.TabIndex = 15
        Me.ListView1.TabStop = False
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 299)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassWord)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.txtDbName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtServerAddress)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "连接数据库"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtServerAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDbName As TextBox
    Friend WithEvents btnDel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAccount As TextBox
    Friend WithEvents txtPassWord As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents ListView1 As ListView
End Class
