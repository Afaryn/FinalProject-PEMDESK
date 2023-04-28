<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Paket_Laundry
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
        Me.DataGrid_paket = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.Combo_bahan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.no = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_takaran = New System.Windows.Forms.TextBox()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGrid_detail = New System.Windows.Forms.DataGridView()
        Me.btn_hpsBahan = New System.Windows.Forms.Button()
        Me.btn_tambahBahan = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataSet_paketLaundry = New apk2.DataSet_paketLaundry()
        Me.PAKETLAUNDRYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAKET_LAUNDRYTableAdapter = New apk2.DataSet_paketLaundryTableAdapters.PAKET_LAUNDRYTableAdapter()
        Me.IDPAKETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMAPAKETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGAPAKETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGrid_paket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSet_paketLaundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAKETLAUNDRYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid_paket
        '
        Me.DataGrid_paket.AutoGenerateColumns = False
        Me.DataGrid_paket.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGrid_paket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_paket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPAKETDataGridViewTextBoxColumn, Me.NAMAPAKETDataGridViewTextBoxColumn, Me.HARGAPAKETDataGridViewTextBoxColumn})
        Me.DataGrid_paket.DataSource = Me.PAKETLAUNDRYBindingSource
        Me.DataGrid_paket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid_paket.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid_paket.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGrid_paket.Name = "DataGrid_paket"
        Me.DataGrid_paket.RowHeadersWidth = 62
        Me.DataGrid_paket.Size = New System.Drawing.Size(524, 564)
        Me.DataGrid_paket.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGrid_paket)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 62)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(524, 564)
        Me.Panel4.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 626)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(524, 60)
        Me.Panel3.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 27)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "DETAIL PAKET LAUDRY"
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(142, 568)
        Me.btn_hapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(128, 42)
        Me.btn_hapus.TabIndex = 5
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(278, 566)
        Me.btn_tambah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(172, 43)
        Me.btn_tambah.TabIndex = 3
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'Combo_bahan
        '
        Me.Combo_bahan.FormattingEnabled = True
        Me.Combo_bahan.Location = New System.Drawing.Point(21, 68)
        Me.Combo_bahan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Combo_bahan.Name = "Combo_bahan"
        Me.Combo_bahan.Size = New System.Drawing.Size(194, 28)
        Me.Combo_bahan.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 38)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nama Bahan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Takaran (ml)"
        '
        'no
        '
        Me.no.AutoSize = True
        Me.no.Location = New System.Drawing.Point(273, 71)
        Me.no.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(98, 20)
        Me.no.TabIndex = 1
        Me.no.Text = "Harga Paket"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Paket"
        '
        'txt_takaran
        '
        Me.txt_takaran.Location = New System.Drawing.Point(243, 69)
        Me.txt_takaran.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_takaran.Name = "txt_takaran"
        Me.txt_takaran.Size = New System.Drawing.Size(102, 26)
        Me.txt_takaran.TabIndex = 0
        '
        'txt_harga
        '
        Me.txt_harga.Location = New System.Drawing.Point(272, 100)
        Me.txt_harga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(162, 26)
        Me.txt_harga.TabIndex = 0
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(15, 100)
        Me.txt_nama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(226, 26)
        Me.txt_nama.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(440, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(299, 30)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "PAKET LAUNDRY SEPATU"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btn_batal)
        Me.Panel2.Controls.Add(Me.btn_hapus)
        Me.Panel2.Controls.Add(Me.btn_tambah)
        Me.Panel2.Controls.Add(Me.no)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_harga)
        Me.Panel2.Controls.Add(Me.txt_nama)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(524, 62)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(476, 624)
        Me.Panel2.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGrid_detail)
        Me.GroupBox1.Controls.Add(Me.btn_hpsBahan)
        Me.GroupBox1.Controls.Add(Me.btn_tambahBahan)
        Me.GroupBox1.Controls.Add(Me.txt_takaran)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Combo_bahan)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 157)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(438, 400)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahan Cuci "
        '
        'DataGrid_detail
        '
        Me.DataGrid_detail.CausesValidation = False
        Me.DataGrid_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_detail.Location = New System.Drawing.Point(8, 175)
        Me.DataGrid_detail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGrid_detail.Name = "DataGrid_detail"
        Me.DataGrid_detail.RowHeadersWidth = 62
        Me.DataGrid_detail.Size = New System.Drawing.Size(421, 215)
        Me.DataGrid_detail.TabIndex = 10
        '
        'btn_hpsBahan
        '
        Me.btn_hpsBahan.Location = New System.Drawing.Point(292, 123)
        Me.btn_hpsBahan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_hpsBahan.Name = "btn_hpsBahan"
        Me.btn_hpsBahan.Size = New System.Drawing.Size(122, 42)
        Me.btn_hpsBahan.TabIndex = 9
        Me.btn_hpsBahan.Text = "Hapus"
        Me.btn_hpsBahan.UseVisualStyleBackColor = True
        '
        'btn_tambahBahan
        '
        Me.btn_tambahBahan.Location = New System.Drawing.Point(18, 118)
        Me.btn_tambahBahan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_tambahBahan.Name = "btn_tambahBahan"
        Me.btn_tambahBahan.Size = New System.Drawing.Size(200, 42)
        Me.btn_tambahBahan.TabIndex = 8
        Me.btn_tambahBahan.Text = "Tambah"
        Me.btn_tambahBahan.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(9, 568)
        Me.btn_batal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(128, 42)
        Me.btn_batal.TabIndex = 5
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 62)
        Me.Panel1.TabIndex = 4
        '
        'DataSet_paketLaundry
        '
        Me.DataSet_paketLaundry.DataSetName = "DataSet_paketLaundry"
        Me.DataSet_paketLaundry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PAKETLAUNDRYBindingSource
        '
        Me.PAKETLAUNDRYBindingSource.DataMember = "PAKET_LAUNDRY"
        Me.PAKETLAUNDRYBindingSource.DataSource = Me.DataSet_paketLaundry
        '
        'PAKET_LAUNDRYTableAdapter
        '
        Me.PAKET_LAUNDRYTableAdapter.ClearBeforeFill = True
        '
        'IDPAKETDataGridViewTextBoxColumn
        '
        Me.IDPAKETDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDPAKETDataGridViewTextBoxColumn.DataPropertyName = "ID_PAKET"
        Me.IDPAKETDataGridViewTextBoxColumn.HeaderText = "ID PAKET"
        Me.IDPAKETDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDPAKETDataGridViewTextBoxColumn.Name = "IDPAKETDataGridViewTextBoxColumn"
        '
        'NAMAPAKETDataGridViewTextBoxColumn
        '
        Me.NAMAPAKETDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NAMAPAKETDataGridViewTextBoxColumn.DataPropertyName = "NAMA_PAKET"
        Me.NAMAPAKETDataGridViewTextBoxColumn.HeaderText = "NAMA PAKET"
        Me.NAMAPAKETDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NAMAPAKETDataGridViewTextBoxColumn.Name = "NAMAPAKETDataGridViewTextBoxColumn"
        '
        'HARGAPAKETDataGridViewTextBoxColumn
        '
        Me.HARGAPAKETDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HARGAPAKETDataGridViewTextBoxColumn.DataPropertyName = "HARGA_PAKET"
        Me.HARGAPAKETDataGridViewTextBoxColumn.HeaderText = "HARGA PAKET"
        Me.HARGAPAKETDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HARGAPAKETDataGridViewTextBoxColumn.Name = "HARGAPAKETDataGridViewTextBoxColumn"
        '
        'Form_Paket_Laundry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 686)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_Paket_Laundry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Paket_Laundry"
        CType(Me.DataGrid_paket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid_detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataSet_paketLaundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAKETLAUNDRYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGrid_paket As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents Combo_bahan As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents no As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_takaran As TextBox
    Friend WithEvents txt_harga As TextBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_hpsBahan As Button
    Friend WithEvents btn_tambahBahan As Button
    Friend WithEvents btn_batal As Button
    Friend WithEvents DataGrid_detail As DataGridView
    Friend WithEvents DataSet_paketLaundry As DataSet_paketLaundry
    Friend WithEvents PAKETLAUNDRYBindingSource As BindingSource
    Friend WithEvents PAKET_LAUNDRYTableAdapter As DataSet_paketLaundryTableAdapters.PAKET_LAUNDRYTableAdapter
    Friend WithEvents IDPAKETDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMAPAKETDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HARGAPAKETDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
