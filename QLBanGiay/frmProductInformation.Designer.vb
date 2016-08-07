<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductInformation))
        Me.btnquaylai = New System.Windows.Forms.Button()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnpre = New System.Windows.Forms.Button()
        Me.dgv4 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdonvitinh = New System.Windows.Forms.TextBox()
        Me.txtloaisp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgv4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnquaylai
        '
        Me.btnquaylai.Location = New System.Drawing.Point(398, 150)
        Me.btnquaylai.Name = "btnquaylai"
        Me.btnquaylai.Size = New System.Drawing.Size(61, 27)
        Me.btnquaylai.TabIndex = 45
        Me.btnquaylai.Text = "Quay lại"
        Me.btnquaylai.UseVisualStyleBackColor = True
        '
        'btnlast
        '
        Me.btnlast.Location = New System.Drawing.Point(487, 117)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(51, 27)
        Me.btnlast.TabIndex = 44
        Me.btnlast.Text = ">|"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnfirst
        '
        Me.btnfirst.Location = New System.Drawing.Point(316, 117)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(51, 27)
        Me.btnfirst.TabIndex = 43
        Me.btnfirst.Text = "|<"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(430, 117)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(51, 27)
        Me.btnnext.TabIndex = 37
        Me.btnnext.Text = ">>"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnpre
        '
        Me.btnpre.Location = New System.Drawing.Point(373, 117)
        Me.btnpre.Name = "btnpre"
        Me.btnpre.Size = New System.Drawing.Size(51, 27)
        Me.btnpre.TabIndex = 36
        Me.btnpre.Text = "<<"
        Me.btnpre.UseVisualStyleBackColor = True
        '
        'dgv4
        '
        Me.dgv4.AllowUserToAddRows = False
        Me.dgv4.AllowUserToDeleteRows = False
        Me.dgv4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4.Location = New System.Drawing.Point(14, 183)
        Me.dgv4.MultiSelect = False
        Me.dgv4.Name = "dgv4"
        Me.dgv4.ReadOnly = True
        Me.dgv4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv4.Size = New System.Drawing.Size(524, 169)
        Me.dgv4.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Mã sản phẩm:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Đơn vị tính:"
        '
        'txtdonvitinh
        '
        Me.txtdonvitinh.Location = New System.Drawing.Point(377, 13)
        Me.txtdonvitinh.Name = "txtdonvitinh"
        Me.txtdonvitinh.Size = New System.Drawing.Size(161, 20)
        Me.txtdonvitinh.TabIndex = 32
        '
        'txtloaisp
        '
        Me.txtloaisp.Location = New System.Drawing.Point(377, 70)
        Me.txtloaisp.Name = "txtloaisp"
        Me.txtloaisp.Size = New System.Drawing.Size(161, 20)
        Me.txtloaisp.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Đơn giá:"
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(102, 124)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(149, 20)
        Me.txtdongia.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Tên sản phẩm:"
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(102, 67)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(149, 20)
        Me.txttensp.TabIndex = 33
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(102, 13)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(149, 20)
        Me.txtmasp.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(292, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Loại sản phẩm:"
        '
        'frmProductInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 364)
        Me.Controls.Add(Me.btnquaylai)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnpre)
        Me.Controls.Add(Me.txtdongia)
        Me.Controls.Add(Me.txtloaisp)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.txtdonvitinh)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.dgv4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductInformation"
        Me.Text = "Thông tin sản phẩm"
        CType(Me.dgv4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnquaylai As System.Windows.Forms.Button
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnpre As System.Windows.Forms.Button
    Friend WithEvents dgv4 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdonvitinh As System.Windows.Forms.TextBox
    Friend WithEvents txtloaisp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bs As System.Windows.Forms.BindingSource
End Class
