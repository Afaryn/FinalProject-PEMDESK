
Imports System.Data.OracleClient

Public Class Form_Laporan_Transaksi
    Sub TampilData()
        If rb_semua.Checked = True Then
            DA = New OracleDataAdapter("select id_transaksi, tgl_transaksi, nama_cust, status_transaksi, pembayaran_transaksi from transaksi order by id_transaksi", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "XXX")
            tabelTransaksi.DataSource = (DS.Tables("XXX"))
            tabelTransaksi.ReadOnly = True
            tabelTransaksi.AutoSizeColumnsMode = tabelTransaksi.AutoSizeColumnsMode.Fill
            rb_custom.Checked = False
        ElseIf rb_custom.Checked = True Then
            DA = New OracleDataAdapter("select id_transaksi, tgl_transaksi, nama_cust, status_transaksi, pembayaran_transaksi from transaksi where tgl_transaksi between TO_TIMESTAMP('" & DateTimePicker_mulai.Text & "','DD Month YYYY') and TO_TIMESTAMP('" & DateTimePicker_sampai.Text & "','DD Month YYYY')", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "XX")
            tabelTransaksi.DataSource = (DS.Tables("XX"))
            tabelTransaksi.ReadOnly = True
            tabelTransaksi.AutoSizeColumnsMode = tabelTransaksi.AutoSizeColumnsMode.Fill
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form_owner.ConFormEnPanel(Form_Laporan)
    End Sub

    Private Sub Form_Laporan_Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3.TRANSAKSI' table. You can move, or remove it, as needed.
        'Me.TRANSAKSITableAdapter.Fill(Me.DataSet3.TRANSAKSI)
        rb_semua.Checked = True
        TampilData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TampilData()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelTransaksi.CellContentDoubleClick
        tampung = tabelTransaksi.Rows(e.RowIndex).Cells(0).Value
        Form_owner.ConFormEnPanel(New Form_laporan_transaksi_detail)
    End Sub
End Class