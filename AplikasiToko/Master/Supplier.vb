Public Class Supplier
    Dim tempNSupp As String 'Digunakan untuk menampung nama supplier sebelum dirubah
    Dim tempNSales As String 'Digunakan untuk menampung nama sales sebelum dirubah
    Private Sub Supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = DSet.Tables("DataSupplier")
        DataGridView2.DataSource = DSet.Tables("DataKontakSupplier")
        setGV()
        ComboBox1.DataSource = DSet.Tables("DataSupplier")
        ComboBox1.ValueMember = "IDSupplier"
        ComboBox1.DisplayMember = "NamaSupplier"

    End Sub

    Sub setGV()
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).HeaderText = "Nama"
        DataGridView1.Columns(2).HeaderText = "Alamat"
        Dim temp As Double = DataGridView1.Size.Width
        DataGridView1.Columns(1).Width = temp * 0.3
        DataGridView1.Columns(2).Width = temp * 0.68
        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

        DataGridView2.Columns(0).Visible = False
        DataGridView2.Columns(1).HeaderText = "Supplier"
        DataGridView2.Columns(2).HeaderText = "Nama Sales"
        DataGridView2.Columns(3).HeaderText = "Telepon"
        temp = DataGridView2.Size.Width
        DataGridView2.Columns(1).Width = temp * 0.3
        DataGridView2.Columns(2).Width = temp * 0.4
        DataGridView2.Columns(3).Width = temp * 0.28
        DataGridView2.Sort(DataGridView2.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            tempNSupp = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            Button1.Text = "Rubah"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView2_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Try
            tempNSupp = DataGridView2.Rows(e.RowIndex).Cells(0).Value
            TextBox1.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
            TextBox4.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
            ComboBox1.SelectedValue = DataGridView2.Rows(e.RowIndex).Cells(0).Value
            Button3.Text = "Rubah"
        Catch ex As Exception

        End Try
    End Sub
End Class