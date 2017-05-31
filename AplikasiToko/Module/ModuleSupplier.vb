Imports System.Data.Sql
Imports System.Data.SqlClient

Module ModuleSupplier
    Dim cmd As SqlCommand
    Function getKodeSupplier(ByVal s As String)
        Dim x As Integer = 0
        constring.Open()
        cmd = New SqlCommand("Select IDSupplier from TbSupplier where NamaSupplier=@ns", constring)
        With cmd.Parameters
            .Add(New SqlParameter("@ns", s))
        End With
        x = cmd.ExecuteScalar
        constring.Close()
        Return x
    End Function
End Module
