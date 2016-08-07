Public Class frmSearch


    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If txtsearch.Text = "" Then
            MessageBox.Show("Chưa nhập tên khách hàng")
        Else
            Dim sql As String =
             <sql>
                select * from Khach_Hang
                where HoTen Like N'%{0}%'
            </sql>
            sql = String.Format(sql, txtsearch.Text)
            thucthi(sql, "Search")
            dgv3.DataSource = ds.Tables("Search")
        End If

    End Sub

    Private Sub btnquaylai_Click(sender As Object, e As EventArgs) Handles btnquaylai.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class