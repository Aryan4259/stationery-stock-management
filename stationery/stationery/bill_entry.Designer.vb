<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bill_entry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bill_entry))
        Panel5 = New Panel()
        Button1 = New Button()
        btnreset = New Button()
        btnsubmit = New Button()
        date1 = New DateTimePicker()
        v_c = New TextBox()
        invoice_no = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        type = New ComboBox()
        Label3 = New Label()
        Panel4 = New Panel()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        product = New ComboBox()
        amount = New TextBox()
        quantity = New TextBox()
        rate = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel5
        ' 
        Panel5.AutoScroll = True
        Panel5.BackColor = Color.FromArgb(CByte(67), CByte(83), CByte(98))
        Panel5.Controls.Add(product)
        Panel5.Controls.Add(amount)
        Panel5.Controls.Add(quantity)
        Panel5.Controls.Add(rate)
        Panel5.Controls.Add(Label10)
        Panel5.Controls.Add(Label9)
        Panel5.Controls.Add(Label8)
        Panel5.Controls.Add(Label7)
        Panel5.Controls.Add(Button1)
        Panel5.Controls.Add(btnreset)
        Panel5.Controls.Add(btnsubmit)
        Panel5.Controls.Add(date1)
        Panel5.Controls.Add(v_c)
        Panel5.Controls.Add(invoice_no)
        Panel5.Controls.Add(Label6)
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(Label4)
        Panel5.Controls.Add(type)
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(23, 181)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1381, 639)
        Panel5.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1184, 298)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 42)
        Button1.TabIndex = 37
        Button1.Text = "Update"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnreset
        ' 
        btnreset.Location = New Point(1009, 298)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(111, 42)
        btnreset.TabIndex = 35
        btnreset.Text = "Reset"
        btnreset.UseVisualStyleBackColor = True
        ' 
        ' btnsubmit
        ' 
        btnsubmit.Location = New Point(835, 298)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(111, 42)
        btnsubmit.TabIndex = 34
        btnsubmit.Text = "Submit"
        btnsubmit.UseVisualStyleBackColor = True
        ' 
        ' date1
        ' 
        date1.CalendarForeColor = Color.Black
        date1.Font = New Font("Segoe UI", 12F)
        date1.Location = New Point(201, 232)
        date1.Name = "date1"
        date1.Size = New Size(250, 34)
        date1.TabIndex = 33
        ' 
        ' v_c
        ' 
        v_c.Font = New Font("Segoe UI", 12F)
        v_c.Location = New Point(201, 162)
        v_c.Name = "v_c"
        v_c.Size = New Size(307, 34)
        v_c.TabIndex = 28
        ' 
        ' invoice_no
        ' 
        invoice_no.Font = New Font("Segoe UI", 12F)
        invoice_no.Location = New Point(201, 88)
        invoice_no.Name = "invoice_no"
        invoice_no.Size = New Size(307, 34)
        invoice_no.TabIndex = 27
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(40, 232)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 27)
        Label6.TabIndex = 22
        Label6.Text = "Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(40, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 27)
        Label5.TabIndex = 21
        Label5.Text = "Vender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(40, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 27)
        Label4.TabIndex = 20
        Label4.Text = "Invoice No"
        ' 
        ' type
        ' 
        type.Font = New Font("Segoe UI", 12F)
        type.FormattingEnabled = True
        type.ItemHeight = 28
        type.Items.AddRange(New Object() {"Purchase", "Sales"})
        type.Location = New Point(201, 19)
        type.Name = "type"
        type.Size = New Size(179, 36)
        type.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(40, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 27)
        Label3.TabIndex = 18
        Label3.Text = "Type"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(191), CByte(218), CByte(247))
        Panel4.Controls.Add(PictureBox2)
        Panel4.Controls.Add(Label2)
        Panel4.Location = New Point(23, 22)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1381, 139)
        Panel4.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(11, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 108)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(158, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(255, 54)
        Label2.TabIndex = 3
        Label2.Text = "Bill Entry"
        ' 
        ' product
        ' 
        product.Font = New Font("Segoe UI", 12F)
        product.FormattingEnabled = True
        product.ItemHeight = 28
        product.Location = New Point(823, 28)
        product.Name = "product"
        product.Size = New Size(179, 36)
        product.TabIndex = 45
        ' 
        ' amount
        ' 
        amount.Font = New Font("Segoe UI", 12F)
        amount.Location = New Point(823, 225)
        amount.Name = "amount"
        amount.Size = New Size(307, 34)
        amount.TabIndex = 44
        ' 
        ' quantity
        ' 
        quantity.Font = New Font("Segoe UI", 12F)
        quantity.Location = New Point(823, 161)
        quantity.Name = "quantity"
        quantity.Size = New Size(307, 34)
        quantity.TabIndex = 43
        ' 
        ' rate
        ' 
        rate.Font = New Font("Segoe UI", 12F)
        rate.Location = New Point(823, 97)
        rate.Name = "rate"
        rate.Size = New Size(307, 34)
        rate.TabIndex = 42
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(662, 225)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 27)
        Label10.TabIndex = 41
        Label10.Text = "Amount"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(662, 161)
        Label9.Name = "Label9"
        Label9.Size = New Size(107, 27)
        Label9.TabIndex = 40
        Label9.Text = "Quantity"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(662, 97)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 27)
        Label8.TabIndex = 39
        Label8.Text = "Rate"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(662, 28)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 27)
        Label7.TabIndex = 38
        Label7.Text = "Product"
        ' 
        ' bill_entry
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(28), CByte(36))
        ClientSize = New Size(1435, 857)
        ControlBox = False
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        FormBorderStyle = FormBorderStyle.None
        Name = "bill_entry"
        WindowState = FormWindowState.Maximized
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnreset As Button
    Friend WithEvents btnsubmit As Button
    Friend WithEvents date1 As DateTimePicker
    Friend WithEvents v_c As TextBox
    Friend WithEvents invoice_no As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend Protected WithEvents type As ComboBox
    Friend WithEvents Button1 As Button
    Friend Protected WithEvents product As ComboBox
    Friend WithEvents amount As TextBox
    Friend WithEvents quantity As TextBox
    Friend WithEvents rate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
