<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_transaksi
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
        Me.b_cari = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.b_TambahTransaksi = New System.Windows.Forms.Button()
        Me.b_Detail = New System.Windows.Forms.Button()
        Me.tb_Search = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDTRANSAKSIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TGLTRANSAKSIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMACUSTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSTRANSAKSIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRANSAKSIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New apk2.DataSet2()
        Me.panel_home = New System.Windows.Forms.Panel()
        Me.TRANSAKSITableAdapter = New apk2.DataSet2TableAdapters.TRANSAKSITableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRANSAKSIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_home.SuspendLayout()
        Me.SuspendLayout()
        '
        'b_cari
        '
        Me.b_cari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_cari.Location = New System.Drawing.Point(917, 171)
        Me.b_cari.Name = "b_cari"
        Me.b_cari.Size = New System.Drawing.Size(62, 34)
        Me.b_cari.TabIndex = 50
        Me.b_cari.Text = "Cari"
        Me.b_cari.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(888, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Transaksi"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(405, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 34)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "TRANSAKSI"
        '
        'b_TambahTransaksi
        '
        Me.b_TambahTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_TambahTransaksi.Location = New System.Drawing.Point(26, 139)
        Me.b_TambahTransaksi.Name = "b_TambahTransaksi"
        Me.b_TambahTransaksi.Size = New System.Drawing.Size(201, 62)
        Me.b_TambahTransaksi.TabIndex = 39
        Me.b_TambahTransaksi.Text = "Tambah Transaksi"
        Me.b_TambahTransaksi.UseVisualStyleBackColor = True
        '
        'b_Detail
        '
        Me.b_Detail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.b_Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Detail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_Detail.Location = New System.Drawing.Point(777, 89)
        Me.b_Detail.Name = "b_Detail"
        Me.b_Detail.Size = New System.Drawing.Size(201, 62)
        Me.b_Detail.TabIndex = 49
        Me.b_Detail.Text = "Detail Transaksi"
        Me.b_Detail.UseVisualStyleBackColor = False
        '
        'tb_Search
        '
        Me.tb_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_Search.Location = New System.Drawing.Point(701, 171)
        Me.tb_Search.Multiline = True
        Me.tb_Search.Name = "tb_Search"
        Me.tb_Search.Size = New System.Drawing.Size(200, 34)
        Me.tb_Search.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(620, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 25)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Search"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDTRANSAKSIDataGridViewTextBoxColumn, Me.TGLTRANSAKSIDataGridViewTextBoxColumn, Me.NAMACUSTDataGridViewTextBoxColumn, Me.PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn, Me.STATUSTRANSAKSIDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TRANSAKSIBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 229)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(952, 398)
        Me.DataGridView1.TabIndex = 51
        '
        'IDTRANSAKSIDataGridViewTextBoxColumn
        '
        Me.IDTRANSAKSIDataGridViewTextBoxColumn.DataPropertyName = "ID_TRANSAKSI"
        Me.IDTRANSAKSIDataGridViewTextBoxColumn.HeaderText = "ID TRANSAKSI"
        Me.IDTRANSAKSIDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDTRANSAKSIDataGridViewTextBoxColumn.Name = "IDTRANSAKSIDataGridViewTextBoxColumn"
        Me.IDTRANSAKSIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TGLTRANSAKSIDataGridViewTextBoxColumn
        '
        Me.TGLTRANSAKSIDataGridViewTextBoxColumn.DataPropertyName = "TGL_TRANSAKSI"
        Me.TGLTRANSAKSIDataGridViewTextBoxColumn.HeaderText = "TGL TRANSAKSI"
        Me.TGLTRANSAKSIDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TGLTRANSAKSIDataGridViewTextBoxColumn.Name = "TGLTRANSAKSIDataGridViewTextBoxColumn"
        Me.TGLTRANSAKSIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NAMACUSTDataGridViewTextBoxColumn
        '
        Me.NAMACUSTDataGridViewTextBoxColumn.DataPropertyName = "NAMA_CUST"
        Me.NAMACUSTDataGridViewTextBoxColumn.HeaderText = "NAMA CUST"
        Me.NAMACUSTDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NAMACUSTDataGridViewTextBoxColumn.Name = "NAMACUSTDataGridViewTextBoxColumn"
        Me.NAMACUSTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn
        '
        Me.PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn.DataPropertyName = "PEMBAYARAN_TRANSAKSI"
        Me.PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn.HeaderText = "PEMBAYARAN TRANSAKSI"
        Me.PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn.Name = "PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn"
        Me.PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STATUSTRANSAKSIDataGridViewTextBoxColumn
        '
        Me.STATUSTRANSAKSIDataGridViewTextBoxColumn.DataPropertyName = "STATUS_TRANSAKSI"
        Me.STATUSTRANSAKSIDataGridViewTextBoxColumn.HeaderText = "STATUS TRANSAKSI"
        Me.STATUSTRANSAKSIDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.STATUSTRANSAKSIDataGridViewTextBoxColumn.Name = "STATUSTRANSAKSIDataGridViewTextBoxColumn"
        Me.STATUSTRANSAKSIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TRANSAKSIBindingSource
        '
        Me.TRANSAKSIBindingSource.DataMember = "TRANSAKSI"
        Me.TRANSAKSIBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'panel_home
        '
        Me.panel_home.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.panel_home.Controls.Add(Me.DataGridView1)
        Me.panel_home.Controls.Add(Me.b_cari)
        Me.panel_home.Controls.Add(Me.b_Detail)
        Me.panel_home.Controls.Add(Me.Label3)
        Me.panel_home.Controls.Add(Me.Label2)
        Me.panel_home.Controls.Add(Me.b_TambahTransaksi)
        Me.panel_home.Controls.Add(Me.tb_Search)
        Me.panel_home.Controls.Add(Me.Label7)
        Me.panel_home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_home.Location = New System.Drawing.Point(0, 0)
        Me.panel_home.Name = "panel_home"
        Me.panel_home.Size = New System.Drawing.Size(1000, 686)
        Me.panel_home.TabIndex = 58
        '
        'TRANSAKSITableAdapter
        '
        Me.TRANSAKSITableAdapter.ClearBeforeFill = True
        '
        'Form_transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 686)
        Me.Controls.Add(Me.panel_home)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRANSAKSIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_home.ResumeLayout(False)
        Me.panel_home.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents b_cari As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents b_TambahTransaksi As Button
    Friend WithEvents b_Detail As Button
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents panel_home As Panel
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents TRANSAKSIBindingSource As BindingSource
    Friend WithEvents TRANSAKSITableAdapter As DataSet2TableAdapters.TRANSAKSITableAdapter
    Friend WithEvents IDTRANSAKSIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TGLTRANSAKSIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMACUSTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSTRANSAKSIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
