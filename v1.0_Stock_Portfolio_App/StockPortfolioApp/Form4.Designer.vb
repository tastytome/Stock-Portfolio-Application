<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.lstContents = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStandard = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstUnsorted = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lstSorted = New System.Windows.Forms.ListBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstContents
        '
        Me.lstContents.FormattingEnabled = True
        Me.lstContents.Location = New System.Drawing.Point(14, 233)
        Me.lstContents.Name = "lstContents"
        Me.lstContents.Size = New System.Drawing.Size(490, 147)
        Me.lstContents.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 88)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controls"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(98, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(271, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "- Conduct Selection Sort for Stock Data Comparisons"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(98, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "- Display Unformatted Textfile's Contents"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.Label6.Location = New System.Drawing.Point(80, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(404, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "After saving your stock list from the Advanced Form, use this form to sort data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(7, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Instructions:"
        '
        'btnStandard
        '
        Me.btnStandard.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnStandard.Location = New System.Drawing.Point(305, 201)
        Me.btnStandard.Name = "btnStandard"
        Me.btnStandard.Size = New System.Drawing.Size(199, 26)
        Me.btnStandard.TabIndex = 1
        Me.btnStandard.Text = "Display Unformatted Textfile"
        Me.btnStandard.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 78)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sorting Portfolio"
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnMenu.Location = New System.Drawing.Point(405, 629)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(99, 26)
        Me.btnMenu.TabIndex = 15
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(13, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Unformatted Contents:"
        '
        'lstUnsorted
        '
        Me.lstUnsorted.FormattingEnabled = True
        Me.lstUnsorted.Location = New System.Drawing.Point(15, 411)
        Me.lstUnsorted.Name = "lstUnsorted"
        Me.lstUnsorted.Size = New System.Drawing.Size(181, 212)
        Me.lstUnsorted.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(12, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 18)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Unsorted"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(320, 390)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 18)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Sorted"
        '
        'lstSorted
        '
        Me.lstSorted.FormattingEnabled = True
        Me.lstSorted.Location = New System.Drawing.Point(323, 411)
        Me.lstSorted.Name = "lstSorted"
        Me.lstSorted.Size = New System.Drawing.Size(181, 212)
        Me.lstSorted.TabIndex = 22
        '
        'btnSort
        '
        Me.btnSort.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSort.Location = New System.Drawing.Point(202, 411)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(115, 212)
        Me.btnSort.TabIndex = 24
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 633)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(383, 20)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "NOTE: Selection Sort Will Only Sort Correctly With 10 Values"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(523, 671)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lstSorted)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnStandard)
        Me.Controls.Add(Me.lstUnsorted)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstContents)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMenu)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form4"
        Me.Text = "Sorting Form"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstContents As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnStandard As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstUnsorted As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lstSorted As ListBox
    Friend WithEvents btnSort As Button
    Friend WithEvents Label10 As Label
End Class
