Imports System.IO
Imports System.Text
Public Class Form4
    'AUTHOR: Thomas Tran
    'TITLE: Stock Portfolio Application (Sorting)
    'VERSION: v1.0

    '--outputs textfile contents into listview
    Private Sub btnStandard_Click(sender As Object, e As EventArgs) Handles btnStandard.Click
        lstContents.Items.Clear()
        Dim StocksFile As StreamReader = File.OpenText("stonks.txt")
        Dim Stock As String
        Do While StocksFile.Peek <> -1
            Stock = StocksFile.ReadLine()
            lstContents.Items.Add(Stock)
        Loop
        StocksFile.Close()
    End Sub

    '--conducts selection sort for highest stock price 
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click

    End Sub

    '--returns to menu form
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class