<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        btn_search = New Button()
        txt_search = New TextBox()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(61, 171)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(446, 156)
        DataGridView1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.PaleVioletRed
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(518, 77)
        Button2.Name = "Button2"
        Button2.Size = New Size(67, 34)
        Button2.TabIndex = 17
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btn_search
        ' 
        btn_search.BackColor = Color.Cornsilk
        btn_search.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_search.ForeColor = SystemColors.ControlDarkDark
        btn_search.Location = New Point(408, 77)
        btn_search.Name = "btn_search"
        btn_search.Size = New Size(75, 34)
        btn_search.TabIndex = 16
        btn_search.Text = "Search"
        btn_search.UseVisualStyleBackColor = False
        ' 
        ' txt_search
        ' 
        txt_search.Location = New Point(46, 77)
        txt_search.Multiline = True
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(334, 38)
        txt_search.TabIndex = 15
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
        Button4.TabIndex = 18
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(605, 365)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(btn_search)
        Controls.Add(txt_search)
        Controls.Add(DataGridView1)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Button4 As Button
End Class
