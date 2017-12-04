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
        Me.btnRace = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picAward = New System.Windows.Forms.PictureBox()
        Me.lblWinning = New System.Windows.Forms.Label()
        Me.picHappy = New System.Windows.Forms.PictureBox()
        Me.picSad = New System.Windows.Forms.PictureBox()
        Me.radJames = New System.Windows.Forms.RadioButton()
        Me.radRenee = New System.Windows.Forms.RadioButton()
        Me.radBecca = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picRenee = New System.Windows.Forms.PictureBox()
        Me.picJames = New System.Windows.Forms.PictureBox()
        Me.picBecca = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBecca = New System.Windows.Forms.Label()
        Me.lblJames = New System.Windows.Forms.Label()
        Me.lblRenee = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picAward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRenee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJames, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBecca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRace
        '
        Me.btnRace.Font = New System.Drawing.Font("Magneto", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRace.Location = New System.Drawing.Point(26, 251)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(361, 63)
        Me.btnRace.TabIndex = 0
        Me.btnRace.Text = "Race"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Magneto", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Casad Family Races"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.picAward)
        Me.GroupBox1.Controls.Add(Me.lblWinning)
        Me.GroupBox1.Controls.Add(Me.picHappy)
        Me.GroupBox1.Controls.Add(Me.picSad)
        Me.GroupBox1.Controls.Add(Me.radJames)
        Me.GroupBox1.Controls.Add(Me.radRenee)
        Me.GroupBox1.Controls.Add(Me.radBecca)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Magneto", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(405, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 284)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bet on your favorite Casad"
        '
        'picAward
        '
        Me.picAward.Image = Global.Moving_Things.My.Resources.Resources.Safety_Competition_Winner
        Me.picAward.Location = New System.Drawing.Point(42, 111)
        Me.picAward.Name = "picAward"
        Me.picAward.Size = New System.Drawing.Size(180, 152)
        Me.picAward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAward.TabIndex = 7
        Me.picAward.TabStop = False
        '
        'lblWinning
        '
        Me.lblWinning.Font = New System.Drawing.Font("Magneto", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinning.Location = New System.Drawing.Point(42, 234)
        Me.lblWinning.Name = "lblWinning"
        Me.lblWinning.Size = New System.Drawing.Size(167, 29)
        Me.lblWinning.TabIndex = 9
        Me.lblWinning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picHappy
        '
        Me.picHappy.Image = Global.Moving_Things.My.Resources.Resources.IMG_3534
        Me.picHappy.Location = New System.Drawing.Point(42, 111)
        Me.picHappy.Name = "picHappy"
        Me.picHappy.Size = New System.Drawing.Size(167, 152)
        Me.picHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHappy.TabIndex = 8
        Me.picHappy.TabStop = False
        Me.picHappy.Visible = False
        '
        'picSad
        '
        Me.picSad.Image = Global.Moving_Things.My.Resources.Resources.sad
        Me.picSad.Location = New System.Drawing.Point(42, 111)
        Me.picSad.Name = "picSad"
        Me.picSad.Size = New System.Drawing.Size(167, 152)
        Me.picSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSad.TabIndex = 6
        Me.picSad.TabStop = False
        Me.picSad.Visible = False
        '
        'radJames
        '
        Me.radJames.AutoSize = True
        Me.radJames.Location = New System.Drawing.Point(15, 53)
        Me.radJames.Name = "radJames"
        Me.radJames.Size = New System.Drawing.Size(79, 23)
        Me.radJames.TabIndex = 5
        Me.radJames.TabStop = True
        Me.radJames.Text = "James"
        Me.radJames.UseVisualStyleBackColor = True
        '
        'radRenee
        '
        Me.radRenee.AutoSize = True
        Me.radRenee.Location = New System.Drawing.Point(15, 82)
        Me.radRenee.Name = "radRenee"
        Me.radRenee.Size = New System.Drawing.Size(77, 23)
        Me.radRenee.TabIndex = 4
        Me.radRenee.TabStop = True
        Me.radRenee.Text = "Renee"
        Me.radRenee.UseVisualStyleBackColor = True
        '
        'radBecca
        '
        Me.radBecca.AutoSize = True
        Me.radBecca.Location = New System.Drawing.Point(15, 25)
        Me.radBecca.Name = "radBecca"
        Me.radBecca.Size = New System.Drawing.Size(75, 23)
        Me.radBecca.TabIndex = 3
        Me.radBecca.TabStop = True
        Me.radBecca.Text = "Becca"
        Me.radBecca.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Moving_Things.My.Resources.Resources.SpeedMaxPC_Racing_Flags
        Me.PictureBox1.Location = New System.Drawing.Point(309, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'picRenee
        '
        Me.picRenee.Image = Global.Moving_Things.My.Resources.Resources.IMG_3459
        Me.picRenee.Location = New System.Drawing.Point(26, 195)
        Me.picRenee.Name = "picRenee"
        Me.picRenee.Size = New System.Drawing.Size(50, 50)
        Me.picRenee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRenee.TabIndex = 3
        Me.picRenee.TabStop = False
        '
        'picJames
        '
        Me.picJames.Image = Global.Moving_Things.My.Resources.Resources.IMG_2825
        Me.picJames.Location = New System.Drawing.Point(26, 139)
        Me.picJames.Name = "picJames"
        Me.picJames.Size = New System.Drawing.Size(50, 50)
        Me.picJames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJames.TabIndex = 2
        Me.picJames.TabStop = False
        '
        'picBecca
        '
        Me.picBecca.Image = Global.Moving_Things.My.Resources.Resources.IMG_0247
        Me.picBecca.Location = New System.Drawing.Point(26, 83)
        Me.picBecca.Name = "picBecca"
        Me.picBecca.Size = New System.Drawing.Size(50, 50)
        Me.picBecca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBecca.TabIndex = 1
        Me.picBecca.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Becca:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "James:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Renee:"
        '
        'lblBecca
        '
        Me.lblBecca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBecca.Location = New System.Drawing.Point(70, 328)
        Me.lblBecca.Name = "lblBecca"
        Me.lblBecca.Size = New System.Drawing.Size(134, 25)
        Me.lblBecca.TabIndex = 10
        Me.lblBecca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJames
        '
        Me.lblJames.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJames.Location = New System.Drawing.Point(253, 328)
        Me.lblJames.Name = "lblJames"
        Me.lblJames.Size = New System.Drawing.Size(134, 25)
        Me.lblJames.TabIndex = 11
        Me.lblJames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRenee
        '
        Me.lblRenee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRenee.Location = New System.Drawing.Point(441, 328)
        Me.lblRenee.Name = "lblRenee"
        Me.lblRenee.Size = New System.Drawing.Size(134, 25)
        Me.lblRenee.TabIndex = 12
        Me.lblRenee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 367)
        Me.Controls.Add(Me.lblRenee)
        Me.Controls.Add(Me.lblJames)
        Me.Controls.Add(Me.lblBecca)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picRenee)
        Me.Controls.Add(Me.picJames)
        Me.Controls.Add(Me.picBecca)
        Me.Controls.Add(Me.btnRace)
        Me.Name = "Form1"
        Me.Text = "Casad Family Races"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picAward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRenee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJames, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBecca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRace As System.Windows.Forms.Button
    Friend WithEvents picBecca As System.Windows.Forms.PictureBox
    Friend WithEvents picJames As System.Windows.Forms.PictureBox
    Friend WithEvents picRenee As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radJames As System.Windows.Forms.RadioButton
    Friend WithEvents radRenee As System.Windows.Forms.RadioButton
    Friend WithEvents radBecca As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picSad As System.Windows.Forms.PictureBox
    Friend WithEvents picHappy As System.Windows.Forms.PictureBox
    Friend WithEvents lblWinning As System.Windows.Forms.Label
    Friend WithEvents picAward As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblBecca As System.Windows.Forms.Label
    Friend WithEvents lblJames As System.Windows.Forms.Label
    Friend WithEvents lblRenee As System.Windows.Forms.Label

End Class
