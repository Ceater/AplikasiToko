Public Class Home
    Public hakAkses As String = ""
    Public Menu(12) As ToolStripMenuItem
    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        LoadDataSet()
        Menu(0) = BarangToolStripMenuItem
        Menu(1) = SupplierToolStripMenuItem
        Menu(2) = StaffToolStripMenuItem
        Menu(3) = PelangganToolStripMenuItem
        Menu(4) = PenjualanToolStripMenuItem
        Menu(5) = TerimaToolStripMenuItem
        Menu(6) = PembayaranToolStripMenuItem
        Menu(7) = StokOpnameToolStripMenuItem
        Menu(8) = PrintUlangNotaToolStripMenuItem
        Menu(9) = PenjualanToolStripMenuItem2
        Menu(10) = TerimaToolStripMenuItem2
        Menu(11) = PembayaranToolStripMenuItem
        Dim temp(11) As String
        For i = 0 To 10
            temp(i) = hakAkses.Substring(i, 1)
            If temp(i) = "1" Then
                Menu(i).Enabled = True
            Else
                Menu(i).Enabled = False
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel4.Text = Date.Now.ToString("dd - MMMM - yyyy")
        ToolStripStatusLabel6.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        Dim f As New Barang
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        Dim f As New Supplier
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        Dim f As New Staff
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim f As New HelpForm
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Dim f As New Penjualan
        f.MdiParent = Me
        f.setStaff(ToolStripStatusLabel2.Text)
        f.Show()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        Dim f As New Pelanggan
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerimaToolStripMenuItem.Click
        Dim f As New TerimaBarang
        f.MdiParent = Me
        f.setStaff(ToolStripStatusLabel2.Text)
        f.Show()
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        Dim f As New Pembayaran
        f.MdiParent = Me
        f.setStaff(ToolStripStatusLabel2.Text)
        f.Show()
    End Sub

    Private Sub CekLaporanToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim f As New FormLaporan("NotaPembayaran")
        f.LaporanNoNota = "4"
        f.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem2.Click
        Dim f As New FormLaporanPenjualan
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles TerimaToolStripMenuItem2.Click
        Dim f As New FormLaporanTerima
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub StokOpnameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokOpnameToolStripMenuItem.Click
        Dim f As New StokOpname
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PembayaranToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem1.Click
        Dim f As New FormLaporan("LaporanPembayaran")
        f.MdiParent = Me
        f.Show()
    End Sub
End Class