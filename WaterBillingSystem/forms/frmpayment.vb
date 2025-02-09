Public Class frmpayment
    Private Sub CboEnterPay_Customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboEnterPay_Customer.SelectedIndexChanged
        If CboEnterPay_Customer.SelectedValue Is Nothing Then

            Return
        End If
        Try

            'MsgBox(CboEnterPay_Customer.SelectedValue)

            sql = "SELECT i.invnum AS [Invoice number], s.total2 AS " _
                           & "[Amount(pesos)],s.credit FROM tblcustomer AS c, tblcreateinvoice " _
                           & "AS i, tblsummary AS s WHERE c.cuscode = i.cuscode " _
                           & "and s.invnum = i.invnum  and c.cuscode = '" _
                           & CboEnterPay_Customer.SelectedValue.ToString & "'"
            myselectstatements(sql, DtgEnterPay_InvoiceNumAmount)
            mysql(sql)

            Dim totamount As Double
            Dim credit As Double

            For Each r As DataRow In dt.Rows
                totamount += r.Item(1)
                credit += r.Item(2)
            Next
            LblEnterPay_TotalAmount.Text = totamount
            LblEnterPay_AvailCredit.Text = credit


        Catch ex As Exception
            '    MsgBox(ex.Message & " in CboEnterPay_Customer_SelectedIndexChanged")
        End Try
    End Sub

    Private Sub frmpayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            '''''''''''''''''''''
            sql = "SELECT * FROM tblcustomer WHERE status = 'pay now'"
            mycbo(sql, CboEnterPay_Customer)
            CboEnterPay_Customer.Text = "---Select Customer----"
            DtgEnterPay_InvoiceNumAmount.Columns.Clear()
            LblEnterPay_TotalAmount.Text = "0"
            LblEnterPay_AvailCredit.Text = "0"
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TxtEnterPay_NetAmount_TextChanged(sender As Object, e As EventArgs) Handles TxtEnterPay_NetAmount.TextChanged
        Try
            If TxtEnterPay_Credit.Text >= LblEnterPay_TotalAmount.Text Then
                TxtEnterPay_Status1.Text = "PAID"
                TxtEnterPay_Credit.Text = Val(TxtEnterPay_NetAmount.Text) + Convert.ToDouble(Val(LblEnterPay_AvailCredit.Text))
                TxtEnterPay_Credit.Text = Val(TxtEnterPay_Credit.Text) - Convert.ToDouble(Val(LblEnterPay_TotalAmount.Text))
            Else
                If TxtEnterPay_NetAmount.Text = "" Then
                    TxtEnterPay_Credit.Clear()
                    TxtEnterPay_Status1.Clear()
                Else
                    TxtEnterPay_Credit.Text = Val(TxtEnterPay_NetAmount.Text) + Convert.ToDouble(Val(LblEnterPay_AvailCredit.Text))
                    TxtEnterPay_Credit.Text = Val(TxtEnterPay_Credit.Text) - Convert.ToDouble(Val(LblEnterPay_TotalAmount.Text))
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnEnterPay_Add_Click(sender As Object, e As EventArgs) Handles BtnEnterPay_Add.Click
        Try
            If TxtEnterPay_Credit.Text < 0 Or CboEnterPay_Customer.Text = "" Then
                MsgBox("Innvalid amount to pay.", MsgBoxStyle.Exclamation, "Pay")
            Else

                sql = "UPDATE tblsummary as s,tblcustomer as c,tblcreateinvoice as i SET [total2] ='" _
                    & LblEnterPay_TotalAmount.Text & "', s.[credit] ='" & TxtEnterPay_Credit.Text &
                    "', s.[netamount] ='0', s.[status] ='PAID' , i.[remarks] ='" _
                    & TxtEnterPay_Remarks.Text & "',c.[status] = 'PAID', paymentdate = now " _
                    & "WHERE s.invnum = i.invnum And i.cuscode = c.cuscode And " _
                    & "c.cusfname like '%" & CboEnterPay_Customer.Text & "%'"
                mysql(sql)
                CboEnterPay_Customer.Text = "---select customer----"
                TxtEnterPay_Remarks.Clear()
                TxtEnterPay_NetAmount.Clear()
                DtgEnterPay_InvoiceNumAmount.Columns.Clear()
                MsgBox("Payments Saved.", , "Payment")
                LblEnterPay_AvailCredit.Text = "0"
                LblEnterPay_TotalAmount.Text = "0"

                Call frmpayment_Load(sender, e)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class