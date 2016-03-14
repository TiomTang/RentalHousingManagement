Imports System.Xml.Serialization

Public Class DbAddressBook

    '继承自XML序列化处理类
    Inherits SerializableData

    '声明特性，忽略该字段，不被序列化，因不支持类型的序列化会导致出错
    <System.Xml.Serialization.XmlIgnore> Public Property Items As New ArrayList

    '新建一个空的DBAddress类，并返回该空类，用于添加新的数据
    '为什么不直接将新的属性添加进原有的序列？
    '返回一个空类的好处是，不需要在类中固化字段，如果日后有更改，代码照样可以使用。
    Public Function AddAddress() As DBAddress
        Dim newAddress As New DBAddress
        Items.Add(newAddress)
        Return newAddress
    End Function


    Public Property Addresses() As DBAddress()
        '序列化类在读取该属性时，GET方法可返回一个数组，用于序列化
        Get
            Dim addressArray(Items.Count - 1) As DBAddress
            Items.CopyTo(addressArray)
            Return addressArray
        End Get

        Set(value As DBAddress())
            Items.Clear()
            If Not value Is Nothing Then
                Dim address As DBAddress
                For Each address In value
                    Items.Add(address)
                Next
            End If
        End Set
    End Property
End Class
