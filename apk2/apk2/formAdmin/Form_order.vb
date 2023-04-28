Imports System.Data.OracleClient

Public Class Form_order
    Dim temp As String

    Sub isilv()
        Dim lst As New ListViewItem
        lst.Text = cb_Paket.Text
        lst.SubItems.Add(tb_Juml.Text)
        lv_paket.Items.Add(lst)
    End Sub

    Sub dtclear()
        tb_Alamat.Clear()
        tb_Juml.Clear()
        tb_NamaCust.Clear()
        tb_NoOrder.Clear()
        tb_Telp.Clear()
        cb_Paket.Text = ""
        cb_Pesanan.Text = ""
        cb_Status.Text = ""
        lv_paket.Clear()
    End Sub

    Sub id()
        temp = ""
        Dim query As String = "select case when max(to_number(substr(ID_TRANSAKSI,3,6))) is null then 1 else max(to_number(substr(ID_TRANSAKSI,3,6)))+1 end as NO from transaksi"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
        DR = CMD.ExecuteReader()
        DR.Read()
        tb_NoOrder.Text = DR.Item(0)
        For i As Integer = 1 To 3 - tb_NoOrder.Text.Length
            temp = temp & "0"
        Next
        tb_NoOrder.Text = "OR" & temp & tb_NoOrder.Text
        DR.Close()
    End Sub

    Private Sub Form_order_Load(sender As Object, e As EventArgs) Handles Me.Load
        id()
        'menambahkan data nama paket laundry dari data base ke combo box
        DA = New OracleDataAdapter("select nama_paket from paket_laundry", CONN)
        DS = New DataSet()
        DS.Clear()
        DA.Fill(DS, "select nama_paket from paket_laundry")

        For i = 0 To DS.Tables(0).Rows.Count - 1
            cb_Paket.Items.Add(DS.Tables(0).Rows(i).Item("nama_paket"))
        Next

    End Sub

    Private Sub b_Add_Click(sender As Object, e As EventArgs) Handles b_Add.Click
        'menambahkan data transaksi terlebih dahulu
        Dim query As String = "insert into transaksi values ('" & tb_NoOrder.Text & "','" & id_login & "',TO_DATE('" & dt_Tgl.Text & "','DD Month YYYY'),TO_DATE('" & dt_Tgl.Text & "','DD Month YYYY')+3,'Baru','" & cb_Status.Text & "','" & tb_NamaCust.Text & "','" & tb_Telp.Text & "','" & tb_Alamat.Text & "','" & cb_Pesanan.Text & "')"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
        'lalu memasukan detail dari transaksi 
        For i As Integer = 0 To (lv_paket.Items.Count - 1)
            Dim query1 As String = "insert into detail_transaksi 
                                    values('" & tb_NoOrder.Text & "',(select id_paket from paket_laundry where nama_paket='" & lv_paket.Items(i).Text & "'), " & CInt(lv_paket.Items(i).SubItems(1).Text) & ",
                                    (select harga_paket*" & CInt(lv_paket.Items(i).SubItems(1).Text) & " from paket_laundry where nama_paket='" & lv_paket.Items(i).Text & "'))"
            CMD = New OracleCommand(query1, CONN)
            CMD.ExecuteNonQuery()
            ' PENGURANGAN BAHAN CUCI PER PAKET LAYANAN LAUNDRY DIKALI JUMLAH NYA 

            DA = New OracleDataAdapter("select id_bahan, takaran from detail_paket where id_paket=(select id_paket from paket_laundry where nama_paket='" & lv_paket.Items(i).Text & "')", CONN)
            DS.Clear()
            DA.Fill(DS, "XXX")

            For a As Integer = 0 To (DS.Tables("XXX").Rows.Count - 1)
                Dim id_bahan = DS.Tables("XXX").Rows(a).Item(0).ToString
                Dim takaran = CInt(DS.Tables("XXX").Rows(a).Item(1))
                Dim total As Integer = takaran * CInt(lv_paket.Items(i).SubItems(1).Text) 'total adalah hasil jumlah dari takaran bahan dikali quantity dari paket
                Dim query2 As String = "update bahan_cuci set stok_bahan = (select stok_bahan-" & total & " from bahan_cuci where id_bahan='" & id_bahan & "') where id_bahan='" & id_bahan & "'"
                CMD = New OracleCommand(query2, CONN)
                CMD.ExecuteNonQuery()
            Next
        Next

        Form_Admin.ConFormEnPanel(New Form_transaksi)
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Form_Admin.ConFormEnPanel(New Form_transaksi)
    End Sub

    Private Sub b_hapus_Click(sender As Object, e As EventArgs) Handles b_hapus.Click
        lv_paket.Items.Remove(lv_paket.SelectedItems(0))
    End Sub

    Private Sub b_Cancel_Click(sender As Object, e As EventArgs) Handles b_Cancel.Click
        dtclear()
        Form_Admin.ConFormEnPanel(New Form_transaksi)
    End Sub

    Private Sub b_tambah_Click(sender As Object, e As EventArgs) Handles b_tambah.Click
        isilv()
        cb_Paket.Text = ""
        tb_Juml.Clear()
    End Sub


End Class