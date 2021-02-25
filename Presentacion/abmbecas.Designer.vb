<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abmbecas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtfinbeca = New System.Windows.Forms.DateTimePicker()
        Me.dtfinicio = New System.Windows.Forms.DateTimePicker()
        Me.lblsalir = New System.Windows.Forms.Label()
        Me.lblguardar = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtresolucion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtidbeca = New System.Windows.Forms.TextBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtidalumno = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lblmodificar = New System.Windows.Forms.Label()
        Me.lblnuevo = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbuscaralu = New System.Windows.Forms.Button()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblbaja = New System.Windows.Forms.Label()
        Me.btnguardaralta = New System.Windows.Forms.Button()
        Me.btnguardaredicion = New System.Windows.Forms.Button()
        Me.btnguardarbaja = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(317, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 437
        Me.Label1.Text = "Inicio"
        '
        'dtfinbeca
        '
        Me.dtfinbeca.Enabled = False
        Me.dtfinbeca.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfinbeca.Location = New System.Drawing.Point(355, 63)
        Me.dtfinbeca.Name = "dtfinbeca"
        Me.dtfinbeca.Size = New System.Drawing.Size(94, 20)
        Me.dtfinbeca.TabIndex = 436
        '
        'dtfinicio
        '
        Me.dtfinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfinicio.Location = New System.Drawing.Point(355, 27)
        Me.dtfinicio.Name = "dtfinicio"
        Me.dtfinicio.Size = New System.Drawing.Size(94, 20)
        Me.dtfinicio.TabIndex = 435
        '
        'lblsalir
        '
        Me.lblsalir.AutoSize = True
        Me.lblsalir.BackColor = System.Drawing.Color.Transparent
        Me.lblsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalir.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblsalir.Location = New System.Drawing.Point(312, 339)
        Me.lblsalir.Name = "lblsalir"
        Me.lblsalir.Size = New System.Drawing.Size(38, 13)
        Me.lblsalir.TabIndex = 448
        Me.lblsalir.Text = "SALIR"
        '
        'lblguardar
        '
        Me.lblguardar.AutoSize = True
        Me.lblguardar.BackColor = System.Drawing.Color.Transparent
        Me.lblguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblguardar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblguardar.Location = New System.Drawing.Point(105, 339)
        Me.lblguardar.Name = "lblguardar"
        Me.lblguardar.Size = New System.Drawing.Size(61, 13)
        Me.lblguardar.TabIndex = 447
        Me.lblguardar.Text = "GUARDAR"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.txtestado)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtfinbeca)
        Me.GroupBox2.Controls.Add(Me.dtfinicio)
        Me.GroupBox2.Controls.Add(Me.txtresolucion)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 101)
        Me.GroupBox2.TabIndex = 450
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Beca"
        '
        'txtestado
        '
        Me.txtestado.BackColor = System.Drawing.Color.Lime
        Me.txtestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtestado.Location = New System.Drawing.Point(75, 27)
        Me.txtestado.MaxLength = 10
        Me.txtestado.Name = "txtestado"
        Me.txtestado.ReadOnly = True
        Me.txtestado.Size = New System.Drawing.Size(71, 20)
        Me.txtestado.TabIndex = 440
        Me.txtestado.Text = "ACTIVO"
        Me.txtestado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 439
        Me.Label3.Text = "Estado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 438
        Me.Label2.Text = " Fin"
        '
        'txtresolucion
        '
        Me.txtresolucion.Location = New System.Drawing.Point(74, 63)
        Me.txtresolucion.MaxLength = 10
        Me.txtresolucion.Name = "txtresolucion"
        Me.txtresolucion.Size = New System.Drawing.Size(71, 20)
        Me.txtresolucion.TabIndex = 427
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 429
        Me.Label6.Text = "Resolucion"
        '
        'txtidbeca
        '
        Me.txtidbeca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidbeca.Location = New System.Drawing.Point(49, 19)
        Me.txtidbeca.Name = "txtidbeca"
        Me.txtidbeca.ReadOnly = True
        Me.txtidbeca.Size = New System.Drawing.Size(44, 20)
        Me.txtidbeca.TabIndex = 409
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(5, 23)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(40, 13)
        Me.label16.TabIndex = 390
        Me.label16.Text = "Codigo"
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'txtidalumno
        '
        Me.txtidalumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidalumno.Location = New System.Drawing.Point(140, 19)
        Me.txtidalumno.MaxLength = 8
        Me.txtidalumno.Name = "txtidalumno"
        Me.txtidalumno.ReadOnly = True
        Me.txtidalumno.Size = New System.Drawing.Size(52, 20)
        Me.txtidalumno.TabIndex = 413
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(196, 22)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(44, 13)
        Me.label4.TabIndex = 416
        Me.label4.Text = "Nombre"
        '
        'lblmodificar
        '
        Me.lblmodificar.AutoSize = True
        Me.lblmodificar.BackColor = System.Drawing.Color.Transparent
        Me.lblmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodificar.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblmodificar.Location = New System.Drawing.Point(169, 33)
        Me.lblmodificar.Name = "lblmodificar"
        Me.lblmodificar.Size = New System.Drawing.Size(148, 20)
        Me.lblmodificar.TabIndex = 444
        Me.lblmodificar.Text = "MODIFICAR BECA"
        Me.lblmodificar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblmodificar.Visible = False
        '
        'lblnuevo
        '
        Me.lblnuevo.AutoSize = True
        Me.lblnuevo.BackColor = System.Drawing.Color.Transparent
        Me.lblnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnuevo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblnuevo.Location = New System.Drawing.Point(185, 33)
        Me.lblnuevo.Name = "lblnuevo"
        Me.lblnuevo.Size = New System.Drawing.Size(114, 20)
        Me.lblnuevo.TabIndex = 443
        Me.lblnuevo.Text = "NUEVO BECA"
        Me.lblnuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblnuevo.Visible = False
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(98, 23)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(39, 13)
        Me.label17.TabIndex = 419
        Me.label17.Text = "Legajo"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.btnbuscaralu)
        Me.GroupBox1.Controls.Add(Me.txtidbeca)
        Me.GroupBox1.Controls.Add(Me.label16)
        Me.GroupBox1.Controls.Add(Me.txtidalumno)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.label17)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 48)
        Me.GroupBox1.TabIndex = 449
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Alumno"
        '
        'btnbuscaralu
        '
        Me.btnbuscaralu.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.buscar
        Me.btnbuscaralu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscaralu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbuscaralu.Location = New System.Drawing.Point(436, 17)
        Me.btnbuscaralu.Name = "btnbuscaralu"
        Me.btnbuscaralu.Size = New System.Drawing.Size(23, 23)
        Me.btnbuscaralu.TabIndex = 451
        Me.btnbuscaralu.UseVisualStyleBackColor = True
        Me.btnbuscaralu.Visible = False
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(246, 19)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(177, 20)
        Me.txtnombre.TabIndex = 410
        '
        'lblbaja
        '
        Me.lblbaja.AutoSize = True
        Me.lblbaja.BackColor = System.Drawing.Color.Transparent
        Me.lblbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbaja.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblbaja.Location = New System.Drawing.Point(172, 33)
        Me.lblbaja.Name = "lblbaja"
        Me.lblbaja.Size = New System.Drawing.Size(138, 20)
        Me.lblbaja.TabIndex = 445
        Me.lblbaja.Text = " ELIMINAR BECA"
        Me.lblbaja.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblbaja.Visible = False
        '
        'btnguardaralta
        '
        Me.btnguardaralta.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaralta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaralta.Location = New System.Drawing.Point(106, 276)
        Me.btnguardaralta.Name = "btnguardaralta"
        Me.btnguardaralta.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaralta.TabIndex = 439
        Me.btnguardaralta.UseVisualStyleBackColor = True
        Me.btnguardaralta.Visible = False
        '
        'btnguardaredicion
        '
        Me.btnguardaredicion.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaredicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaredicion.Location = New System.Drawing.Point(106, 276)
        Me.btnguardaredicion.Name = "btnguardaredicion"
        Me.btnguardaredicion.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaredicion.TabIndex = 442
        Me.btnguardaredicion.UseVisualStyleBackColor = True
        Me.btnguardaredicion.Visible = False
        '
        'btnguardarbaja
        '
        Me.btnguardarbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardarbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardarbaja.Location = New System.Drawing.Point(106, 276)
        Me.btnguardarbaja.Name = "btnguardarbaja"
        Me.btnguardarbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnguardarbaja.TabIndex = 441
        Me.btnguardarbaja.UseVisualStyleBackColor = True
        Me.btnguardarbaja.Visible = False
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncerrar.Location = New System.Drawing.Point(297, 276)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(60, 60)
        Me.btncerrar.TabIndex = 440
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Escudo_de_Juan_Pablo_II
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(12, 8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(66, 77)
        Me.PictureBox3.TabIndex = 446
        Me.PictureBox3.TabStop = False
        '
        'abmbecas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 359)
        Me.Controls.Add(Me.lblsalir)
        Me.Controls.Add(Me.lblguardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnguardaralta)
        Me.Controls.Add(Me.btnguardaredicion)
        Me.Controls.Add(Me.btnguardarbaja)
        Me.Controls.Add(Me.lblmodificar)
        Me.Controls.Add(Me.lblnuevo)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblbaja)
        Me.Name = "abmbecas"
        Me.Text = "abmbecas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Label1 As Label
    Public WithEvents dtfinbeca As DateTimePicker
    Public WithEvents dtfinicio As DateTimePicker
    Friend WithEvents lblsalir As Label
    Friend WithEvents lblguardar As Label
    Public WithEvents GroupBox2 As GroupBox
    Public WithEvents Label2 As Label
    Public WithEvents txtresolucion As TextBox
    Public WithEvents Label6 As Label
    Public WithEvents txtidbeca As TextBox
    Public WithEvents label16 As Label
    Friend WithEvents erroricono As ErrorProvider
    Public WithEvents btnguardaralta As Button
    Public WithEvents btnguardaredicion As Button
    Public WithEvents btnguardarbaja As Button
    Public WithEvents lblmodificar As Label
    Public WithEvents lblnuevo As Label
    Private WithEvents btncerrar As Button
    Public WithEvents GroupBox1 As GroupBox
    Public WithEvents txtidalumno As TextBox
    Public WithEvents txtnombre As TextBox
    Public WithEvents label17 As Label
    Public WithEvents label4 As Label
    Private WithEvents PictureBox3 As PictureBox
    Public WithEvents lblbaja As Label
    Public WithEvents txtestado As TextBox
    Public WithEvents Label3 As Label
    Friend WithEvents btnbuscaralu As Button
End Class
