Public Class frmInvoiceReport
    Private Sub frmInvoiceReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            sql = "SELECT * FROM tblcustomer"
            mycbo(sql, CboInvoiceReport_AllCus)
            CboInvoiceReport_AllCus.Text = "All Customer"
            ''''''''''''''''''''''''''''''

            sql = " SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name]  ,i.invnum as " _
                & " [Invoice Number] ,i.invdate as [Invoice Date],i.invdue as " _
                & "[Due Date],s.total2 as [Amount(pesos)],  paymentdate as [Payment Date] ," _
                & "s.status as [Status]  FROM tblcustomer c,tblcreateinvoice " _
                & "i,tblsummary s where c.cuscode=i.cuscode and i.invnum = s.invnum "
            myselectstatements(sql, DtgInvoiceReport_ViewAll)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Try

            sql = " SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name] ,i.invnum as " _
                    & " [Invoice Number] ,i.invdate as [Invoice date],i.invdue as " _
                    & "[Due Date],s.total2 as [Amount],  paymentdate as [Payment Date] , " _
                    & "s.status as [status]  FROM tblcustomer c,tblcreateinvoice " _
                    & "i,tblsummary s where c.cuscode=i.cuscode and i.invnum = s.invnum"
            myselectstatements(sql, DtgInvoiceReport_ViewAll)
            CboInvoiceReport_AllCus.Text = "All Customer"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub DtpInvoiceReport_From_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpInvoiceReport_From.ValueChanged
        Try




            If DtpInvoiceReport_From.Text = "" Then
                MsgBox("no query")
            Else
                sql = "SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name] ,i.invnum as [Invoice Number]" _
                    & ",i.invdate as [Invoice date],i.invdue as [Due Date]," _
                    & "s.total2 as [Amount] ,  paymentdate as [Payment Date] , " _
                    & "s.status as [status] FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
                    & " c.cuscode=i.cuscode and i.invnum = s.invnum and i.invdate like '%" _
                    & DtpInvoiceReport_From.Text & "%'"
                myselectstatements(sql, DtgInvoiceReport_ViewAll)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DtpInvoiceReport_To_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpInvoiceReport_To.ValueChanged
        Try
            If DtpInvoiceReport_From.Text = "" Then
                MsgBox("no query")
            Else
                sql = "SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name] ,i.invnum as [Invoice Number]" _
                    & ",i.invdate as [Invoice Date],i.invdue as [Due Date]," _
                    & "s.total2 as [Amount] , paymentdate as [Payment Date] , " _
                    & "s.status as [status] FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
                    & " c.cuscode=i.cuscode and i.invnum = s.invnum and i.invdue like '%" _
                    & DtpInvoiceReport_To.Text & "%'"
                myselectstatements(sql, DtgInvoiceReport_ViewAll)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CboInvoiceReport_AllCus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboInvoiceReport_AllCus.SelectedIndexChanged
        Try
            If CboInvoiceReport_All.Text = "" Or CboInvoiceReport_AllCus.SelectedValue Is Nothing Then
                ' MsgBox("no query")
            Else
                sql = " SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name]  ,i.invnum as " _
                    & " [Invoice Number] ,i.invdate as [Invoice Date],i.invdue as " _
                    & "[Due Date],s.total2 as [Amount], paymentdate as [Payment Date] , " _
                    & "s.status as [status]  FROM tblcustomer c,tblcreateinvoice " _
                    & "i,tblsummary s where c.cuscode=i.cuscode and i.invnum = s.invnum " _
                    & "and c.cuscode = '" & CboInvoiceReport_AllCus.SelectedValue.ToString & "'"
                myselectstatements(sql, DtgInvoiceReport_ViewAll)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message & " in CboInvoiceReport_AllCus_SelectedIndexChanged")
        End Try

    End Sub
End Class