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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.txtFatGrams = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPercentFat = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the number of calories in the food:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the number of fat grams in the food"
        '
        'txtCalories
        '
        Me.txtCalories.Location = New System.Drawing.Point(257, 56)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(100, 20)
        Me.txtCalories.TabIndex = 2
        '
        'txtFatGrams
        '
        Me.txtFatGrams.Location = New System.Drawing.Point(257, 100)
        Me.txtFatGrams.Name = "txtFatGrams"
        Me.txtFatGrams.Size = New System.Drawing.Size(100, 20)
        Me.txtFatGrams.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Percentage of calories that come from fat:"
        '
        'lblPercentFat
        '
        Me.lblPercentFat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPercentFat.Location = New System.Drawing.Point(257, 148)
        Me.lblPercentFat.Name = "lblPercentFat"
        Me.lblPercentFat.Size = New System.Drawing.Size(100, 23)
        Me.lblPercentFat.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(36, 198)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(82, 38)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(164, 198)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 38)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(287, 198)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 38)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPercentFat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFatGrams)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fat Percentage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCalories As System.Windows.Forms.TextBox
    Friend WithEvents txtFatGrams As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPercentFat As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
