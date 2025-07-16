Imports System.Data.Common
Imports System.Data.SqlClient
Imports Windows.Win32.System

Public Class dashbord

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project_sem_5\stationery\stationery\Database1.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As DataAdapter
    Dim ds As DataSet
    Dim tbl As New DataTable()
    Dim bm As BindingManagerBase
    Dim str As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        While Me.Panel8.Controls.Count > 0
            Me.Panel8.Controls(0).Dispose()


        End While
        Dim nf As New bill_entry With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.Dock = DockStyle.Fill
        Me.Panel8.Controls.Add(nf)
        nf.AutoScroll = True
        nf.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        While Me.Panel8.Controls.Count > 0
            Me.Panel8.Controls(0).Dispose()


        End While
        Dim nf As New overview With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.Dock = DockStyle.Fill
        Me.Panel8.Controls.Add(nf)
        nf.AutoScroll = True
        nf.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        While Me.Panel8.Controls.Count > 0
            Me.Panel8.Controls(0).Dispose()


        End While
        Dim nf As New purchase With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.Dock = DockStyle.Fill
        Me.Panel8.Controls.Add(nf)
        nf.AutoScroll = True
        nf.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        While Me.Panel8.Controls.Count > 0
            Me.Panel8.Controls(0).Dispose()


        End While
        Dim nf As New sales With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.Dock = DockStyle.Fill
        Me.Panel8.Controls.Add(nf)
        nf.AutoScroll = True
        nf.Show()
    End Sub

    Private Sub dashbord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        While Me.Panel8.Controls.Count > 0
            Me.Panel8.Controls(0).Dispose()


        End While
        Dim nf As New overview With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.Dock = DockStyle.Fill
        Me.Panel8.Controls.Add(nf)
        nf.AutoScroll = True
        nf.Show()
        relordd()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        While Panel8.Controls.Count > 0
            Panel8.Controls(0).Dispose()


        End While
        Dim nf As New add_products With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.Dock = DockStyle.Fill
        Panel8.Controls.Add(nf)
        nf.AutoScroll = True
        nf.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        While Me.Panel8.Controls.Count > 0
            Me.Panel8.Controls(0).Dispose()


        End While
        Dim nf As New remain_stock With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.Dock = DockStyle.Fill
        Me.Panel8.Controls.Add(nf)
        nf.AutoScroll = True
        nf.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        While Me.Panel8.Controls.Count > 0
            Me.Panel8.Controls(0).Dispose()


        End While
        Dim nf As New report With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.Dock = DockStyle.Fill
        Me.Panel8.Controls.Add(nf)
        nf.AutoScroll = True
        nf.Show()
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub
End Class