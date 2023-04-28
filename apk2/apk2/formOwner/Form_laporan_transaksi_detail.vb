Imports System.Data.OracleClient

Public Class Form_laporan_transaksi_detail
    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Form_owner.ConFormEnPanel(New Form_Laporan_Transaksi)
    End Sub


    Private Sub Form_laporan_transaksi_detail_Load(sender As Object, e As EventArgs) Handles Me.Load
        CMD = New OracleCommand("select * from TRANSAKSI where ID_TRANSAKSI='" & tampung & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        Try
            If DR.HasRows Then
                txt_idStaff.Text = DR.Item("ID_STAFF")
                No_Order.Text = DR.Item("ID_TRANSAKSI")
                Nama.Text = DR.Item("NAMA_CUST")
                Alamat.Text = DR.Item("ALAMAT_CUST")
                Telp.Text = DR.Item("HP_CUST")
                cb_pembayaran.Text = DR.Item("PEMBAYARAN_TRANSAKSI")
                TglOrder.Text = DR.Item("TGL_TRANSAKSI")
                tb_pesanan.Text = DR.Item("OPSI_KIRIM")
                cb_status.Text = DR.Item("STATUS_TRANSAKSI")
            End If
        Catch ex As Exception
            MessageBox.Show("input data Gagal " & ex.Message)
        End Try
        DA = New OracleDataAdapter("select nama_paket,harga_paket,jumlah,total from detail_transaksi join paket_laundry using (id_paket) where id_transaksi='" & tampung & "'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "select nama_paket,harga_paket,jumlah,total from detail_transaksi join paket_laundry using (id_paket) where id_transaksi='" & tampung & "'")
        DataGrid_pesanan.DataSource = (DS.Tables("select nama_paket,harga_paket,jumlah,total from detail_transaksi join paket_laundry using (id_paket) where id_transaksi='" & tampung & "'"))
        DataGrid_pesanan.ReadOnly = True
        DataGrid_pesanan.AutoSizeColumnsMode = DataGrid_pesanan.AutoSizeColumnsMode.Fill
        CMD = New OracleCommand("select SUM(total) AS Total from detail_transaksi where ID_TRANSAKSI='" & tampung & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            tb_total.Text = "Rp." + DR.Item("total").ToString
        End If
    End Sub
End Class