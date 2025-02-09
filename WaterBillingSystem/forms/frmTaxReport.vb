Public Class frmTaxReport
    Private Sub frmTaxReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            '''''''''''''''''''''''''''''''''
            sql = "SELECT * FROM tblcustomer as c,tblcreateinvoice " _
            & "as i WHERE c.cuscode = i.cuscode and i.taxable = 'true'"
            mycbotax(sql, CboTaxReport_AllCus)
            CboTaxReport_AllCus.Text = "All Customers"
            ''''''''''''''''''''''''''''''
            sql = "SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name] ,i.invnum as [Invoice Number]" _
               & ",i.invdate as [Invoice Date],i.invdue as [Due Date]," _
               & "s.total2 as [Amount(pesos)],s.salestax as [Tax], " _
               & "paymentdate as [Payment Date] , s.status as [Status] " _
               & "FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
               & " c.cuscode=i.cuscode and i.invnum = s.invnum and i.taxable = 'true' "
            myselectstatements(sql, DtgTaxReport_TotalView)
            ''''''''''''''''''''''''''''''''''''''
            Dim tot As Integer = 0
            For i As Integer = 0 To DtgTaxReport_TotalView.RowCount - 1
                tot += DtgTaxReport_TotalView.Rows(i).Cells(5).Value
            Next

            If tot = 0 Then
                MessageBox.Show("No Records Found")

            End If

            TextBox3.Text = tot
            '''''''''''''''''''''''''''''

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CboTaxReport_AllCus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTaxReport_AllCus.SelectedIndexChanged
        If CboTaxReport_AllCus.SelectedValue IsNot Nothing Then

            Try
                sql = "SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name] ,i.invnum as [Invoice Number]" _
                               & ",i.invdate as [Invoice Date],i.invdue as [Due Date]," _
                               & "s.total2 as [Amount(Pesos)] , s.salestax as [Tax],paymentdate as [Payment Date] , " _
                               & "s.status as [status] FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
                               & " c.cuscode=i.cuscode and i.invnum = s.invnum  and i.taxable = 'true' and c.cuscode = '" _
                               & CboTaxReport_AllCus.SelectedValue.ToString & "'"
                myselectstatements(sql, DtgTaxReport_TotalView)
            Catch ex As Exception
                ' MsgBox(ex.Message & " in CboTaxReport_AllCus_SelectedIndexChanged")
            End Try
        Else
            Try
                sql = "SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name] ,i.invnum as [Invoice Number]" _
                               & ",i.invdate as [Invoice Date],i.invdue as [Due Date]," _
                               & "s.total2 as [Amount(Pesos)] , s.salestax as [Tax],paymentdate as [Payment Date] , " _
                               & "s.status as [status] FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
                               & " c.cuscode=i.cuscode and i.invnum = s.invnum  and i.taxable = 'true' and s.salestax > '0' "
                myselectstatements(sql, DtgTaxReport_TotalView)
            Catch ex As Exception
                ' MsgBox(ex.Message & " in CboTaxReport_AllCus_SelectedIndexChanged")
            End Try
        End If
    End Sub

    Private Sub BtnTaxReport_Go_Click(sender As Object, e As EventArgs) Handles BtnTaxReport_Go.Click
        Try
            CboTaxReport_AllCus.Text = "All Customer"
            sql = "SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name] ,i.invnum as [Invoice Number]" _
               & ",i.invdate as [Invoice date],i.invdue as [Due Date]," _
               & "s.total2 as [Amount(Pesos)] , s.salestax as [Tax], paymentdate as [Payment Date] , " _
               & "s.status as [status] FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
               & " c.cuscode=i.cuscode and i.invnum = s.invnum  and s.salestax > '0'"
            myselectstatements(sql, DtgTaxReport_TotalView)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DtpTaxReport_From_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpTaxReport_From.ValueChanged
        Try

            sql = "SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name] ,i.invnum as [Invoice Number]" _
                & ",i.invdate as [Invoice date],i.invdue as [Due Date]," _
                & "s.total2 as [Amount(Pesos)] , s.salestax as [Tax], paymentdate as [Payment Date] , " _
                & "s.status as [status] FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
                & " c.cuscode=i.cuscode and i.invnum = s.invnum  and i.invdate like '%" _
                & DtpTaxReport_From.Text & "%'"
            myselectstatements(sql, DtgTaxReport_TotalView)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DtpTaxReport_To_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpTaxReport_To.ValueChanged
        Try

            sql = "SELECT (c.cusfname & ' ' & c.cuslname)  as [Customer Name] ,i.invnum as [Invoice Number]" _
                & ",i.invdate as [Invoice Date],i.invdue as [Due Date]," _
                & "s.total2 as [Amount(Pesos)] , s.salestax as [Tax], paymentdate as [Payment Date] , " _
                & "s.status as [status] FROM tblcustomer c,tblcreateinvoice i,tblsummary s WHERE" _
                & " c.cuscode=i.cuscode and i.invnum = s.invnum  and i.invdate like '%" _
                & DtpTaxReport_To.Text & "%'"
            myselectstatements(sql, DtgTaxReport_TotalView)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class