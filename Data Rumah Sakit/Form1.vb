Public Class Form_Menu_Utama
    Private Sub Form_Menu_Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPasien_Click(sender As Object, e As EventArgs) Handles btnPasien.Click
        Dim formPasien = New Form_Data_Pasien()
        formPasien.Show()
        Me.Hide()
    End Sub

    Private Sub btnDokter_Click(sender As Object, e As EventArgs) Handles btnDokter.Click
        Dim formDokter = New Form_Data_Dokter()
        formDokter.Show()
        Me.Hide()
    End Sub

    Private Sub btnObat_Click(sender As Object, e As EventArgs) Handles btnObat.Click
        Dim formObat = New Form_Data_Obat()
        formObat.Show()
        Me.Hide()
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Me.Close()
        System.Environment.Exit(1)
    End Sub
End Class
