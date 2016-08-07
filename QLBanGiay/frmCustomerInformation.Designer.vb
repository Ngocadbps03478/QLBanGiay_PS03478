<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerInformation))
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.txthoten = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.btnpre = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnquaylai = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 182)
        Me.dgv1.MultiSelect = False
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(524, 169)
        Me.dgv1.TabIndex = 1
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(100, 12)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(149, 20)
        Me.txtmakh.TabIndex = 1
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(375, 12)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(161, 20)
        Me.txtsdt.TabIndex = 2
        '
        'txthoten
        '
        Me.txthoten.Location = New System.Drawing.Point(100, 66)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(149, 20)
        Me.txthoten.TabIndex = 3
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(375, 69)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(161, 20)
        Me.txtemail.TabIndex = 4
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(100, 123)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(149, 20)
        Me.txtdiachi.TabIndex = 5
        '
        'btnpre
        '
        Me.btnpre.Location = New System.Drawing.Point(371, 116)
        Me.btnpre.Name = "btnpre"
        Me.btnpre.Size = New System.Drawing.Size(51, 27)
        Me.btnpre.TabIndex = 6
        Me.btnpre.Text = "<<"
        Me.btnpre.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(428, 116)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(51, 27)
        Me.btnnext.TabIndex = 7
        Me.btnnext.Text = ">>"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mã khách hàng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Họ và tên:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(296, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Số điện thoại:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Địa chỉ:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(334, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Email:"
        '
        'btnfirst
        '
        Me.btnfirst.Location = New System.Drawing.Point(314, 116)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(51, 27)
        Me.btnfirst.TabIndex = 13
        Me.btnfirst.Text = "|<"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btnlast
        '
        Me.btnlast.Location = New System.Drawing.Point(485, 116)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(51, 27)
        Me.btnlast.TabIndex = 14
        Me.btnlast.Text = ">|"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnquaylai
        '
        Me.btnquaylai.Location = New System.Drawing.Point(396, 149)
        Me.btnquaylai.Name = "btnquaylai"
        Me.btnquaylai.Size = New System.Drawing.Size(61, 27)
        Me.btnquaylai.TabIndex = 29
        Me.btnquaylai.Text = "Quay lại"
        Me.btnquaylai.UseVisualStyleBackColor = True
        '
        'frmCustomerInformation
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
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txthoten)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.dgv1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomerInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin khách hàng"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents txthoten As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents btnpre As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnquaylai As System.Windows.Forms.Button
End Class
