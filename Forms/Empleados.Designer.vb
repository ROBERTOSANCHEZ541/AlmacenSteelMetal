<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Dim Label1 As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.BtnActualir = New System.Windows.Forms.Button()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.dgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LBTel = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtNss = New System.Windows.Forms.TextBox()
        Me.LbNss = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.lbEdad = New System.Windows.Forms.Label()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.lbrfc = New System.Windows.Forms.Label()
        Me.txtcurp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPuesto = New System.Windows.Forms.TextBox()
        Me.lbpuesto = New System.Windows.Forms.Label()
        Me.TxtIdSucursal = New System.Windows.Forms.TextBox()
        Me.lbIdSucursal = New System.Windows.Forms.Label()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(168, 63)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(45, 16)
        Label1.TabIndex = 158
        Label1.Text = "Ej:(1204)"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(14, 63)
        IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(24, 13)
        IDLabel.TabIndex = 156
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(66, 63)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(78, 20)
        Me.IDTextBox.TabIndex = 157
        '
        'BtnActualir
        '
        Me.BtnActualir.Location = New System.Drawing.Point(179, 365)
        Me.BtnActualir.Name = "BtnActualir"
        Me.BtnActualir.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualir.TabIndex = 155
        Me.BtnActualir.Text = "Actualizar"
        Me.BtnActualir.UseVisualStyleBackColor = True
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(102, 365)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMostrar.TabIndex = 154
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(21, 365)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 153
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'dgvEmpleado
        '
        Me.dgvEmpleado.AllowUserToAddRows = False
        Me.dgvEmpleado.AllowUserToDeleteRows = False
        Me.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleado.Location = New System.Drawing.Point(376, 80)
        Me.dgvEmpleado.Name = "dgvEmpleado"
        Me.dgvEmpleado.ReadOnly = True
        Me.dgvEmpleado.Size = New System.Drawing.Size(397, 331)
        Me.dgvEmpleado.TabIndex = 152
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(10, 93)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(50, 13)
        Me.lbNombre.TabIndex = 151
        Me.lbNombre.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(66, 90)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(290, 20)
        Me.TxtNombre.TabIndex = 150
        '
        'LBTel
        '
        Me.LBTel.AutoSize = True
        Me.LBTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTel.Location = New System.Drawing.Point(10, 201)
        Me.LBTel.Name = "LBTel"
        Me.LBTel.Size = New System.Drawing.Size(57, 13)
        Me.LBTel.TabIndex = 149
        Me.LBTel.Text = "Telefono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(77, 201)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(249, 20)
        Me.txtTelefono.TabIndex = 148
        '
        'TxtNss
        '
        Me.TxtNss.Location = New System.Drawing.Point(77, 261)
        Me.TxtNss.Name = "TxtNss"
        Me.TxtNss.Size = New System.Drawing.Size(249, 20)
        Me.TxtNss.TabIndex = 147
        '
        'LbNss
        '
        Me.LbNss.AutoSize = True
        Me.LbNss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNss.Location = New System.Drawing.Point(10, 261)
        Me.LbNss.Name = "LbNss"
        Me.LbNss.Size = New System.Drawing.Size(32, 13)
        Me.LbNss.TabIndex = 146
        Me.LbNss.Text = "NSS"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.GeneralToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 159
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(77, 129)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(249, 20)
        Me.TxtEdad.TabIndex = 161
        '
        'lbEdad
        '
        Me.lbEdad.AutoSize = True
        Me.lbEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEdad.Location = New System.Drawing.Point(10, 129)
        Me.lbEdad.Name = "lbEdad"
        Me.lbEdad.Size = New System.Drawing.Size(35, 13)
        Me.lbEdad.TabIndex = 160
        Me.lbEdad.Text = "edad"
        '
        'txtRfc
        '
        Me.txtRfc.Location = New System.Drawing.Point(77, 168)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(249, 20)
        Me.txtRfc.TabIndex = 163
        '
        'lbrfc
        '
        Me.lbrfc.AutoSize = True
        Me.lbrfc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbrfc.Location = New System.Drawing.Point(10, 168)
        Me.lbrfc.Name = "lbrfc"
        Me.lbrfc.Size = New System.Drawing.Size(22, 13)
        Me.lbrfc.TabIndex = 162
        Me.lbrfc.Text = "rfc"
        '
        'txtcurp
        '
        Me.txtcurp.Location = New System.Drawing.Point(77, 235)
        Me.txtcurp.Name = "txtcurp"
        Me.txtcurp.Size = New System.Drawing.Size(249, 20)
        Me.txtcurp.TabIndex = 165
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "curp"
        '
        'TxtPuesto
        '
        Me.TxtPuesto.Location = New System.Drawing.Point(80, 293)
        Me.TxtPuesto.Name = "TxtPuesto"
        Me.TxtPuesto.Size = New System.Drawing.Size(249, 20)
        Me.TxtPuesto.TabIndex = 169
        '
        'lbpuesto
        '
        Me.lbpuesto.AutoSize = True
        Me.lbpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbpuesto.Location = New System.Drawing.Point(13, 293)
        Me.lbpuesto.Name = "lbpuesto"
        Me.lbpuesto.Size = New System.Drawing.Size(45, 13)
        Me.lbpuesto.TabIndex = 168
        Me.lbpuesto.Text = "puesto"
        '
        'TxtIdSucursal
        '
        Me.TxtIdSucursal.Location = New System.Drawing.Point(80, 319)
        Me.TxtIdSucursal.Name = "TxtIdSucursal"
        Me.TxtIdSucursal.Size = New System.Drawing.Size(249, 20)
        Me.TxtIdSucursal.TabIndex = 167
        '
        'lbIdSucursal
        '
        Me.lbIdSucursal.AutoSize = True
        Me.lbIdSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdSucursal.Location = New System.Drawing.Point(9, 322)
        Me.lbIdSucursal.Name = "lbIdSucursal"
        Me.lbIdSucursal.Size = New System.Drawing.Size(69, 13)
        Me.lbIdSucursal.TabIndex = 166
        Me.lbIdSucursal.Text = "IDSucursal"
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(260, 365)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBorrar.TabIndex = 170
        Me.BtnBorrar.Text = "borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnMenu.Location = New System.Drawing.Point(745, 12)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(43, 23)
        Me.BtnMenu.TabIndex = 171
        Me.BtnMenu.Text = "Menu"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.TxtPuesto)
        Me.Controls.Add(Me.lbpuesto)
        Me.Controls.Add(Me.TxtIdSucursal)
        Me.Controls.Add(Me.lbIdSucursal)
        Me.Controls.Add(Me.txtcurp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRfc)
        Me.Controls.Add(Me.lbrfc)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.lbEdad)
        Me.Controls.Add(Label1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.BtnActualir)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.dgvEmpleado)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LBTel)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.TxtNss)
        Me.Controls.Add(Me.LbNss)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents BtnActualir As Button
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents dgvEmpleado As DataGridView
    Friend WithEvents lbNombre As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LBTel As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents TxtNss As TextBox
    Friend WithEvents LbNss As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents lbEdad As Label
    Friend WithEvents txtRfc As TextBox
    Friend WithEvents lbrfc As Label
    Friend WithEvents txtcurp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPuesto As TextBox
    Friend WithEvents lbpuesto As Label
    Friend WithEvents TxtIdSucursal As TextBox
    Friend WithEvents lbIdSucursal As Label
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnMenu As Button
End Class
