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
        Me.btnRock = New System.Windows.Forms.Button()
        Me.btnPaper = New System.Windows.Forms.Button()
        Me.btnScissors = New System.Windows.Forms.Button()
        Me.lblWinning = New System.Windows.Forms.Label()
        Me.picAll = New System.Windows.Forms.PictureBox()
        Me.picRock = New System.Windows.Forms.PictureBox()
        Me.picPaper = New System.Windows.Forms.PictureBox()
        Me.picScissors = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRock = New System.Windows.Forms.Label()
        Me.lblPaper = New System.Windows.Forms.Label()
        Me.lblScissors = New System.Windows.Forms.Label()
        CType(Me.picAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRock
        '
        Me.btnRock.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRock.Location = New System.Drawing.Point(61, 245)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(100, 45)
        Me.btnRock.TabIndex = 0
        Me.btnRock.Text = "Rock"
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'btnPaper
        '
        Me.btnPaper.Font = New System.Drawing.Font("Britannic Bold", 15.75!)
        Me.btnPaper.Location = New System.Drawing.Point(167, 245)
        Me.btnPaper.Name = "btnPaper"
        Me.btnPaper.Size = New System.Drawing.Size(100, 45)
        Me.btnPaper.TabIndex = 1
        Me.btnPaper.Text = "Paper"
        Me.btnPaper.UseVisualStyleBackColor = True
        '
        'btnScissors
        '
        Me.btnScissors.Font = New System.Drawing.Font("Britannic Bold", 15.75!)
        Me.btnScissors.Location = New System.Drawing.Point(273, 245)
        Me.btnScissors.Name = "btnScissors"
        Me.btnScissors.Size = New System.Drawing.Size(100, 45)
        Me.btnScissors.TabIndex = 2
        Me.btnScissors.Text = "Scissors"
        Me.btnScissors.UseVisualStyleBackColor = True
        '
        'lblWinning
        '
        Me.lblWinning.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinning.Location = New System.Drawing.Point(61, 317)
        Me.lblWinning.Name = "lblWinning"
        Me.lblWinning.Size = New System.Drawing.Size(312, 76)
        Me.lblWinning.TabIndex = 6
        Me.lblWinning.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picAll
        '
        Me.picAll.Image = Global.Rock_Paper_Scissors.My.Resources.Resources.qbHME84
        Me.picAll.Location = New System.Drawing.Point(46, 54)
        Me.picAll.Name = "picAll"
        Me.picAll.Size = New System.Drawing.Size(353, 141)
        Me.picAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAll.TabIndex = 7
        Me.picAll.TabStop = False
        '
        'picRock
        '
        Me.picRock.Image = Global.Rock_Paper_Scissors.My.Resources.Resources.Dwayne_The_Rock_Johnson_pro
        Me.picRock.Location = New System.Drawing.Point(46, 12)
        Me.picRock.Name = "picRock"
        Me.picRock.Size = New System.Drawing.Size(353, 227)
        Me.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRock.TabIndex = 5
        Me.picRock.TabStop = False
        Me.picRock.Visible = False
        '
        'picPaper
        '
        Me.picPaper.Image = Global.Rock_Paper_Scissors.My.Resources.Resources.Rock_paper_scissors__paper_
        Me.picPaper.Location = New System.Drawing.Point(-72, 12)
        Me.picPaper.Name = "picPaper"
        Me.picPaper.Size = New System.Drawing.Size(353, 227)
        Me.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPaper.TabIndex = 4
        Me.picPaper.TabStop = False
        Me.picPaper.Visible = False
        '
        'picScissors
        '
        Me.picScissors.Image = Global.Rock_Paper_Scissors.My.Resources.Resources.Rock_paper_scissors__scissors_
        Me.picScissors.Location = New System.Drawing.Point(-72, 12)
        Me.picScissors.Name = "picScissors"
        Me.picScissors.Size = New System.Drawing.Size(353, 227)
        Me.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picScissors.TabIndex = 3
        Me.picScissors.TabStop = False
        Me.picScissors.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Score:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Score:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Score:"
        '
        'lblRock
        '
        Me.lblRock.AutoSize = True
        Me.lblRock.Location = New System.Drawing.Point(102, 293)
        Me.lblRock.Name = "lblRock"
        Me.lblRock.Size = New System.Drawing.Size(0, 13)
        Me.lblRock.TabIndex = 11
        '
        'lblPaper
        '
        Me.lblPaper.AutoSize = True
        Me.lblPaper.Location = New System.Drawing.Point(202, 293)
        Me.lblPaper.Name = "lblPaper"
        Me.lblPaper.Size = New System.Drawing.Size(0, 13)
        Me.lblPaper.TabIndex = 12
        '
        'lblScissors
        '
        Me.lblScissors.AutoSize = True
        Me.lblScissors.Location = New System.Drawing.Point(314, 293)
        Me.lblScissors.Name = "lblScissors"
        Me.lblScissors.Size = New System.Drawing.Size(0, 13)
        Me.lblScissors.TabIndex = 13
        '
        'frmRockPaperScissors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 402)
        Me.Controls.Add(Me.lblScissors)
        Me.Controls.Add(Me.lblPaper)
        Me.Controls.Add(Me.lblRock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picAll)
        Me.Controls.Add(Me.lblWinning)
        Me.Controls.Add(Me.picRock)
        Me.Controls.Add(Me.picPaper)
        Me.Controls.Add(Me.picScissors)
        Me.Controls.Add(Me.btnScissors)
        Me.Controls.Add(Me.btnPaper)
        Me.Controls.Add(Me.btnRock)
        Me.Name = "frmRockPaperScissors"
        Me.Text = "Rock Paper Scissors"
        CType(Me.picAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRock As Button
    Friend WithEvents btnPaper As Button
    Friend WithEvents btnScissors As Button
    Friend WithEvents picScissors As PictureBox
    Friend WithEvents picPaper As PictureBox
    Friend WithEvents picRock As PictureBox
    Friend WithEvents lblWinning As Label
    Friend WithEvents picAll As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRock As Label
    Friend WithEvents lblPaper As Label
    Friend WithEvents lblScissors As Label
End Class
