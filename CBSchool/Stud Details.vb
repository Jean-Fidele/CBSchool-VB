Imports System.Data.OleDb
Imports System.IO
Public Class Stud_Details
    Dim cond, ph As Integer
    Dim dr As OleDbDataReader
    Dim Photos1() As Byte


    Private Sub Stud_Details_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        cn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Stud_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Clear()
        ph = 1
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Module1.conn()
        cn.Open()
        cond = 0
        Dim ctr, i As Integer


        ds.Clear()
        str = "select * from Student"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Student")
        ctr = ds.Tables("Student").Rows.Count - 1
        For i = 0 To ctr
            ComboBox1.Items.Add(ds.Tables("Student").Rows(i)(0).ToString)
        Next


        ds.Clear()
        str = "select * from Student"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Student")
        ctr = ds.Tables("Student").Rows.Count - 1
        For i = 0 To ctr
            ComboBox2.Items.Add(ds.Tables("Student").Rows(i)(1).ToString)
        Next



        ds.Clear()
        str = "select * from Class"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Class")
        ctr = ds.Tables("Class").Rows.Count - 1
        For i = 0 To ctr
            ComboBox3.Items.Add(ds.Tables("Class").Rows(i)(1).ToString)
        Next

        For i = 0 To 100
            File.Delete("photo" & i & ".jpg")
        Next


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim ctr, i As Integer
        cond = 1
        ds.Clear()
        str = "select * from Student where RegNo = '" & ComboBox1.Text & "'"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Student")
        ctr = ds.Tables("Student").Rows.Count - 1


        For i = 0 To ctr
            TextBox1.Text = ds.Tables("Student").Rows(i)(2).ToString
            TextBox2.Text = ds.Tables("Student").Rows(i)(14).ToString
            TextBox3.Text = ds.Tables("Student").Rows(i)(4).ToString
            TextBox4.Text = ds.Tables("Student").Rows(i)(6).ToString
            TextBox5.Text = ds.Tables("Student").Rows(i)(7).ToString
            TextBox6.Text = ds.Tables("Student").Rows(i)(8).ToString
            TextBox7.Text = ds.Tables("Student").Rows(i)(10).ToString
            TextBox8.Text = ds.Tables("Student").Rows(i)(9).ToString
            TextBox9.Text = ds.Tables("Student").Rows(i)(11).ToString
            TextBox10.Text = ds.Tables("Student").Rows(i)(13).ToString
            TextBox11.Text = ds.Tables("Student").Rows(i)(12).ToString
            TextBox12.Text = ds.Tables("Student").Rows(i)(16).ToString
            TextBox13.Text = ds.Tables("Student").Rows(i)(17).ToString
            TextBox14.Text = ds.Tables("Student").Rows(i)(5).ToString
            TextBox15.Text = ds.Tables("Student").Rows(i)(3).ToString
            TextBox16.Text = ds.Tables("Student").Rows(i)(15).ToString
        Next
        PictureBox1.Image = PictureBox1.InitialImage


        'Select Student Photo
        cmd = New OleDbCommand
        cmd.CommandText = "select SID,SName,StudImage from Photo where SID = " & ComboBox1.Text & ""
        cmd.Parameters.AddWithValue("@SID", ComboBox1.Text)
        cmd.Connection = cn
        dr = cmd.ExecuteReader
        Dim pho As String

        pho = "photo" & ph & ".jpg"
        If dr.Read() Then
            Photos1 = dr(2)
            File.WriteAllBytes(pho, Photos1)
            PictureBox1.Load(pho)
            ph = ph + 1

        End If


        ds.Clear()
        str = "select * from Student where RegNo = '" & ComboBox1.Text & "'"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Student")
        ctr = ds.Tables("Student").Rows.Count - 1
        For i = 0 To ctr
            ComboBox2.SelectedItem = ds.Tables("Student").Rows(i)(1).ToString
            ComboBox3.SelectedItem = ds.Tables("Student").Rows(i)(18).ToString
            ComboBox4.Text = ds.Tables("Student").Rows(i)(19).ToString
        Next
        cond = 0

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim ctr, i As Integer

        If cond = 0 Then
            'cond = 2
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox4.Items.Clear()
            ComboBox1.Text = "Select"
            ComboBox2.Text = "Select"
            ComboBox4.Text = "Select"

            ds.Clear()
            str = "select * from Student where AdmitedTo = '" & ComboBox3.Text & "'"
            cmd = New OleDbCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, "Student")
            ctr = ds.Tables("Student").Rows.Count - 1
            For i = 0 To ctr
                ComboBox1.Items.Add(ds.Tables("Student").Rows(i)(0).ToString)
                ComboBox2.Items.Add(ds.Tables("Student").Rows(i)(1).ToString)
                ComboBox4.Items.Add(ds.Tables("Student").Rows(i)(19).ToString)
            Next
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim ctr, i As Integer

        'If cond = 0 Or cond = 2 Then
        '    cond = 4
        ds.Clear()
        str = "select * from Student where RollNo = '" & ComboBox4.Text & "' and AdmitedTo = '" & ComboBox3.Text & "'"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Student")
        ctr = ds.Tables("Student").Rows.Count - 1
        For i = 0 To ctr
            ComboBox1.SelectedItem = ds.Tables("Student").Rows(i)(0).ToString
        Next
        'End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cond = 0
        Dim ctr, i As Integer
        PictureBox1.Image = PictureBox1.InitialImage
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox1.Text = "Select"
        ComboBox2.Text = "Select"
        ComboBox3.Text = "Select"
        ComboBox4.Text = "Select"
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()

        ds.Clear()
        str = "select * from Student"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Student")
        ctr = ds.Tables("Student").Rows.Count - 1
        For i = 0 To ctr
            ComboBox1.Items.Add(ds.Tables("Student").Rows(i)(0).ToString)
        Next

        ds.Clear()
        str = "select * from Student"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Student")
        ctr = ds.Tables("Student").Rows.Count - 1
        For i = 0 To ctr
            ComboBox2.Items.Add(ds.Tables("Student").Rows(i)(1).ToString)
        Next

        ds.Clear()
        str = "select * from Class"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Class")
        ctr = ds.Tables("Class").Rows.Count - 1
        For i = 0 To ctr
            ComboBox3.Items.Add(ds.Tables("Class").Rows(i)(1).ToString)
        Next

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim ctr, i As Integer

        'If cond = 0 Or cond = 2 Then
        '    cond = 3
        ds.Clear()
        str = "select * from Student where StudName = '" & ComboBox2.Text & "'"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Student")
        ctr = ds.Tables("Student").Rows.Count - 1
        For i = 0 To ctr
            ComboBox1.SelectedItem = ds.Tables("Student").Rows(i)(0).ToString
        Next
        'End If
    End Sub
End Class