<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.btnStartComputer = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnSquare00 = New System.Windows.Forms.Button()
        Me.btnSquare01 = New System.Windows.Forms.Button()
        Me.btnSquare02 = New System.Windows.Forms.Button()
        Me.btnSquare12 = New System.Windows.Forms.Button()
        Me.btnSquare11 = New System.Windows.Forms.Button()
        Me.btnSquare10 = New System.Windows.Forms.Button()
        Me.btnSquare22 = New System.Windows.Forms.Button()
        Me.btnSquare21 = New System.Windows.Forms.Button()
        Me.btnSquare20 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Location = New System.Drawing.Point(13, 13)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(73, 13)
        Me.lblPlayerName.TabIndex = 0
        Me.lblPlayerName.Text = "Human Player"
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Location = New System.Drawing.Point(92, 10)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(224, 20)
        Me.txtPlayerName.TabIndex = 0
        '
        'btnStartGame
        '
        Me.btnStartGame.Location = New System.Drawing.Point(12, 67)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(90, 60)
        Me.btnStartGame.TabIndex = 1
        Me.btnStartGame.Text = "Start New Game"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'btnStartComputer
        '
        Me.btnStartComputer.Location = New System.Drawing.Point(12, 133)
        Me.btnStartComputer.Name = "btnStartComputer"
        Me.btnStartComputer.Size = New System.Drawing.Size(90, 60)
        Me.btnStartComputer.TabIndex = 2
        Me.btnStartComputer.Text = "GO! Computer"
        Me.btnStartComputer.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(405, 423)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(73, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(326, 423)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(73, 23)
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnSquare00
        '
        Me.btnSquare00.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.btnSquare00.Location = New System.Drawing.Point(195, 67)
        Me.btnSquare00.Name = "btnSquare00"
        Me.btnSquare00.Size = New System.Drawing.Size(80, 80)
        Me.btnSquare00.TabIndex = 6
        Me.btnSquare00.TabStop = False
        Me.btnSquare00.Text = "?"
        Me.btnSquare00.UseVisualStyleBackColor = True
        '
        'btnSquare01
        '
        Me.btnSquare01.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.btnSquare01.Location = New System.Drawing.Point(281, 67)
        Me.btnSquare01.Name = "btnSquare01"
        Me.btnSquare01.Size = New System.Drawing.Size(80, 80)
        Me.btnSquare01.TabIndex = 7
        Me.btnSquare01.TabStop = False
        Me.btnSquare01.Text = "?"
        Me.btnSquare01.UseVisualStyleBackColor = True
        '
        'btnSquare02
        '
        Me.btnSquare02.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.btnSquare02.Location = New System.Drawing.Point(367, 67)
        Me.btnSquare02.Name = "btnSquare02"
        Me.btnSquare02.Size = New System.Drawing.Size(80, 80)
        Me.btnSquare02.TabIndex = 8
        Me.btnSquare02.TabStop = False
        Me.btnSquare02.Text = "?"
        Me.btnSquare02.UseVisualStyleBackColor = True
        '
        'btnSquare12
        '
        Me.btnSquare12.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.btnSquare12.Location = New System.Drawing.Point(367, 153)
        Me.btnSquare12.Name = "btnSquare12"
        Me.btnSquare12.Size = New System.Drawing.Size(80, 80)
        Me.btnSquare12.TabIndex = 11
        Me.btnSquare12.TabStop = False
        Me.btnSquare12.Text = "?"
        Me.btnSquare12.UseVisualStyleBackColor = True
        '
        'btnSquare11
        '
        Me.btnSquare11.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.btnSquare11.Location = New System.Drawing.Point(281, 153)
        Me.btnSquare11.Name = "btnSquare11"
        Me.btnSquare11.Size = New System.Drawing.Size(80, 80)
        Me.btnSquare11.TabIndex = 10
        Me.btnSquare11.TabStop = False
        Me.btnSquare11.Text = "?"
        Me.btnSquare11.UseVisualStyleBackColor = True
        '
        'btnSquare10
        '
        Me.btnSquare10.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.btnSquare10.Location = New System.Drawing.Point(195, 153)
        Me.btnSquare10.Name = "btnSquare10"
        Me.btnSquare10.Size = New System.Drawing.Size(80, 80)
        Me.btnSquare10.TabIndex = 9
        Me.btnSquare10.TabStop = False
        Me.btnSquare10.Text = "?"
        Me.btnSquare10.UseVisualStyleBackColor = True
        '
        'btnSquare22
        '
        Me.btnSquare22.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.btnSquare22.Location = New System.Drawing.Point(367, 239)
        Me.btnSquare22.Name = "btnSquare22"
        Me.btnSquare22.Size = New System.Drawing.Size(80, 80)
        Me.btnSquare22.TabIndex = 14
        Me.btnSquare22.TabStop = False
        Me.btnSquare22.Text = "?"
        Me.btnSquare22.UseVisualStyleBackColor = True
        '
        'btnSquare21
        '
        Me.btnSquare21.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.btnSquare21.Location = New System.Drawing.Point(281, 239)
        Me.btnSquare21.Name = "btnSquare21"
        Me.btnSquare21.Size = New System.Drawing.Size(80, 80)
        Me.btnSquare21.TabIndex = 13
        Me.btnSquare21.TabStop = False
        Me.btnSquare21.Text = "?"
        Me.btnSquare21.UseVisualStyleBackColor = True
        '
        'btnSquare20
        '
        Me.btnSquare20.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.btnSquare20.Location = New System.Drawing.Point(195, 239)
        Me.btnSquare20.Name = "btnSquare20"
        Me.btnSquare20.Size = New System.Drawing.Size(80, 80)
        Me.btnSquare20.TabIndex = 12
        Me.btnSquare20.TabStop = False
        Me.btnSquare20.Text = "?"
        Me.btnSquare20.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(480, 457)
        Me.Controls.Add(Me.btnSquare22)
        Me.Controls.Add(Me.btnSquare21)
        Me.Controls.Add(Me.btnSquare20)
        Me.Controls.Add(Me.btnSquare12)
        Me.Controls.Add(Me.btnSquare11)
        Me.Controls.Add(Me.btnSquare10)
        Me.Controls.Add(Me.btnSquare02)
        Me.Controls.Add(Me.btnSquare01)
        Me.Controls.Add(Me.btnSquare00)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnStartComputer)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.lblPlayerName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "VB Game Surface - Kevin Nguyen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlayerName As Label
    Friend WithEvents txtPlayerName As TextBox
    Friend WithEvents btnStartGame As Button
    Friend WithEvents btnStartComputer As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnSquare00 As Button
    Friend WithEvents btnSquare01 As Button
    Friend WithEvents btnSquare02 As Button
    Friend WithEvents btnSquare12 As Button
    Friend WithEvents btnSquare11 As Button
    Friend WithEvents btnSquare10 As Button
    Friend WithEvents btnSquare22 As Button
    Friend WithEvents btnSquare21 As Button
    Friend WithEvents btnSquare20 As Button
End Class
