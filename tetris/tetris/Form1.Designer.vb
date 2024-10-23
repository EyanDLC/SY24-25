<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Avatar = New PictureBox()
        Timer1 = New Timer(components)
        Flower = New PictureBox()
        enemy = New PictureBox()
        Wall1 = New PictureBox()
        TimeLabel = New Label()
        Timer2 = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        ScoreLabel = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        GameOverScreen = New Label()
        GameOverScore = New Label()
        GameOverScoreLabel = New Label()
        GameOverTimeLabel = New Label()
        GameOverTime = New Label()
        ResetButton = New Button()
        Flower3 = New PictureBox()
        Flower4 = New PictureBox()
        Flower5 = New PictureBox()
        Flower6 = New PictureBox()
        Flower7 = New PictureBox()
        Flower8 = New PictureBox()
        Flower9 = New PictureBox()
        Flower10 = New PictureBox()
        WinScreen = New Label()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(Flower, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Wall1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Flower3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Flower4, ComponentModel.ISupportInitialize).BeginInit()
        CType(Flower5, ComponentModel.ISupportInitialize).BeginInit()
        CType(Flower6, ComponentModel.ISupportInitialize).BeginInit()
        CType(Flower7, ComponentModel.ISupportInitialize).BeginInit()
        CType(Flower8, ComponentModel.ISupportInitialize).BeginInit()
        CType(Flower9, ComponentModel.ISupportInitialize).BeginInit()
        CType(Flower10, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(206, 391)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(106, 104)
        Avatar.SizeMode = PictureBoxSizeMode.Zoom
        Avatar.TabIndex = 0
        Avatar.TabStop = False
        Avatar.Tag = "Player"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1
        ' 
        ' Flower
        ' 
        Flower.Image = CType(resources.GetObject("Flower.Image"), Image)
        Flower.Location = New Point(448, 433)
        Flower.Name = "Flower"
        Flower.Size = New Size(125, 62)
        Flower.SizeMode = PictureBoxSizeMode.Zoom
        Flower.TabIndex = 1
        Flower.TabStop = False
        Flower.Tag = "coin"
        ' 
        ' enemy
        ' 
        enemy.Image = CType(resources.GetObject("enemy.Image"), Image)
        enemy.Location = New Point(418, 185)
        enemy.Name = "enemy"
        enemy.Size = New Size(183, 137)
        enemy.SizeMode = PictureBoxSizeMode.Zoom
        enemy.TabIndex = 2
        enemy.TabStop = False
        ' 
        ' Wall1
        ' 
        Wall1.BackColor = SystemColors.ActiveCaption
        Wall1.Image = CType(resources.GetObject("Wall1.Image"), Image)
        Wall1.Location = New Point(-22, -22)
        Wall1.Name = "Wall1"
        Wall1.Size = New Size(1077, 74)
        Wall1.SizeMode = PictureBoxSizeMode.StretchImage
        Wall1.TabIndex = 4
        Wall1.TabStop = False
        Wall1.Tag = "Wall"
        ' 
        ' TimeLabel
        ' 
        TimeLabel.AutoSize = True
        TimeLabel.Font = New Font("Segoe UI", 20F)
        TimeLabel.Location = New Point(137, -2)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New Size(38, 46)
        TimeLabel.TabIndex = 6
        TimeLabel.Text = "0"
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(26, -2)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 46)
        Label1.TabIndex = 7
        Label1.Text = "Time"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F)
        Label2.Location = New Point(781, -2)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 46)
        Label2.TabIndex = 8
        Label2.Text = "Flowers"
        ' 
        ' ScoreLabel
        ' 
        ScoreLabel.AutoSize = True
        ScoreLabel.Font = New Font("Segoe UI", 20F)
        ScoreLabel.Location = New Point(936, -2)
        ScoreLabel.Name = "ScoreLabel"
        ScoreLabel.Size = New Size(38, 46)
        ScoreLabel.TabIndex = 9
        ScoreLabel.Text = "0"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ActiveCaption
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-22, 590)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1064, 70)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        PictureBox1.Tag = "Wall"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.ActiveCaption
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-38, 47)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(124, 563)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        PictureBox2.Tag = "Wall"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ActiveCaption
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(980, 47)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(108, 549)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        PictureBox3.Tag = "Wall"
        ' 
        ' GameOverScreen
        ' 
        GameOverScreen.AutoSize = True
        GameOverScreen.Font = New Font("Showcard Gothic", 50F, FontStyle.Underline)
        GameOverScreen.Location = New Point(264, 95)
        GameOverScreen.Name = "GameOverScreen"
        GameOverScreen.Size = New Size(502, 103)
        GameOverScreen.TabIndex = 13
        GameOverScreen.Text = "Game Over"
        GameOverScreen.Visible = False
        ' 
        ' GameOverScore
        ' 
        GameOverScore.AutoSize = True
        GameOverScore.BorderStyle = BorderStyle.FixedSingle
        GameOverScore.Font = New Font("Segoe UI", 30F)
        GameOverScore.Location = New Point(573, 333)
        GameOverScore.Name = "GameOverScore"
        GameOverScore.Size = New Size(58, 69)
        GameOverScore.TabIndex = 14
        GameOverScore.Text = "0"
        GameOverScore.Visible = False
        ' 
        ' GameOverScoreLabel
        ' 
        GameOverScoreLabel.AutoSize = True
        GameOverScoreLabel.BorderStyle = BorderStyle.FixedSingle
        GameOverScoreLabel.Font = New Font("Segoe UI", 35F)
        GameOverScoreLabel.Location = New Point(343, 325)
        GameOverScoreLabel.Name = "GameOverScoreLabel"
        GameOverScoreLabel.Size = New Size(180, 80)
        GameOverScoreLabel.TabIndex = 15
        GameOverScoreLabel.Text = "Score"
        GameOverScoreLabel.Visible = False
        ' 
        ' GameOverTimeLabel
        ' 
        GameOverTimeLabel.AutoSize = True
        GameOverTimeLabel.BorderStyle = BorderStyle.FixedSingle
        GameOverTimeLabel.Font = New Font("Segoe UI", 35F)
        GameOverTimeLabel.Location = New Point(343, 228)
        GameOverTimeLabel.Name = "GameOverTimeLabel"
        GameOverTimeLabel.Size = New Size(164, 80)
        GameOverTimeLabel.TabIndex = 16
        GameOverTimeLabel.Text = "TIme"
        GameOverTimeLabel.Visible = False
        ' 
        ' GameOverTime
        ' 
        GameOverTime.AutoSize = True
        GameOverTime.BorderStyle = BorderStyle.FixedSingle
        GameOverTime.Font = New Font("Segoe UI", 30F)
        GameOverTime.Location = New Point(573, 236)
        GameOverTime.Name = "GameOverTime"
        GameOverTime.Size = New Size(58, 69)
        GameOverTime.TabIndex = 17
        GameOverTime.Text = "0"
        GameOverTime.Visible = False
        ' 
        ' ResetButton
        ' 
        ResetButton.BackColor = SystemColors.Info
        ResetButton.Font = New Font("Showcard Gothic", 35F)
        ResetButton.Location = New Point(318, 483)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(391, 101)
        ResetButton.TabIndex = 18
        ResetButton.Text = "Try Again?"
        ResetButton.UseVisualStyleBackColor = False
        ResetButton.Visible = False
        ' 
        ' Flower3
        ' 
        Flower3.Image = CType(resources.GetObject("Flower3.Image"), Image)
        Flower3.Location = New Point(212, 280)
        Flower3.Name = "Flower3"
        Flower3.Size = New Size(125, 62)
        Flower3.SizeMode = PictureBoxSizeMode.Zoom
        Flower3.TabIndex = 20
        Flower3.TabStop = False
        Flower3.Tag = "coin"
        ' 
        ' Flower4
        ' 
        Flower4.Image = CType(resources.GetObject("Flower4.Image"), Image)
        Flower4.Location = New Point(110, 522)
        Flower4.Name = "Flower4"
        Flower4.Size = New Size(125, 62)
        Flower4.SizeMode = PictureBoxSizeMode.Zoom
        Flower4.TabIndex = 21
        Flower4.TabStop = False
        Flower4.Tag = "coin"
        ' 
        ' Flower5
        ' 
        Flower5.Image = CType(resources.GetObject("Flower5.Image"), Image)
        Flower5.Location = New Point(834, 58)
        Flower5.Name = "Flower5"
        Flower5.Size = New Size(125, 62)
        Flower5.SizeMode = PictureBoxSizeMode.Zoom
        Flower5.TabIndex = 22
        Flower5.TabStop = False
        Flower5.Tag = "coin"
        ' 
        ' Flower6
        ' 
        Flower6.Image = CType(resources.GetObject("Flower6.Image"), Image)
        Flower6.Location = New Point(820, 522)
        Flower6.Name = "Flower6"
        Flower6.Size = New Size(125, 62)
        Flower6.SizeMode = PictureBoxSizeMode.Zoom
        Flower6.TabIndex = 23
        Flower6.TabStop = False
        Flower6.Tag = "coin"
        ' 
        ' Flower7
        ' 
        Flower7.Image = CType(resources.GetObject("Flower7.Image"), Image)
        Flower7.Location = New Point(91, 58)
        Flower7.Name = "Flower7"
        Flower7.Size = New Size(125, 62)
        Flower7.SizeMode = PictureBoxSizeMode.Zoom
        Flower7.TabIndex = 24
        Flower7.TabStop = False
        Flower7.Tag = "coin"
        ' 
        ' Flower8
        ' 
        Flower8.Image = CType(resources.GetObject("Flower8.Image"), Image)
        Flower8.Location = New Point(637, 280)
        Flower8.Name = "Flower8"
        Flower8.Size = New Size(125, 62)
        Flower8.SizeMode = PictureBoxSizeMode.Zoom
        Flower8.TabIndex = 25
        Flower8.TabStop = False
        Flower8.Tag = "coin"
        ' 
        ' Flower9
        ' 
        Flower9.Image = CType(resources.GetObject("Flower9.Image"), Image)
        Flower9.Location = New Point(448, 95)
        Flower9.Name = "Flower9"
        Flower9.Size = New Size(125, 62)
        Flower9.SizeMode = PictureBoxSizeMode.Zoom
        Flower9.TabIndex = 26
        Flower9.TabStop = False
        Flower9.Tag = "coin"
        ' 
        ' Flower10
        ' 
        Flower10.Image = CType(resources.GetObject("Flower10.Image"), Image)
        Flower10.Location = New Point(448, 280)
        Flower10.Name = "Flower10"
        Flower10.Size = New Size(125, 62)
        Flower10.SizeMode = PictureBoxSizeMode.Zoom
        Flower10.TabIndex = 27
        Flower10.TabStop = False
        Flower10.Tag = "coin"
        ' 
        ' WinScreen
        ' 
        WinScreen.AutoSize = True
        WinScreen.Font = New Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        WinScreen.Location = New Point(293, 263)
        WinScreen.Name = "WinScreen"
        WinScreen.Size = New Size(427, 98)
        WinScreen.TabIndex = 28
        WinScreen.Text = "You Win!"
        WinScreen.Visible = False
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(1030, 622)
        Controls.Add(WinScreen)
        Controls.Add(Flower10)
        Controls.Add(Flower9)
        Controls.Add(Flower8)
        Controls.Add(Flower7)
        Controls.Add(Flower6)
        Controls.Add(Flower5)
        Controls.Add(Flower4)
        Controls.Add(Flower3)
        Controls.Add(ResetButton)
        Controls.Add(GameOverTime)
        Controls.Add(GameOverTimeLabel)
        Controls.Add(GameOverScoreLabel)
        Controls.Add(GameOverScore)
        Controls.Add(GameOverScreen)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(ScoreLabel)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TimeLabel)
        Controls.Add(Wall1)
        Controls.Add(enemy)
        Controls.Add(Flower)
        Controls.Add(Avatar)
        Name = "form1"
        Text = "Form1"
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(Flower, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(Wall1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(Flower3, ComponentModel.ISupportInitialize).EndInit()
        CType(Flower4, ComponentModel.ISupportInitialize).EndInit()
        CType(Flower5, ComponentModel.ISupportInitialize).EndInit()
        CType(Flower6, ComponentModel.ISupportInitialize).EndInit()
        CType(Flower7, ComponentModel.ISupportInitialize).EndInit()
        CType(Flower8, ComponentModel.ISupportInitialize).EndInit()
        CType(Flower9, ComponentModel.ISupportInitialize).EndInit()
        CType(Flower10, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Flower As PictureBox
    Friend WithEvents enemy As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Wall1 As PictureBox
    Friend WithEvents Enemy3 As PictureBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GameOverScreen As Label
    Friend WithEvents GameOverScore As Label
    Friend WithEvents GameOverScoreLabel As Label
    Friend WithEvents GameOverTimeLabel As Label
    Friend WithEvents GameOverTime As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents Flower3 As PictureBox
    Friend WithEvents Flower4 As PictureBox
    Friend WithEvents Flower5 As PictureBox
    Friend WithEvents Flower6 As PictureBox
    Friend WithEvents Flower7 As PictureBox
    Friend WithEvents Flower8 As PictureBox
    Friend WithEvents Flower9 As PictureBox
    Friend WithEvents Flower10 As PictureBox
    Friend WithEvents WinScreen As Label

End Class
