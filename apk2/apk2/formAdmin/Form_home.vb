Imports System.Data.OracleClient
Public Class Form_home
    Private Sub Form_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.TRANSAKSI' table. You can move, or remove it, as needed.
        Me.TRANSAKSITableAdapter.Fill(Me.DataSet2.TRANSAKSI)
        Dim query As String = "select count(*) from transaksi where status_transaksi='Baru'"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
        DR = CMD.ExecuteReader()
        DR.Read()
        Label4.Text = DR.Item(0)
        Dim query1 As String = "select count(*) from transaksi"
        CMD = New OracleCommand(query1, CONN)
        CMD.ExecuteNonQuery()
        DR = CMD.ExecuteReader()
        DR.Read()
        Label5.Text = DR.Item(0)
    End Sub
End Class