Public Class Barang

    Private Sub Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = DSet.Tables("DataBarang")
        setGV()
        ComboBox1.DataSource = DSet.Tables("DataSatuan")
        ComboBox1.DisplayMember = "NamaSatuan"
        ComboBox1.ValueMember = "KodeSatuan"
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Button1.Text = "Rubah"
            TextBox1.ReadOnly = True
            TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            ComboBox1.SelectedValue = getKodeSatuan(DataGridView1.Rows(e.RowIndex).Cells(3).Value)
            TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            NumericUpDown1.Value = DataGridView1.Rows(e.RowIndex).Cells(6).Value
            NumericUpDown2.Value = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        clearall()
        Button1.Text = "Tambah"
    End Sub

    Sub clearall()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        ComboBox1.SelectedIndex = 0
    End Sub

    Sub setGV()
        DataGridView1.Columns(0).HeaderText = "Kode"
        DataGridView1.Columns(1).HeaderText = "Nama Barang"
        DataGridView1.Columns(2).HeaderText = "Stok"
        DataGridView1.Columns(3).HeaderText = "Satuan"
        DataGridView1.Columns(4).HeaderText = "Harga"
        DataGridView1.Columns(5).HeaderText = "Isi Barang"
        DataGridView1.Columns(6).HeaderText = "Pengingat"
        Dim temp As Double = DataGridView1.Size.Width
        DataGridView1.Columns(0).Width = temp * 0.1
        DataGridView1.Columns(1).Width = temp * 0.4
        DataGridView1.Columns(2).Width = temp * 0.07
        DataGridView1.Columns(3).Width = temp * 0.1
        DataGridView1.Columns(4).Width = temp * 0.1
        DataGridView1.Columns(5).Width = temp * 0.1
        DataGridView1.Columns(6).Width = temp * 0.1
        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class