<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sucursales
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
        Dim IDLabel As System.Windows.Forms.Label
        Me.BtnActualir = New System.Windows.Forms.Button()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.LBcategoria = New System.Windows.Forms.Label()
        Me.TxtSucursal = New System.Windows.Forms.TextBox()
        Me.dgvSucursales = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnMenu = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(42, 51)
        IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(24, 13)
        IDLabel.TabIndex = 154
        IDLabel.Text = "ID:"
        '
        'BtnActualir
        '
        Me.BtnActualir.Location = New System.Drawing.Point(325, 21)
        Me.BtnActualir.Name = "BtnActualir"
        Me.BtnActualir.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualir.TabIndex = 158
        Me.BtnActualir.Text = "Actualizar"
        Me.BtnActualir.UseVisualStyleBackColor = True
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(249, 21)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMostrar.TabIndex = 157
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(173, 21)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 156
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(105, 51)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(78, 20)
        Me.IDTextBox.TabIndex = 155
        '
        'LBcategoria
        '
        Me.LBcategoria.AutoSize = True
        Me.LBcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBcategoria.Location = New System.Drawing.Point(16, 79)
        Me.LBcategoria.Name = "LBcategoria"
        Me.LBcategoria.Size = New System.Drawing.Size(50, 13)
        Me.LBcategoria.TabIndex = 153
        Me.LBcategoria.Text = "Nombre"
        '
        'TxtSucursal
        '
        Me.TxtSucursal.Location = New System.Drawing.Point(105, 76)
        Me.TxtSucursal.Name = "TxtSucursal"
        Me.TxtSucursal.Size = New System.Drawing.Size(257, 20)
        Me.TxtSucursal.TabIndex = 152
        '
        'dgvSucursales
        '
        Me.dgvSucursales.AllowUserToAddRows = False
        Me.dgvSucursales.AllowUserToDeleteRows = False
        Me.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSucursales.Location = New System.Drawing.Point(368, 60)
        Me.dgvSucursales.Name = "dgvSucursales"
        Me.dgvSucursales.ReadOnly = True
        Me.dgvSucursales.Size = New System.Drawing.Size(338, 269)
        Me.dgvSucursales.TabIndex = 151
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 168
        Me.Label3.Text = "ciudad"
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Location = New System.Drawing.Point(105, 102)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(249, 20)
        Me.TxtCiudad.TabIndex = 167
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "codigo postal"
        '
        'txtCp
        '
        Me.txtCp.Location = New System.Drawing.Point(105, 142)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.Size = New System.Drawing.Size(249, 20)
        Me.txtCp.TabIndex = 165
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 164
        Me.Label6.Text = "Telefono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(103, 178)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(249, 20)
        Me.txtTelefono.TabIndex = 163
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(105, 208)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(249, 65)
        Me.txtDireccion.TabIndex = 160
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "Dirección"
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnMenu.Location = New System.Drawing.Point(3, 1)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(43, 23)
        Me.BtnMenu.TabIndex = 187
        Me.BtnMenu.Text = "Menu"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'Sucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 450)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCiudad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnActualir)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.LBcategoria)
        Me.Controls.Add(Me.TxtSucursal)
        Me.Controls.Add(Me.dgvSucursales)
        Me.Name = "Sucursales"
        Me.Text = "Sucursales"
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnActualir As Button
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents LBcategoria As Label
    Friend WithEvents TxtSucursal As TextBox
    Friend WithEvents dgvSucursales As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnMenu As Button
End Class
