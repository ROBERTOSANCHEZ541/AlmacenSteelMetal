<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
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
        Dim LBFecha As System.Windows.Forms.Label
        Me.txtFechaPedido = New System.Windows.Forms.TextBox()
        Me.lbIDClient = New System.Windows.Forms.Label()
        Me.txtClienteID = New System.Windows.Forms.TextBox()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIDPedido = New System.Windows.Forms.TextBox()
        Me.CBNombreC = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        LBFecha = New System.Windows.Forms.Label()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBFecha
        '
        LBFecha.AutoSize = True
        LBFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LBFecha.Location = New System.Drawing.Point(47, 9)
        LBFecha.Name = "LBFecha"
        LBFecha.Size = New System.Drawing.Size(42, 13)
        LBFecha.TabIndex = 171
        LBFecha.Text = "Fecha"
        '
        'txtFechaPedido
        '
        Me.txtFechaPedido.Enabled = False
        Me.txtFechaPedido.Location = New System.Drawing.Point(92, 5)
        Me.txtFechaPedido.Name = "txtFechaPedido"
        Me.txtFechaPedido.Size = New System.Drawing.Size(200, 20)
        Me.txtFechaPedido.TabIndex = 172
        '
        'lbIDClient
        '
        Me.lbIDClient.AutoSize = True
        Me.lbIDClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIDClient.Location = New System.Drawing.Point(26, 47)
        Me.lbIDClient.Name = "lbIDClient"
        Me.lbIDClient.Size = New System.Drawing.Size(63, 13)
        Me.lbIDClient.TabIndex = 168
        Me.lbIDClient.Text = "ID Cliente"
        '
        'txtClienteID
        '
        Me.txtClienteID.Location = New System.Drawing.Point(92, 54)
        Me.txtClienteID.Name = "txtClienteID"
        Me.txtClienteID.Size = New System.Drawing.Size(79, 20)
        Me.txtClienteID.TabIndex = 167
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowUserToAddRows = False
        Me.dgvPedidos.AllowUserToDeleteRows = False
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Location = New System.Drawing.Point(12, 102)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.ReadOnly = True
        Me.dgvPedidos.Size = New System.Drawing.Size(397, 331)
        Me.dgvPedidos.TabIndex = 176
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(299, 47)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMostrar.TabIndex = 183
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(298, 18)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 182
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnMenu.Location = New System.Drawing.Point(-2, -1)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(43, 23)
        Me.BtnMenu.TabIndex = 184
        Me.BtnMenu.Text = "Menu"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "IDPedido"
        '
        'TxtIDPedido
        '
        Me.TxtIDPedido.Location = New System.Drawing.Point(94, 79)
        Me.TxtIDPedido.Name = "TxtIDPedido"
        Me.TxtIDPedido.Size = New System.Drawing.Size(67, 20)
        Me.TxtIDPedido.TabIndex = 198
        '
        'CBNombreC
        '
        Me.CBNombreC.FormattingEnabled = True
        Me.CBNombreC.Location = New System.Drawing.Point(92, 28)
        Me.CBNombreC.Name = "CBNombreC"
        Me.CBNombreC.Size = New System.Drawing.Size(121, 21)
        Me.CBNombreC.TabIndex = 230
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 229
        Me.Label3.Text = "Nombre"
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 450)
        Me.Controls.Add(Me.CBNombreC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtIDPedido)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.dgvPedidos)
        Me.Controls.Add(LBFecha)
        Me.Controls.Add(Me.txtFechaPedido)
        Me.Controls.Add(Me.lbIDClient)
        Me.Controls.Add(Me.txtClienteID)
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFechaPedido As TextBox
    Friend WithEvents lbIDClient As Label
    Friend WithEvents txtClienteID As TextBox
    Friend WithEvents dgvPedidos As DataGridView
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnMenu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIDPedido As TextBox
    Friend WithEvents CBNombreC As ComboBox
    Friend WithEvents Label3 As Label
End Class
