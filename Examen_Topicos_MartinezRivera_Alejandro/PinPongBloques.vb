Public Class PinPongBloques
    Dim arriba, horizontal, juego, cont As Integer
    Private Sub PinPongBloques_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Timer1.Enabled = True Then
            Select Case e.KeyCode
            'Barra a la izq
                Case Keys.Left
                    Barra.Left = Barra.Left - 20
                'Barra a la derecha
                Case Keys.Right
                    Barra.Left = Barra.Left + 20
            End Select
            'Limites de la barra
            If Barra.Left <= 0 Then
                Barra.Left = 1
            End If
            If Barra.Left >= 580 Then
                Barra.Left = 579
            End If
        End If
    End Sub
    Private Sub PinPongBloques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arriba = 1
        cont = 0
        juego = 1
        Randomize(horizontal)
        horizontal = Math.Round(Rnd() * 2)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Movimiento a la izquierda de la bola
        If horizontal = 1 Then
            Bola.Left = Bola.Left - 10
            If Bola.Left <= -5 Then
                Bola.Left = -4
                horizontal = 2
            End If
        End If
        'Movimiento a la derecha de la bola
        If horizontal = 2 Then
            Bola.Left = Bola.Left + 10
            If Bola.Left >= 730 Then
                Bola.Left = 729
                horizontal = 1
            End If
        End If
        If arriba = 1 Then
            Bola.Top = Bola.Top - 10
            'Bloques Verdes
            If Bola.Bounds.IntersectsWith(V1.Bounds) And V1.Visible = True Then
                arriba = 2
                V1.Visible = False
                My.Computer.Audio.Play(My.Resources.Bloques_destruidos, AudioPlayMode.Background)
                cont = cont + 1
            End If
            If Bola.Bounds.IntersectsWith(V2.Bounds) And V2.Visible = True Then
                arriba = 2
                V2.Visible = False
                My.Computer.Audio.Play(My.Resources.Bloques_destruidos, AudioPlayMode.Background)
                cont = cont + 1
            End If
            If Bola.Bounds.IntersectsWith(V3.Bounds) And V3.Visible = True Then
                arriba = 2
                V3.Visible = False
                My.Computer.Audio.Play(My.Resources.Bloques_destruidos, AudioPlayMode.Background)
                cont = cont + 1
            End If
            If Bola.Bounds.IntersectsWith(V4.Bounds) And V4.Visible = True Then
                arriba = 2
                V4.Visible = False
                My.Computer.Audio.Play(My.Resources.Bloques_destruidos, AudioPlayMode.Background)
                cont = cont + 1
            End If
            If Bola.Bounds.IntersectsWith(V5.Bounds) And V5.Visible = True Then
                arriba = 2
                V5.Visible = False
                My.Computer.Audio.Play(My.Resources.Bloques_destruidos, AudioPlayMode.Background)
                cont = cont + 1
            End If

            'Bloques Rojos
            If Bola.Bounds.IntersectsWith(R1.Bounds) And R1.Visible = True Then
                arriba = 2
                R1.Visible = False
                My.Computer.Audio.Play(My.Resources.Bloques_destruidos, AudioPlayMode.Background)
                cont = cont + 1
            ElseIf Bola.Top <= 20 Then
                arriba = 2
            End If
            If Bola.Bounds.IntersectsWith(R2.Bounds) And R2.Visible = True Then
                arriba = 2
                R2.Visible = False
                My.Computer.Audio.Play(My.Resources.Bloques_destruidos, AudioPlayMode.Background)
                cont = cont + 1
            ElseIf Bola.Top <= 20 Then
                arriba = 2
            End If
            If Bola.Bounds.IntersectsWith(R3.Bounds) And R3.Visible = True Then
                arriba = 2
                R3.Visible = False
                My.Computer.Audio.Play(My.Resources.Bloques_destruidos, AudioPlayMode.Background)
                cont = cont + 1
            ElseIf Bola.Top <= 20 Then
                arriba = 2
            End If
            If Bola.Bounds.IntersectsWith(R4.Bounds) And R4.Visible = True Then
                arriba = 2
                R4.Visible = False
                My.Computer.Audio.Play(My.Resources.Bloques_destruidos, AudioPlayMode.Background)
                cont = cont + 1
            ElseIf Bola.Top <= 20 Then
                arriba = 2
            End If
            If Bola.Bounds.IntersectsWith(R5.Bounds) And R5.Visible = True Then
                arriba = 2
                R5.Visible = False
                My.Computer.Audio.Play(My.Resources.Bloques_destruidos, AudioPlayMode.Background)
                cont = cont + 1
            ElseIf Bola.Top <= 20 Then
                arriba = 2
            End If
        End If

        If arriba = 2 Then
            Bola.Top = Bola.Top + 10
            'Colision entre bola y barra
            If Bola.Bounds.IntersectsWith(Barra.Bounds) Then
                arriba = 1
            End If
            'Cuando pierdes
            If Bola.Top >= 460 Then
                GameOver.Visible = True
                Timer1.Enabled = False
                My.Computer.Audio.Play(My.Resources.GameOver, AudioPlayMode.Background)
                juego = 2
            End If
            If cont = 10 Then
                Timer1.Enabled = False
                Win.Visible = True
                My.Computer.Audio.Play(My.Resources.YouWin, AudioPlayMode.Background)
                juego = 2
            End If
        End If
    End Sub
    Private Sub JuegoNuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JuegoNuevoToolStripMenuItem.Click
        'Posiciones iniciales
        Barra.Top = 480
        Barra.Left = 290
        Bola.Top = 415
        Bola.Left = 350

        juego = 1

        'Bloques visibles
        V1.Visible = True
        V2.Visible = True
        V3.Visible = True
        V4.Visible = True
        V5.Visible = True
        R1.Visible = True
        R2.Visible = True
        R3.Visible = True
        R4.Visible = True
        R5.Visible = True

        'Desactivar timer
        Timer1.Enabled = False

        'Imagenes invisibles
        GameOver.Visible = False
        Win.Visible = False
        cont = 0
    End Sub

    Private Sub IniciarJuegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarJuegoToolStripMenuItem.Click
        If juego = 1 Then
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
End Class
