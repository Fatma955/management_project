<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        btn_add = New Button()
        btn_update = New Button()
        btn_delete = New Button()
        Label3 = New Label()
        Label2 = New Label()
        label1 = New Label()
        Txt_pass = New TextBox()
        Txt_email = New TextBox()
        Txt_name = New TextBox()
        Button2 = New Button()
        btn_search = New Button()
        txt_search = New TextBox()
        Label4 = New Label()
        txt_level = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Cornsilk
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlDarkDark
        Button4.Location = New Point(23, 22)
        Button4.Name = "Button4"
        Button4.Size = New Size(39, 38)
        Button4.TabIndex = 19
        Button4.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(35, 145)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(446, 167)
        DataGridView1.TabIndex = 20
        ' 
        ' btn_add
        ' 
        btn_add.BackColor = Color.Cornsilk
        btn_add.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_add.ForeColor = SystemColors.ControlDarkDark
        btn_add.Location = New Point(503, 308)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(178, 51)
        btn_add.TabIndex = 21
        btn_add.Text = "Add New User"
        btn_add.UseVisualStyleBackColor = False
        ' 
        ' btn_update
        ' 
        btn_update.BackColor = Color.Cornsilk
        btn_update.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_update.ForeColor = SystemColors.ControlDarkDark
        btn_update.Location = New Point(503, 376)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(178, 51)
        btn_update.TabIndex = 22
        btn_update.Text = "Update User"
        btn_update.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.Cornsilk
        btn_delete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_delete.ForeColor = SystemColors.ControlDarkDark
        btn_delete.Location = New Point(503, 458)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(178, 51)
        btn_delete.TabIndex = 23
        btn_delete.Text = "Delete User"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.MenuText
        Label3.Location = New Point(79, 439)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 25)
        Label3.TabIndex = 29
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.MenuText
        Label2.Location = New Point(101, 402)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 25)
        Label2.TabIndex = 28
        Label2.Text = "Email"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        label1.ForeColor = SystemColors.MenuText
        label1.Location = New Point(79, 353)
        label1.Name = "label1"
        label1.Size = New Size(100, 25)
        label1.TabIndex = 27
        label1.Text = "UserName"
        ' 
        ' Txt_pass
        ' 
        Txt_pass.Location = New Point(196, 431)
        Txt_pass.Multiline = True
        Txt_pass.Name = "Txt_pass"
        Txt_pass.Size = New Size(195, 33)
        Txt_pass.TabIndex = 26
        ' 
        ' Txt_email
        ' 
        Txt_email.Location = New Point(196, 388)
        Txt_email.Multiline = True
        Txt_email.Name = "Txt_email"
        Txt_email.Size = New Size(195, 33)
        Txt_email.TabIndex = 25
        ' 
        ' Txt_name
        ' 
        Txt_name.Location = New Point(196, 345)
        Txt_name.Multiline = True
        Txt_name.Name = "Txt_name"
        Txt_name.Size = New Size(195, 33)
        Txt_name.TabIndex = 24
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.PaleVioletRed
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(483, 84)
        Button2.Name = "Button2"
        Button2.Size = New Size(67, 34)
        Button2.TabIndex = 32
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btn_search
        ' 
        btn_search.BackColor = Color.Cornsilk
        btn_search.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_search.ForeColor = SystemColors.ControlDarkDark
        btn_search.Location = New Point(393, 84)
        btn_search.Name = "btn_search"
        btn_search.Size = New Size(75, 34)
        btn_search.TabIndex = 31
        btn_search.Text = "Search "
        btn_search.UseVisualStyleBackColor = False
        ' 
        ' txt_search
        ' 
        txt_search.Location = New Point(31, 84)
        txt_search.Multiline = True
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(334, 38)
        txt_search.TabIndex = 30
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.MenuText
        Label4.Location = New Point(79, 486)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 25)
        Label4.TabIndex = 34
        Label4.Text = "LevelNum"
        ' 
        ' txt_level
        ' 
        txt_level.Location = New Point(196, 486)
        txt_level.Multiline = True
        txt_level.Name = "txt_level"
        txt_level.Size = New Size(195, 33)
        txt_level.TabIndex = 35
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(733, 538)
        Controls.Add(txt_level)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(btn_search)
        Controls.Add(txt_search)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(label1)
        Controls.Add(Txt_pass)
        Controls.Add(Txt_email)
        Controls.Add(Txt_name)
        Controls.Add(btn_delete)
        Controls.Add(btn_update)
        Controls.Add(btn_add)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Name = "Form4"
        Text = "Manage Users"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents Txt_pass As TextBox
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Txt_name As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_level As TextBox
End Class
