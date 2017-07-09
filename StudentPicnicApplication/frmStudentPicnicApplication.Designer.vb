<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentPicnicApplication
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
        Me.lblSpringFlingPicnic = New System.Windows.Forms.Label()
        Me.picPicnic = New System.Windows.Forms.PictureBox()
        Me.lblAllStudentsAreWelcome = New System.Windows.Forms.Label()
        Me.btnViewPicnicInformation = New System.Windows.Forms.Button()
        Me.btnExitWindow = New System.Windows.Forms.Button()
        Me.lblPicnicDate = New System.Windows.Forms.Label()
        Me.lblPicnicLocation = New System.Windows.Forms.Label()
        CType(Me.picPicnic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSpringFlingPicnic
        '
        Me.lblSpringFlingPicnic.AutoSize = True
        Me.lblSpringFlingPicnic.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpringFlingPicnic.Location = New System.Drawing.Point(282, 39)
        Me.lblSpringFlingPicnic.Name = "lblSpringFlingPicnic"
        Me.lblSpringFlingPicnic.Size = New System.Drawing.Size(163, 50)
        Me.lblSpringFlingPicnic.TabIndex = 0
        Me.lblSpringFlingPicnic.Text = "Annual Spring " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fling Picnic"
        '
        'picPicnic
        '
        Me.picPicnic.Image = Global.StudentPicnicApplication.My.Resources.Resources.Picnic
        Me.picPicnic.Location = New System.Drawing.Point(17, 19)
        Me.picPicnic.Name = "picPicnic"
        Me.picPicnic.Size = New System.Drawing.Size(237, 392)
        Me.picPicnic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPicnic.TabIndex = 1
        Me.picPicnic.TabStop = False
        '
        'lblAllStudentsAreWelcome
        '
        Me.lblAllStudentsAreWelcome.AutoSize = True
        Me.lblAllStudentsAreWelcome.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllStudentsAreWelcome.Location = New System.Drawing.Point(268, 111)
        Me.lblAllStudentsAreWelcome.Name = "lblAllStudentsAreWelcome"
        Me.lblAllStudentsAreWelcome.Size = New System.Drawing.Size(190, 19)
        Me.lblAllStudentsAreWelcome.TabIndex = 2
        Me.lblAllStudentsAreWelcome.Text = "All Students are Welcome"
        '
        'btnViewPicnicInformation
        '
        Me.btnViewPicnicInformation.BackColor = System.Drawing.Color.YellowGreen
        Me.btnViewPicnicInformation.Location = New System.Drawing.Point(288, 152)
        Me.btnViewPicnicInformation.Name = "btnViewPicnicInformation"
        Me.btnViewPicnicInformation.Size = New System.Drawing.Size(150, 40)
        Me.btnViewPicnicInformation.TabIndex = 3
        Me.btnViewPicnicInformation.Text = "View Picnic Information"
        Me.btnViewPicnicInformation.UseVisualStyleBackColor = False
        '
        'btnExitWindow
        '
        Me.btnExitWindow.BackColor = System.Drawing.Color.YellowGreen
        Me.btnExitWindow.Location = New System.Drawing.Point(288, 371)
        Me.btnExitWindow.Name = "btnExitWindow"
        Me.btnExitWindow.Size = New System.Drawing.Size(150, 40)
        Me.btnExitWindow.TabIndex = 5
        Me.btnExitWindow.Text = "Exit Window"
        Me.btnExitWindow.UseVisualStyleBackColor = False
        '
        'lblPicnicDate
        '
        Me.lblPicnicDate.AutoSize = True
        Me.lblPicnicDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPicnicDate.Location = New System.Drawing.Point(319, 212)
        Me.lblPicnicDate.Name = "lblPicnicDate"
        Me.lblPicnicDate.Size = New System.Drawing.Size(88, 16)
        Me.lblPicnicDate.TabIndex = 6
        Me.lblPicnicDate.Text = "April 17, 2015"
        Me.lblPicnicDate.Visible = False
        '
        'lblPicnicLocation
        '
        Me.lblPicnicLocation.AutoSize = True
        Me.lblPicnicLocation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPicnicLocation.Location = New System.Drawing.Point(280, 245)
        Me.lblPicnicLocation.Name = "lblPicnicLocation"
        Me.lblPicnicLocation.Size = New System.Drawing.Size(167, 32)
        Me.lblPicnicLocation.TabIndex = 7
        Me.lblPicnicLocation.Text = "Located in the Quad in front" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the Barnard Building" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblPicnicLocation.Visible = False
        '
        'frmStudentPicnicApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(474, 432)
        Me.Controls.Add(Me.lblPicnicLocation)
        Me.Controls.Add(Me.lblPicnicDate)
        Me.Controls.Add(Me.btnExitWindow)
        Me.Controls.Add(Me.btnViewPicnicInformation)
        Me.Controls.Add(Me.lblAllStudentsAreWelcome)
        Me.Controls.Add(Me.picPicnic)
        Me.Controls.Add(Me.lblSpringFlingPicnic)
        Me.Name = "frmStudentPicnicApplication"
        Me.Text = "Student Picnic Application"
        CType(Me.picPicnic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSpringFlingPicnic As System.Windows.Forms.Label
    Friend WithEvents picPicnic As System.Windows.Forms.PictureBox
    Friend WithEvents lblAllStudentsAreWelcome As System.Windows.Forms.Label
    Friend WithEvents btnViewPicnicInformation As System.Windows.Forms.Button
    Friend WithEvents btnExitWindow As System.Windows.Forms.Button
    Friend WithEvents lblPicnicDate As System.Windows.Forms.Label
    Friend WithEvents lblPicnicLocation As System.Windows.Forms.Label

End Class
