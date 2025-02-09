Public Class frmManageCustomer
    Private Sub frmManageCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            sql = "SELECT cuscode as [Customer Code],cusfname as [First Name],cuslname as [Last Name],cusaddress as [Address] " &
            "FROM tblcustomer WHERE actions='Active'"
            myselectstatements(sql, DtgManageCus_ViewRecord)
        Catch ex As Exception
            MsgBox(ex.Message & " in tls_managecus_Click")
        End Try
    End Sub

    Private Sub BtnManageCus_Go_Click(sender As Object, e As EventArgs) Handles BtnManageCus_Go.Click
        Try
            If CboManageCus_ActionUsers.Text = "Delete" Then
                sql = "UPDATE tblcustomer SET actions ='Deleted' WHERE cuscode ='" &
                DtgManageCus_ViewRecord.CurrentRow.Cells(0).Value & "'"
                mysql(sql)
                MsgBox("Customer has been deleted.", , "Delete")
                Call frmManageCustomer_Load(sender, e)
            ElseIf CboManageCus_ActionUsers.Text = "Edit" Then
                frmeditcustomer.lbladdcus.Text = "Update Customer"
                frmeditcustomer.TxtAddCus_Code.Text = DtgManageCus_ViewRecord.CurrentRow.Cells(0).Value.ToString
                sql = "SELECT * FROM tblcustomer WHERE cuscode like '%" & frmeditcustomer.TxtAddCus_Code.Text & "%'"
                mysql(sql)
                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        frmeditcustomer.TxtAddCus_Fname.Text = .Item("cusfname")
                        frmeditcustomer.TxtAddCus_Lname.Text = .Item("cuslname")
                        frmeditcustomer.TxtAddCus_NickName.Text = .Item("cusnckname")
                        frmeditcustomer.TxtAddCus_Address.Text = .Item("cusaddress")
                        frmeditcustomer.TxtAddCus_Phone.Text = .Item("phone")
                        frmeditcustomer.TxtAddCus_Mobile.Text = .Item("mobile")

                    End With

                    frmeditcustomer.ShowDialog()
                End If
            Else
                MsgBox("Select your Actions", MsgBoxStyle.Information, "Action")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " in BtnManageCus_Go_Click.")
        End Try
    End Sub

    Private Sub BtnManageCus_Search_Click(sender As Object, e As EventArgs) Handles BtnManageCus_Search.Click
        Try
            sql = "SELECT cuscode as [Customer Code], cusfname as [First Name],cuslname as [Last Name],cusaddress as [Address] " &
            "FROM tblcustomer WHERE cuscode LIKE '%" & TxtManageCus_id.Text & "%' AND actions='Active'"
            myselectstatements(sql, DtgManageCus_ViewRecord)
        Catch ex As Exception
            MsgBox(ex.Message & "in BtnManageCus_Search_Click.")
        End Try
    End Sub
End Class