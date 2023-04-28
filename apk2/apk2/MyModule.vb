Imports System.Data.OracleClient
Module MyModule
    Public akun_login As String = "-"
    Public id_login As String
    Public DS As DataSet
    Public DA As OracleDataAdapter
    Public CONN As OracleConnection
    Public CMD As OracleCommand
    Public DR As OracleDataReader
    Public tampung As String
    Public login As String
    Public logout As String

    'MENGHUBUNGKAN KEDALAM DATABASE
    Public Sub Koneksi()
        Dim konek As String
        konek = "Data Source=LAPTOP-7JCGTHCO;User ID=DBSUCIO;Password=admin;Unicode=True"
        CONN = New OracleConnection(konek)
        Try
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
                MsgBox("succes..", MsgBoxStyle.Exclamation, "Informasi")
                Form_owner.statusDB.Text = "connected"
                Form_owner.statusDB.ForeColor = Color.White
            End If

        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal " & ex.Message)
        End Try
    End Sub

    Sub Tampil_tabel(ByVal tbl As String, ByVal grid As DataGridView)
        DA = New OracleDataAdapter("select * from " & tbl & "", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "select * from " & tbl & "")
        grid.DataSource = (DS.Tables("select * from " & tbl & ""))
        grid.ReadOnly = True
        grid.AutoSizeColumnsMode = grid.AutoSizeColumnsMode.Fill
    End Sub

    Public Sub log_akun(ByVal id_login As String, ByVal login As Date, ByVal logout As Date)
        'pencatatan akun login
        Dim query As String = "insert into log_akun values('" & id_login & "',TO_TIMESTAMP('" & login & "', 'dd/MM/yyyy HH24:mi:ss'), TO_TIMESTAMP('" & logout & "', 'dd/MM/yyyy HH24:mi:ss'))"
        CMD = New OracleCommand(query, CONN)
        CMD.ExecuteNonQuery()
        '/////////////////////
    End Sub
End Module
