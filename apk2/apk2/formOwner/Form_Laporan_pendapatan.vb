Imports System.Data.OracleClient

Public Class Form_Laporan_pendapatan
    Sub TampilData()
        If rb_semua.Checked = True Then
            DA = New OracleDataAdapter("select tgl_transaksi ,id_transaksi AS PEMASUKAN ,SUM(total) AS TOTAL from detail_transaksi join transaksi 
                                        using (id_Transaksi) group by id_transaksi,tgl_transaksi order by id_transaksi ", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "XXX")
            DataGridView1.DataSource = (DS.Tables("XXX"))
            DataGridView1.ReadOnly = True
            DataGridView1.AutoSizeColumnsMode = DataGridView1.AutoSizeColumnsMode.Fill
            Dim query As String = "select sum(total) from detail_transaksi"
            CMD = New OracleCommand(query, CONN)
            CMD.ExecuteNonQuery()
            DR = CMD.ExecuteReader()
            DR.Read()
            TextBox1.Text = "Rp." + DR.Item(0).ToString
            rb_bulanan.Checked = False
        ElseIf rb_bulanan.Checked = True Then
            DA = New OracleDataAdapter("select tgl_transaksi,id_transaksi AS PEMASUKAN ,SUM(total) AS TOTAL from detail_transaksi join transaksi 
                                        using (id_Transaksi) 
                                        where extract(month from tgl_transaksi)= " & CInt(cb_bulan.Text) & " and extract(year from tgl_transaksi)=" & CInt(cb_tahun.Text) & "
                                        group by id_transaksi,tgl_transaksi order by id_transaksi ", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "XX")
            DataGridView1.DataSource = (DS.Tables("XX"))
            DataGridView1.ReadOnly = True
            DataGridView1.AutoSizeColumnsMode = DataGridView1.AutoSizeColumnsMode.Fill
            Dim query As String = "select sum(total) from detail_transaksi join transaksi 
                                   using (id_Transaksi) 
                                   where extract(month from tgl_transaksi)= " & CInt(cb_bulan.Text) & " and extract(year from tgl_transaksi)=" & CInt(cb_tahun.Text) & "
                                   group by id_transaksi,tgl_transaksi order by id_transaksi"
            CMD = New OracleCommand(query, CONN)
            CMD.ExecuteNonQuery()
            DR = CMD.ExecuteReader()
            DR.Read()
            TextBox1.Text = "Rp." + DR.Item(0).ToString
            rb_semua.Checked = False
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form_owner.ConFormEnPanel(Form_Laporan)
    End Sub

    Private Sub Form_Laporan_pendapatan_Load(sender As Object, e As EventArgs) Handles Me.Load
        rb_semua.Checked = True
        TampilData()
        DA = New OracleDataAdapter("select distinct(extract(month from tgl_transaksi)) AS Bulan from transaksi", CONN)
        DS = New DataSet()
        DS.Clear()
        DA.Fill(DS, "select distinct(extract(month from tgl_transaksi)) AS Bulan from transaksi")

        For i = 0 To DS.Tables(0).Rows.Count - 1
            cb_bulan.Items.Add(DS.Tables(0).Rows(i).Item("Bulan"))
        Next

        DA = New OracleDataAdapter("select distinct(extract(year from tgl_transaksi)) As Year from transaksi", CONN)
        DS = New DataSet()
        DS.Clear()
        DA.Fill(DS, "select distinct(extract(year from tgl_transaksi)) As Year from transaksi")

        For i = 0 To DS.Tables(0).Rows.Count - 1
            cb_tahun.Items.Add(DS.Tables(0).Rows(i).Item("Year"))
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TampilData()
    End Sub

End Class