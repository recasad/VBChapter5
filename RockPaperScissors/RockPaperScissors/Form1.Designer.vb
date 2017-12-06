<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRockPaperScissors
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
        Me.picRock = New System.Windows.Forms.PictureBox()
        Me.picScissors = New System.Windows.Forms.PictureBox()
        Me.picPaper = New System.Windows.Forms.PictureBox()
        Me.picAll = New System.Windows.Forms.PictureBox()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.btnPaper = New System.Windows.Forms.Button()
        Me.btnScissors = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWinning = New System.Windows.Forms.Label()
        Me.lblScissors = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPaper = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRock = New System.Windows.Forms.Label()
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picRock
        '
        Me.picRock.Image = Global.RockPaperScissors.My.Resources.Resources.Dwayne_The_Rock_Johnson_pro
        Me.picRock.Location = New System.Drawing.Point(45, 68)
        Me.picRock.Name = "picRock"
        Me.picRock.Size = New System.Drawing.Size(389, 203)
        Me.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRock.TabIndex = 0
        Me.picRock.TabStop = False
        Me.picRock.Visible = False
        '
        'picScissors
        '
        Me.picScissors.Image = Global.RockPaperScissors.My.Resources.Resources.Rock_paper_scissors__scissors_
        Me.picScissors.Location = New System.Drawing.Point(-51, 38)
        Me.picScissors.Name = "picScissors"
        Me.picScissors.Size = New System.Drawing.Size(317, 228)
        Me.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picScissors.TabIndex = 1
        Me.picScissors.TabStop = False
        Me.picScissors.Visible = False
        '
        'picPaper
        '
        Me.picPaper.Image = Global.RockPaperScissors.My.Resources.Resources.Rock_paper_scissors__paper_
        Me.picPaper.Location = New System.Drawing.Point(-28, 38)
        Me.picPaper.Name = "picPaper"
        Me.picPaper.Size = New System.Drawing.Size(270, 228)
        Me.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPaper.TabIndex = 2
        Me.picPaper.TabStop = False
        Me.picPaper.Visible = False
        '
        'picAll
        '
        Me.picAll.Image = Global.RockPaperScissors.My.Resources.Resources.qbHME84
        Me.picAll.Location = New System.Drawing.Point(47, 68)
        Me.picAll.Name = "picAll"
        Me.picAll.Size = New System.Drawing.Size(387, 146)
        Me.picAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAll.TabIndex = 3
        Me.picAll.TabStop = False
        '
        'btnRock
        '
        Me.btnRock.Font = New System.Drawing.Font("Century", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRock.Location = New System.Drawing.Point(47, 277)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(125, 52)
        Me.btnRock.TabIndex = 4
        Me.btnRock.Text = "Rock"
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'btnPaper
        '
        Me.btnPaper.Font = New System.Drawing.Font("Century", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnPaper.Location = New System.Drawing.Point(178, 277)
        Me.btnPaper.Name = "btnPaper"
        Me.btnPaper.Size = New System.Drawing.Size(125, 52)
        Me.btnPaper.TabIndex = 5
        Me.btnPaper.Text = "Paper"
        Me.btnPaper.UseVisualStyleBackColor = True
        '
        'btnScissors
        '
        Me.btnScissors.Font = New System.Drawing.Font("Century", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnScissors.Location = New System.Drawing.Point(309, 277)
        Me.btnScissors.Name = "btnScissors"
        Me.btnScissors.Size = New System.Drawing.Size(125, 52)
        Me.btnScissors.TabIndex = 6
        Me.btnScissors.Text = "Scissors"
        Me.btnScissors.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Score:"
        '
        'lblWinning
        '
        Me.lblWinning.Font = New System.Drawing.Font("Century", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinning.Location = New System.Drawing.Point(40, 370)
        Me.lblWinning.Name = "lblWinning"
        Me.lblWinning.Size = New System.Drawing.Size(400, 85)
        Me.lblWinning.TabIndex = 8
        Me.lblWinning.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblScissors
        '
        Me.lblScissors.AutoSize = True
        Me.lblScissors.Location = New System.Drawing.Point(350, 332)
        Me.lblScissors.Name = "lblScissors"
        Me.lblScissors.Size = New System.Drawing.Size(0, 13)
        Me.lblScissors.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(306, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Score:"
        '
        'lblPaper
        '
        Me.lblPaper.AutoSize = True
        Me.lblPaper.Location = New System.Drawing.Point(219, 332)
        Me.lblPaper.Name = "lblPaper"
        Me.lblPaper.Size = New System.Drawing.Size(0, 13)
        Me.lblPaper.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(175, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Score:"
        '
        'lblRock
        '
        Me.lblRock.AutoSize = True
        Me.lblRock.Location = New System.Drawing.Point(88, 332)
        Me.lblRock.Name = "lblRock"
        Me.lblRock.Size = New System.Drawing.Size(0, 13)
        Me.lblRock.TabIndex = 13
        '
        'frmRockPaperScissors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 464)
        Me.Controls.Add(Me.lblRock)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPaper)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblScissors)
        Me.Controls.Add(Me.lblWinning)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnScissors)
        Me.Controls.Add(Me.btnPaper)
        Me.Controls.Add(Me.btnRock)
        Me.Controls.Add(Me.picAll)
        Me.Controls.Add(Me.picPaper)
        Me.Controls.Add(Me.picScissors)
        Me.Controls.Add(Me.picRock)
        Me.Name = "frmRockPaperScissors"
        Me.Text = "Rock Paper Scissors"
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picRock As PictureBox
    Friend WithEvents picScissors As PictureBox
    Friend WithEvents picPaper As PictureBox
    Friend WithEvents picAll As PictureBox
    Friend WithEvents btnRock As Button
    Friend WithEvents btnPaper As Button
    Friend WithEvents btnScissors As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWinning As Label
    Friend WithEvents lblScissors As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPaper As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRock As Label
End Class
