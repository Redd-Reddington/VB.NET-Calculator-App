<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblCalculator = New Label()
        Label2 = New Label()
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        Label3 = New Label()
        btnAdd = New Button()
        btnSubtract = New Button()
        btnMultiply = New Button()
        btnDivide = New Button()
        lblResults = New Label()
        SuspendLayout()
        ' 
        ' lblCalculator
        ' 
        lblCalculator.AutoSize = True
        lblCalculator.Font = New Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCalculator.ForeColor = Color.ForestGreen
        lblCalculator.Location = New Point(389, 35)
        lblCalculator.Name = "lblCalculator"
        lblCalculator.Size = New Size(357, 89)
        lblCalculator.TabIndex = 0
        lblCalculator.Text = "Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(243, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 23)
        Label2.TabIndex = 1
        Label2.Text = "Enter First Number:"
        ' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(474, 192)
        txtNum1.Multiline = True
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(323, 47)
        txtNum1.TabIndex = 2
        ' 
        ' txtNum2
        ' 
        txtNum2.Location = New Point(474, 267)
        txtNum2.Multiline = True
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(323, 47)
        txtNum2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(243, 270)
        Label3.Name = "Label3"
        Label3.Size = New Size(192, 23)
        Label3.TabIndex = 4
        Label3.Text = "Enter Second Number:"
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        btnAdd.Location = New Point(474, 371)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(118, 53)
        btnAdd.TabIndex = 5
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        btnSubtract.Location = New Point(638, 371)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(118, 53)
        btnSubtract.TabIndex = 6
        btnSubtract.Text = "-"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        btnMultiply.Location = New Point(474, 478)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(118, 53)
        btnMultiply.TabIndex = 7
        btnMultiply.Text = "*"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' btnDivide
        ' 
        btnDivide.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        btnDivide.Location = New Point(638, 478)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(118, 53)
        btnDivide.TabIndex = 8
        btnDivide.Text = "/"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' lblResults
        ' 
        lblResults.AutoSize = True
        lblResults.Font = New Font("Segoe UI", 40F, FontStyle.Bold)
        lblResults.ForeColor = Color.Blue
        lblResults.Location = New Point(961, 301)
        lblResults.Name = "lblResults"
        lblResults.Size = New Size(77, 89)
        lblResults.TabIndex = 9
        lblResults.Text = "0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        ClientSize = New Size(1377, 854)
        Controls.Add(lblResults)
        Controls.Add(btnDivide)
        Controls.Add(btnMultiply)
        Controls.Add(btnSubtract)
        Controls.Add(btnAdd)
        Controls.Add(Label3)
        Controls.Add(txtNum2)
        Controls.Add(txtNum1)
        Controls.Add(Label2)
        Controls.Add(lblCalculator)
        Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Name = "Form1"
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCalculator As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents lblResults As Label

End Class
