<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_owner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_owner))
        Me.Panel_bar = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label_namaLogin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.statusDB = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel_home = New System.Windows.Forms.Panel()
        Me.btn_dashboard = New System.Windows.Forms.Button()
        Me.btn_profil = New System.Windows.Forms.Button()
        Me.btn_rekap = New System.Windows.Forms.Button()
        Me.btn_status = New System.Windows.Forms.Button()
        Me.btn_transaksi = New System.Windows.Forms.Button()
        Me.btn_paket = New System.Windows.Forms.Button()
        Me.btn_max = New System.Windows.Forms.Button()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Panel_bar.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_bar
        '
        Me.Panel_bar.BackColor = System.Drawing.Color.Silver
        Me.Panel_bar.Controls.Add(Me.btn_max)
        Me.Panel_bar.Controls.Add(Me.btn_min)
        Me.Panel_bar.Controls.Add(Me.btn_close)
        Me.Panel_bar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_bar.Location = New System.Drawing.Point(0, 0)
        Me.Panel_bar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel_bar.Name = "Panel_bar"
        Me.Panel_bar.Size = New System.Drawing.Size(1300, 54)
        Me.Panel_bar.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.Label_namaLogin)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btn_dashboard)
        Me.Panel2.Controls.Add(Me.btn_profil)
        Me.Panel2.Controls.Add(Me.btn_rekap)
        Me.Panel2.Controls.Add(Me.btn_status)
        Me.Panel2.Controls.Add(Me.btn_transaksi)
        Me.Panel2.Controls.Add(Me.btn_paket)
        Me.Panel2.Controls.Add(Me.statusDB)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 686)
        Me.Panel2.TabIndex = 1
        '
        'Label_namaLogin
        '
        Me.Label_namaLogin.AutoSize = True
        Me.Label_namaLogin.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_namaLogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_namaLogin.Location = New System.Drawing.Point(136, 55)
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
        Me.Label2.Location = New System.Drawing.Point(34, 18)
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
        Me.Label3.Location = New System.Drawing.Point(12, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "__________________________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(45, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Owner"
        '
        'Panel_home
        '
        Me.Panel_home.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_home.Location = New System.Drawing.Point(300, 54)
        Me.Panel_home.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel_home.Name = "Panel_home"
        Me.Panel_home.Size = New System.Drawing.Size(1000, 686)
        Me.Panel_home.TabIndex = 2
        '
        'btn_dashboard
        '
        Me.btn_dashboard.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_dashboard.BackColor = System.Drawing.Color.DarkGray
        Me.btn_dashboard.FlatAppearance.BorderSize = 0
        Me.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dashboard.Image = Global.apk2.My.Resources.Resources.garage
        Me.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dashboard.Location = New System.Drawing.Point(0, 131)
        Me.btn_dashboard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Size = New System.Drawing.Size(300, 75)
        Me.btn_dashboard.TabIndex = 2
        Me.btn_dashboard.Text = "DASHBOARD"
        Me.btn_dashboard.UseVisualStyleBackColor = False
        '
        'btn_profil
        '
        Me.btn_profil.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_profil.BackColor = System.Drawing.Color.DarkGray
        Me.btn_profil.FlatAppearance.BorderSize = 0
        Me.btn_profil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_profil.Image = Global.apk2.My.Resources.Resources.user1
        Me.btn_profil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_profil.Location = New System.Drawing.Point(0, 559)
        Me.btn_profil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_profil.Name = "btn_profil"
        Me.btn_profil.Size = New System.Drawing.Size(300, 75)
        Me.btn_profil.TabIndex = 1
        Me.btn_profil.Text = "PROFIL"
        Me.btn_profil.UseVisualStyleBackColor = False
        '
        'btn_rekap
        '
        Me.btn_rekap.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_rekap.BackColor = System.Drawing.Color.DarkGray
        Me.btn_rekap.FlatAppearance.BorderSize = 0
        Me.btn_rekap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rekap.Image = Global.apk2.My.Resources.Resources.document
        Me.btn_rekap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_rekap.Location = New System.Drawing.Point(0, 474)
        Me.btn_rekap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_rekap.Name = "btn_rekap"
        Me.btn_rekap.Size = New System.Drawing.Size(300, 75)
        Me.btn_rekap.TabIndex = 1
        Me.btn_rekap.Text = "LAPORAN"
        Me.btn_rekap.UseVisualStyleBackColor = False
        '
        'btn_status
        '
        Me.btn_status.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_status.BackColor = System.Drawing.Color.DarkGray
        Me.btn_status.FlatAppearance.BorderSize = 0
        Me.btn_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_status.Image = Global.apk2.My.Resources.Resources.edit__1_
        Me.btn_status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_status.Location = New System.Drawing.Point(0, 388)
        Me.btn_status.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_status.Name = "btn_status"
        Me.btn_status.Size = New System.Drawing.Size(300, 75)
        Me.btn_status.TabIndex = 1
        Me.btn_status.Text = "STOK BAHAN BAKU"
        Me.btn_status.UseVisualStyleBackColor = False
        '
        'btn_transaksi
        '
        Me.btn_transaksi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_transaksi.BackColor = System.Drawing.Color.DarkGray
        Me.btn_transaksi.FlatAppearance.BorderSize = 0
        Me.btn_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_transaksi.Image = Global.apk2.My.Resources.Resources.users_alt
        Me.btn_transaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_transaksi.Location = New System.Drawing.Point(0, 302)
        Me.btn_transaksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_transaksi.Name = "btn_transaksi"
        Me.btn_transaksi.Size = New System.Drawing.Size(300, 75)
        Me.btn_transaksi.TabIndex = 1
        Me.btn_transaksi.Text = "MANAJEMEN USER"
        Me.btn_transaksi.UseVisualStyleBackColor = False
        '
        'btn_paket
        '
        Me.btn_paket.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_paket.BackColor = System.Drawing.Color.DarkGray
        Me.btn_paket.FlatAppearance.BorderSize = 0
        Me.btn_paket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_paket.Image = Global.apk2.My.Resources.Resources.apps
        Me.btn_paket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_paket.Location = New System.Drawing.Point(0, 217)
        Me.btn_paket.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_paket.Name = "btn_paket"
        Me.btn_paket.Size = New System.Drawing.Size(300, 75)
        Me.btn_paket.TabIndex = 1
        Me.btn_paket.Text = "        PAKET LAYANAN LAUNDRY"
        Me.btn_paket.UseVisualStyleBackColor = False
        '
        'btn_max
        '
        Me.btn_max.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_max.FlatAppearance.BorderSize = 0
        Me.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_max.Image = CType(resources.GetObject("btn_max.Image"), System.Drawing.Image)
        Me.btn_max.Location = New System.Drawing.Point(1174, 8)
        Me.btn_max.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_max.Name = "btn_max"
        Me.btn_max.Size = New System.Drawing.Size(52, 38)
        Me.btn_max.TabIndex = 2
        Me.btn_max.UseVisualStyleBackColor = True
        '
        'btn_min
        '
        Me.btn_min.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_min.FlatAppearance.BorderSize = 0
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Image = CType(resources.GetObject("btn_min.Image"), System.Drawing.Image)
        Me.btn_min.Location = New System.Drawing.Point(1119, 8)
        Me.btn_min.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(46, 38)
        Me.btn_min.TabIndex = 1
        Me.btn_min.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.Location = New System.Drawing.Point(1236, 8)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(46, 38)
        Me.btn_close.TabIndex = 0
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Form_owner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 740)
        Me.Controls.Add(Me.Panel_home)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_bar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_owner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel_bar.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_bar As Panel
    Friend WithEvents btn_min As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel_home As Panel
    Friend WithEvents btn_max As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents statusDB As Label
    Friend WithEvents btn_rekap As Button
    Friend WithEvents btn_status As Button
    Friend WithEvents btn_transaksi As Button
    Friend WithEvents btn_paket As Button
    Friend WithEvents btn_dashboard As Button
    Friend WithEvents Label_namaLogin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_profil As Button
End Class
