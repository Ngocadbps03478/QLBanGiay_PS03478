Public Class frmProductUpdates
    Private Sub thucthi1()
        Dim sql As String =
               <sql>
                select MaSP, TenSP, DonGia, DonViTinh, TenLoai
                from San_Pham join Loai_SP on San_Pham.MaLoai = Loai_SP.MaLoai
            </sql>
        thucthi(sql, "SanPham")
        dgv3.DataSource = ds.Tables("SanPham")
    End Sub

    Private Sub cbbox()
        If cbloaisp.Text = "Adidas Neo" Then
            lblmaloai.Text = "AD001"
        ElseIf cbloaisp.Text = "Adidas Tennis" Then
            lblmaloai.Text = "AD002"
        ElseIf cbloaisp.Text = "Adidas Originals" Then
            lblmaloai.Text = "AD003"
        ElseIf cbloaisp.Text = "Nike Running" Then
            lblmaloai.Text = "NK001"
        Else
            lblmaloai.Text = "NK002"
        End If
    End Sub

    'lấy dữ liệu
    Private Sub btnload_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub dgv3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv3.CellClick
        Dim click As Integer = dgv3.CurrentCell.RowIndex
        txtmasp.Text = dgv3.Item(0, click).Value
        txttensp.Text = dgv3.Item(1, click).Value
        txtdongia.Text = dgv3.Item(2, click).Value
        txtdonvitinh.Text = dgv3.Item(3, click).Value
        cbloaisp.Text = dgv3.Item(4, click).Value

        cbbox()
    End Sub

    'thêm
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If txtmasp.Text = "" Or txtdongia.Text = "" Or txtmasp.Text = "" Or txttensp.Text = "" Or lblmaloai.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin")
        Else
            Dim sql As String =
           <sql>
                insert into San_Pham (MaSP, TenSP, DonGia, DonViTinh, MaLoai)
                values ('{0}', N'{1}','{2}','{3}','{4}')
            </sql>
            sql = String.Format(sql, txtmasp.Text, txttensp.Text, txtdongia.Text, txtdonvitinh.Text, lblmaloai.Text)
            excute(sql)
            thucthi1()
        End If
    End Sub


    'xóa
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If txtmasp.Text = "" Then
            MessageBox.Show("Vui lòng nhập mã sản phẩm")
        Else
            Dim sql As String =
          <sql>
                delete from San_Pham
                where MaSP = '{0}'
            </sql>
            sql = String.Format(sql, txtmasp.Text)
            excute(sql)
            thucthi1()
        End If

    End Sub
    'sửa
    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        If txtmasp.Text = "" Then
            MessageBox.Show("Vui lòng nhập mã sản phẩm")
        Else
            Dim sql As String =
                <sql>
                update San_Pham
                set TenSP = N'{1}', DonGia = '{2}', DonViTinh = N'{3}', MaLoai = '{4}'
                where MaSP = '{0}'
            </sql>
            sql = String.Format(sql, txtmasp.Text, txttensp.Text, txtdongia.Text, txtdonvitinh.Text, lblmaloai.Text)
            excute(sql)
            thucthi1()
        End If
    End Sub




    Private Sub cbloaisp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbloaisp.SelectedIndexChanged
        cbbox()
    End Sub

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        txttensp.Clear()
        txtdongia.Clear()
        txtdonvitinh.Clear()
        txtmasp.Clear()
    End Sub

    Private Sub btnquaylai_Click(sender As Object, e As EventArgs) Handles btnquaylai.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub frmsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String =
       <sql>
                select * from Loai_SP
            </sql>
        thucthi(sql, "LoaiSP")
        cbloaisp.DataSource = ds.Tables("LoaiSP")
        cbloaisp.DisplayMember = "TenLoai"
        cbloaisp.ValueMember = "MaLoai"
        thucthi1()
        cbbox()
    End Sub
End Class