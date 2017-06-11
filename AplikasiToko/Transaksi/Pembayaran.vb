Public Class Pembayaran
    Dim lblArr(7) As Label
    Dim staff As String = ""

    Private Sub Pembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblArr(0) = NNota
        lblArr(1) = NToko
        lblArr(2) = TotTag1
        lblArr(3) = Kekurangan1
        lblArr(4) = TotTag2
        lblArr(5) = Kekurangan2
        lblArr(6) = Bayar
        lblArr(7) = HAkhir
        clear()
        loadTagihan()
        loadListBox()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            Dim temp() As String = Split(loadTagihan.Item(sender.selectedindex), "-")
            lblArr(0).Text = temp(0)
            lblArr(1).Text = temp(2)
            lblArr(2).Text = temp(3)
            lblArr(3).Text = temp(4)
            lblArr(4).Text = temp(3)
            lblArr(5).Text = temp(4)
            lblArr(6).Text = "0"
            lblArr(7).Text = lblArr(6).Text - temp(4)
        Catch ex As Exception

        End Try
    End Sub

    Sub clear()
        lblArr(0).Text = ""
        lblArr(1).Text = ""
        lblArr(2).Text = "0"
        lblArr(3).Text = "0"
        lblArr(4).Text = "0"
        lblArr(5).Text = "0"
        lblArr(6).Text = "0"
        lblArr(7).Text = "0"
    End Sub

    Sub loadListBox()
        If loadTagihan.Count <> 0 Then
            For i = 0 To loadTagihan.Count - 1
                Dim temp() As String
                temp = Split(loadTagihan.Item(i), "-")
                ListBox1.Items.Add(temp(0))
            Next
            ListBox1.SelectedIndex = 0
        Else
            MsgBox("Tidak ada tagihan yang belum lunas")
        End If
    End Sub

    Sub setStaff(x As String)
        staff = x
    End Sub
End Class