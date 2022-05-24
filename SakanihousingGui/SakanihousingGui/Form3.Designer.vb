<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim AcademicNumberLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1_ = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SakniHDataSet = New SakanihousingGui.sakniHDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RoomTableAdapter = New SakanihousingGui.sakniHDataSetTableAdapters.RoomTableAdapter()
        Me.TableAdapterManager = New SakanihousingGui.sakniHDataSetTableAdapters.TableAdapterManager()
        Me.RequestOfstudentTableAdapter = New SakanihousingGui.sakniHDataSetTableAdapters.RequestOfstudentTableAdapter()
        Me.StudentTableAdapter = New SakanihousingGui.sakniHDataSetTableAdapters.studentTableAdapter()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequestOfstudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SakniHDataSet1 = New SakanihousingGui.sakniHDataSet1()
        Me.RoomBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomTableAdapter1 = New SakanihousingGui.sakniHDataSet1TableAdapters.RoomTableAdapter()
        AcademicNumberLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SakniHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestOfstudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SakniHDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AcademicNumberLabel
        '
        AcademicNumberLabel.AutoSize = True
        AcademicNumberLabel.Location = New System.Drawing.Point(354, 80)
        AcademicNumberLabel.Name = "AcademicNumberLabel"
        AcademicNumberLabel.Size = New System.Drawing.Size(96, 13)
        AcademicNumberLabel.TabIndex = 5
        AcademicNumberLabel.Text = "academic Number:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1_)
        Me.GroupBox1.Controls.Add(AcademicNumberLabel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 293)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "info"
        '
        'TextBox1_
        '
        Me.TextBox1_.Location = New System.Drawing.Point(476, 73)
        Me.TextBox1_.Name = "TextBox1_"
        Me.TextBox1_.Size = New System.Drawing.Size(122, 20)
        Me.TextBox1_.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rooms"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "roomNum", True))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RoomBindingSource, "roomNum", True))
        Me.ComboBox1.DataSource = Me.RoomBindingSource1
        Me.ComboBox1.DisplayMember = "roomnumber"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(107, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "roomnumber"
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "Room"
        Me.RoomBindingSource.DataSource = Me.SakniHDataSet
        '
        'SakniHDataSet
        '
        Me.SakniHDataSet.DataSetName = "sakniHDataSet"
        Me.SakniHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Create Request"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdministrationRoomTableAdapter = Nothing
        Me.TableAdapterManager.AdministrationTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RequestAdministrationTableAdapter = Nothing
        Me.TableAdapterManager.RequestOfstudentTableAdapter = Me.RequestOfstudentTableAdapter
        Me.TableAdapterManager.RequestTableAdapter = Nothing
        Me.TableAdapterManager.Room_locationTableAdapter = Nothing
        Me.TableAdapterManager.RoomTableAdapter = Me.RoomTableAdapter
        Me.TableAdapterManager.Rules_of_RoomTableAdapter = Nothing
        Me.TableAdapterManager.studentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.UpdateOrder = SakanihousingGui.sakniHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RequestOfstudentTableAdapter
        '
        Me.RequestOfstudentTableAdapter.ClearBeforeFill = True
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.SakniHDataSet
        '
        'RequestOfstudentBindingSource
        '
        Me.RequestOfstudentBindingSource.DataMember = "RequestOfstudent"
        Me.RequestOfstudentBindingSource.DataSource = Me.SakniHDataSet
        '
        'SakniHDataSet1
        '
        Me.SakniHDataSet1.DataSetName = "sakniHDataSet1"
        Me.SakniHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomBindingSource1
        '
        Me.RoomBindingSource1.DataMember = "Room"
        Me.RoomBindingSource1.DataSource = Me.SakniHDataSet1
        '
        'RoomTableAdapter1
        '
        Me.RoomTableAdapter1.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Check in "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SakniHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestOfstudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SakniHDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SakniHDataSet As sakniHDataSet
    Friend WithEvents RoomBindingSource As BindingSource
    Friend WithEvents RoomTableAdapter As sakniHDataSetTableAdapters.RoomTableAdapter
    Friend WithEvents TableAdapterManager As sakniHDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentTableAdapter As sakniHDataSetTableAdapters.studentTableAdapter
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents RequestOfstudentTableAdapter As sakniHDataSetTableAdapters.RequestOfstudentTableAdapter
    Friend WithEvents RequestOfstudentBindingSource As BindingSource
    Friend WithEvents TextBox1_ As TextBox
    Friend WithEvents SakniHDataSet1 As sakniHDataSet1
    Friend WithEvents RoomBindingSource1 As BindingSource
    Friend WithEvents RoomTableAdapter1 As sakniHDataSet1TableAdapters.RoomTableAdapter
End Class
