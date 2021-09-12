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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarListasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Total = New System.Windows.Forms.ListBox()
        Me.Descuento2 = New System.Windows.Forms.ListBox()
        Me.Descuento1 = New System.Windows.Forms.ListBox()
        Me.Subtotal = New System.Windows.Forms.ListBox()
        Me.Cine = New System.Windows.Forms.ListBox()
        Me.Función = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CINE GUATE"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarListasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(682, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar entradas"
        '
        'LimpiarListasToolStripMenuItem
        '
        Me.LimpiarListasToolStripMenuItem.Name = "LimpiarListasToolStripMenuItem"
        Me.LimpiarListasToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.LimpiarListasToolStripMenuItem.Text = "Limpiar listas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 76)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(514, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(440, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cantidad:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(271, 27)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cine:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(74, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Función:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Total)
        Me.GroupBox2.Controls.Add(Me.Descuento2)
        Me.GroupBox2.Controls.Add(Me.Descuento1)
        Me.GroupBox2.Controls.Add(Me.Subtotal)
        Me.GroupBox2.Controls.Add(Me.Cine)
        Me.GroupBox2.Controls.Add(Me.Función)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(631, 258)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precio:"
        '
        'Total
        '
        Me.Total.FormattingEnabled = True
        Me.Total.ItemHeight = 16
        Me.Total.Location = New System.Drawing.Point(514, 21)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(95, 228)
        Me.Total.TabIndex = 5
        '
        'Descuento2
        '
        Me.Descuento2.FormattingEnabled = True
        Me.Descuento2.ItemHeight = 16
        Me.Descuento2.Location = New System.Drawing.Point(413, 21)
        Me.Descuento2.Name = "Descuento2"
        Me.Descuento2.Size = New System.Drawing.Size(95, 228)
        Me.Descuento2.TabIndex = 4
        '
        'Descuento1
        '
        Me.Descuento1.FormattingEnabled = True
        Me.Descuento1.ItemHeight = 16
        Me.Descuento1.Location = New System.Drawing.Point(312, 21)
        Me.Descuento1.Name = "Descuento1"
        Me.Descuento1.Size = New System.Drawing.Size(95, 228)
        Me.Descuento1.TabIndex = 3
        '
        'Subtotal
        '
        Me.Subtotal.FormattingEnabled = True
        Me.Subtotal.ItemHeight = 16
        Me.Subtotal.Location = New System.Drawing.Point(211, 21)
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.Size = New System.Drawing.Size(95, 228)
        Me.Subtotal.TabIndex = 2
        '
        'Cine
        '
        Me.Cine.FormattingEnabled = True
        Me.Cine.ItemHeight = 16
        Me.Cine.Location = New System.Drawing.Point(110, 21)
        Me.Cine.Name = "Cine"
        Me.Cine.Size = New System.Drawing.Size(95, 228)
        Me.Cine.TabIndex = 1
        '
        'Función
        '
        Me.Función.FormattingEnabled = True
        Me.Función.ItemHeight = 16
        Me.Función.Location = New System.Drawing.Point(9, 21)
        Me.Función.Name = "Función"
        Me.Función.Size = New System.Drawing.Size(95, 228)
        Me.Función.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Control de Pagos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarListasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Total As ListBox
    Friend WithEvents Descuento2 As ListBox
    Friend WithEvents Descuento1 As ListBox
    Friend WithEvents Subtotal As ListBox
    Friend WithEvents Cine As ListBox
    Friend WithEvents Función As ListBox
End Class
