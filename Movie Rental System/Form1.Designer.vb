<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MovieTitleTextBox = New TextBox()
        RentalAmountTextBox = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        DVDRadioBtn = New RadioButton()
        VHSRadioBtn = New RadioButton()
        Label2 = New Label()
        MemberCheckBox = New CheckBox()
        NewReleaseCheckBox = New CheckBox()
        CalculateBtn = New Button()
        ClearBtn = New Button()
        OrderCompleteBtn = New Button()
        ExitBtn = New Button()
        SummaryBtn = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MovieTitleTextBox
        ' 
        MovieTitleTextBox.Location = New Point(111, 17)
        MovieTitleTextBox.Name = "MovieTitleTextBox"
        MovieTitleTextBox.Size = New Size(278, 23)
        MovieTitleTextBox.TabIndex = 0
        ' 
        ' RentalAmountTextBox
        ' 
        RentalAmountTextBox.Location = New Point(111, 66)
        RentalAmountTextBox.Name = "RentalAmountTextBox"
        RentalAmountTextBox.ReadOnly = True
        RentalAmountTextBox.Size = New Size(147, 23)
        RentalAmountTextBox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 2
        Label1.Text = "Movie Title:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DVDRadioBtn)
        GroupBox1.Controls.Add(VHSRadioBtn)
        GroupBox1.Location = New Point(404, 17)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(98, 76)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Movie Format"
        ' 
        ' DVDRadioBtn
        ' 
        DVDRadioBtn.AutoSize = True
        DVDRadioBtn.Location = New Point(16, 47)
        DVDRadioBtn.Name = "DVDRadioBtn"
        DVDRadioBtn.Size = New Size(48, 19)
        DVDRadioBtn.TabIndex = 1
        DVDRadioBtn.TabStop = True
        DVDRadioBtn.Text = "DVD"
        DVDRadioBtn.UseVisualStyleBackColor = True
        ' 
        ' VHSRadioBtn
        ' 
        VHSRadioBtn.AutoSize = True
        VHSRadioBtn.Location = New Point(16, 22)
        VHSRadioBtn.Name = "VHSRadioBtn"
        VHSRadioBtn.Size = New Size(47, 19)
        VHSRadioBtn.TabIndex = 0
        VHSRadioBtn.TabStop = True
        VHSRadioBtn.Text = "VHS"
        VHSRadioBtn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 15)
        Label2.TabIndex = 4
        Label2.Text = "Rental Amount:"
        ' 
        ' MemberCheckBox
        ' 
        MemberCheckBox.AutoSize = True
        MemberCheckBox.Location = New Point(523, 39)
        MemberCheckBox.Name = "MemberCheckBox"
        MemberCheckBox.Size = New Size(71, 19)
        MemberCheckBox.TabIndex = 5
        MemberCheckBox.Text = "Member"
        MemberCheckBox.UseVisualStyleBackColor = True
        ' 
        ' NewReleaseCheckBox
        ' 
        NewReleaseCheckBox.AutoSize = True
        NewReleaseCheckBox.Location = New Point(523, 65)
        NewReleaseCheckBox.Name = "NewReleaseCheckBox"
        NewReleaseCheckBox.Size = New Size(92, 19)
        NewReleaseCheckBox.TabIndex = 6
        NewReleaseCheckBox.Text = "New Release"
        NewReleaseCheckBox.UseVisualStyleBackColor = True
        ' 
        ' CalculateBtn
        ' 
        CalculateBtn.Location = New Point(12, 126)
        CalculateBtn.Name = "CalculateBtn"
        CalculateBtn.Size = New Size(138, 48)
        CalculateBtn.TabIndex = 7
        CalculateBtn.Text = "Calculate"
        CalculateBtn.UseVisualStyleBackColor = True
        ' 
        ' ClearBtn
        ' 
        ClearBtn.Location = New Point(170, 126)
        ClearBtn.Name = "ClearBtn"
        ClearBtn.Size = New Size(138, 48)
        ClearBtn.TabIndex = 8
        ClearBtn.Text = "Clear"
        ClearBtn.UseVisualStyleBackColor = True
        ' 
        ' OrderCompleteBtn
        ' 
        OrderCompleteBtn.Location = New Point(329, 126)
        OrderCompleteBtn.Name = "OrderCompleteBtn"
        OrderCompleteBtn.Size = New Size(138, 48)
        OrderCompleteBtn.TabIndex = 9
        OrderCompleteBtn.Text = "Order Complete"
        OrderCompleteBtn.UseVisualStyleBackColor = True
        ' 
        ' ExitBtn
        ' 
        ExitBtn.BackColor = SystemColors.ControlLightLight
        ExitBtn.Location = New Point(146, 194)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(344, 54)
        ExitBtn.TabIndex = 10
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = False
        ' 
        ' SummaryBtn
        ' 
        SummaryBtn.Location = New Point(477, 126)
        SummaryBtn.Name = "SummaryBtn"
        SummaryBtn.Size = New Size(138, 48)
        SummaryBtn.TabIndex = 11
        SummaryBtn.Text = "Summary"
        SummaryBtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(643, 276)
        Controls.Add(SummaryBtn)
        Controls.Add(ExitBtn)
        Controls.Add(OrderCompleteBtn)
        Controls.Add(ClearBtn)
        Controls.Add(CalculateBtn)
        Controls.Add(NewReleaseCheckBox)
        Controls.Add(MemberCheckBox)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(RentalAmountTextBox)
        Controls.Add(MovieTitleTextBox)
        Name = "Form1"
        Text = "Movie Rental System"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MovieTitleTextBox As TextBox
    Friend WithEvents RentalAmountTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DVDRadioBtn As RadioButton
    Friend WithEvents VHSRadioBtn As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents MemberCheckBox As CheckBox
    Friend WithEvents NewReleaseCheckBox As CheckBox
    Friend WithEvents CalculateBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents OrderCompleteBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents SummaryBtn As Button
End Class
