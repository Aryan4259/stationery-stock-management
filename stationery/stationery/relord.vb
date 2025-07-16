Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports Windows.Win32.System

Module relord
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project_sem_5\stationery\stationery\Database1.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As DataAdapter
    Dim ds As DataSet
    Dim tbl As New DataTable()
    Dim bm As BindingManagerBase
    Dim str As String
    Public Function relordd()
        Dim query As String = "SELECT id, type, invoice_no, vender, date, product, rate, p_quantity, s_quantity, amount FROM stock"

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using cmd As New SqlCommand(query, con)
            Using da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)



                ' Variables to store total purchase and sales amounts
                Dim totalPurchaseAmount As Double = 0
                Dim totalSalesAmount As Double = 0

                ' Display data in labels inside individual panels
                For Each row As DataRow In dt.Rows



                    Dim pQuantityLabel As String
                    pQuantityLabel = If(row("p_quantity") IsNot DBNull.Value, row("p_quantity").ToString(), "0")



                    Dim sQuantityLabel As String
                    sQuantityLabel = If(row("s_quantity") IsNot DBNull.Value, row("s_quantity").ToString(), "0")

                    ' Convert quantities and rate to double and calculate amounts
                    Dim rate As Double
                    Dim pQuantity As Double
                    Dim sQuantity As Double

                    Double.TryParse(row("rate").ToString(), rate)
                    Double.TryParse(row("p_quantity").ToString(), pQuantity)
                    Double.TryParse(row("s_quantity").ToString(), sQuantity)

                    totalPurchaseAmount += pQuantity * rate
                    totalSalesAmount += sQuantity * rate
                Next
                ' Calculate closing balance amount
                Dim closingBalanceAmount As Double = totalPurchaseAmount - totalSalesAmount

                ' Display closing balance amount
                dashbord.Label2.Text = closingBalanceAmount.ToString() + " ₹"
                dashbord.Label6.Text = totalPurchaseAmount.ToString() + " ₹"
                dashbord.Label3.Text = totalSalesAmount.ToString() + " ₹"
            End Using
        End Using

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return 0
    End Function
End Module
