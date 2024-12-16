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
        lblStudentIDPrompt = New Label()
        txtStudentID = New TextBox()
        btnCheckStatus = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' lblStudentIDPrompt
        ' 
        lblStudentIDPrompt.AutoSize = True
        lblStudentIDPrompt.Location = New Point(5, 14)
        lblStudentIDPrompt.Name = "lblStudentIDPrompt"
        lblStudentIDPrompt.Size = New Size(120, 20)
        lblStudentIDPrompt.TabIndex = 0
        lblStudentIDPrompt.Text = "Enter Student ID:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(128, 15)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(137, 27)
        txtStudentID.TabIndex = 1
        ' 
        ' btnCheckStatus
        ' 
        btnCheckStatus.Location = New Point(14, 58)
        btnCheckStatus.Name = "btnCheckStatus"
        btnCheckStatus.Size = New Size(250, 33)
        btnCheckStatus.TabIndex = 2
        btnCheckStatus.Text = "Check_Status"
        btnCheckStatus.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(8, 107)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(49, 20)
        lblResult.TabIndex = 3
        lblResult.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(btnCheckStatus)
        Controls.Add(txtStudentID)
        Controls.Add(lblStudentIDPrompt)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblStudentIDPrompt As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents btnCheckStatus As Button
    Friend WithEvents lblResult As Label

End Class
