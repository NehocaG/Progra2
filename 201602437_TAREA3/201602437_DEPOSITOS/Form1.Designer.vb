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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBAhorro = New System.Windows.Forms.RadioButton()
        Me.RBMonetarioPremi = New System.Windows.Forms.RadioButton()
        Me.RBMonetario = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TBEfectivo = New System.Windows.Forms.TextBox()
        Me.TBOtros = New System.Windows.Forms.TextBox()
        Me.TBPropio = New System.Windows.Forms.TextBox()
        Me.CBefectivo = New System.Windows.Forms.CheckBox()
        Me.CBOtros = New System.Windows.Forms.CheckBox()
        Me.CBPropios = New System.Windows.Forms.CheckBox()
        Me.BCalcular = New System.Windows.Forms.Button()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.LbAhorro = New System.Windows.Forms.Label()
        Me.LbMonPre = New System.Windows.Forms.Label()
        Me.LbInteres = New System.Windows.Forms.Label()
        Me.LbTD = New System.Windows.Forms.Label()
        Me.LbTotalDe = New System.Windows.Forms.Label()
        Me.LSA = New System.Windows.Forms.Label()
        Me.LbSalAct = New System.Windows.Forms.Label()
        Me.BBorrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBAhorro)
        Me.GroupBox1.Controls.Add(Me.RBMonetarioPremi)
        Me.GroupBox1.Controls.Add(Me.RBMonetario)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Deposito"
        '
        'RBAhorro
        '
        Me.RBAhorro.AutoSize = True
        Me.RBAhorro.Location = New System.Drawing.Point(31, 123)
        Me.RBAhorro.Name = "RBAhorro"
        Me.RBAhorro.Size = New System.Drawing.Size(86, 24)
        Me.RBAhorro.TabIndex = 2
        Me.RBAhorro.Text = "Ahorro"
        Me.RBAhorro.UseVisualStyleBackColor = True
        '
        'RBMonetarioPremi
        '
        Me.RBMonetarioPremi.AutoSize = True
        Me.RBMonetarioPremi.Location = New System.Drawing.Point(31, 76)
        Me.RBMonetarioPremi.Name = "RBMonetarioPremi"
        Me.RBMonetarioPremi.Size = New System.Drawing.Size(185, 24)
        Me.RBMonetarioPremi.TabIndex = 1
        Me.RBMonetarioPremi.Text = "Monetario Premier"
        Me.RBMonetarioPremi.UseVisualStyleBackColor = True
        '
        'RBMonetario
        '
        Me.RBMonetario.AutoSize = True
        Me.RBMonetario.Location = New System.Drawing.Point(31, 35)
        Me.RBMonetario.Name = "RBMonetario"
        Me.RBMonetario.Size = New System.Drawing.Size(113, 24)
        Me.RBMonetario.TabIndex = 0
        Me.RBMonetario.Text = "Monetario"
        Me.RBMonetario.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TBEfectivo)
        Me.GroupBox2.Controls.Add(Me.TBOtros)
        Me.GroupBox2.Controls.Add(Me.TBPropio)
        Me.GroupBox2.Controls.Add(Me.CBefectivo)
        Me.GroupBox2.Controls.Add(Me.CBOtros)
        Me.GroupBox2.Controls.Add(Me.CBPropios)
        Me.GroupBox2.Location = New System.Drawing.Point(306, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 164)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Moneda"
        '
        'TBEfectivo
        '
        Me.TBEfectivo.Location = New System.Drawing.Point(210, 122)
        Me.TBEfectivo.Name = "TBEfectivo"
        Me.TBEfectivo.Size = New System.Drawing.Size(129, 22)
        Me.TBEfectivo.TabIndex = 5
        Me.TBEfectivo.Text = "0"
        Me.TBEfectivo.Visible = False
        '
        'TBOtros
        '
        Me.TBOtros.Location = New System.Drawing.Point(210, 75)
        Me.TBOtros.Name = "TBOtros"
        Me.TBOtros.Size = New System.Drawing.Size(129, 22)
        Me.TBOtros.TabIndex = 4
        Me.TBOtros.Text = "0"
        Me.TBOtros.Visible = False
        '
        'TBPropio
        '
        Me.TBPropio.Location = New System.Drawing.Point(210, 36)
        Me.TBPropio.Name = "TBPropio"
        Me.TBPropio.Size = New System.Drawing.Size(129, 22)
        Me.TBPropio.TabIndex = 3
        Me.TBPropio.Text = "0"
        Me.TBPropio.Visible = False
        '
        'CBefectivo
        '
        Me.CBefectivo.AutoSize = True
        Me.CBefectivo.Location = New System.Drawing.Point(17, 124)
        Me.CBefectivo.Name = "CBefectivo"
        Me.CBefectivo.Size = New System.Drawing.Size(80, 21)
        Me.CBefectivo.TabIndex = 2
        Me.CBefectivo.Text = "Efectivo"
        Me.CBefectivo.UseVisualStyleBackColor = True
        '
        'CBOtros
        '
        Me.CBOtros.AutoSize = True
        Me.CBOtros.Location = New System.Drawing.Point(17, 77)
        Me.CBOtros.Name = "CBOtros"
        Me.CBOtros.Size = New System.Drawing.Size(173, 21)
        Me.CBOtros.TabIndex = 1
        Me.CBOtros.Text = "Cheques otros Bancos"
        Me.CBOtros.UseVisualStyleBackColor = True
        '
        'CBPropios
        '
        Me.CBPropios.AutoSize = True
        Me.CBPropios.Location = New System.Drawing.Point(17, 36)
        Me.CBPropios.Name = "CBPropios"
        Me.CBPropios.Size = New System.Drawing.Size(138, 21)
        Me.CBPropios.TabIndex = 0
        Me.CBPropios.Text = "Cheques Propios"
        Me.CBPropios.UseVisualStyleBackColor = True
        '
        'BCalcular
        '
        Me.BCalcular.Location = New System.Drawing.Point(28, 235)
        Me.BCalcular.Name = "BCalcular"
        Me.BCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BCalcular.TabIndex = 2
        Me.BCalcular.Text = "Calcular"
        Me.BCalcular.UseVisualStyleBackColor = True
        '
        'BLimpiar
        '
        Me.BLimpiar.Location = New System.Drawing.Point(109, 235)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BLimpiar.TabIndex = 3
        Me.BLimpiar.Text = "Limpiar"
        Me.BLimpiar.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(190, 235)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 4
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'LbAhorro
        '
        Me.LbAhorro.AutoSize = True
        Me.LbAhorro.Location = New System.Drawing.Point(25, 318)
        Me.LbAhorro.Name = "LbAhorro"
        Me.LbAhorro.Size = New System.Drawing.Size(98, 17)
        Me.LbAhorro.TabIndex = 5
        Me.LbAhorro.Text = "Interes Ahorro"
        Me.LbAhorro.Visible = False
        '
        'LbMonPre
        '
        Me.LbMonPre.AutoSize = True
        Me.LbMonPre.Location = New System.Drawing.Point(25, 318)
        Me.LbMonPre.Name = "LbMonPre"
        Me.LbMonPre.Size = New System.Drawing.Size(171, 17)
        Me.LbMonPre.TabIndex = 6
        Me.LbMonPre.Text = "Interes Monetario Premier"
        Me.LbMonPre.Visible = False
        '
        'LbInteres
        '
        Me.LbInteres.AutoSize = True
        Me.LbInteres.Location = New System.Drawing.Point(202, 318)
        Me.LbInteres.Name = "LbInteres"
        Me.LbInteres.Size = New System.Drawing.Size(0, 17)
        Me.LbInteres.TabIndex = 7
        '
        'LbTD
        '
        Me.LbTD.AutoSize = True
        Me.LbTD.Location = New System.Drawing.Point(25, 290)
        Me.LbTD.Name = "LbTD"
        Me.LbTD.Size = New System.Drawing.Size(115, 17)
        Me.LbTD.TabIndex = 8
        Me.LbTD.Text = "Total a depositar"
        Me.LbTD.Visible = False
        '
        'LbTotalDe
        '
        Me.LbTotalDe.AutoSize = True
        Me.LbTotalDe.Location = New System.Drawing.Point(202, 290)
        Me.LbTotalDe.Name = "LbTotalDe"
        Me.LbTotalDe.Size = New System.Drawing.Size(0, 17)
        Me.LbTotalDe.TabIndex = 9
        '
        'LSA
        '
        Me.LSA.AutoSize = True
        Me.LSA.Location = New System.Drawing.Point(25, 351)
        Me.LSA.Name = "LSA"
        Me.LSA.Size = New System.Drawing.Size(87, 17)
        Me.LSA.TabIndex = 10
        Me.LSA.Text = "Saldo Actual"
        Me.LSA.Visible = False
        '
        'LbSalAct
        '
        Me.LbSalAct.AutoSize = True
        Me.LbSalAct.Location = New System.Drawing.Point(202, 351)
        Me.LbSalAct.Name = "LbSalAct"
        Me.LbSalAct.Size = New System.Drawing.Size(0, 17)
        Me.LbSalAct.TabIndex = 11
        '
        'BBorrar
        '
        Me.BBorrar.BackColor = System.Drawing.Color.Red
        Me.BBorrar.Location = New System.Drawing.Point(516, 235)
        Me.BBorrar.Name = "BBorrar"
        Me.BBorrar.Size = New System.Drawing.Size(140, 32)
        Me.BBorrar.TabIndex = 12
        Me.BBorrar.Text = "Borrar Registro"
        Me.BBorrar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 414)
        Me.Controls.Add(Me.BBorrar)
        Me.Controls.Add(Me.LbSalAct)
        Me.Controls.Add(Me.LSA)
        Me.Controls.Add(Me.LbTotalDe)
        Me.Controls.Add(Me.LbTD)
        Me.Controls.Add(Me.LbInteres)
        Me.Controls.Add(Me.LbMonPre)
        Me.Controls.Add(Me.LbAhorro)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BLimpiar)
        Me.Controls.Add(Me.BCalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Depositos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBAhorro As RadioButton
    Friend WithEvents RBMonetarioPremi As RadioButton
    Friend WithEvents RBMonetario As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TBEfectivo As TextBox
    Friend WithEvents TBOtros As TextBox
    Friend WithEvents TBPropio As TextBox
    Friend WithEvents CBefectivo As CheckBox
    Friend WithEvents CBOtros As CheckBox
    Friend WithEvents CBPropios As CheckBox
    Friend WithEvents BCalcular As Button
    Friend WithEvents BLimpiar As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents LbAhorro As Label
    Friend WithEvents LbMonPre As Label
    Friend WithEvents LbInteres As Label
    Friend WithEvents LbTD As Label
    Friend WithEvents LbTotalDe As Label
    Friend WithEvents LSA As Label
    Friend WithEvents LbSalAct As Label
    Friend WithEvents BBorrar As Button
End Class
