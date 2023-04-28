Imports System.Data.OracleClient

Public Class Form_owner
    Private Sub Form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Label_namaLogin.Text = akun_login
        ConFormEnPanel(New Form_dashboard)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        logout = DateTime.Now.ToString()
        Me.Close()
        Form_login.Show()
        log_akun(id_login, login, logout)
    End Sub

    Private Sub btn_max_Click(sender As Object, e As EventArgs) Handles btn_max.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        Else
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub btn_min_Click(sender As Object, e As EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Sub ConFormEnPanel(ByVal FormCon As Object)

        If Me.Panel_home.Controls.Count > 0 Then Me.Panel_home.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(FormCon, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panel_home.Controls.Add(fh)
        Me.Panel_home.Tag = fh
        fh.Show()

    End Sub

    Private Sub btn_transaksi_Click(sender As Object, e As EventArgs) Handles btn_transaksi.Click
        ConFormEnPanel(New Form_akun)
    End Sub

    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_paket.Click
        ConFormEnPanel(New Form_Paket_Laundry)
    End Sub

    Private Sub btn_status_Click(sender As Object, e As EventArgs) Handles btn_status.Click
        ConFormEnPanel(New Form_stokBahan)
    End Sub

    Private Sub btn_dashboard_Click_1(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        ConFormEnPanel(New Form_dashboard)
    End Sub

    Private Sub btn_rekap_Click(sender As Object, e As EventArgs) Handles btn_rekap.Click
        ConFormEnPanel(New Form_Laporan)
    End Sub

    Private Sub btn_profil_Click(sender As Object, e As EventArgs) Handles btn_profil.Click
        ConFormEnPanel(New Form_profil)
    End Sub
End Class
