Public Class frmeditcustomer
    Private Sub BtnAddCus_Save_Click(sender As Object, e As EventArgs) Handles BtnAddCus_Save.Click
        Try
            sql = "UPDATE tblcustomer SET cusfname='" & TxtAddCus_Fname.Text &
             "',cuslname='" & TxtAddCus_Lname.Text & "',cusnckname='" & TxtAddCus_NickName.Text &
             "'," & "cusaddress='" & TxtAddCus_Address.Text & "',phone='" & TxtAddCus_Phone.Text &
             "',mobile='" & TxtAddCus_Mobile.Text & "' WHERE cuscode='" & TxtAddCus_Code.Text & "'"
            mysql(sql)
            MsgBox("Customer has been updated.", , "Update")
            Me.Close()

            sql = "SELECT cuscode as [Customer Code],cusfname as [First Name],cuslname as [Last Name],cusaddress as [Address] " &
           "FROM tblcustomer WHERE actions='Active'"
            myselectstatements(sql, frmManageCustomer.DtgManageCus_ViewRecord)

        Catch ex As Exception

        End Try
    End Sub
End Class