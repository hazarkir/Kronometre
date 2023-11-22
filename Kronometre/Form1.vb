Public Class Form1
    Private kronometre As New Stopwatch
    Dim play As Boolean = True



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim sure As TimeSpan = kronometre.Elapsed
        Label1.Text = String.Format("{0:00}:{1:00}:{2:000}", sure.Minutes, sure.Seconds, sure.Milliseconds)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False

        kronometre.Reset()
        Label1.Text = "00:00:000"
        ListBox1.Items.Clear()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If play = True Then
            Timer1.Start()
            kronometre.Start()

            play = False
            Button1.BackgroundImage = Image.FromFile("img/pause.png")
            Button2.Enabled = False
            Button3.Enabled = True

        Else
            Timer1.Stop()
            kronometre.Stop()

            play = True
            Button1.BackgroundImage = Image.FromFile("img/play.png")
            Button2.Enabled = True
            Button3.Enabled = False

        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackgroundImage = Image.FromFile("img/play.png")
        Button2.BackgroundImage = Image.FromFile("img/replay.png")
        Button3.BackgroundImage = Image.FromFile("img/clock.png")

        Button2.Enabled = False
        Button3.Enabled = False


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Add(ListBox1.Items.Count + 1 & ". TUR -- " & Label1.Text)
    End Sub
End Class
