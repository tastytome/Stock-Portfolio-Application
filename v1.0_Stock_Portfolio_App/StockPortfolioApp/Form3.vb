Imports System.IO
Imports System.Text

'--accesses API that imports yahoo finance data (yahoo disabled their own service years ago)
Imports YahooFinanceApi
Public Class Form3
    '--AUTHOR: Thomas Tran
    '--TITLE: Stock Portfolio Application (Advanced)
    '--VERSION: v1.0

    Dim blnInputDataOK As Boolean = False

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--example tickers for testing
        txtTickers.Text = "DHHF.AX,VTS.AX,NDQ.AX,VAS.AX,TSLA,AAPL,GOOG,ETH-USD,BTC-USD,MSFT"
        '--add columns To listview
        lsvStocks.Columns.Add("Symbol", 60, HorizontalAlignment.Left) 'Column 0
        lsvStocks.Columns.Add("Price", 100, HorizontalAlignment.Left) 'Column 1
        lsvStocks.Columns.Add("Change", 80, HorizontalAlignment.Left) 'Column 2
        lsvStocks.Columns.Add("Change %", 80, HorizontalAlignment.Left) 'Column 3
        lsvStocks.Columns.Add("Time", 150, HorizontalAlignment.Left) 'Column 4 - used in Function GetAvg
        lsvStocks.Columns.Add("Volume", 80, HorizontalAlignment.Left) 'Column 5
        lsvStocks.Columns.Add("52 Week Low", 90, HorizontalAlignment.Left) 'Column 6
        lsvStocks.Columns.Add("52 Week High", 90, HorizontalAlignment.Left) 'Column 7
        lsvStocks.Columns.Add("200 Day Average", 100, HorizontalAlignment.Left) 'Column 8
        lsvStocks.Columns.Add("200 Day Change", 100, HorizontalAlignment.Left) 'Column 9
        lsvStocks.Columns.Add("200 Day Change %", 110, HorizontalAlignment.Left) 'Column 10
        lsvStocks.Columns.Add("Long Name", 250, HorizontalAlignment.Left) 'Column 11
    End Sub

    '--validates existence of symbols, type/range check not suitable as some stocks include numbers (e.g. A2M.AX)
    Private Sub DoInputValidation()
        '--existence check
        If (String.IsNullOrEmpty(txtTickers.Text)) Then
            MessageBox.Show("Enter a symbol", "Error")
            txtTickers.Focus()
        Else
            blnInputDataOK = True
        End If
    End Sub

    '--retrives stock data from the internet after validation, then runs Private Sub DisplayResults to display
    Private Async Sub btnGetPrices_Click(sender As Object, e As EventArgs) Handles btnGetPrices.Click
        '--runs validation subroutine
        blnInputDataOK = False
        DoInputValidation()
        If blnInputDataOK = True Then
            '--send an async query so program doesn't have to wait for internet response
            Dim securities = Await Yahoo.
                Symbols(txtTickers.Text.Split(","c)).
                Fields(Field.Symbol,
                       Field.RegularMarketPrice,
                       Field.Currency,
                       Field.RegularMarketChange,
                       Field.RegularMarketChangePercent,
                       Field.RegularMarketTime,
                       Field.RegularMarketVolume,
                       Field.TwoHundredDayAverage,
                       Field.TwoHundredDayAverageChange,
                       Field.TwoHundredDayAverageChangePercent,
                       Field.FiftyTwoWeekLow,
                       Field.FiftyTwoWeekHigh,
                       Field.LongName).
                QueryAsync()
            DisplayResults(securities)
        End If
    End Sub

    '--outputs stock data to listview as part of button press and saves values for sorting
    Private Sub DisplayResults(securities As IReadOnlyDictionary(Of String, Security))
        '--clears old tickers (prevents duplicates when sorting later)
        lsvStocks.Items.Clear()

        '--creates a textfile for only ticker and price for later use
        Dim PricesFile As New IO.StreamWriter("stonkprices.txt")

        '--loops through the results
        For Each objSecurity As Security In securities.Values

            Dim strCurrency As String
            Try
                '--the currency is not always available, so this catches exceptions
                strCurrency = objSecurity.Currency
            Catch
                strCurrency = "(unavailable)"
            End Try

            Dim strLongName As String
            '--the long name is not available for cryptocurrencies, so this catches exceptions
            Try
                strLongName = objSecurity.LongName
            Catch
                strLongName = "(unavailable)"
            End Try

            Dim dtLatestPrice As DateTime = UnixTimeStampToDateTime(objSecurity.RegularMarketTime)

            '--adds stock information to listview
            lsvStocks.Items.Add(New ListViewItem(New String() {
                                                 $"{objSecurity.Symbol}",
                                                 $"{objSecurity.RegularMarketPrice} {strCurrency}",
                                                 $"{objSecurity.RegularMarketChange}",
                                                 $"{objSecurity.RegularMarketChangePercent}",
                                                 $"{dtLatestPrice}",
                                                 $"{objSecurity.RegularMarketVolume}",
                                                 $"{objSecurity.FiftyTwoWeekLow}",
                                                 $"{objSecurity.FiftyTwoWeekHigh}",
                                                 $"{objSecurity.TwoHundredDayAverage}",
                                                 $"{objSecurity.TwoHundredDayAverageChange}",
                                                 $"{objSecurity.TwoHundredDayAverageChangePercent}",
                                                 $"{strLongName}"
                                                 }))

            '--writes symbol and price to textfile for use in sorting form
            PricesFile.WriteLine(objSecurity.Symbol)
            PricesFile.WriteLine(objSecurity.RegularMarketPrice)

        Next

        PricesFile.Close()

    End Sub

    '--converts time from API for calculations
    Public Shared Function UnixTimeStampToDateTime(ByVal unixTimeStamp As Long) As DateTime
        '--unix timestamp is seconds past epoch
        Dim dtDateTime As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
        dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime()
        Return dtDateTime
    End Function

    '--function to get average of a listview column
    Private Function GetAvg(ByVal lv As ListView, ByVal col As Integer) As Double
        Dim total As Double
        For Each itm As ListViewItem In lsvStocks.Items
            total += CDbl(itm.SubItems(col).Text)
        Next
        GetAvg = total / lsvStocks.Items.Count
    End Function

    '--outputs total average day change % with date and performance
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        '--clear old values if any
        txtDayChange.Clear()
        txtPerformance.Clear()
        txtDate.Clear()

        '--display current date
        txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy")

        '--calculate average day change % from listview column using private function
        Dim result As Double
        result = GetAvg(lsvStocks, 3)
        txtDayChange.Text = (result & "%")

        '--comment if positive or negative
        If result > 0 Then
            txtPerformance.Text = "Positive Daily Change"
        Else
            txtPerformance.Text = "Negative Daily Change"
        End If

    End Sub

    '--exports listview data to textfile
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        '--creates textfile and cycles through listview to add each value
        Using LVStream As New IO.StreamWriter("stonks.txt")

            For Each LVi As ListViewItem In lsvStocks.Items

                Dim LVRow As String = ""
                For Each LVCell As ListViewItem.ListViewSubItem _
               In LVi.SubItems

                    LVRow &= LVCell.Text & ","
                Next
                LVRow = LVRow.Remove(LVRow.Length - 1, 1)
                LVStream.WriteLine(LVRow)
            Next

            MessageBox.Show("Stock ListView data has been added to the textfile")

        End Using

    End Sub

    '--returns to menu form
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.Show()
        Me.Hide()
    End Sub

    '--clears input fields and display
    Private Sub btnReset_Click(sender As Object, e As EventArgs)
        txtDayChange.Clear()
        txtPerformance.Clear()
        txtDate.Clear()
        txtTickers.Clear()
        lsvStocks.Items.Clear()
    End Sub

    '--add back example tickers for testing
    Private Sub btnRefill_Click(sender As Object, e As EventArgs) Handles btnRefill.Click
        txtTickers.Clear()
        txtTickers.Text = "DHHF.AX,VTS.AX,NDQ.AX,VAS.AX,TSLA,AAPL,GOOG,ETH-USD,BTC-USD,MSFT"
    End Sub

End Class