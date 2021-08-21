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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBKing = New System.Windows.Forms.RadioButton()
        Me.RBQueen = New System.Windows.Forms.RadioButton()
        Me.RBMatrimonial = New System.Windows.Forms.RadioButton()
        Me.RBImperial = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TBhilo = New System.Windows.Forms.TextBox()
        Me.TBseda = New System.Windows.Forms.TextBox()
        Me.TBalgo = New System.Windows.Forms.TextBox()
        Me.TBLino = New System.Windows.Forms.TextBox()
        Me.CBHilo = New System.Windows.Forms.CheckBox()
        Me.CBSeda = New System.Windows.Forms.CheckBox()
        Me.CBAlgodon = New System.Windows.Forms.CheckBox()
        Me.CBLino = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CAMAS ""DORMI TRANQUILO"""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBKing)
        Me.GroupBox1.Controls.Add(Me.RBQueen)
        Me.GroupBox1.Controls.Add(Me.RBMatrimonial)
        Me.GroupBox1.Controls.Add(Me.RBImperial)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMAÑO "
        '
        'RBKing
        '
        Me.RBKing.AutoSize = True
        Me.RBKing.Location = New System.Drawing.Point(227, 77)
        Me.RBKing.Name = "RBKing"
        Me.RBKing.Size = New System.Drawing.Size(62, 21)
        Me.RBKing.TabIndex = 3
        Me.RBKing.Text = "KING"
        Me.RBKing.UseVisualStyleBackColor = True
        '
        'RBQueen
        '
        Me.RBQueen.AutoSize = True
        Me.RBQueen.Location = New System.Drawing.Point(227, 34)
        Me.RBQueen.Name = "RBQueen"
        Me.RBQueen.Size = New System.Drawing.Size(78, 21)
        Me.RBQueen.TabIndex = 2
        Me.RBQueen.Text = "QUEEN"
        Me.RBQueen.UseVisualStyleBackColor = True
        '
        'RBMatrimonial
        '
        Me.RBMatrimonial.AutoSize = True
        Me.RBMatrimonial.Location = New System.Drawing.Point(17, 77)
        Me.RBMatrimonial.Name = "RBMatrimonial"
        Me.RBMatrimonial.Size = New System.Drawing.Size(123, 21)
        Me.RBMatrimonial.TabIndex = 1
        Me.RBMatrimonial.Text = "MATRIMONIAL"
        Me.RBMatrimonial.UseVisualStyleBackColor = True
        '
        'RBImperial
        '
        Me.RBImperial.AutoSize = True
        Me.RBImperial.Location = New System.Drawing.Point(17, 34)
        Me.RBImperial.Name = "RBImperial"
        Me.RBImperial.Size = New System.Drawing.Size(91, 21)
        Me.RBImperial.TabIndex = 0
        Me.RBImperial.Text = "IMPERIAL"
        Me.RBImperial.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TBhilo)
        Me.GroupBox2.Controls.Add(Me.TBseda)
        Me.GroupBox2.Controls.Add(Me.TBalgo)
        Me.GroupBox2.Controls.Add(Me.TBLino)
        Me.GroupBox2.Controls.Add(Me.CBHilo)
        Me.GroupBox2.Controls.Add(Me.CBSeda)
        Me.GroupBox2.Controls.Add(Me.CBAlgodon)
        Me.GroupBox2.Controls.Add(Me.CBLino)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(416, 148)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MATERIAL"
        '
        'TBhilo
        '
        Me.TBhilo.Location = New System.Drawing.Point(227, 111)
        Me.TBhilo.Name = "TBhilo"
        Me.TBhilo.Size = New System.Drawing.Size(100, 22)
        Me.TBhilo.TabIndex = 7
        Me.TBhilo.Text = "0"
        Me.TBhilo.Visible = False
        '
        'TBseda
        '
        Me.TBseda.Location = New System.Drawing.Point(227, 84)
        Me.TBseda.Name = "TBseda"
        Me.TBseda.Size = New System.Drawing.Size(100, 22)
        Me.TBseda.TabIndex = 6
        Me.TBseda.Text = "0"
        Me.TBseda.Visible = False
        '
        'TBalgo
        '
        Me.TBalgo.Location = New System.Drawing.Point(227, 57)
        Me.TBalgo.Name = "TBalgo"
        Me.TBalgo.Size = New System.Drawing.Size(100, 22)
        Me.TBalgo.TabIndex = 5
        Me.TBalgo.Text = "0"
        Me.TBalgo.Visible = False
        '
        'TBLino
        '
        Me.TBLino.Location = New System.Drawing.Point(227, 26)
        Me.TBLino.Name = "TBLino"
        Me.TBLino.Size = New System.Drawing.Size(100, 22)
        Me.TBLino.TabIndex = 4
        Me.TBLino.Text = "0"
        Me.TBLino.Visible = False
        '
        'CBHilo
        '
        Me.CBHilo.AutoSize = True
        Me.CBHilo.Location = New System.Drawing.Point(17, 111)
        Me.CBHilo.Name = "CBHilo"
        Me.CBHilo.Size = New System.Drawing.Size(116, 21)
        Me.CBHilo.TabIndex = 3
        Me.CBHilo.Text = "HILO CRUDO"
        Me.CBHilo.UseVisualStyleBackColor = True
        '
        'CBSeda
        '
        Me.CBSeda.AutoSize = True
        Me.CBSeda.Location = New System.Drawing.Point(17, 84)
        Me.CBSeda.Name = "CBSeda"
        Me.CBSeda.Size = New System.Drawing.Size(67, 21)
        Me.CBSeda.TabIndex = 2
        Me.CBSeda.Text = "SEDA"
        Me.CBSeda.UseVisualStyleBackColor = True
        '
        'CBAlgodon
        '
        Me.CBAlgodon.AutoSize = True
        Me.CBAlgodon.Location = New System.Drawing.Point(17, 57)
        Me.CBAlgodon.Name = "CBAlgodon"
        Me.CBAlgodon.Size = New System.Drawing.Size(100, 21)
        Me.CBAlgodon.TabIndex = 1
        Me.CBAlgodon.Text = "ALGODON"
        Me.CBAlgodon.UseVisualStyleBackColor = True
        '
        'CBLino
        '
        Me.CBLino.AutoSize = True
        Me.CBLino.Location = New System.Drawing.Point(17, 28)
        Me.CBLino.Name = "CBLino"
        Me.CBLino.Size = New System.Drawing.Size(62, 21)
        Me.CBLino.TabIndex = 0
        Me.CBLino.Text = "LINO"
        Me.CBLino.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(472, 30)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(93, 26)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(78, 26)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(61, 26)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 382)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Cubrecamas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBKing As RadioButton
    Friend WithEvents RBQueen As RadioButton
    Friend WithEvents RBMatrimonial As RadioButton
    Friend WithEvents RBImperial As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CBHilo As CheckBox
    Friend WithEvents CBSeda As CheckBox
    Friend WithEvents CBAlgodon As CheckBox
    Friend WithEvents CBLino As CheckBox
    Friend WithEvents TBhilo As TextBox
    Friend WithEvents TBseda As TextBox
    Friend WithEvents TBalgo As TextBox
    Friend WithEvents TBLino As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
End Class
