<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Admin
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
        Me.Panel_home = New System.Windows.Forms.Panel()
        Me.Label_namaLogin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.statusDB = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel_bar = New System.Windows.Forms.Panel()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_profil = New System.Windows.Forms.Button()
        Me.btn_transaksi = New System.Windows.Forms.Button()
        Me.btn_dashboard = New System.Windows.Forms.Button()
        Me.btn_max = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel_bar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_home
        '
        Me.Panel_home.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_home.Location = New System.Drawing.Point(300, 54)
        Me.Panel_home.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel_home.Name = "Panel_home"
        Me.Panel_home.Size = New System.Drawing.Size(1000, 686)
        Me.Panel_home.TabIndex = 5
        '
        'Label_namaLogin
        '
        Me.Label_namaLogin.AutoSize = True
        Me.Label_namaLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_namaLogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_namaLogin.Location = New System.Drawing.Point(170, 130)
        Me.Label_namaLogin.Name = "Label_namaLogin"
        Me.Label_namaLogin.Size = New System.Drawing.Size(25, 32)
        Me.Label_namaLogin.TabIndex = 5
        Me.Label_namaLogin.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(38, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SELAMAT DATANG"
        '
        'statusDB
        '
        Me.statusDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.statusDB.AutoSize = True
        Me.statusDB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.statusDB.Location = New System.Drawing.Point(116, 652)
        Me.statusDB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.statusDB.Name = "statusDB"
        Me.statusDB.Size = New System.Drawing.Size(14, 20)
        Me.statusDB.TabIndex = 0
        Me.statusDB.Text = "-"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(18, 652)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(15, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "__________________________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(26, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Karyawan"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label_namaLogin)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btn_profil)
        Me.Panel2.Controls.Add(Me.btn_transaksi)
        Me.Panel2.Controls.Add(Me.btn_dashboard)
        Me.Panel2.Controls.Add(Me.statusDB)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 686)
        Me.Panel2.TabIndex = 4
        '
        'Panel_bar
        '
        Me.Panel_bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel_bar.Controls.Add(Me.btn_max)
        Me.Panel_bar.Controls.Add(Me.btn_min)
        Me.Panel_bar.Controls.Add(Me.btn_close)
        Me.Panel_bar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_bar.Location = New System.Drawing.Point(0, 0)
        Me.Panel_bar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel_bar.Name = "Panel_bar"
        Me.Panel_bar.Size = New System.Drawing.Size(1300, 54)
        Me.Panel_bar.TabIndex = 3
        '
        'btn_min
        '
        Me.btn_min.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_min.BackgroundImage = Global.apk2.My.Resources.Resources.Minimize
        Me.btn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_min.FlatAppearance.BorderSize = 0
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Location = New System.Drawing.Point(1119, 8)
        Me.btn_min.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(46, 38)
        Me.btn_min.TabIndex = 1
        Me.btn_min.UseVisualStyleBackColor = True
        '
        'btn_profil
        '
        Me.btn_profil.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_profil.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btn_profil.FlatAppearance.BorderSize = 0
        Me.btn_profil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_profil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_profil.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btn_profil.Image = Global.apk2.My.Resources.Resources.user1
        Me.btn_profil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_profil.Location = New System.Drawing.Point(0, 257)
        Me.btn_profil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_profil.Name = "btn_profil"
        Me.btn_profil.Size = New System.Drawing.Size(300, 75)
        Me.btn_profil.TabIndex = 2
        Me.btn_profil.Text = "PROFILE"
        Me.btn_profil.UseVisualStyleBackColor = False
        '
        'btn_transaksi
        '
        Me.btn_transaksi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_transaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btn_transaksi.FlatAppearance.BorderSize = 0
        Me.btn_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_transaksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_transaksi.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btn_transaksi.Image = Global.apk2.My.Resources.Resources.document
        Me.btn_transaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_transaksi.Location = New System.Drawing.Point(0, 438)
        Me.btn_transaksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_transaksi.Name = "btn_transaksi"
        Me.btn_transaksi.Size = New System.Drawing.Size(300, 75)
        Me.btn_transaksi.TabIndex = 1
        Me.btn_transaksi.Text = "TRANSAKSI"
        Me.btn_transaksi.UseVisualStyleBackColor = False
        '
        'btn_dashboard
        '
        Me.btn_dashboard.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_dashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btn_dashboard.FlatAppearance.BorderSize = 0
        Me.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dashboard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_dashboard.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btn_dashboard.Image = Global.apk2.My.Resources.Resources.apps
        Me.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dashboard.Location = New System.Drawing.Point(0, 348)
        Me.btn_dashboard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Size = New System.Drawing.Size(300, 75)
        Me.btn_dashboard.TabIndex = 1
        Me.btn_dashboard.Text = "DASHBOARD"
        Me.btn_dashboard.UseVisualStyleBackColor = False
        '
        'btn_max
        '
        Me.btn_max.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_max.BackgroundImage = Global.apk2.My.Resources.Resources.open
        Me.btn_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_max.FlatAppearance.BorderSize = 0
        Me.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_max.Location = New System.Drawing.Point(1174, 8)
        Me.btn_max.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_max.Name = "btn_max"
        Me.btn_max.Size = New System.Drawing.Size(52, 38)
        Me.btn_max.TabIndex = 2
        Me.btn_max.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.BackgroundImage = Global.apk2.My.Resources.Resources.Close
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_close.Location = New System.Drawing.Point(1236, 8)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(46, 38)
        Me.btn_close.TabIndex = 0
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Form_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 740)
        Me.Controls.Add(Me.Panel_home)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_bar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Admin"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel_bar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_home As Panel
    Friend WithEvents Label_namaLogin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_profil As Button
    Friend WithEvents btn_transaksi As Button
    Friend WithEvents btn_max As Button
    Friend WithEvents btn_min As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_dashboard As Button
    Friend WithEvents statusDB As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel_bar As Panel
End Class
