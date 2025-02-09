Public Class frmPaymentReport
    Private Sub CboPayReports_AllCus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPayReports_AllCus.SelectedIndexChanged

        Try
            If CboPayReports_AllCus.Text = "" Or CboPayReports_AllCus.SelectedValue Is Nothing Then
                'MsgBox("no query")
                CboPayReports_AllCus.Text = "All Customers"
            Else
                sql = " SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name] ,i.invnum as " _
                    & " [Invoice Number] ,i.invdate as [Invoice Date],i.invdue as " _
                    & "[Due Date],s.total2 as [Amount(Pesos)],  paymentdate as [Payment Date] , " _
                    & "s.status as [status]  FROM tblcustomer c,tblcreateinvoice " _
                    & "i,tblsummary s where c.cuscode=i.cuscode and i.invnum = s.invnum" _
                    & " and s.status = 'PAID' and c.cuscode = '" _
                    & CboPayReports_AllCus.SelectedValue.ToString & "'"
                myselectstatements(sql, DtgPayReports_TotalView)
            End If

        Catch ex As Exception
            'MsgBox(ex.Message & "in CboPayReports_AllCus_SelectedIndexChanged")
        End Try
    End Sub

    Private Sub frmPaymentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            ''''''''''''''''''''''''''''''''''''''''
            sql = "SELECT * FROM tblcustomer WHERE status = 'PAID'"
            mycbo(sql, CboPayReports_AllCus)
            CboPayReports_AllCus.Text = "All Customers"
            '''''''''''''''''''''''''''''
            sql = "SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name] ,i.invnum as [Invoice Number]" _
                & ",i.invdate as [Invoice date],i.invdue as [Due Date]," _
                & "s.total2 as [Amount(pesos)], paymentdate as [Payment Date] , s.status as " _
                & "[Status] FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
                & " c.cuscode=i.cuscode and i.invnum = s.invnum and s.status = 'PAID'"
            myselectstatements(sql, DtgPayReports_TotalView)
            ''''''''''''''''''''''''''''''''''''''''''''''''


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnPayReports_Go_Click(sender As Object, e As EventArgs) Handles BtnPayReports_Go.Click
        Try
            CboPayReports_AllCus.Text = "All Customer"
            sql = "SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name] ,i.invnum as [Invoice Number]" _
                & ",i.invdate as [Invoice Date],i.invdue as [Due Date]," _
                & "s.total2 as [Amount(pesos)], paymentdate as [Payment Date] , s.status as " _
                & "[Status] FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
                & " c.cuscode=i.cuscode and i.invnum = s.invnum and s.status = '" _
                & "PAID" & "'"
            myselectstatements(sql, DtgPayReports_TotalView)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DtpPayReports_From_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpPayReports_From.ValueChanged
        Try

            sql = "SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name] ,i.invnum as [Invoice Number]" _
                & ",i.invdate as [Invoice Date],i.invdue as [Due Date]," _
                & "s.total2 as [Amount(Pesos)] ,  paymentdate as [Payment Date] , " _
                & "s.status as [status] FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
                & " c.cuscode=i.cuscode and i.invnum = s.invnum and s.status = 'PAID' and i.invdate like '%" _
                & DtpPayReports_From.Text & "%'"
            myselectstatements(sql, DtgPayReports_TotalView)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DtpPayReports_To_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpPayReports_To.ValueChanged
        Try

            sql = "SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name] ,i.invnum as [Invoice Number]" _
                & ",i.invdate as [Invoice Date],i.invdue as [Due Date]," _
                & "s.total2 as [Amount(Pesos)] ,  paymentdate as [Payment Date] , " _
                & "s.status as [status] FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
                & " c.cuscode=i.cuscode and i.invnum = s.invnum and s.status = 'PAID' and i.invdate like '%" _
                & DtpPayReports_To.Text & "%'"
            myselectstatements(sql, DtgPayReports_TotalView)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class