Public Class Form1
    Private Sub tsItem_Click(sender As Object, e As EventArgs)
        closeChildForm()
        anyfrm(frmItem)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsInvoice.Click
        closeChildForm()
        anyfrm(frmInvoice)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles tsStaff.Click
        closeChildForm()
        anyfrm(frmStaff)
    End Sub


    Private Sub AddCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCustomerToolStripMenuItem.Click
        closeChildForm()
        anyfrm(frmCustomer)
    End Sub

    Private Sub ManageCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageCustomerToolStripMenuItem.Click
        closeChildForm()
        anyfrm(frmManageCustomer)
    End Sub

    Private Sub InvoiceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceReportToolStripMenuItem.Click
        closeChildForm()
        anyfrm(frmInvoiceReport)
    End Sub

    Private Sub PaymenReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymenReportToolStripMenuItem.Click
        closeChildForm()
        anyfrm(frmPaymentReport)
    End Sub

    Private Sub TaxReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaxReportToolStripMenuItem.Click
        closeChildForm()
        anyfrm(frmTaxReport)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles tsPayment.Click
        closeChildForm()
        anyfrm(frmpayment)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles tsSettings.Click
        closeChildForm()
        anyfrm(frmSettings)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visibleAdminMenu("false")
    End Sub

    Private Sub tsLogin_Click(sender As Object, e As EventArgs) Handles tsLogin.Click
        If tsLogin.Text = "Login" Then
            LoginForm1.ShowDialog()
        Else
            tsLogin.Text = "Login"
            tsLogin.Image = My.Resources.loginCLIP
            visibleAdminMenu("false")
        End If
    End Sub

    Private Sub tsAccount_Click(sender As Object, e As EventArgs) Handles tsAccount.Click
        closeChildForm()
        anyfrm(frmAccount)
    End Sub
End Class
