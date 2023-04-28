<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_laporan_transaksi_detail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.labelDetail = New System.Windows.Forms.Label()
        Me.DataGrid_pesanan = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cb_pembayaran = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cb_status = New System.Windows.Forms.ComboBox()
        Me.tb_pesanan = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tb_total = New System.Windows.Forms.TextBox()
        Me.TglOrder = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Telp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Alamat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.No_Order = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panel_home = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_idStaff = New System.Windows.Forms.TextBox()
        CType(Me.DataGrid_pesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.panel_home.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 276)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(722, 31)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Total Pesanan"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelDetail
        '
        Me.labelDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelDetail.AutoSize = True
        Me.labelDetail.BackColor = System.Drawing.Color.Black
        Me.labelDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDetail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelDetail.Location = New System.Drawing.Point(851, 19)
        Me.labelDetail.Name = "labelDetail"
        Me.labelDetail.Size = New System.Drawing.Size(122, 20)
        Me.labelDetail.TabIndex = 35
        Me.labelDetail.Text = "Detail Transaksi"
        '
        'DataGrid_pesanan
        '
        Me.DataGrid_pesanan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid_pesanan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGrid_pesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_pesanan.Location = New System.Drawing.Point(20, 37)
        Me.DataGrid_pesanan.Name = "DataGrid_pesanan"
        Me.DataGrid_pesanan.RowHeadersWidth = 62
        Me.DataGrid_pesanan.RowTemplate.Height = 28
        Me.DataGrid_pesanan.Size = New System.Drawing.Size(894, 238)
        Me.DataGrid_pesanan.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(685, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 20)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Laporan Transaksi"
        '
        'cb_pembayaran
        '
        Me.cb_pembayaran.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_pembayaran.FormattingEnabled = True
        Me.cb_pembayaran.Items.AddRange(New Object() {"Lunas", "Belum Lunas"})
        Me.cb_pembayaran.Location = New System.Drawing.Point(733, 108)
        Me.cb_pembayaran.Name = "cb_pembayaran"
        Me.cb_pembayaran.Size = New System.Drawing.Size(167, 32)
        Me.cb_pembayaran.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(831, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 20)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "/"
        '
        'cb_status
        '
        Me.cb_status.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_status.FormattingEnabled = True
        Me.cb_status.Items.AddRange(New Object() {"Baru", "Proses", "Selesai", "Diambil", "Batal"})
        Me.cb_status.Location = New System.Drawing.Point(733, 145)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(167, 32)
        Me.cb_status.TabIndex = 59
        '
        'tb_pesanan
        '
        Me.tb_pesanan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_pesanan.BackColor = System.Drawing.Color.Gainsboro
        Me.tb_pesanan.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pesanan.Location = New System.Drawing.Point(733, 226)
        Me.tb_pesanan.Name = "tb_pesanan"
        Me.tb_pesanan.ReadOnly = True
        Me.tb_pesanan.Size = New System.Drawing.Size(240, 30)
        Me.tb_pesanan.TabIndex = 58
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DataGrid_pesanan)
        Me.GroupBox2.Controls.Add(Me.tb_total)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 290)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(945, 364)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Pesanan"
        '
        'tb_total
        '
        Me.tb_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_total.Location = New System.Drawing.Point(740, 276)
        Me.tb_total.Multiline = True
        Me.tb_total.Name = "tb_total"
        Me.tb_total.Size = New System.Drawing.Size(174, 32)
        Me.tb_total.TabIndex = 14
        '
        'TglOrder
        '
        Me.TglOrder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TglOrder.BackColor = System.Drawing.Color.Gainsboro
        Me.TglOrder.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TglOrder.Location = New System.Drawing.Point(733, 189)
        Me.TglOrder.Name = "TglOrder"
        Me.TglOrder.ReadOnly = True
        Me.TglOrder.Size = New System.Drawing.Size(240, 30)
        Me.TglOrder.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(554, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 22)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Pesanan"
        '
        'Telp
        '
        Me.Telp.BackColor = System.Drawing.Color.Gainsboro
        Me.Telp.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telp.Location = New System.Drawing.Point(182, 227)
        Me.Telp.Name = "Telp"
        Me.Telp.ReadOnly = True
        Me.Telp.Size = New System.Drawing.Size(313, 30)
        Me.Telp.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 22)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "No. Order"
        '
        'Alamat
        '
        Me.Alamat.BackColor = System.Drawing.Color.Gainsboro
        Me.Alamat.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alamat.Location = New System.Drawing.Point(182, 190)
        Me.Alamat.Name = "Alamat"
        Me.Alamat.ReadOnly = True
        Me.Alamat.Size = New System.Drawing.Size(313, 30)
        Me.Alamat.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(30, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DETAIL TRANSAKSI"
        '
        'Nama
        '
        Me.Nama.BackColor = System.Drawing.Color.Gainsboro
        Me.Nama.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(182, 152)
        Me.Nama.Name = "Nama"
        Me.Nama.ReadOnly = True
        Me.Nama.Size = New System.Drawing.Size(313, 30)
        Me.Nama.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 22)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Nama Lengkap"
        '
        'No_Order
        '
        Me.No_Order.BackColor = System.Drawing.Color.Gainsboro
        Me.No_Order.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_Order.Location = New System.Drawing.Point(182, 115)
        Me.No_Order.Name = "No_Order"
        Me.No_Order.ReadOnly = True
        Me.No_Order.Size = New System.Drawing.Size(313, 30)
        Me.No_Order.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 22)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 22)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Telepon"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(554, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 22)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Status Pembayaran"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(554, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 22)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Status Order"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(554, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 22)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Tanggal Order"
        '
        'panel_home
        '
        Me.panel_home.BackColor = System.Drawing.Color.Silver
        Me.panel_home.Controls.Add(Me.labelDetail)
        Me.panel_home.Controls.Add(Me.Label14)
        Me.panel_home.Controls.Add(Me.cb_pembayaran)
        Me.panel_home.Controls.Add(Me.Label12)
        Me.panel_home.Controls.Add(Me.cb_status)
        Me.panel_home.Controls.Add(Me.tb_pesanan)
        Me.panel_home.Controls.Add(Me.GroupBox2)
        Me.panel_home.Controls.Add(Me.TglOrder)
        Me.panel_home.Controls.Add(Me.Label9)
        Me.panel_home.Controls.Add(Me.Telp)
        Me.panel_home.Controls.Add(Me.Label10)
        Me.panel_home.Controls.Add(Me.Label2)
        Me.panel_home.Controls.Add(Me.Alamat)
        Me.panel_home.Controls.Add(Me.Label1)
        Me.panel_home.Controls.Add(Me.Nama)
        Me.panel_home.Controls.Add(Me.Label3)
        Me.panel_home.Controls.Add(Me.txt_idStaff)
        Me.panel_home.Controls.Add(Me.No_Order)
        Me.panel_home.Controls.Add(Me.Label4)
        Me.panel_home.Controls.Add(Me.Label5)
        Me.panel_home.Controls.Add(Me.Label6)
        Me.panel_home.Controls.Add(Me.Label7)
        Me.panel_home.Controls.Add(Me.Label8)
        Me.panel_home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_home.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_home.Location = New System.Drawing.Point(0, 0)
        Me.panel_home.Name = "panel_home"
        Me.panel_home.Size = New System.Drawing.Size(1000, 686)
        Me.panel_home.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 22)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "ID Staff"
        '
        'txt_idStaff
        '
        Me.txt_idStaff.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_idStaff.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idStaff.Location = New System.Drawing.Point(182, 79)
        Me.txt_idStaff.Name = "txt_idStaff"
        Me.txt_idStaff.ReadOnly = True
        Me.txt_idStaff.Size = New System.Drawing.Size(313, 30)
        Me.txt_idStaff.TabIndex = 51
        '
        'Form_laporan_transaksi_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 686)
        Me.Controls.Add(Me.panel_home)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_laporan_transaksi_detail"
        Me.Text = "Form_laporan_transaksi_detail"
        CType(Me.DataGrid_pesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.panel_home.ResumeLayout(False)
        Me.panel_home.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents labelDetail As Label
    Friend WithEvents DataGrid_pesanan As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents cb_pembayaran As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cb_status As ComboBox
    Friend WithEvents tb_pesanan As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tb_total As TextBox
    Friend WithEvents TglOrder As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Telp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Alamat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Nama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents No_Order As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents panel_home As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_idStaff As TextBox
End Class
