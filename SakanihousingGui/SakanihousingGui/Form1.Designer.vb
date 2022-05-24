<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.enterButt = New System.Windows.Forms.Button()
        Me.cancelButt = New System.Windows.Forms.Button()
        Me.userName = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'enterButt
        '
        Me.enterButt.Location = New System.Drawing.Point(319, 225)
        Me.enterButt.Name = "enterButt"
        Me.enterButt.Size = New System.Drawing.Size(75, 23)
        Me.enterButt.TabIndex = 0
        Me.enterButt.Text = "Enter"
        Me.enterButt.UseVisualStyleBackColor = True
        '
        'cancelButt
        '
        Me.cancelButt.Location = New System.Drawing.Point(210, 225)
        Me.cancelButt.Name = "cancelButt"
        Me.cancelButt.Size = New System.Drawing.Size(75, 23)
        Me.cancelButt.TabIndex = 1
        Me.cancelButt.Text = "Cancel"
        Me.cancelButt.UseVisualStyleBackColor = True
        '
        'userName
        '
        Me.userName.Location = New System.Drawing.Point(210, 95)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(184, 20)
        Me.userName.TabIndex = 2
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(210, 138)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(184, 20)
        Me.Password.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 417)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.cancelButt)
        Me.Controls.Add(Me.enterButt)
        Me.Name = "Form1"
        Me.Text = "login page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents enterButt As Button
    Friend WithEvents cancelButt As Button
    Friend WithEvents userName As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
