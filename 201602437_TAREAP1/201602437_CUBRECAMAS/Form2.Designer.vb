<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.REHilo = New System.Windows.Forms.Label()
        Me.RESeda = New System.Windows.Forms.Label()
        Me.REAlgo = New System.Windows.Forms.Label()
        Me.RELino = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBCosto = New System.Windows.Forms.Label()
        Me.LBPrecio = New System.Windows.Forms.Label()
        Me.LbCos = New System.Windows.Forms.Label()
        Me.LbPre = New System.Windows.Forms.Label()
        Me.BRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.REHilo)
        Me.GroupBox1.Controls.Add(Me.RESeda)
        Me.GroupBox1.Controls.Add(Me.REAlgo)
        Me.GroupBox1.Controls.Add(Me.RELino)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 137)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COSTO DE MATERIAL"
        '
        'REHilo
        '
        Me.REHilo.AutoSize = True
        Me.REHilo.Location = New System.Drawing.Point(172, 106)
        Me.REHilo.Name = "REHilo"
        Me.REHilo.Size = New System.Drawing.Size(0, 17)
        Me.REHilo.TabIndex = 7
        '
        'RESeda
        '
        Me.RESeda.AutoSize = True
        Me.RESeda.Location = New System.Drawing.Point(172, 80)
        Me.RESeda.Name = "RESeda"
        Me.RESeda.Size = New System.Drawing.Size(0, 17)
        Me.RESeda.TabIndex = 6
        '
        'REAlgo
        '
        Me.REAlgo.AutoSize = True
        Me.REAlgo.Location = New System.Drawing.Point(172, 54)
        Me.REAlgo.Name = "REAlgo"
        Me.REAlgo.Size = New System.Drawing.Size(0, 17)
        Me.REAlgo.TabIndex = 5
        '
        'RELino
        '
        Me.RELino.AutoSize = True
        Me.RELino.Location = New System.Drawing.Point(172, 28)
        Me.RELino.Name = "RELino"
        Me.RELino.Size = New System.Drawing.Size(0, 17)
        Me.RELino.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HILO CRUDO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SEDA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ALGODON:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LINO:"
        '
        'LBCosto
        '
        Me.LBCosto.AutoSize = True
        Me.LBCosto.Location = New System.Drawing.Point(45, 180)
        Me.LBCosto.Name = "LBCosto"
        Me.LBCosto.Size = New System.Drawing.Size(111, 17)
        Me.LBCosto.TabIndex = 1
        Me.LBCosto.Text = "COSTO TOTAL:"
        '
        'LBPrecio
        '
        Me.LBPrecio.AutoSize = True
        Me.LBPrecio.Location = New System.Drawing.Point(45, 221)
        Me.LBPrecio.Name = "LBPrecio"
        Me.LBPrecio.Size = New System.Drawing.Size(136, 17)
        Me.LBPrecio.TabIndex = 2
        Me.LBPrecio.Text = "PRECIO DE VENTA:"
        '
        'LbCos
        '
        Me.LbCos.AutoSize = True
        Me.LbCos.Location = New System.Drawing.Point(195, 180)
        Me.LbCos.Name = "LbCos"
        Me.LbCos.Size = New System.Drawing.Size(0, 17)
        Me.LbCos.TabIndex = 3
        '
        'LbPre
        '
        Me.LbPre.AutoSize = True
        Me.LbPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPre.Location = New System.Drawing.Point(195, 221)
        Me.LbPre.Name = "LbPre"
        Me.LbPre.Size = New System.Drawing.Size(0, 17)
        Me.LbPre.TabIndex = 4
        '
        'BRegresar
        '
        Me.BRegresar.Location = New System.Drawing.Point(334, 266)
        Me.BRegresar.Name = "BRegresar"
        Me.BRegresar.Size = New System.Drawing.Size(96, 31)
        Me.BRegresar.TabIndex = 5
        Me.BRegresar.Text = "REGRESAR"
        Me.BRegresar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 337)
        Me.Controls.Add(Me.BRegresar)
        Me.Controls.Add(Me.LbPre)
        Me.Controls.Add(Me.LbCos)
        Me.Controls.Add(Me.LBPrecio)
        Me.Controls.Add(Me.LBCosto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Calculos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents REHilo As Label
    Friend WithEvents RESeda As Label
    Friend WithEvents REAlgo As Label
    Friend WithEvents RELino As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBCosto As Label
    Friend WithEvents LBPrecio As Label
    Friend WithEvents LbCos As Label
    Friend WithEvents LbPre As Label
    Friend WithEvents BRegresar As Button
End Class
