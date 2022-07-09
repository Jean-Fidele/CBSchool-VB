<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StuffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddExamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddExamMarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllExamDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentMarkDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollectFessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollectFeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeesCollectionDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffPaymentsDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllPaymentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllPaymentDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(888, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem, Me.ClassToolStripMenuItem, Me.StuffToolStripMenuItem, Me.ExamToolStripMenuItem, Me.FeesToolStripMenuItem, Me.UserToolStripMenuItem, Me.SubjectToolStripMenuItem, Me.PaymentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1048, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStudentToolStripMenuItem, Me.StudentDetailsToolStripMenuItem, Me.UpdateStudentToolStripMenuItem})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(76, 25)
        Me.StudentToolStripMenuItem.Text = "&Student"
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.AddStudentToolStripMenuItem.Text = "&Add Student"
        '
        'StudentDetailsToolStripMenuItem
        '
        Me.StudentDetailsToolStripMenuItem.Name = "StudentDetailsToolStripMenuItem"
        Me.StudentDetailsToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.StudentDetailsToolStripMenuItem.Text = "&Student Details"
        '
        'UpdateStudentToolStripMenuItem
        '
        Me.UpdateStudentToolStripMenuItem.Name = "UpdateStudentToolStripMenuItem"
        Me.UpdateStudentToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.UpdateStudentToolStripMenuItem.Text = "&Update Student"
        '
        'ClassToolStripMenuItem
        '
        Me.ClassToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddClassToolStripMenuItem, Me.ClassDetailsToolStripMenuItem})
        Me.ClassToolStripMenuItem.Name = "ClassToolStripMenuItem"
        Me.ClassToolStripMenuItem.Size = New System.Drawing.Size(58, 25)
        Me.ClassToolStripMenuItem.Text = "&Class"
        '
        'AddClassToolStripMenuItem
        '
        Me.AddClassToolStripMenuItem.Name = "AddClassToolStripMenuItem"
        Me.AddClassToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.AddClassToolStripMenuItem.Text = "&Add Class"
        '
        'ClassDetailsToolStripMenuItem
        '
        Me.ClassDetailsToolStripMenuItem.Name = "ClassDetailsToolStripMenuItem"
        Me.ClassDetailsToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.ClassDetailsToolStripMenuItem.Text = "&Class Details"
        '
        'StuffToolStripMenuItem
        '
        Me.StuffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStaffToolStripMenuItem, Me.StaffDetailsToolStripMenuItem})
        Me.StuffToolStripMenuItem.Name = "StuffToolStripMenuItem"
        Me.StuffToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.StuffToolStripMenuItem.Text = "Staff"
        '
        'AddStaffToolStripMenuItem
        '
        Me.AddStaffToolStripMenuItem.Name = "AddStaffToolStripMenuItem"
        Me.AddStaffToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.AddStaffToolStripMenuItem.Text = "Add Staff"
        '
        'StaffDetailsToolStripMenuItem
        '
        Me.StaffDetailsToolStripMenuItem.Name = "StaffDetailsToolStripMenuItem"
        Me.StaffDetailsToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.StaffDetailsToolStripMenuItem.Text = "Staff Details"
        '
        'ExamToolStripMenuItem
        '
        Me.ExamToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddExamToolStripMenuItem, Me.AddExamMarksToolStripMenuItem, Me.ExamDetailsToolStripMenuItem, Me.AllExamDetailsToolStripMenuItem, Me.StudentMarkDetailsToolStripMenuItem})
        Me.ExamToolStripMenuItem.Name = "ExamToolStripMenuItem"
        Me.ExamToolStripMenuItem.Size = New System.Drawing.Size(59, 25)
        Me.ExamToolStripMenuItem.Text = "Exam"
        '
        'AddExamToolStripMenuItem
        '
        Me.AddExamToolStripMenuItem.Name = "AddExamToolStripMenuItem"
        Me.AddExamToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.AddExamToolStripMenuItem.Text = "Add Exam"
        '
        'AddExamMarksToolStripMenuItem
        '
        Me.AddExamMarksToolStripMenuItem.Name = "AddExamMarksToolStripMenuItem"
        Me.AddExamMarksToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.AddExamMarksToolStripMenuItem.Text = "Add Exam Marks"
        '
        'ExamDetailsToolStripMenuItem
        '
        Me.ExamDetailsToolStripMenuItem.Name = "ExamDetailsToolStripMenuItem"
        Me.ExamDetailsToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.ExamDetailsToolStripMenuItem.Text = "Exam Details"
        '
        'AllExamDetailsToolStripMenuItem
        '
        Me.AllExamDetailsToolStripMenuItem.Name = "AllExamDetailsToolStripMenuItem"
        Me.AllExamDetailsToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.AllExamDetailsToolStripMenuItem.Text = "All Exam details"
        '
        'StudentMarkDetailsToolStripMenuItem
        '
        Me.StudentMarkDetailsToolStripMenuItem.Name = "StudentMarkDetailsToolStripMenuItem"
        Me.StudentMarkDetailsToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.StudentMarkDetailsToolStripMenuItem.Text = "Student Mark Details"
        '
        'FeesToolStripMenuItem
        '
        Me.FeesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFeesToolStripMenuItem, Me.CollectFessToolStripMenuItem, Me.CollectFeesToolStripMenuItem, Me.FeesCollectionDetailsToolStripMenuItem})
        Me.FeesToolStripMenuItem.Name = "FeesToolStripMenuItem"
        Me.FeesToolStripMenuItem.Size = New System.Drawing.Size(53, 25)
        Me.FeesToolStripMenuItem.Text = "Fees"
        '
        'AddFeesToolStripMenuItem
        '
        Me.AddFeesToolStripMenuItem.Name = "AddFeesToolStripMenuItem"
        Me.AddFeesToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.AddFeesToolStripMenuItem.Text = "Add Fees"
        '
        'CollectFessToolStripMenuItem
        '
        Me.CollectFessToolStripMenuItem.Name = "CollectFessToolStripMenuItem"
        Me.CollectFessToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.CollectFessToolStripMenuItem.Text = "Fees Details"
        '
        'CollectFeesToolStripMenuItem
        '
        Me.CollectFeesToolStripMenuItem.Name = "CollectFeesToolStripMenuItem"
        Me.CollectFeesToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.CollectFeesToolStripMenuItem.Text = "Collect Fees"
        '
        'FeesCollectionDetailsToolStripMenuItem
        '
        Me.FeesCollectionDetailsToolStripMenuItem.Name = "FeesCollectionDetailsToolStripMenuItem"
        Me.FeesCollectionDetailsToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.FeesCollectionDetailsToolStripMenuItem.Text = "Fees Collection Details"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.UpdateUserToolStripMenuItem, Me.DetailsUserToolStripMenuItem, Me.DeleteUserToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.UserToolStripMenuItem.Text = "&User"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'UpdateUserToolStripMenuItem
        '
        Me.UpdateUserToolStripMenuItem.Name = "UpdateUserToolStripMenuItem"
        Me.UpdateUserToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.UpdateUserToolStripMenuItem.Text = "Update User"
        '
        'DetailsUserToolStripMenuItem
        '
        Me.DetailsUserToolStripMenuItem.Name = "DetailsUserToolStripMenuItem"
        Me.DetailsUserToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.DetailsUserToolStripMenuItem.Text = "Details User"
        '
        'DeleteUserToolStripMenuItem
        '
        Me.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        Me.DeleteUserToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.DeleteUserToolStripMenuItem.Text = "Delete User"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 458)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1048, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel1.Text = "Status:"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'Timer1
        '
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CustomFormat = "hh:MM:ss tt"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(912, 460)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(124, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(868, 464)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Time:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(670, 460)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(192, 20)
        Me.DateTimePicker2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(626, 464)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 31.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cyan
        Me.Label3.Location = New System.Drawing.Point(187, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(562, 48)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Student Information System"
        '
        'SubjectToolStripMenuItem
        '
        Me.SubjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSubjectToolStripMenuItem, Me.SubjectDetailsToolStripMenuItem})
        Me.SubjectToolStripMenuItem.Name = "SubjectToolStripMenuItem"
        Me.SubjectToolStripMenuItem.Size = New System.Drawing.Size(73, 25)
        Me.SubjectToolStripMenuItem.Text = "Subject"
        '
        'AddSubjectToolStripMenuItem
        '
        Me.AddSubjectToolStripMenuItem.Name = "AddSubjectToolStripMenuItem"
        Me.AddSubjectToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.AddSubjectToolStripMenuItem.Text = "Add Subject"
        '
        'SubjectDetailsToolStripMenuItem
        '
        Me.SubjectDetailsToolStripMenuItem.Name = "SubjectDetailsToolStripMenuItem"
        Me.SubjectDetailsToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.SubjectDetailsToolStripMenuItem.Text = "Subject Details"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffPaymentsDetailsToolStripMenuItem, Me.AllPaymentDetailsToolStripMenuItem, Me.AllPaymentDetailsToolStripMenuItem1})
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(90, 25)
        Me.PaymentToolStripMenuItem.Text = "Payments"
        '
        'StaffPaymentsDetailsToolStripMenuItem
        '
        Me.StaffPaymentsDetailsToolStripMenuItem.Name = "StaffPaymentsDetailsToolStripMenuItem"
        Me.StaffPaymentsDetailsToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.StaffPaymentsDetailsToolStripMenuItem.Text = "Staff Payments "
        '
        'AllPaymentDetailsToolStripMenuItem
        '
        Me.AllPaymentDetailsToolStripMenuItem.Name = "AllPaymentDetailsToolStripMenuItem"
        Me.AllPaymentDetailsToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.AllPaymentDetailsToolStripMenuItem.Text = "Staff Payment Details"
        '
        'AllPaymentDetailsToolStripMenuItem1
        '
        Me.AllPaymentDetailsToolStripMenuItem1.Name = "AllPaymentDetailsToolStripMenuItem1"
        Me.AllPaymentDetailsToolStripMenuItem1.Size = New System.Drawing.Size(228, 26)
        Me.AllPaymentDetailsToolStripMenuItem1.Text = "All Payment Details"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 480)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StuffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddExamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddExamMarksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllExamDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentMarkDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddFeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollectFessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollectFeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeesCollectionDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffPaymentsDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllPaymentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllPaymentDetailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
