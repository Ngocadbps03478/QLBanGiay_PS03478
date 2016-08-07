<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoiceDetails))
        Me.cbkh = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbhd = New System.Windows.Forms.ComboBox()
        Me.dgv5 = New System.Windows.Forms.DataGridView()
        Me.btnquaylai = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtngayhd = New System.Windows.Forms.TextBox()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtloaisp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdonvitinh = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtthanhtien = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnpre = New System.Windows.Forms.Button()
        CType(Me.dgv5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbkh
        '
        Me.cbkh.FormattingEnabled = True
        Me.cbkh.Location = New System.Drawing.Point(107, 12)
        Me.cbkh.Name = "cbkh"
        Me.cbkh.Size = New System.Drawing.Size(185, 21)
        Me.cbkh.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tên khách hàng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mã hóa đơn:"
        '
        'cbhd
        '
        Me.cbhd.FormattingEnabled = True
        Me.cbhd.Location = New System.Drawing.Point(107, 57)
        Me.cbhd.Name = "cbhd"
        Me.cbhd.Size = New System.Drawing.Size(185, 21)
        Me.cbhd.TabIndex = 2
        '
        'dgv5
        '
        Me.dgv5.AllowUserToAddRows = False
        Me.dgv5.AllowUserToDeleteRows = False
        Me.dgv5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5.Location = New System.Drawing.Point(12, 288)
        Me.dgv5.Name = "dgv5"
        Me.dgv5.ReadOnly = True
        Me.dgv5.Size = New System.Drawing.Size(669, 212)
        Me.dgv5.TabIndex = 5
        '
        'btnquaylai
        '
        Me.btnquaylai.Location = New System.Drawing.Point(127, 150)
        Me.btnquaylai.Name = "btnquaylai"
        Me.btnquaylai.Size = New System.Drawing.Size(61, 27)
        Me.btnquaylai.TabIndex = 34
        Me.btnquaylai.Text = "Quay lại"
        Me.btnquaylai.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.Location = New System.Drawing.Point(137, 84)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(51, 27)
        Me.btnload.TabIndex = 29
        Me.btnload.Text = "Load"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(395, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Ngày lập HD:"
        '
        'txtngayhd
        '
        Me.txtngayhd.Location = New System.Drawing.Point(472, 12)
        Me.txtngayhd.Name = "txtngayhd"
        Me.txtngayhd.Size = New System.Drawing.Size(185, 20)
        Me.txtngayhd.TabIndex = 37
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(472, 52)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(185, 20)
        Me.txttensp.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Tên sản phẩm:"
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(472, 130)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(185, 20)
        Me.txtdongia.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(419, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Đơn giá:"
        '
        'txtloaisp
        '
        Me.txtloaisp.Location = New System.Drawing.Point(472, 91)
        Me.txtloaisp.Name = "txtloaisp"
        Me.txtloaisp.Size = New System.Drawing.Size(185, 20)
        Me.txtloaisp.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(387, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Loại sản phẩm:"
        '
        'txtdonvitinh
        '
        Me.txtdonvitinh.Location = New System.Drawing.Point(472, 209)
        Me.txtdonvitinh.Name = "txtdonvitinh"
        Me.txtdonvitinh.Size = New System.Drawing.Size(185, 20)
        Me.txtdonvitinh.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(403, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Đơn vị tính:"
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(472, 169)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(185, 20)
        Me.txtsoluong.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(414, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Số lượng:"
        '
        'txtthanhtien
        '
        Me.txtthanhtien.Location = New System.Drawing.Point(472, 248)
        Me.txtthanhtien.Name = "txtthanhtien"
        Me.txtthanhtien.Size = New System.Drawing.Size(185, 20)
        Me.txtthanhtien.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(405, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Thành tiền:"
        '
        'btnlast
        '
        Me.btnlast.Location = New System.Drawing.Point(221, 117)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(51, 27)
        Me.btnlast.TabIndex = 53
        Me.btnlast.Text = ">|"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnfirst
        '
        Me.btnfirst.Location = New System.Drawing.Point(50, 117)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(51, 27)
        Me.btnfirst.TabIndex = 52
        Me.btnfirst.Text = "|<"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(164, 117)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(51, 27)
        Me.btnnext.TabIndex = 51
        Me.btnnext.Text = ">>"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnpre
        '
        Me.btnpre.Location = New System.Drawing.Point(107, 117)
        Me.btnpre.Name = "btnpre"
        Me.btnpre.Size = New System.Drawing.Size(51, 27)
        Me.btnpre.TabIndex = 50
        Me.btnpre.Text = "<<"
        Me.btnpre.UseVisualStyleBackColor = True
        '
        'frmInvoiceDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 512)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnpre)
        Me.Controls.Add(Me.txtthanhtien)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdonvitinh)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsoluong)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtdongia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtloaisp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtngayhd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnquaylai)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.dgv5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbhd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbkh)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInvoiceDetails"
        Me.Text = "Chi tiết hóa đơn"
        CType(Me.dgv5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbkh As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbhd As System.Windows.Forms.ComboBox
    Friend WithEvents dgv5 As System.Windows.Forms.DataGridView
    Friend WithEvents btnquaylai As System.Windows.Forms.Button
    Friend WithEvents btnload As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtngayhd As System.Windows.Forms.TextBox
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtloaisp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdonvitinh As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtthanhtien As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnpre As System.Windows.Forms.Button
End Class
