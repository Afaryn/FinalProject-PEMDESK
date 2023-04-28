Public Class Form_Laporan

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form_owner.ConFormEnPanel(New Form_Laporan_logAkun)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_owner.ConFormEnPanel(New Form_Laporan_Transaksi)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_owner.ConFormEnPanel(New Form_Laporan_pendapatan)
    End Sub
End Class