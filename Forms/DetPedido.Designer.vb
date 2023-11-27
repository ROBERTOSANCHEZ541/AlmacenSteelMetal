<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetPedido
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.TxtRestante = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CbIdProduct = New System.Windows.Forms.ComboBox()
        Me.CbProductosN = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.dgvDTPedido = New System.Windows.Forms.DataGridView()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBTransp = New System.Windows.Forms.ComboBox()
        Me.TxtIdPedido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdTransporte = New System.Windows.Forms.TextBox()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvDTPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(124, 170)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(60, 13)
        Label2.TabIndex = 222
        Label2.Text = "cantidad:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(11, 66)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(58, 13)
        Label4.TabIndex = 218
        Label4.Text = "Producto"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(48, 90)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(20, 13)
        DescriptionLabel.TabIndex = 208
        DescriptionLabel.Text = "ID"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(11, 170)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(44, 13)
        QuantityLabel.TabIndex = 209
        QuantityLabel.Text = "Stock:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(61, 17)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(61, 13)
        Label1.TabIndex = 226
        Label1.Text = "IdPedido:"
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnMenu.Location = New System.Drawing.Point(12, 12)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(43, 23)
        Me.BtnMenu.TabIndex = 154
        Me.BtnMenu.Text = "Menu"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'TxtRestante
        '
        Me.TxtRestante.Enabled = False
        Me.TxtRestante.Location = New System.Drawing.Point(14, 212)
        Me.TxtRestante.Name = "TxtRestante"
        Me.TxtRestante.Size = New System.Drawing.Size(84, 20)
        Me.TxtRestante.TabIndex = 223
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(127, 186)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(63, 20)
        Me.TxtCantidad.TabIndex = 221
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(20, 238)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 23)
        Me.Button2.TabIndex = 220
        Me.Button2.Text = "Total:"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CbIdProduct
        '
        Me.CbIdProduct.FormattingEnabled = True
        Me.CbIdProduct.Location = New System.Drawing.Point(75, 90)
        Me.CbIdProduct.Name = "CbIdProduct"
        Me.CbIdProduct.Size = New System.Drawing.Size(121, 21)
        Me.CbIdProduct.TabIndex = 219
        '
        'CbProductosN
        '
        Me.CbProductosN.FormattingEnabled = True
        Me.CbProductosN.Location = New System.Drawing.Point(75, 63)
        Me.CbProductosN.Name = "CbProductosN"
        Me.CbProductosN.Size = New System.Drawing.Size(121, 21)
        Me.CbProductosN.TabIndex = 217
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 216
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(76, 238)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(84, 20)
        Me.TxtTotal.TabIndex = 215
        '
        'dgvDTPedido
        '
        Me.dgvDTPedido.AllowUserToAddRows = False
        Me.dgvDTPedido.AllowUserToDeleteRows = False
        Me.dgvDTPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDTPedido.Location = New System.Drawing.Point(202, 69)
        Me.dgvDTPedido.Name = "dgvDTPedido"
        Me.dgvDTPedido.ReadOnly = True
        Me.dgvDTPedido.Size = New System.Drawing.Size(375, 353)
        Me.dgvDTPedido.TabIndex = 214
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(24, 309)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMostrar.TabIndex = 213
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(23, 280)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 212
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Enabled = False
        Me.TxtPrecio.Location = New System.Drawing.Point(75, 147)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(84, 20)
        Me.TxtPrecio.TabIndex = 211
        '
        'TxtStock
        '
        Me.TxtStock.Enabled = False
        Me.TxtStock.Location = New System.Drawing.Point(11, 186)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(85, 20)
        Me.TxtStock.TabIndex = 210
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 207
        Me.Label10.Text = "Precio"
        '
        'CBTransp
        '
        Me.CBTransp.FormattingEnabled = True
        Me.CBTransp.Location = New System.Drawing.Point(323, 11)
        Me.CBTransp.Name = "CBTransp"
        Me.CBTransp.Size = New System.Drawing.Size(121, 21)
        Me.CBTransp.TabIndex = 228
        '
        'TxtIdPedido
        '
        Me.TxtIdPedido.Location = New System.Drawing.Point(133, 14)
        Me.TxtIdPedido.Name = "TxtIdPedido"
        Me.TxtIdPedido.Size = New System.Drawing.Size(84, 20)
        Me.TxtIdPedido.TabIndex = 227
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(249, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 225
        Me.Label3.Text = "Transporte"
        '
        'txtIdTransporte
        '
        Me.txtIdTransporte.Enabled = False
        Me.txtIdTransporte.Location = New System.Drawing.Point(450, 11)
        Me.txtIdTransporte.Name = "txtIdTransporte"
        Me.txtIdTransporte.Size = New System.Drawing.Size(83, 20)
        Me.txtIdTransporte.TabIndex = 224
        '
        'DetPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 428)
        Me.Controls.Add(Me.CBTransp)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TxtIdPedido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIdTransporte)
        Me.Controls.Add(Me.TxtRestante)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CbIdProduct)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.CbProductosN)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.dgvDTPedido)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnMenu)
        Me.Name = "DetPedido"
        Me.Text = "DetPedido"
        CType(Me.dgvDTPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMenu As Button
    Friend WithEvents TxtRestante As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents CbIdProduct As ComboBox
    Friend WithEvents CbProductosN As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents dgvDTPedido As DataGridView
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CBTransp As ComboBox
    Friend WithEvents TxtIdPedido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdTransporte As TextBox
End Class
