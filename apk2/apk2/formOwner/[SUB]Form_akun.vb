Imports System.Data.OracleClient


Public Class Form_akun
    Dim Jk_staff As String
    Dim buka As Boolean
    Dim temp As String

    Sub cldata()
        txt_nama.Clear()
        txt_no.Clear()
        txt_pass.Clear()
        txt_user.Clear()
        Combo_jk.SelectedIndex = 0
    End Sub

    Sub id()
        temp = ""
        Dim query As String = "select case when max(to_number(substr(id_staff,4,6))) is null then 1 else max(to_number(substr(id_staff,4,6)))+1 end as NO from staff"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
        DR = CMD.ExecuteReader()
        DR.Read()
        txt_id.Text = DR.Item(0)
        For i As Integer = 1 To 3 - txt_id.TextLength
            temp = temp & "0"
        Next
        txt_id.Text = "KR" & temp & txt_id.Text
        DR.Close()
    End Sub

    Sub simpan()
        If Combo_jk.Text = "Laki - Laki" Then
            Jk_staff = "Laki"
        ElseIf Combo_jk.Text = "Perempuan" Then
            Jk_staff = "Perempuan"
        End If
        Dim query As String = "insert into staff values('" & txt_id.Text & "', '" & txt_nama.Text & "', 'Karyawan', '" & txt_no.Text & "', '" & txt_user.Text & "', '" & txt_pass.Text & "', '" & Jk_staff & "')"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
    End Sub

    Sub ubah()
        If Combo_jk.Text = "Laki - Laki" Then
            Jk_staff = "Laki"
        ElseIf Combo_jk.Text = "Perempuan" Then
            Jk_staff = "Perempuan"
        End If
        Dim query As String = "update staff set nama_staff ='" & txt_nama.Text & "'
                            , hp_staff ='" & txt_no.Text & "'
                            , username_akun_staff ='" & txt_user.Text & "'
                             , password_akun_staff ='" & txt_pass.Text & "'
                            , jk_staff ='" & Jk_staff & "'
                            where id_staff ='" & txt_id.Text & "'"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
    End Sub

    Sub hapus()
        Dim query As String = "delete from staff where id_staff='" & txt_id.Text & "'"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
    End Sub

    Private Sub Form_akun_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet11.STAFF' table. You can move, or remove it, as needed.
        Me.STAFFTableAdapter.Fill(Me.DataSet11.STAFF)
        Tampil_tabel("staff", DataGrid_akun)
        buka = True

    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        cldata()
        id()
        LABEL_AKUN.Text = "TAMBAH AKUN KARYAWAN"
        btn_hapus.Visible = False
        btn_simpan.Text = "Tambah"

    End Sub


    Private Sub DataGrid_akun_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_akun.CellContentDoubleClick
        txt_id.Text = DataGrid_akun.Rows(e.RowIndex).Cells(0).Value
        txt_nama.Text = DataGrid_akun.Rows(e.RowIndex).Cells(1).Value
        txt_no.Text = DataGrid_akun.Rows(e.RowIndex).Cells(3).Value
        txt_user.Text = DataGrid_akun.Rows(e.RowIndex).Cells(4).Value
        txt_pass.Text = DataGrid_akun.Rows(e.RowIndex).Cells(5).Value
        If DataGrid_akun.Rows(e.RowIndex).Cells(6).Value = "Laki" Then
            Combo_jk.Text = "Laki - Laki"
        ElseIf DataGrid_akun.Rows(e.RowIndex).Cells(6).Value = "Perempuan" Then
            Combo_jk.Text = "Perempuan"
        End If
        LABEL_AKUN.Text = "UBAH AKUN KARYAWAN"
        btn_hapus.Visible = True
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If btn_simpan.Text = "Tambah" Then
            If txt_nama.Text = "" Or txt_no.Text = "" Or txt_pass.Text = "" Or txt_user.Text = "" Then
                MsgBox("Masih Terdapat Data Kosong!")
            Else
                simpan()
                cldata()
                id()
                Tampil_tabel("staff", DataGrid_akun)
            End If
        ElseIf btn_simpan.Text = "Simpan" Then
            ubah()
            cldata()
            Tampil_tabel("staff", DataGrid_akun)
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        hapus()
        cldata()
        Tampil_tabel("staff", DataGrid_akun)
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        cldata()
    End Sub


End Class