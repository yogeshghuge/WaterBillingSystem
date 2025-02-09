<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpayment
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
        Me.CboEnterPay_Customer = New System.Windows.Forms.ComboBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.DtgEnterPay_InvoiceNumAmount = New System.Windows.Forms.DataGridView()
        Me.BtnEnterPay_Add = New System.Windows.Forms.Button()
        Me.TxtEnterPay_NetAmount = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.LblEnterPay_AvailCredit = New System.Windows.Forms.Label()
        Me.LblEnterPay_TotalAmount = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TxtEnterPay_Remarks = New System.Windows.Forms.TextBox()
        Me.TxtEnterPay_Status1 = New System.Windows.Forms.TextBox()
        Me.TxtEnterPay_Credit = New System.Windows.Forms.TextBox()
        CType(Me.DtgEnterPay_InvoiceNumAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CboEnterPay_Customer
        '
        Me.CboEnterPay_Customer.FormattingEnabled = True
        Me.CboEnterPay_Customer.Items.AddRange(New Object() {"---Select Customer----"})
        Me.CboEnterPay_Customer.Location = New System.Drawing.Point(105, 67)
        Me.CboEnterPay_Customer.MaxDropDownItems = 13
        Me.CboEnterPay_Customer.Name = "CboEnterPay_Customer"
        Me.CboEnterPay_Customer.Size = New System.Drawing.Size(138, 21)
        Me.CboEnterPay_Customer.TabIndex = 28
        Me.CboEnterPay_Customer.Text = "---Select Customer----"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(12, 9)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(114, 20)
        Me.Label84.TabIndex = 27
        Me.Label84.Text = "Enter Payment"
        '
        'DtgEnterPay_InvoiceNumAmount
        '
        Me.DtgEnterPay_InvoiceNumAmount.AllowUserToAddRows = False
        Me.DtgEnterPay_InvoiceNumAmount.AllowUserToDeleteRows = False
        Me.DtgEnterPay_InvoiceNumAmount.AllowUserToResizeColumns = False
        Me.DtgEnterPay_InvoiceNumAmount.AllowUserToResizeRows = False
        Me.DtgEnterPay_InvoiceNumAmount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgEnterPay_InvoiceNumAmount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DtgEnterPay_InvoiceNumAmount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgEnterPay_InvoiceNumAmount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DtgEnterPay_InvoiceNumAmount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgEnterPay_InvoiceNumAmount.DefaultCellStyle = DataGridViewCellStyle11
        Me.DtgEnterPay_InvoiceNumAmount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DtgEnterPay_InvoiceNumAmount.Location = New System.Drawing.Point(312, 55)
        Me.DtgEnterPay_InvoiceNumAmount.Name = "DtgEnterPay_InvoiceNumAmount"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgEnterPay_InvoiceNumAmount.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DtgEnterPay_InvoiceNumAmount.RowHeadersVisible = False
        Me.DtgEnterPay_InvoiceNumAmount.Size = New System.Drawing.Size(455, 94)
        Me.DtgEnterPay_InvoiceNumAmount.TabIndex = 26
        '
        'BtnEnterPay_Add
        '
        Me.BtnEnterPay_Add.Location = New System.Drawing.Point(105, 263)
        Me.BtnEnterPay_Add.Name = "BtnEnterPay_Add"
        Me.BtnEnterPay_Add.Size = New System.Drawing.Size(127, 28)
        Me.BtnEnterPay_Add.TabIndex = 25
        Me.BtnEnterPay_Add.Text = "Save Payments"
        Me.BtnEnterPay_Add.UseVisualStyleBackColor = True
        '
        'TxtEnterPay_NetAmount
        '
        Me.TxtEnterPay_NetAmount.Location = New System.Drawing.Point(105, 163)
        Me.TxtEnterPay_NetAmount.Name = "TxtEnterPay_NetAmount"
        Me.TxtEnterPay_NetAmount.Size = New System.Drawing.Size(127, 20)
        Me.TxtEnterPay_NetAmount.TabIndex = 16
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(26, 166)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(69, 13)
        Me.Label44.TabIndex = 18
        Me.Label44.Text = "Net Amount :"
        '
        'LblEnterPay_AvailCredit
        '
        Me.LblEnterPay_AvailCredit.AutoSize = True
        Me.LblEnterPay_AvailCredit.Location = New System.Drawing.Point(138, 136)
        Me.LblEnterPay_AvailCredit.Name = "LblEnterPay_AvailCredit"
        Me.LblEnterPay_AvailCredit.Size = New System.Drawing.Size(13, 13)
        Me.LblEnterPay_AvailCredit.TabIndex = 19
        Me.LblEnterPay_AvailCredit.Text = "0"
        '
        'LblEnterPay_TotalAmount
        '
        Me.LblEnterPay_TotalAmount.AutoSize = True
        Me.LblEnterPay_TotalAmount.Location = New System.Drawing.Point(138, 105)
        Me.LblEnterPay_TotalAmount.Name = "LblEnterPay_TotalAmount"
        Me.LblEnterPay_TotalAmount.Size = New System.Drawing.Size(13, 13)
        Me.LblEnterPay_TotalAmount.TabIndex = 20
        Me.LblEnterPay_TotalAmount.Text = "0"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(9, 136)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(86, 13)
        Me.Label45.TabIndex = 21
        Me.Label45.Text = "Available Credit :"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(19, 104)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(76, 13)
        Me.Label46.TabIndex = 22
        Me.Label46.Text = "Total Amount :"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(40, 203)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(55, 13)
        Me.Label49.TabIndex = 23
        Me.Label49.Text = "Remarks :"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(38, 70)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(57, 13)
        Me.Label54.TabIndex = 24
        Me.Label54.Text = "Customer :"
        '
        'TxtEnterPay_Remarks
        '
        Me.TxtEnterPay_Remarks.Location = New System.Drawing.Point(105, 200)
        Me.TxtEnterPay_Remarks.Multiline = True
        Me.TxtEnterPay_Remarks.Name = "TxtEnterPay_Remarks"
        Me.TxtEnterPay_Remarks.Size = New System.Drawing.Size(184, 57)
        Me.TxtEnterPay_Remarks.TabIndex = 17
        '
        'TxtEnterPay_Status1
        '
        Me.TxtEnterPay_Status1.Location = New System.Drawing.Point(473, 75)
        Me.TxtEnterPay_Status1.Name = "TxtEnterPay_Status1"
        Me.TxtEnterPay_Status1.Size = New System.Drawing.Size(43, 20)
        Me.TxtEnterPay_Status1.TabIndex = 30
        '
        'TxtEnterPay_Credit
        '
        Me.TxtEnterPay_Credit.Location = New System.Drawing.Point(409, 75)
        Me.TxtEnterPay_Credit.Name = "TxtEnterPay_Credit"
        Me.TxtEnterPay_Credit.Size = New System.Drawing.Size(46, 20)
        Me.TxtEnterPay_Credit.TabIndex = 29
        '
        'frmpayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 359)
        Me.Controls.Add(Me.CboEnterPay_Customer)
        Me.Controls.Add(Me.Label84)
        Me.Controls.Add(Me.DtgEnterPay_InvoiceNumAmount)
        Me.Controls.Add(Me.BtnEnterPay_Add)
        Me.Controls.Add(Me.TxtEnterPay_NetAmount)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.LblEnterPay_AvailCredit)
        Me.Controls.Add(Me.LblEnterPay_TotalAmount)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.TxtEnterPay_Remarks)
        Me.Controls.Add(Me.TxtEnterPay_Status1)
        Me.Controls.Add(Me.TxtEnterPay_Credit)
        Me.Name = "frmpayment"
        Me.Text = "Payment"
        CType(Me.DtgEnterPay_InvoiceNumAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CboEnterPay_Customer As ComboBox
    Friend WithEvents Label84 As Label
    Friend WithEvents DtgEnterPay_InvoiceNumAmount As DataGridView
    Friend WithEvents BtnEnterPay_Add As Button
    Friend WithEvents TxtEnterPay_NetAmount As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents LblEnterPay_AvailCredit As Label
    Friend WithEvents LblEnterPay_TotalAmount As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents TxtEnterPay_Remarks As TextBox
    Friend WithEvents TxtEnterPay_Status1 As TextBox
    Friend WithEvents TxtEnterPay_Credit As TextBox
End Class
