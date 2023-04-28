Public Class Form_Admin
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

    Private Sub btn_profil_Click(sender As Object, e As EventArgs) Handles btn_profil.Click
        ConFormEnPanel(New Form_profile)
    End Sub

    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        ConFormEnPanel(New Form_home)
    End Sub

    Private Sub btn_transaksi_Click(sender As Object, e As EventArgs) Handles btn_transaksi.Click
        ConFormEnPanel(New Form_transaksi)
    End Sub

    Private Sub Form_Admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Koneksi()
        Label_namaLogin.Text = akun_login
        ConFormEnPanel(New Form_home)

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
        Form_login.Show()
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

End Class