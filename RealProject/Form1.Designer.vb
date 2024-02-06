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
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(8, 8)
        Me.btnCreateAccount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(152, 57)
        Me.btnCreateAccount.TabIndex = 0
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(467, 69)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(433, 366)
        Me.txtOutput.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(467, 11)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblUsername.Size = New System.Drawing.Size(0, 31)
        Me.lblUsername.TabIndex = 2
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(164, 8)
        Me.btnLogIn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(147, 57)
        Me.btnLogIn.TabIndex = 3
        Me.btnLogIn.Text = "Login"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(315, 8)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnLogOut.Size = New System.Drawing.Size(148, 57)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.Text = "Logout"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(8, 69)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(455, 93)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start Practice"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 441)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Theory Test Practice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnStart As Button
End Class
