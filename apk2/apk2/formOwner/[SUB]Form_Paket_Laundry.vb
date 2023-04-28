Imports System.Data.OracleClient

Public Class Form_Paket_Laundry
    Dim bahan As String
    Dim temp As String
    Dim id_baru As String
    Dim id_panggil As String


    Private Sub cldata()
        txt_harga.Clear()
        txt_nama.Clear()
        txt_takaran.Clear()
        Combo_bahan.Text = ""
        DataGrid_detail.DataSource = False
    End Sub



    Sub get_data(ByVal id As String, ByVal grid As DataGridView)
        DA = New OracleDataAdapter("select nama_bahan,takaran
                     from bahan_cuci join detail_paket using(id_bahan) join paket_laundry 
                     using (id_paket) where id_paket='" & id & "'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "select nama_bahan,takaran
                     from bahan_cuci join detail_paket using(id_bahan) join paket_laundry 
                     using (id_paket) where id_paket='" & id & "'")
        grid.DataSource = (DS.Tables("select nama_bahan,takaran
                     from bahan_cuci join detail_paket using(id_bahan) join paket_laundry 
                     using (id_paket) where id_paket='" & id & "'"))
        grid.ReadOnly = True
        grid.AutoSizeColumnsMode = grid.AutoSizeColumnsMode.Fill

    End Sub

    Sub cariBahan(ByVal a As String)
        CMD = New OracleCommand("select id_bahan from bahan_cuci where nama_bahan='" & a & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            bahan = DR.Item("id_bahan")
        Else
            MsgBox("bahan TIDAK DITEMUKAN")
        End If
    End Sub


    Sub simpanBahan(ByVal a As String, ByVal b As String)
        cariBahan(a)
        Dim query As String = "insert into detail_paket values('" & bahan & "', '" & b & "', " & CInt(txt_takaran.Text) & ")"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
    End Sub

    Sub ubahBahan(ByVal a As String, ByVal b As String)
        cariBahan(a)
        Dim query As String = "update detail_paket set takaran= '" & CInt(txt_takaran.Text) & "'
                            where id_bahan ='" & bahan & "' and id_paket='" & b & "'"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
    End Sub

    Sub hapusBahan(ByVal a As String, ByVal b As String)
        cariBahan(a)
        Dim query As String = "delete from detail_paket where id_bahan='" & bahan & "' and id_paket='" & b & "'"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
    End Sub

    'METHOD UNTUK CRUD PAKET'
    Sub simpanPaket(ByVal id As String, ByVal a As String, ByVal b As Integer)
        Dim query As String = "insert into paket_laundry values('" & id & "','" & a & "', " & b & ")"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
    End Sub

    Sub ubahPaket(ByVal id As String, ByVal a As String, ByVal b As Integer)
        Dim query As String = "update paket_laundry set nama_paket='" & a & "', harga_paket=" & b & " where id_paket='" & id & "'"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
    End Sub

    Sub hapusPaket(ByVal a As String)
        Dim query As String = "delete from detail_paket where id_paket='" & a & "'"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
        Dim query2 As String = "delete from paket_laundry where id_paket='" & a & "'"
        CMD = New OracleCommand(query2, CONN)
        CMD.ExecuteNonQuery()
    End Sub

    Sub id()
        temp = ""
        Dim query As String = "select case when max(to_number(substr(id_paket,3,6))) is null then 1 else max(to_number(substr(id_paket,3,6)))+1 end as NO from paket_laundry"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
        DR = CMD.ExecuteReader()
        DR.Read()
        id_baru = DR.Item(0)
        For i As Integer = 1 To 3 - id_baru.Length
            temp = temp & "0"
        Next
        id_baru = "P" & temp & id_baru
        DR.Close()
    End Sub

    '==================================================================================================================================

    Private Sub Form_Paket_Laundry_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet_paketLaundry.PAKET_LAUNDRY' table. You can move, or remove it, as needed.
        Me.PAKET_LAUNDRYTableAdapter.Fill(Me.DataSet_paketLaundry.PAKET_LAUNDRY)
        Tampil_tabel("paket_laundry", DataGrid_paket)
        DA = New OracleDataAdapter("select nama_bahan from bahan_cuci", CONN)
        DS = New DataSet()
        DS.Clear()
        DA.Fill(DS, "select nama_bahan from bahan_cuci")

        For i = 0 To DS.Tables(0).Rows.Count - 1
            Combo_bahan.Items.Add(DS.Tables(0).Rows(i).Item("nama_bahan"))
        Next
    End Sub

    Private Sub DataGrid_paket_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_paket.CellContentDoubleClick
        id_panggil = DataGrid_paket.Rows(e.RowIndex).Cells(0).Value
        get_data(id_panggil, DataGrid_detail)
        txt_nama.Text = DataGrid_paket.Rows(e.RowIndex).Cells(1).Value
        txt_harga.Text = DataGrid_paket.Rows(e.RowIndex).Cells(2).Value
        btn_tambah.Text = "Simpan"
    End Sub

    Private Sub DataGrid_detail_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        Combo_bahan.Text = DataGrid_detail.Rows(e.RowIndex).Cells(0).Value
        txt_takaran.Text = DataGrid_detail.Rows(e.RowIndex).Cells(1).Value
        btn_tambahBahan.Text = "Simpan"
    End Sub

    Private Sub btn_tambahBahan_Click(sender As Object, e As EventArgs) Handles btn_tambahBahan.Click
        If Combo_bahan.Text = "" Or txt_takaran.Text = "" Then
            MsgBox("Terdapat data kosong!")
        Else
            If btn_tambahBahan.Text = "Tambah" Then
                simpanBahan(Combo_bahan.Text, id_panggil)
                get_data(id_panggil, DataGrid_detail)
            ElseIf btn_tambahBahan.Text = "Simpan" Then
                ubahBahan(Combo_bahan.Text, id_panggil)
                get_data(id_panggil, DataGrid_detail)
                btn_tambahBahan.Text = "Tambah"
            End If
        End If
        Combo_bahan.Text = ""
        txt_takaran.Text = ""
    End Sub

    Private Sub btn_hpsBahan_Click(sender As Object, e As EventArgs) Handles btn_hpsBahan.Click
        hapusBahan(Combo_bahan.Text, id_panggil)
        get_data(id_panggil, DataGrid_detail)
        Combo_bahan.Text = ""
        txt_takaran.Text = ""
        btn_tambahBahan.Text = "Tambah"
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        If txt_nama.Text = "" Or txt_harga.Text = "" Then
            MsgBox("Terdapat data Kosong!")
        Else
            If btn_tambah.Text = "Tambah" Then
                id()
                simpanPaket(id_baru, txt_nama.Text, CInt(txt_harga.Text))
                Tampil_tabel("paket_laundry", DataGrid_paket)
            ElseIf btn_tambah.Text = "Simpan" Then
                ubahPaket(id_panggil, txt_nama.Text, CInt(txt_harga.Text))
                Tampil_tabel("paket_laundry", DataGrid_paket)
                btn_tambah.Text = "Tambah"
            End If
        End If
        cldata()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        hapusPaket(id_panggil)
        Tampil_tabel("paket_laundry", DataGrid_paket)
        cldata()
        btn_tambah.Text = "Tambah"
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        cldata()
        btn_tambah.Text = "Tambah"
        btn_tambahBahan.Text = "Tambah"
    End Sub


    'Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
    '    If 
    '    id()
    '    simpanPaket(id_baru, txt_nama.Text, CInt(txt_harga.Text))
    '    Tampil_tabel("paket_laundry", DataGrid_paket)
    'End Sub
End Class