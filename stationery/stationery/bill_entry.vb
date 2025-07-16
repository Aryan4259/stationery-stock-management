Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class bill_entry
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project_sem_5\stationery\stationery\Database1.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim tbl As New DataTable()
    Dim bm As BindingManagerBase
    Dim str As String
    Dim dgv As DataGridView ' Declare a DataGridView object

    Private Sub bill_entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoComboBox()
        Panel5.AutoScroll = True ' Enable AutoScroll for Panel5
        InitializeDataGridView() ' Initialize DataGridView on form load
        LoadDataIntoDataGridView() ' Load data into DataGridView
    End Sub

    Private Sub InitializeDataGridView()
        ' Initialize DataGridView and add it to Panel5
        dgv = New DataGridView With {
        .Size = New Size(Panel5.Width, Panel5.Height - 50), ' Adjust the size as needed
        .Location = New Point(0, 300), ' Set the X and Y location
        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
        .BackgroundColor = Color.White
    }
        AddHandler dgv.CellClick, AddressOf dgv_CellClick ' Add event handler for CellClick
        Panel5.Controls.Add(dgv) ' Add DataGridView to Panel5
    End Sub

    Private Sub LoadDataIntoComboBox()
        Dim query As String = "SELECT id, pname FROM product"
        Using cmd As New SqlCommand(query, con)
            Using da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                product.DataSource = dt
                product.DisplayMember = "pname"
                product.ValueMember = "id"
            End Using
        End Using
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        If type.Text.ToLower() = "purchase" Then
            InsertPurchase()
        ElseIf type.Text.ToLower() = "sales" Then
            InsertSales()
        Else
            MsgBox("Please select Purchase type to insert data")
        End If
    End Sub

    Private Sub InsertPurchase()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        str = "INSERT INTO stock(type,invoice_no,vender,date,product,rate,amount,p_quantity) VALUES(@type,@invoice_no,@vender,@date,@product,@rate,@amount,@p_quantity)"
        cmd = New SqlCommand(str, con)
        cmd.Parameters.AddWithValue("@type", type.Text)
        cmd.Parameters.AddWithValue("@invoice_no", invoice_no.Text)
        cmd.Parameters.AddWithValue("@vender", v_c.Text)
        cmd.Parameters.AddWithValue("@date", date1.Text)
        cmd.Parameters.AddWithValue("@product", product.GetItemText(product.SelectedItem))
        cmd.Parameters.AddWithValue("@rate", rate.Text)
        cmd.Parameters.AddWithValue("@amount", amount.Text)
        cmd.Parameters.AddWithValue("@p_quantity", quantity.Text)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data inserted successfully")
        Catch ex As Exception
            MsgBox("Error inserting data: " + ex.Message)
        Finally
            con.Close()
        End Try
        LoadDataIntoDataGridView() ' Refresh DataGridView after insert
    End Sub

    Private Sub InsertSales()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        str = "INSERT INTO stock(type,invoice_no,vender,date,product,rate,amount,s_quantity) VALUES(@type,@invoice_no,@vender,@date,@product,@rate,@amount,@s_quantity)"
        cmd = New SqlCommand(str, con)
        cmd.Parameters.AddWithValue("@type", type.Text)
        cmd.Parameters.AddWithValue("@invoice_no", invoice_no.Text)
        cmd.Parameters.AddWithValue("@vender", v_c.Text)
        cmd.Parameters.AddWithValue("@date", date1.Text)
        cmd.Parameters.AddWithValue("@product", product.GetItemText(product.SelectedItem))
        cmd.Parameters.AddWithValue("@rate", rate.Text)
        cmd.Parameters.AddWithValue("@amount", amount.Text)
        cmd.Parameters.AddWithValue("@s_quantity", quantity.Text)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data inserted successfully")
        Catch ex As Exception
            MsgBox("Error inserting data: " + ex.Message)
        Finally
            con.Close()
        End Try
        LoadDataIntoDataGridView() ' Refresh DataGridView after insert
    End Sub

    Private Sub LoadDataIntoDataGridView()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim query As String = "SELECT * FROM stock"
        Dim cmd As New SqlCommand(query, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgv.DataSource = dt
        con.Close()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        ' Ensure the row index is valid
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)
            ' Populate text boxes with data from the selected row
            type.Text = row.Cells("type").Value.ToString()
            invoice_no.Text = row.Cells("invoice_no").Value.ToString()
            v_c.Text = row.Cells("vender").Value.ToString()
            date1.Text = row.Cells("date").Value.ToString()
            product.Text = row.Cells("product").Value.ToString()
            rate.Text = row.Cells("rate").Value.ToString()
            amount.Text = row.Cells("amount").Value.ToString()
            quantity.Text = If(type.Text.ToLower() = "purchase", row.Cells("p_quantity").Value.ToString(), row.Cells("s_quantity").Value.ToString())
        End If
    End Sub

    Private Sub quantity_TextChanged(sender As Object, e As EventArgs)
        amount.Text = Val(rate.Text) * Val(quantity.Text)
    End Sub

    Private Sub product_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' You can add code here if needed when the selected item changes
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateData() ' Update the data in the database when Button1 is clicked
    End Sub

    Private Sub UpdateData()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        ' Update query to modify the selected record in the database
        Dim updateQuery As String = "UPDATE stock SET type=@type, vender=@vender, date=@date, product=@product, rate=@rate, amount=@amount, " &
                                    "p_quantity=@p_quantity, s_quantity=@s_quantity WHERE invoice_no=@invoice_no"
        cmd = New SqlCommand(updateQuery, con)

        ' Add parameters to the command
        cmd.Parameters.AddWithValue("@type", type.Text)
        cmd.Parameters.AddWithValue("@invoice_no", invoice_no.Text)
        cmd.Parameters.AddWithValue("@vender", v_c.Text)
        cmd.Parameters.AddWithValue("@date", date1.Text)
        cmd.Parameters.AddWithValue("@product", product.GetItemText(product.SelectedItem))
        cmd.Parameters.AddWithValue("@rate", rate.Text)
        cmd.Parameters.AddWithValue("@amount", amount.Text)

        ' Determine which quantity field to update based on the type
        If type.Text.ToLower() = "purchase" Then
            cmd.Parameters.AddWithValue("@p_quantity", quantity.Text)
            cmd.Parameters.AddWithValue("@s_quantity", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@p_quantity", DBNull.Value)
            cmd.Parameters.AddWithValue("@s_quantity", quantity.Text)
        End If

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data updated successfully")
        Catch ex As Exception
            MsgBox("Error updating data: " + ex.Message)
        Finally
            con.Close()
        End Try

        LoadDataIntoDataGridView() ' Refresh DataGridView after update
    End Sub

End Class
