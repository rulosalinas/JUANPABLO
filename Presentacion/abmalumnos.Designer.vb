﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmabmalumnos
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
        Me.dtfbaja = New System.Windows.Forms.DateTimePicker()
        Me.dtfalta = New System.Windows.Forms.DateTimePicker()
        Me.dtfnacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.cbxsexo = New System.Windows.Forms.ComboBox()
        Me.txtlocalidad = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtdomicilio = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtidalumno = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.txtmbaja = New System.Windows.Forms.TextBox()
        Me.lblmbaja = New System.Windows.Forms.Label()
        Me.lblfbaja = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnguardaralta = New System.Windows.Forms.Button()
        Me.btnguardaredicion = New System.Windows.Forms.Button()
        Me.btnguardarbaja = New System.Windows.Forms.Button()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblnuevo = New System.Windows.Forms.Label()
        Me.lblmodificar = New System.Windows.Forms.Label()
        Me.lblbaja = New System.Windows.Forms.Label()
        Me.txtnombretutor = New System.Windows.Forms.TextBox()
        Me.lbltutor = New System.Windows.Forms.Label()
        Me.txtdnitutor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnbuscartutor = New System.Windows.Forms.Button()
        Me.gbbaja = New System.Windows.Forms.GroupBox()
        Me.lblsalir = New System.Windows.Forms.Label()
        Me.lblguardar = New System.Windows.Forms.Label()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbbaja.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtfbaja
        '
        Me.dtfbaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfbaja.Location = New System.Drawing.Point(69, 20)
        Me.dtfbaja.Name = "dtfbaja"
        Me.dtfbaja.Size = New System.Drawing.Size(128, 20)
        Me.dtfbaja.TabIndex = 17
        Me.dtfbaja.Value = New Date(2019, 9, 4, 23, 0, 41, 0)
        Me.dtfbaja.Visible = False
        '
        'dtfalta
        '
        Me.dtfalta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfalta.Location = New System.Drawing.Point(452, 221)
        Me.dtfalta.Name = "dtfalta"
        Me.dtfalta.Size = New System.Drawing.Size(185, 20)
        Me.dtfalta.TabIndex = 9
        Me.dtfalta.Value = New Date(2019, 9, 23, 13, 6, 25, 0)
        '
        'dtfnacimiento
        '
        Me.dtfnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfnacimiento.Location = New System.Drawing.Point(84, 222)
        Me.dtfnacimiento.Name = "dtfnacimiento"
        Me.dtfnacimiento.Size = New System.Drawing.Size(128, 20)
        Me.dtfnacimiento.TabIndex = 8
        Me.dtfnacimiento.Value = New Date(2019, 9, 23, 13, 6, 25, 0)
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(69, 112)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(273, 20)
        Me.txtapellido.TabIndex = 1
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(12, 116)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(44, 13)
        Me.label9.TabIndex = 11
        Me.label9.Text = "Apellido"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(452, 81)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(185, 20)
        Me.txtdni.TabIndex = 4
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(386, 86)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(35, 13)
        Me.label17.TabIndex = 177
        Me.label17.Text = "D.N.I."
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(452, 136)
        Me.txttelefono.MaxLength = 10
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(185, 20)
        Me.txttelefono.TabIndex = 6
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(385, 140)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(49, 13)
        Me.label16.TabIndex = 169
        Me.label16.Text = "Teléfono"
        '
        'cbxsexo
        '
        Me.cbxsexo.AutoCompleteCustomSource.AddRange(New String() {"MASCULINO", "FEMENINO"})
        Me.cbxsexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbxsexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbxsexo.FormattingEnabled = True
        Me.cbxsexo.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
        Me.cbxsexo.Location = New System.Drawing.Point(452, 108)
        Me.cbxsexo.Name = "cbxsexo"
        Me.cbxsexo.Size = New System.Drawing.Size(185, 21)
        Me.cbxsexo.TabIndex = 5
        '
        'txtlocalidad
        '
        Me.txtlocalidad.Location = New System.Drawing.Point(452, 163)
        Me.txtlocalidad.Name = "txtlocalidad"
        Me.txtlocalidad.Size = New System.Drawing.Size(185, 20)
        Me.txtlocalidad.TabIndex = 7
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(385, 167)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(53, 13)
        Me.label8.TabIndex = 152
        Me.label8.Text = "Localidad"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(12, 221)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(63, 13)
        Me.label7.TabIndex = 151
        Me.label7.Text = "Fecha Nac."
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(385, 112)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(31, 13)
        Me.label6.TabIndex = 150
        Me.label6.Text = "Sexo"
        '
        'txtdomicilio
        '
        Me.txtdomicilio.Location = New System.Drawing.Point(69, 166)
        Me.txtdomicilio.Name = "txtdomicilio"
        Me.txtdomicilio.Size = New System.Drawing.Size(273, 20)
        Me.txtdomicilio.TabIndex = 3
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 171)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(49, 13)
        Me.label5.TabIndex = 13
        Me.label5.Text = "Domicilio"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(69, 139)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(273, 20)
        Me.txtnombre.TabIndex = 2
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 143)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(44, 13)
        Me.label4.TabIndex = 12
        Me.label4.Text = "Nombre"
        '
        'txtidalumno
        '
        Me.txtidalumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidalumno.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtidalumno.Location = New System.Drawing.Point(69, 85)
        Me.txtidalumno.MaxLength = 4
        Me.txtidalumno.Name = "txtidalumno"
        Me.txtidalumno.ReadOnly = True
        Me.txtidalumno.Size = New System.Drawing.Size(273, 20)
        Me.txtidalumno.TabIndex = 0
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 88)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(39, 13)
        Me.label3.TabIndex = 10
        Me.label3.Text = "Legajo"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(386, 220)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(58, 13)
        Me.label14.TabIndex = 165
        Me.label14.Text = "Fecha Alta"
        '
        'txtmbaja
        '
        Me.txtmbaja.Location = New System.Drawing.Point(302, 20)
        Me.txtmbaja.Name = "txtmbaja"
        Me.txtmbaja.Size = New System.Drawing.Size(303, 20)
        Me.txtmbaja.TabIndex = 18
        Me.txtmbaja.Visible = False
        '
        'lblmbaja
        '
        Me.lblmbaja.AutoSize = True
        Me.lblmbaja.Location = New System.Drawing.Point(231, 24)
        Me.lblmbaja.Name = "lblmbaja"
        Me.lblmbaja.Size = New System.Drawing.Size(63, 13)
        Me.lblmbaja.TabIndex = 21
        Me.lblmbaja.Text = "Motivo Baja"
        Me.lblmbaja.Visible = False
        '
        'lblfbaja
        '
        Me.lblfbaja.AutoSize = True
        Me.lblfbaja.Location = New System.Drawing.Point(12, 259)
        Me.lblfbaja.Name = "lblfbaja"
        Me.lblfbaja.Size = New System.Drawing.Size(61, 13)
        Me.lblfbaja.TabIndex = 19
        Me.lblfbaja.Text = "Fecha Baja"
        Me.lblfbaja.Visible = False
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncerrar.Location = New System.Drawing.Point(377, 322)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(60, 60)
        Me.btncerrar.TabIndex = 362
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnguardaralta
        '
        Me.btnguardaralta.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaralta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaralta.Location = New System.Drawing.Point(186, 322)
        Me.btnguardaralta.Name = "btnguardaralta"
        Me.btnguardaralta.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaralta.TabIndex = 361
        Me.btnguardaralta.UseVisualStyleBackColor = True
        Me.btnguardaralta.Visible = False
        '
        'btnguardaredicion
        '
        Me.btnguardaredicion.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaredicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaredicion.Location = New System.Drawing.Point(186, 322)
        Me.btnguardaredicion.Name = "btnguardaredicion"
        Me.btnguardaredicion.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaredicion.TabIndex = 364
        Me.btnguardaredicion.UseVisualStyleBackColor = True
        Me.btnguardaredicion.Visible = False
        '
        'btnguardarbaja
        '
        Me.btnguardarbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardarbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardarbaja.Location = New System.Drawing.Point(186, 322)
        Me.btnguardarbaja.Name = "btnguardarbaja"
        Me.btnguardarbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnguardarbaja.TabIndex = 363
        Me.btnguardarbaja.UseVisualStyleBackColor = True
        Me.btnguardarbaja.Visible = False
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'lblnuevo
        '
        Me.lblnuevo.AutoSize = True
        Me.lblnuevo.BackColor = System.Drawing.Color.Transparent
        Me.lblnuevo.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnuevo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblnuevo.Location = New System.Drawing.Point(259, 24)
        Me.lblnuevo.Name = "lblnuevo"
        Me.lblnuevo.Size = New System.Drawing.Size(120, 17)
        Me.lblnuevo.TabIndex = 365
        Me.lblnuevo.Text = "NUEVO ALUMNO"
        Me.lblnuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblnuevo.Visible = False
        '
        'lblmodificar
        '
        Me.lblmodificar.AutoSize = True
        Me.lblmodificar.BackColor = System.Drawing.Color.Transparent
        Me.lblmodificar.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodificar.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblmodificar.Location = New System.Drawing.Point(243, 24)
        Me.lblmodificar.Name = "lblmodificar"
        Me.lblmodificar.Size = New System.Drawing.Size(152, 17)
        Me.lblmodificar.TabIndex = 366
        Me.lblmodificar.Text = "MODIFICAR ALUMNO"
        Me.lblmodificar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblmodificar.Visible = False
        '
        'lblbaja
        '
        Me.lblbaja.AutoSize = True
        Me.lblbaja.BackColor = System.Drawing.Color.Transparent
        Me.lblbaja.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbaja.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblbaja.Location = New System.Drawing.Point(266, 24)
        Me.lblbaja.Name = "lblbaja"
        Me.lblbaja.Size = New System.Drawing.Size(107, 17)
        Me.lblbaja.TabIndex = 367
        Me.lblbaja.Text = "BAJA ALUMNO"
        Me.lblbaja.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblbaja.Visible = False
        '
        'txtnombretutor
        '
        Me.txtnombretutor.Location = New System.Drawing.Point(70, 193)
        Me.txtnombretutor.Name = "txtnombretutor"
        Me.txtnombretutor.ReadOnly = True
        Me.txtnombretutor.Size = New System.Drawing.Size(272, 20)
        Me.txtnombretutor.TabIndex = 369
        '
        'lbltutor
        '
        Me.lbltutor.AutoSize = True
        Me.lbltutor.Location = New System.Drawing.Point(12, 195)
        Me.lbltutor.Name = "lbltutor"
        Me.lbltutor.Size = New System.Drawing.Size(32, 13)
        Me.lbltutor.TabIndex = 370
        Me.lbltutor.Text = "Tutor"
        '
        'txtdnitutor
        '
        Me.txtdnitutor.Location = New System.Drawing.Point(452, 190)
        Me.txtdnitutor.Name = "txtdnitutor"
        Me.txtdnitutor.ReadOnly = True
        Me.txtdnitutor.Size = New System.Drawing.Size(155, 20)
        Me.txtdnitutor.TabIndex = 368
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 371
        Me.Label2.Text = "DNI Tutor"
        '
        'btnbuscartutor
        '
        Me.btnbuscartutor.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.buscar
        Me.btnbuscartutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscartutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbuscartutor.Location = New System.Drawing.Point(614, 188)
        Me.btnbuscartutor.Name = "btnbuscartutor"
        Me.btnbuscartutor.Size = New System.Drawing.Size(23, 23)
        Me.btnbuscartutor.TabIndex = 372
        Me.btnbuscartutor.UseVisualStyleBackColor = True
        Me.btnbuscartutor.Visible = False
        '
        'gbbaja
        '
        Me.gbbaja.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbbaja.Controls.Add(Me.dtfbaja)
        Me.gbbaja.Controls.Add(Me.txtmbaja)
        Me.gbbaja.Controls.Add(Me.lblmbaja)
        Me.gbbaja.Location = New System.Drawing.Point(15, 249)
        Me.gbbaja.Name = "gbbaja"
        Me.gbbaja.Size = New System.Drawing.Size(624, 57)
        Me.gbbaja.TabIndex = 373
        Me.gbbaja.TabStop = False
        Me.gbbaja.Text = "Baja"
        Me.gbbaja.Visible = False
        '
        'lblsalir
        '
        Me.lblsalir.AutoSize = True
        Me.lblsalir.BackColor = System.Drawing.Color.Transparent
        Me.lblsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalir.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblsalir.Location = New System.Drawing.Point(392, 388)
        Me.lblsalir.Name = "lblsalir"
        Me.lblsalir.Size = New System.Drawing.Size(38, 13)
        Me.lblsalir.TabIndex = 375
        Me.lblsalir.Text = "SALIR"
        '
        'lblguardar
        '
        Me.lblguardar.AutoSize = True
        Me.lblguardar.BackColor = System.Drawing.Color.Transparent
        Me.lblguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblguardar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblguardar.Location = New System.Drawing.Point(185, 388)
        Me.lblguardar.Name = "lblguardar"
        Me.lblguardar.Size = New System.Drawing.Size(61, 13)
        Me.lblguardar.TabIndex = 374
        Me.lblguardar.Text = "GUARDAR"
        '
        'frmabmalumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.depositphotos_38740641_stock_photo_white_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(669, 410)
        Me.Controls.Add(Me.lblsalir)
        Me.Controls.Add(Me.lblguardar)
        Me.Controls.Add(Me.gbbaja)
        Me.Controls.Add(Me.btnbuscartutor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnombretutor)
        Me.Controls.Add(Me.lbltutor)
        Me.Controls.Add(Me.txtdnitutor)
        Me.Controls.Add(Me.lblbaja)
        Me.Controls.Add(Me.lblmodificar)
        Me.Controls.Add(Me.lblnuevo)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnguardaralta)
        Me.Controls.Add(Me.btnguardaredicion)
        Me.Controls.Add(Me.btnguardarbaja)
        Me.Controls.Add(Me.dtfalta)
        Me.Controls.Add(Me.dtfnacimiento)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.label17)
        Me.Controls.Add(Me.lblfbaja)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label16)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.cbxsexo)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtlocalidad)
        Me.Controls.Add(Me.txtidalumno)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtdomicilio)
        Me.Name = "frmabmalumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Alumnos "
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbbaja.ResumeLayout(False)
        Me.gbbaja.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Public WithEvents dtfbaja As System.Windows.Forms.DateTimePicker
    Public WithEvents dtfalta As System.Windows.Forms.DateTimePicker
    Public WithEvents dtfnacimiento As System.Windows.Forms.DateTimePicker
    Public WithEvents txtapellido As System.Windows.Forms.TextBox
    Public WithEvents label9 As System.Windows.Forms.Label
    Public WithEvents txtdni As System.Windows.Forms.TextBox
    Public WithEvents label17 As System.Windows.Forms.Label
    Public WithEvents txttelefono As System.Windows.Forms.TextBox
    Public WithEvents label16 As System.Windows.Forms.Label
    Public WithEvents cbxsexo As System.Windows.Forms.ComboBox
    Public WithEvents txtlocalidad As System.Windows.Forms.TextBox
    Public WithEvents label8 As System.Windows.Forms.Label
    Public WithEvents label7 As System.Windows.Forms.Label
    Public WithEvents label6 As System.Windows.Forms.Label
    Public WithEvents txtdomicilio As System.Windows.Forms.TextBox
    Public WithEvents label5 As System.Windows.Forms.Label
    Public WithEvents txtnombre As System.Windows.Forms.TextBox
    Public WithEvents label4 As System.Windows.Forms.Label
    Public WithEvents txtidalumno As System.Windows.Forms.TextBox
    Public WithEvents label3 As System.Windows.Forms.Label
    Public WithEvents label14 As System.Windows.Forms.Label
    Public WithEvents txtmbaja As System.Windows.Forms.TextBox
    Public WithEvents lblmbaja As System.Windows.Forms.Label
    Public WithEvents lblfbaja As System.Windows.Forms.Label
    Public WithEvents lblbaja As System.Windows.Forms.Label
    Public WithEvents lblmodificar As System.Windows.Forms.Label
    Public WithEvents lblnuevo As System.Windows.Forms.Label
    Public WithEvents btnguardaralta As System.Windows.Forms.Button
    Public WithEvents btnguardaredicion As System.Windows.Forms.Button
    Public WithEvents btnguardarbaja As System.Windows.Forms.Button
    Friend WithEvents btnbuscartutor As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtnombretutor As System.Windows.Forms.TextBox
    Public WithEvents lbltutor As System.Windows.Forms.Label
    Public WithEvents txtdnitutor As System.Windows.Forms.TextBox
    Friend WithEvents gbbaja As System.Windows.Forms.GroupBox
    Friend WithEvents lblsalir As Label
    Friend WithEvents lblguardar As Label
End Class
