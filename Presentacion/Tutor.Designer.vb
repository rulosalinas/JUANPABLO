<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtutor
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
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cbxbusqueda = New System.Windows.Forms.ComboBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnbaja = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.lblayuda = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(834, 2)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(33, 20)
        Me.txtflag.TabIndex = 375
        Me.txtflag.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(322, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 30)
        Me.Label1.TabIndex = 369
        Me.Label1.Text = "LISTADO DE TUTORES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(548, 75)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(55, 13)
        Me.Label32.TabIndex = 372
        Me.Label32.Text = "Busqueda"
        '
        'cbxbusqueda
        '
        Me.cbxbusqueda.FormattingEnabled = True
        Me.cbxbusqueda.Items.AddRange(New Object() {"DNI", "Apellido"})
        Me.cbxbusqueda.Location = New System.Drawing.Point(788, 71)
        Me.cbxbusqueda.Name = "cbxbusqueda"
        Me.cbxbusqueda.Size = New System.Drawing.Size(62, 21)
        Me.cbxbusqueda.TabIndex = 362
        Me.cbxbusqueda.Text = "DNI"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(611, 72)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(162, 20)
        Me.txtbuscar.TabIndex = 361
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.BackColor = System.Drawing.SystemColors.Control
        Me.inexistente.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inexistente.LinkColor = System.Drawing.Color.Red
        Me.inexistente.Location = New System.Drawing.Point(343, 245)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(214, 17)
        Me.inexistente.TabIndex = 364
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "NO SE ENCONTRARON DATOS"
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncerrar.Location = New System.Drawing.Point(611, 399)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(60, 60)
        Me.btncerrar.TabIndex = 368
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnbaja
        '
        Me.btnbaja.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.cancelar
        Me.btnbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbaja.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnbaja.Location = New System.Drawing.Point(455, 399)
        Me.btnbaja.Name = "btnbaja"
        Me.btnbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnbaja.TabIndex = 367
        Me.btnbaja.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnbaja.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.modificar
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btneditar.Location = New System.Drawing.Point(375, 399)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(60, 60)
        Me.btneditar.TabIndex = 366
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Agregar
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnuevo.Location = New System.Drawing.Point(290, 399)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(60, 60)
        Me.btnnuevo.TabIndex = 365
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.BackgroundColor = System.Drawing.SystemColors.Control
        Me.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Location = New System.Drawing.Point(27, 132)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(820, 231)
        Me.datalistado.TabIndex = 363
        '
        'lblayuda
        '
        Me.lblayuda.AutoSize = True
        Me.lblayuda.BackColor = System.Drawing.Color.Transparent
        Me.lblayuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblayuda.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblayuda.Location = New System.Drawing.Point(287, 104)
        Me.lblayuda.Name = "lblayuda"
        Me.lblayuda.Size = New System.Drawing.Size(346, 16)
        Me.lblayuda.TabIndex = 376
        Me.lblayuda.Text = "DOBLE CLICK PARA SELECCIONAR EL ALUMNO"
        Me.lblayuda.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Escudo_de_Juan_Pablo_II
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(27, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(66, 77)
        Me.PictureBox3.TabIndex = 377
        Me.PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(620, 463)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 381
        Me.Label5.Text = "SALIR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label4.Location = New System.Drawing.Point(457, 463)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 380
        Me.Label4.Text = "ELIMINAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(381, 463)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 379
        Me.Label3.Text = "EDITAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label2.Location = New System.Drawing.Point(297, 463)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 378
        Me.Label2.Text = "NUEVO"
        '
        'frmtutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.depositphotos_38740641_stock_photo_white_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 489)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblayuda)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.cbxbusqueda)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.inexistente)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnbaja)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.datalistado)
        Me.Name = "frmtutor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutor"
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label32 As System.Windows.Forms.Label
    Private WithEvents cbxbusqueda As System.Windows.Forms.ComboBox
    Private WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Private WithEvents btncerrar As System.Windows.Forms.Button
    Private WithEvents btnbaja As System.Windows.Forms.Button
    Private WithEvents btneditar As System.Windows.Forms.Button
    Private WithEvents btnnuevo As System.Windows.Forms.Button
    Private WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents lblayuda As System.Windows.Forms.Label
    Private WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
