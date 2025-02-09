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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsInvoice = New System.Windows.Forms.ToolStripButton()
        Me.tsPayment = New System.Windows.Forms.ToolStripButton()
        Me.tsCustomer = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AddCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsStaff = New System.Windows.Forms.ToolStripButton()
        Me.tsSettings = New System.Windows.Forms.ToolStripButton()
        Me.tsReport = New System.Windows.Forms.ToolStripDropDownButton()
        Me.InvoiceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymenReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaxReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAccount = New System.Windows.Forms.ToolStripButton()
        Me.tsLogin = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsInvoice, Me.tsPayment, Me.tsCustomer, Me.tsStaff, Me.tsSettings, Me.tsReport, Me.ToolStripSeparator1, Me.tsAccount, Me.tsLogin})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(953, 52)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsInvoice
        '
        Me.tsInvoice.Image = CType(resources.GetObject("tsInvoice.Image"), System.Drawing.Image)
        Me.tsInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsInvoice.Name = "tsInvoice"
        Me.tsInvoice.Size = New System.Drawing.Size(49, 49)
        Me.tsInvoice.Text = "Invoice"
        Me.tsInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsPayment
        '
        Me.tsPayment.Image = CType(resources.GetObject("tsPayment.Image"), System.Drawing.Image)
        Me.tsPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPayment.Name = "tsPayment"
        Me.tsPayment.Size = New System.Drawing.Size(58, 49)
        Me.tsPayment.Text = "Payment"
        Me.tsPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsCustomer
        '
        Me.tsCustomer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCustomerToolStripMenuItem, Me.ManageCustomerToolStripMenuItem})
        Me.tsCustomer.Image = CType(resources.GetObject("tsCustomer.Image"), System.Drawing.Image)
        Me.tsCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCustomer.Name = "tsCustomer"
        Me.tsCustomer.Size = New System.Drawing.Size(72, 49)
        Me.tsCustomer.Text = "Customer"
        Me.tsCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AddCustomerToolStripMenuItem
        '
        Me.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem"
        Me.AddCustomerToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AddCustomerToolStripMenuItem.Text = "Add Customer"
        '
        'ManageCustomerToolStripMenuItem
        '
        Me.ManageCustomerToolStripMenuItem.Name = "ManageCustomerToolStripMenuItem"
        Me.ManageCustomerToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ManageCustomerToolStripMenuItem.Text = "Manage Customer"
        '
        'tsStaff
        '
        Me.tsStaff.Image = CType(resources.GetObject("tsStaff.Image"), System.Drawing.Image)
        Me.tsStaff.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsStaff.Name = "tsStaff"
        Me.tsStaff.Size = New System.Drawing.Size(35, 49)
        Me.tsStaff.Text = "Staff"
        Me.tsStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsSettings
        '
        Me.tsSettings.Image = CType(resources.GetObject("tsSettings.Image"), System.Drawing.Image)
        Me.tsSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSettings.Name = "tsSettings"
        Me.tsSettings.Size = New System.Drawing.Size(53, 49)
        Me.tsSettings.Text = "Settings"
        Me.tsSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsReport
        '
        Me.tsReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvoiceReportToolStripMenuItem, Me.PaymenReportToolStripMenuItem, Me.TaxReportToolStripMenuItem})
        Me.tsReport.Image = CType(resources.GetObject("tsReport.Image"), System.Drawing.Image)
        Me.tsReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsReport.Name = "tsReport"
        Me.tsReport.Size = New System.Drawing.Size(55, 49)
        Me.tsReport.Text = "Report"
        Me.tsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'InvoiceReportToolStripMenuItem
        '
        Me.InvoiceReportToolStripMenuItem.Name = "InvoiceReportToolStripMenuItem"
        Me.InvoiceReportToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.InvoiceReportToolStripMenuItem.Text = "Invoice Report"
        '
        'PaymenReportToolStripMenuItem
        '
        Me.PaymenReportToolStripMenuItem.Name = "PaymenReportToolStripMenuItem"
        Me.PaymenReportToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PaymenReportToolStripMenuItem.Text = "Paymen Report"
        '
        'TaxReportToolStripMenuItem
        '
        Me.TaxReportToolStripMenuItem.Name = "TaxReportToolStripMenuItem"
        Me.TaxReportToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.TaxReportToolStripMenuItem.Text = "Tax Report"
        '
        'tsAccount
        '
        Me.tsAccount.Image = CType(resources.GetObject("tsAccount.Image"), System.Drawing.Image)
        Me.tsAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAccount.Name = "tsAccount"
        Me.tsAccount.Size = New System.Drawing.Size(56, 49)
        Me.tsAccount.Text = "Account"
        Me.tsAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsLogin
        '
        Me.tsLogin.Image = Global.WaterBillingSystem.My.Resources.Resources.loginCLIP
        Me.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsLogin.Name = "tsLogin"
        Me.tsLogin.Size = New System.Drawing.Size(41, 49)
        Me.tsLogin.Text = "Login"
        Me.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 509)
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Water Billing System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsInvoice As ToolStripButton
    Friend WithEvents tsStaff As ToolStripButton
    Friend WithEvents tsSettings As ToolStripButton
    Friend WithEvents tsLogin As ToolStripButton
    Friend WithEvents tsCustomer As ToolStripDropDownButton
    Friend WithEvents AddCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsReport As ToolStripDropDownButton
    Friend WithEvents InvoiceReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymenReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaxReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsPayment As ToolStripButton
    Friend WithEvents tsAccount As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
