Option Strict On

'--accesses API that imports yahoo finance data (yahoo disabled their own service years ago)
Imports YahooFinanceApi
Public Class Form3
    '--AUTHOR: Thomas Tran
    '--TITLE: Stock Portfolio Application (Advanced)
    '--VERSION: v1.0

    Dim blnInputDataOK As Boolean = False

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--example tickers for testing
        txtTickers.Text = "DHHF.AX,VTS.AX,NDQ.AX,VAS.AX,TSLA,AAPL,GOOG,MSFT,ETH-USD,BTC-USD"
        '--add columns To listview
        lsvStocks.Columns.Add("Symbol", 60, HorizontalAlignment.Left) 'Column 1
        lsvStocks.Columns.Add("Price", 100, HorizontalAlignment.Left) 'Column 2
        lsvStocks.Columns.Add("Change", 80, HorizontalAlignment.Left) 'Column 3
        lsvStocks.Columns.Add("Time", 150, HorizontalAlignment.Left) 'Column 4
        lsvStocks.Columns.Add("Volume", 80, HorizontalAlignment.Left) 'Column 5
        lsvStocks.Columns.Add("52 Week Low", 90, HorizontalAlignment.Left) 'Column 7
        lsvStocks.Columns.Add("52 Week High", 90, HorizontalAlignment.Left) 'Column 8
        lsvStocks.Columns.Add("200 Day Average", 100, HorizontalAlignment.Left) 'Column 9
        lsvStocks.Columns.Add("200 Day Change", 100, HorizontalAlignment.Left) 'Column 10
        lsvStocks.Columns.Add("200 Day Change %", 110, HorizontalAlignment.Left) 'Column 11
        lsvStocks.Columns.Add("Long Name", 250, HorizontalAlignment.Left) 'Column 12
    End Sub

    '--validates existence of symbols
    Private Sub DoInputValidation()
        '--existence check
        If (String.IsNullOrEmpty(txtTickers.Text)) Then
            MessageBox.Show("Enter a symbol", "Error")
            txtTickers.Focus()
        Else
            blnInputDataOK = True
        End If
    End Sub

    Private Async Sub btnGetPrices_Click(sender As Object, e As EventArgs) Handles btnGetPrices.Click
        '--run validation subroutine
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

    Private Sub DisplayResults(securities As IReadOnlyDictionary(Of String, Security))
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

            'NOTE: add trunucation for regular market change

            Dim dtLatestPrice As DateTime = UnixTimeStampToDateTime(objSecurity.RegularMarketTime)

            '--adds stock information to listview
            lsvStocks.Items.Add(New ListViewItem(New String() {
                                                 $"{objSecurity.Symbol}",
                                                 $"{objSecurity.RegularMarketPrice} {strCurrency}",
                                                 $"{objSecurity.RegularMarketChange}",
                                                 $"{dtLatestPrice}",
                                                 $"{objSecurity.RegularMarketVolume}",
                                                 $"{objSecurity.FiftyTwoWeekLow}",
                                                 $"{objSecurity.FiftyTwoWeekHigh}",
                                                 $"{objSecurity.TwoHundredDayAverage}",
                                                 $"{objSecurity.TwoHundredDayAverageChange}",
                                                 $"{objSecurity.TwoHundredDayAverageChangePercent}",
                                                 $"{strLongName}"
                                                 }))
        Next
    End Sub

    '--converts time from API for calculations
    Public Shared Function UnixTimeStampToDateTime(ByVal unixTimeStamp As Long) As DateTime
        '--unix timestamp is seconds past epoch
        Dim dtDateTime As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
        dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime()
        Return dtDateTime
    End Function

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click

    End Sub

    Private Sub btnHoldings_Click(sender As Object, e As EventArgs) Handles btnHoldings.Click

    End Sub

    '--returns to menu form
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.Show()
        Me.Hide()
    End Sub

    '--clears input fields and display
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtDayChange.Clear()
        txtTotalChange.Clear()
        txtDate.Clear()
        txtTickers.Clear()
        lsvStocks.Items.Clear()
    End Sub

End Class