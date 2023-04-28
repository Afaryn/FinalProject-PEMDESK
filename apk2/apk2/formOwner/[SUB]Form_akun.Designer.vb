<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_akun
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
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel_akun = New System.Windows.Forms.Panel()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Combo_jk = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.no = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_no = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.LABEL_AKUN = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGrid_akun = New System.Windows.Forms.DataGridView()
        Me.STAFFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New apk2.DataSet1()
        Me.DataSet_paketLaundry = New apk2.DataSet_paketLaundry()
        Me.DataSetpaketLaundryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STAFFTableAdapter = New apk2.DataSet1TableAdapters.STAFFTableAdapter()
        Me.DataSet11 = New apk2.DataSet1()
        Me.STAFFBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDSTAFFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMASTAFFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSISISTAFFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HPSTAFFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERNAMEAKUNSTAFFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORDAKUNSTAFFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JKSTAFFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel_akun.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGrid_akun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STAFFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_paketLaundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetpaketLaundryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STAFFBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_tambah)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 128)
        Me.Panel1.TabIndex = 0
        '
        'btn_tambah
        '
        Me.btn_tambah.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_tambah.Location = New System.Drawing.Point(411, 75)
        Me.btn_tambah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(183, 43)
        Me.btn_tambah.TabIndex = 2
        Me.btn_tambah.Text = "Tambah Akun"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(396, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "MANAJEMEN USER"
        '
        'Panel_akun
        '
        Me.Panel_akun.Controls.Add(Me.btn_hapus)
        Me.Panel_akun.Controls.Add(Me.btn_batal)
        Me.Panel_akun.Controls.Add(Me.btn_simpan)
        Me.Panel_akun.Controls.Add(Me.Combo_jk)
        Me.Panel_akun.Controls.Add(Me.Label4)
        Me.Panel_akun.Controls.Add(Me.Label3)
        Me.Panel_akun.Controls.Add(Me.Label2)
        Me.Panel_akun.Controls.Add(Me.txt_pass)
        Me.Panel_akun.Controls.Add(Me.txt_user)
        Me.Panel_akun.Controls.Add(Me.Label7)
        Me.Panel_akun.Controls.Add(Me.txt_id)
        Me.Panel_akun.Controls.Add(Me.no)
        Me.Panel_akun.Controls.Add(Me.Label1)
        Me.Panel_akun.Controls.Add(Me.txt_no)
        Me.Panel_akun.Controls.Add(Me.txt_nama)
        Me.Panel_akun.Controls.Add(Me.LABEL_AKUN)
        Me.Panel_akun.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_akun.Location = New System.Drawing.Point(0, 468)
        Me.Panel_akun.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel_akun.Name = "Panel_akun"
        Me.Panel_akun.Size = New System.Drawing.Size(1000, 218)
        Me.Panel_akun.TabIndex = 2
        '
        'btn_hapus
        '
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_hapus.Location = New System.Drawing.Point(844, 43)
        Me.btn_hapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(141, 43)
        Me.btn_hapus.TabIndex = 55
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_batal.Location = New System.Drawing.Point(844, 157)
        Me.btn_batal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(141, 43)
        Me.btn_batal.TabIndex = 53
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_simpan.Location = New System.Drawing.Point(844, 100)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(141, 43)
        Me.btn_simpan.TabIndex = 52
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Combo_jk
        '
        Me.Combo_jk.FormattingEnabled = True
        Me.Combo_jk.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.Combo_jk.Location = New System.Drawing.Point(572, 157)
        Me.Combo_jk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Combo_jk.Name = "Combo_jk"
        Me.Combo_jk.Size = New System.Drawing.Size(210, 28)
        Me.Combo_jk.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(456, 162)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(456, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(456, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Username"
        '
        'txt_pass
        '
        Me.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pass.Location = New System.Drawing.Point(548, 112)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(234, 26)
        Me.txt_pass.TabIndex = 46
        '
        'txt_user
        '
        Me.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user.Location = New System.Drawing.Point(548, 60)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(234, 26)
        Me.txt_user.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 65)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "ID Karyawan"
        '
        'txt_id
        '
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id.Location = New System.Drawing.Point(144, 65)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(126, 26)
        Me.txt_id.TabIndex = 44
        '
        'no
        '
        Me.no.AutoSize = True
        Me.no.Location = New System.Drawing.Point(14, 162)
        Me.no.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(59, 20)
        Me.no.TabIndex = 42
        Me.no.Text = "No. HP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 112)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Nama Lengkap"
        '
        'txt_no
        '
        Me.txt_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_no.Location = New System.Drawing.Point(142, 157)
        Me.txt_no.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(280, 26)
        Me.txt_no.TabIndex = 40
        '
        'txt_nama
        '
        Me.txt_nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nama.Location = New System.Drawing.Point(142, 112)
        Me.txt_nama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(280, 26)
        Me.txt_nama.TabIndex = 41
        '
        'LABEL_AKUN
        '
        Me.LABEL_AKUN.AutoSize = True
        Me.LABEL_AKUN.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABEL_AKUN.Location = New System.Drawing.Point(4, 5)
        Me.LABEL_AKUN.Name = "LABEL_AKUN"
        Me.LABEL_AKUN.Size = New System.Drawing.Size(245, 25)
        Me.LABEL_AKUN.TabIndex = 39
        Me.LABEL_AKUN.Text = "UBAH AKUN KARYAWAN"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGrid_akun)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 128)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1000, 340)
        Me.Panel4.TabIndex = 3
        '
        'DataGrid_akun
        '
        Me.DataGrid_akun.AutoGenerateColumns = False
        Me.DataGrid_akun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid_akun.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGrid_akun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_akun.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSTAFFDataGridViewTextBoxColumn, Me.NAMASTAFFDataGridViewTextBoxColumn, Me.POSISISTAFFDataGridViewTextBoxColumn, Me.HPSTAFFDataGridViewTextBoxColumn, Me.USERNAMEAKUNSTAFFDataGridViewTextBoxColumn, Me.PASSWORDAKUNSTAFFDataGridViewTextBoxColumn, Me.JKSTAFFDataGridViewTextBoxColumn})
        Me.DataGrid_akun.DataSource = Me.STAFFBindingSource1
        Me.DataGrid_akun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid_akun.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid_akun.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGrid_akun.Name = "DataGrid_akun"
        Me.DataGrid_akun.RowHeadersWidth = 62
        Me.DataGrid_akun.Size = New System.Drawing.Size(1000, 340)
        Me.DataGrid_akun.TabIndex = 0
        '
        'STAFFBindingSource
        '
        Me.STAFFBindingSource.DataMember = "STAFF"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet_paketLaundry
        '
        Me.DataSet_paketLaundry.DataSetName = "DataSet_paketLaundry"
        Me.DataSet_paketLaundry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSetpaketLaundryBindingSource
        '
        Me.DataSetpaketLaundryBindingSource.DataSource = Me.DataSet_paketLaundry
        Me.DataSetpaketLaundryBindingSource.Position = 0
        '
        'STAFFTableAdapter
        '
        Me.STAFFTableAdapter.ClearBeforeFill = True
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STAFFBindingSource1
        '
        Me.STAFFBindingSource1.DataMember = "STAFF"
        Me.STAFFBindingSource1.DataSource = Me.DataSet11
        '
        'IDSTAFFDataGridViewTextBoxColumn
        '
        Me.IDSTAFFDataGridViewTextBoxColumn.DataPropertyName = "ID_STAFF"
        Me.IDSTAFFDataGridViewTextBoxColumn.HeaderText = "ID STAFF"
        Me.IDSTAFFDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDSTAFFDataGridViewTextBoxColumn.Name = "IDSTAFFDataGridViewTextBoxColumn"
        '
        'NAMASTAFFDataGridViewTextBoxColumn
        '
        Me.NAMASTAFFDataGridViewTextBoxColumn.DataPropertyName = "NAMA_STAFF"
        Me.NAMASTAFFDataGridViewTextBoxColumn.HeaderText = "NAMA STAFF"
        Me.NAMASTAFFDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NAMASTAFFDataGridViewTextBoxColumn.Name = "NAMASTAFFDataGridViewTextBoxColumn"
        '
        'POSISISTAFFDataGridViewTextBoxColumn
        '
        Me.POSISISTAFFDataGridViewTextBoxColumn.DataPropertyName = "POSISI_STAFF"
        Me.POSISISTAFFDataGridViewTextBoxColumn.HeaderText = "POSISI STAFF"
        Me.POSISISTAFFDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.POSISISTAFFDataGridViewTextBoxColumn.Name = "POSISISTAFFDataGridViewTextBoxColumn"
        '
        'HPSTAFFDataGridViewTextBoxColumn
        '
        Me.HPSTAFFDataGridViewTextBoxColumn.DataPropertyName = "HP_STAFF"
        Me.HPSTAFFDataGridViewTextBoxColumn.HeaderText = "HP STAFF"
        Me.HPSTAFFDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HPSTAFFDataGridViewTextBoxColumn.Name = "HPSTAFFDataGridViewTextBoxColumn"
        '
        'USERNAMEAKUNSTAFFDataGridViewTextBoxColumn
        '
        Me.USERNAMEAKUNSTAFFDataGridViewTextBoxColumn.DataPropertyName = "USERNAME_AKUN_STAFF"
        Me.USERNAMEAKUNSTAFFDataGridViewTextBoxColumn.HeaderText = "USERNAME AKUN"
        Me.USERNAMEAKUNSTAFFDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.USERNAMEAKUNSTAFFDataGridViewTextBoxColumn.Name = "USERNAMEAKUNSTAFFDataGridViewTextBoxColumn"
        '
        'PASSWORDAKUNSTAFFDataGridViewTextBoxColumn
        '
        Me.PASSWORDAKUNSTAFFDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD_AKUN_STAFF"
        Me.PASSWORDAKUNSTAFFDataGridViewTextBoxColumn.HeaderText = "PASSWORD AKUN"
        Me.PASSWORDAKUNSTAFFDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PASSWORDAKUNSTAFFDataGridViewTextBoxColumn.Name = "PASSWORDAKUNSTAFFDataGridViewTextBoxColumn"
        '
        'JKSTAFFDataGridViewTextBoxColumn
        '
        Me.JKSTAFFDataGridViewTextBoxColumn.DataPropertyName = "JK_STAFF"
        Me.JKSTAFFDataGridViewTextBoxColumn.HeaderText = "JENIS KELAMIN"
        Me.JKSTAFFDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.JKSTAFFDataGridViewTextBoxColumn.Name = "JKSTAFFDataGridViewTextBoxColumn"
        '
        'Form_akun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 686)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel_akun)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_akun"
        Me.Text = "Form_transaksi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_akun.ResumeLayout(False)
        Me.Panel_akun.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGrid_akun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STAFFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_paketLaundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetpaketLaundryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STAFFBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_akun As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGrid_akun As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Combo_jk As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents no As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_no As TextBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents LABEL_AKUN As Label
    Friend WithEvents btn_hapus As Button
    Friend WithEvents DataSet_paketLaundry As DataSet_paketLaundry
    Friend WithEvents DataSetpaketLaundryBindingSource As BindingSource
    Friend WithEvents STAFFBindingSource As BindingSource
    Friend WithEvents DataSet1 As apk2.DataSet1
    Friend WithEvents STAFFTableAdapter As apk2.DataSet1TableAdapters.STAFFTableAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents STAFFBindingSource1 As BindingSource
    Friend WithEvents IDSTAFFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMASTAFFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POSISISTAFFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HPSTAFFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USERNAMEAKUNSTAFFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORDAKUNSTAFFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JKSTAFFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
