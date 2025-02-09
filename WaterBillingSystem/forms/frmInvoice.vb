Public Class frmInvoice
    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sql = "SELECT invnum FROM tblcreateinvoice"
        'mysql(sql)


        sql = "SELECT * FROM tblcustomer WHERE status = 'PAID' or  status ='open'"
        mycbo(sql, CboCreateInvoice_Customer)
        CboCreateInvoice_Customer.Text = "---Please Select Customer---"

        sql = "SELECT (autostart & autoend) FROM tblauto WHERE autocode='invoiceno'"
        janAutoNumber(sql, TxtCreateInvoice_InvoiceNum)

        sql = " SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name]  ,i.invnum as " _
                & " [Invoice Number] ,i.invdate as [Invoice Date],i.invdue as " _
                & "[Due Date],s.total2 as [Amount(pesos)], paymentdate as [Payment Date]," _
                & "s.status as [Status]  FROM tblcustomer c,tblcreateinvoice " _
                & "i,tblsummary s where c.cuscode=i.cuscode and i.invnum = s.invnum " _
                & "and s.status = 'pay now' AND actions= 'Active'"
            myselectstatements(sql, DtgOpenInvoice_View)

    End Sub

    Private Sub BtnCreateInvioce_SearchCus_Click(sender As Object, e As EventArgs) Handles BtnCreateInvioce_SearchCus.Click

        frmListCustmers.ShowDialog()

    End Sub

    Private Sub BtnCreateInvioce_Save_Click(sender As Object, e As EventArgs) Handles BtnCreateInvioce_Save.Click
        Try
            'If CboCreateInvoice_Customer.Text = "---Please Select Customer---" Then
            '    MsgBox("Select Customer First", MsgBoxStyle.Exclamation, "Select")
            'Else
            sql = "INSERT INTO tblcreateinvoice " &
                "(invnum,invdate,invdue,description,quantity,unitprice,unit" &
                ",discount,total1,taxable,remarks,cuscode ) VALUES ('" & TxtCreateInvoice_InvoiceNum.Text &
                "','" & DtpCreateInvoice_InvoiceDate.Text & "','" & DtpCreateInvoice_DueDate.Text &
                "','" & TxtCreateInvoice_Description.Text & "','" & TxtCreateInvoice_Quantity.Text &
                "','" & TxtCreateInvoice_UnitPrice.Text & "','" & TxtCreateInvoice_Unit.Text &
                "','" & TxtCreateInvoice_Discount.Text & "','" & TxtcreateInvoice_total1.Text &
                "','" & ChkCreateInvoice_Taxable.Checked & "','" & TxtCreateInvoice_Remarks.Text &
                "','" & CboCreateInvoice_Customer.SelectedValue.ToString & "')"
            mysql(sql)

            sql = "INSERT INTO tblsummary  (subtotal,salestax,total2,amountdue,status,invnum,cuscode,credit) " &
            "VALUES ('" & TxtCreateInvoice_SubTotal.Text & "','" & TxtCreateInvoice_Salestax.Text &
            "','" & TxtCreateInvoice_Totals.Text & "','" & TxtCreateInvoice_AmountDue.Text &
            "','pay now','" & TxtCreateInvoice_InvoiceNum.Text &
            "','" & CboCreateInvoice_Customer.SelectedValue.ToString & "','0')"
            mysql(sql)

            sql = "UPDATE tblcustomer SET  status = 'pay now' WHERE cuscode = '" & CboCreateInvoice_Customer.SelectedValue.ToString & "'"
            mysql(sql)
            MsgBox("invoice issued", , "invoice")

            invoiceclear()
            janAutoNumberUpdate("invoiceno")

            Call frmInvoice_Load(sender, e)
            'End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtCreateInvoice_Quantity_TextChanged(sender As Object, e As EventArgs) Handles TxtCreateInvoice_Quantity.TextChanged
        Try
            TxtcreateInvoice_total1.Text = (TxtCreateInvoice_Quantity.Text)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtCreateInvoice_UnitPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtCreateInvoice_UnitPrice.TextChanged
        Try
            TxtcreateInvoice_total1.Text = TxtCreateInvoice_Quantity.Text * Convert.ToDouble(TxtCreateInvoice_UnitPrice.Text)
            TxtcreateInvoice_total1.Text = TxtcreateInvoice_total1.Text - Convert.ToDouble(Val(TxtCreateInvoice_Discount.Text)) * Convert.ToDouble(TxtcreateInvoice_total1.Text / 100)
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtCreateInvoice_Discount_TextChanged(sender As Object, e As EventArgs) Handles TxtCreateInvoice_Discount.TextChanged

        Try
            TxtcreateInvoice_total1.Text = TxtCreateInvoice_Quantity.Text * Convert.ToDouble(TxtCreateInvoice_UnitPrice.Text)
            TxtcreateInvoice_total1.Text = TxtcreateInvoice_total1.Text - Convert.ToDouble(Val(TxtCreateInvoice_Discount.Text)) * Convert.ToDouble(TxtcreateInvoice_total1.Text / 100)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ChkCreateInvoice_Taxable_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCreateInvoice_Taxable.CheckedChanged
        Try
            If ChkCreateInvoice_Taxable.CheckState = CheckState.Checked Then
                TxtCreateInvoice_Salestax.Text = TxtcreateInvoice_total1.Text * Convert.ToDouble(0.12)
            Else
                TxtCreateInvoice_Salestax.Text = Nothing
                TxtCreateInvoice_Salestax.Text = 0
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TxtCreateInvoice_Salestax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCreateInvoice_Salestax.TextChanged
        Try
            TxtCreateInvoice_Totals.Text = TxtCreateInvoice_SubTotal.Text + Convert.ToDouble(Val(TxtCreateInvoice_Salestax.Text))
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtCreateInvoice_Totals_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCreateInvoice_Totals.TextChanged
        Try
            TxtCreateInvoice_AmountDue.Text = TxtCreateInvoice_Totals.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtcreateInvoice_total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtcreateInvoice_total1.TextChanged
        Try
            TxtCreateInvoice_SubTotal.Text = TxtcreateInvoice_total1.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            If ChkCreateInvoice_Taxable.CheckState = CheckState.Checked Then
                TxtCreateInvoice_Salestax.Text = TxtcreateInvoice_total1.Text * Convert.ToDouble(0.12)
            Else
                TxtCreateInvoice_Salestax.Text = Nothing
                TxtCreateInvoice_Salestax.Text = 0
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    'Private Sub DtpOpenInvoice_From_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpOpenInvoice_From.ValueChanged
    '    Try

    '        sql = "SELECT (c.cusfname & ' ' & c.cuslname) as [Customer Name],i.invnum as [Invoice Number]" _
    '            & ",i.invdate as [Invoice Date],i.invdue as [Due Date]," _
    '            & "s.total2 as [Amount(pesos)], paymentdate as [Payment Date] ," _
    '            & " s.status as [Status] FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
    '            & " c.cuscode=i.cuscode and i.invnum = s.invnum and s.status = 'pay now' and i.invdate like '%" _
    '            & DtpOpenInvoice_From.Text & "%'"
    '        myselectstatements(sql, DtgOpenInvoice_View)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub DtpOpenInvoice_To_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpOpenInvoice_To.ValueChanged
    '    Try

    '        sql = "SELECT (c.cusfname & ' ' & c.cuslname) as [Customer Name],i.invnum as [Invoice Number]" _
    '            & ",i.invdate as [Invoice Date],i.invdue as [Due Date]," _
    '            & "s.total2 as [Amount(pesos)], paymentdate as [Payment Date] ," _
    '            & " s.status as [Status] FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
    '            & " c.cuscode=i.cuscode and i.invnum = s.invnum and s.status = 'pay now' and i.invdate like '%" _
    '            & DtpOpenInvoice_To.Text & "%'"
    '        myselectstatements(sql, DtgOpenInvoice_View)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            sql = "SELECT (c.cusfname & ' ' & c.cuslname) as [Customer Name],i.invnum as [Invoice Number]" _
            & ",i.invdate as [Invoice Date],i.invdue as [Due Date]," _
            & "s.total2 as [Amount(pesos)], paymentdate as [Payment Date] ," _
            & " s.status as [Status] FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
            & " c.cuscode=i.cuscode and i.invnum = s.invnum and s.status = 'pay now' and Format (invdate, 'mm/dd/yyyy') >= '" _
            & DtpOpenInvoice_From.Value & "' and Format (invdate, 'mm/dd/yyyy') <='" _
            & DtpOpenInvoice_To.Value & "'"
            myselectstatements(sql, DtgOpenInvoice_View)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class