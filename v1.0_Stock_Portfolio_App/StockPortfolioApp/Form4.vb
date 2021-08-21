Imports System.IO
Imports System.Text
Public Class Form4
    'AUTHOR: Thomas Tran
    'TITLE: Stock Portfolio Application (Sorting)
    'VERSION: v1.0

    '--outputs unsorted array from textfile
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--load up the Listboxes on the Form with a Heading
        lstUnsorted.Items.Add("--------------------------")
        lstUnsorted.Items.Add("Unsorted Array")
        lstUnsorted.Items.Add("--------------------------")
        lstSorted.Items.Add("--------------------------")
        lstSorted.Items.Add("Sorted Array")
        lstSorted.Items.Add("--------------------------")
    End Sub

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
        '--load data from textfile into arrays

        Try

            Dim Stocks(9) As String
            Dim Prices(9) As Integer

            Dim StonkSortFile As IO.StreamReader
            '--open the Input File to be read using the VB StreamReader
            StonkSortFile = New IO.StreamReader("stonkprices.txt")
            '--use a Loop to read through all of the Lines in the Input File
            Dim ItemCounter As Integer = 0
            Do While Not StonkSortFile.EndOfStream
                Stocks(ItemCounter) = StonkSortFile.ReadLine
                Prices(ItemCounter) = StonkSortFile.ReadLine
                ItemCounter = ItemCounter + 1

            Loop
            '--close the file after finishing loop
            StonkSortFile.Close()

            '--display items in listbox
            lstUnsorted.Items.Clear()
            lstUnsorted.Items.Add("--------------------------")
            lstUnsorted.Items.Add("Unsorted Array")
            lstUnsorted.Items.Add("--------------------------")
            Dim p As Integer
            For p = 0 To ItemCounter - 1
                lstUnsorted.Items.Add(Stocks(p) & ": " & Prices(p))
            Next

            '--apply the Selection Sort Algorithm to sort the Array into Ascending Order. 
            Dim lowerbound As Integer = LBound(Prices) '--start index of array
            Dim upperbound As Integer = UBound(Prices) '--end Index of Array

            Dim i As Integer = 0   '--Main Loop Counter for array processing
            Dim j As Integer = 0   '--Index counter Value to shuffle along 1 index step

            Dim intMinValueIndex As Integer     '--Index to move Minimum Value to  
            Dim intSwapValueIndex As Integer    '--Index Value that Min Value is found at
            Dim intSwapValue As Integer         '--Actual value of the found Minimum
            Dim strSwapStock As String

            '--loop to go through the array doing Selection Sort Passes. 

            For i = lowerbound To upperbound
                intMinValueIndex = i
                '--reset the saved Swap Values from the last Pass of the Array
                intSwapValue = 0
                intSwapValueIndex = 0
                For j = i + 1 To upperbound
                    '--search and find the lowest value remaining in the array 
                    If Prices(j) < Prices(intMinValueIndex) Then
                        '--First check for first time finding a smaller value, 
                        '--then check if smallest so far.
                        If intSwapValue = 0 Then
                            intSwapValue = Prices(j)
                            strSwapStock = Stocks(j)
                            intSwapValueIndex = j
                        Else
                            If Prices(j) < intSwapValue Then
                                intSwapValue = Prices(j)
                                strSwapStock = Stocks(j)
                                intSwapValueIndex = j
                            End If
                        End If
                    End If
                Next j

                If intSwapValue <> 0 Then
                    Prices(intSwapValueIndex) = Prices(intMinValueIndex)
                    Stocks(intSwapValueIndex) = Stocks(intMinValueIndex)
                    Prices(intMinValueIndex) = intSwapValue
                    Stocks(intMinValueIndex) = strSwapStock
                End If

                '--Display Load of Sorted Listbox for the current Pass
                '--First clear out the previous Pass display data 
                lstSorted.Items.Clear()
                Dim strCurrentPassInfo As String = "Array Pass i = " & CStr(i)
                lstSorted.Items.Add("--------------------------")
                lstSorted.Items.Add(strCurrentPassInfo)
                lstSorted.Items.Add("--------------------------")
                For k = 0 To Stocks.Count - 1
                    lstSorted.Items.Add(Prices(k) & ":  " & Stocks(k))
                Next k
                MsgBox("Click OK to continue")
            Next i


            '--The Array should now be fully sorted into ascending order. 
            '--Load up the Sorted Array into the Sorted List Box to display on the Form. 

            '--First clear out the previous Pass display data 
            lstSorted.Items.Clear()
            '--Load up the Sorted Listbox on the Form with a Heading followed the Array Data.
            lstSorted.Items.Add("--------------------------")
            lstSorted.Items.Add("Final Sorted Array")
            lstSorted.Items.Add("--------------------------")
            For c = 0 To Prices.Count - 1
                lstSorted.Items.Add(Prices(c) & ":  " & Stocks(c))
            Next

        Catch ex As Exception
            MsgBox("Please ensure you exported a list of exactly 10 stocks from the advanced view for this to function (or change the default examples)")
        End Try

    End Sub

    '--returns to menu form
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class