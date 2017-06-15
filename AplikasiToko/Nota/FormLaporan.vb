Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FormLaporan
    Public LaporanNoNota As String = ""
    Dim Jenis As String = ""

    Public Sub New(ByVal laporan As String)
        InitializeComponent()
        Jenis = laporan
    End Sub

    Private Sub crv_Load(sender As Object, e As EventArgs) Handles crv.Load
        Try
            Dim con As SqlConnection
            con = constring
            con.Open()

            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()

            Dim adapt As New SqlDataAdapter
            Dim dataset As New DataSet

            adapt.SelectCommand = cmd
            dataset.Clear()
            Dim rep As New ReportDocument
            If Jenis = "NotaPenjualan" Then
                cmd.CommandText = "SELECT H.NoNotaJual, H.TglNota, H.GrandTotal, H.NamaPelanggan, H.IDStaff, D.IDBarang, D.NamaBarang, D.Satuan, D.HargaSatuan, D.Jumlah, D.Diskon, D.Subtotal from HJual H, DJual D where H.NoNotaJual=D.NoNotaJual"
                adapt.Fill(dataset, "Penjualan")
                rep = New NotaPenjualan
                rep.SetDataSource(dataset)
            ElseIf Jenis = "NotaPenjualanSatuan" Then
                cmd.CommandText = "SELECT H.NoNotaJual, H.TglNota, H.GrandTotal, H.NamaPelanggan, H.IDStaff, D.IDBarang, D.NamaBarang, D.Satuan, D.HargaSatuan, D.Jumlah, D.Diskon, D.Subtotal from HJual H, DJual D where H.NoNotaJual=D.NoNotaJual and H.NoNotaJual=@a"
                cmd.Parameters.AddWithValue("@a", LaporanNoNota)
                adapt.Fill(dataset, "Penjualan")
                rep = New NotaPenjualan
                rep.SetDataSource(dataset)
            End If
            con.Close()
            crv.ReportSource = rep
            crv.Refresh()
        Catch ex As Exception

        End Try
    End Sub
End Class