Public Class Form_transaksi
    Private Sub b_TambahTransaksi_Click(sender As Object, e As EventArgs) Handles b_TambahTransaksi.Click
        Form_Admin.ConFormEnPanel(New Form_order)
    End Sub

    Private Sub b_Detail_Click(sender As Object, e As EventArgs) Handles b_Detail.Click
        Form_Admin.ConFormEnPanel(New Form_detailTransaksi)
    End Sub


    Private Sub Form_transaksi_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet2.TRANSAKSI' table. You can move, or remove it, as needed.
        Me.TRANSAKSITableAdapter.Fill(Me.DataSet2.TRANSAKSI)
        Tampil_tabel("transaksi", DataGridView1)
        b_Detail.Visible = False
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        b_Detail.Visible = True
        tampung = DataGridView1.Rows(e.RowIndex).Cells(0).Value
    End Sub


End Class