Module Module1
    Public usertype As String
    Public userId As String
    Public sql As String
    Public dt As New DataTable
    Public da As New OleDb.OleDbDataAdapter
    Public Function myDBmodule() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
                                         Application.StartupPath & "\db_billing.accdb;Persist Security Info=True")
    End Function
    Dim con As OleDb.OleDbConnection = myDBmodule()
    Public Sub myselectstatements(ByVal sql As String, ByVal dtg As DataGridView)
        Try
            con.Open()
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            dtg.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        ' Form1.TextBox1.Text = Total().ToString("c")
    End Sub
    Public Sub mysql(ByVal sql As String)
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try
        con.Close()
    End Sub
    Public Sub mycbo(ByVal sql As String, ByVal cbo As ComboBox)
        Try
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
            Dim ds As New DataSet
            da.Fill(ds, "db_billing")
            With cbo
                .DataSource = ds.Tables(0)
                .ValueMember = "cuscode"
                .DisplayMember = "cusfname"
            End With

         
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub mycbotax(ByVal sql As String, ByVal cbo As ComboBox)
        Try
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
            Dim ds As New DataSet
            da.Fill(ds, "db_billing")
            cbo.DataSource = ds.Tables(0)
            cbo.ValueMember = "taxable"
            cbo.DisplayMember = "cusfname"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub janAutoNumber(ByVal sql As String, ByVal obj As Object)
        'Try
        con.Open()
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            obj.text = dt.Rows(0).Item(0)
            'Form1.TxtAddCus_Code.Text = dt.Rows.Count & "code"
            'Form1.TxtCreateInvoice_InvoiceNum.Text = "000" & dt.Rows.Count - 1
            'Files.TxtAddCus_Code.Text = dt.Rows.Count & "code"
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
            con.Close()
    End Sub
    Public Sub janAutoNumberUpdate(ByVal autocode As String)
        Try
            con.Open()
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("UPDATE  tblauto SET autoend=autoend+1 WHERE autocode='" & autocode & "'", con)
            Dim dt As New DataTable
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    Public Sub loginSub(ByVal username As TextBox, ByVal pass As TextBox)
        Try
            con.Open()
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter _
            ("SELECT * FROM tbluser WHERE username='" & username.Text & "' and pass='" & pass.Text & "'", con)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                usertype = dt.Rows(0).Item("type")
                userId = dt.Rows(0).Item("user_id")
                MsgBox("Welcome " & usertype)
                Form1.tsLogin.Text = "Logout"
                Form1.tsLogin.Image = My.Resources.logoutCLIP

                If usertype = "Staff" Then
                    visibleStaffMenu("true")
                Else
                    visibleAdminMenu("true")
                End If



            Else
                MsgBox("Account does not exist! Please contact Administrator", MsgBoxStyle.Exclamation, "Not Exist")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
End Module
