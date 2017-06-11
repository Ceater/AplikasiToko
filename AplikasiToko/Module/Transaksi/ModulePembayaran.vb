Imports System.Data.Sql
Imports System.Data.SqlClient

Module ModulePembayaran
    Dim cmd As SqlCommand
    Function loadTagihan() As ArrayList
        Dim x As New ArrayList
        Try
            constring.Open()
            cmd = New SqlCommand("select H.NoNotaJual,H.TglNota,H.NamaPelanggan, H.GrandTotal, H.GrandTotal - T.UangBayar as Kekurangan from HJual H, TbPembayaran T where H.NoNotaJual = T.NoNotaJual and H.GrandTotal - T.UangBayar <> 0", constring)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            While reader.Read
                x.Add(reader.GetValue(0) & "-" & reader.GetValue(1) & "-" & reader.GetValue(2) & "-" & reader.GetValue(3) & "-" & reader.GetValue(4))
            End While
            constring.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            constring.Close()
        End Try
        Return x
    End Function

    Function cekNotaPembayaran() As Boolean
        Dim x As Boolean
        Try
            constring.Open()
            cmd = New SqlCommand("select H.NoNotaJual,H.TglNota,H.NamaPelanggan, H.GrandTotal, H.GrandTotal - T.UangBayar as Kekurangan from HJual H, TbPembayaran T where H.NoNotaJual = T.NoNotaJual and H.GrandTotal - T.UangBayar <> 0", constring)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            While reader.Read
                x.Add(reader.GetValue(0) & "-" & reader.GetValue(1) & "-" & reader.GetValue(2) & "-" & reader.GetValue(3) & "-" & reader.GetValue(4))
            End While
            constring.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            constring.Close()
        End Try
        Return x
    End Function
End Module
