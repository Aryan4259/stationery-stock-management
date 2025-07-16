<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class overview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(overview))
        Panel3 = New Panel()
        Panel4 = New Panel()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        Panel9 = New Panel()
        Label2 = New Label()
        Label6 = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Location = New Point(27, 264)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1362, 407)
        Panel3.TabIndex = 5
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(141), CByte(121), CByte(242))
        Panel4.Controls.Add(PictureBox3)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(Label3)
        Panel4.Location = New Point(27, 36)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(677, 209)
        Panel4.TabIndex = 4
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(413, 15)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(180, 176)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 62)
        Label1.TabIndex = 6
        Label1.Text = "Label1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.InactiveCaptionText
        Label3.Location = New Point(16, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(275, 41)
        Label3.TabIndex = 4
        Label3.Text = "Purchase Quantity"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(81), CByte(207), CByte(232))
        Panel9.Controls.Add(PictureBox1)
        Panel9.Controls.Add(Label2)
        Panel9.Controls.Add(Label6)
        Panel9.Location = New Point(721, 36)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(668, 209)
        Panel9.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 62)
        Label2.TabIndex = 6
        Label2.Text = "Label2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.InactiveCaptionText
        Label6.Location = New Point(23, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(221, 41)
        Label6.TabIndex = 3
        Label6.Text = "Sales Quantity"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Location = New Point(27, 683)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1362, 407)
        Panel1.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(407, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(180, 176)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' overview
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(28), CByte(36))
        ClientSize = New Size(1421, 1102)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Controls.Add(Panel9)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "overview"
        Text = "overview"
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
