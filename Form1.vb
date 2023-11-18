Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDbase()
        txtfirst.Enabled = False
        txtlast.Enabled = False
        txtstudcourse.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        SaveRecord()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        SearchData()
    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim ans As DialogResult = MessageBox.Show("Do you want to save changes", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            updaterecord(txtuserid.Text, txtfirst.Text, txtlast.Text, txtstudcourse.Text)
            MsgBox("Update Success")
        Else
            MsgBox("Update Cancelled")
        End If

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim ans As DialogResult = MessageBox.Show("Do you want to save changes", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            deleterecord(txtuserid.Text)
            MsgBox("Delete Success")
        Else
            MsgBox("Delete Cancelled")
        End If
    End Sub
End Class
