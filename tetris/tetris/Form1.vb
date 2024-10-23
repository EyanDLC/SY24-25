Imports System.Formats.Asn1.AsnWriter
Imports System.Xml

Public Class form1
    Dim Time As Integer
    Dim movements As New Dictionary(Of String, Collection)
    Dim tracks As New Dictionary(Of String, Integer)
    Dim Score As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Follow(enemy, Avatar, 1, 1)
    End Sub
    Sub Pace(e As PictureBox, p As PictureBox, s As Integer)
        Dim Dir As Integer
        Dir = e.Tag
        If e.Location.X > p.Location.X Then
            e.Location += New Point(Dir * s, 0)
        Else
            e.Location += New Point(Dir * s, 0)
            e.Tag = -Dir
        End If
    End Sub
    Sub Follow(e As PictureBox, a As PictureBox, speedx As Integer, speedy As Integer)
        If e.Location.Y > a.Location.Y Then
            move(e, 0, -speedy)
        Else
            move(e, 0, speedy)
        End If
        If e.Location.X > a.Location.X Then
            move(e, -speedx, 0)
        Else
            move(e, speedx, 0)
        End If
    End Sub

    Sub Track(e As PictureBox, a As PictureBox)
        If Not tracks.ContainsKey(e.Name & a.Name) Then
            tracks.Add(e.Name & a.Name, 1)
        Else
            Dim idx As Integer
            idx = tracks(e.Name & a.Name)
            If movements.ContainsKey(a.Name) AndAlso idx < movements(a.Name).Count Then
                e.Location = movements(a.Name).Item(idx)
                tracks(e.Name & a.Name) = idx + 1
            End If

        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, ResetButton.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(Avatar, -7.2, 0)
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(Avatar, 7.2, 0)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(Avatar, 0, 7.2)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            move(Avatar, 0, -7.2)
        End If
        Dim p As PictureBox
        If IntersectsWith(enemy, "Player", p) Then
            p.Visible = False
        End If
        If Avatar.Visible = False Then
            Timer2.Enabled = False
            GameOverScreen.Visible = True
            GameOverScore.Visible = True
            GameOverScoreLabel.Visible = True
            GameOverTime.Visible = True
            GameOverTimeLabel.Visible = True
            ResetButton.Visible = True
            Timer1.Enabled = False
            GameOverScore.Text = ScoreLabel.Text
            GameOverTime.Text = TimeLabel.Text
        ElseIf Avatar.Visible = True Then
            Timer2.Enabled = True
            GameOverScreen.Visible = False
            GameOverScore.Visible = False
            GameOverScoreLabel.Visible = False
            GameOverTime.Visible = False
            GameOverTimeLabel.Visible = False
            ResetButton.Visible = False
            Timer1.Enabled = True
            If ScoreLabel.Text = 9 Then
                WinScreen.Visible = True
                ResetButton.Visible = True
                Timer1.Enabled = False
            End If

        End If

        Dim c As PictureBox
        If IntersectsWith(Avatar, "coin", c) Then
            c.Visible = False
            Score = Score + 1D
            ScoreLabel.Text = Score
        End If


    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
        Dim Score As Integer
        If IntersectsWith(p, "wall") Then
            p.Location -= New Point(xdir, ydir)
        End If

        If Not movements.ContainsKey(p.Name) Then
            movements.Add(p.Name, New Collection)
        End If
        movements(p.Name).Add(p.Location)

    End Sub

    Function endingWith(s As String) As Collection
        Dim coll As New Collection
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing Then
                If UCase(obj.Name).EndsWith(UCase(s)) Then
                    coll.Add(obj)
                End If
            End If
        Next
        Return coll
    End Function
    Function IntersectsWith(p As PictureBox, tag As String) As Boolean
        Return IntersectsWith(p, tag, Nothing)
    End Function
    Function IntersectsWith(p As PictureBox, tag As String, Optional ByRef other As PictureBox = Nothing) As Boolean
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing AndAlso obj.Visible Then
                If p.Bounds.IntersectsWith(obj.Bounds) And (UCase(obj.Tag) = UCase(tag) Or
                    UCase(obj.Name).EndsWith(UCase(tag))) Then
                    other = obj
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Time += 1
        TimeLabel.Text = Time
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles ResetButton.Click


        Timer1.Enabled = True
        WinScreen.Visible = False
        GameOverScreen.Visible = False
        GameOverScore.Visible = False
        GameOverScoreLabel.Visible = False
        GameOverTime.Visible = False
        GameOverTimeLabel.Visible = False
        ResetButton.Visible = False
        Avatar.Visible = True
        Flower.Visible = True
        Flower3.Visible = True
        Flower4.Visible = True
        Flower5.Visible = True
        Flower6.Visible = True
        Flower7.Visible = True
        Flower8.Visible = True
        Flower9.Visible = True
        Flower10.Visible = True
        TimeLabel.Text = "0"
        ScoreLabel.Text = "0"
        Score = 0
        Time = 0
        Avatar.Location = New Point(206, 391)
        enemy.Location = New Point(418, 185)
    End Sub

End Class
