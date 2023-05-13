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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        DataGridView1 = New DataGridView()
        btn_add = New Button()
        btn_update = New Button()
        btn_delete = New Button()
        txt_search = New TextBox()
        Txt_type = New TextBox()
        Txt_price = New TextBox()
        Txt_expired = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btn_search = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(21, 424)
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
        btn_add.Location = New Point(731, 155)
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
        btn_update.Location = New Point(731, 238)
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
        btn_delete.Location = New Point(731, 325)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(178, 51)
        btn_delete.TabIndex = 4
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' txt_search
        ' 
        txt_search.Location = New Point(189, 27)
        txt_search.Multiline = True
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(334, 38)
        txt_search.TabIndex = 5
        ' 
        ' Txt_type
        ' 
        Txt_type.Location = New Point(347, 181)
        Txt_type.Multiline = True
        Txt_type.Name = "Txt_type"
        Txt_type.Size = New Size(195, 33)
        Txt_type.TabIndex = 6
        ' 
        ' Txt_price
        ' 
        Txt_price.Location = New Point(347, 238)
        Txt_price.Multiline = True
        Txt_price.Name = "Txt_price"
        Txt_price.Size = New Size(195, 33)
        Txt_price.TabIndex = 7
        ' 
        ' Txt_expired
        ' 
        Txt_expired.Location = New Point(347, 294)
        Txt_expired.Multiline = True
        Txt_expired.Name = "Txt_expired"
        Txt_expired.Size = New Size(195, 33)
        Txt_expired.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.MenuText
        Label1.Location = New Point(258, 181)
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
        Label2.Location = New Point(258, 246)
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
        Label3.Location = New Point(222, 302)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 25)
        Label3.TabIndex = 11
        Label3.Text = "Expired Date"
        ' 
        ' btn_search
        ' 
        btn_search.BackColor = Color.Cornsilk
        btn_search.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_search.ForeColor = SystemColors.ControlDarkDark
        btn_search.Location = New Point(551, 27)
        btn_search.Name = "btn_search"
        btn_search.Size = New Size(75, 34)
        btn_search.TabIndex = 12
        btn_search.Text = "Search"
        btn_search.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.NavajoWhite
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlDarkDark
        Button1.Location = New Point(731, 572)
        Button1.Name = "Button1"
        Button1.Size = New Size(178, 51)
        Button1.TabIndex = 13
        Button1.Text = "Manage Users"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.PaleVioletRed
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(661, 27)
        Button2.Name = "Button2"
        Button2.Size = New Size(67, 34)
        Button2.TabIndex = 14
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Cornsilk
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ControlDarkDark
        Button3.Location = New Point(731, 409)
        Button3.Name = "Button3"
        Button3.Size = New Size(178, 51)
        Button3.TabIndex = 15
        Button3.Text = "Expired Items"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Cornsilk
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlDarkDark
        Button4.Location = New Point(12, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(39, 38)
        Button4.TabIndex = 16
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(937, 647)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btn_search)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Txt_expired)
        Controls.Add(Txt_price)
        Controls.Add(Txt_type)
        Controls.Add(txt_search)
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
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Txt_type As TextBox
    Friend WithEvents Txt_price As TextBox
    Friend WithEvents Txt_expired As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
