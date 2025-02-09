<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Pnl_CreateInvioce = New System.Windows.Forms.Panel()
        Me.TxtcreateInvoice_total1 = New System.Windows.Forms.TextBox()
        Me.DtpCreateInvoice_DueDate = New System.Windows.Forms.DateTimePicker()
        Me.DtpCreateInvoice_InvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.TxtCreateInvoice_Unit = New System.Windows.Forms.TextBox()
        Me.BtnCreateInvioce_Save = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtCreateInvoice_Remarks = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCreateInvoice_SubTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtCreateInvoice_Totals = New System.Windows.Forms.TextBox()
        Me.TxtCreateInvoice_AmountDue = New System.Windows.Forms.TextBox()
        Me.TxtCreateInvoice_Salestax = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ChkCreateInvoice_Taxable = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.TxtCreateInvoice_Description = New System.Windows.Forms.TextBox()
        Me.TxtCreateInvoice_Quantity = New System.Windows.Forms.TextBox()
        Me.TxtCreateInvoice_Discount = New System.Windows.Forms.TextBox()
        Me.TxtCreateInvoice_UnitPrice = New System.Windows.Forms.TextBox()
        Me.BtnCreateInvioce_SearchCus = New System.Windows.Forms.Button()
        Me.CboCreateInvoice_Customer = New System.Windows.Forms.ComboBox()
        Me.TxtCreateInvoice_InvoiceNum = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Pnl_OpenInvoice = New System.Windows.Forms.Panel()
        Me.DtpOpenInvoice_To = New System.Windows.Forms.DateTimePicker()
        Me.DtpOpenInvoice_From = New System.Windows.Forms.DateTimePicker()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DtgOpenInvoice_View = New System.Windows.Forms.DataGridView()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Pnl_CreateInvioce.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Pnl_OpenInvoice.SuspendLayout()
        CType(Me.DtgOpenInvoice_View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(935, 474)
        Me.TabControl2.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Pnl_CreateInvioce)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(927, 448)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create Invoice"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Pnl_CreateInvioce
        '
        Me.Pnl_CreateInvioce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_CreateInvioce.Controls.Add(Me.TxtcreateInvoice_total1)
        Me.Pnl_CreateInvioce.Controls.Add(Me.DtpCreateInvoice_DueDate)
        Me.Pnl_CreateInvioce.Controls.Add(Me.DtpCreateInvoice_InvoiceDate)
        Me.Pnl_CreateInvioce.Controls.Add(Me.TxtCreateInvoice_Unit)
        Me.Pnl_CreateInvioce.Controls.Add(Me.BtnCreateInvioce_Save)
        Me.Pnl_CreateInvioce.Controls.Add(Me.Label19)
        Me.Pnl_CreateInvioce.Controls.Add(Me.TxtCreateInvoice_Remarks)
        Me.Pnl_CreateInvioce.Controls.Add(Me.GroupBox1)
        Me.Pnl_CreateInvioce.Controls.Add(Me.ChkCreateInvoice_Taxable)
        Me.Pnl_CreateInvioce.Controls.Add(Me.Label18)
        Me.Pnl_CreateInvioce.Controls.Add(Me.Label96)
        Me.Pnl_CreateInvioce.Controls.Add(Me.Label4)
        Me.Pnl_CreateInvioce.Controls.Add(Me.Label93)
        Me.Pnl_CreateInvioce.Controls.Add(Me.Label94)
        Me.Pnl_CreateInvioce.Controls.Add(Me.Label95)
        Me.Pnl_CreateInvioce.Controls.Add(Me.TxtCreateInvoice_Description)
        Me.Pnl_CreateInvioce.Controls.Add(Me.TxtCreateInvoice_Quantity)
        Me.Pnl_CreateInvioce.Controls.Add(Me.TxtCreateInvoice_Discount)
        Me.Pnl_CreateInvioce.Controls.Add(Me.TxtCreateInvoice_UnitPrice)
        Me.Pnl_CreateInvioce.Controls.Add(Me.BtnCreateInvioce_SearchCus)
        Me.Pnl_CreateInvioce.Controls.Add(Me.CboCreateInvoice_Customer)
        Me.Pnl_CreateInvioce.Controls.Add(Me.TxtCreateInvoice_InvoiceNum)
        Me.Pnl_CreateInvioce.Controls.Add(Me.Label10)
        Me.Pnl_CreateInvioce.Controls.Add(Me.Label8)
        Me.Pnl_CreateInvioce.Controls.Add(Me.Label11)
        Me.Pnl_CreateInvioce.Controls.Add(Me.Label7)
        Me.Pnl_CreateInvioce.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_CreateInvioce.Location = New System.Drawing.Point(3, 3)
        Me.Pnl_CreateInvioce.Name = "Pnl_CreateInvioce"
        Me.Pnl_CreateInvioce.Size = New System.Drawing.Size(921, 442)
        Me.Pnl_CreateInvioce.TabIndex = 5
        '
        'TxtcreateInvoice_total1
        '
        Me.TxtcreateInvoice_total1.Location = New System.Drawing.Point(123, 304)
        Me.TxtcreateInvoice_total1.Name = "TxtcreateInvoice_total1"
        Me.TxtcreateInvoice_total1.Size = New System.Drawing.Size(59, 20)
        Me.TxtcreateInvoice_total1.TabIndex = 10
        '
        'DtpCreateInvoice_DueDate
        '
        Me.DtpCreateInvoice_DueDate.CustomFormat = "MM/dd/yyyy"
        Me.DtpCreateInvoice_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpCreateInvoice_DueDate.Location = New System.Drawing.Point(123, 76)
        Me.DtpCreateInvoice_DueDate.Name = "DtpCreateInvoice_DueDate"
        Me.DtpCreateInvoice_DueDate.Size = New System.Drawing.Size(127, 20)
        Me.DtpCreateInvoice_DueDate.TabIndex = 3
        '
        'DtpCreateInvoice_InvoiceDate
        '
        Me.DtpCreateInvoice_InvoiceDate.CustomFormat = "MM/dd/yyyy"
        Me.DtpCreateInvoice_InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpCreateInvoice_InvoiceDate.Location = New System.Drawing.Point(123, 51)
        Me.DtpCreateInvoice_InvoiceDate.Name = "DtpCreateInvoice_InvoiceDate"
        Me.DtpCreateInvoice_InvoiceDate.Size = New System.Drawing.Size(127, 20)
        Me.DtpCreateInvoice_InvoiceDate.TabIndex = 2
        '
        'TxtCreateInvoice_Unit
        '
        Me.TxtCreateInvoice_Unit.Enabled = False
        Me.TxtCreateInvoice_Unit.Location = New System.Drawing.Point(228, 213)
        Me.TxtCreateInvoice_Unit.Name = "TxtCreateInvoice_Unit"
        Me.TxtCreateInvoice_Unit.Size = New System.Drawing.Size(86, 20)
        Me.TxtCreateInvoice_Unit.TabIndex = 16
        Me.TxtCreateInvoice_Unit.Text = "cubic meter"
        '
        'BtnCreateInvioce_Save
        '
        Me.BtnCreateInvioce_Save.Location = New System.Drawing.Point(767, 393)
        Me.BtnCreateInvioce_Save.Name = "BtnCreateInvioce_Save"
        Me.BtnCreateInvioce_Save.Size = New System.Drawing.Size(95, 23)
        Me.BtnCreateInvioce_Save.TabIndex = 12
        Me.BtnCreateInvioce_Save.Text = "Save"
        Me.BtnCreateInvioce_Save.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(62, 333)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 13)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Remarks :"
        '
        'TxtCreateInvoice_Remarks
        '
        Me.TxtCreateInvoice_Remarks.Location = New System.Drawing.Point(118, 330)
        Me.TxtCreateInvoice_Remarks.Multiline = True
        Me.TxtCreateInvoice_Remarks.Name = "TxtCreateInvoice_Remarks"
        Me.TxtCreateInvoice_Remarks.Size = New System.Drawing.Size(321, 63)
        Me.TxtCreateInvoice_Remarks.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCreateInvoice_SubTotal)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TxtCreateInvoice_Totals)
        Me.GroupBox1.Controls.Add(Me.TxtCreateInvoice_AmountDue)
        Me.GroupBox1.Controls.Add(Me.TxtCreateInvoice_Salestax)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Location = New System.Drawing.Point(533, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 156)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Summary"
        '
        'TxtCreateInvoice_SubTotal
        '
        Me.TxtCreateInvoice_SubTotal.BackColor = System.Drawing.Color.Cornsilk
        Me.TxtCreateInvoice_SubTotal.Enabled = False
        Me.TxtCreateInvoice_SubTotal.Location = New System.Drawing.Point(95, 33)
        Me.TxtCreateInvoice_SubTotal.Name = "TxtCreateInvoice_SubTotal"
        Me.TxtCreateInvoice_SubTotal.Size = New System.Drawing.Size(187, 20)
        Me.TxtCreateInvoice_SubTotal.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Sales Tax :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Amount Due :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(30, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Sud-Total :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(-33, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Total :"
        '
        'TxtCreateInvoice_Totals
        '
        Me.TxtCreateInvoice_Totals.BackColor = System.Drawing.Color.Cornsilk
        Me.TxtCreateInvoice_Totals.Enabled = False
        Me.TxtCreateInvoice_Totals.Location = New System.Drawing.Point(95, 89)
        Me.TxtCreateInvoice_Totals.Name = "TxtCreateInvoice_Totals"
        Me.TxtCreateInvoice_Totals.Size = New System.Drawing.Size(187, 20)
        Me.TxtCreateInvoice_Totals.TabIndex = 1
        '
        'TxtCreateInvoice_AmountDue
        '
        Me.TxtCreateInvoice_AmountDue.BackColor = System.Drawing.Color.Cornsilk
        Me.TxtCreateInvoice_AmountDue.Enabled = False
        Me.TxtCreateInvoice_AmountDue.Location = New System.Drawing.Point(95, 115)
        Me.TxtCreateInvoice_AmountDue.Name = "TxtCreateInvoice_AmountDue"
        Me.TxtCreateInvoice_AmountDue.Size = New System.Drawing.Size(187, 20)
        Me.TxtCreateInvoice_AmountDue.TabIndex = 1
        '
        'TxtCreateInvoice_Salestax
        '
        Me.TxtCreateInvoice_Salestax.BackColor = System.Drawing.Color.Cornsilk
        Me.TxtCreateInvoice_Salestax.Enabled = False
        Me.TxtCreateInvoice_Salestax.Location = New System.Drawing.Point(95, 63)
        Me.TxtCreateInvoice_Salestax.Name = "TxtCreateInvoice_Salestax"
        Me.TxtCreateInvoice_Salestax.Size = New System.Drawing.Size(187, 20)
        Me.TxtCreateInvoice_Salestax.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(47, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Totals :"
        '
        'ChkCreateInvoice_Taxable
        '
        Me.ChkCreateInvoice_Taxable.AutoSize = True
        Me.ChkCreateInvoice_Taxable.Location = New System.Drawing.Point(228, 303)
        Me.ChkCreateInvoice_Taxable.Name = "ChkCreateInvoice_Taxable"
        Me.ChkCreateInvoice_Taxable.Size = New System.Drawing.Size(64, 17)
        Me.ChkCreateInvoice_Taxable.TabIndex = 18
        Me.ChkCreateInvoice_Taxable.Text = "Taxable"
        Me.ChkCreateInvoice_Taxable.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(190, 216)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Unit :"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Location = New System.Drawing.Point(62, 278)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(55, 13)
        Me.Label96.TabIndex = 15
        Me.Label96.Text = "Discount :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Total :"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Location = New System.Drawing.Point(51, 150)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(66, 13)
        Me.Label93.TabIndex = 14
        Me.Label93.Text = "Description :"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Location = New System.Drawing.Point(66, 216)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(52, 13)
        Me.Label94.TabIndex = 11
        Me.Label94.Text = "Quantity :"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Location = New System.Drawing.Point(59, 252)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(59, 13)
        Me.Label95.TabIndex = 12
        Me.Label95.Text = "Unit Price :"
        '
        'TxtCreateInvoice_Description
        '
        Me.TxtCreateInvoice_Description.Location = New System.Drawing.Point(123, 147)
        Me.TxtCreateInvoice_Description.Multiline = True
        Me.TxtCreateInvoice_Description.Name = "TxtCreateInvoice_Description"
        Me.TxtCreateInvoice_Description.Size = New System.Drawing.Size(316, 52)
        Me.TxtCreateInvoice_Description.TabIndex = 6
        '
        'TxtCreateInvoice_Quantity
        '
        Me.TxtCreateInvoice_Quantity.Location = New System.Drawing.Point(123, 213)
        Me.TxtCreateInvoice_Quantity.Name = "TxtCreateInvoice_Quantity"
        Me.TxtCreateInvoice_Quantity.Size = New System.Drawing.Size(61, 20)
        Me.TxtCreateInvoice_Quantity.TabIndex = 7
        '
        'TxtCreateInvoice_Discount
        '
        Me.TxtCreateInvoice_Discount.Location = New System.Drawing.Point(123, 275)
        Me.TxtCreateInvoice_Discount.Name = "TxtCreateInvoice_Discount"
        Me.TxtCreateInvoice_Discount.Size = New System.Drawing.Size(61, 20)
        Me.TxtCreateInvoice_Discount.TabIndex = 9
        '
        'TxtCreateInvoice_UnitPrice
        '
        Me.TxtCreateInvoice_UnitPrice.Location = New System.Drawing.Point(123, 249)
        Me.TxtCreateInvoice_UnitPrice.Name = "TxtCreateInvoice_UnitPrice"
        Me.TxtCreateInvoice_UnitPrice.Size = New System.Drawing.Size(61, 20)
        Me.TxtCreateInvoice_UnitPrice.TabIndex = 8
        '
        'BtnCreateInvioce_SearchCus
        '
        Me.BtnCreateInvioce_SearchCus.Location = New System.Drawing.Point(276, 111)
        Me.BtnCreateInvioce_SearchCus.Name = "BtnCreateInvioce_SearchCus"
        Me.BtnCreateInvioce_SearchCus.Size = New System.Drawing.Size(56, 23)
        Me.BtnCreateInvioce_SearchCus.TabIndex = 5
        Me.BtnCreateInvioce_SearchCus.Text = "List"
        Me.BtnCreateInvioce_SearchCus.UseVisualStyleBackColor = True
        '
        'CboCreateInvoice_Customer
        '
        Me.CboCreateInvoice_Customer.FormattingEnabled = True
        Me.CboCreateInvoice_Customer.Location = New System.Drawing.Point(121, 113)
        Me.CboCreateInvoice_Customer.Name = "CboCreateInvoice_Customer"
        Me.CboCreateInvoice_Customer.Size = New System.Drawing.Size(149, 21)
        Me.CboCreateInvoice_Customer.TabIndex = 4
        Me.CboCreateInvoice_Customer.Text = "---Please Select Customer---"
        '
        'TxtCreateInvoice_InvoiceNum
        '
        Me.TxtCreateInvoice_InvoiceNum.Location = New System.Drawing.Point(123, 24)
        Me.TxtCreateInvoice_InvoiceNum.Name = "TxtCreateInvoice_InvoiceNum"
        Me.TxtCreateInvoice_InvoiceNum.Size = New System.Drawing.Size(127, 20)
        Me.TxtCreateInvoice_InvoiceNum.TabIndex = 1
        Me.TxtCreateInvoice_InvoiceNum.Text = "0000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(58, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Due Date :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Invoice Number :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(58, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Customer :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Invoice Date : "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Pnl_OpenInvoice)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(927, 448)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Open Invoice"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Pnl_OpenInvoice
        '
        Me.Pnl_OpenInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_OpenInvoice.Controls.Add(Me.DtpOpenInvoice_To)
        Me.Pnl_OpenInvoice.Controls.Add(Me.DtpOpenInvoice_From)
        Me.Pnl_OpenInvoice.Controls.Add(Me.Button7)
        Me.Pnl_OpenInvoice.Controls.Add(Me.DtgOpenInvoice_View)
        Me.Pnl_OpenInvoice.Controls.Add(Me.Label22)
        Me.Pnl_OpenInvoice.Controls.Add(Me.Label27)
        Me.Pnl_OpenInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_OpenInvoice.Location = New System.Drawing.Point(3, 3)
        Me.Pnl_OpenInvoice.Name = "Pnl_OpenInvoice"
        Me.Pnl_OpenInvoice.Size = New System.Drawing.Size(921, 442)
        Me.Pnl_OpenInvoice.TabIndex = 6
        '
        'DtpOpenInvoice_To
        '
        Me.DtpOpenInvoice_To.CustomFormat = "MM/dd/yyyy"
        Me.DtpOpenInvoice_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpOpenInvoice_To.Location = New System.Drawing.Point(696, 29)
        Me.DtpOpenInvoice_To.Name = "DtpOpenInvoice_To"
        Me.DtpOpenInvoice_To.Size = New System.Drawing.Size(131, 20)
        Me.DtpOpenInvoice_To.TabIndex = 8
        '
        'DtpOpenInvoice_From
        '
        Me.DtpOpenInvoice_From.CustomFormat = "MM/dd/yyyy"
        Me.DtpOpenInvoice_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpOpenInvoice_From.Location = New System.Drawing.Point(526, 29)
        Me.DtpOpenInvoice_From.Name = "DtpOpenInvoice_From"
        Me.DtpOpenInvoice_From.Size = New System.Drawing.Size(132, 20)
        Me.DtpOpenInvoice_From.TabIndex = 7
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(833, 26)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(70, 23)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Go"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DtgOpenInvoice_View
        '
        Me.DtgOpenInvoice_View.AllowUserToAddRows = False
        Me.DtgOpenInvoice_View.AllowUserToDeleteRows = False
        Me.DtgOpenInvoice_View.AllowUserToResizeColumns = False
        Me.DtgOpenInvoice_View.AllowUserToResizeRows = False
        Me.DtgOpenInvoice_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgOpenInvoice_View.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgOpenInvoice_View.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgOpenInvoice_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgOpenInvoice_View.DefaultCellStyle = DataGridViewCellStyle2
        Me.DtgOpenInvoice_View.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DtgOpenInvoice_View.Location = New System.Drawing.Point(3, 68)
        Me.DtgOpenInvoice_View.Name = "DtgOpenInvoice_View"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgOpenInvoice_View.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DtgOpenInvoice_View.RowHeadersVisible = False
        Me.DtgOpenInvoice_View.Size = New System.Drawing.Size(900, 347)
        Me.DtgOpenInvoice_View.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(484, 35)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 13)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "From :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(664, 35)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(26, 13)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "To :"
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 474)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "frmInvoice"
        Me.Text = "INVOICE"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Pnl_CreateInvioce.ResumeLayout(False)
        Me.Pnl_CreateInvioce.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Pnl_OpenInvoice.ResumeLayout(False)
        Me.Pnl_OpenInvoice.PerformLayout()
        CType(Me.DtgOpenInvoice_View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Pnl_CreateInvioce As Panel
    Friend WithEvents TxtcreateInvoice_total1 As TextBox
    Friend WithEvents DtpCreateInvoice_DueDate As DateTimePicker
    Friend WithEvents DtpCreateInvoice_InvoiceDate As DateTimePicker
    Friend WithEvents TxtCreateInvoice_Unit As TextBox
    Friend WithEvents BtnCreateInvioce_Save As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtCreateInvoice_Remarks As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCreateInvoice_SubTotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtCreateInvoice_Totals As TextBox
    Friend WithEvents TxtCreateInvoice_AmountDue As TextBox
    Friend WithEvents TxtCreateInvoice_Salestax As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ChkCreateInvoice_Taxable As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label96 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents TxtCreateInvoice_Description As TextBox
    Friend WithEvents TxtCreateInvoice_Quantity As TextBox
    Friend WithEvents TxtCreateInvoice_Discount As TextBox
    Friend WithEvents TxtCreateInvoice_UnitPrice As TextBox
    Friend WithEvents BtnCreateInvioce_SearchCus As Button
    Friend WithEvents CboCreateInvoice_Customer As ComboBox
    Friend WithEvents TxtCreateInvoice_InvoiceNum As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Pnl_OpenInvoice As Panel
    Friend WithEvents DtpOpenInvoice_To As DateTimePicker
    Friend WithEvents DtpOpenInvoice_From As DateTimePicker
    Friend WithEvents Button7 As Button
    Friend WithEvents DtgOpenInvoice_View As DataGridView
    Friend WithEvents Label22 As Label
    Friend WithEvents Label27 As Label
End Class
