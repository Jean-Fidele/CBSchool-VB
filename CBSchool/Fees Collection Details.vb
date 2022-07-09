﻿Imports System.Data.OleDb
Public Class Fees_Collection_Details


    Dim cond As Integer
    Dim sname, sclass, regno, remain As String
    Dim che As Integer
    Private Sub Fees_Collection_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Clear()
        ' Module1.conn()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Module1.conn()
        cn.Open()

        cond = 0
        Dim ctr, i As Integer
        ds.Clear()
        str = "select * from Student ORDER BY RegNo ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Student")
        ctr = ds.Tables("Student").Rows.Count - 1
        For i = 0 To ctr
            ComboBox1.Items.Add(ds.Tables("Student").Rows(i)(0).ToString)
        Next

        ds.Clear()
        ComboBox2.Items.Add("ALL")
        str = "select * from Student ORDER BY RegNo ASC"
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

        ds.Clear()
        str = "select * from FeesCollection ORDER BY FID ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "FeesCollection")
        ctr = ds.Tables("FeesCollection").Rows.Count - 1
        For i = 0 To ctr
            DataGridView1.Rows.Add(ds.Tables("FeesCollection").Rows(i)(0).ToString, ds.Tables("FeesCollection").Rows(i)(1).ToString, ds.Tables("FeesCollection").Rows(i)(2).ToString, ds.Tables("FeesCollection").Rows(i)(4).ToString, ds.Tables("FeesCollection").Rows(i)(3).ToString, ds.Tables("FeesCollection").Rows(i)(7).ToString, ds.Tables("FeesCollection").Rows(i)(6).ToString, ds.Tables("FeesCollection").Rows(i)(5).ToString)
        Next

        sname = "ALL"
        sclass = "ALL"
        regno = "ALL"
        remain = "N/A"
        che = 1

    End Sub
    Private Sub Fees_Collection_Details_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        cn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox1.Text = "Select"
        ComboBox2.Text = "Select"
        ComboBox3.Text = "Select"
        TextBox1.Visible = False
        Label1.Visible = False
        DataGridView1.Rows.Clear()

        cond = 0
        Dim ctr, i As Integer

        ds.Clear()
        str = "select * from Student ORDER BY RegNo ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Student")
        ctr = ds.Tables("Student").Rows.Count - 1
        For i = 0 To ctr
            ComboBox1.Items.Add(ds.Tables("Student").Rows(i)(0).ToString)
        Next

        ds.Clear()
        str = "select * from Student ORDER BY RegNo ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Student")
        ctr = ds.Tables("Student").Rows.Count - 1
        For i = 0 To ctr
            ComboBox2.Items.Add(ds.Tables("Student").Rows(i)(1).ToString)
        Next

        ds.Clear()
        str = "select * from Class ORDER BY CID ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Class")
        ctr = ds.Tables("Class").Rows.Count - 1
        For i = 0 To ctr
            ComboBox3.Items.Add(ds.Tables("Class").Rows(i)(1).ToString)
        Next

        ds.Clear()
        str = "select * from FeesCollection ORDER BY FID ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "FeesCollection")
        ctr = ds.Tables("FeesCollection").Rows.Count - 1
        For i = 0 To ctr
            DataGridView1.Rows.Add(ds.Tables("FeesCollection").Rows(i)(0).ToString, ds.Tables("FeesCollection").Rows(i)(1).ToString, ds.Tables("FeesCollection").Rows(i)(2).ToString, ds.Tables("FeesCollection").Rows(i)(4).ToString, ds.Tables("FeesCollection").Rows(i)(3).ToString, ds.Tables("FeesCollection").Rows(i)(7).ToString, ds.Tables("FeesCollection").Rows(i)(6).ToString, ds.Tables("FeesCollection").Rows(i)(5).ToString)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        regno = ComboBox1.Text
        Dim ctr, i, va As Integer
        Dim ca As String
        ca = ""
        cond = 1
        TextBox1.Visible = True
        Label1.Visible = True
        DataGridView1.Rows.Clear()
        'ComboBox2.Text = "Select"
        'ComboBox3.Text = "Select"

        ds.Clear()
        str = "select * from FeesCollection where RegNo = '" & ComboBox1.Text & "' ORDER BY FID ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "FeesCollection")
        ctr = ds.Tables("FeesCollection").Rows.Count - 1
        For i = 0 To ctr
            DataGridView1.Rows.Add(ds.Tables("FeesCollection").Rows(i)(0).ToString, ds.Tables("FeesCollection").Rows(i)(1).ToString, ds.Tables("FeesCollection").Rows(i)(2).ToString, ds.Tables("FeesCollection").Rows(i)(4).ToString, ds.Tables("FeesCollection").Rows(i)(3).ToString, ds.Tables("FeesCollection").Rows(i)(7).ToString, ds.Tables("FeesCollection").Rows(i)(6).ToString, ds.Tables("FeesCollection").Rows(i)(5).ToString)
        Next

        ds.Clear()
        str = "select * from FeesCollection where RegNo = '" & ComboBox1.Text & "' ORDER BY FID ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "FeesCollection")
        ctr = ds.Tables("FeesCollection").Rows.Count - 1
        For i = 0 To ctr
            ca = ds.Tables("FeesCollection").Rows(0)(3).ToString
            va = Val(ds.Tables("FeesCollection").Rows(i)(5).ToString)
        Next

        ds.Clear()
        str = "select * from Student where RegNo = '" & ComboBox1.Text & "' ORDER BY RegNo ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Student")
        ctr = ds.Tables("Student").Rows.Count - 1
        For i = 0 To ctr
            ComboBox2.Text = ds.Tables("Student").Rows(i)(1).ToString
            ComboBox3.Text = ds.Tables("Student").Rows(i)(18).ToString
        Next

        ds.Clear()
        Dim su As Integer = 0
        str = "select * from Fees where Class = '" & ca & "' ORDER BY FID ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Fees")
        ctr = ds.Tables("Fees").Rows.Count - 1
        For i = 0 To ctr
            su = su + Val(ds.Tables("Fees").Rows(i)(3).ToString)
        Next
        TextBox1.Text = su - va
        'End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        sname = ComboBox2.Text
        Dim ctr, i As Integer
        ds.Clear()
        str = "select * from Student where StudName = '" & ComboBox2.Text & "' ORDER BY RegNo ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Student")
        ctr = ds.Tables("Student").Rows.Count - 1
        For i = 0 To ctr
            ComboBox1.Text = ds.Tables("Student").Rows(i)(0).ToString
            'ComboBox3.Text = ds.Tables("Student").Rows(i)(18).ToString
        Next
        cond = 1
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        sclass = ComboBox3.Text
        Dim ctr, i As Integer
        If cond = 2 Or cond = 0 Then
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox1.Text = "Select"
            ComboBox2.Text = "Select"
            TextBox1.Visible = False
            Label1.Visible = False
            DataGridView1.Rows.Clear()

            ds.Clear()
            str = "select * from Student where AdmitedTo = '" & ComboBox3.Text & "' ORDER BY RegNo ASC"
            cmd = New OleDbCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, "Student")
            ctr = ds.Tables("Student").Rows.Count - 1
            For i = 0 To ctr
                ComboBox1.Items.Add(ds.Tables("Student").Rows(i)(0).ToString)
            Next

            ds.Clear()
            str = "select * from Student where AdmitedTo = '" & ComboBox3.Text & "' ORDER BY RegNo ASC"
            cmd = New OleDbCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, "Student")
            ctr = ds.Tables("Student").Rows.Count - 1
            For i = 0 To ctr
                ComboBox2.Items.Add(ds.Tables("Student").Rows(i)(1).ToString)
            Next

            ds.Clear()
            str = "select * from FeesCollection where Class = '" & ComboBox3.Text & "' ORDER BY FID ASC"
            cmd = New OleDbCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, "FeesCollection")
            ctr = ds.Tables("FeesCollection").Rows.Count - 1
            For i = 0 To ctr
                DataGridView1.Rows.Add(ds.Tables("FeesCollection").Rows(i)(0).ToString, ds.Tables("FeesCollection").Rows(i)(1).ToString, ds.Tables("FeesCollection").Rows(i)(2).ToString, ds.Tables("FeesCollection").Rows(i)(4).ToString, ds.Tables("FeesCollection").Rows(i)(3).ToString, ds.Tables("FeesCollection").Rows(i)(7).ToString, ds.Tables("FeesCollection").Rows(i)(6).ToString, ds.Tables("FeesCollection").Rows(i)(5).ToString)
            Next
        End If
        cond = 2
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        remain = TextBox1.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class