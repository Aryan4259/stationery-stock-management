Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports Windows.Win32.System

Public Class purchase
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project_sem_5\stationery\stationery\Database1.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As DataAdapter
    Dim ds As DataSet
    Dim tbl As New DataTable()
    Dim bm As BindingManagerBase
    Dim str As String
    Private Sub FetchAndDisplayData()
        Dim query As String = "SELECT id, date, invoice_no, vender, product, rate, p_quantity, amount FROM stock WHERE type='purchase'"

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using cmd As New SqlCommand(query, con)
            Using da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' Clear existing controls in the main panel
                Panel1.Controls.Clear()

                ' Create and add header panel
                Dim headerPanel As New Panel()
                headerPanel.Size = New Size(1100, 40)
                headerPanel.BackColor = Color.LightBlue ' Light blue for the header background
                headerPanel.Location = New Point(10, 10)
                headerPanel.Padding = New Padding(5)
                headerPanel.BorderStyle = BorderStyle.FixedSingle

                ' Define the positions for each header
                Dim headerX As Integer = 10
                Dim HeaderFont As New Font("Segoe UI", 14, FontStyle.Bold)

                Dim headers() As String = {"ID", "Date", "Invoice No", "Vendor", "Product", "Rate", "Quantity", "Amount"}
                For Each header As String In headers
                    Dim headerLabel As New Label()
                    headerLabel.Text = header
                    headerLabel.Location = New Point(headerX, 5)
                    headerLabel.AutoSize = True
                    headerLabel.Font = HeaderFont
                    headerLabel.ForeColor = Color.Black ' Darker text for contrast
                    headerPanel.Controls.Add(headerLabel)
                    headerX += 130 ' Adjust the spacing as needed
                Next

                Panel1.Controls.Add(headerPanel)

                ' Display data in labels inside individual panels
                Dim y As Integer = 60 ' Initial Y position for the data row panels (below the header panel)
                Dim labelFont As New Font("Segoe UI", 12, FontStyle.Regular)

                For Each row As DataRow In dt.Rows
                    ' Create a new panel for each row
                    Dim rowPanel As New Panel()
                    rowPanel.Size = New Size(1100, 40)
                    rowPanel.Location = New Point(10, y)
                    rowPanel.Padding = New Padding(5)
                    rowPanel.BackColor = Color.White ' White background for data rows
                    rowPanel.BorderStyle = BorderStyle.FixedSingle

                    ' Define the positions for each field
                    Dim x As Integer = 10

                    ' Create and position labels for each field in the row
                    Dim idLabel As New Label()
                    idLabel.Text = row("id").ToString()
                    idLabel.Location = New Point(x, 10)
                    idLabel.AutoSize = True
                    idLabel.Font = labelFont
                    idLabel.ForeColor = Color.Black ' Black text for visibility
                    rowPanel.Controls.Add(idLabel)
                    x += 130 ' Adjust the spacing as needed

                    Dim dateLabel As New Label()
                    dateLabel.Text = DateTime.Parse(row("date").ToString()).ToString("yyyy-MM-dd")
                    dateLabel.Location = New Point(x, 10)
                    dateLabel.AutoSize = True
                    dateLabel.Font = labelFont
                    dateLabel.ForeColor = Color.Black
                    rowPanel.Controls.Add(dateLabel)
                    x += 130 ' Adjust the spacing as needed

                    Dim invoiceNoLabel As New Label()
                    invoiceNoLabel.Text = row("invoice_no").ToString()
                    invoiceNoLabel.Location = New Point(x, 10)
                    invoiceNoLabel.AutoSize = True
                    invoiceNoLabel.Font = labelFont
                    invoiceNoLabel.ForeColor = Color.Black
                    rowPanel.Controls.Add(invoiceNoLabel)
                    x += 130 ' Adjust the spacing as needed

                    Dim vendorLabel As New Label()
                    vendorLabel.Text = row("vender").ToString()
                    vendorLabel.Location = New Point(x, 10)
                    vendorLabel.AutoSize = True
                    vendorLabel.Font = labelFont
                    vendorLabel.ForeColor = Color.Black
                    rowPanel.Controls.Add(vendorLabel)
                    x += 130 ' Adjust the spacing as needed

                    Dim productLabel As New Label()
                    productLabel.Text = row("product").ToString()
                    productLabel.Location = New Point(x, 10)
                    productLabel.AutoSize = True
                    productLabel.Font = labelFont
                    productLabel.ForeColor = Color.Black
                    rowPanel.Controls.Add(productLabel)
                    x += 130 ' Adjust the spacing as needed

                    Dim rateLabel As New Label()
                    rateLabel.Text = row("rate").ToString()
                    rateLabel.Location = New Point(x, 10)
                    rateLabel.AutoSize = True
                    rateLabel.Font = labelFont
                    rateLabel.ForeColor = Color.Black
                    rowPanel.Controls.Add(rateLabel)
                    x += 130 ' Adjust the spacing as needed

                    Dim quantityLabel As New Label()
                    quantityLabel.Text = row("p_quantity").ToString()
                    quantityLabel.Location = New Point(x, 10)
                    quantityLabel.AutoSize = True
                    quantityLabel.Font = labelFont
                    quantityLabel.ForeColor = Color.Black
                    rowPanel.Controls.Add(quantityLabel)
                    x += 130 ' Adjust the spacing as needed

                    Dim amountLabel As New Label()
                    amountLabel.Text = row("amount").ToString()
                    amountLabel.Location = New Point(x, 10)
                    amountLabel.AutoSize = True
                    amountLabel.Font = labelFont
                    amountLabel.ForeColor = Color.Black
                    rowPanel.Controls.Add(amountLabel)

                    ' Add row panel to the main panel
                    Panel1.Controls.Add(rowPanel)

                    ' Increment Y position for the next row panel
                    y += rowPanel.Height + 5 ' Add some space between panels
                Next
            End Using
        End Using

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub










    Private Sub purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchAndDisplayData()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        AutoScroll = True
    End Sub
End Class