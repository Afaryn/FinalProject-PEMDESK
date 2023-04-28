<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Laporan_Transaksi
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabelTransaksi = New System.Windows.Forms.DataGridView()
        Me.TRANSAKSIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet3 = New apk2.DataSet3()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rb_custom = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker_sampai = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_mulai = New System.Windows.Forms.DateTimePicker()
        Me.rb_semua = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataSet2 = New apk2.DataSet2()
        Me.DataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRANSAKSITableAdapter = New apk2.DataSet3TableAdapters.TRANSAKSITableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tabelTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRANSAKSIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.tabelTransaksi)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 194)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 492)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETAIL TRANSAKSI"
        '
        'tabelTransaksi
        '
        Me.tabelTransaksi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabelTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabelTransaksi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.tabelTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelTransaksi.Location = New System.Drawing.Point(4, 24)
        Me.tabelTransaksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabelTransaksi.Name = "tabelTransaksi"
        Me.tabelTransaksi.RowHeadersWidth = 62
        Me.tabelTransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabelTransaksi.Size = New System.Drawing.Size(992, 463)
        Me.tabelTransaksi.TabIndex = 0
        '
        'TRANSAKSIBindingSource
        '
        Me.TRANSAKSIBindingSource.DataMember = "TRANSAKSI"
        Me.TRANSAKSIBindingSource.DataSource = Me.DataSet3
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.rb_custom)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_sampai)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_mulai)
        Me.GroupBox2.Controls.Add(Me.rb_semua)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 77)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(723, 103)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(425, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 29)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "-"
        '
        'rb_custom
        '
        Me.rb_custom.AutoSize = True
        Me.rb_custom.Location = New System.Drawing.Point(219, 34)
        Me.rb_custom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rb_custom.Name = "rb_custom"
        Me.rb_custom.Size = New System.Drawing.Size(89, 24)
        Me.rb_custom.TabIndex = 14
        Me.rb_custom.TabStop = True
        Me.rb_custom.Text = "Custom"
        Me.rb_custom.UseVisualStyleBackColor = True
        '
        'DateTimePicker_sampai
        '
        Me.DateTimePicker_sampai.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_sampai.Location = New System.Drawing.Point(452, 67)
        Me.DateTimePicker_sampai.Name = "DateTimePicker_sampai"
        Me.DateTimePicker_sampai.Size = New System.Drawing.Size(202, 28)
        Me.DateTimePicker_sampai.TabIndex = 18
        '
        'DateTimePicker_mulai
        '
        Me.DateTimePicker_mulai.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_mulai.Location = New System.Drawing.Point(217, 68)
        Me.DateTimePicker_mulai.Name = "DateTimePicker_mulai"
        Me.DateTimePicker_mulai.Size = New System.Drawing.Size(202, 28)
        Me.DateTimePicker_mulai.TabIndex = 19
        '
        'rb_semua
        '
        Me.rb_semua.AutoSize = True
        Me.rb_semua.Location = New System.Drawing.Point(32, 34)
        Me.rb_semua.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rb_semua.Name = "rb_semua"
        Me.rb_semua.Size = New System.Drawing.Size(85, 24)
        Me.rb_semua.TabIndex = 15
        Me.rb_semua.TabStop = True
        Me.rb_semua.Text = "Semua"
        Me.rb_semua.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "DETAIL TRANSAKSI"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImage = Global.apk2.My.Resources.Resources.caret_right
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(785, 103)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 43)
        Me.Button1.TabIndex = 13
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Location = New System.Drawing.Point(763, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Laporan"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(837, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "/"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(856, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Laporan Transaksi"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(373, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(262, 30)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "LAPORAN TRANSAKSI"
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet2BindingSource
        '
        Me.DataSet2BindingSource.DataSource = Me.DataSet2
        Me.DataSet2BindingSource.Position = 0
        '
        'TRANSAKSITableAdapter
        '
        Me.TRANSAKSITableAdapter.ClearBeforeFill = True
        '
        'Form_Laporan_Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 686)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_Laporan_Transaksi"
        Me.Text = "Form_Transaksi"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.tabelTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRANSAKSIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tabelTransaksi As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_custom As RadioButton
    Friend WithEvents rb_semua As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataSet2BindingSource As BindingSource
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents DataSet3 As DataSet3
    Friend WithEvents TRANSAKSIBindingSource As BindingSource
    Friend WithEvents TRANSAKSITableAdapter As DataSet3TableAdapters.TRANSAKSITableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker_sampai As DateTimePicker
    Friend WithEvents DateTimePicker_mulai As DateTimePicker
End Class
