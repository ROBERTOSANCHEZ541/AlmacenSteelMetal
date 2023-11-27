<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetCompra
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
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtIdCompra = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdTransporte = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.dgvDTCompra = New System.Windows.Forms.DataGridView()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CBTransp = New System.Windows.Forms.ComboBox()
        Me.CbProductosN = New System.Windows.Forms.ComboBox()
        Me.CbIdProduct = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtRestante = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvDTCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(47, 11)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(66, 13)
        Label1.TabIndex = 182
        Label1.Text = "IDCompra:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(40, 67)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(20, 13)
        DescriptionLabel.TabIndex = 184
        DescriptionLabel.Text = "ID"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(3, 147)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(44, 13)
        QuantityLabel.TabIndex = 186
        QuantityLabel.Text = "Stock:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(3, 43)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(58, 13)
        Label4.TabIndex = 201
        Label4.Text = "Producto"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(116, 147)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(60, 13)
        Label2.TabIndex = 205
        Label2.Text = "cantidad:"
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnMenu.Location = New System.Drawing.Point(-2, 1)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(43, 23)
        Me.BtnMenu.TabIndex = 153
        Me.BtnMenu.Text = "Menu"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Enabled = False
        Me.TxtPrecio.Location = New System.Drawing.Point(67, 124)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(84, 20)
        Me.TxtPrecio.TabIndex = 189
        '
        'TxtIdCompra
        '
        Me.TxtIdCompra.Location = New System.Drawing.Point(119, 8)
        Me.TxtIdCompra.Name = "TxtIdCompra"
        Me.TxtIdCompra.Size = New System.Drawing.Size(84, 20)
        Me.TxtIdCompra.TabIndex = 183
        '
        'TxtStock
        '
        Me.TxtStock.Enabled = False
        Me.TxtStock.Location = New System.Drawing.Point(3, 163)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(85, 20)
        Me.TxtStock.TabIndex = 187
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(235, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Transporte"
        '
        'txtIdTransporte
        '
        Me.txtIdTransporte.Enabled = False
        Me.txtIdTransporte.Location = New System.Drawing.Point(436, 5)
        Me.txtIdTransporte.Name = "txtIdTransporte"
        Me.txtIdTransporte.Size = New System.Drawing.Size(83, 20)
        Me.txtIdTransporte.TabIndex = 180
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 179
        Me.Label10.Text = "Precio"
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(16, 286)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMostrar.TabIndex = 194
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(15, 257)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 193
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'dgvDTCompra
        '
        Me.dgvDTCompra.AllowUserToAddRows = False
        Me.dgvDTCompra.AllowUserToDeleteRows = False
        Me.dgvDTCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDTCompra.Location = New System.Drawing.Point(194, 46)
        Me.dgvDTCompra.Name = "dgvDTCompra"
        Me.dgvDTCompra.ReadOnly = True
        Me.dgvDTCompra.Size = New System.Drawing.Size(375, 353)
        Me.dgvDTCompra.TabIndex = 195
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(68, 215)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(84, 20)
        Me.TxtTotal.TabIndex = 197
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(66, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 198
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CBTransp
        '
        Me.CBTransp.FormattingEnabled = True
        Me.CBTransp.Location = New System.Drawing.Point(309, 5)
        Me.CBTransp.Name = "CBTransp"
        Me.CBTransp.Size = New System.Drawing.Size(121, 21)
        Me.CBTransp.TabIndex = 199
        '
        'CbProductosN
        '
        Me.CbProductosN.FormattingEnabled = True
        Me.CbProductosN.Location = New System.Drawing.Point(67, 40)
        Me.CbProductosN.Name = "CbProductosN"
        Me.CbProductosN.Size = New System.Drawing.Size(121, 21)
        Me.CbProductosN.TabIndex = 200
        '
        'CbIdProduct
        '
        Me.CbIdProduct.FormattingEnabled = True
        Me.CbIdProduct.Location = New System.Drawing.Point(67, 67)
        Me.CbIdProduct.Name = "CbIdProduct"
        Me.CbIdProduct.Size = New System.Drawing.Size(121, 21)
        Me.CbIdProduct.TabIndex = 202
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 23)
        Me.Button2.TabIndex = 203
        Me.Button2.Text = "Total:"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(119, 163)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(63, 20)
        Me.TxtCantidad.TabIndex = 204
        '
        'TxtRestante
        '
        Me.TxtRestante.Enabled = False
        Me.TxtRestante.Location = New System.Drawing.Point(6, 189)
        Me.TxtRestante.Name = "TxtRestante"
        Me.TxtRestante.Size = New System.Drawing.Size(84, 20)
        Me.TxtRestante.TabIndex = 206
        '
        'DetCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 411)
        Me.Controls.Add(Me.TxtRestante)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CbIdProduct)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.CbProductosN)
        Me.Controls.Add(Me.CBTransp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.dgvDTCompra)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TxtIdCompra)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIdTransporte)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnMenu)
        Me.Name = "DetCompra"
        Me.Text = "DetCompra"
        CType(Me.dgvDTCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMenu As Button
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtIdCompra As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdTransporte As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents dgvDTCompra As DataGridView
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CBTransp As ComboBox
    Friend WithEvents CbProductosN As ComboBox
    Friend WithEvents CbIdProduct As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtRestante As TextBox
End Class
