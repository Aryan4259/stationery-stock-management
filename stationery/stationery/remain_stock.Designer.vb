<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class remain_stock
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
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        dtpEndDate = New DateTimePicker()
        dtpStartDate = New DateTimePicker()
        Button1 = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(31, 91)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1367, 608)
        Panel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(514, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 33)
        Label2.TabIndex = 3
        Label2.Text = "End Date"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(58, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 33)
        Label1.TabIndex = 2
        Label1.Text = "Start Date"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Location = New Point(657, 48)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(250, 27)
        dtpEndDate.TabIndex = 1
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Location = New Point(212, 48)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(250, 27)
        dtpStartDate.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(937, 49)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "Show"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1037, 49)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 5
        Button2.Text = "Print"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1137, 49)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 6
        Button3.Text = "Add"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' remain_stock
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(28), CByte(36))
        ClientSize = New Size(1433, 729)
        ControlBox = False
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(dtpEndDate)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(dtpStartDate)
        FormBorderStyle = FormBorderStyle.None
        Name = "remain_stock"
        Text = "remain_stock"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
