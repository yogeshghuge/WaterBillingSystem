Public Class frmSettings
    Private Sub btnAdminSave_Click(sender As Object, e As EventArgs) Handles btnAdminSave.Click
        Try
            sql = "INSERT INTO tbluser (user_id,username,pass,type) " &
            "VALUES ('" & txtAdminuserId.Text & "','" & txtAdminUsername.Text &
            "','" & txtAdminPassword.Text & "','Administrator')"
            mysql(sql)

            sql = "INSERT INTO tblstaff (staff_id,status) VALUES ('" & txtAdminuserId.Text & "','ACTIVE')"
            mysql(sql)

            sql = "SELECT user_id as [ID], username as [Username] FROM tbluser WHERE type = 'Administrator'"
            myselectstatements(sql, dtgadminList)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT user_id as [ID], username as [Username] FROM tbluser WHERE type = 'Administrator'"
        myselectstatements(sql, dtgadminList)
    End Sub
End Class