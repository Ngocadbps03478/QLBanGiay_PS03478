Imports System.Data.SqlClient

Module Database
    Public ds As New DataSet
    'Dim link As String = "Data Source=.\sqlexpress;Initial Catalog=PS03478_Assignment;Integrated Security=True"
    Dim link As String = "workstation id=ngocadbps03478.mssql.somee.com;packet size=4096;user id=Ngocadbps03478_SQLLogin_1;pwd=tgks3mg66d;data source=ngocadbps03478.mssql.somee.com;persist security info=False;initial catalog=ngocadbps03478"

    Public Sub excute(sql As String)
        Dim cnn As New SqlConnection(link)
        Dim command As New SqlCommand(sql, cnn)
        cnn.Open()
        command.ExecuteNonQuery()
        cnn.Close()
    End Sub

    Public Sub thucthi(sql As String, tablename As String)
        Dim cnn As New SqlConnection(link)
        Dim adapter As New SqlDataAdapter(sql, cnn)
        If ds.Tables.Contains(tablename) Then
            ds.Tables(tablename).Clear()
        End If
        adapter.Fill(ds, tablename)
        cnn.Close()
    End Sub




End Module
