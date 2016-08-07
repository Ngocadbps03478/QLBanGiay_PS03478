Imports System.Data.SqlClient
Public Class frmCustomerInformation
    'load'
    Private Sub frmthongtinkh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String =
            <sql>
                select * from Khach_Hang    
            </sql>
        thucthi(sql, "KhachHang")
        bs.DataSource = ds.Tables("KhachHang")
        dgv1.DataSource = bs
        bs.ResetBindings(False)
    End Sub
    'đổ dữ liệu lên txt'
    Private Sub dgv1_SelectionChanged_1(sender As Object, e As EventArgs) Handles dgv1.SelectionChanged
        Try
            Dim bsrow As DataRowView = bs.Current
            Dim abc As DataRow = bsrow.Row
            txtmakh.Text = abc("MaKH")
            txthoten.Text = abc("HoTen")
            txtdiachi.Text = abc("DiaChi")
            txtsdt.Text = abc("SoDienThoai")
            txtemail.Text = abc("Email")
        Catch ex As Exception
        End Try
    End Sub
    'tới lùi'
    Private Sub btnpre_Click(sender As Object, e As EventArgs) Handles btnpre.Click
        bs.MovePrevious()
    End Sub
    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        bs.MoveNext()
    End Sub
    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        bs.MoveLast()
    End Sub
    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        bs.MoveFirst()
    End Sub
    Private Sub btnquaylai_Click(sender As Object, e As EventArgs) Handles btnquaylai.Click
        frmMain.Show()
        Me.Hide()
    End Sub
End Class