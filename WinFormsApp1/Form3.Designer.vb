<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        DataGridView1 = New DataGridView()
        btn_add = New Button()
        btn_update = New Button()
        btn_delete = New Button()
        txt_email = New TextBox()
        Txt_type = New TextBox()
        Txt_price = New TextBox()
        Txt_expired = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(32, 216)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(459, 211)
        DataGridView1.TabIndex = 1
        ' 
        ' btn_add
        ' 
        btn_add.BackColor = Color.Cornsilk
        btn_add.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_add.ForeColor = SystemColors.ControlDarkDark
        btn_add.Location = New Point(32, 124)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(178, 51)
        btn_add.TabIndex = 2
        btn_add.Text = "Add"
        btn_add.UseVisualStyleBackColor = False
        ' 
        ' btn_update
        ' 
        btn_update.BackColor = Color.Cornsilk
        btn_update.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_update.ForeColor = SystemColors.ControlDarkDark
        btn_update.Location = New Point(268, 124)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(178, 51)
        btn_update.TabIndex = 3
        btn_update.Text = "Update"
        btn_update.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.Cornsilk
        btn_delete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_delete.ForeColor = SystemColors.ControlDarkDark
        btn_delete.Location = New Point(537, 124)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(178, 51)
        btn_delete.TabIndex = 4
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(537, 278)
        txt_email.Multiline = True
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(243, 51)
        txt_email.TabIndex = 5
        ' 
        ' Txt_type
        ' 
        Txt_type.Location = New Point(78, 40)
        Txt_type.Multiline = True
        Txt_type.Name = "Txt_type"
        Txt_type.Size = New Size(144, 33)
        Txt_type.TabIndex = 6
        ' 
        ' Txt_price
        ' 
        Txt_price.Location = New Point(335, 40)
        Txt_price.Multiline = True
        Txt_price.Name = "Txt_price"
        Txt_price.Size = New Size(137, 33)
        Txt_price.TabIndex = 7
        ' 
        ' Txt_expired
        ' 
        Txt_expired.Location = New Point(631, 40)
        Txt_expired.Multiline = True
        Txt_expired.Name = "Txt_expired"
        Txt_expired.Size = New Size(137, 33)
        Txt_expired.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.MenuText
        Label1.Location = New Point(21, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 25)
        Label1.TabIndex = 9
        Label1.Text = "Type"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.MenuText
        Label2.Location = New Point(251, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 10
        Label2.Text = "Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.MenuText
        Label3.Location = New Point(492, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 25)
        Label3.TabIndex = 11
        Label3.Text = "Expired Date"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Txt_expired)
        Controls.Add(Txt_price)
        Controls.Add(Txt_type)
        Controls.Add(txt_email)
        Controls.Add(btn_delete)
        Controls.Add(btn_update)
        Controls.Add(btn_add)
        Controls.Add(DataGridView1)
        Name = "Form3"
        Text = "Form3"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Txt_type As TextBox
    Friend WithEvents Txt_price As TextBox
    Friend WithEvents Txt_expired As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
