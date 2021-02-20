<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmabmpagos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcurso = New System.Windows.Forms.TextBox()
        Me.label35 = New System.Windows.Forms.Label()
        Me.txtdivision = New System.Windows.Forms.TextBox()
        Me.txtnivel = New System.Windows.Forms.TextBox()
        Me.label37 = New System.Windows.Forms.Label()
        Me.label45 = New System.Windows.Forms.Label()
        Me.txtidpago = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtiddetalle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblnuevo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxformapago = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxtipocomprobante = New System.Windows.Forms.ComboBox()
        Me.txtprecioarancel = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnombrearancel = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtidarancel = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtrecargo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtflag2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtidalumno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnagregaralumno = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcantidad = New System.Windows.Forms.NumericUpDown()
        Me.btnagregaritem = New System.Windows.Forms.Button()
        Me.btnagregararancel = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnmarzo = New System.Windows.Forms.Button()
        Me.btnabril = New System.Windows.Forms.Button()
        Me.btnmayo = New System.Windows.Forms.Button()
        Me.btnjunio = New System.Windows.Forms.Button()
        Me.btnjulio = New System.Windows.Forms.Button()
        Me.btnagosto = New System.Windows.Forms.Button()
        Me.btnseptiembre = New System.Windows.Forms.Button()
        Me.btnoctubre = New System.Windows.Forms.Button()
        Me.btnnoviembre = New System.Windows.Forms.Button()
        Me.btndiciembre = New System.Windows.Forms.Button()
        Me.lblsalir = New System.Windows.Forms.Label()
        Me.lblguardar = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btningreso = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnguardaralta = New System.Windows.Forms.Button()
        Me.btnguardaredicion = New System.Windows.Forms.Button()
        Me.btnguardarbaja = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lblcomprobante = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblnumcaja = New System.Windows.Forms.Label()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdni
        '
        Me.txtdni.Enabled = False
        Me.txtdni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdni.Location = New System.Drawing.Point(145, 76)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.ReadOnly = True
        Me.txtdni.Size = New System.Drawing.Size(92, 20)
        Me.txtdni.TabIndex = 339
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(105, 80)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(35, 13)
        Me.Label43.TabIndex = 338
        Me.Label43.Text = "D.N.I."
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(296, 76)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(262, 20)
        Me.txtnombre.TabIndex = 336
        '
        'txtcurso
        '
        Me.txtcurso.Enabled = False
        Me.txtcurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcurso.Location = New System.Drawing.Point(733, 76)
        Me.txtcurso.Name = "txtcurso"
        Me.txtcurso.ReadOnly = True
        Me.txtcurso.Size = New System.Drawing.Size(36, 20)
        Me.txtcurso.TabIndex = 326
        '
        'label35
        '
        Me.label35.AutoSize = True
        Me.label35.Enabled = False
        Me.label35.Location = New System.Drawing.Point(699, 80)
        Me.label35.Name = "label35"
        Me.label35.Size = New System.Drawing.Size(34, 13)
        Me.label35.TabIndex = 325
        Me.label35.Text = "Curso"
        '
        'txtdivision
        '
        Me.txtdivision.Enabled = False
        Me.txtdivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdivision.Location = New System.Drawing.Point(772, 76)
        Me.txtdivision.Name = "txtdivision"
        Me.txtdivision.ReadOnly = True
        Me.txtdivision.Size = New System.Drawing.Size(37, 20)
        Me.txtdivision.TabIndex = 324
        '
        'txtnivel
        '
        Me.txtnivel.Enabled = False
        Me.txtnivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnivel.Location = New System.Drawing.Point(602, 76)
        Me.txtnivel.Name = "txtnivel"
        Me.txtnivel.ReadOnly = True
        Me.txtnivel.Size = New System.Drawing.Size(94, 20)
        Me.txtnivel.TabIndex = 322
        '
        'label37
        '
        Me.label37.AutoSize = True
        Me.label37.Enabled = False
        Me.label37.Location = New System.Drawing.Point(565, 80)
        Me.label37.Name = "label37"
        Me.label37.Size = New System.Drawing.Size(31, 13)
        Me.label37.TabIndex = 321
        Me.label37.Text = "Nivel"
        '
        'label45
        '
        Me.label45.AutoSize = True
        Me.label45.Enabled = False
        Me.label45.Location = New System.Drawing.Point(247, 80)
        Me.label45.Name = "label45"
        Me.label45.Size = New System.Drawing.Size(44, 13)
        Me.label45.TabIndex = 317
        Me.label45.Text = "Nombre"
        '
        'txtidpago
        '
        Me.txtidpago.Enabled = False
        Me.txtidpago.Location = New System.Drawing.Point(54, 27)
        Me.txtidpago.Name = "txtidpago"
        Me.txtidpago.ReadOnly = True
        Me.txtidpago.Size = New System.Drawing.Size(87, 20)
        Me.txtidpago.TabIndex = 346
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 345
        Me.Label2.Text = "N° Pago"
        '
        'txtiddetalle
        '
        Me.txtiddetalle.Location = New System.Drawing.Point(62, 24)
        Me.txtiddetalle.Name = "txtiddetalle"
        Me.txtiddetalle.Size = New System.Drawing.Size(47, 20)
        Me.txtiddetalle.TabIndex = 348
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 347
        Me.Label3.Text = "Id Detalle"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.BackColor = System.Drawing.SystemColors.Control
        Me.inexistente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inexistente.LinkColor = System.Drawing.Color.Red
        Me.inexistente.Location = New System.Drawing.Point(363, 392)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(270, 20)
        Me.inexistente.TabIndex = 392
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "NO SE AGREGARON ELEMENTOS"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.BackgroundColor = System.Drawing.SystemColors.Control
        Me.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado.DefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado.Location = New System.Drawing.Point(129, 314)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(759, 172)
        Me.datalistado.TabIndex = 391
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'lblnuevo
        '
        Me.lblnuevo.AutoSize = True
        Me.lblnuevo.BackColor = System.Drawing.Color.Transparent
        Me.lblnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnuevo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblnuevo.Location = New System.Drawing.Point(421, 31)
        Me.lblnuevo.Name = "lblnuevo"
        Me.lblnuevo.Size = New System.Drawing.Size(66, 20)
        Me.lblnuevo.TabIndex = 426
        Me.lblnuevo.Text = "PAGOS"
        Me.lblnuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(322, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 633
        Me.Label5.Text = "Forma Pago"
        '
        'cbxformapago
        '
        Me.cbxformapago.FormattingEnabled = True
        Me.cbxformapago.Items.AddRange(New Object() {"CONTADO", "TARJETA"})
        Me.cbxformapago.Location = New System.Drawing.Point(389, 27)
        Me.cbxformapago.Name = "cbxformapago"
        Me.cbxformapago.Size = New System.Drawing.Size(85, 21)
        Me.cbxformapago.TabIndex = 637
        Me.cbxformapago.Text = "CONTADO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(170, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 639
        Me.Label9.Text = "Tipo"
        '
        'cbxtipocomprobante
        '
        Me.cbxtipocomprobante.FormattingEnabled = True
        Me.cbxtipocomprobante.Items.AddRange(New Object() {"RECIBO", "FACTURA"})
        Me.cbxtipocomprobante.Location = New System.Drawing.Point(204, 27)
        Me.cbxtipocomprobante.Name = "cbxtipocomprobante"
        Me.cbxtipocomprobante.Size = New System.Drawing.Size(78, 21)
        Me.cbxtipocomprobante.TabIndex = 640
        Me.cbxtipocomprobante.Text = "RECIBO"
        '
        'txtprecioarancel
        '
        Me.txtprecioarancel.Location = New System.Drawing.Point(425, 24)
        Me.txtprecioarancel.Name = "txtprecioarancel"
        Me.txtprecioarancel.Size = New System.Drawing.Size(63, 20)
        Me.txtprecioarancel.TabIndex = 642
        Me.txtprecioarancel.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(383, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 641
        Me.Label10.Text = "Precio"
        '
        'txtnombrearancel
        '
        Me.txtnombrearancel.Location = New System.Drawing.Point(192, 24)
        Me.txtnombrearancel.Name = "txtnombrearancel"
        Me.txtnombrearancel.Size = New System.Drawing.Size(185, 20)
        Me.txtnombrearancel.TabIndex = 644
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(113, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 643
        Me.Label11.Text = "Nombre"
        '
        'txtidarancel
        '
        Me.txtidarancel.Location = New System.Drawing.Point(163, 24)
        Me.txtidarancel.Name = "txtidarancel"
        Me.txtidarancel.Size = New System.Drawing.Size(25, 20)
        Me.txtidarancel.TabIndex = 645
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(713, 24)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(39, 20)
        Me.txtdescuento.TabIndex = 650
        Me.txtdescuento.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(544, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 648
        Me.Label12.Text = "Recargo"
        '
        'txtrecargo
        '
        Me.txtrecargo.Location = New System.Drawing.Point(593, 24)
        Me.txtrecargo.Name = "txtrecargo"
        Me.txtrecargo.Size = New System.Drawing.Size(55, 20)
        Me.txtrecargo.TabIndex = 647
        Me.txtrecargo.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(650, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 646
        Me.Label13.Text = "Descuento"
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(765, 493)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(123, 29)
        Me.txttotal.TabIndex = 659
        Me.txttotal.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(712, 500)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 20)
        Me.Label17.TabIndex = 661
        Me.Label17.Text = "Total"
        '
        'txtflag2
        '
        Me.txtflag2.Location = New System.Drawing.Point(837, 12)
        Me.txtflag2.Name = "txtflag2"
        Me.txtflag2.Size = New System.Drawing.Size(27, 20)
        Me.txtflag2.TabIndex = 662
        Me.txtflag2.Text = "0"
        Me.txtflag2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.txtidalumno)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbxtipocomprobante)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbxformapago)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtidpago)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtcurso)
        Me.GroupBox1.Controls.Add(Me.label35)
        Me.GroupBox1.Controls.Add(Me.txtdivision)
        Me.GroupBox1.Controls.Add(Me.txtnivel)
        Me.GroupBox1.Controls.Add(Me.label37)
        Me.GroupBox1.Controls.Add(Me.btnagregaralumno)
        Me.GroupBox1.Controls.Add(Me.label45)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(869, 110)
        Me.GroupBox1.TabIndex = 664
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Pago"
        '
        'txtidalumno
        '
        Me.txtidalumno.Enabled = False
        Me.txtidalumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidalumno.Location = New System.Drawing.Point(54, 76)
        Me.txtidalumno.Name = "txtidalumno"
        Me.txtidalumno.ReadOnly = True
        Me.txtidalumno.Size = New System.Drawing.Size(38, 20)
        Me.txtidalumno.TabIndex = 642
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 641
        Me.Label7.Text = "Legajo"
        '
        'btnagregaralumno
        '
        Me.btnagregaralumno.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.buscar
        Me.btnagregaralumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnagregaralumno.Location = New System.Drawing.Point(824, 68)
        Me.btnagregaralumno.Name = "btnagregaralumno"
        Me.btnagregaralumno.Size = New System.Drawing.Size(39, 36)
        Me.btnagregaralumno.TabIndex = 430
        Me.btnagregaralumno.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Controls.Add(Me.btnagregaritem)
        Me.GroupBox2.Controls.Add(Me.txtdescuento)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtidarancel)
        Me.GroupBox2.Controls.Add(Me.txtnombrearancel)
        Me.GroupBox2.Controls.Add(Me.txtrecargo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtprecioarancel)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtiddetalle)
        Me.GroupBox2.Controls.Add(Me.btnagregararancel)
        Me.GroupBox2.Controls.Add(Me.btnquitar)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(869, 53)
        Me.GroupBox2.TabIndex = 666
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(496, 24)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(40, 20)
        Me.txtcantidad.TabIndex = 665
        Me.txtcantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnagregaritem
        '
        Me.btnagregaritem.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.buscar
        Me.btnagregaritem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnagregaritem.Location = New System.Drawing.Point(824, 12)
        Me.btnagregaritem.Name = "btnagregaritem"
        Me.btnagregaritem.Size = New System.Drawing.Size(39, 38)
        Me.btnagregaritem.TabIndex = 664
        Me.btnagregaritem.UseVisualStyleBackColor = True
        '
        'btnagregararancel
        '
        Me.btnagregararancel.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.btnAgregar1
        Me.btnagregararancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnagregararancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnagregararancel.Location = New System.Drawing.Point(758, 22)
        Me.btnagregararancel.Name = "btnagregararancel"
        Me.btnagregararancel.Size = New System.Drawing.Size(27, 25)
        Me.btnagregararancel.TabIndex = 651
        Me.btnagregararancel.UseVisualStyleBackColor = True
        '
        'btnquitar
        '
        Me.btnquitar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.btnquitar
        Me.btnquitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnquitar.Location = New System.Drawing.Point(790, 22)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(27, 25)
        Me.btnquitar.TabIndex = 663
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.BackColor = System.Drawing.Color.Transparent
        Me.lblhora.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblhora.Location = New System.Drawing.Point(110, 81)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(35, 16)
        Me.lblhora.TabIndex = 668
        Me.lblhora.Text = "Hora"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblfecha.Location = New System.Drawing.Point(12, 81)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(44, 16)
        Me.lblfecha.TabIndex = 667
        Me.lblfecha.Text = "Fecha"
        '
        'Timer1
        '
        '
        'btnmarzo
        '
        Me.btnmarzo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmarzo.Location = New System.Drawing.Point(129, 287)
        Me.btnmarzo.Name = "btnmarzo"
        Me.btnmarzo.Size = New System.Drawing.Size(76, 21)
        Me.btnmarzo.TabIndex = 670
        Me.btnmarzo.Text = "Marzo"
        Me.btnmarzo.UseVisualStyleBackColor = True
        '
        'btnabril
        '
        Me.btnabril.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnabril.Location = New System.Drawing.Point(205, 287)
        Me.btnabril.Name = "btnabril"
        Me.btnabril.Size = New System.Drawing.Size(76, 21)
        Me.btnabril.TabIndex = 671
        Me.btnabril.Text = "Abril"
        Me.btnabril.UseVisualStyleBackColor = True
        '
        'btnmayo
        '
        Me.btnmayo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmayo.Location = New System.Drawing.Point(281, 287)
        Me.btnmayo.Name = "btnmayo"
        Me.btnmayo.Size = New System.Drawing.Size(76, 21)
        Me.btnmayo.TabIndex = 672
        Me.btnmayo.Text = "Mayo"
        Me.btnmayo.UseVisualStyleBackColor = True
        '
        'btnjunio
        '
        Me.btnjunio.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjunio.Location = New System.Drawing.Point(357, 287)
        Me.btnjunio.Name = "btnjunio"
        Me.btnjunio.Size = New System.Drawing.Size(76, 21)
        Me.btnjunio.TabIndex = 673
        Me.btnjunio.Text = "Junio"
        Me.btnjunio.UseVisualStyleBackColor = True
        '
        'btnjulio
        '
        Me.btnjulio.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjulio.Location = New System.Drawing.Point(433, 287)
        Me.btnjulio.Name = "btnjulio"
        Me.btnjulio.Size = New System.Drawing.Size(76, 21)
        Me.btnjulio.TabIndex = 674
        Me.btnjulio.Text = "Julio"
        Me.btnjulio.UseVisualStyleBackColor = True
        '
        'btnagosto
        '
        Me.btnagosto.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagosto.Location = New System.Drawing.Point(509, 287)
        Me.btnagosto.Name = "btnagosto"
        Me.btnagosto.Size = New System.Drawing.Size(76, 21)
        Me.btnagosto.TabIndex = 675
        Me.btnagosto.Text = "Agosto"
        Me.btnagosto.UseVisualStyleBackColor = True
        '
        'btnseptiembre
        '
        Me.btnseptiembre.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnseptiembre.Location = New System.Drawing.Point(585, 287)
        Me.btnseptiembre.Name = "btnseptiembre"
        Me.btnseptiembre.Size = New System.Drawing.Size(76, 21)
        Me.btnseptiembre.TabIndex = 676
        Me.btnseptiembre.Text = "Septiembre"
        Me.btnseptiembre.UseVisualStyleBackColor = True
        '
        'btnoctubre
        '
        Me.btnoctubre.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnoctubre.Location = New System.Drawing.Point(661, 287)
        Me.btnoctubre.Name = "btnoctubre"
        Me.btnoctubre.Size = New System.Drawing.Size(76, 21)
        Me.btnoctubre.TabIndex = 677
        Me.btnoctubre.Text = "Octubre"
        Me.btnoctubre.UseVisualStyleBackColor = True
        '
        'btnnoviembre
        '
        Me.btnnoviembre.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnoviembre.Location = New System.Drawing.Point(737, 287)
        Me.btnnoviembre.Name = "btnnoviembre"
        Me.btnnoviembre.Size = New System.Drawing.Size(76, 21)
        Me.btnnoviembre.TabIndex = 678
        Me.btnnoviembre.Text = "Noviembre"
        Me.btnnoviembre.UseVisualStyleBackColor = True
        '
        'btndiciembre
        '
        Me.btndiciembre.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndiciembre.Location = New System.Drawing.Point(813, 287)
        Me.btndiciembre.Name = "btndiciembre"
        Me.btndiciembre.Size = New System.Drawing.Size(76, 21)
        Me.btndiciembre.TabIndex = 679
        Me.btndiciembre.Text = "Diciembre"
        Me.btndiciembre.UseVisualStyleBackColor = True
        '
        'lblsalir
        '
        Me.lblsalir.AutoSize = True
        Me.lblsalir.BackColor = System.Drawing.Color.Transparent
        Me.lblsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalir.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblsalir.Location = New System.Drawing.Point(816, 605)
        Me.lblsalir.Name = "lblsalir"
        Me.lblsalir.Size = New System.Drawing.Size(38, 13)
        Me.lblsalir.TabIndex = 685
        Me.lblsalir.Text = "SALIR"
        '
        'lblguardar
        '
        Me.lblguardar.AutoSize = True
        Me.lblguardar.BackColor = System.Drawing.Color.Transparent
        Me.lblguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblguardar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblguardar.Location = New System.Drawing.Point(484, 605)
        Me.lblguardar.Name = "lblguardar"
        Me.lblguardar.Size = New System.Drawing.Size(61, 13)
        Me.lblguardar.TabIndex = 684
        Me.lblguardar.Text = "GUARDAR"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button1.Location = New System.Drawing.Point(19, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 48)
        Me.Button1.TabIndex = 686
        Me.Button1.Text = "Consultar Pagos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button2.Location = New System.Drawing.Point(19, 377)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 48)
        Me.Button2.TabIndex = 687
        Me.Button2.Text = "Consultar Caja"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(733, 605)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 697
        Me.Label1.Text = "IMPRIMIR"
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.cajao
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Location = New System.Drawing.Point(231, 539)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(60, 60)
        Me.Button8.TabIndex = 699
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btningreso
        '
        Me.btningreso.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.cajai
        Me.btningreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btningreso.Location = New System.Drawing.Point(158, 539)
        Me.btningreso.Name = "btningreso"
        Me.btningreso.Size = New System.Drawing.Size(60, 60)
        Me.btningreso.TabIndex = 698
        Me.btningreso.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Printer
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(731, 539)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(60, 60)
        Me.Button6.TabIndex = 696
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Escudo_de_Juan_Pablo_II
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(25, 1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(66, 77)
        Me.PictureBox3.TabIndex = 689
        Me.PictureBox3.TabStop = False
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncerrar.Location = New System.Drawing.Point(805, 539)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(60, 60)
        Me.btncerrar.TabIndex = 681
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnguardaralta
        '
        Me.btnguardaralta.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaralta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaralta.Location = New System.Drawing.Point(484, 539)
        Me.btnguardaralta.Name = "btnguardaralta"
        Me.btnguardaralta.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaralta.TabIndex = 680
        Me.btnguardaralta.UseVisualStyleBackColor = True
        '
        'btnguardaredicion
        '
        Me.btnguardaredicion.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaredicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaredicion.Location = New System.Drawing.Point(484, 539)
        Me.btnguardaredicion.Name = "btnguardaredicion"
        Me.btnguardaredicion.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaredicion.TabIndex = 683
        Me.btnguardaredicion.UseVisualStyleBackColor = True
        Me.btnguardaredicion.Visible = False
        '
        'btnguardarbaja
        '
        Me.btnguardarbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardarbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardarbaja.Location = New System.Drawing.Point(484, 539)
        Me.btnguardarbaja.Name = "btnguardarbaja"
        Me.btnguardarbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnguardarbaja.TabIndex = 682
        Me.btnguardarbaja.UseVisualStyleBackColor = True
        Me.btnguardarbaja.Visible = False
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button3.Location = New System.Drawing.Point(19, 431)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 48)
        Me.Button3.TabIndex = 688
        Me.Button3.Text = "Consultar Deuda"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label4.Location = New System.Drawing.Point(157, 605)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 700
        Me.Label4.Text = "INGRESOS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label6.Location = New System.Drawing.Point(236, 605)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 701
        Me.Label6.Text = "GASTOS"
        '
        'Lblcomprobante
        '
        Me.Lblcomprobante.AutoSize = True
        Me.Lblcomprobante.Location = New System.Drawing.Point(756, 75)
        Me.Lblcomprobante.Name = "Lblcomprobante"
        Me.Lblcomprobante.Size = New System.Drawing.Size(0, 13)
        Me.Lblcomprobante.TabIndex = 664
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(743, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 702
        Me.Label8.Text = "N° Comprobante"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(746, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 704
        Me.Label14.Text = "N° Caja"
        '
        'lblnumcaja
        '
        Me.lblnumcaja.AutoSize = True
        Me.lblnumcaja.Location = New System.Drawing.Point(762, 31)
        Me.lblnumcaja.Name = "lblnumcaja"
        Me.lblnumcaja.Size = New System.Drawing.Size(13, 13)
        Me.lblnumcaja.TabIndex = 703
        Me.lblnumcaja.Text = "1"
        '
        'frmabmpagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.depositphotos_38740641_stock_photo_white_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(900, 626)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblnumcaja)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Lblcomprobante)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btningreso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblsalir)
        Me.Controls.Add(Me.lblguardar)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnguardaralta)
        Me.Controls.Add(Me.btnguardaredicion)
        Me.Controls.Add(Me.btnguardarbaja)
        Me.Controls.Add(Me.btndiciembre)
        Me.Controls.Add(Me.btnnoviembre)
        Me.Controls.Add(Me.btnoctubre)
        Me.Controls.Add(Me.btnseptiembre)
        Me.Controls.Add(Me.btnagosto)
        Me.Controls.Add(Me.btnjulio)
        Me.Controls.Add(Me.btnjunio)
        Me.Controls.Add(Me.btnmayo)
        Me.Controls.Add(Me.btnabril)
        Me.Controls.Add(Me.btnmarzo)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtflag2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.lblnuevo)
        Me.Controls.Add(Me.inexistente)
        Me.Controls.Add(Me.datalistado)
        Me.Name = "frmabmpagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "abmpagos"
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Public WithEvents txtdni As System.Windows.Forms.TextBox
    Public WithEvents Label43 As System.Windows.Forms.Label
    Public WithEvents txtnombre As System.Windows.Forms.TextBox
    Public WithEvents txtcurso As System.Windows.Forms.TextBox
    Public WithEvents label35 As System.Windows.Forms.Label
    Public WithEvents txtdivision As System.Windows.Forms.TextBox
    Public WithEvents txtnivel As System.Windows.Forms.TextBox
    Public WithEvents label37 As System.Windows.Forms.Label
    Public WithEvents label45 As System.Windows.Forms.Label
    Public WithEvents txtidpago As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtiddetalle As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lblnuevo As System.Windows.Forms.Label
    Friend WithEvents btnagregaralumno As System.Windows.Forms.Button
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxformapago As System.Windows.Forms.ComboBox
    Friend WithEvents cbxtipocomprobante As System.Windows.Forms.ComboBox
    Public WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnagregararancel As System.Windows.Forms.Button
    Public WithEvents txtdescuento As System.Windows.Forms.TextBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents txtrecargo As System.Windows.Forms.TextBox
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents txtidarancel As System.Windows.Forms.TextBox
    Public WithEvents txtnombrearancel As System.Windows.Forms.TextBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents txtprecioarancel As System.Windows.Forms.TextBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents datalistado As System.Windows.Forms.DataGridView
    Public WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Public WithEvents txtflag2 As System.Windows.Forms.TextBox
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btndiciembre As System.Windows.Forms.Button
    Friend WithEvents btnnoviembre As System.Windows.Forms.Button
    Friend WithEvents btnoctubre As System.Windows.Forms.Button
    Friend WithEvents btnseptiembre As System.Windows.Forms.Button
    Friend WithEvents btnagosto As System.Windows.Forms.Button
    Friend WithEvents btnjulio As System.Windows.Forms.Button
    Friend WithEvents btnjunio As System.Windows.Forms.Button
    Friend WithEvents btnmayo As System.Windows.Forms.Button
    Friend WithEvents btnabril As System.Windows.Forms.Button
    Friend WithEvents btnmarzo As System.Windows.Forms.Button
    Friend WithEvents lblsalir As Label
    Friend WithEvents lblguardar As Label
    Private WithEvents btncerrar As Button
    Public WithEvents btnguardaralta As Button
    Public WithEvents btnguardaredicion As Button
    Public WithEvents btnguardarbaja As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Private WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Private WithEvents Button6 As Button
    Public WithEvents btningreso As Button
    Public WithEvents Button8 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Public WithEvents txtidalumno As TextBox
    Public WithEvents Label7 As Label
    Public WithEvents Lblcomprobante As Label
    Public WithEvents Label8 As Label
    Friend WithEvents btnagregaritem As Button
    Friend WithEvents txtcantidad As NumericUpDown
    Public WithEvents Label14 As Label
    Public WithEvents lblnumcaja As Label
End Class
