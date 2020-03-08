<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Playermove = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.play = New System.Windows.Forms.Button()
        Me.Stats = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.results = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearStatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(51, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player Choice:"
        '
        'Playermove
        '
        Me.Playermove.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Playermove.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Playermove.FormattingEnabled = True
        Me.Playermove.Items.AddRange(New Object() {"Rock", "Paper", "Scissors"})
        Me.Playermove.Location = New System.Drawing.Point(132, 137)
        Me.Playermove.Name = "Playermove"
        Me.Playermove.Size = New System.Drawing.Size(121, 21)
        Me.Playermove.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(335, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Computer Choice:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 3
        '
        'play
        '
        Me.play.Location = New System.Drawing.Point(263, 252)
        Me.play.Name = "play"
        Me.play.Size = New System.Drawing.Size(92, 50)
        Me.play.TabIndex = 4
        Me.play.Text = "Play Game"
        Me.play.UseVisualStyleBackColor = True
        '
        'Stats
        '
        Me.Stats.Location = New System.Drawing.Point(435, 252)
        Me.Stats.Name = "Stats"
        Me.Stats.Size = New System.Drawing.Size(97, 50)
        Me.Stats.TabIndex = 5
        Me.Stats.Text = "Game Statistics"
        Me.Stats.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(272, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Results:"
        '
        'results
        '
        Me.results.AutoSize = True
        Me.results.Location = New System.Drawing.Point(338, 204)
        Me.results.Name = "results"
        Me.results.Size = New System.Drawing.Size(0, 13)
        Me.results.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearStatisticsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearStatisticsToolStripMenuItem
        '
        Me.ClearStatisticsToolStripMenuItem.Name = "ClearStatisticsToolStripMenuItem"
        Me.ClearStatisticsToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ClearStatisticsToolStripMenuItem.Text = "Clear Statistics"
        '
        'RPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.results)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Stats)
        Me.Controls.Add(Me.play)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Playermove)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RPS"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Playermove As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents play As Button
    Friend WithEvents Stats As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents results As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearStatisticsToolStripMenuItem As ToolStripMenuItem
End Class
