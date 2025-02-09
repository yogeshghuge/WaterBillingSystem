<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.Label53 = New System.Windows.Forms.Label()
        Me.dtgadminList = New System.Windows.Forms.DataGridView()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtAdminPassword = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtAdminUsername = New System.Windows.Forms.TextBox()
        Me.btnAdminSave = New System.Windows.Forms.Button()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtAdminuserId = New System.Windows.Forms.TextBox()
        CType(Me.dtgadminList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(12, 182)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(196, 25)
        Me.Label53.TabIndex = 19
        Me.Label53.Text = "List Admin Account"
        '
        'dtgadminList
        '
        Me.dtgadminList.AllowUserToAddRows = False
        Me.dtgadminList.AllowUserToDeleteRows = False
        Me.dtgadminList.AllowUserToResizeColumns = False
        Me.dtgadminList.AllowUserToResizeRows = False
        Me.dtgadminList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgadminList.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dtgadminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgadminList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgadminList.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.dtgadminList.Location = New System.Drawing.Point(12, 210)
        Me.dtgadminList.Name = "dtgadminList"
        Me.dtgadminList.RowHeadersVisible = False
        Me.dtgadminList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgadminList.Size = New System.Drawing.Size(680, 193)
        Me.dtgadminList.TabIndex = 18
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(12, 9)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(228, 25)
        Me.Label50.TabIndex = 17
        Me.Label50.Text = "Mange Admin Account"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(177, 120)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(59, 13)
        Me.Label48.TabIndex = 16
        Me.Label48.Text = "Password :"
        '
        'txtAdminPassword
        '
        Me.txtAdminPassword.Location = New System.Drawing.Point(242, 117)
        Me.txtAdminPassword.Name = "txtAdminPassword"
        Me.txtAdminPassword.Size = New System.Drawing.Size(227, 20)
        Me.txtAdminPassword.TabIndex = 15
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(175, 94)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(61, 13)
        Me.Label47.TabIndex = 14
        Me.Label47.Text = "Username :"
        '
        'txtAdminUsername
        '
        Me.txtAdminUsername.Location = New System.Drawing.Point(242, 91)
        Me.txtAdminUsername.Name = "txtAdminUsername"
        Me.txtAdminUsername.Size = New System.Drawing.Size(227, 20)
        Me.txtAdminUsername.TabIndex = 13
        '
        'btnAdminSave
        '
        Me.btnAdminSave.Location = New System.Drawing.Point(394, 143)
        Me.btnAdminSave.Name = "btnAdminSave"
        Me.btnAdminSave.Size = New System.Drawing.Size(75, 23)
        Me.btnAdminSave.TabIndex = 12
        Me.btnAdminSave.Text = "Save"
        Me.btnAdminSave.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(189, 68)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(47, 13)
        Me.Label40.TabIndex = 11
        Me.Label40.Text = "User Id :"
        '
        'txtAdminuserId
        '
        Me.txtAdminuserId.Location = New System.Drawing.Point(242, 65)
        Me.txtAdminuserId.Name = "txtAdminuserId"
        Me.txtAdminuserId.Size = New System.Drawing.Size(100, 20)
        Me.txtAdminuserId.TabIndex = 10
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 416)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.dtgadminList)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.txtAdminPassword)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.txtAdminUsername)
        Me.Controls.Add(Me.btnAdminSave)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.txtAdminuserId)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        CType(Me.dtgadminList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label53 As Label
    Friend WithEvents dtgadminList As DataGridView
    Friend WithEvents Label50 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents txtAdminPassword As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents txtAdminUsername As TextBox
    Friend WithEvents btnAdminSave As Button
    Friend WithEvents Label40 As Label
    Friend WithEvents txtAdminuserId As TextBox
End Class
