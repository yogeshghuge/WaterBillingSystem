Module md_function
    Public Sub closeChildForm()
        For Each ChildForm As Form In Form1.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Public Sub anyfrm(ByVal frm As Form)
        With frm
            .MdiParent = Form1
            ' .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub
    Public Sub invoiceclear()
        frmInvoice.TxtCreateInvoice_Description.Clear()
        frmInvoice.TxtCreateInvoice_Quantity.Clear()
        frmInvoice.TxtcreateInvoice_total1.Clear()
        frmInvoice.TxtCreateInvoice_Remarks.Text = ""
        frmInvoice.TxtCreateInvoice_SubTotal.Clear()
        frmInvoice.TxtCreateInvoice_Totals.Clear()
        frmInvoice.TxtCreateInvoice_AmountDue.Clear()
        frmInvoice.DtpCreateInvoice_DueDate.Text = Now
        frmInvoice.DtpCreateInvoice_InvoiceDate.Text = Now
        frmInvoice.CboCreateInvoice_Customer.Text = "---Please Select Customer---"
        frmInvoice.TxtCreateInvoice_UnitPrice.Clear()
        frmInvoice.TxtCreateInvoice_Discount.Text = ""
        frmInvoice.ChkCreateInvoice_Taxable.Checked = False
        frmInvoice.TxtCreateInvoice_Salestax.Text = Nothing
    End Sub

    Public Sub visibleStaffMenu(result As String)
        With Form1
            .tsInvoice.Enabled = result
            .tsPayment.Enabled = result
            .tsCustomer.Enabled = result
            .tsReport.Enabled = result
            .tsAccount.Enabled = result
        End With
    End Sub
    Public Sub visibleAdminMenu(result As String)
        With Form1
            .tsInvoice.Enabled = result
            .tsPayment.Enabled = result
            .tsCustomer.Enabled = result
            .tsSettings.Enabled = result
            .tsStaff.Enabled = result
            .tsReport.Enabled = result
            .tsAccount.Enabled = result
        End With
    End Sub
End Module
