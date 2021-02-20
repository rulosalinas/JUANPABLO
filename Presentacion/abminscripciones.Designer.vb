<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmabminscripciones
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
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbxdivision = New System.Windows.Forms.ComboBox()
        Me.cbxcurso = New System.Windows.Forms.ComboBox()
        Me.cbxnivel = New System.Windows.Forms.ComboBox()
        Me.dtfinscripcion = New System.Windows.Forms.DateTimePicker()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtidinscripcion = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtidalumno = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblbaja = New System.Windows.Forms.Label()
        Me.lblmodificar = New System.Windows.Forms.Label()
        Me.lblnuevo = New System.Windows.Forms.Label()
        Me.Erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbuscaralumno = New System.Windows.Forms.Button()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblsalir = New System.Windows.Forms.Label()
        Me.lblguardar = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnguardaralta = New System.Windows.Forms.Button()
        Me.btnguardaredicion = New System.Windows.Forms.Button()
        Me.btnguardarbaja = New System.Windows.Forms.Button()
        Me.cbcondicional = New System.Windows.Forms.CheckBox()
        Me.cbxanio = New System.Windows.Forms.ComboBox()
        CType(Me.Erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(306, 95)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.ReadOnly = True
        Me.txtdni.Size = New System.Drawing.Size(88, 20)
        Me.txtdni.TabIndex = 627
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(277, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 626
        Me.Label14.Text = "DNI"
        '
        'cbxdivision
        '
        Me.cbxdivision.FormattingEnabled = True
        Me.cbxdivision.Location = New System.Drawing.Point(290, 201)
        Me.cbxdivision.Name = "cbxdivision"
        Me.cbxdivision.Size = New System.Drawing.Size(105, 21)
        Me.cbxdivision.TabIndex = 625
        '
        'cbxcurso
        '
        Me.cbxcurso.FormattingEnabled = True
        Me.cbxcurso.Location = New System.Drawing.Point(100, 201)
        Me.cbxcurso.Name = "cbxcurso"
        Me.cbxcurso.Size = New System.Drawing.Size(103, 21)
        Me.cbxcurso.TabIndex = 624
        '
        'cbxnivel
        '
        Me.cbxnivel.FormattingEnabled = True
        Me.cbxnivel.Location = New System.Drawing.Point(100, 163)
        Me.cbxnivel.Name = "cbxnivel"
        Me.cbxnivel.Size = New System.Drawing.Size(295, 21)
        Me.cbxnivel.TabIndex = 622
        '
        'dtfinscripcion
        '
        Me.dtfinscripcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfinscripcion.Location = New System.Drawing.Point(120, 240)
        Me.dtfinscripcion.Name = "dtfinscripcion"
        Me.dtfinscripcion.Size = New System.Drawing.Size(95, 20)
        Me.dtfinscripcion.TabIndex = 620
        Me.dtfinscripcion.Value = New Date(2019, 9, 28, 10, 28, 0, 0)
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(22, 244)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(91, 13)
        Me.label20.TabIndex = 618
        Me.label20.Text = "Fecha Inscripción"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(22, 132)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(42, 13)
        Me.label4.TabIndex = 611
        Me.label4.Text = "Alumno"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(100, 128)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(268, 20)
        Me.txtnombre.TabIndex = 612
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(22, 205)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(34, 13)
        Me.label13.TabIndex = 615
        Me.label13.Text = "Curso"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(242, 205)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(44, 13)
        Me.label12.TabIndex = 614
        Me.label12.Text = "División"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(22, 166)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(31, 13)
        Me.label11.TabIndex = 613
        Me.label11.Text = "Nivel"
        '
        'txtidinscripcion
        '
        Me.txtidinscripcion.Location = New System.Drawing.Point(100, 91)
        Me.txtidinscripcion.Name = "txtidinscripcion"
        Me.txtidinscripcion.ReadOnly = True
        Me.txtidinscripcion.Size = New System.Drawing.Size(44, 20)
        Me.txtidinscripcion.TabIndex = 631
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(22, 98)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(73, 13)
        Me.label7.TabIndex = 630
        Me.label7.Text = "N° Inscripcion"
        '
        'txtidalumno
        '
        Me.txtidalumno.Location = New System.Drawing.Point(205, 95)
        Me.txtidalumno.Name = "txtidalumno"
        Me.txtidalumno.ReadOnly = True
        Me.txtidalumno.Size = New System.Drawing.Size(57, 20)
        Me.txtidalumno.TabIndex = 629
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(163, 98)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(39, 13)
        Me.label3.TabIndex = 628
        Me.label3.Text = "Legajo"
        '
        'lblbaja
        '
        Me.lblbaja.AutoSize = True
        Me.lblbaja.BackColor = System.Drawing.Color.Transparent
        Me.lblbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbaja.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblbaja.Location = New System.Drawing.Point(172, 27)
        Me.lblbaja.Name = "lblbaja"
        Me.lblbaja.Size = New System.Drawing.Size(158, 20)
        Me.lblbaja.TabIndex = 634
        Me.lblbaja.Text = "BAJA INSCRIPCION"
        Me.lblbaja.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblbaja.Visible = False
        '
        'lblmodificar
        '
        Me.lblmodificar.AutoSize = True
        Me.lblmodificar.BackColor = System.Drawing.Color.Transparent
        Me.lblmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodificar.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblmodificar.Location = New System.Drawing.Point(150, 27)
        Me.lblmodificar.Name = "lblmodificar"
        Me.lblmodificar.Size = New System.Drawing.Size(208, 20)
        Me.lblmodificar.TabIndex = 633
        Me.lblmodificar.Text = "MODIFICAR INSCRIPCION"
        Me.lblmodificar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblmodificar.Visible = False
        '
        'lblnuevo
        '
        Me.lblnuevo.AutoSize = True
        Me.lblnuevo.BackColor = System.Drawing.Color.Transparent
        Me.lblnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnuevo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblnuevo.Location = New System.Drawing.Point(166, 27)
        Me.lblnuevo.Name = "lblnuevo"
        Me.lblnuevo.Size = New System.Drawing.Size(173, 20)
        Me.lblnuevo.TabIndex = 632
        Me.lblnuevo.Text = "NUEVA INSCRIPCION"
        Me.lblnuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblnuevo.Visible = False
        '
        'Erroricono
        '
        Me.Erroricono.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(277, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 636
        Me.Label1.Text = "Periodo"
        '
        'btnbuscaralumno
        '
        Me.btnbuscaralumno.BackColor = System.Drawing.Color.Transparent
        Me.btnbuscaralumno.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.buscar
        Me.btnbuscaralumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscaralumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscaralumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscaralumno.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnbuscaralumno.Location = New System.Drawing.Point(372, 127)
        Me.btnbuscaralumno.Margin = New System.Windows.Forms.Padding(1)
        Me.btnbuscaralumno.Name = "btnbuscaralumno"
        Me.btnbuscaralumno.Size = New System.Drawing.Size(23, 23)
        Me.btnbuscaralumno.TabIndex = 621
        Me.btnbuscaralumno.UseVisualStyleBackColor = False
        Me.btnbuscaralumno.Visible = False
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.DimGray
        Me.lblfecha.Location = New System.Drawing.Point(367, 18)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(38, 16)
        Me.lblfecha.TabIndex = 637
        Me.lblfecha.Text = "Fecha"
        '
        'Timer1
        '
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.BackColor = System.Drawing.Color.Transparent
        Me.lblhora.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.Color.DimGray
        Me.lblhora.Location = New System.Drawing.Point(373, 32)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(32, 16)
        Me.lblhora.TabIndex = 638
        Me.lblhora.Text = "Hora"
        '
        'lblsalir
        '
        Me.lblsalir.AutoSize = True
        Me.lblsalir.BackColor = System.Drawing.Color.Transparent
        Me.lblsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalir.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblsalir.Location = New System.Drawing.Point(321, 384)
        Me.lblsalir.Name = "lblsalir"
        Me.lblsalir.Size = New System.Drawing.Size(38, 13)
        Me.lblsalir.TabIndex = 644
        Me.lblsalir.Text = "SALIR"
        '
        'lblguardar
        '
        Me.lblguardar.AutoSize = True
        Me.lblguardar.BackColor = System.Drawing.Color.Transparent
        Me.lblguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblguardar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblguardar.Location = New System.Drawing.Point(114, 384)
        Me.lblguardar.Name = "lblguardar"
        Me.lblguardar.Size = New System.Drawing.Size(61, 13)
        Me.lblguardar.TabIndex = 643
        Me.lblguardar.Text = "GUARDAR"
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncerrar.Location = New System.Drawing.Point(306, 318)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(60, 60)
        Me.btncerrar.TabIndex = 640
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnguardaralta
        '
        Me.btnguardaralta.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaralta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaralta.Location = New System.Drawing.Point(115, 318)
        Me.btnguardaralta.Name = "btnguardaralta"
        Me.btnguardaralta.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaralta.TabIndex = 639
        Me.btnguardaralta.UseVisualStyleBackColor = True
        Me.btnguardaralta.Visible = False
        '
        'btnguardaredicion
        '
        Me.btnguardaredicion.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaredicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaredicion.Location = New System.Drawing.Point(115, 318)
        Me.btnguardaredicion.Name = "btnguardaredicion"
        Me.btnguardaredicion.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaredicion.TabIndex = 642
        Me.btnguardaredicion.UseVisualStyleBackColor = True
        Me.btnguardaredicion.Visible = False
        '
        'btnguardarbaja
        '
        Me.btnguardarbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardarbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardarbaja.Location = New System.Drawing.Point(115, 318)
        Me.btnguardarbaja.Name = "btnguardarbaja"
        Me.btnguardarbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnguardarbaja.TabIndex = 641
        Me.btnguardarbaja.UseVisualStyleBackColor = True
        Me.btnguardarbaja.Visible = False
        '
        'cbcondicional
        '
        Me.cbcondicional.AutoSize = True
        Me.cbcondicional.Location = New System.Drawing.Point(25, 54)
        Me.cbcondicional.Name = "cbcondicional"
        Me.cbcondicional.Size = New System.Drawing.Size(81, 17)
        Me.cbcondicional.TabIndex = 646
        Me.cbcondicional.Text = "Condicional"
        Me.cbcondicional.UseVisualStyleBackColor = True
        '
        'cbxanio
        '
        Me.cbxanio.FormattingEnabled = True
        Me.cbxanio.Location = New System.Drawing.Point(321, 240)
        Me.cbxanio.Name = "cbxanio"
        Me.cbxanio.Size = New System.Drawing.Size(73, 21)
        Me.cbxanio.TabIndex = 647
        '
        'frmabminscripciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.depositphotos_38740641_stock_photo_white_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(483, 410)
        Me.Controls.Add(Me.cbxanio)
        Me.Controls.Add(Me.cbcondicional)
        Me.Controls.Add(Me.lblsalir)
        Me.Controls.Add(Me.lblguardar)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnguardaralta)
        Me.Controls.Add(Me.btnguardaredicion)
        Me.Controls.Add(Me.btnguardarbaja)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblbaja)
        Me.Controls.Add(Me.lblmodificar)
        Me.Controls.Add(Me.lblnuevo)
        Me.Controls.Add(Me.txtidinscripcion)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.txtidalumno)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbxdivision)
        Me.Controls.Add(Me.cbxcurso)
        Me.Controls.Add(Me.cbxnivel)
        Me.Controls.Add(Me.btnbuscaralumno)
        Me.Controls.Add(Me.dtfinscripcion)
        Me.Controls.Add(Me.label20)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.label11)
        Me.Name = "frmabminscripciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "abminscripciones"
        CType(Me.Erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtdni As System.Windows.Forms.TextBox
    Public WithEvents txtnombre As System.Windows.Forms.TextBox
    Public WithEvents txtidalumno As System.Windows.Forms.TextBox
    Public WithEvents lblbaja As System.Windows.Forms.Label
    Public WithEvents lblmodificar As System.Windows.Forms.Label
    Public WithEvents lblnuevo As System.Windows.Forms.Label
    Friend WithEvents Erroricono As System.Windows.Forms.ErrorProvider
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents cbxdivision As System.Windows.Forms.ComboBox
    Public WithEvents cbxcurso As System.Windows.Forms.ComboBox
    Public WithEvents cbxnivel As System.Windows.Forms.ComboBox
    Public WithEvents btnbuscaralumno As System.Windows.Forms.Button
    Public WithEvents dtfinscripcion As System.Windows.Forms.DateTimePicker
    Public WithEvents label20 As System.Windows.Forms.Label
    Public WithEvents label4 As System.Windows.Forms.Label
    Public WithEvents label13 As System.Windows.Forms.Label
    Public WithEvents label12 As System.Windows.Forms.Label
    Public WithEvents label11 As System.Windows.Forms.Label
    Public WithEvents txtidinscripcion As System.Windows.Forms.TextBox
    Public WithEvents label7 As System.Windows.Forms.Label
    Public WithEvents label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblhora As Label
    Friend WithEvents lblsalir As Label
    Friend WithEvents lblguardar As Label
    Private WithEvents btncerrar As Button
    Public WithEvents btnguardaralta As Button
    Public WithEvents btnguardaredicion As Button
    Public WithEvents btnguardarbaja As Button
    Friend WithEvents cbcondicional As CheckBox
    Friend WithEvents cbxanio As ComboBox
End Class
