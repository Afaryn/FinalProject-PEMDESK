<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_home
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDTRANSAKSIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TGLTRANSAKSIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMACUSTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSTRANSAKSIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRANSAKSIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New apk2.DataSet2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TRANSAKSITableAdapter = New apk2.DataSet2TableAdapters.TRANSAKSITableAdapter()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRANSAKSIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.PictureBox4)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(488, 85)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(188, 101)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TOTAL ORDER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(105, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 31)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "-"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.apk2.My.Resources.Resources.shopping_cart_check
        Me.PictureBox4.Location = New System.Drawing.Point(19, 38)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(45, 46)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(292, 85)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(188, 101)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "NEW ORDER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(108, 45)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "-"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.apk2.My.Resources.Resources.shopping_cart__2_
        Me.PictureBox3.Location = New System.Drawing.Point(22, 38)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 46)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDTRANSAKSIDataGridViewTextBoxColumn, Me.TGLTRANSAKSIDataGridViewTextBoxColumn, Me.NAMACUSTDataGridViewTextBoxColumn, Me.PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn, Me.STATUSTRANSAKSIDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TRANSAKSIBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(50, 204)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(876, 447)
        Me.DataGridView1.TabIndex = 20
        '
        'IDTRANSAKSIDataGridViewTextBoxColumn
        '
        Me.IDTRANSAKSIDataGridViewTextBoxColumn.DataPropertyName = "ID_TRANSAKSI"
        Me.IDTRANSAKSIDataGridViewTextBoxColumn.HeaderText = "ID TRANSAKSI"
        Me.IDTRANSAKSIDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDTRANSAKSIDataGridViewTextBoxColumn.Name = "IDTRANSAKSIDataGridViewTextBoxColumn"
        '
        'TGLTRANSAKSIDataGridViewTextBoxColumn
        '
        Me.TGLTRANSAKSIDataGridViewTextBoxColumn.DataPropertyName = "TGL_TRANSAKSI"
        Me.TGLTRANSAKSIDataGridViewTextBoxColumn.HeaderText = "TGL TRANSAKSI"
        Me.TGLTRANSAKSIDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TGLTRANSAKSIDataGridViewTextBoxColumn.Name = "TGLTRANSAKSIDataGridViewTextBoxColumn"
        '
        'NAMACUSTDataGridViewTextBoxColumn
        '
        Me.NAMACUSTDataGridViewTextBoxColumn.DataPropertyName = "NAMA_CUST"
        Me.NAMACUSTDataGridViewTextBoxColumn.HeaderText = "NAMA CUST"
        Me.NAMACUSTDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NAMACUSTDataGridViewTextBoxColumn.Name = "NAMACUSTDataGridViewTextBoxColumn"
        '
        'PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn
        '
        Me.PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn.DataPropertyName = "PEMBAYARAN_TRANSAKSI"
        Me.PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn.HeaderText = "PEMBAYARAN TRANSAKSI"
        Me.PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn.Name = "PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn"
        '
        'STATUSTRANSAKSIDataGridViewTextBoxColumn
        '
        Me.STATUSTRANSAKSIDataGridViewTextBoxColumn.DataPropertyName = "STATUS_TRANSAKSI"
        Me.STATUSTRANSAKSIDataGridViewTextBoxColumn.HeaderText = "STATUS TRANSAKSI"
        Me.STATUSTRANSAKSIDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.STATUSTRANSAKSIDataGridViewTextBoxColumn.Name = "STATUSTRANSAKSIDataGridViewTextBoxColumn"
        '
        'TRANSAKSIBindingSource
        '
        Me.TRANSAKSIBindingSource.DataMember = "TRANSAKSI"
        Me.TRANSAKSIBindingSource.DataSource = Me.DataSet2BindingSource
        '
        'DataSet2BindingSource
        '
        Me.DataSet2BindingSource.DataSource = Me.DataSet2
        Me.DataSet2BindingSource.Position = 0
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(390, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 34)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "DASHBOARD"
        '
        'TRANSAKSITableAdapter
        '
        Me.TRANSAKSITableAdapter.ClearBeforeFill = True
        '
        'Form_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 686)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRANSAKSIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents DataSet2BindingSource As BindingSource
    Friend WithEvents TRANSAKSIBindingSource As BindingSource
    Friend WithEvents TRANSAKSITableAdapter As DataSet2TableAdapters.TRANSAKSITableAdapter
    Friend WithEvents IDTRANSAKSIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TGLTRANSAKSIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMACUSTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PEMBAYARANTRANSAKSIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSTRANSAKSIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
