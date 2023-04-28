Imports System.Data.OracleClient
Imports System.Drawing.Printing

Public Class Form_stokBahan

    Dim temp As String
    Dim id_baru As String
    'method untuk membuat id otomatis
    Sub id()
        temp = ""
        Dim query As String = "select case when max(to_number(substr(id_bahan,3,6))) 
        is null then 1 else max(to_number(substr(id_bahan,3,6)))+1 end as NO from bahan_cuci"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
        DR = CMD.ExecuteReader()
        DR.Read()
        id_baru = DR.Item(0)
        For i As Integer = 1 To 3 - id_baru.Length
            temp = temp & "0"
        Next
        id_baru = "B" & temp & id_baru
        DR.Close()
    End Sub

    'method untuk menambah data baru
    Sub simpan(ByVal id As String, ByVal a As String, ByVal b As Integer)
        Dim query As String = "insert into bahan_cuci values('" & id & "','" & a & "', " & b & ")"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
    End Sub

    'method untuk update data
    Sub ubah(ByVal id As String, ByVal b As Integer)
        Dim query As String = "update bahan_cuci set stok_bahan=(select stok_bahan + " & b & " from bahan_cuci where id_bahan='" & id & "') where id_bahan='" & id & "'"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
    End Sub

    'method untuk hapus data
    'menghapus data ditabel relasi terlebih dahulu, baru ditabel induknya 
    Sub hapus(ByVal a As String)
        Dim query As String = "delete from detail_paket where id_bahan ='" & a & "'"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
        Dim query2 As String = "delete from bahan_cuci where id_bahan='" & a & "'"
        CMD = New OracleCommand(query2, CONN)
        CMD.ExecuteNonQuery()
    End Sub

    Sub cldata()
        txt_idBahan.Clear()
        txt_namaBahan.Text = ""
        txt_updateIsi.Clear()
    End Sub

    Private Sub btn_tBahan_Click(sender As Object, e As EventArgs) Handles btn_tBahan.Click
        label_judul.Text = "TAMBAH BAHAN"
        txt_namaBahan.Visible = True
        btn_simpan.Text = "Tambah"
        id()
        txt_idBahan.Text = id_baru
    End Sub

    Private Sub Form_stokBahan_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet_BahanCuci.BAHAN_CUCI' table. You can move, or remove it, as needed.
        Me.BAHAN_CUCITableAdapter.Fill(Me.DataSet_BahanCuci.BAHAN_CUCI)
        Tampil_tabel("bahan_cuci", DataGridView_bahan)

    End Sub

    Private Sub DataGridView_bahan_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_bahan.CellContentDoubleClick
        txt_idBahan.Text = DataGridView_bahan.Rows(e.RowIndex).Cells(0).Value
        txt_namaBahan.Text = DataGridView_bahan.Rows(e.RowIndex).Cells(1).Value
        label_judul.Text = "UPDATE STOK BAHAN"
        btn_simpan.Text = "Simpan"
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_namaBahan.Text = "" Or txt_updateIsi.Text = "" Then
            MsgBox("Terdapat data kosong!")
        Else
            If btn_simpan.Text = "Simpan" Then
                ubah(txt_idBahan.Text, CInt(txt_updateIsi.Text))
            ElseIf btn_simpan.Text = "Tambah" Then
                simpan(id_baru, txt_namaBahan.Text, CInt(txt_updateIsi.Text))
            End If
            Tampil_tabel("bahan_cuci", DataGridView_bahan)
        End If
        cldata()
    End Sub

    Private Sub btn_hapusBahan_Click(sender As Object, e As EventArgs) Handles btn_hapusBahan.Click
        hapus(txt_idBahan.Text)
        Tampil_tabel("bahan_cuci", DataGridView_bahan)
        cldata()
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        cldata()
    End Sub

End Class