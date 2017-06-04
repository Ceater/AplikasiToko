Imports System.Data.Sql
Imports System.Data.SqlClient

Module ModuleBarang
    Dim cmd As SqlCommand
    Function getKodeSatuan(ByVal s As String)
        Dim x As Integer = 0
        constring.Open()
        cmd = New SqlCommand("Select KodeSatuan from TbSatuan where NamaSatuan=@ns", constring)
        With cmd.Parameters
            .Add(New SqlParameter("@ns", s))
        End With
        x = cmd.ExecuteScalar
        constring.Close()
        Return x
    End Function

    Sub insertBarang(ByVal KDBarang As String, ByVal NMBarang As String, ByVal Stok As Integer, ByVal KDSatuan As String, ByVal HSatuan As Integer, ByVal Spengingat As Integer, ByVal JIsibarang As Integer)
        Try
            constring.Open()
            cmd = New SqlCommand("insert into TbBarang values(@aa,@ab,@ac,@ad,@ae,@af)", constring)
            With cmd.Parameters
                .Add(New SqlParameter("@aa", KDBarang))
                .Add(New SqlParameter("@ab", NMBarang))
                .Add(New SqlParameter("@ac", Stok))
                .Add(New SqlParameter("@ad", KDSatuan))
                .Add(New SqlParameter("@ae", HSatuan))
                .Add(New SqlParameter("@af", Spengingat))
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New SqlCommand("insert into DSatuan values(@aa,@ab,@ac)", constring)
            With cmd.Parameters
                .Add(New SqlParameter("@aa", KDBarang))
                .Add(New SqlParameter("@ab", KDSatuan))
                .Add(New SqlParameter("@ac", JIsibarang))
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            constring.Close()
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox("Barang sudah teregistrasi")
            constring.Close()
        End Try
    End Sub

    Sub updateBarang(ByVal KDBarang As String, ByVal NMBarang As String, ByVal Stok As Integer, ByVal KDSatuan As String, ByVal HSatuan As Integer, ByVal Spengingat As Integer, ByVal JIsibarang As Integer)
        constring.Open()
        cmd = New SqlCommand("update TbBarang set NamaBarang=@a2, Stok=@a3, SatuanBarang=@a4, HargaSatuan=@a5, StokPengingat=@a6 where KodeBarang=@a1", constring)
        With cmd.Parameters
            .Add(New SqlParameter("@a1", KDBarang))
            .Add(New SqlParameter("@a2", NMBarang))
            .Add(New SqlParameter("@a3", Stok))
            .Add(New SqlParameter("@a4", KDSatuan))
            .Add(New SqlParameter("@a5", HSatuan))
            .Add(New SqlParameter("@a6", Spengingat))
        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New SqlCommand("update DSatuan set KodeSatuan=@ab, JumlahIsibarang=@ac where KodeBarang=@aa", constring)
        With cmd.Parameters
            .Add(New SqlParameter("@aa", KDBarang))
            .Add(New SqlParameter("@ab", KDSatuan))
            .Add(New SqlParameter("@ac", JIsibarang))
        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        constring.Close()
    End Sub

    Sub deleteBarang(ByVal KDBarang As String)
        constring.Open()
        cmd = New SqlCommand("delete TbBarang where KodeBarang=@a1", constring)
        With cmd.Parameters
            .Add(New SqlParameter("@a1", KDBarang))
        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New SqlCommand("delete DSatuan where KodeBarang=@aa", constring)
        With cmd.Parameters
            .Add(New SqlParameter("@aa", KDBarang))
        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        constring.Close()
    End Sub
End Module
