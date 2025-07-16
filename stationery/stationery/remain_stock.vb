Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class remain_stock
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project_sem_5\stationery\stationery\Database1.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim tbl As New DataTable()
    Dim bm As BindingManagerBase
    Private WithEvents PrintDoc As New PrintDocument()
    Private Sub remain_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load all data when the form is opened
        Dim startDate As DateTime = New DateTime(2000, 1, 1) ' Assuming data does not exist before the year 2000
        Dim endDate As DateTime = DateTime.Now ' Up to the current date

        DisplayInsertedData(startDate, endDate)
    End Sub

    Private Sub DisplayInsertedData(startDate As DateTime, endDate As DateTime)
        Dim query As String = "SELECT id, type, invoice_no, vender, date, product, rate, p_quantity, s_quantity, amount " &
                          "FROM stock WHERE date >= @startDate AND date <= @endDate ORDER BY date"

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@startDate", startDate)
            cmd.Parameters.AddWithValue("@endDate", endDate)

            Using da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' Clear existing controls in the main panel
                Panel1.Controls.Clear()

                ' Group data by month
                Dim groupedData = dt.AsEnumerable().GroupBy(Function(row) New DateTime(row.Field(Of DateTime)("date").Year, row.Field(Of DateTime)("date").Month, 1))

                Dim y As Integer = 10 ' Initial Y position for the first month's data
                For Each group In groupedData
                    Dim month = group.Key
                    Dim monthLabel As New Label()
                    monthLabel.Text = month.ToString("MMMM yyyy")
                    monthLabel.Font = New Font("Arial", 14, FontStyle.Bold)
                    monthLabel.ForeColor = Color.Black
                    monthLabel.Location = New Point(10, y)
                    monthLabel.AutoSize = True
                    Panel1.Controls.Add(monthLabel)
                    y += 30 ' Space below the month label

                    ' Create and add header panel
                    Dim headerPanel As New Panel()
                    headerPanel.Size = New Size(1150, 30)
                    headerPanel.BackColor = Color.LightBlue
                    headerPanel.Location = New Point(10, y)
                    headerPanel.Padding = New Padding(5)

                    Dim headerX As Integer = 10
                    Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
                    Dim headers() As String = {"ID", "Type", "Invoice No", "Vendor", "Date", "Product", "Rate", "P_Quantity", "S_Quantity", "Amount"}

                    For Each header As String In headers
                        Dim headerLabel As New Label()
                        headerLabel.Text = header
                        headerLabel.Location = New Point(headerX, 5)
                        headerLabel.AutoSize = True
                        headerLabel.Font = headerFont
                        headerLabel.ForeColor = Color.Black
                        headerPanel.Controls.Add(headerLabel)
                        headerX += 100 ' Adjust the spacing as needed
                    Next

                    Panel1.Controls.Add(headerPanel)
                    y += 40 ' Space below the header panel

                    ' Variables to store monthly purchase and sales amounts
                    Dim totalPurchaseAmount As Double = 0
                    Dim totalSalesAmount As Double = 0

                    ' Display data in labels inside individual panels for the current month
                    For Each row As DataRow In group
                        Dim rowPanel As New Panel()
                        rowPanel.Size = New Size(1150, 30)
                        rowPanel.Location = New Point(10, y)
                        rowPanel.Padding = New Padding(5)
                        rowPanel.ForeColor = Color.Black
                        rowPanel.BackColor = Color.White

                        Dim x As Integer = 10
                        Dim labelFont As New Font("Arial", 12, FontStyle.Regular)

                        ' Create and position labels for each field in the row
                        Dim idLabel As New Label()
                        idLabel.Text = row("id").ToString()
                        idLabel.Location = New Point(x, 5)
                        idLabel.AutoSize = True
                        idLabel.Font = labelFont
                        rowPanel.Controls.Add(idLabel)
                        x += 100

                        Dim typeLabel As New Label()
                        typeLabel.Text = row("type").ToString()
                        typeLabel.Location = New Point(x, 5)
                        typeLabel.AutoSize = True
                        typeLabel.Font = labelFont
                        rowPanel.Controls.Add(typeLabel)
                        x += 100

                        Dim invoiceNoLabel As New Label()
                        invoiceNoLabel.Text = row("invoice_no").ToString()
                        invoiceNoLabel.Location = New Point(x, 5)
                        invoiceNoLabel.AutoSize = True
                        invoiceNoLabel.Font = labelFont
                        rowPanel.Controls.Add(invoiceNoLabel)
                        x += 100

                        Dim vendorLabel As New Label()
                        vendorLabel.Text = row("vender").ToString()
                        vendorLabel.Location = New Point(x, 5)
                        vendorLabel.AutoSize = True
                        vendorLabel.Font = labelFont
                        rowPanel.Controls.Add(vendorLabel)
                        x += 100

                        Dim dateLabel As New Label()
                        dateLabel.Text = DateTime.Parse(row("date").ToString()).ToString("yyyy-MM-dd")
                        dateLabel.Location = New Point(x, 5)
                        dateLabel.AutoSize = True
                        dateLabel.Font = labelFont
                        rowPanel.Controls.Add(dateLabel)
                        x += 100

                        Dim productLabel As New Label()
                        productLabel.Text = row("product").ToString()
                        productLabel.Location = New Point(x, 5)
                        productLabel.AutoSize = True
                        productLabel.Font = labelFont
                        rowPanel.Controls.Add(productLabel)
                        x += 100

                        Dim rateLabel As New Label()
                        rateLabel.Text = row("rate").ToString()
                        rateLabel.Location = New Point(x, 5)
                        rateLabel.AutoSize = True
                        rateLabel.Font = labelFont
                        rowPanel.Controls.Add(rateLabel)
                        x += 100

                        Dim pQuantityLabel As New Label()
                        pQuantityLabel.Text = If(row("p_quantity") IsNot DBNull.Value, row("p_quantity").ToString(), "0")
                        pQuantityLabel.Location = New Point(x, 5)
                        pQuantityLabel.AutoSize = True
                        pQuantityLabel.Font = labelFont
                        rowPanel.Controls.Add(pQuantityLabel)
                        x += 100

                        Dim sQuantityLabel As New Label()
                        sQuantityLabel.Text = If(row("s_quantity") IsNot DBNull.Value, row("s_quantity").ToString(), "0")
                        sQuantityLabel.Location = New Point(x, 5)
                        sQuantityLabel.AutoSize = True
                        sQuantityLabel.Font = labelFont
                        rowPanel.Controls.Add(sQuantityLabel)
                        x += 100

                        Dim amountLabel As New Label()
                        amountLabel.Text = row("amount").ToString()
                        amountLabel.Location = New Point(x, 5)
                        amountLabel.AutoSize = True
                        amountLabel.Font = labelFont
                        rowPanel.Controls.Add(amountLabel)

                        ' Convert quantities and rate to double and calculate amounts
                        Dim rate As Double
                        Dim pQuantity As Double
                        Dim sQuantity As Double

                        Double.TryParse(row("rate").ToString(), rate)
                        Double.TryParse(row("p_quantity").ToString(), pQuantity)
                        Double.TryParse(row("s_quantity").ToString(), sQuantity)

                        totalPurchaseAmount += pQuantity * rate
                        totalSalesAmount += sQuantity * rate

                        ' Add row panel to the main panel
                        Panel1.Controls.Add(rowPanel)

                        ' Increment Y position for the next row panel
                        y += rowPanel.Height + 10 ' Add some space between panels
                    Next

                    ' Calculate monthly closing balance amount
                    Dim closingBalanceAmount As Double = totalPurchaseAmount - totalSalesAmount

                    ' Create a panel for the closing balance
                    Dim closingBalancePanel As New Panel()
                    closingBalancePanel.Size = New Size(1150, 40) ' Adjust size as needed
                    closingBalancePanel.BackColor = Color.LightGray ' Adjust background color
                    closingBalancePanel.Location = New Point(10, y)
                    closingBalancePanel.Padding = New Padding(10)
                    closingBalancePanel.BorderStyle = BorderStyle.FixedSingle ' Add border for distinction

                    ' Create a label for the closing balance
                    Dim closingBalanceLabel As New Label()
                    closingBalanceLabel.Text = "Closing Balance for " & month.ToString("MMMM yyyy") & ": " & closingBalanceAmount.ToString("C2")
                    closingBalanceLabel.Font = New Font("Arial", 14, FontStyle.Bold)
                    closingBalanceLabel.ForeColor = Color.DarkGreen ' Use a distinctive color
                    closingBalanceLabel.AutoSize = True
                    closingBalancePanel.Controls.Add(closingBalanceLabel)

                    ' Add the closing balance panel to the main panel
                    Panel1.Controls.Add(closingBalancePanel)
                    y += closingBalancePanel.Height + 10 ' Space below the closing balance panel
                Next
            End Using
        End Using

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Panel1.AutoScroll = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim startDate As DateTime = dtpStartDate.Value
        Dim endDate As DateTime = dtpEndDate.Value

        DisplayInsertedData(startDate, endDate)
    End Sub
End Class

