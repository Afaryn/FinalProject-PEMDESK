<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_order
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.b_Add = New System.Windows.Forms.Button()
        Me.b_hapus = New System.Windows.Forms.Button()
        Me.b_tambah = New System.Windows.Forms.Button()
        Me.lv_paket = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cb_Pesanan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_Tgl = New System.Windows.Forms.DateTimePicker()
        Me.cb_Status = New System.Windows.Forms.ComboBox()
        Me.tb_Juml = New System.Windows.Forms.TextBox()
        Me.tb_Alamat = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.b_Cancel = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tb_Telp = New System.Windows.Forms.TextBox()
        Me.tb_NamaCust = New System.Windows.Forms.TextBox()
        Me.cb_Paket = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_NoOrder = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(859, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 20)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Form Order"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(751, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 20)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Transaksi"
        '
        'b_Add
        '
        Me.b_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_Add.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.b_Add.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.b_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Add.Location = New System.Drawing.Point(680, 616)
        Me.b_Add.Name = "b_Add"
        Me.b_Add.Size = New System.Drawing.Size(129, 45)
        Me.b_Add.TabIndex = 6
        Me.b_Add.Text = "Add Chart"
        Me.b_Add.UseVisualStyleBackColor = False
        '
        'b_hapus
        '
        Me.b_hapus.BackColor = System.Drawing.Color.Sienna
        Me.b_hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_hapus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.b_hapus.Location = New System.Drawing.Point(746, 232)
        Me.b_hapus.Name = "b_hapus"
        Me.b_hapus.Size = New System.Drawing.Size(146, 45)
        Me.b_hapus.TabIndex = 31
        Me.b_hapus.Text = "Hapus Paket"
        Me.b_hapus.UseVisualStyleBackColor = False
        '
        'b_tambah
        '
        Me.b_tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tambah.Location = New System.Drawing.Point(502, 232)
        Me.b_tambah.Name = "b_tambah"
        Me.b_tambah.Size = New System.Drawing.Size(136, 45)
        Me.b_tambah.TabIndex = 30
        Me.b_tambah.Text = "Tambah Paket"
        Me.b_tambah.UseVisualStyleBackColor = True
        '
        'lv_paket
        '
        Me.lv_paket.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lv_paket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_paket.FullRowSelect = True
        Me.lv_paket.GridLines = True
        Me.lv_paket.HideSelection = False
        Me.lv_paket.Location = New System.Drawing.Point(502, 292)
        Me.lv_paket.Name = "lv_paket"
        Me.lv_paket.Size = New System.Drawing.Size(390, 179)
        Me.lv_paket.TabIndex = 28
        Me.lv_paket.UseCompatibleStateImageBehavior = False
        Me.lv_paket.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Paket"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 190
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jumlah"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 61
        '
        'cb_Pesanan
        '
        Me.cb_Pesanan.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cb_Pesanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Pesanan.FormattingEnabled = True
        Me.cb_Pesanan.Items.AddRange(New Object() {"Antar", "Ambil"})
        Me.cb_Pesanan.Location = New System.Drawing.Point(16, 389)
        Me.cb_Pesanan.Name = "cb_Pesanan"
        Me.cb_Pesanan.Size = New System.Drawing.Size(397, 30)
        Me.cb_Pesanan.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 22)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Opsi Pengiriman"
        '
        'dt_Tgl
        '
        Me.dt_Tgl.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.dt_Tgl.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_Tgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_Tgl.Location = New System.Drawing.Point(496, 38)
        Me.dt_Tgl.Name = "dt_Tgl"
        Me.dt_Tgl.Size = New System.Drawing.Size(392, 30)
        Me.dt_Tgl.TabIndex = 24
        '
        'cb_Status
        '
        Me.cb_Status.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cb_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Status.FormattingEnabled = True
        Me.cb_Status.Items.AddRange(New Object() {"Belum Lunas", "Lunas"})
        Me.cb_Status.Location = New System.Drawing.Point(16, 463)
        Me.cb_Status.Name = "cb_Status"
        Me.cb_Status.Size = New System.Drawing.Size(397, 30)
        Me.cb_Status.TabIndex = 23
        '
        'tb_Juml
        '
        Me.tb_Juml.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tb_Juml.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_Juml.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Juml.Location = New System.Drawing.Point(500, 177)
        Me.tb_Juml.Multiline = True
        Me.tb_Juml.Name = "tb_Juml"
        Me.tb_Juml.Size = New System.Drawing.Size(392, 34)
        Me.tb_Juml.TabIndex = 22
        '
        'tb_Alamat
        '
        Me.tb_Alamat.BackColor = System.Drawing.SystemColors.Control
        Me.tb_Alamat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_Alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Alamat.Location = New System.Drawing.Point(16, 249)
        Me.tb_Alamat.Multiline = True
        Me.tb_Alamat.Name = "tb_Alamat"
        Me.tb_Alamat.Size = New System.Drawing.Size(398, 105)
        Me.tb_Alamat.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.b_Cancel)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.b_Add)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1000, 686)
        Me.Panel3.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(390, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(197, 34)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "FORM ORDER"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(839, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 20)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "/"
        '
        'b_Cancel
        '
        Me.b_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_Cancel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.b_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.b_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Cancel.Location = New System.Drawing.Point(836, 616)
        Me.b_Cancel.Name = "b_Cancel"
        Me.b_Cancel.Size = New System.Drawing.Size(129, 45)
        Me.b_Cancel.TabIndex = 25
        Me.b_Cancel.Text = "Cancel"
        Me.b_Cancel.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel4.Controls.Add(Me.b_hapus)
        Me.Panel4.Controls.Add(Me.b_tambah)
        Me.Panel4.Controls.Add(Me.lv_paket)
        Me.Panel4.Controls.Add(Me.cb_Pesanan)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.dt_Tgl)
        Me.Panel4.Controls.Add(Me.cb_Status)
        Me.Panel4.Controls.Add(Me.tb_Juml)
        Me.Panel4.Controls.Add(Me.tb_Alamat)
        Me.Panel4.Controls.Add(Me.tb_Telp)
        Me.Panel4.Controls.Add(Me.tb_NamaCust)
        Me.Panel4.Controls.Add(Me.cb_Paket)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.tb_NoOrder)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(37, 75)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(928, 525)
        Me.Panel4.TabIndex = 0
        '
        'tb_Telp
        '
        Me.tb_Telp.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tb_Telp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_Telp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Telp.Location = New System.Drawing.Point(16, 182)
        Me.tb_Telp.Multiline = True
        Me.tb_Telp.Name = "tb_Telp"
        Me.tb_Telp.Size = New System.Drawing.Size(398, 34)
        Me.tb_Telp.TabIndex = 20
        '
        'tb_NamaCust
        '
        Me.tb_NamaCust.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tb_NamaCust.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_NamaCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_NamaCust.Location = New System.Drawing.Point(16, 108)
        Me.tb_NamaCust.Multiline = True
        Me.tb_NamaCust.Name = "tb_NamaCust"
        Me.tb_NamaCust.Size = New System.Drawing.Size(398, 34)
        Me.tb_NamaCust.TabIndex = 19
        '
        'cb_Paket
        '
        Me.cb_Paket.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cb_Paket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Paket.FormattingEnabled = True
        Me.cb_Paket.Location = New System.Drawing.Point(500, 106)
        Me.cb_Paket.Name = "cb_Paket"
        Me.cb_Paket.Size = New System.Drawing.Size(390, 30)
        Me.cb_Paket.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 439)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 22)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Status Pembayaran"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(489, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 22)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Tanggal Order"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(496, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 22)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(496, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 22)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Paket Laundry"
        '
        'tb_NoOrder
        '
        Me.tb_NoOrder.BackColor = System.Drawing.Color.Gainsboro
        Me.tb_NoOrder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_NoOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_NoOrder.Location = New System.Drawing.Point(16, 42)
        Me.tb_NoOrder.Multiline = True
        Me.tb_NoOrder.Name = "tb_NoOrder"
        Me.tb_NoOrder.ReadOnly = True
        Me.tb_NoOrder.Size = New System.Drawing.Size(249, 34)
        Me.tb_NoOrder.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Transaksi"
        '
        'Form_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 686)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_order"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents b_Add As Button
    Friend WithEvents b_hapus As Button
    Friend WithEvents b_tambah As Button
    Friend WithEvents lv_paket As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents cb_Pesanan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dt_Tgl As DateTimePicker
    Friend WithEvents cb_Status As ComboBox
    Friend WithEvents tb_Juml As TextBox
    Friend WithEvents tb_Alamat As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents b_Cancel As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tb_Telp As TextBox
    Friend WithEvents tb_NamaCust As TextBox
    Friend WithEvents cb_Paket As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_NoOrder As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
