Public Class frmAccount
    Private Sub BtnProfile_Save_Click(sender As Object, e As EventArgs) Handles BtnProfile_Save.Click
        Try

            sql = "UPDATE tblstaff SET staff_fname='" & TxtProfile_Fname.Text & "',staff_lname='" & TxtProfile_Lname.Text &
                       "',staff_mname='" & TxtProfile_Mname.Text &
                       "',staff_add='" & TxtProfile_Address.Text & "', staff_tell='" & TxtProfile_Phone.Text &
                       "',staff_mobile='" & TxtProfile_Mobile.Text & "',staff_fax='" & TxtProfile_Fax.Text &
                       "' WHERE staff_id='" & userId & "'"
            mysql(sql)

            sql = "UPDATE tbluser SET username='" & txtMyUsername.Text &
                "', pass =  '" & txtMyPassword.Text & "'  WHERE user_id = '" & userId & "'"
            mysql(sql)
            MsgBox("Account has been updated", , "Update user accounts")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            sql = "SELECT * FROM tblstaff,tbluser WHERE user_id=staff_id and user_id='" & userId & "'"
            mysql(sql)
            With dt.Rows(0)
                txtMyUsername.Text = .Item("username")
                txtMyPassword.Text = .Item("pass")
                TxtProfile_Fname.Text = .Item("staff_fname")
                TxtProfile_Mname.Text = .Item("staff_mname")
                TxtProfile_Lname.Text = .Item("staff_lname")
                TxtProfile_Address.Text = .Item("staff_add")
                TxtProfile_Phone.Text = .Item("staff_tell")
                TxtProfile_Mobile.Text = .Item("staff_mobile")
                TxtProfile_Fax.Text = .Item("staff_fax")

            End With
        Catch ex As Exception
            'MsgBox(ex.Message & " in TabControl1_Selected")
        End Try
    End Sub
End Class