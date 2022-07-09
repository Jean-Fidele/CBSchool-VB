Imports System.Windows.Forms
Public Class Home

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
        Timer1.Start()

    End Sub

    Private Sub Home_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As Integer = MsgBox("Do You Really Want To Logout The Application.?", MsgBoxStyle.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Timer1.Stop()
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentToolStripMenuItem.Click
        'StudRegister.MdiParent = Me
        StudRegister.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
    End Sub

    Private Sub StudentDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentDetailsToolStripMenuItem.Click
        Stud_Details.Show()

    End Sub

    Private Sub UpdateStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateStudentToolStripMenuItem.Click
        Stud_Update.Show()

    End Sub

    Private Sub AddClassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddClassToolStripMenuItem.Click
        Add_Class.Show()

    End Sub

    Private Sub AddFeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFeesToolStripMenuItem.Click
        Fees_Add.Show()

    End Sub

    Private Sub CollectFessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollectFessToolStripMenuItem.Click
        Fees_Details.Show()

    End Sub

    Private Sub CollectFeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollectFeesToolStripMenuItem.Click
        Fees_Collect.Show()

    End Sub

    Private Sub FeesCollectionDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeesCollectionDetailsToolStripMenuItem.Click
        Fees_Collection_Details.Show()

    End Sub

    Private Sub AddExamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddExamToolStripMenuItem.Click
        Add_Exam.Show()

    End Sub

    Private Sub AddExamMarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddExamMarksToolStripMenuItem.Click
        Add_Exam_Marks.Show()

    End Sub

    Private Sub AddStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStaffToolStripMenuItem.Click
        Add_Staff.Show()

    End Sub

    Private Sub StaffDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffDetailsToolStripMenuItem.Click
        Staff_Details.Show()

    End Sub

    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        Add_User.Show()

    End Sub

    Private Sub UpdateUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateUserToolStripMenuItem.Click
        Update_User.Show()

    End Sub

    Private Sub DetailsUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsUserToolStripMenuItem.Click
        Details_User.Show()

    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserToolStripMenuItem.Click
        Delete_User.Show()

    End Sub

    Private Sub AddSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSubjectToolStripMenuItem.Click
        Add_Subject.Show()

    End Sub

    Private Sub SubjectDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectDetailsToolStripMenuItem.Click

    End Sub

    Private Sub PaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentToolStripMenuItem.Click

    End Sub

    Private Sub StaffPaymentsDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffPaymentsDetailsToolStripMenuItem.Click
        'Staff_Payment.Show()

    End Sub
End Class