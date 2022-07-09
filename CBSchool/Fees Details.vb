
Imports System.Data.OleDb
Public Class Fees_Details
    Dim che As Integer
    Private Sub Fees_Details_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        cn.Close()
    End Sub

    Private Sub Fees_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Clear()

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        che = 0
        Module1.conn()
        cn.Open()

        Dim ctr, i As Integer
        'cn.Open()
        str = "select * from Fees ORDER BY FID ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Fees")
        ctr = ds.Tables("Fees").Rows.Count - 1
        For i = 0 To ctr
            DataGridView1.Rows.Add(ds.Tables("Fees").Rows(i)(0).ToString, ds.Tables("Fees").Rows(i)(1).ToString, ds.Tables("Fees").Rows(i)(2).ToString, ds.Tables("Fees").Rows(i)(3).ToString, ds.Tables("Fees").Rows(i)(4).ToString, ds.Tables("Fees").Rows(i)(5).ToString, ds.Tables("Fees").Rows(i)(6).ToString)
        Next
        'cn.Close()

        ds.Clear()
        'cn.Open()
        str = "select * from Class ORDER BY CID ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Class")
        ctr = ds.Tables("Class").Rows.Count - 1
        For i = 0 To ctr
            ComboBox4.Items.Add(ds.Tables("Class").Rows(i)(1).ToString)
        Next
        'cn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ComboBox4.Items.Clear()
        ComboBox3.Text = "Select"
        ComboBox4.Text = "Select"
        DataGridView1.Rows.Clear()
        ds.Clear()
        che = 0
        Dim ctr, i As Integer
        'cn.Open()
        str = "select * from Fees ORDER BY FID ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Fees")
        ctr = ds.Tables("Fees").Rows.Count - 1
        For i = 0 To ctr
            DataGridView1.Rows.Add(ds.Tables("Fees").Rows(i)(0).ToString, ds.Tables("Fees").Rows(i)(1).ToString, ds.Tables("Fees").Rows(i)(2).ToString, ds.Tables("Fees").Rows(i)(3).ToString, ds.Tables("Fees").Rows(i)(4).ToString, ds.Tables("Fees").Rows(i)(5).ToString, ds.Tables("Fees").Rows(i)(6).ToString)
        Next
        'cn.Close()

        ds.Clear()
        'cn.Open()
        str = "select * from Class ORDER BY CID ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Class")
        ctr = ds.Tables("Class").Rows.Count - 1
        For i = 0 To ctr
            ComboBox4.Items.Add(ds.Tables("Class").Rows(i)(1).ToString)
        Next
        'cn.Close()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

        ds.Clear()
        DataGridView1.Rows.Clear()
        'If che = 0 Or che = 4 Or che = 3 Then
        '    che = 3
        ComboBox4.Text = "Select"
        'End If
        Dim ctr, i As Integer
        'cn.Open()
        str = "select * from Fees where PartPayment = '" & ComboBox3.Text & "' ORDER BY FID ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Fees")
        ctr = ds.Tables("Fees").Rows.Count - 1
        For i = 0 To ctr
            DataGridView1.Rows.Add(ds.Tables("Fees").Rows(i)(0).ToString, ds.Tables("Fees").Rows(i)(1).ToString, ds.Tables("Fees").Rows(i)(2).ToString, ds.Tables("Fees").Rows(i)(3).ToString, ds.Tables("Fees").Rows(i)(4).ToString, ds.Tables("Fees").Rows(i)(5).ToString, ds.Tables("Fees").Rows(i)(6).ToString)
        Next
        'cn.Close()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        ComboBox3.Text = "Select"

        ds.Clear()
        DataGridView1.Rows.Clear()

        Dim ctr, i As Integer
        'cn.Open()
        str = "select * from Fees where Class = '" & ComboBox4.Text & "' ORDER BY FID ASC"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Fees")
        ctr = ds.Tables("Fees").Rows.Count - 1
        For i = 0 To ctr
            DataGridView1.Rows.Add(ds.Tables("Fees").Rows(i)(0).ToString, ds.Tables("Fees").Rows(i)(1).ToString, ds.Tables("Fees").Rows(i)(2).ToString, ds.Tables("Fees").Rows(i)(3).ToString, ds.Tables("Fees").Rows(i)(4).ToString, ds.Tables("Fees").Rows(i)(5).ToString, ds.Tables("Fees").Rows(i)(6).ToString)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class