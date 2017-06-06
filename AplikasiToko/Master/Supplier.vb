Public Class Supplier
    Dim tempNSupp As String 'Digunakan untuk menampung nama supplier sebelum dirubah
    Dim tempNSales As String 'Digunakan untuk menampung nama sales sebelum dirubah
    Private Sub Supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TmpDSet As DataTable
        DataGridView1.DataSource = DSet.Tables("DataSupplier")
        DataGridView2.DataSource = DSet.Tables("DataKontakSupplier")
        setGV()
        TmpDSet = DSet.Tables("DataSupplier")
        ComboBox1.DataSource = TmpDSet
        ComboBox1.ValueMember = "NamaSupplier"
        ComboBox1.DisplayMember = "NamaSupplier"
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
            TextBox1.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
            TextBox4.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value
            ComboBox1.SelectedValue = DataGridView2.Rows(e.RowIndex).Cells(1).Value
            Button3.Text = "Rubah"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim result As Integer = MessageBox.Show("Anda ingin mengosongkan kolom?", "Peringatan", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            resetSupp()
        ElseIf result = DialogResult.No Then
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim result As Integer = MessageBox.Show("Anda ingin mengosongkan kolom?", "Peringatan", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            resetSalesSupp()
        ElseIf result = DialogResult.No Then
        End If
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

    Sub resetSupp()
        TextBox2.Text = ""
        TextBox3.Text = ""
        Button1.Text = "Tambah"
    End Sub

    Sub resetSalesSupp()
        TextBox1.Text = ""
        TextBox4.Text = ""
        ComboBox1.SelectedIndex = 0
        Button3.Text = "Tambah"
    End Sub
End Class