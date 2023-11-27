<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transporte
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dgvTransporte = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPlaca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCapacidad = New System.Windows.Forms.TextBox()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.dgvTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(7, 33)
        IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(24, 13)
        IDLabel.TabIndex = 154
        IDLabel.Text = "ID:"
        '
        'BtnActualir
        '
        Me.BtnActualir.Location = New System.Drawing.Point(310, 28)
        Me.BtnActualir.Name = "BtnActualir"
        Me.BtnActualir.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualir.TabIndex = 158
        Me.BtnActualir.Text = "Actualizar"
        Me.BtnActualir.UseVisualStyleBackColor = True
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(234, 28)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMostrar.TabIndex = 157
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(158, 28)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 156
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(63, 33)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(78, 20)
        Me.IDTextBox.TabIndex = 155
        '
        'LBcategoria
        '
        Me.LBcategoria.AutoSize = True
        Me.LBcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBcategoria.Location = New System.Drawing.Point(7, 67)
        Me.LBcategoria.Name = "LBcategoria"
        Me.LBcategoria.Size = New System.Drawing.Size(50, 13)
        Me.LBcategoria.TabIndex = 153
        Me.LBcategoria.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(63, 64)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(114, 20)
        Me.txtNombre.TabIndex = 152
        '
        'dgvTransporte
        '
        Me.dgvTransporte.AllowUserToAddRows = False
        Me.dgvTransporte.AllowUserToDeleteRows = False
        Me.dgvTransporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransporte.Location = New System.Drawing.Point(12, 120)
        Me.dgvTransporte.Name = "dgvTransporte"
        Me.dgvTransporte.ReadOnly = True
        Me.dgvTransporte.Size = New System.Drawing.Size(475, 246)
        Me.dgvTransporte.TabIndex = 151
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "tipo"
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(63, 91)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(97, 20)
        Me.TxtTipo.TabIndex = 159
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "numero de placa"
        '
        'TxtPlaca
        '
        Me.TxtPlaca.Location = New System.Drawing.Point(283, 95)
        Me.TxtPlaca.Name = "TxtPlaca"
        Me.TxtPlaca.Size = New System.Drawing.Size(97, 20)
        Me.TxtPlaca.TabIndex = 161
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "capacidad"
        '
        'TxtCapacidad
        '
        Me.TxtCapacidad.Location = New System.Drawing.Point(283, 69)
        Me.TxtCapacidad.Name = "TxtCapacidad"
        Me.TxtCapacidad.Size = New System.Drawing.Size(97, 20)
        Me.TxtCapacidad.TabIndex = 163
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(391, 28)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBorrar.TabIndex = 165
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnMenu.Location = New System.Drawing.Point(0, -2)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(43, 23)
        Me.BtnMenu.TabIndex = 188
        Me.BtnMenu.Text = "Menu"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'Transporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 386)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCapacidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPlaca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTipo)
        Me.Controls.Add(Me.BtnActualir)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.LBcategoria)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.dgvTransporte)
        Me.Name = "Transporte"
        Me.Text = "Transporte"
        CType(Me.dgvTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnActualir As Button
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents LBcategoria As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents dgvTransporte As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPlaca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCapacidad As TextBox
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnMenu As Button
End Class
