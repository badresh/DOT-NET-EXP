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
        lblAgePrompt = New Label()
        txtAge = New TextBox()
        btnCheckEligibility = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' lblAgePrompt
        ' 
        lblAgePrompt.AutoSize = True
        lblAgePrompt.Location = New Point(10, 5)
        lblAgePrompt.Name = "lblAgePrompt"
        lblAgePrompt.Size = New Size(77, 20)
        lblAgePrompt.TabIndex = 0
        lblAgePrompt.Text = "Enter Age:"
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(93, 6)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(101, 27)
        txtAge.TabIndex = 1
        ' 
        ' btnCheckEligibility
        ' 
        btnCheckEligibility.Location = New Point(72, 56)
        btnCheckEligibility.Name = "btnCheckEligibility"
        btnCheckEligibility.Size = New Size(123, 34)
        btnCheckEligibility.TabIndex = 2
        btnCheckEligibility.Text = "Check Eligibility"
        btnCheckEligibility.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(6, 109)
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
        Controls.Add(btnCheckEligibility)
        Controls.Add(txtAge)
        Controls.Add(lblAgePrompt)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAgePrompt As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnCheckEligibility As Button
    Friend WithEvents lblResult As Label

End Class
