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

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        If cbocourse.SelectedIndex = 0 Then
            DisplayAllData("bsit")
        ElseIf cbocourse.SelectedIndex = 1 Then
            DisplayAllData("CBA")
        ElseIf cbocourse.SelectedIndex = 2 Then
            DisplayAllData("Criminology")
        ElseIf cbocourse.SelectedIndex = 3 Then
            DisplayAllData("CSS")
        Else
            MsgBox("no record found")
        End If
    End Sub
End Class