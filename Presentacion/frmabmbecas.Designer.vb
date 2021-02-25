<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmabmbecas
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
        Me.SuspendLayout()
        '
        'frmabmbecas
        '
        Me.ClientSize = New System.Drawing.Size(558, 372)
        Me.Name = "frmabmbecas"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents PictureBox3 As PictureBox
    Public WithEvents txtidbeca As TextBox
    Public WithEvents label16 As Label
    Public WithEvents txtresolucion As TextBox
    Public WithEvents txtdnialu As TextBox
    Friend WithEvents erroricono As ErrorProvider
    Public WithEvents Label6 As Label
    Public WithEvents lblmbaja As Label
    Public WithEvents lblbaja As Label
    Public WithEvents lblmodificar As Label
    Public WithEvents lblnuevo As Label
    Private WithEvents btncerrar As Button
    Public WithEvents btnguardaralta As Button
    Public WithEvents btnguardaredicion As Button
    Public WithEvents btnguardarbaja As Button
    Public WithEvents txtnombe As TextBox
    Public WithEvents label4 As Label
    Public WithEvents txtmonto As TextBox
    Friend WithEvents lblsalir As Label
    Friend WithEvents lblguardar As Label
    Public WithEvents label17 As Label
    Public WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Public WithEvents dtfinbeca As DateTimePicker
    Public WithEvents dtfinicio As DateTimePicker
    Public WithEvents cbxestado As CheckBox
    Public WithEvents GroupBox1 As GroupBox
    Public WithEvents GroupBox2 As GroupBox
End Class
