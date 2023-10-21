Public Class Form2
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConnectDbase()
        LoadAllData()

        With dgvdata
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .RowsDefaultCellStyle.BackColor = Color.AntiqueWhite
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
        End With
    End Sub
End Class