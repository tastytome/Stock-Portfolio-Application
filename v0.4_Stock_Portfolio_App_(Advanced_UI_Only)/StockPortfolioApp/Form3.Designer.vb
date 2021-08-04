<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnHoldings = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTickers = New System.Windows.Forms.TextBox()
        Me.btnGetPrices = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTotalValue = New System.Windows.Forms.TextBox()
        Me.txtDayChange = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalChange = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lsvStocks = New System.Windows.Forms.ListView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnMenu.Location = New System.Drawing.Point(1694, 1331)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(5)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(159, 50)
        Me.btnMenu.TabIndex = 3
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.btnHoldings)
        Me.GroupBox2.Controls.Add(Me.btnExport)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnImport)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtTickers)
        Me.GroupBox2.Controls.Add(Me.btnGetPrices)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 440)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(1823, 234)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controls"
        '
        'btnHoldings
        '
        Me.btnHoldings.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnHoldings.Location = New System.Drawing.Point(1265, 73)
        Me.btnHoldings.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnHoldings.Name = "btnHoldings"
        Me.btnHoldings.Size = New System.Drawing.Size(232, 124)
        Me.btnHoldings.TabIndex = 18
        Me.btnHoldings.Text = "Add Holdings"
        Me.btnHoldings.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnExport.Location = New System.Drawing.Point(1509, 73)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(137, 124)
        Me.btnExport.TabIndex = 16
        Me.btnExport.Text = "Export CSV File"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(158, 170)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(549, 27)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Add Commas if Inputting Multiple at Once (No Spaces)"
        '
        'btnImport
        '
        Me.btnImport.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnImport.Location = New System.Drawing.Point(1658, 73)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(137, 124)
        Me.btnImport.TabIndex = 17
        Me.btnImport.Text = "Import CSV File"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(158, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(827, 27)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Input Other Excange Stocks in the Format with Exchange (e.g. VDHG.AX,A2M.AX )"
        '
        'txtTickers
        '
        Me.txtTickers.Location = New System.Drawing.Point(18, 73)
        Me.txtTickers.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtTickers.Name = "txtTickers"
        Me.txtTickers.Size = New System.Drawing.Size(1235, 31)
        Me.txtTickers.TabIndex = 8
        '
        'btnGetPrices
        '
        Me.btnGetPrices.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnGetPrices.Location = New System.Drawing.Point(1075, 135)
        Me.btnGetPrices.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnGetPrices.Name = "btnGetPrices"
        Me.btnGetPrices.Size = New System.Drawing.Size(178, 62)
        Me.btnGetPrices.TabIndex = 1
        Me.btnGetPrices.Text = "Get Prices"
        Me.btnGetPrices.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.Label6.Location = New System.Drawing.Point(158, 117)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(551, 27)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Input US Stocks in the Format (e.g. TSLA,GOOG,AAPL)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(18, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 33)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Tickers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(18, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Instructions:"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnReset.Location = New System.Drawing.Point(1523, 1331)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 50)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 39)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1484, 150)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.Label7.Location = New System.Drawing.Point(841, 91)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(617, 27)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Thomas Tran | VCE Software Development | v1.0 Prerelease"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(18, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(826, 81)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Portfolio Application"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1526, 39)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.txtTotalValue)
        Me.GroupBox3.Controls.Add(Me.txtDayChange)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtTotalChange)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 205)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(1484, 215)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Overview"
        '
        'txtTotalValue
        '
        Me.txtTotalValue.Location = New System.Drawing.Point(211, 44)
        Me.txtTotalValue.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtTotalValue.Name = "txtTotalValue"
        Me.txtTotalValue.Size = New System.Drawing.Size(240, 31)
        Me.txtTotalValue.TabIndex = 12
        '
        'txtDayChange
        '
        Me.txtDayChange.Location = New System.Drawing.Point(211, 98)
        Me.txtDayChange.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtDayChange.Name = "txtDayChange"
        Me.txtDayChange.Size = New System.Drawing.Size(240, 31)
        Me.txtDayChange.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(18, 150)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 33)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Total Change:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(18, 96)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 33)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Day Change:"
        '
        'txtTotalChange
        '
        Me.txtTotalChange.Location = New System.Drawing.Point(211, 153)
        Me.txtTotalChange.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtTotalChange.Name = "txtTotalChange"
        Me.txtTotalChange.Size = New System.Drawing.Size(240, 31)
        Me.txtTotalChange.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(18, 44)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 33)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Total Value:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1526, 205)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(327, 215)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1722, 222)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(103, 102)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'lsvStocks
        '
        Me.lsvStocks.HideSelection = False
        Me.lsvStocks.Location = New System.Drawing.Point(30, 701)
        Me.lsvStocks.Name = "lsvStocks"
        Me.lsvStocks.Size = New System.Drawing.Size(1823, 612)
        Me.lsvStocks.TabIndex = 22
        Me.lsvStocks.UseCompatibleStateImageBehavior = False
        Me.lsvStocks.View = System.Windows.Forms.View.Details
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1885, 1412)
        Me.Controls.Add(Me.lsvStocks)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnReset)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMenu As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTickers As TextBox
    Friend WithEvents btnGetPrices As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTotalChange As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnImport As Button
    Friend WithEvents txtTotalValue As TextBox
    Friend WithEvents txtDayChange As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lsvStocks As ListView
    Friend WithEvents btnHoldings As Button
End Class
