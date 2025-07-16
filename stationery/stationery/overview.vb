
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class overview
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project_sem_5\stationery\stationery\Database1.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim tbl As New DataTable()
    Dim bm As BindingManagerBase
    Dim str As String

    Private Sub overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT p_quantity, s_quantity FROM stock"
        cmd = New SqlCommand(query, con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()

        Try
            con.Open()
            da.Fill(ds, "stock")
            con.Close()

            Dim pQuantityTotal As Integer = 0
            Dim sQuantityTotal As Integer = 0

            For Each row As DataRow In ds.Tables("stock").Rows
                Dim pQuantity As Integer = 0
                Dim sQuantity As Integer = 0

                If Integer.TryParse(row("p_quantity").ToString(), pQuantity) Then
                    pQuantityTotal += pQuantity
                End If

                If Integer.TryParse(row("s_quantity").ToString(), sQuantity) Then
                    sQuantityTotal += sQuantity
                End If
            Next

            ' Assuming you have two labels named Label1 and Label2
            Label1.Text = pQuantityTotal.ToString()
            Label2.Text = sQuantityTotal.ToString()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        DisplayQuantityData()
        DisplayAmountData()
        AutoScroll = True

    End Sub

    Private Sub DisplayQuantityData()
        Dim query As String = "
SELECT 
    product, 
    SUM(CAST(p_quantity AS INT)) AS p_quantity_total, 
    SUM(CAST(s_quantity AS INT)) AS s_quantity_total, 
    (SUM(CAST(p_quantity AS INT)) - SUM(CAST(s_quantity AS INT))) AS productremain 
FROM 
    stock
GROUP BY 
    product"

        ' Ensure the connection is closed before opening
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using cmd As New SqlCommand(query, con)
            Using da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' Clear existing controls in Panel3
                Panel3.Controls.Clear()

                ' Set Panel3 properties for auto-scrolling
                Panel3.BackColor = Color.FromArgb(20, 20, 20) ' Dark gray
                Panel3.AutoScroll = True

                ' Create and add header panel
                Dim headerPanel As New Panel()
                headerPanel.Size = New Size(1150, 30)
                headerPanel.BackColor = Color.LightBlue
                headerPanel.Location = New Point(10, 10)
                headerPanel.Padding = New Padding(5)

                Dim headerX As Integer = 10
                Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
                Dim headers() As String = {"Product", "Purchase Quantity", "Sales Quantity", "Remaining Stock"}

                For Each header As String In headers
                    Dim headerLabel As New Label()
                    headerLabel.Text = header
                    headerLabel.Location = New Point(headerX, 5)
                    headerLabel.AutoSize = True ' Adjust size automatically
                    headerLabel.Font = headerFont
                    headerLabel.ForeColor = Color.Black
                    headerPanel.Controls.Add(headerLabel)
                    headerX += 250 ' Adjust the spacing as needed
                Next

                Panel3.Controls.Add(headerPanel)

                ' Display data in labels inside individual panels
                Dim y As Integer = 50 ' Initial Y position for the data row panels (below the header panel)
                For Each row As DataRow In dt.Rows
                    Dim rowPanel As New Panel()
                    rowPanel.Size = New Size(1150, 30)
                    rowPanel.Location = New Point(10, y)
                    rowPanel.Padding = New Padding(5)
                    rowPanel.BackColor = Color.White ' Optional, for better visual distinction

                    Dim x As Integer = 10
                    Dim labelFont As New Font("Arial", 12, FontStyle.Regular)

                    Dim productLabel As New Label()
                    productLabel.Text = row("product").ToString()
                    productLabel.Location = New Point(x, 5)
                    productLabel.AutoSize = True ' Adjust size automatically
                    productLabel.Font = labelFont
                    rowPanel.Controls.Add(productLabel)
                    x += 250

                    Dim purchaseQuantityLabel As New Label()
                    purchaseQuantityLabel.Text = If(IsDBNull(row("p_quantity_total")), "0", row("p_quantity_total").ToString())
                    purchaseQuantityLabel.Location = New Point(x, 5)
                    purchaseQuantityLabel.AutoSize = True ' Adjust size automatically
                    purchaseQuantityLabel.Font = labelFont
                    rowPanel.Controls.Add(purchaseQuantityLabel)
                    x += 250

                    Dim salesQuantityLabel As New Label()
                    salesQuantityLabel.Text = If(IsDBNull(row("s_quantity_total")), "0", row("s_quantity_total").ToString())
                    salesQuantityLabel.Location = New Point(x, 5)
                    salesQuantityLabel.AutoSize = True ' Adjust size automatically
                    salesQuantityLabel.Font = labelFont
                    rowPanel.Controls.Add(salesQuantityLabel)
                    x += 250

                    Dim remainingStockLabel As New Label()
                    remainingStockLabel.Text = If(IsDBNull(row("productremain")), "0", row("productremain").ToString())
                    remainingStockLabel.Location = New Point(x, 5)
                    remainingStockLabel.AutoSize = True ' Adjust size automatically
                    remainingStockLabel.Font = labelFont
                    rowPanel.Controls.Add(remainingStockLabel)

                    ' Add row panel to the main panel
                    Panel3.Controls.Add(rowPanel)

                    y += rowPanel.Height + 10 ' Adjust space between rows as needed
                Next

                ' Adjust Panel3's AutoScrollMinSize based on content height
                Panel3.AutoScrollMinSize = New Size(0, y + 50)
            End Using
        End Using

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub












    Private Sub DisplayAmountData()
        Dim query As String = "
SELECT 
    product, 
    SUM(CAST(p_quantity AS FLOAT) * CAST(rate AS FLOAT)) AS purchase_amount_total, 
    SUM(CAST(s_quantity AS FLOAT) * CAST(rate AS FLOAT)) AS sales_amount_total,
    (SUM(CAST(p_quantity AS FLOAT) * CAST(rate AS FLOAT)) - SUM(CAST(s_quantity AS FLOAT) * CAST(rate AS FLOAT))) AS remaining_amount
FROM 
    stock
GROUP BY 
    product"

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using cmd As New SqlCommand(query, con)
            Using da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' Clear existing controls in Panel1
                Panel1.Controls.Clear()

                ' Set Panel1 properties for auto-scrolling
                Panel1.BackColor = Color.FromArgb(20, 20, 20) ' Dark gray
                Panel1.AutoScroll = True

                ' Create and add header panel
                Dim headerPanel As New Panel()
                headerPanel.Size = New Size(1150, 30)
                headerPanel.BackColor = Color.LightBlue
                headerPanel.Location = New Point(10, 10)
                headerPanel.Padding = New Padding(5)

                Dim headerX As Integer = 10
                Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
                Dim headers() As String = {"Product", "Purchase Amount Total", "Sales Amount Total", "Remaining Amount"}

                For Each header As String In headers
                    Dim headerLabel As New Label()
                    headerLabel.Text = header
                    headerLabel.Location = New Point(headerX, 5)
                    headerLabel.AutoSize = True
                    headerLabel.Font = headerFont
                    headerLabel.ForeColor = Color.Black
                    headerPanel.Controls.Add(headerLabel)
                    headerX += 250 ' Adjust the spacing as needed
                Next

                Panel1.Controls.Add(headerPanel)

                ' Display data in labels inside individual panels
                Dim y As Integer = 50
                For Each row As DataRow In dt.Rows
                    Dim rowPanel As New Panel()
                    rowPanel.Size = New Size(1150, 30)
                    rowPanel.Location = New Point(10, y)
                    rowPanel.Padding = New Padding(5)
                    rowPanel.BackColor = Color.White ' Optional, for better visual distinction

                    Dim x As Integer = 10
                    Dim labelFont As New Font("Arial", 12, FontStyle.Regular)

                    Dim productLabel As New Label()
                    productLabel.Text = row("product").ToString()
                    productLabel.Location = New Point(x, 5)
                    productLabel.AutoSize = True
                    productLabel.Font = labelFont
                    rowPanel.Controls.Add(productLabel)
                    x += 250

                    Dim purchaseAmountLabel As New Label()
                    purchaseAmountLabel.Text = If(IsDBNull(row("purchase_amount_total")), "0.00", Convert.ToDouble(row("purchase_amount_total")).ToString("C2"))
                    purchaseAmountLabel.Location = New Point(x, 5)
                    purchaseAmountLabel.AutoSize = True
                    purchaseAmountLabel.Font = labelFont
                    rowPanel.Controls.Add(purchaseAmountLabel)
                    x += 250

                    Dim salesAmountLabel As New Label()
                    salesAmountLabel.Text = If(IsDBNull(row("sales_amount_total")), "0.00", Convert.ToDouble(row("sales_amount_total")).ToString("C2"))
                    salesAmountLabel.Location = New Point(x, 5)
                    salesAmountLabel.AutoSize = True
                    salesAmountLabel.Font = labelFont
                    rowPanel.Controls.Add(salesAmountLabel)
                    x += 250

                    Dim remainingAmountLabel As New Label()
                    remainingAmountLabel.Text = If(IsDBNull(row("remaining_amount")), "0.00", Convert.ToDouble(row("remaining_amount")).ToString("C2"))
                    remainingAmountLabel.Location = New Point(x, 5)
                    remainingAmountLabel.AutoSize = True
                    remainingAmountLabel.Font = labelFont
                    rowPanel.Controls.Add(remainingAmountLabel)

                    ' Add row panel to the main panel
                    Panel1.Controls.Add(rowPanel)

                    y += rowPanel.Height + 10
                Next

                ' Adjust Panel1's AutoScrollMinSize based on content height
                Panel1.AutoScrollMinSize = New Size(0, y + 50)
            End Using
        End Using

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub











End Class