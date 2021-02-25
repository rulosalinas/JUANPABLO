<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmovimientos
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
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.gbmovimientos = New System.Windows.Forms.GroupBox()
        Me.cbxtipomov = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtidmov = New System.Windows.Forms.TextBox()
        Me.btnbaja = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblnumcaja = New System.Windows.Forms.Label()
        Me.txtflag2 = New System.Windows.Forms.TextBox()
        Me.lblguardar = New System.Windows.Forms.Label()
        Me.btnguardaralta = New System.Windows.Forms.Button()
        Me.lblsalir = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbmovimientos.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Escudo_de_Juan_Pablo_II
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(66, 77)
        Me.PictureBox3.TabIndex = 702
        Me.PictureBox3.TabStop = False
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(603, 7)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(33, 20)
        Me.txtflag.TabIndex = 700
        Me.txtflag.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(117, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 30)
        Me.Label1.TabIndex = 698
        Me.Label1.Text = " MOVIMIENTOS DE CAJA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.BackColor = System.Drawing.SystemColors.Control
        Me.inexistente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inexistente.LinkColor = System.Drawing.Color.Red
        Me.inexistente.Location = New System.Drawing.Point(118, 287)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(244, 20)
        Me.inexistente.TabIndex = 693
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "NO SE ENCONTRARON DATOS"
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncerrar.Location = New System.Drawing.Point(375, 406)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(60, 60)
        Me.btncerrar.TabIndex = 697
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datalistado.BackgroundColor = System.Drawing.SystemColors.Control
        Me.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Location = New System.Drawing.Point(21, 201)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(458, 188)
        Me.datalistado.TabIndex = 692
        '
        'gbmovimientos
        '
        Me.gbmovimientos.Controls.Add(Me.cbxtipomov)
        Me.gbmovimientos.Controls.Add(Me.Label4)
        Me.gbmovimientos.Controls.Add(Me.Label3)
        Me.gbmovimientos.Controls.Add(Me.Label2)
        Me.gbmovimientos.Controls.Add(Me.lblcodigo)
        Me.gbmovimientos.Controls.Add(Me.txtmonto)
        Me.gbmovimientos.Controls.Add(Me.txtdescripcion)
        Me.gbmovimientos.Controls.Add(Me.txtidmov)
        Me.gbmovimientos.Location = New System.Drawing.Point(21, 107)
        Me.gbmovimientos.Name = "gbmovimientos"
        Me.gbmovimientos.Size = New System.Drawing.Size(458, 87)
        Me.gbmovimientos.TabIndex = 703
        Me.gbmovimientos.TabStop = False
        Me.gbmovimientos.Text = "Datos"
        '
        'cbxtipomov
        '
        Me.cbxtipomov.FormattingEnabled = True
        Me.cbxtipomov.Items.AddRange(New Object() {"EGRESO", "INGRESO"})
        Me.cbxtipomov.Location = New System.Drawing.Point(155, 18)
        Me.cbxtipomov.Name = "cbxtipomov"
        Me.cbxtipomov.Size = New System.Drawing.Size(93, 21)
        Me.cbxtipomov.TabIndex = 714
        Me.cbxtipomov.Text = "EGRESO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(274, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Monto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo"
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(6, 22)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblcodigo.TabIndex = 4
        Me.lblcodigo.Text = "Codigo"
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(319, 18)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(114, 20)
        Me.txtmonto.TabIndex = 2
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(82, 48)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(351, 20)
        Me.txtdescripcion.TabIndex = 1
        '
        'txtidmov
        '
        Me.txtidmov.Location = New System.Drawing.Point(52, 18)
        Me.txtidmov.Name = "txtidmov"
        Me.txtidmov.ReadOnly = True
        Me.txtidmov.Size = New System.Drawing.Size(39, 20)
        Me.txtidmov.TabIndex = 0
        '
        'btnbaja
        '
        Me.btnbaja.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.cancelar
        Me.btnbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbaja.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnbaja.Location = New System.Drawing.Point(250, 406)
        Me.btnbaja.Name = "btnbaja"
        Me.btnbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnbaja.TabIndex = 696
        Me.btnbaja.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnbaja.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(425, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 707
        Me.Label14.Text = "N° Caja"
        '
        'lblnumcaja
        '
        Me.lblnumcaja.AutoSize = True
        Me.lblnumcaja.Location = New System.Drawing.Point(441, 76)
        Me.lblnumcaja.Name = "lblnumcaja"
        Me.lblnumcaja.Size = New System.Drawing.Size(13, 13)
        Me.lblnumcaja.TabIndex = 706
        Me.lblnumcaja.Text = "1"
        '
        'txtflag2
        '
        Me.txtflag2.Location = New System.Drawing.Point(462, 3)
        Me.txtflag2.Name = "txtflag2"
        Me.txtflag2.Size = New System.Drawing.Size(27, 20)
        Me.txtflag2.TabIndex = 705
        Me.txtflag2.Text = "0"
        Me.txtflag2.Visible = False
        '
        'lblguardar
        '
        Me.lblguardar.AutoSize = True
        Me.lblguardar.BackColor = System.Drawing.Color.Transparent
        Me.lblguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblguardar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblguardar.Location = New System.Drawing.Point(145, 472)
        Me.lblguardar.Name = "lblguardar"
        Me.lblguardar.Size = New System.Drawing.Size(61, 13)
        Me.lblguardar.TabIndex = 711
        Me.lblguardar.Text = "GUARDAR"
        '
        'btnguardaralta
        '
        Me.btnguardaralta.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaralta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaralta.Location = New System.Drawing.Point(146, 409)
        Me.btnguardaralta.Name = "btnguardaralta"
        Me.btnguardaralta.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaralta.TabIndex = 708
        Me.btnguardaralta.UseVisualStyleBackColor = True
        '
        'lblsalir
        '
        Me.lblsalir.AutoSize = True
        Me.lblsalir.BackColor = System.Drawing.Color.Transparent
        Me.lblsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalir.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblsalir.Location = New System.Drawing.Point(386, 472)
        Me.lblsalir.Name = "lblsalir"
        Me.lblsalir.Size = New System.Drawing.Size(38, 13)
        Me.lblsalir.TabIndex = 712
        Me.lblsalir.Text = "SALIR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(252, 472)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 713
        Me.Label5.Text = "ELIMINAR"
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'frmmovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.depositphotos_38740641_stock_photo_white_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(499, 494)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblsalir)
        Me.Controls.Add(Me.lblguardar)
        Me.Controls.Add(Me.btnguardaralta)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblnumcaja)
        Me.Controls.Add(Me.txtflag2)
        Me.Controls.Add(Me.gbmovimientos)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inexistente)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnbaja)
        Me.Controls.Add(Me.datalistado)
        Me.Name = "frmmovimientos"
        Me.Text = "frmmovimientos"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbmovimientos.ResumeLayout(False)
        Me.gbmovimientos.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtflag As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents inexistente As LinkLabel
    Private WithEvents btncerrar As Button
    Private WithEvents datalistado As DataGridView
    Friend WithEvents gbmovimientos As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtidmov As TextBox
    Private WithEvents btnbaja As Button
    Public WithEvents Label14 As Label
    Public WithEvents lblnumcaja As Label
    Public WithEvents txtflag2 As TextBox
    Friend WithEvents lblguardar As Label
    Public WithEvents btnguardaralta As Button
    Friend WithEvents lblsalir As Label
    Friend WithEvents cbxtipomov As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents erroricono As ErrorProvider
End Class
