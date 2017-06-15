Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared.SharedUtils

Public Class FormNotaPenjualan
    Private Sub FormNotaPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            constring.Open()

            Dim cmd As New SqlCommand
            cmd.Connection = constring
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()

            Dim adapt As New SqlDataAdapter
            Dim dataset As New DataSet

            adapt.SelectCommand = cmd
            dataset.Clear()

            'cmd.CommandText = "SELECT H.NoNotaJual, H.TglNota, H.GrandTotal, H.NamaPelanggan, H.IDStaff, D.IDBarang, D.NamaBarang, D.Satuan, D.HargaSatuan, D.Jumlah, D.Diskon, D.Subtotal from HJual H, DJual D where H.NoNotaJual=D.NoNotaJual"
            'adapt.Fill(dataset, "DSetPenjualan")
            Dim rep As New NotaPenjualan
            rep.SetDataSource(dataset)

            CrystalReportViewer1.ReportSource = rep
            CrystalReportViewer1.Refresh()
            constring.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class