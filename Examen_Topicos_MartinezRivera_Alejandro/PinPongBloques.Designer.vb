<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PinPongBloques
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JuegoNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarJuegoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R1 = New System.Windows.Forms.PictureBox()
        Me.R2 = New System.Windows.Forms.PictureBox()
        Me.R5 = New System.Windows.Forms.PictureBox()
        Me.R3 = New System.Windows.Forms.PictureBox()
        Me.R4 = New System.Windows.Forms.PictureBox()
        Me.V1 = New System.Windows.Forms.PictureBox()
        Me.V2 = New System.Windows.Forms.PictureBox()
        Me.V3 = New System.Windows.Forms.PictureBox()
        Me.V4 = New System.Windows.Forms.PictureBox()
        Me.V5 = New System.Windows.Forms.PictureBox()
        Me.Barra = New System.Windows.Forms.PictureBox()
        Me.Bola = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GameOver = New System.Windows.Forms.PictureBox()
        Me.Win = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.R1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bola, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameOver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Win, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1024, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JuegoNuevoToolStripMenuItem, Me.IniciarJuegoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(93, 27)
        Me.OpcionesToolStripMenuItem.Text = "&Opciones"
        '
        'JuegoNuevoToolStripMenuItem
        '
        Me.JuegoNuevoToolStripMenuItem.Name = "JuegoNuevoToolStripMenuItem"
        Me.JuegoNuevoToolStripMenuItem.Size = New System.Drawing.Size(186, 28)
        Me.JuegoNuevoToolStripMenuItem.Text = "Juego Nuevo"
        '
        'IniciarJuegoToolStripMenuItem
        '
        Me.IniciarJuegoToolStripMenuItem.Name = "IniciarJuegoToolStripMenuItem"
        Me.IniciarJuegoToolStripMenuItem.Size = New System.Drawing.Size(186, 28)
        Me.IniciarJuegoToolStripMenuItem.Text = "Iniciar Juego"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(186, 28)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'R1
        '
        Me.R1.Image = Global.Examen_Topicos_MartinezRivera_Alejandro.My.Resources.Resources.Rojo
        Me.R1.Location = New System.Drawing.Point(-2, 32)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(200, 75)
        Me.R1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.R1.TabIndex = 1
        Me.R1.TabStop = False
        '
        'R2
        '
        Me.R2.Image = Global.Examen_Topicos_MartinezRivera_Alejandro.My.Resources.Resources.Rojo
        Me.R2.Location = New System.Drawing.Point(204, 32)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(200, 75)
        Me.R2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.R2.TabIndex = 2
        Me.R2.TabStop = False
        '
        'R5
        '
        Me.R5.Image = Global.Examen_Topicos_MartinezRivera_Alejandro.My.Resources.Resources.Rojo
        Me.R5.Location = New System.Drawing.Point(822, 32)
        Me.R5.Name = "R5"
        Me.R5.Size = New System.Drawing.Size(200, 75)
        Me.R5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.R5.TabIndex = 3
        Me.R5.TabStop = False
        '
        'R3
        '
        Me.R3.Image = Global.Examen_Topicos_MartinezRivera_Alejandro.My.Resources.Resources.Rojo
        Me.R3.Location = New System.Drawing.Point(410, 32)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(200, 75)
        Me.R3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.R3.TabIndex = 4
        Me.R3.TabStop = False
        '
        'R4
        '
        Me.R4.Image = Global.Examen_Topicos_MartinezRivera_Alejandro.My.Resources.Resources.Rojo
        Me.R4.Location = New System.Drawing.Point(616, 32)
        Me.R4.Name = "R4"
        Me.R4.Size = New System.Drawing.Size(200, 75)
        Me.R4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.R4.TabIndex = 5
        Me.R4.TabStop = False
        '
        'V1
        '
        Me.V1.Image = Global.Examen_Topicos_MartinezRivera_Alejandro.My.Resources.Resources.Verde
        Me.V1.Location = New System.Drawing.Point(-2, 113)
        Me.V1.Name = "V1"
        Me.V1.Size = New System.Drawing.Size(200, 75)
        Me.V1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.V1.TabIndex = 6
        Me.V1.TabStop = False
        '
        'V2
        '
        Me.V2.Image = Global.Examen_Topicos_MartinezRivera_Alejandro.My.Resources.Resources.Verde
        Me.V2.Location = New System.Drawing.Point(204, 113)
        Me.V2.Name = "V2"
        Me.V2.Size = New System.Drawing.Size(200, 75)
        Me.V2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.V2.TabIndex = 7
        Me.V2.TabStop = False
        '
        'V3
        '
        Me.V3.Image = Global.Examen_Topicos_MartinezRivera_Alejandro.My.Resources.Resources.Verde
        Me.V3.Location = New System.Drawing.Point(410, 113)
        Me.V3.Name = "V3"
        Me.V3.Size = New System.Drawing.Size(200, 75)
        Me.V3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.V3.TabIndex = 8
        Me.V3.TabStop = False
        '
        'V4
        '
        Me.V4.Image = Global.Examen_Topicos_MartinezRivera_Alejandro.My.Resources.Resources.Verde
        Me.V4.Location = New System.Drawing.Point(616, 113)
        Me.V4.Name = "V4"
        Me.V4.Size = New System.Drawing.Size(200, 75)
        Me.V4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.V4.TabIndex = 9
        Me.V4.TabStop = False
        '
        'V5
        '
        Me.V5.Image = Global.Examen_Topicos_MartinezRivera_Alejandro.My.Resources.Resources.Verde
        Me.V5.Location = New System.Drawing.Point(822, 113)
        Me.V5.Name = "V5"
        Me.V5.Size = New System.Drawing.Size(200, 75)
        Me.V5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.V5.TabIndex = 10
        Me.V5.TabStop = False
        '
        'Barra
        '
        Me.Barra.Image = Global.Examen_Topicos_MartinezRivera_Alejandro.My.Resources.Resources.Cursor
        Me.Barra.Location = New System.Drawing.Point(385, 591)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(250, 50)
        Me.Barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Barra.TabIndex = 11
        Me.Barra.TabStop = False
        '
        'Bola
        '
        Me.Bola.Image = Global.Examen_Topicos_MartinezRivera_Alejandro.My.Resources.Resources.Pelota
        Me.Bola.Location = New System.Drawing.Point(470, 510)
        Me.Bola.Name = "Bola"
        Me.Bola.Size = New System.Drawing.Size(80, 80)
        Me.Bola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bola.TabIndex = 12
        Me.Bola.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'GameOver
        '
        Me.GameOver.Image = Global.Examen_Topicos_MartinezRivera_Alejandro.My.Resources.Resources.game_over
        Me.GameOver.Location = New System.Drawing.Point(373, 288)
        Me.GameOver.Name = "GameOver"
        Me.GameOver.Size = New System.Drawing.Size(338, 186)
        Me.GameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GameOver.TabIndex = 13
        Me.GameOver.TabStop = False
        Me.GameOver.Visible = False
        '
        'Win
        '
        Me.Win.Image = Global.Examen_Topicos_MartinezRivera_Alejandro.My.Resources.Resources.Ganador
        Me.Win.Location = New System.Drawing.Point(373, 288)
        Me.Win.Name = "Win"
        Me.Win.Size = New System.Drawing.Size(338, 186)
        Me.Win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Win.TabIndex = 14
        Me.Win.TabStop = False
        Me.Win.Visible = False
        '
        'PinPongBloques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 653)
        Me.Controls.Add(Me.Win)
        Me.Controls.Add(Me.GameOver)
        Me.Controls.Add(Me.Bola)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.V5)
        Me.Controls.Add(Me.V4)
        Me.Controls.Add(Me.V3)
        Me.Controls.Add(Me.V2)
        Me.Controls.Add(Me.V1)
        Me.Controls.Add(Me.R4)
        Me.Controls.Add(Me.R3)
        Me.Controls.Add(Me.R5)
        Me.Controls.Add(Me.R2)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PinPongBloques"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pin Pong Bloques"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.R1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bola, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameOver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Win, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JuegoNuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IniciarJuegoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R1 As PictureBox
    Friend WithEvents R2 As PictureBox
    Friend WithEvents R5 As PictureBox
    Friend WithEvents R3 As PictureBox
    Friend WithEvents R4 As PictureBox
    Friend WithEvents V1 As PictureBox
    Friend WithEvents V2 As PictureBox
    Friend WithEvents V3 As PictureBox
    Friend WithEvents V4 As PictureBox
    Friend WithEvents V5 As PictureBox
    Friend WithEvents Barra As PictureBox
    Friend WithEvents Bola As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GameOver As PictureBox
    Friend WithEvents Win As PictureBox
End Class
