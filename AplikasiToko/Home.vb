Public Class Home

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        LoadDataSet()
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

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
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

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
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

    Private Sub CekLaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CekLaporanToolStripMenuItem.Click
        Dim f As New FormNotaPenjualan
        f.Show()
    End Sub
End Class