<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItem
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Pnl_AddService = New System.Windows.Forms.Panel()
        Me.CboServiceType = New System.Windows.Forms.ComboBox()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.CboServiceUnit = New System.Windows.Forms.ComboBox()
        Me.TxtServiceDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnServiceSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtServiceName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtServiceUnitPrice = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Pnl_MangeService = New System.Windows.Forms.Panel()
        Me.BtnManageSer_Add = New System.Windows.Forms.Button()
        Me.BtnManageSer_Delete = New System.Windows.Forms.Button()
        Me.BtnManageSer_Edit = New System.Windows.Forms.Button()
        Me.CboManageSer_Status = New System.Windows.Forms.ComboBox()
        Me.DtgManageSer_Description = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtManageSer_SerName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Pnl_AddService.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Pnl_MangeService.SuspendLayout()
        CType(Me.DtgManageSer_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Controls.Add(Me.TabPage4)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(0, 0)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(653, 477)
        Me.TabControl3.TabIndex = 6
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Pnl_AddService)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(645, 451)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Add Service"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Pnl_AddService
        '
        Me.Pnl_AddService.BackColor = System.Drawing.Color.White
        Me.Pnl_AddService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_AddService.Controls.Add(Me.CboServiceType)
        Me.Pnl_AddService.Controls.Add(Me.Label97)
        Me.Pnl_AddService.Controls.Add(Me.CboServiceUnit)
        Me.Pnl_AddService.Controls.Add(Me.TxtServiceDesc)
        Me.Pnl_AddService.Controls.Add(Me.Label3)
        Me.Pnl_AddService.Controls.Add(Me.BtnServiceSave)
        Me.Pnl_AddService.Controls.Add(Me.Label2)
        Me.Pnl_AddService.Controls.Add(Me.TxtServiceName)
        Me.Pnl_AddService.Controls.Add(Me.Label1)
        Me.Pnl_AddService.Controls.Add(Me.TxtServiceUnitPrice)
        Me.Pnl_AddService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_AddService.Location = New System.Drawing.Point(3, 3)
        Me.Pnl_AddService.Name = "Pnl_AddService"
        Me.Pnl_AddService.Size = New System.Drawing.Size(639, 445)
        Me.Pnl_AddService.TabIndex = 3
        '
        'CboServiceType
        '
        Me.CboServiceType.FormattingEnabled = True
        Me.CboServiceType.Location = New System.Drawing.Point(198, 92)
        Me.CboServiceType.Name = "CboServiceType"
        Me.CboServiceType.Size = New System.Drawing.Size(121, 21)
        Me.CboServiceType.TabIndex = 9
        Me.CboServiceType.Tag = ""
        Me.CboServiceType.Text = "---Service Type---"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Location = New System.Drawing.Point(160, 251)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(32, 13)
        Me.Label97.TabIndex = 8
        Me.Label97.Text = "Unit :"
        '
        'CboServiceUnit
        '
        Me.CboServiceUnit.FormattingEnabled = True
        Me.CboServiceUnit.Location = New System.Drawing.Point(198, 248)
        Me.CboServiceUnit.Name = "CboServiceUnit"
        Me.CboServiceUnit.Size = New System.Drawing.Size(152, 21)
        Me.CboServiceUnit.TabIndex = 7
        '
        'TxtServiceDesc
        '
        Me.TxtServiceDesc.Location = New System.Drawing.Point(198, 145)
        Me.TxtServiceDesc.Multiline = True
        Me.TxtServiceDesc.Name = "TxtServiceDesc"
        Me.TxtServiceDesc.Size = New System.Drawing.Size(325, 71)
        Me.TxtServiceDesc.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(136, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unit Price:"
        '
        'BtnServiceSave
        '
        Me.BtnServiceSave.Location = New System.Drawing.Point(275, 275)
        Me.BtnServiceSave.Name = "BtnServiceSave"
        Me.BtnServiceSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnServiceSave.TabIndex = 0
        Me.BtnServiceSave.Text = "Save"
        Me.BtnServiceSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Service Description:"
        '
        'TxtServiceName
        '
        Me.TxtServiceName.Location = New System.Drawing.Point(198, 119)
        Me.TxtServiceName.Name = "TxtServiceName"
        Me.TxtServiceName.Size = New System.Drawing.Size(254, 20)
        Me.TxtServiceName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Service Name:"
        '
        'TxtServiceUnitPrice
        '
        Me.TxtServiceUnitPrice.Location = New System.Drawing.Point(198, 222)
        Me.TxtServiceUnitPrice.Name = "TxtServiceUnitPrice"
        Me.TxtServiceUnitPrice.Size = New System.Drawing.Size(152, 20)
        Me.TxtServiceUnitPrice.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Pnl_MangeService)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(645, 451)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Manage Service"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Pnl_MangeService
        '
        Me.Pnl_MangeService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_MangeService.Controls.Add(Me.BtnManageSer_Delete)
        Me.Pnl_MangeService.Controls.Add(Me.BtnManageSer_Edit)
        Me.Pnl_MangeService.Controls.Add(Me.CboManageSer_Status)
        Me.Pnl_MangeService.Controls.Add(Me.DtgManageSer_Description)
        Me.Pnl_MangeService.Controls.Add(Me.Label5)
        Me.Pnl_MangeService.Controls.Add(Me.TxtManageSer_SerName)
        Me.Pnl_MangeService.Controls.Add(Me.Label6)
        Me.Pnl_MangeService.Controls.Add(Me.BtnManageSer_Add)
        Me.Pnl_MangeService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_MangeService.Location = New System.Drawing.Point(3, 3)
        Me.Pnl_MangeService.Name = "Pnl_MangeService"
        Me.Pnl_MangeService.Size = New System.Drawing.Size(639, 445)
        Me.Pnl_MangeService.TabIndex = 4
        '
        'BtnManageSer_Add
        '
        Me.BtnManageSer_Add.Location = New System.Drawing.Point(452, 416)
        Me.BtnManageSer_Add.Name = "BtnManageSer_Add"
        Me.BtnManageSer_Add.Size = New System.Drawing.Size(85, 23)
        Me.BtnManageSer_Add.TabIndex = 6
        Me.BtnManageSer_Add.Text = "Add"
        Me.BtnManageSer_Add.UseVisualStyleBackColor = True
        '
        'BtnManageSer_Delete
        '
        Me.BtnManageSer_Delete.Location = New System.Drawing.Point(545, 416)
        Me.BtnManageSer_Delete.Name = "BtnManageSer_Delete"
        Me.BtnManageSer_Delete.Size = New System.Drawing.Size(89, 23)
        Me.BtnManageSer_Delete.TabIndex = 6
        Me.BtnManageSer_Delete.Text = "Delete"
        Me.BtnManageSer_Delete.UseVisualStyleBackColor = True
        '
        'BtnManageSer_Edit
        '
        Me.BtnManageSer_Edit.Location = New System.Drawing.Point(452, 416)
        Me.BtnManageSer_Edit.Name = "BtnManageSer_Edit"
        Me.BtnManageSer_Edit.Size = New System.Drawing.Size(87, 23)
        Me.BtnManageSer_Edit.TabIndex = 6
        Me.BtnManageSer_Edit.Text = "Edit"
        Me.BtnManageSer_Edit.UseVisualStyleBackColor = True
        '
        'CboManageSer_Status
        '
        Me.CboManageSer_Status.FormattingEnabled = True
        Me.CboManageSer_Status.Items.AddRange(New Object() {"-----Please Select Status------"})
        Me.CboManageSer_Status.Location = New System.Drawing.Point(487, 3)
        Me.CboManageSer_Status.Name = "CboManageSer_Status"
        Me.CboManageSer_Status.Size = New System.Drawing.Size(146, 21)
        Me.CboManageSer_Status.TabIndex = 4
        '
        'DtgManageSer_Description
        '
        Me.DtgManageSer_Description.AllowUserToAddRows = False
        Me.DtgManageSer_Description.AllowUserToDeleteRows = False
        Me.DtgManageSer_Description.AllowUserToResizeColumns = False
        Me.DtgManageSer_Description.AllowUserToResizeRows = False
        Me.DtgManageSer_Description.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgManageSer_Description.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgManageSer_Description.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DtgManageSer_Description.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgManageSer_Description.DefaultCellStyle = DataGridViewCellStyle11
        Me.DtgManageSer_Description.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DtgManageSer_Description.Location = New System.Drawing.Point(3, 89)
        Me.DtgManageSer_Description.Name = "DtgManageSer_Description"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgManageSer_Description.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DtgManageSer_Description.RowHeadersVisible = False
        Me.DtgManageSer_Description.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgManageSer_Description.Size = New System.Drawing.Size(630, 321)
        Me.DtgManageSer_Description.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Service Description:"
        '
        'TxtManageSer_SerName
        '
        Me.TxtManageSer_SerName.Location = New System.Drawing.Point(354, 4)
        Me.TxtManageSer_SerName.Name = "TxtManageSer_SerName"
        Me.TxtManageSer_SerName.Size = New System.Drawing.Size(127, 20)
        Me.TxtManageSer_SerName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Service Name:"
        '
        'frmItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 477)
        Me.Controls.Add(Me.TabControl3)
        Me.Name = "frmItem"
        Me.Text = "frmItem"
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Pnl_AddService.ResumeLayout(False)
        Me.Pnl_AddService.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.Pnl_MangeService.ResumeLayout(False)
        Me.Pnl_MangeService.PerformLayout()
        CType(Me.DtgManageSer_Description, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Pnl_AddService As Panel
    Friend WithEvents CboServiceType As ComboBox
    Friend WithEvents Label97 As Label
    Friend WithEvents CboServiceUnit As ComboBox
    Friend WithEvents TxtServiceDesc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnServiceSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtServiceName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtServiceUnitPrice As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Pnl_MangeService As Panel
    Friend WithEvents BtnManageSer_Add As Button
    Friend WithEvents BtnManageSer_Delete As Button
    Friend WithEvents BtnManageSer_Edit As Button
    Friend WithEvents CboManageSer_Status As ComboBox
    Friend WithEvents DtgManageSer_Description As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtManageSer_SerName As TextBox
    Friend WithEvents Label6 As Label
End Class
