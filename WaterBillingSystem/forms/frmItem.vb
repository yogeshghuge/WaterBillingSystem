Public Class frmItem
    Private Sub BtnServiceSave_Click(sender As Object, e As EventArgs) Handles BtnServiceSave.Click
        Try
            sql = "INSERT INTO tblservices (service_name,service_desc,service_unitprice,service_unit,service_type)" &
            " VALUES ('" & TxtServiceName.Text & "','" & TxtServiceDesc.Text & "','" & TxtServiceUnitPrice.Text &
            "','" & CboServiceUnit.Text & "','" & CboServiceType.Text & "')"
            mysql(sql)
            MsgBox("New service has been saved.", , "Service Save")
        Catch ex As Exception
            MsgBox(ex.Message & " in BtnAddSer_Save_Click.")
        End Try
    End Sub

    Private Sub frmItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sql = "SELECT service_id as [ID],service_name as [Service Name], " &
            "service_desc as [Service Description], service_unitprice as [Unit Price], " &
            "service_unit as [Unit],service_type as [Type] FROM tblservices"
            myselectstatements(sql, DtgManageSer_Description)
        Catch ex As Exception
            MsgBox(ex.Message & " in TabControl3_Selected")
        End Try
    End Sub
End Class