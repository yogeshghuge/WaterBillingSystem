Public Class frmCustomer
    Private Sub BtnAddCus_Save_Click(sender As Object, e As EventArgs) Handles BtnAddCus_Save.Click
        Try
            If lbladdcus.Text = "Add Customer" Then
                sql = "INSERT INTO tblcustomer (cusfname,cuslname,cusnckname," _
                   & "cusaddress,phone ,mobile, cuscode,status,actions)" _
                   & "VALUES ('" & TxtAddCus_Fname.Text & "' , '" & TxtAddCus_Lname.Text _
                   & "','" & TxtAddCus_NickName.Text & "','" & TxtAddCus_Address.Text _
                   & "','" & TxtAddCus_Phone.Text & "','" & TxtAddCus_Mobile.Text &
                   "','" & TxtAddCus_Code.Text & "','" & "open" & "','Active')"
                mysql(sql)
                MsgBox("Customer Save", , "Save")
            Else
                sql = "UPDATE tblcustomer SET cusfname='" & TxtAddCus_Fname.Text &
                "',cuslname='" & TxtAddCus_Lname.Text & "',cusnckname='" & TxtAddCus_NickName.Text &
                "'," & "cusaddress='" & TxtAddCus_Address.Text & "',phone='" & TxtAddCus_Phone.Text &
                "',mobile='" & TxtAddCus_Mobile.Text & "' WHERE cuscode='" & TxtAddCus_Code.Text & "'"
                mysql(sql)
                MsgBox("Customer has been updated.", , "Update")
                lbladdcus.Text = "Add Customer"
            End If



            ''''''''''''''''''''''''' 
            janAutoNumberUpdate("cuscode")

            Call frmCustomer_Load(sender, e)

            'lbladdcus.Text = "Add Customer"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        smartClear(Me)
        '''''''''''''''''''''''''''''''''
        sql = "SELECT (autostart & autoend)  FROM tblauto WHERE autocode='cuscode'"
        janAutoNumber(sql, TxtAddCus_Code)
    End Sub
End Class