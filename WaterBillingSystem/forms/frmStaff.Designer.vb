<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtstaff_id = New System.Windows.Forms.TextBox()
        Me.BtnAddStaff_Save = New System.Windows.Forms.Button()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.dtpStaff_dbirth = New System.Windows.Forms.DateTimePicker()
        Me.TxtStaff_Lname = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txtStaff_Mname = New System.Windows.Forms.TextBox()
        Me.TxtStaff_Phone = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.TxtStaff_Fax = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TxtStaff_Fname = New System.Windows.Forms.TextBox()
        Me.TxtStaff_Mobile = New System.Windows.Forms.TextBox()
        Me.TxtStaff_Address = New System.Windows.Forms.TextBox()
        Me.btnStaffAdd = New System.Windows.Forms.Button()
        Me.btnStaffEdit = New System.Windows.Forms.Button()
        Me.btnStaffDelete = New System.Windows.Forms.Button()
        Me.dtgStaff_List = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgStaff_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(311, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(223, 37)
        Me.Label25.TabIndex = 22
        Me.Label25.Text = "Manage Staffs"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.txtpass)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.txtusername)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtstaff_id)
        Me.GroupBox2.Controls.Add(Me.BtnAddStaff_Save)
        Me.GroupBox2.Controls.Add(Me.Label61)
        Me.GroupBox2.Controls.Add(Me.Label60)
        Me.GroupBox2.Controls.Add(Me.dtpStaff_dbirth)
        Me.GroupBox2.Controls.Add(Me.TxtStaff_Lname)
        Me.GroupBox2.Controls.Add(Me.Label56)
        Me.GroupBox2.Controls.Add(Me.Label59)
        Me.GroupBox2.Controls.Add(Me.txtStaff_Mname)
        Me.GroupBox2.Controls.Add(Me.TxtStaff_Phone)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label58)
        Me.GroupBox2.Controls.Add(Me.TxtStaff_Fax)
        Me.GroupBox2.Controls.Add(Me.Label55)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.TxtStaff_Fname)
        Me.GroupBox2.Controls.Add(Me.TxtStaff_Mobile)
        Me.GroupBox2.Controls.Add(Me.TxtStaff_Address)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(12, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(887, 225)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Basic Information"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(380, 134)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(59, 13)
        Me.Label31.TabIndex = 17
        Me.Label31.Text = "Password :"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(441, 131)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(243, 20)
        Me.txtpass.TabIndex = 18
        Me.txtpass.UseSystemPasswordChar = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(50, 131)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(61, 13)
        Me.Label30.TabIndex = 15
        Me.Label30.Text = "Username :"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(117, 128)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(257, 20)
        Me.txtusername.TabIndex = 16
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(64, 27)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 13)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Saff Id  :"
        '
        'txtstaff_id
        '
        Me.txtstaff_id.Location = New System.Drawing.Point(117, 24)
        Me.txtstaff_id.Name = "txtstaff_id"
        Me.txtstaff_id.Size = New System.Drawing.Size(178, 20)
        Me.txtstaff_id.TabIndex = 1
        '
        'BtnAddStaff_Save
        '
        Me.BtnAddStaff_Save.Location = New System.Drawing.Point(757, 189)
        Me.BtnAddStaff_Save.Name = "BtnAddStaff_Save"
        Me.BtnAddStaff_Save.Size = New System.Drawing.Size(124, 30)
        Me.BtnAddStaff_Save.TabIndex = 10
        Me.BtnAddStaff_Save.Text = "Save"
        Me.BtnAddStaff_Save.UseVisualStyleBackColor = True
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(47, 53)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(63, 13)
        Me.Label61.TabIndex = 2
        Me.Label61.Text = "First Name :"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(67, 105)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(44, 13)
        Me.Label60.TabIndex = 2
        Me.Label60.Text = "Phone :"
        '
        'dtpStaff_dbirth
        '
        Me.dtpStaff_dbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStaff_dbirth.Location = New System.Drawing.Point(117, 76)
        Me.dtpStaff_dbirth.Name = "dtpStaff_dbirth"
        Me.dtpStaff_dbirth.Size = New System.Drawing.Size(178, 20)
        Me.dtpStaff_dbirth.TabIndex = 5
        '
        'TxtStaff_Lname
        '
        Me.TxtStaff_Lname.Location = New System.Drawing.Point(373, 50)
        Me.TxtStaff_Lname.Name = "TxtStaff_Lname"
        Me.TxtStaff_Lname.Size = New System.Drawing.Size(205, 20)
        Me.TxtStaff_Lname.TabIndex = 3
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(391, 105)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(44, 13)
        Me.Label56.TabIndex = 2
        Me.Label56.Text = "Mobile :"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(303, 53)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(64, 13)
        Me.Label59.TabIndex = 2
        Me.Label59.Text = "Last Name :"
        '
        'txtStaff_Mname
        '
        Me.txtStaff_Mname.Location = New System.Drawing.Point(665, 50)
        Me.txtStaff_Mname.Name = "txtStaff_Mname"
        Me.txtStaff_Mname.Size = New System.Drawing.Size(169, 20)
        Me.txtStaff_Mname.TabIndex = 4
        '
        'TxtStaff_Phone
        '
        Me.TxtStaff_Phone.Location = New System.Drawing.Point(117, 102)
        Me.TxtStaff_Phone.Name = "TxtStaff_Phone"
        Me.TxtStaff_Phone.Size = New System.Drawing.Size(257, 20)
        Me.TxtStaff_Phone.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(584, 53)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 13)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Middle Name :"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(316, 79)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(51, 13)
        Me.Label58.TabIndex = 2
        Me.Label58.Text = "Address :"
        '
        'TxtStaff_Fax
        '
        Me.TxtStaff_Fax.Location = New System.Drawing.Point(741, 102)
        Me.TxtStaff_Fax.Name = "TxtStaff_Fax"
        Me.TxtStaff_Fax.Size = New System.Drawing.Size(93, 20)
        Me.TxtStaff_Fax.TabIndex = 9
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(36, 79)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(74, 13)
        Me.Label55.TabIndex = 2
        Me.Label55.Text = "Date Of Birth :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(704, 105)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(30, 13)
        Me.Label34.TabIndex = 7
        Me.Label34.Text = "Fax :"
        '
        'TxtStaff_Fname
        '
        Me.TxtStaff_Fname.Location = New System.Drawing.Point(117, 50)
        Me.TxtStaff_Fname.Name = "TxtStaff_Fname"
        Me.TxtStaff_Fname.Size = New System.Drawing.Size(178, 20)
        Me.TxtStaff_Fname.TabIndex = 2
        '
        'TxtStaff_Mobile
        '
        Me.TxtStaff_Mobile.Location = New System.Drawing.Point(441, 102)
        Me.TxtStaff_Mobile.Name = "TxtStaff_Mobile"
        Me.TxtStaff_Mobile.Size = New System.Drawing.Size(243, 20)
        Me.TxtStaff_Mobile.TabIndex = 8
        '
        'TxtStaff_Address
        '
        Me.TxtStaff_Address.Location = New System.Drawing.Point(373, 76)
        Me.TxtStaff_Address.Name = "TxtStaff_Address"
        Me.TxtStaff_Address.Size = New System.Drawing.Size(461, 20)
        Me.TxtStaff_Address.TabIndex = 6
        '
        'btnStaffAdd
        '
        Me.btnStaffAdd.Location = New System.Drawing.Point(638, 203)
        Me.btnStaffAdd.Name = "btnStaffAdd"
        Me.btnStaffAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnStaffAdd.TabIndex = 20
        Me.btnStaffAdd.Text = "Add"
        Me.btnStaffAdd.UseVisualStyleBackColor = True
        '
        'btnStaffEdit
        '
        Me.btnStaffEdit.Location = New System.Drawing.Point(719, 203)
        Me.btnStaffEdit.Name = "btnStaffEdit"
        Me.btnStaffEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnStaffEdit.TabIndex = 19
        Me.btnStaffEdit.Text = "Edit"
        Me.btnStaffEdit.UseVisualStyleBackColor = True
        '
        'btnStaffDelete
        '
        Me.btnStaffDelete.Location = New System.Drawing.Point(800, 202)
        Me.btnStaffDelete.Name = "btnStaffDelete"
        Me.btnStaffDelete.Size = New System.Drawing.Size(99, 23)
        Me.btnStaffDelete.TabIndex = 18
        Me.btnStaffDelete.Text = "De activate"
        Me.btnStaffDelete.UseVisualStyleBackColor = True
        '
        'dtgStaff_List
        '
        Me.dtgStaff_List.AllowUserToAddRows = False
        Me.dtgStaff_List.AllowUserToDeleteRows = False
        Me.dtgStaff_List.AllowUserToResizeColumns = False
        Me.dtgStaff_List.AllowUserToResizeRows = False
        Me.dtgStaff_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgStaff_List.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgStaff_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgStaff_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgStaff_List.Location = New System.Drawing.Point(12, 55)
        Me.dtgStaff_List.Name = "dtgStaff_List"
        Me.dtgStaff_List.RowHeadersVisible = False
        Me.dtgStaff_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgStaff_List.Size = New System.Drawing.Size(887, 141)
        Me.dtgStaff_List.TabIndex = 17
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 474)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnStaffAdd)
        Me.Controls.Add(Me.btnStaffEdit)
        Me.Controls.Add(Me.btnStaffDelete)
        Me.Controls.Add(Me.dtgStaff_List)
        Me.Name = "frmStaff"
        Me.Text = "Staff"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtgStaff_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtstaff_id As TextBox
    Friend WithEvents BtnAddStaff_Save As Button
    Friend WithEvents Label61 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents dtpStaff_dbirth As DateTimePicker
    Friend WithEvents TxtStaff_Lname As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents txtStaff_Mname As TextBox
    Friend WithEvents TxtStaff_Phone As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents TxtStaff_Fax As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents TxtStaff_Fname As TextBox
    Friend WithEvents TxtStaff_Mobile As TextBox
    Friend WithEvents TxtStaff_Address As TextBox
    Friend WithEvents btnStaffAdd As Button
    Friend WithEvents btnStaffEdit As Button
    Friend WithEvents btnStaffDelete As Button
    Friend WithEvents dtgStaff_List As DataGridView
End Class
