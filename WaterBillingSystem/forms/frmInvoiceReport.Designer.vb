<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceReport
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DtpInvoiceReport_To = New System.Windows.Forms.DateTimePicker()
        Me.DtpInvoiceReport_From = New System.Windows.Forms.DateTimePicker()
        Me.CboInvoiceReport_All = New System.Windows.Forms.ComboBox()
        Me.DtgInvoiceReport_ViewAll = New System.Windows.Forms.DataGridView()
        Me.CboInvoiceReport_AllCus = New System.Windows.Forms.ComboBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        CType(Me.DtgInvoiceReport_ViewAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(120, 20)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Invoice Reports"
        '
        'DtpInvoiceReport_To
        '
        Me.DtpInvoiceReport_To.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpInvoiceReport_To.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpInvoiceReport_To.Location = New System.Drawing.Point(508, 81)
        Me.DtpInvoiceReport_To.Name = "DtpInvoiceReport_To"
        Me.DtpInvoiceReport_To.Size = New System.Drawing.Size(89, 20)
        Me.DtpInvoiceReport_To.TabIndex = 20
        '
        'DtpInvoiceReport_From
        '
        Me.DtpInvoiceReport_From.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpInvoiceReport_From.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpInvoiceReport_From.Location = New System.Drawing.Point(384, 80)
        Me.DtpInvoiceReport_From.Name = "DtpInvoiceReport_From"
        Me.DtpInvoiceReport_From.Size = New System.Drawing.Size(89, 20)
        Me.DtpInvoiceReport_From.TabIndex = 19
        '
        'CboInvoiceReport_All
        '
        Me.CboInvoiceReport_All.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboInvoiceReport_All.FormattingEnabled = True
        Me.CboInvoiceReport_All.Items.AddRange(New Object() {"All"})
        Me.CboInvoiceReport_All.Location = New System.Drawing.Point(613, 80)
        Me.CboInvoiceReport_All.Name = "CboInvoiceReport_All"
        Me.CboInvoiceReport_All.Size = New System.Drawing.Size(71, 21)
        Me.CboInvoiceReport_All.TabIndex = 18
        Me.CboInvoiceReport_All.Text = "All"
        '
        'DtgInvoiceReport_ViewAll
        '
        Me.DtgInvoiceReport_ViewAll.AllowUserToAddRows = False
        Me.DtgInvoiceReport_ViewAll.AllowUserToDeleteRows = False
        Me.DtgInvoiceReport_ViewAll.AllowUserToResizeColumns = False
        Me.DtgInvoiceReport_ViewAll.AllowUserToResizeRows = False
        Me.DtgInvoiceReport_ViewAll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtgInvoiceReport_ViewAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgInvoiceReport_ViewAll.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgInvoiceReport_ViewAll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgInvoiceReport_ViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgInvoiceReport_ViewAll.DefaultCellStyle = DataGridViewCellStyle2
        Me.DtgInvoiceReport_ViewAll.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DtgInvoiceReport_ViewAll.Location = New System.Drawing.Point(3, 128)
        Me.DtgInvoiceReport_ViewAll.Name = "DtgInvoiceReport_ViewAll"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgInvoiceReport_ViewAll.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DtgInvoiceReport_ViewAll.RowHeadersVisible = False
        Me.DtgInvoiceReport_ViewAll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DtgInvoiceReport_ViewAll.Size = New System.Drawing.Size(769, 316)
        Me.DtgInvoiceReport_ViewAll.TabIndex = 17
        '
        'CboInvoiceReport_AllCus
        '
        Me.CboInvoiceReport_AllCus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboInvoiceReport_AllCus.FormattingEnabled = True
        Me.CboInvoiceReport_AllCus.Items.AddRange(New Object() {"All Customer"})
        Me.CboInvoiceReport_AllCus.Location = New System.Drawing.Point(229, 78)
        Me.CboInvoiceReport_AllCus.Name = "CboInvoiceReport_AllCus"
        Me.CboInvoiceReport_AllCus.Size = New System.Drawing.Size(110, 21)
        Me.CboInvoiceReport_AllCus.TabIndex = 16
        Me.CboInvoiceReport_AllCus.Text = "All Customer"
        '
        'Button20
        '
        Me.Button20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button20.Location = New System.Drawing.Point(690, 77)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(71, 23)
        Me.Button20.TabIndex = 15
        Me.Button20.Text = "Go"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Label76
        '
        Me.Label76.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(479, 84)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(23, 13)
        Me.Label76.TabIndex = 13
        Me.Label76.Text = "To:"
        '
        'Label78
        '
        Me.Label78.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(345, 84)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(33, 13)
        Me.Label78.TabIndex = 14
        Me.Label78.Text = "From:"
        '
        'frmInvoiceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 456)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.DtpInvoiceReport_To)
        Me.Controls.Add(Me.DtpInvoiceReport_From)
        Me.Controls.Add(Me.CboInvoiceReport_All)
        Me.Controls.Add(Me.DtgInvoiceReport_ViewAll)
        Me.Controls.Add(Me.CboInvoiceReport_AllCus)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Label76)
        Me.Controls.Add(Me.Label78)
        Me.Name = "frmInvoiceReport"
        Me.Text = "Report"
        CType(Me.DtgInvoiceReport_ViewAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label20 As Label
    Friend WithEvents DtpInvoiceReport_To As DateTimePicker
    Friend WithEvents DtpInvoiceReport_From As DateTimePicker
    Friend WithEvents CboInvoiceReport_All As ComboBox
    Friend WithEvents DtgInvoiceReport_ViewAll As DataGridView
    Friend WithEvents CboInvoiceReport_AllCus As ComboBox
    Friend WithEvents Button20 As Button
    Friend WithEvents Label76 As Label
    Friend WithEvents Label78 As Label
End Class
