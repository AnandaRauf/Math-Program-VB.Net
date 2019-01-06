Public Class Anutias
    Private Sub QtButAnu_Click(sender As Object, e As EventArgs) Handles QtButAnu.Click

        MsgBox("Are you sure exit ?", vbQuestion + vbYesNo, "Confirmation")

        Close()
    End Sub

    Private Sub TotButAnu_Click(sender As Object, e As EventArgs) Handles TotButAnu.Click
        Dim hargabarang, dpbarang, sisacicilanbarang, bungabarang, jumlahbungabarang As Integer
        hargabarang = HrgBAnuBox.Text
        dpbarang = DpBrngAnuBox.Text
        bungabarang = BngBrngBox.Text
        sisacicilanbarang = hargabarang - dpbarang
        SisaClnBAnuBox.Text = sisacicilanbarang
        jumlahbungabarang = SisaClnBAnuBox.Text * bungabarang / 100
        JmlhBngAnuBox.Text = jumlahbungabarang
        TotTagAnuBox.Text = JmlhBngAnuBox.Text + SisaClnBAnuBox.Text
        TagBuAnuBox.Text = TotTagAnuBox.Text
        TokAnuBox.Text = SisaClnBAnuBox.Text + JmlhBngAnuBox.Text + TotTagAnuBox.Text + TagBuAnuBox.Text


    End Sub
End Class