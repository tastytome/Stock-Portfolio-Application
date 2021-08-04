Option Strict On

'--acceses API that imports yahoo finance data (yahoo disabled their own service years ago)
Imports YahooFinanceApi
Public Class Form3
    '--AUTHOR: Thomas Tran
    '--TITLE: Stock Portfolio Application (Advanced)
    '--VERSION: v1.0

    Dim blnInputDataOK As Boolean = False

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--example tickers for testing
        txtTickers.Text = "DHHF.AX,VTS.AX,NDQ.AX,VAS.AX,TSLA,AAPL,GOOG,MSFT"
        '--add columns To listview
        lsvStocks.Columns.Add("Symbol", 100, HorizontalAlignment.Left) 'Column 1
        lsvStocks.Columns.Add("Price", 100, HorizontalAlignment.Left) 'Column 2
        lsvStocks.Columns.Add("Time", 200, HorizontalAlignment.Left) 'Column 3
        lsvStocks.Columns.Add("Name", 300, HorizontalAlignment.Left) 'Column 4
        lsvStocks.Columns.Add("Placeholder", 100, HorizontalAlignment.Left) 'Column 5
        lsvStocks.Columns.Add("Placeholder", 100, HorizontalAlignment.Left) 'Column 6
        lsvStocks.Columns.Add("Placeholder", 100, HorizontalAlignment.Left) 'Column 7
        lsvStocks.Columns.Add("Placeholder", 100, HorizontalAlignment.Left) 'Column 8
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
                Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketTime, Field.Currency, Field.LongName).
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
                strCurrency = "(unknown)"
            End Try

            Dim strLongName As String
            Try
                strLongName = objSecurity.LongName
            Catch
                strLongName = "(unknown)"
            End Try

            Dim dtLatestPrice As DateTime = UnixTimeStampToDateTime(objSecurity.RegularMarketTime)

            '-adds stock information to listview
            lsvStocks.Items.Add(New ListViewItem(New String() {
                                                 $"{objSecurity.Symbol}",
                                                 $"{objSecurity.RegularMarketPrice} {strCurrency}",
                                                 $"{dtLatestPrice}",
                                                 $"{strLongName}"
                                                 }))
        Next
    End Sub

    Public Shared Function UnixTimeStampToDateTime(ByVal unixTimeStamp As Long) As DateTime
        '--unix timestamp is seconds past epoch
        Dim dtDateTime As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
        dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime()
        Return dtDateTime
    End Function

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtDayChange.Clear()
        txtTotalChange.Clear()
        txtTotalValue.Clear()
        txtTickers.Clear()
        lsvStocks.Items.Clear()
    End Sub
End Class