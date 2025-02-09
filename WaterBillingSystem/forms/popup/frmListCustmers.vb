Public Class frmListCustmers
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        GroupBox1.Show()
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.BringToFront()
        ''''''''''''''''''''''''''''''''
        DataGridView1.Hide()
        sql = "SELECT (autostart & autoend) FROM tblauto WHERE autocode='cuscode'"
        janAutoNumber(sql, TxtAddCus_Code)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Hide()
        GroupBox1.SendToBack()
        Call frmListCustmers_Load(sender, e)
        DataGridView1.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            sql = "SELECT c.cuscode as [code] ,c.cusfname as [customer name] , c.cuslname as [last name] ," _
                & "c.cusaddress as [address] FROM tblcustomer as c WHERE  c.status = 'PAID' AND actions='Active'" _
                & " and c.cuscode Like '" & TextBox1.Text & "%'"
            myselectstatements(sql, DataGridView1)
            '''''''''''''''''''''''''''
            datacolumsvisible(DataGridView1)
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmListCustmers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sql = "SELECT c.cuscode as [code] ,c.cusfname as [customer name] , c.cuslname as [last name] ," _
                & "c.cusaddress as [address] FROM tblcustomer as c WHERE  c.status = 'PAID' AND actions='Active'"
            myselectstatements(sql, DataGridView1)
            '''''''''''''''''''''''
            datacolumsvisible(DataGridView1)
        Catch ex As Exception
            '    MsgBox(ex.Message & "All customer are not paying yet", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            'If DataGridView1.CurrentRow.Cells(8).Value.ToString() = Nothing Then
            '    datagridselect()
            'Else
            '    datagridselect()
            '    Form1.TxtCreateInvoice_InvoiceNum.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
            'End If

            frmInvoice.CboCreateInvoice_Customer.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            Me.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub
End Class