<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaxReport
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
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.DtpTaxReport_To = New System.Windows.Forms.DateTimePicker()
        Me.DtpTaxReport_From = New System.Windows.Forms.DateTimePicker()
        Me.CboTaxReport_All = New System.Windows.Forms.ComboBox()
        Me.DtgTaxReport_TotalView = New System.Windows.Forms.DataGridView()
        Me.CboTaxReport_AllCus = New System.Windows.Forms.ComboBox()
        Me.BtnTaxReport_Go = New System.Windows.Forms.Button()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        CType(Me.DtgTaxReport_TotalView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(407, 419)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(138, 38)
        Me.TextBox4.TabIndex = 24
        Me.TextBox4.Text = "total taxes"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(551, 419)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(218, 38)
        Me.TextBox3.TabIndex = 23
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(12, 9)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(95, 20)
        Me.Label77.TabIndex = 22
        Me.Label77.Text = "Tax Reports"
        '
        'DtpTaxReport_To
        '
        Me.DtpTaxReport_To.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpTaxReport_To.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTaxReport_To.Location = New System.Drawing.Point(529, 84)
        Me.DtpTaxReport_To.Name = "DtpTaxReport_To"
        Me.DtpTaxReport_To.Size = New System.Drawing.Size(89, 20)
        Me.DtpTaxReport_To.TabIndex = 21
        '
        'DtpTaxReport_From
        '
        Me.DtpTaxReport_From.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpTaxReport_From.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTaxReport_From.Location = New System.Drawing.Point(405, 83)
        Me.DtpTaxReport_From.Name = "DtpTaxReport_From"
        Me.DtpTaxReport_From.Size = New System.Drawing.Size(89, 20)
        Me.DtpTaxReport_From.TabIndex = 20
        '
        'CboTaxReport_All
        '
        Me.CboTaxReport_All.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboTaxReport_All.FormattingEnabled = True
        Me.CboTaxReport_All.Items.AddRange(New Object() {"All"})
        Me.CboTaxReport_All.Location = New System.Drawing.Point(634, 83)
        Me.CboTaxReport_All.Name = "CboTaxReport_All"
        Me.CboTaxReport_All.Size = New System.Drawing.Size(71, 21)
        Me.CboTaxReport_All.TabIndex = 19
        Me.CboTaxReport_All.Text = "All"
        '
        'DtgTaxReport_TotalView
        '
        Me.DtgTaxReport_TotalView.AllowUserToAddRows = False
        Me.DtgTaxReport_TotalView.AllowUserToDeleteRows = False
        Me.DtgTaxReport_TotalView.AllowUserToResizeColumns = False
        Me.DtgTaxReport_TotalView.AllowUserToResizeRows = False
        Me.DtgTaxReport_TotalView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtgTaxReport_TotalView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgTaxReport_TotalView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DtgTaxReport_TotalView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgTaxReport_TotalView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgTaxReport_TotalView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgTaxReport_TotalView.DefaultCellStyle = DataGridViewCellStyle2
        Me.DtgTaxReport_TotalView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DtgTaxReport_TotalView.Location = New System.Drawing.Point(5, 124)
        Me.DtgTaxReport_TotalView.Name = "DtgTaxReport_TotalView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgTaxReport_TotalView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DtgTaxReport_TotalView.RowHeadersVisible = False
        Me.DtgTaxReport_TotalView.Size = New System.Drawing.Size(764, 292)
        Me.DtgTaxReport_TotalView.TabIndex = 18
        '
        'CboTaxReport_AllCus
        '
        Me.CboTaxReport_AllCus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboTaxReport_AllCus.FormattingEnabled = True
        Me.CboTaxReport_AllCus.Items.AddRange(New Object() {"All Customer"})
        Me.CboTaxReport_AllCus.Location = New System.Drawing.Point(250, 83)
        Me.CboTaxReport_AllCus.Name = "CboTaxReport_AllCus"
        Me.CboTaxReport_AllCus.Size = New System.Drawing.Size(110, 21)
        Me.CboTaxReport_AllCus.TabIndex = 17
        Me.CboTaxReport_AllCus.Text = "All Customer"
        '
        'BtnTaxReport_Go
        '
        Me.BtnTaxReport_Go.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTaxReport_Go.Location = New System.Drawing.Point(711, 80)
        Me.BtnTaxReport_Go.Name = "BtnTaxReport_Go"
        Me.BtnTaxReport_Go.Size = New System.Drawing.Size(58, 23)
        Me.BtnTaxReport_Go.TabIndex = 16
        Me.BtnTaxReport_Go.Text = "Go"
        Me.BtnTaxReport_Go.UseVisualStyleBackColor = True
        '
        'Label80
        '
        Me.Label80.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(500, 87)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(23, 13)
        Me.Label80.TabIndex = 14
        Me.Label80.Text = "To:"
        '
        'Label81
        '
        Me.Label81.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(366, 87)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(33, 13)
        Me.Label81.TabIndex = 15
        Me.Label81.Text = "From:"
        '
        'frmTaxReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 469)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label77)
        Me.Controls.Add(Me.DtpTaxReport_To)
        Me.Controls.Add(Me.DtpTaxReport_From)
        Me.Controls.Add(Me.CboTaxReport_All)
        Me.Controls.Add(Me.DtgTaxReport_TotalView)
        Me.Controls.Add(Me.CboTaxReport_AllCus)
        Me.Controls.Add(Me.BtnTaxReport_Go)
        Me.Controls.Add(Me.Label80)
        Me.Controls.Add(Me.Label81)
        Me.Name = "frmTaxReport"
        Me.Text = "Report"
        CType(Me.DtgTaxReport_TotalView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label77 As Label
    Friend WithEvents DtpTaxReport_To As DateTimePicker
    Friend WithEvents DtpTaxReport_From As DateTimePicker
    Friend WithEvents CboTaxReport_All As ComboBox
    Friend WithEvents DtgTaxReport_TotalView As DataGridView
    Friend WithEvents CboTaxReport_AllCus As ComboBox
    Friend WithEvents BtnTaxReport_Go As Button
    Friend WithEvents Label80 As Label
    Friend WithEvents Label81 As Label
End Class
