Imports System.Data.OleDb
Public Class Fees_Add
    Dim LastNo As Integer

    Private Sub Fees_Add_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        cn.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cn.Close()
        Me.Close()

    End Sub

    Private Sub Fees_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ds.Clear()

        DateTimePicker1.Value = DateTime.Now
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Module1.conn()
        cn.Open()

        'cn.Open()
        str = "select * from Fees"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Fees")

        LastNo = ds.Tables("Fees").Rows.Count + 1
        If LastNo >= 0 Then
            TextBox1.Text = "FID" & LastNo
        Else
            TextBox1.Text = "FID" & 0
        End If
        'cn.Close()

        Dim ctr As Integer
        'cn.Open()
        str = "select * from Class"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Class")
        ctr = ds.Tables("Class").Rows.Count - 1
        For i = 0 To ctr
            CheckedListBox1.Items.Add(ds.Tables("Class").Rows(i)(1).ToString)
        Next
        'cn.Close()

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim er As Integer = 0
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            er = 1
            MsgBox("Please Fill All The Detail's.")
        End If

        'insert
        If er = 0 Then
            Try

                For i = 0 To CheckedListBox1.CheckedItems.Count - 1

                    If CheckedListBox1.GetItemCheckState(i) = CheckState.Checked Then
                        If LastNo >= 0 Then
                            TextBox1.Text = "FID" & LastNo
                        Else
                            TextBox1.Text = "FID" & 0
                        End If
                        cmd.Connection = cn
                        'cmd.CommandText = "insert into ExamSubject(ESID,EID,Subject) values('" & x & "','" & TextBox1.Text & "','" & CheckedListBox1.CheckedItems(i).ToString & "')"
                        cmd.CommandText = "insert into Fees(FID,FDate,FeesFor,Amount,PartPayment,Description,Class) values('" & TextBox1.Text & "','" & DateTimePicker1.Text & "','" & TextBox3.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & CheckedListBox1.CheckedItems(i).ToString & "')"
                        cmd.ExecuteNonQuery()
                        LastNo = LastNo + 1
                    End If
                Next
                Dim result As Integer = MessageBox.Show("New Fees Term Added. Want To Add Another One.", "Added", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    Me.Close()
                ElseIf result = DialogResult.Yes Then
                    ds.Clear()
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    ComboBox1.ResetText()

                    str = "select * from Fees"
                    cmd = New OleDbCommand(str, cn)
                    da.SelectCommand = cmd
                    da.Fill(ds, "Fees")
                    Dim LastNo As Integer
                    LastNo = ds.Tables("Fees").Rows.Count + 1
                    If LastNo >= 0 Then
                        TextBox1.Text = "FID" & LastNo
                    Else
                        TextBox1.Text = "FID" & 0
                    End If
                End If
            Catch ex As Exception
                MsgBox(" Fees Detail Not Added.")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                ComboBox1.ResetText()
            End Try
            'insert closed
        End If
        'cn.Close()

    End Sub
End Class