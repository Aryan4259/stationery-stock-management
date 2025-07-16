<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_products
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
        Panel5 = New Panel()
        txtcn = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        txtdate = New DateTimePicker()
        txtpn = New TextBox()
        Label6 = New Label()
        Label4 = New Label()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(67), CByte(83), CByte(98))
        Panel5.Controls.Add(txtcn)
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(Button1)
        Panel5.Controls.Add(Button7)
        Panel5.Controls.Add(Button6)
        Panel5.Controls.Add(txtdate)
        Panel5.Controls.Add(txtpn)
        Panel5.Controls.Add(Label6)
        Panel5.Controls.Add(Label4)
        Panel5.Location = New Point(24, 28)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1397, 674)
        Panel5.TabIndex = 20
        ' 
        ' txtcn
        ' 
        txtcn.Font = New Font("Segoe UI", 12F)
        txtcn.Location = New Point(279, 293)
        txtcn.Name = "txtcn"
        txtcn.Size = New Size(307, 34)
        txtcn.TabIndex = 38
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(89, 293)
        Label3.Name = "Label3"
        Label3.Size = New Size(183, 27)
        Label3.TabIndex = 37
        Label3.Text = "Company Name"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1207, 578)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 42)
        Button1.TabIndex = 36
        Button1.Text = "Delete"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(779, 578)
        Button7.Name = "Button7"
        Button7.Size = New Size(111, 42)
        Button7.TabIndex = 35
        Button7.Text = "Update"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(279, 363)
        Button6.Name = "Button6"
        Button6.Size = New Size(111, 42)
        Button6.TabIndex = 34
        Button6.Text = "Add"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' txtdate
        ' 
        txtdate.CalendarForeColor = Color.Black
        txtdate.Font = New Font("Segoe UI", 12F)
        txtdate.Location = New Point(279, 215)
        txtdate.Name = "txtdate"
        txtdate.Size = New Size(250, 34)
        txtdate.TabIndex = 33
        ' 
        ' txtpn
        ' 
        txtpn.Font = New Font("Segoe UI", 12F)
        txtpn.Location = New Point(279, 144)
        txtpn.Name = "txtpn"
        txtpn.Size = New Size(307, 34)
        txtpn.TabIndex = 27
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(89, 215)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 27)
        Label6.TabIndex = 22
        Label6.Text = "Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(89, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 27)
        Label4.TabIndex = 20
        Label4.Text = "Product Name"
        ' 
        ' add_products
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(28), CByte(36))
        ClientSize = New Size(1451, 730)
        ControlBox = False
        Controls.Add(Panel5)
        FormBorderStyle = FormBorderStyle.None
        Name = "add_products"
        Text = "add_products"
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents txtdate As DateTimePicker
    Friend WithEvents txtpn As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcn As TextBox
    Friend WithEvents Label3 As Label
End Class
