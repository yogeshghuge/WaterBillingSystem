<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentReport
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
        Me.Label62 = New System.Windows.Forms.Label()
        Me.DtpPayReports_To = New System.Windows.Forms.DateTimePicker()
        Me.DtpPayReports_From = New System.Windows.Forms.DateTimePicker()
        Me.CboPayReports_All = New System.Windows.Forms.ComboBox()
        Me.DtgPayReports_TotalView = New System.Windows.Forms.DataGridView()
        Me.CboPayReports_AllCus = New System.Windows.Forms.ComboBox()
        Me.BtnPayReports_Go = New System.Windows.Forms.Button()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        CType(Me.DtgPayReports_TotalView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(12, 9)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(140, 20)
        Me.Label62.TabIndex = 20
        Me.Label62.Text = "Payments Reports"
        '
        'DtpPayReports_To
        '
        Me.DtpPayReports_To.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpPayReports_To.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpPayReports_To.Location = New System.Drawing.Point(521, 82)
        Me.DtpPayReports_To.Name = "DtpPayReports_To"
        Me.DtpPayReports_To.Size = New System.Drawing.Size(89, 20)
        Me.DtpPayReports_To.TabIndex = 19
        '
        'DtpPayReports_From
        '
        Me.DtpPayReports_From.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpPayReports_From.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpPayReports_From.Location = New System.Drawing.Point(397, 81)
        Me.DtpPayReports_From.Name = "DtpPayReports_From"
        Me.DtpPayReports_From.Size = New System.Drawing.Size(89, 20)
        Me.DtpPayReports_From.TabIndex = 18
        '
        'CboPayReports_All
        '
        Me.CboPayReports_All.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboPayReports_All.FormattingEnabled = True
        Me.CboPayReports_All.Items.AddRange(New Object() {"All"})
        Me.CboPayReports_All.Location = New System.Drawing.Point(626, 81)
        Me.CboPayReports_All.Name = "CboPayReports_All"
        Me.CboPayReports_All.Size = New System.Drawing.Size(71, 21)
        Me.CboPayReports_All.TabIndex = 17
        Me.CboPayReports_All.Text = "All"
        '
        'DtgPayReports_TotalView
        '
        Me.DtgPayReports_TotalView.AllowUserToAddRows = False
        Me.DtgPayReports_TotalView.AllowUserToDeleteRows = False
        Me.DtgPayReports_TotalView.AllowUserToResizeColumns = False
        Me.DtgPayReports_TotalView.AllowUserToResizeRows = False
        Me.DtgPayReports_TotalView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtgPayReports_TotalView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgPayReports_TotalView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DtgPayReports_TotalView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgPayReports_TotalView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DtgPayReports_TotalView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgPayReports_TotalView.DefaultCellStyle = DataGridViewCellStyle8
        Me.DtgPayReports_TotalView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DtgPayReports_TotalView.Location = New System.Drawing.Point(5, 135)
        Me.DtgPayReports_TotalView.Name = "DtgPayReports_TotalView"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgPayReports_TotalView.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DtgPayReports_TotalView.RowHeadersVisible = False
        Me.DtgPayReports_TotalView.Size = New System.Drawing.Size(770, 330)
        Me.DtgPayReports_TotalView.TabIndex = 16
        '
        'CboPayReports_AllCus
        '
        Me.CboPayReports_AllCus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboPayReports_AllCus.FormattingEnabled = True
        Me.CboPayReports_AllCus.Items.AddRange(New Object() {"All Customer"})
        Me.CboPayReports_AllCus.Location = New System.Drawing.Point(242, 81)
        Me.CboPayReports_AllCus.Name = "CboPayReports_AllCus"
        Me.CboPayReports_AllCus.Size = New System.Drawing.Size(110, 21)
        Me.CboPayReports_AllCus.TabIndex = 15
        Me.CboPayReports_AllCus.Text = "All Customer"
        '
        'BtnPayReports_Go
        '
        Me.BtnPayReports_Go.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPayReports_Go.Location = New System.Drawing.Point(703, 80)
        Me.BtnPayReports_Go.Name = "BtnPayReports_Go"
        Me.BtnPayReports_Go.Size = New System.Drawing.Size(72, 23)
        Me.BtnPayReports_Go.TabIndex = 14
        Me.BtnPayReports_Go.Text = "Go"
        Me.BtnPayReports_Go.UseVisualStyleBackColor = True
        '
        'Label63
        '
        Me.Label63.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(492, 85)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(23, 13)
        Me.Label63.TabIndex = 12
        Me.Label63.Text = "To:"
        '
        'Label64
        '
        Me.Label64.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(358, 85)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(33, 13)
        Me.Label64.TabIndex = 13
        Me.Label64.Text = "From:"
        '
        'frmPaymentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 477)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.DtpPayReports_To)
        Me.Controls.Add(Me.DtpPayReports_From)
        Me.Controls.Add(Me.CboPayReports_All)
        Me.Controls.Add(Me.DtgPayReports_TotalView)
        Me.Controls.Add(Me.CboPayReports_AllCus)
        Me.Controls.Add(Me.BtnPayReports_Go)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Label64)
        Me.Name = "frmPaymentReport"
        Me.Text = "Report"
        CType(Me.DtgPayReports_TotalView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label62 As Label
    Friend WithEvents DtpPayReports_To As DateTimePicker
    Friend WithEvents DtpPayReports_From As DateTimePicker
    Friend WithEvents CboPayReports_All As ComboBox
    Friend WithEvents DtgPayReports_TotalView As DataGridView
    Friend WithEvents CboPayReports_AllCus As ComboBox
    Friend WithEvents BtnPayReports_Go As Button
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
End Class
