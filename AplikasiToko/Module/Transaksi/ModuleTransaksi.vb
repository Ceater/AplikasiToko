Imports System.Data.Sql
Imports System.Data.SqlClient

Module ModuleTransaksi
    Dim cmd As SqlCommand
    Sub insertHJual(nota As String, tgl As Date, grandtot As Integer, idstaff As String)
        Try
            constring.Open()
            cmd = New SqlCommand("Insert into HJual values(@a,@b,@c,@d)", constring)
            With cmd.Parameters
                .Add(New SqlParameter("@a", nota))
                .Add(New SqlParameter("@b", tgl))
                .Add(New SqlParameter("@c", grandtot))
                .Add(New SqlParameter("@d", idstaff))
            End With
            constring.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            constring.Close()
        End Try
    End Sub

    Sub insertDJual(nota As String, idbarang As String, namabarang As String, harga As Integer, jumlah As Integer, subtot As Integer)
        Try
            constring.Open()
            cmd = New SqlCommand("Insert into DJual values(@a,@b,@c,@d,@e,@f)", constring)
            With cmd.Parameters
                .Add(New SqlParameter("@a", nota))
                .Add(New SqlParameter("@b", idbarang))
                .Add(New SqlParameter("@c", namabarang))
                .Add(New SqlParameter("@d", harga))
                .Add(New SqlParameter("@e", jumlah))
                .Add(New SqlParameter("@f", subtot))
            End With
            constring.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            constring.Close()
        End Try
    End Sub

    Sub insertPembayaran(nota As String, tgl As Date, uangbayar As Integer)
        Try
            constring.Open()
            cmd = New SqlCommand("Insert into TbPembayaran values(@a,@b,@c)", constring)
            With cmd.Parameters
                .Add(New SqlParameter("@a", nota))
                .Add(New SqlParameter("@b", tgl))
                .Add(New SqlParameter("@c", uangbayar))
            End With
            constring.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            constring.Close()
        End Try
    End Sub
End Module
