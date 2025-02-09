Public Class frmStaff
    Private Sub frmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT staff_id as [ID], (staff_lname & ', ' & staff_fname & ' ' & staff_mname) as [Name]," &
          "staff_dbirth as [Date of Birth],datediff('yyyy',staff_dbirth, now) as [Age],staff_add as [Address] " &
          ",status as [Status] FROM tblstaff,tbluser WHERE staff_id=user_id and type = 'Staff'"
        myselectstatements(sql, dtgStaff_List)


    End Sub

    Private Sub btnStaffAdd_Click(sender As Object, e As EventArgs) Handles btnStaffAdd.Click
        GroupBox2.Enabled = True
        smartClear(GroupBox2)
        dtpStaff_dbirth.Value = Now
    End Sub

    Private Sub btnStaffEdit_Click(sender As Object, e As EventArgs) Handles btnStaffEdit.Click
        GroupBox2.Enabled = True
        Try
            txtstaff_id.Text = dtgStaff_List.CurrentRow.Cells(0).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnStaffDelete_Click(sender As Object, e As EventArgs) Handles btnStaffDelete.Click
        Try
            If btnStaffDelete.Text = "Active Now" Then
                sql = "UPDATE tblstaff SET status ='ACTIVE' WHERE staff_id ='" & dtgStaff_List.CurrentRow.Cells(0).Value & "'"
                mysql(sql)
            Else
                sql = "UPDATE tblstaff SET status ='NOT ACTIVE' WHERE staff_id ='" & dtgStaff_List.CurrentRow.Cells(0).Value & "'"
                mysql(sql)
            End If

            Call frmStaff_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAddStaff_Save_Click(sender As Object, e As EventArgs) Handles BtnAddStaff_Save.Click
        Try
            sql = "SELECT staff_id FROM tblstaff WHERE staff_id = '" & txtstaff_id.Text & "'"
            mysql(sql)
            If dt.Rows.Count > 0 Then
                sql = "UPDATE tblstaff SET staff_fname='" & TxtStaff_Fname.Text & "',staff_lname='" & TxtStaff_Lname.Text &
                                        "',staff_mname='" & txtStaff_Mname.Text & "',staff_dbirth='" & dtpStaff_dbirth.Value &
                                        "',staff_add='" & TxtStaff_Address.Text & "', staff_tell='" & TxtStaff_Phone.Text &
                                        "',staff_mobile='" & TxtStaff_Mobile.Text & "',staff_fax='" & TxtStaff_Fax.Text &
                                        "' WHERE staff_id='" & txtstaff_id.Text & "'"
                mysql(sql)
                MsgBox("Staff information has been updated.", , "Update")
            Else
                sql = "INSERT INTO tblstaff (staff_id,staff_fname,staff_lname," &
                                        "staff_mname,staff_dbirth,staff_add," &
                                        "staff_tell,staff_mobile,staff_fax,status) " &
                                        "VALUES ('" & txtstaff_id.Text & "','" &
                                        TxtStaff_Fname.Text & "','" & TxtStaff_Lname.Text _
                                        & "','" & txtStaff_Mname.Text & "','" & dtpStaff_dbirth.Value _
                                        & "','" & TxtStaff_Address.Text & "','" & TxtStaff_Phone.Text _
                                        & "','" & TxtStaff_Mobile.Text & "','" & TxtStaff_Fax.Text & "','ACTIVE')"
                mysql(sql)

                sql = "INSERT INTO tbluser (user_id,username, pass,type) " &
            "VALUES ('" & txtstaff_id.Text & "','" & txtusername.Text & "','" & txtpass.Text & "','Staff')"
                mysql(sql)
                MsgBox("New Staff has been saved.", , "Save")
            End If

            smartClear(GroupBox2)

            ' Call Form1_Load(sender, e)
            GroupBox2.Enabled = False


            sql = "SELECT staff_id as [ID], (staff_lname & ', ' & staff_fname & ' ' & staff_mname) as [Name]," &
         "staff_dbirth as [Date of Birth],datediff('yyyy',staff_dbirth, now) as [Age],staff_add as [Address] " &
         ",status as [Status] FROM tblstaff,tbluser WHERE staff_id=user_id and type = 'Staff'"
            myselectstatements(sql, dtgStaff_List)
        Catch ex As Exception
            MsgBox("You must fill up all the fields given in the area." & ex.Message, MsgBoxStyle.Exclamation)
        Return
        End Try
    End Sub

    Private Sub txtstaff_id_TextChanged(sender As Object, e As EventArgs) Handles txtstaff_id.TextChanged
        Try
            sql = "SELECT * FROM tblstaff,tbluser WHERE staff_id=user_id and staff_id = '" & txtstaff_id.Text & "'"
            mysql(sql)
            If dt.Rows.Count > 0 Then
                TxtStaff_Fname.Text = dt.Rows(0).Item("staff_fname")
                txtStaff_Mname.Text = dt.Rows(0).Item("staff_mname")
                TxtStaff_Lname.Text = dt.Rows(0).Item("staff_lname")
                dtpStaff_dbirth.Value = dt.Rows(0).Item("staff_dbirth")
                TxtStaff_Address.Text = dt.Rows(0).Item("staff_add")
                TxtStaff_Phone.Text = dt.Rows(0).Item("staff_tell")
                TxtStaff_Mobile.Text = dt.Rows(0).Item("staff_mobile")
                TxtStaff_Fax.Text = dt.Rows(0).Item("staff_fax")
                txtusername.Text = dt.Rows(0).Item("username")
                txtpass.Text = dt.Rows(0).Item("pass")
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " in txtstaff_id_TextChanged")
        End Try
    End Sub

    Private Sub dtgStaff_List_Click(sender As Object, e As EventArgs) Handles dtgStaff_List.Click
        Try
            If dtgStaff_List.CurrentRow.Cells(5).Value = "NOT ACTIVE" Then
                btnStaffDelete.Text = "Active Now"
            Else
                btnStaffDelete.Text = "De activate"
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class