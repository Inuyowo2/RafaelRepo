Imports System.Runtime.Versioning
Imports System.Security.Cryptography.X509Certificates
Imports K4os.Compression.LZ4.Streams
Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient
Module Module1
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String
    Dim dtTable As New DataTable
    Dim adapter As New MySqlDataAdapter

    Public Sub ConnectDbase()
        host = "127.0.0.1"
        dbname = "cs2aoop"
        uname = "root"
        pwd = "password"
        ' check if connection if open
        If Not con Is Nothing Then
            con.Close() 'close dbconnection
            con.ConnectionString = "server =" & host & "; user id = " & uname & "; password = " & pwd & "; database =" & dbname & ""
            Try
                ' open connection
                con.Open()
                MessageBox.Show("Connected")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Public Sub SaveRecord()
        Dim fname, lname, course As String
        fname = Form1.txtfname.Text
        lname = Form1.txtlname.Text
        course = Form1.txtcourse.Text
        sqlquery = "INSERT INTO student(studFName,studLName,course) VALUES (@fname, @lname, @course)"
        ' pass the query and connection to sqlcommand
        mysqlcmd = New MySqlCommand(sqlquery, con)
        ' add parameter value
        mysqlcmd.Parameters.AddWithValue("@fname", fname)
        mysqlcmd.Parameters.AddWithValue("@lname", lname)
        mysqlcmd.Parameters.AddWithValue("@course", course)
        Try
            ' execute query commadn
            mysqlcmd.ExecuteNonQuery()
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            TextClear()
        End Try
    End Sub
    Sub TextClear()
        Form1.txtfname.Clear()
        Form1.txtlname.Clear()
        Form1.txtcourse.Clear()
    End Sub
    Public Sub SearchData()
        Dim uid As String
        uid = Form1.txtuserid.Text
        sqlquery = "SELECT * FROM student where studID = @uid "
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd.Parameters.AddWithValue("@uid", uid)

        Try
            reader = mysqlcmd.ExecuteReader()
            If reader.Read Then
                Form1.txtfirst.Text = reader("studFName").ToString()
                Form1.txtlast.Text = reader("studLName").ToString()
                Form1.txtstudcourse.Text = reader("course").ToString()
                Form1.btnupdate.Enabled = True
                Form1.btndelete.Enabled = True
                Form1.txtfirst.Enabled = True
                Form1.txtlast.Enabled = True
                Form1.txtstudcourse.Enabled = True

            Else
                MsgBox("No Record")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try
    End Sub
    Public Sub LoadAllData()
        sqlquery = "SELECT * FROM student"
        adapter = New MySqlDataAdapter(sqlquery, con)
        Try
            ' display record in data grid view
            dtTable = New DataTable
            adapter.Fill(dtTable) ' pass record from mysql to datatable
            With Form2.dgvdata
                .DataSource = dtTable
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub DisplayAllData(kurso As String)
        sqlquery = "SELECT * FROM student where course= @kurso"
        adapter = New MySqlDataAdapter(sqlquery, con)
        adapter.SelectCommand.Parameters.AddWithValue("@kurso", kurso)
        Try
            ' display record in data grid view
            dtTable = New DataTable
            adapter.Fill(dtTable) ' pass record from mysql to datatable
            With Form2.dgvdata
                .DataSource = dtTable
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub updaterecord(studID As String, fname As String, lname As String, course As String)
        sqlquery = "UPDATE student set studFName=@fname, studLName=@lname, course=@course where studID=@studID"
        Try
            Using cmd As New MySqlCommand(sqlquery, con)
                cmd.Parameters.AddWithValue("@fname", fname)
                cmd.Parameters.AddWithValue("@lname", lname)
                cmd.Parameters.AddWithValue("@course", course)
                cmd.Parameters.AddWithValue("@stuidID", studID)
                cmd.ExecuteNonQuery()
                MsgBox("Update Success", vbInformation, "Update Message")
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        Finally
            Form1.txtfirst.Clear()
            Form1.txtlast.Clear()
            Form1.txtstudcourse.Clear()
            Form1.txtuserid.Clear()

        End Try

    End Sub
    Public Sub deleterecord(studid As String)
        sqlquery = "DELETE FROM student where studID=@studID"
        Try
            Using cmd As New MySqlCommand(sqlquery, con)
                cmd.Parameters.AddWithValue("@stuidID", studid)
                cmd.ExecuteNonQuery()
                MsgBox("Delete Success", vbInformation, "delete Message")
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        Finally
            Form1.txtfirst.Clear()
            Form1.txtlast.Clear()
            Form1.txtstudcourse.Clear()
            Form1.txtuserid.Clear()

        End Try
    End Sub
End Module
