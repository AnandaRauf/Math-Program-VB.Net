Public Class MainMenu
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click

        MsgBox("Are you sure exit ?", vbQuestion + vbYesNo, "Confirmation")

        Close()
    End Sub

    Private Sub AboutAppsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutAppsToolStripMenuItem.Click
        MessageBox.Show("Version 1.0.0")
        MessageBox.Show("Powered  By PT.Tech Media Development")
        MessageBox.Show("Developed Date: 06 January 2019")
    End Sub

    Private Sub AnutiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnutiasToolStripMenuItem.Click
        Anutias.Show()
    End Sub
End Class