Imports System.Drawing.Printing 'untuk form dokumen print invoice
Imports System.Data.OracleClient

Public Class Form_detailTransaksi
    Dim WithEvents PD As New PrintDocument 'variabel-variabel untuk print
    Dim PPD As New PrintPreviewDialog

    Private Sub Form_detailTransaksi_Load(sender As Object, e As EventArgs) Handles Me.Load
        CMD = New OracleCommand("select * from TRANSAKSI where ID_TRANSAKSI='" & tampung & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        Try
            If DR.HasRows Then
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

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Form_Admin.ConFormEnPanel(New Form_transaksi)
    End Sub

    Private Sub b_ProsesOrder_Click(sender As Object, e As EventArgs) Handles b_ProsesOrder.Click
        Dim query As String = "update transaksi set PEMBAYARAN_TRANSAKSI='" & cb_pembayaran.Text & "',STATUS_TRANSAKSI='" & cb_status.Text & "'"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
        Form_Admin.ConFormEnPanel(New Form_transaksi)
    End Sub

    Private Sub b_CetakInvoice_Click(sender As Object, e As EventArgs) Handles b_CetakInvoice.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    'Custom paper size
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 800, 700)
        PD.DefaultPageSettings = pagesetup
    End Sub

    'Setting dan isi dokumen invoice
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        'untuk font
        Dim f24 As New Font("Poppins", 24, FontStyle.Bold)
        Dim f11 As New Font("Poppins", 11, FontStyle.Bold)
        Dim f11a As New Font("Poppins", 11, FontStyle.Regular)
        'untuk margin
        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width - 15
        'untuk variabel
        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center
        Dim garis As String
        garis = "=============================================================================================="

        'Header informasi SUCIO
        e.Graphics.DrawString("INVOICE", f24, Brushes.Black, rightmargin, 20, kanan)

        e.Graphics.DrawString("SUCIO SHOES & APPAREL CARE", f11, Brushes.Black, 20, 30)
        e.Graphics.DrawString("Jl. Sunan Ampel Barat II Pasuruan", f11a, Brushes.Black, 20, 80)
        e.Graphics.DrawString("(+62) 81249292928", f11a, Brushes.Black, 20, 100)
        e.Graphics.DrawString("suciocompany@gmail.com", f11a, Brushes.Black, 20, 120)

        e.Graphics.DrawString(garis, f11a, Brushes.Black, 0, 160) 'pembatas garis

        'untuk informasi data customer
        e.Graphics.DrawString("Customer", f11, Brushes.Black, 20, 200)
        'e.Graphics.DrawString("(nama cust)", f11a, Brushes.Black, 110, 200)
        'e.Graphics.DrawString("(nama cust)", f11a, Brushes.Black, 110, 220)
        'e.Graphics.DrawString("(nama cust)", f11a, Brushes.Black, 110, 240)

        'untuk informasi transaksi customer
        e.Graphics.DrawString("ID Transaksi", f11, Brushes.Black, 650, 200, kanan)
        e.Graphics.DrawString("Tgl Transaksi", f11, Brushes.Black, 650, 220, kanan)
        e.Graphics.DrawString("Tgl Ambil", f11, Brushes.Black, 650, 240, kanan)
        e.Graphics.DrawString("Pesanan", f11, Brushes.Black, 650, 260, kanan)


        'Informasi data customer dari id transaksi yang ditampung setelah diklik di form sebelumnya
        CMD = New OracleCommand("select * from TRANSAKSI where ID_TRANSAKSI= '" & tampung & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        Try
            If DR.HasRows Then
                e.Graphics.DrawString(DR.Item("NAMA_CUST"), f11a, Brushes.Black, 110, 200) 'penataan data
                e.Graphics.DrawString(DR.Item("ALAMAT_CUST"), f11a, Brushes.Black, 110, 220)
                e.Graphics.DrawString(DR.Item("HP_CUST"), f11a, Brushes.Black, 110, 240)

                e.Graphics.DrawString(DR.Item("ID_TRANSAKSI"), f11a, Brushes.Black, 660, 200)
                e.Graphics.DrawString(DR.Item("TGL_TRANSAKSI"), f11a, Brushes.Black, 660, 220)
                e.Graphics.DrawString(DR.Item("TGL_SELESAI"), f11a, Brushes.Black, 660, 240)
                e.Graphics.DrawString(DR.Item("OPSI_KIRIM"), f11a, Brushes.Black, 660, 260)

            Else
                MsgBox("GAGAL MEMUAT DATA!", MsgBoxStyle.Exclamation, "Warning")
            End If
        Catch ex As Exception

        End Try

        'Salam terimakasih
        e.Graphics.DrawString("Terima Kasih telah mempercayakan sepatumu di SUCIO, TEMANSUCI!", f11, Brushes.Black, 150, 620)

        DataGrid_pesanan.AllowUserToAddRows = False 'menghilangkan row sisa
        Dim i As Long
        Dim tinggi As Integer
        For baris As Integer = 0 To DataGrid_pesanan.RowCount - 1
            tinggi += 25
            'label judul invoice
            e.Graphics.DrawString("QTY", f11, Brushes.Black, 40, 350)
            e.Graphics.DrawString("NAMA LAYANAN", f11, Brushes.Black, 150, 350)
            e.Graphics.DrawString("HARGA", f11, Brushes.Black, 650, 350)

            'menampilkan data totalan dari datagridtotal per cells
            e.Graphics.DrawString(DataGrid_pesanan.Rows(baris).Cells(2).Value.ToString, f11a, Brushes.Black, 50, 375 + tinggi)
            e.Graphics.DrawString(DataGrid_pesanan.Rows(baris).Cells(0).Value.ToString, f11a, Brushes.Black, 150, 375 + tinggi)
            e.Graphics.DrawString(DataGrid_pesanan.Rows(baris).Cells(1).Value.ToString, f11a, Brushes.Black, 660, 375 + tinggi)

        Next
        e.Graphics.DrawString("TOTAL", f11, Brushes.Black, 580, 480 + tinggi)
        e.Graphics.DrawString(tb_total.Text, f11, Brushes.Black, 660, 480 + tinggi)
    End Sub


End Class