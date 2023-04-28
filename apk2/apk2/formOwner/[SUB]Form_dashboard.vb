Imports System.Data.OracleClient

Public Class Form_dashboard
    Private Sub Form_dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet2.TRANSAKSI' table. You can move, or remove it, as needed.
        Me.TRANSAKSITableAdapter.Fill(Me.DataSet2.TRANSAKSI)
        'Untuk menghitung jumlah karywan 
        Dim query As String = "select count(id_staff) from staff"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
        DR = CMD.ExecuteReader()
        DR.Read()
        label_karyawan.Text = DR.Item(0)
        DataGridView_transaksi.ReadOnly = True
        DataGridView_transaksi.AutoSizeColumnsMode = DataGridView_transaksi.AutoSizeColumnsMode.Fill
        'jumlah transaksi baru
        query = "select count(*) from transaksi where status_transaksi='Baru'"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
        DR = CMD.ExecuteReader()
        DR.Read()
        Label4.Text = DR.Item(0)
        'jumlah total transaksi
        Dim query1 As String = "select count(*) from transaksi"
        CMD = New OracleCommand(query1, CONN)
        CMD.ExecuteNonQuery()
        DR = CMD.ExecuteReader()
        DR.Read()
        Label5.Text = DR.Item(0)
        ' untuk menghitung jumlah customer
        query = "select count(distinct(HP_CUST)) from transaksi"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
        DR = CMD.ExecuteReader()
        DR.Read()
        Label2.Text = DR.Item(0)
        'total pendapatan 
        query = "select sum(total) from detail_transaksi"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
        DR = CMD.ExecuteReader()
        DR.Read()
        Label1.Text = "Rp." + DR.Item(0).ToString

    End Sub


End Class