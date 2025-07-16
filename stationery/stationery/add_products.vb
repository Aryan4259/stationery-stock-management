Imports System.Data.Common
Imports System.Data.SqlClient

Public Class add_products
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project_sem_5\stationery\stationery\Database1.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim tbl As New DataTable()
    Dim bm As BindingManagerBase
    Dim str As String

    ' Initialize DataGridView
    Private dgvProducts As New DataGridView()

    Private Sub add_products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up DataGridView properties
        dgvProducts.Size = New Size(600, 300)
        dgvProducts.Location = New Point(600, 100)
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        AddHandler dgvProducts.CellClick, AddressOf dgvProducts_CellClick

        ' Add the DataGridView to Panel5
        Panel5.Controls.Add(dgvProducts)

        ' Load data into the DataGridView
        LoadData()
    End Sub

    Private Sub LoadData()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        ' Query to fetch data from the product table
        str = "SELECT * FROM product"
        da = New SqlDataAdapter(str, con)
        tbl.Clear() ' Clear previous data
        da.Fill(tbl)
        dgvProducts.DataSource = tbl

        con.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (con.State = ConnectionState.Closed) Then
            con.Open()
        End If

        str = "INSERT INTO product (pname, date, cname) VALUES (@pname, @date, @cname)"
        cmd = New SqlCommand(str, con)
        cmd.Parameters.AddWithValue("@pname", txtpn.Text)
        cmd.Parameters.AddWithValue("@date", txtdate.Text)
        cmd.Parameters.AddWithValue("@cname", txtcn.Text)
        cmd.ExecuteNonQuery()

        MsgBox("Data inserted successfully")
        con.Close()

        ' Reload data to reflect the new entry
        LoadData()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Check if a row is selected in the DataGridView
        If dgvProducts.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvProducts.SelectedRows(0)
            Dim productId As Integer = selectedRow.Cells("ID").Value ' Assuming "ID" is the primary key column

            If (con.State = ConnectionState.Closed) Then
                con.Open()
            End If

            ' Update query to modify the selected record
            str = "UPDATE product SET pname = @pname, date = @date, cname = @cname WHERE ID = @ID"
            cmd = New SqlCommand(str, con)
            cmd.Parameters.AddWithValue("@pname", txtpn.Text)
            cmd.Parameters.AddWithValue("@date", txtdate.Text)
            cmd.Parameters.AddWithValue("@cname", txtcn.Text)
            cmd.Parameters.AddWithValue("@ID", productId)

            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MsgBox("Data updated successfully")
            Else
                MsgBox("No matching record found to update")
            End If

            con.Close()

            ' Reload data to reflect the updated entry
            LoadData()
        Else
            MsgBox("Please select a row to update.")
        End If
    End Sub

    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvProducts.Rows(e.RowIndex)
            txtpn.Text = selectedRow.Cells("pname").Value.ToString()
            txtdate.Text = selectedRow.Cells("date").Value.ToString()
            txtcn.Text = selectedRow.Cells("cname").Value.ToString()
        End If
    End Sub
End Class
