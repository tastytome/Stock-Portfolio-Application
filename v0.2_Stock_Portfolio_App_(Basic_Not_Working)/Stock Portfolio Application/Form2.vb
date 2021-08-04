Option Strict On

Imports YahooFinanceApi

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTickers.Text = "AAPL,GOOG,MSFT,XYZ,BBD-B.TO"
    End Sub

    Private Async Sub btnGetPrices_Click(sender As Object, e As EventArgs) Handles btnGetPrices.Click
        'Send an async query
        Dim securities = Await Yahoo.
                Symbols(txtTickers.Text.Split(","c)).
                Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketTime, Field.Currency, Field.LongName).
                QueryAsync()
        DisplayResults(securities)
    End Sub

    Private Sub DisplayResults(securities As IReadOnlyDictionary(Of String, Security))
        'add a blank line to ease reading the results
        If lstResults.Items.Count > 0 Then lstResults.Items.Add(String.Empty)

        'loop through the results
        For Each objSecurity As Security In securities.Values
            Dim strCurrency As String
            Try
                'for some reason, the currency is not always available!
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
        'Unix timestamp is seconds past epoch
        Dim dtDateTime As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
        dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime()
        Return dtDateTime
    End Function

End Class
