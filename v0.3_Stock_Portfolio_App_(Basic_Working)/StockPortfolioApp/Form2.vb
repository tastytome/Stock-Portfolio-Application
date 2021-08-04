Option Strict On

'--acceses API that imports yahoo finance data (yahoo disabled their own service years ago)
Imports YahooFinanceApi

Public Class Form2
    'AUTHOR: Thomas Tran
    'TITLE: Stock Portfolio Application (Basic)
    'VERSION: v1.0

    '--example tickers for testing
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTickers.Text = "DHHF.AX,VTS.AX,NDQ.AX,VAS.AX,TSLA,AAPL,GOOG,MSFT"
    End Sub


    Private Async Sub btnGetPrices_Click(sender As Object, e As EventArgs) Handles btnGetPrices.Click
        '--send an async query so program doesn't have to wait for internet response
        Dim securities = Await Yahoo.
                Symbols(txtTickers.Text.Split(","c)).
                Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketTime, Field.Currency, Field.LongName).
                QueryAsync()
        DisplayResults(securities)
    End Sub

    Private Sub DisplayResults(securities As IReadOnlyDictionary(Of String, Security))
        '--adds a blank line to ease reading the results
        If lstResults.Items.Count > 0 Then lstResults.Items.Add(String.Empty)

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
            lstResults.Items.Add($"{objSecurity.Symbol} @ {objSecurity.RegularMarketPrice} {strCurrency} - {dtLatestPrice} - {strLongName}")
        Next

        lstResults.SelectedIndex = lstResults.Items.Count - 1
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

End Class
