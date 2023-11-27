<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Dim DescriptionLabel As System.Windows.Forms.Label
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.dgvCompras = New System.Windows.Forms.DataGridView()
        Me.txtFechaPedido = New System.Windows.Forms.TextBox()
        Me.lbIDClient = New System.Windows.Forms.Label()
        Me.txtProvID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEmpId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIDCompra = New System.Windows.Forms.TextBox()
        Me.CBNombreP = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(67, 14)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(42, 13)
        DescriptionLabel.TabIndex = 187
        DescriptionLabel.Text = "Fecha"
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnMenu.Location = New System.Drawing.Point(12, 12)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(43, 23)
        Me.BtnMenu.TabIndex = 153
        Me.BtnMenu.Text = "Menu"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(354, 78)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMostrar.TabIndex = 191
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(273, 78)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 190
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'dgvCompras
        '
        Me.dgvCompras.AllowUserToAddRows = False
        Me.dgvCompras.AllowUserToDeleteRows = False
        Me.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompras.Location = New System.Drawing.Point(32, 107)
        Me.dgvCompras.Name = "dgvCompras"
        Me.dgvCompras.ReadOnly = True
        Me.dgvCompras.Size = New System.Drawing.Size(397, 331)
        Me.dgvCompras.TabIndex = 189
        '
        'txtFechaPedido
        '
        Me.txtFechaPedido.Enabled = False
        Me.txtFechaPedido.Location = New System.Drawing.Point(112, 10)
        Me.txtFechaPedido.Name = "txtFechaPedido"
        Me.txtFechaPedido.Size = New System.Drawing.Size(80, 20)
        Me.txtFechaPedido.TabIndex = 188
        '
        'lbIDClient
        '
        Me.lbIDClient.AutoSize = True
        Me.lbIDClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIDClient.Location = New System.Drawing.Point(249, 41)
        Me.lbIDClient.Name = "lbIDClient"
        Me.lbIDClient.Size = New System.Drawing.Size(78, 13)
        Me.lbIDClient.TabIndex = 186
        Me.lbIDClient.Text = "ProveedorID"
        '
        'txtProvID
        '
        Me.txtProvID.Location = New System.Drawing.Point(332, 38)
        Me.txtProvID.Name = "txtProvID"
        Me.txtProvID.Size = New System.Drawing.Size(79, 20)
        Me.txtProvID.TabIndex = 185
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 195
        Me.Label2.Text = "EmpleadoID"
        '
        'TxtEmpId
        '
        Me.TxtEmpId.Enabled = False
        Me.TxtEmpId.Location = New System.Drawing.Point(113, 62)
        Me.TxtEmpId.Name = "TxtEmpId"
        Me.TxtEmpId.Size = New System.Drawing.Size(79, 20)
        Me.TxtEmpId.TabIndex = 194
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "IDCompra"
        '
        'TxtIDCompra
        '
        Me.TxtIDCompra.Location = New System.Drawing.Point(367, 10)
        Me.TxtIDCompra.Name = "TxtIDCompra"
        Me.TxtIDCompra.Size = New System.Drawing.Size(67, 20)
        Me.TxtIDCompra.TabIndex = 196
        '
        'CBNombreP
        '
        Me.CBNombreP.FormattingEnabled = True
        Me.CBNombreP.Location = New System.Drawing.Point(125, 38)
        Me.CBNombreP.Name = "CBNombreP"
        Me.CBNombreP.Size = New System.Drawing.Size(121, 21)
        Me.CBNombreP.TabIndex = 232
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 231
        Me.Label3.Text = "Nombre Proveedor:"
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 450)
        Me.Controls.Add(Me.CBNombreP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtIDCompra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtEmpId)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.dgvCompras)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.txtFechaPedido)
        Me.Controls.Add(Me.lbIDClient)
        Me.Controls.Add(Me.txtProvID)
        Me.Controls.Add(Me.BtnMenu)
        Me.Name = "Compras"
        Me.Text = "Compras"
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMenu As Button
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents dgvCompras As DataGridView
    Friend WithEvents txtFechaPedido As TextBox
    Friend WithEvents lbIDClient As Label
    Friend WithEvents txtProvID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEmpId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIDCompra As TextBox
    Friend WithEvents CBNombreP As ComboBox
    Friend WithEvents Label3 As Label
End Class
