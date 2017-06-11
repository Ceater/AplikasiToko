Imports System.Data.Sql
Imports System.Data.SqlClient

Module ModuleTerima
    Dim cmd As SqlCommand
    Sub insertHTerima(nota As String, tgl As String, idstaff As String)
        Try
            constring.Open()
            cmd = New SqlCommand("insert into HTerima Values(@a,@b,@c)", constring)
            With cmd.Parameters
                .Add(New SqlParameter("@a", nota))
                .Add(New SqlParameter("@b", tgl))
                .Add(New SqlParameter("@c", idstaff))
            End With
            cmd.ExecuteNonQuery()
            constring.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            constring.Close()
        End Try
    End Sub

    Sub insertDTerima(nota As String, idbarang As String, namabarang As String, satuan As String, jumlah As String)
        Try
            constring.Open()
            cmd = New SqlCommand("insert into DTerima Values(@a,@b,@c,@d,@e)", constring)
            With cmd.Parameters
                .Add(New SqlParameter("@a", nota))
                .Add(New SqlParameter("@b", idbarang))
                .Add(New SqlParameter("@c", namabarang))
                .Add(New SqlParameter("@d", satuan))
                .Add(New SqlParameter("@e", jumlah))
            End With
            cmd.ExecuteNonQuery()
            constring.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            constring.Close()
        End Try
    End Sub
End Module