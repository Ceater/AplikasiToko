Public Class Penjualan
    Dim DTable As New DataTable
    Dim DRow As DataRow
    Dim jumlah As String = ""

    Private Sub Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setGV()
        ComboBox1.DataSource = DSet.Tables("DataBarang")
        ComboBox1.ValueMember = "NamaBarang"
        ComboBox1.DisplayMember = "KodeBarang"
        Timer1.Start()
    End Sub

    Sub setGV()
        DTable.Columns.Add("Kode Barang")
        DTable.Columns.Add("Nama Barang")
        DTable.Columns.Add("Satuan")
        DTable.Columns.Add("Harga Satuan")
        DTable.Columns.Add("Jumlah")
        DTable.Columns.Add("Diskon %")
        DTable.Columns.Add("Grand Total")
        DataGridView1.DataSource = DTable
        Dim temp As Double = DataGridView1.Size.Width
        DataGridView1.Columns(0).Width = temp * 0.15
        DataGridView1.Columns(1).Width = temp * 0.245
        DataGridView1.Columns(2).Width = temp * 0.1
        DataGridView1.Columns(3).Width = temp * 0.15
        DataGridView1.Columns(4).Width = temp * 0.12
        DataGridView1.Columns(5).Width = temp * 0.1
        DataGridView1.Columns(6).Width = temp * 0.13
        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.Columns(3).ReadOnly = True
        DataGridView1.Columns(6).ReadOnly = True
    End Sub

    Private Sub ComboBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            Try
                DRow = DTable.NewRow
                DRow("Kode Barang") = ComboBox1.SelectedText
                DRow("Nama Barang") = ComboBox1.SelectedValue
                DRow("Satuan") = DSet.Tables("DataBarang").Rows(ComboBox1.SelectedIndex).Item(3).ToString
                DRow("Harga Satuan") = DSet.Tables("DataBarang").Rows(ComboBox1.SelectedIndex).Item(4).ToString
                DRow("Jumlah") = 1
                DRow("Diskon %") = 0
                DRow("Grand Total") = DRow("Harga Satuan")
                DTable.Rows.Add(DRow)
            Catch ex As Exception
                'MsgBox("Kode barang tidak ditemukan")
            End Try
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If (DataGridView1.CurrentCell.ColumnIndex = 4 Or DataGridView1.CurrentCell.ColumnIndex = 5) Then 'put columnindextovalidate
            RemoveHandler e.Control.KeyPress, AddressOf ValidateKeyPress
            AddHandler e.Control.KeyPress, AddressOf ValidateKeyPress
        End If
    End Sub

    Private Sub ValidateKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        DRow = DTable.Rows(DataGridView1.CurrentCell.RowIndex)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        Else

        End If
        If (DataGridView1.CurrentCell.ColumnIndex = 4) Then
            jumlah &= [Enum].GetName(GetType(System.Windows.Forms.Keys), CType(Asc(e.KeyChar), System.Windows.Forms.Keys)).Substring(1, 1)
        End If
    End Sub

    Private Sub CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellLeave
        If (DataGridView1.CurrentCell.ColumnIndex = 4 Or DataGridView1.CurrentCell.ColumnIndex = 5) Then 'put columnindextovalidate
            DRow = DTable.Rows(DataGridView1.CurrentCell.RowIndex)
            Dim tot As Integer = CInt(DRow("Harga Satuan")) * DRow("Jumlah")
            Dim disc As Integer = CInt(DRow("Diskon %"))
            If disc = 0 Then
                DRow("Grand Total") = tot
            Else
                DRow("Grand Total") = tot - (tot * (disc / 100))
            End If
            DRow("Jumlah") = jumlah
        Else
            jumlah = ""
        End If
        'MsgBox(DataGridView1.CurrentCell.ColumnIndex)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For i = 0 To DTable.Rows.Count - 1
            DRow = DTable.Rows(i)
            Dim tot As Integer = CInt(DRow("Harga Satuan")) * DRow("Jumlah")
            Dim disc As Integer = CInt(DRow("Diskon %"))
            If disc = 0 Then
                DRow("Grand Total") = tot
            Else
                DRow("Grand Total") = tot - (tot * (disc / 100))
            End If
            'DRow("Jumlah") = jumlah
        Next
    End Sub
End Class