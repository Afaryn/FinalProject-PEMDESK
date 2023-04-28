Imports System.Data.OracleClient

Public Class Form_profil

    Private Sub Form_profil_Load(sender As Object, e As EventArgs) Handles Me.Load
        CMD = New OracleCommand("select * from staff where NAMA_STAFF='" & akun_login & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txt_id.Text = DR.Item("ID_STAFF")
            txt_nama.Text = DR.Item("NAMA_STAFF")
            txt_hp.Text = DR.Item("HP_STAFF")
            txt_posisi.Text = DR.Item("POSISI_STAFF")
            txt_user.Text = DR.Item("USERNAME_AKUN_STAFF")
            txt_pass.Text = DR.Item("PASSWORD_AKUN_STAFF")
            If DR.Item("JK_STAFF") = "Perempuan" Then
                rb_perempuan.Checked = True
            ElseIf DR.Item("JK_STAFF") = "Laki" Then
                rb_laki.Checked = True
            End If
        Else
            MsgBox("DATA GAGAL MEMUAT")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jk_staff As String
        If rb_laki.Checked = True Then
            jk_staff = "Laki"
        ElseIf rb_perempuan.Checked = True Then
            jk_staff = "Perempuan"
        End If
        Dim query As String = "update staff set nama_staff ='" & txt_nama.Text & "'
                            , hp_staff ='" & txt_hp.Text & "'
                            , username_akun_staff ='" & txt_user.Text & "'
                             , password_akun_staff ='" & txt_pass.Text & "'
                            , jk_staff ='" & Jk_staff & "'
                            where id_staff ='" & txt_id.Text & "'"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
    End Sub
End Class