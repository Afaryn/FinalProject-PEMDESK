<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_stokBahan
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_hapusBahan = New System.Windows.Forms.Button()
        Me.btn_tBahan = New System.Windows.Forms.Button()
        Me.pnl_data = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_idBahan = New System.Windows.Forms.TextBox()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.label_judul = New System.Windows.Forms.Label()
        Me.no = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_updateIsi = New System.Windows.Forms.TextBox()
        Me.txt_namaBahan = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView_bahan = New System.Windows.Forms.DataGridView()
        Me.BAHANCUCIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_BahanCuci = New apk2.DataSet_BahanCuci()
        Me.BAHAN_CUCITableAdapter = New apk2.DataSet_BahanCuciTableAdapters.BAHAN_CUCITableAdapter()
        Me.IDBAHANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMABAHANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOKBAHANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnl_data.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView_bahan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHANCUCIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_BahanCuci, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 62)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(390, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 30)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "STOK BAHAN BAKU"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_hapusBahan)
        Me.Panel3.Controls.Add(Me.btn_tBahan)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 564)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(656, 122)
        Me.Panel3.TabIndex = 2
        '
        'btn_hapusBahan
        '
        Me.btn_hapusBahan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_hapusBahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hapusBahan.Location = New System.Drawing.Point(452, 32)
        Me.btn_hapusBahan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_hapusBahan.Name = "btn_hapusBahan"
        Me.btn_hapusBahan.Size = New System.Drawing.Size(196, 55)
        Me.btn_hapusBahan.TabIndex = 3
        Me.btn_hapusBahan.Text = "Hapus Bahan"
        Me.btn_hapusBahan.UseVisualStyleBackColor = True
        '
        'btn_tBahan
        '
        Me.btn_tBahan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_tBahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tBahan.Location = New System.Drawing.Point(14, 32)
        Me.btn_tBahan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_tBahan.Name = "btn_tBahan"
        Me.btn_tBahan.Size = New System.Drawing.Size(196, 55)
        Me.btn_tBahan.TabIndex = 4
        Me.btn_tBahan.Text = "Tambah Bahan"
        Me.btn_tBahan.UseVisualStyleBackColor = True
        '
        'pnl_data
        '
        Me.pnl_data.Controls.Add(Me.Label2)
        Me.pnl_data.Controls.Add(Me.txt_idBahan)
        Me.pnl_data.Controls.Add(Me.btn_batal)
        Me.pnl_data.Controls.Add(Me.btn_simpan)
        Me.pnl_data.Controls.Add(Me.label_judul)
        Me.pnl_data.Controls.Add(Me.no)
        Me.pnl_data.Controls.Add(Me.Label1)
        Me.pnl_data.Controls.Add(Me.txt_updateIsi)
        Me.pnl_data.Controls.Add(Me.txt_namaBahan)
        Me.pnl_data.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_data.Location = New System.Drawing.Point(656, 62)
        Me.pnl_data.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnl_data.Name = "pnl_data"
        Me.pnl_data.Size = New System.Drawing.Size(344, 624)
        Me.pnl_data.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "ID Bahan"
        '
        'txt_idBahan
        '
        Me.txt_idBahan.Location = New System.Drawing.Point(129, 77)
        Me.txt_idBahan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_idBahan.Name = "txt_idBahan"
        Me.txt_idBahan.ReadOnly = True
        Me.txt_idBahan.Size = New System.Drawing.Size(121, 26)
        Me.txt_idBahan.TabIndex = 26
        '
        'btn_batal
        '
        Me.btn_batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_batal.Location = New System.Drawing.Point(33, 538)
        Me.btn_batal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(120, 46)
        Me.btn_batal.TabIndex = 24
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.Location = New System.Drawing.Point(33, 469)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(178, 46)
        Me.btn_simpan.TabIndex = 25
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'label_judul
        '
        Me.label_judul.AutoSize = True
        Me.label_judul.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_judul.Location = New System.Drawing.Point(33, 32)
        Me.label_judul.Name = "label_judul"
        Me.label_judul.Size = New System.Drawing.Size(240, 27)
        Me.label_judul.TabIndex = 22
        Me.label_judul.Text = "UPDATE STOK BAHAN"
        '
        'no
        '
        Me.no.AutoSize = True
        Me.no.Location = New System.Drawing.Point(34, 220)
        Me.no.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(72, 20)
        Me.no.TabIndex = 20
        Me.no.Text = "Berat Isi "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nama Bahan"
        '
        'txt_updateIsi
        '
        Me.txt_updateIsi.Location = New System.Drawing.Point(33, 249)
        Me.txt_updateIsi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_updateIsi.Name = "txt_updateIsi"
        Me.txt_updateIsi.Size = New System.Drawing.Size(214, 26)
        Me.txt_updateIsi.TabIndex = 19
        '
        'txt_namaBahan
        '
        Me.txt_namaBahan.Location = New System.Drawing.Point(33, 162)
        Me.txt_namaBahan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_namaBahan.Name = "txt_namaBahan"
        Me.txt_namaBahan.Size = New System.Drawing.Size(214, 26)
        Me.txt_namaBahan.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView_bahan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 502)
        Me.Panel2.TabIndex = 3
        '
        'DataGridView_bahan
        '
        Me.DataGridView_bahan.AutoGenerateColumns = False
        Me.DataGridView_bahan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_bahan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView_bahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_bahan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDBAHANDataGridViewTextBoxColumn, Me.NAMABAHANDataGridViewTextBoxColumn, Me.STOKBAHANDataGridViewTextBoxColumn})
        Me.DataGridView_bahan.DataSource = Me.BAHANCUCIBindingSource
        Me.DataGridView_bahan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_bahan.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_bahan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView_bahan.Name = "DataGridView_bahan"
        Me.DataGridView_bahan.RowHeadersWidth = 62
        Me.DataGridView_bahan.Size = New System.Drawing.Size(656, 502)
        Me.DataGridView_bahan.TabIndex = 0
        '
        'BAHANCUCIBindingSource
        '
        Me.BAHANCUCIBindingSource.DataMember = "BAHAN_CUCI"
        Me.BAHANCUCIBindingSource.DataSource = Me.DataSet_BahanCuci
        '
        'DataSet_BahanCuci
        '
        Me.DataSet_BahanCuci.DataSetName = "DataSet_BahanCuci"
        Me.DataSet_BahanCuci.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BAHAN_CUCITableAdapter
        '
        Me.BAHAN_CUCITableAdapter.ClearBeforeFill = True
        '
        'IDBAHANDataGridViewTextBoxColumn
        '
        Me.IDBAHANDataGridViewTextBoxColumn.DataPropertyName = "ID_BAHAN"
        Me.IDBAHANDataGridViewTextBoxColumn.HeaderText = "ID BAHAN"
        Me.IDBAHANDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDBAHANDataGridViewTextBoxColumn.Name = "IDBAHANDataGridViewTextBoxColumn"
        '
        'NAMABAHANDataGridViewTextBoxColumn
        '
        Me.NAMABAHANDataGridViewTextBoxColumn.DataPropertyName = "NAMA_BAHAN"
        Me.NAMABAHANDataGridViewTextBoxColumn.HeaderText = "NAMA BAHAN"
        Me.NAMABAHANDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NAMABAHANDataGridViewTextBoxColumn.Name = "NAMABAHANDataGridViewTextBoxColumn"
        '
        'STOKBAHANDataGridViewTextBoxColumn
        '
        Me.STOKBAHANDataGridViewTextBoxColumn.DataPropertyName = "STOK_BAHAN"
        Me.STOKBAHANDataGridViewTextBoxColumn.HeaderText = "STOK BAHAN"
        Me.STOKBAHANDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.STOKBAHANDataGridViewTextBoxColumn.Name = "STOKBAHANDataGridViewTextBoxColumn"
        '
        'Form_stokBahan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 686)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnl_data)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_stokBahan"
        Me.Text = "Form_stokBahan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.pnl_data.ResumeLayout(False)
        Me.pnl_data.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView_bahan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHANCUCIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_BahanCuci, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_hapusBahan As Button
    Friend WithEvents pnl_data As Panel
    Friend WithEvents btn_tBahan As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView_bahan As DataGridView
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents label_judul As Label
    Friend WithEvents no As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_idBahan As TextBox
    Friend WithEvents txt_updateIsi As TextBox
    Friend WithEvents txt_namaBahan As TextBox
    Friend WithEvents DataSet_BahanCuci As DataSet_BahanCuci
    Friend WithEvents BAHANCUCIBindingSource As BindingSource
    Friend WithEvents BAHAN_CUCITableAdapter As DataSet_BahanCuciTableAdapters.BAHAN_CUCITableAdapter
    Friend WithEvents IDBAHANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMABAHANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STOKBAHANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
