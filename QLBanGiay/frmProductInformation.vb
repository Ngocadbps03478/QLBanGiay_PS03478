Public Class frmProductInformation
    Private Sub thucthi1()
        Dim sql As String =
            <sql>
                 select MaSP, TenSP, DonGia, DonViTinh, TenLoai
                from San_Pham join Loai_SP on San_Pham.MaLoai = Loai_SP.MaLoai   
            </sql>
        thucthi(sql, "SanPham")
        bs.DataSource = ds.Tables("SanPham")
        dgv4.DataSource = bs
        bs.ResetBindings(False)
    End Sub

    Private Sub dgv4_SelectionChanged(sender As Object, e As EventArgs) Handles dgv4.SelectionChanged
        Try
            Dim bsrow As DataRowView = bs.Current
            Dim row As DataRow = bsrow.Row
            txtmasp.Text = row("MaSP")
            txttensp.Text = row("TenSP")
            txtdongia.Text = row("DonGia")
            txtdonvitinh.Text = row("DonViTinh")
            txtloaisp.Text = row("TenLoai")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnquaylai_Click(sender As Object, e As EventArgs) Handles btnquaylai.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub frmthongtinsp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        thucthi1()
    End Sub

    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        bs.MoveFirst()
    End Sub

    Private Sub btnpre_Click(sender As Object, e As EventArgs) Handles btnpre.Click
        bs.MovePrevious()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        bs.MoveNext()
    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        bs.MoveLast()
    End Sub

    Private Sub txtloaisp_TextChanged(sender As Object, e As EventArgs) Handles txtloaisp.TextChanged

    End Sub
End Class