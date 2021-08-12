<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBasicForm = New System.Windows.Forms.Button()
        Me.btnAdvancedForm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSortingForm = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(32, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 81)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stocks App"
        '
        'btnBasicForm
        '
        Me.btnBasicForm.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnBasicForm.Location = New System.Drawing.Point(32, 54)
        Me.btnBasicForm.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnBasicForm.Name = "btnBasicForm"
        Me.btnBasicForm.Size = New System.Drawing.Size(266, 92)
        Me.btnBasicForm.TabIndex = 1
        Me.btnBasicForm.Text = "Basic Form"
        Me.btnBasicForm.UseVisualStyleBackColor = True
        '
        'btnAdvancedForm
        '
        Me.btnAdvancedForm.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdvancedForm.Location = New System.Drawing.Point(32, 185)
        Me.btnAdvancedForm.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAdvancedForm.Name = "btnAdvancedForm"
        Me.btnAdvancedForm.Size = New System.Drawing.Size(266, 132)
        Me.btnAdvancedForm.TabIndex = 2
        Me.btnAdvancedForm.Text = "Advanced Form"
        Me.btnAdvancedForm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(308, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 33)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter and Display Text"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(308, 185)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter and Display Table"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(308, 218)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(285, 33)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Calculate Total Change"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(308, 251)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(228, 33)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "View Detailed Info"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(420, 44)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 40)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(636, 150)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnSortingForm)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnBasicForm)
        Me.GroupBox2.Controls.Add(Me.btnAdvancedForm)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(44, 200)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(636, 502)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forms"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(308, 396)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 33)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Export CSV"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(308, 363)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(222, 33)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Sort Portfolio File"
        '
        'btnSortingForm
        '
        Me.btnSortingForm.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSortingForm.Location = New System.Drawing.Point(32, 363)
        Me.btnSortingForm.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSortingForm.Name = "btnSortingForm"
        Me.btnSortingForm.Size = New System.Drawing.Size(266, 92)
        Me.btnSortingForm.TabIndex = 13
        Me.btnSortingForm.Text = "Sorting Form"
        Me.btnSortingForm.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(308, 284)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(229, 33)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Save Portfolio File"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(308, 84)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 33)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Name / Price / Date"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnExit.Location = New System.Drawing.Point(44, 725)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(636, 58)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(728, 809)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Form1"
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBasicForm As Button
    Friend WithEvents btnAdvancedForm As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSortingForm As Button
End Class
