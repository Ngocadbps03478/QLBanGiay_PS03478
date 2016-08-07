Public Class frmCustomerUpdates
    Private Sub thucthi1()
        Dim sql As String =
            <sql>
                select * from Khach_Hang    
            </sql>
        thucthi(sql, "KhachHang")
        dgv2.DataSource = ds.Tables("KhachHang")
    End Sub
    'load'
    Private Sub frmcapnhatkh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        thucthi1()
    End Sub
    'đổ dữ liệu lên txt'
    Private Sub dgv2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv2.CellClick
        Dim click As Integer = dgv2.CurrentCell.RowIndex
        txtmakh.Text = dgv2.Item(0, click).Value
        txthoten.Text = dgv2.Item(1, click).Value
        txtdiachi.Text = dgv2.Item(2, click).Value
        txtsdt.Text = dgv2.Item(3, click).Value
        txtemail.Text = dgv2.Item(4, click).Value
    End Sub
    'thêm'
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If txtmakh.Text = "" Or txthoten.Text = "" Or txtdiachi.Text = "" Or txtsdt.Text = "" Or txtemail.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin")
        Else
            Dim sql As String =
            <sql>
                insert into Khach_Hang (MaKH, HoTen, DiaChi, SoDienThoai, Email)
                values ('{0}',N'{1}',N'{2}','{3}','{4}')
            </sql>
            sql = String.Format(sql, txtmakh.Text, txthoten.Text, txtdiachi.Text, txtsdt.Text, txtemail.Text)
            excute(sql)
            thucthi1()
        End If
    End Sub
    'xóa'
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If txtmakh.Text = "" Then
            MessageBox.Show("Vui lòng nhập mã khách hàng")
        Else
            Dim sql As String =
            <sql>
                delete from Khach_Hang
                where MaKH = '{0}'
            </sql>
            sql = String.Format(sql, txtmakh.Text)
            excute(sql)
            thucthi1()
        End If
    End Sub


    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        If txtmakh.Text = "" Then
            MessageBox.Show("Vui lòng nhập mã khách hàng")
        Else
            Dim sql As String =
       <sql>
                update Khach_Hang
                set HoTen = N'{1}', DiaChi = N'{2}', SoDienThoai = '{3}', Email = '{4}'
                where MaKH = '{0}'
            </sql>
            sql = String.Format(sql, txtmakh.Text, txthoten.Text, txtdiachi.Text, txtsdt.Text, txtemail.Text)
            excute(sql)
            thucthi1()
        End If
    End Sub
    'clear all'
    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        txtmakh.Clear()
        txthoten.Clear()
        txtdiachi.Clear()
        txtsdt.Clear()
        txtemail.Clear()
    End Sub



    Private Sub btnquaylai_Click(sender As Object, e As EventArgs) Handles btnquaylai.Click
        frmMain.Show()
        Me.Hide()

    End Sub



End Class