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

    Sub insertBarang(ByVal a As String, ByVal b As String, ByVal c As Integer)
        constring.Open()
        cmd = New SqlCommand("insert into TbBarang values('1','Pepsodent Kecil',0,2,2500,5)", constring)
        constring.Close()
    End Sub
End Module
