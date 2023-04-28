Imports System.Data.OracleClient

Public Class Form_login

    Private Sub Form_login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Koneksi()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        CMD = New OracleCommand("select * from staff where USERNAME_AKUN_STAFF='" & txt_username.Text & "'and PASSWORD_AKUN_STAFF='" & txt_pass.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            id_login = DR.Item("ID_STAFF")
            akun_login = DR.Item("NAMA_STAFF")
            login = DateTime.Now.ToString()
            If DR.Item("POSISI_STAFF") = "Owner" Then
                Form_owner.Show()
                Me.Hide()
            ElseIf DR.Item("POSISI_STAFF") = "Karyawan" Then
                Form_Admin.Show()
                Me.Hide()
            End If
        Else
            MsgBox("AKUN TIDAK DITEMUKAN")
        End If
        txt_username.Text = ""
        txt_pass.Text = ""
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub chkbox_pass_CheckedChanged(sender As Object, e As EventArgs) Handles chkbox_pass.CheckedChanged
        If chkbox_pass.Checked = True Then
            txt_pass.UseSystemPasswordChar = True
        ElseIf chkbox_pass.Checked = False Then
            txt_pass.UseSystemPasswordChar = False
        End If
    End Sub
End Class