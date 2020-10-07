<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.listar = New System.Windows.Forms.DataGridView()
        Me.month = New System.Windows.Forms.ComboBox()
        Me.btnVerdura = New System.Windows.Forms.Button()
        Me.btnSessionOut = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtSiembra = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.verduras = New System.Windows.Forms.ComboBox()
        Me.txtVerdura = New System.Windows.Forms.TextBox()
        Me.idverduras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.siembra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.listar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listar
        '
        Me.listar.AllowUserToAddRows = False
        Me.listar.AllowUserToDeleteRows = False
        Me.listar.AllowUserToResizeColumns = False
        Me.listar.AllowUserToResizeRows = False
        Me.listar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listar.BackgroundColor = System.Drawing.Color.White
        Me.listar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.listar.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.listar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.listar.ColumnHeadersHeight = 27
        Me.listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.listar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idverduras, Me.nombre, Me.siembra, Me.mes, Me.precio, Me.cantidad, Me.Delete})
        Me.listar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.listar.EnableHeadersVisualStyles = False
        Me.listar.GridColor = System.Drawing.Color.White
        Me.listar.Location = New System.Drawing.Point(12, 283)
        Me.listar.MultiSelect = False
        Me.listar.Name = "listar"
        Me.listar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.listar.RowHeadersVisible = False
        Me.listar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.listar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.listar.ShowEditingIcon = False
        Me.listar.Size = New System.Drawing.Size(866, 273)
        Me.listar.TabIndex = 4
        Me.listar.TabStop = False
        '
        'month
        '
        Me.month.FormattingEnabled = True
        Me.month.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.month.Location = New System.Drawing.Point(9, 66)
        Me.month.Name = "month"
        Me.month.Size = New System.Drawing.Size(136, 21)
        Me.month.TabIndex = 31
        '
        'btnVerdura
        '
        Me.btnVerdura.Location = New System.Drawing.Point(624, 229)
        Me.btnVerdura.Name = "btnVerdura"
        Me.btnVerdura.Size = New System.Drawing.Size(127, 32)
        Me.btnVerdura.TabIndex = 30
        Me.btnVerdura.Text = "Agregar Verdura"
        Me.btnVerdura.UseVisualStyleBackColor = True
        '
        'btnSessionOut
        '
        Me.btnSessionOut.Location = New System.Drawing.Point(757, 229)
        Me.btnSessionOut.Name = "btnSessionOut"
        Me.btnSessionOut.Size = New System.Drawing.Size(118, 32)
        Me.btnSessionOut.TabIndex = 29
        Me.btnSessionOut.Text = "Cerrar Sesion"
        Me.btnSessionOut.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(446, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Simbra"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(446, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cantidad "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Mes de Plantado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Codigo de Verdura"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(449, 66)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(136, 20)
        Me.txtCantidad.TabIndex = 22
        '
        'txtSiembra
        '
        Me.txtSiembra.Location = New System.Drawing.Point(449, 24)
        Me.txtSiembra.Name = "txtSiembra"
        Me.txtSiembra.Size = New System.Drawing.Size(136, 20)
        Me.txtSiembra.TabIndex = 21
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(237, 66)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(136, 20)
        Me.txtPrecio.TabIndex = 20
        '
        'verduras
        '
        Me.verduras.FormattingEnabled = True
        Me.verduras.Items.AddRange(New Object() {"Zanahoria", "Brocoli", "Pimiento", "Cebolla"})
        Me.verduras.Location = New System.Drawing.Point(237, 24)
        Me.verduras.Name = "verduras"
        Me.verduras.Size = New System.Drawing.Size(136, 21)
        Me.verduras.TabIndex = 19
        '
        'txtVerdura
        '
        Me.txtVerdura.Location = New System.Drawing.Point(12, 25)
        Me.txtVerdura.Name = "txtVerdura"
        Me.txtVerdura.Size = New System.Drawing.Size(123, 20)
        Me.txtVerdura.TabIndex = 18
        '
        'idverduras
        '
        Me.idverduras.HeaderText = "Codigo Verdura"
        Me.idverduras.Name = "idverduras"
        Me.idverduras.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'siembra
        '
        Me.siembra.HeaderText = "Siembra"
        Me.siembra.Name = "siembra"
        '
        'mes
        '
        Me.mes.HeaderText = "Mes"
        Me.mes.Name = "mes"
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'Delete
        '
        Me.Delete.HeaderText = "Eliminar"
        Me.Delete.Image = Global.Clase.My.Resources.Resources.descarga1
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 568)
        Me.Controls.Add(Me.month)
        Me.Controls.Add(Me.btnVerdura)
        Me.Controls.Add(Me.btnSessionOut)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtSiembra)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.verduras)
        Me.Controls.Add(Me.txtVerdura)
        Me.Controls.Add(Me.listar)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.listar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listar As DataGridView
    Friend WithEvents month As ComboBox
    Friend WithEvents btnVerdura As Button
    Friend WithEvents btnSessionOut As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtSiembra As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents verduras As ComboBox
    Friend WithEvents txtVerdura As TextBox
    Friend WithEvents idverduras As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents siembra As DataGridViewTextBoxColumn
    Friend WithEvents mes As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewImageColumn
End Class
