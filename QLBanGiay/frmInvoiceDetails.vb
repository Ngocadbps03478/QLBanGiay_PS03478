Public Class frmInvoiceDetails

    Private Sub frmchitiethd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String =
           <sql>
                select * from Khach_Hang
            </sql>
        thucthi(sql, "KhachHang")
        cbkh.DataSource = ds.Tables("KhachHang")
        cbkh.DisplayMember = "HoTen"
        cbkh.ValueMember = "MaKH"
    End Sub

    Private Sub cbkh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkh.SelectedIndexChanged
        Dim sql As String =
          <sql>
                select * from Hoa_Don 
                where MaKH = N'{0}'
            </sql>
        sql = String.Format(sql, cbkh.SelectedValue)
        thucthi(sql, "HoaDon")

        cbhd.DataSource = ds.Tables("HoaDon")
        cbhd.DisplayMember = "MaHD"
        cbhd.ValueMember = "MaHD"

    End Sub


    Private Sub btnload_Click_1(sender As Object, e As EventArgs) Handles btnload.Click
        Dim sql As String =
    <sql>
                    select Hoa_Don.MaHD,Khach_Hang.HoTen, NgayLapHD, TenSP,Loai_SP.TenLoai, DonGia, SoLuong,DonViTinh,
		            (DonGia * SoLuong) as ThanhTien
                    from Khach_Hang join Hoa_Don on Khach_Hang.MaKH = Hoa_Don.MaKH
                    join HoaDon_CT on Hoa_Don.MaHD = HoaDon_CT.MaHD
                    join San_Pham on San_Pham.MaSP = HoaDon_CT.MaSP
                    join Loai_SP on Loai_SP.MaLoai = San_Pham.MaLoai
                    where Hoa_Don.MaHD = '{0}'
            </sql>

        sql = String.Format(sql, cbhd.SelectedValue)
        thucthi(sql, "cthd")
        bs.DataSource = ds.Tables("cthd")
        dgv5.DataSource = bs
        bs.ResetBindings(False)
    End Sub


    Private Sub dgv5_SelectionChanged(sender As Object, e As EventArgs) Handles dgv5.SelectionChanged
        Try
            Dim rowview As DataRowView = bs.Current
            Dim row As DataRow = rowview.Row

            txtngayhd.Text = row("NgayLapHD")
            txttensp.Text = row("TenSP")
            txtloaisp.Text = row("TenLoai")
            txtdongia.Text = row("DonGia")
            txtsoluong.Text = row("SoLuong")
            txtdonvitinh.Text = row("DonViTinh")
            txtthanhtien.Text = row("ThanhTien")
        Catch ex As Exception
        End Try
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

    Private Sub btnquaylai_Click(sender As Object, e As EventArgs) Handles btnquaylai.Click
        frmMain.Show()
        Me.Hide()
    End Sub


End Class