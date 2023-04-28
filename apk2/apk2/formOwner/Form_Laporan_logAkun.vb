Imports System.Data.OracleClient

Public Class Form_Laporan_logAkun
    Sub TampilData()
        If rb_semua.Checked = True Then
            DA = New OracleDataAdapter("select id_staff,nama_staff,login,logout from log_akun join staff using (id_staff)", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "XXX")
            DataGridView1.DataSource = (DS.Tables("XXX"))
            DataGridView1.ReadOnly = True
            DataGridView1.AutoSizeColumnsMode = DataGridView1.AutoSizeColumnsMode.Fill
            rb_custom.Checked = False
        ElseIf rb_custom.Checked = True Then
            DA = New OracleDataAdapter("SELECT id_staff,nama_staff,login,logout from log_akun join staff using (id_staff) where login between TO_TIMESTAMP('" & DateTimePicker_mulai.Text & "','DD Month YYYY')-1 and TO_TIMESTAMP('" & DateTimePicker_sampai.Text & "','DD Month YYYY')+1", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "XX")
            DataGridView1.DataSource = (DS.Tables("XX"))
            DataGridView1.ReadOnly = True
            DataGridView1.AutoSizeColumnsMode = DataGridView1.AutoSizeColumnsMode.Fill
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form_owner.ConFormEnPanel(Form_Laporan)
    End Sub

    Private Sub Form_Laporan_logAkun_Load(sender As Object, e As EventArgs) Handles Me.Load
        rb_semua.Checked = True
        TampilData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TampilData()
    End Sub
End Class