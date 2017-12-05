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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radA = New System.Windows.Forms.RadioButton()
        Me.radB = New System.Windows.Forms.RadioButton()
        Me.radC = New System.Windows.Forms.RadioButton()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radC)
        Me.GroupBox1.Controls.Add(Me.radB)
        Me.GroupBox1.Controls.Add(Me.radA)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'radA
        '
        Me.radA.AutoSize = True
        Me.radA.Location = New System.Drawing.Point(17, 19)
        Me.radA.Name = "radA"
        Me.radA.Size = New System.Drawing.Size(99, 17)
        Me.radA.TabIndex = 0
        Me.radA.TabStop = True
        Me.radA.Text = "Solve for A side"
        Me.radA.UseVisualStyleBackColor = True
        '
        'radB
        '
        Me.radB.AutoSize = True
        Me.radB.Location = New System.Drawing.Point(17, 42)
        Me.radB.Name = "radB"
        Me.radB.Size = New System.Drawing.Size(99, 17)
        Me.radB.TabIndex = 1
        Me.radB.TabStop = True
        Me.radB.Text = "Solve for B side"
        Me.radB.UseVisualStyleBackColor = True
        '
        'radC
        '
        Me.radC.AutoSize = True
        Me.radC.Location = New System.Drawing.Point(17, 65)
        Me.radC.Name = "radC"
        Me.radC.Size = New System.Drawing.Size(99, 17)
        Me.radC.TabIndex = 2
        Me.radC.TabStop = True
        Me.radC.Text = "Solve for C side"
        Me.radC.UseVisualStyleBackColor = True
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(153, 67)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 1
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(153, 44)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 20)
        Me.txtA.TabIndex = 2
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(153, 90)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(100, 20)
        Me.txtC.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(165, 116)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(40, 126)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 164)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Right Triangle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radC As System.Windows.Forms.RadioButton
    Friend WithEvents radB As System.Windows.Forms.RadioButton
    Friend WithEvents radA As System.Windows.Forms.RadioButton
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
