Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System
Imports System.IO

Module GlobalModule
    Public constring As New SqlConnection("")
    Public DSet As New DataSet
    Public cmd As SqlCommand
    Public SqlAdapter As SqlDataAdapter

    Sub LoadSetting()
        Dim filepath As String = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath())) & "\Setting\setting.txt"
        Dim line As String = ""
        Try
            Dim sr As StreamReader = New StreamReader(filepath)
            line = sr.ReadLine
            If line Is Nothing Then
                MsgBox("Database tidak termuat")
            Else
                constring = New SqlConnection(line)
            End If
        Catch ex As Exception
            MsgBox("Database tidak ditemukan")
        End Try

        Try
            constring.Open()
            constring.Close()
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox("Pengaturan Salah")
        End Try
    End Sub

    Sub LoadDataSet()
        Try
            constring.Open()
            SqlAdapter = New SqlDataAdapter("select tb.KodeBarang, NamaBarang, Stok, NamaSatuan, HargaSatuan, JumlahIsiBarang, StokPengingat from TbBarang tb, TbSatuan ts, DSatuan ds where tb.SatuanBarang = ts.KodeSatuan and tb.KodeBarang=ds.KodeBarang", constring)
            SqlAdapter.Fill(DSet, "DataBarang")
            SqlAdapter = New SqlDataAdapter("select * from TbSupplier", constring)
            SqlAdapter.Fill(DSet, "DataSupplier")
            SqlAdapter = New SqlDataAdapter("select IDKontakSupplier, NamaSupplier, NamaSales, TlpSales from TbKontakSupplier tk, TbSupplier ts where tk.IDSupplier = ts.IDSupplier", constring)
            SqlAdapter.Fill(DSet, "DataKontakSupplier")
            SqlAdapter = New SqlDataAdapter("select * from TbSatuan", constring)
            SqlAdapter.Fill(DSet, "DataSatuan")
            constring.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            constring.Close()
        End Try
    End Sub
End Module
