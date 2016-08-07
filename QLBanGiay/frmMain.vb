Public Class frmMain
    Private Sub ThôngTinKháchHàngToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ThôngTinKháchHàngToolStripMenuItem1.Click
        frmCustomerInformation.Show()
        Me.Hide()
    End Sub

    Private Sub CậtNhậtKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậtNhậtKháchHàngToolStripMenuItem.Click
        frmCustomerUpdates.Show()
        Me.Hide()
    End Sub

    Private Sub ThôngTinSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinSảnPhẩmToolStripMenuItem.Click
        frmProductInformation.Show()
        Me.Hide()
    End Sub

    Private Sub CậpNhậtSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậtSảnPhẩmToolStripMenuItem.Click
        frmProductUpdates.Show()
        Me.Hide()
    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        frmInvoiceDetails.Show()
        Me.Hide()
    End Sub

    Private Sub ThôngTinỨngDụngToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmIntro.Show()
        Me.Hide()
    End Sub

    Private Sub TìmKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKháchHàngToolStripMenuItem.Click
        frmSearch.Show()
        Me.Hide()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
