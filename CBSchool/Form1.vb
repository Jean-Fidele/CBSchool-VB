Imports System.Data.OleDb
Public Class Form1

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        cn.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        PasswordTextBox.Clear()
        c.Clear()

        Dim ctr, i As Integer
        ds.Clear()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Module1.conn()
        cn.Open()
        str = "select * from Users"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Users")
        ctr = ds.Tables("Users").Rows.Count - 1
        For i = 0 To ctr
            ComboBox1.Items.Add(ds.Tables("Users").Rows(i)(1).ToString)
        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        c.Text = ComboBox1.Text

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim ctr, i As Integer
        Dim che As Integer = 0
        Dim emp As String = ""
        ds.Clear()
        'cn.Open()
        str = "select * from Users"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Users")
        ctr = ds.Tables("Users").Rows.Count - 1

        For i = 0 To ctr
            If ds.Tables("Users").Rows(i)(1).ToString = c.Text And ds.Tables("Users").Rows(i)(2).ToString = PasswordTextBox.Text Then
                che = 1
                emp = ds.Tables("Users").Rows(i)(3).ToString
            End If
        Next

        '...............

        If che = 1 Then
            cn.Close()

            If emp = "ADMIN" Then

            ElseIf emp = "TEACHING STAFF" Then
                ' Home.StaffToolStripMenuItem.Visible = False
                ' Home.FeesToolStripMenuItem.Visible = False
                'Home.AccountsToolStripMenuItem.Visible = False
                ' Home.UserToolStripMenuItem.Visible = False
                ' Home.PaymentsToolStripMenuItem.Visible = False
            ElseIf emp = "NON TEACHING STAFF" Then
                ' Home.StudentToolStripMenuItem.Visible = False
                ' Home.ClassToolStripMenuItem.Visible = False
                'Home.StaffToolStripMenuItem.Visible = False
                'Home.ExamToolStripMenuItem.Visible = False
                ' Home.SubjectToolStripMenuItem.Visible = False
                ' Home.UserToolStripMenuItem.Visible = False
            End If
            Home.Button1.Text = ComboBox1.Text & " - Logout"
            Home.Show()
            Me.Hide()
            ComboBox1.ResetText()
            c.Clear()
            PasswordTextBox.Clear()
        Else
            MsgBox("Password Incorect for Selected User.")
        End If

    End Sub
End Class
