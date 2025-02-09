<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageCustomer
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DtgManageCus_ViewRecord = New System.Windows.Forms.DataGridView()
        Me.CboManageCus_ActionUsers = New System.Windows.Forms.ComboBox()
        Me.BtnManageCus_Search = New System.Windows.Forms.Button()
        Me.BtnManageCus_Go = New System.Windows.Forms.Button()
        Me.TxtManageCus_id = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        CType(Me.DtgManageCus_ViewRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtgManageCus_ViewRecord
        '
        Me.DtgManageCus_ViewRecord.AllowUserToAddRows = False
        Me.DtgManageCus_ViewRecord.AllowUserToDeleteRows = False
        Me.DtgManageCus_ViewRecord.AllowUserToResizeColumns = False
        Me.DtgManageCus_ViewRecord.AllowUserToResizeRows = False
        Me.DtgManageCus_ViewRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgManageCus_ViewRecord.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DtgManageCus_ViewRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgManageCus_ViewRecord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgManageCus_ViewRecord.DefaultCellStyle = DataGridViewCellStyle8
        Me.DtgManageCus_ViewRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DtgManageCus_ViewRecord.Location = New System.Drawing.Point(17, 112)
        Me.DtgManageCus_ViewRecord.Name = "DtgManageCus_ViewRecord"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgManageCus_ViewRecord.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DtgManageCus_ViewRecord.RowHeadersVisible = False
        Me.DtgManageCus_ViewRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgManageCus_ViewRecord.Size = New System.Drawing.Size(755, 341)
        Me.DtgManageCus_ViewRecord.TabIndex = 15
        '
        'CboManageCus_ActionUsers
        '
        Me.CboManageCus_ActionUsers.FormattingEnabled = True
        Me.CboManageCus_ActionUsers.Items.AddRange(New Object() {"---Please Select Action---", "Edit", "Delete"})
        Me.CboManageCus_ActionUsers.Location = New System.Drawing.Point(551, 85)
        Me.CboManageCus_ActionUsers.Name = "CboManageCus_ActionUsers"
        Me.CboManageCus_ActionUsers.Size = New System.Drawing.Size(148, 21)
        Me.CboManageCus_ActionUsers.TabIndex = 14
        Me.CboManageCus_ActionUsers.Text = "---Please Select Action---"
        '
        'BtnManageCus_Search
        '
        Me.BtnManageCus_Search.Location = New System.Drawing.Point(197, 83)
        Me.BtnManageCus_Search.Name = "BtnManageCus_Search"
        Me.BtnManageCus_Search.Size = New System.Drawing.Size(68, 23)
        Me.BtnManageCus_Search.TabIndex = 12
        Me.BtnManageCus_Search.Text = "Search"
        Me.BtnManageCus_Search.UseVisualStyleBackColor = True
        '
        'BtnManageCus_Go
        '
        Me.BtnManageCus_Go.Location = New System.Drawing.Point(705, 83)
        Me.BtnManageCus_Go.Name = "BtnManageCus_Go"
        Me.BtnManageCus_Go.Size = New System.Drawing.Size(66, 23)
        Me.BtnManageCus_Go.TabIndex = 13
        Me.BtnManageCus_Go.Text = "Go"
        Me.BtnManageCus_Go.UseVisualStyleBackColor = True
        '
        'TxtManageCus_id
        '
        Me.TxtManageCus_id.Location = New System.Drawing.Point(16, 86)
        Me.TxtManageCus_id.Name = "TxtManageCus_id"
        Me.TxtManageCus_id.Size = New System.Drawing.Size(175, 20)
        Me.TxtManageCus_id.TabIndex = 8
        '
        'Label72
        '
        Me.Label72.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(0, 0)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(784, 39)
        Me.Label72.TabIndex = 9
        Me.Label72.Text = "Manage Customer"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(13, 67)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(85, 13)
        Me.Label52.TabIndex = 10
        Me.Label52.Text = "Customer Code :"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(551, 69)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(129, 13)
        Me.Label43.TabIndex = 11
        Me.Label43.Text = "Action for selected users :"
        '
        'frmManageCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 481)
        Me.Controls.Add(Me.DtgManageCus_ViewRecord)
        Me.Controls.Add(Me.CboManageCus_ActionUsers)
        Me.Controls.Add(Me.BtnManageCus_Search)
        Me.Controls.Add(Me.BtnManageCus_Go)
        Me.Controls.Add(Me.TxtManageCus_id)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label43)
        Me.Name = "frmManageCustomer"
        Me.Text = "Customer"
        CType(Me.DtgManageCus_ViewRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtgManageCus_ViewRecord As DataGridView
    Friend WithEvents CboManageCus_ActionUsers As ComboBox
    Friend WithEvents BtnManageCus_Search As Button
    Friend WithEvents BtnManageCus_Go As Button
    Friend WithEvents TxtManageCus_id As TextBox
    Friend WithEvents Label72 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label43 As Label
End Class
