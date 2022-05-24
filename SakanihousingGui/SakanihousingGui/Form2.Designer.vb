<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.checkinButt = New System.Windows.Forms.Button()
        Me.checkoutButt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'checkinButt
        '
        Me.checkinButt.Location = New System.Drawing.Point(140, 97)
        Me.checkinButt.Name = "checkinButt"
        Me.checkinButt.Size = New System.Drawing.Size(160, 23)
        Me.checkinButt.TabIndex = 0
        Me.checkinButt.Text = "Check in "
        Me.checkinButt.UseVisualStyleBackColor = True
        '
        'checkoutButt
        '
        Me.checkoutButt.Location = New System.Drawing.Point(455, 97)
        Me.checkoutButt.Name = "checkoutButt"
        Me.checkoutButt.Size = New System.Drawing.Size(167, 23)
        Me.checkoutButt.TabIndex = 1
        Me.checkoutButt.Text = "Check out"
        Me.checkoutButt.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 257)
        Me.Controls.Add(Me.checkoutButt)
        Me.Controls.Add(Me.checkinButt)
        Me.Name = "Form2"
        Me.Text = "make request"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents checkinButt As Button
    Friend WithEvents checkoutButt As Button
End Class
