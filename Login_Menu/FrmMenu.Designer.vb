<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuGeneral = New System.Windows.Forms.MenuStrip()
        Me.CatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransporteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.DetallesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetallesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuGeneral.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuGeneral
        '
        Me.MenuGeneral.BackColor = System.Drawing.Color.LightSeaGreen
        Me.MenuGeneral.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuGeneral.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoToolStripMenuItem})
        Me.MenuGeneral.Location = New System.Drawing.Point(0, 0)
        Me.MenuGeneral.Name = "MenuGeneral"
        Me.MenuGeneral.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuGeneral.Size = New System.Drawing.Size(202, 24)
        Me.MenuGeneral.TabIndex = 9
        Me.MenuGeneral.Text = "MenuStrip1"
        '
        'CatalogoToolStripMenuItem
        '
        Me.CatalogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem1, Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.SucursalesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ProveedoresToolStripMenuItem1, Me.CategoriasToolStripMenuItem1, Me.PedidosToolStripMenuItem1, Me.TransporteToolStripMenuItem1})
        Me.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        Me.CatalogoToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.CatalogoToolStripMenuItem.Text = "Catalogo:"
        '
        'ComprasToolStripMenuItem1
        '
        Me.ComprasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetallesToolStripMenuItem1})
        Me.ComprasToolStripMenuItem1.Name = "ComprasToolStripMenuItem1"
        Me.ComprasToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ComprasToolStripMenuItem1.Text = "Compras"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'SucursalesToolStripMenuItem
        '
        Me.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem"
        Me.SucursalesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SucursalesToolStripMenuItem.Text = "Sucursales"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'CategoriasToolStripMenuItem1
        '
        Me.CategoriasToolStripMenuItem1.Name = "CategoriasToolStripMenuItem1"
        Me.CategoriasToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.CategoriasToolStripMenuItem1.Text = "Categorias"
        '
        'PedidosToolStripMenuItem1
        '
        Me.PedidosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetallesToolStripMenuItem})
        Me.PedidosToolStripMenuItem1.Name = "PedidosToolStripMenuItem1"
        Me.PedidosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.PedidosToolStripMenuItem1.Text = "Pedidos"
        '
        'TransporteToolStripMenuItem1
        '
        Me.TransporteToolStripMenuItem1.Name = "TransporteToolStripMenuItem1"
        Me.TransporteToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.TransporteToolStripMenuItem1.Text = "Transporte"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.LbUsuario)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(364, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(145, 54)
        Me.Panel1.TabIndex = 10
        '
        'LbUsuario
        '
        Me.LbUsuario.AutoSize = True
        Me.LbUsuario.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUsuario.Location = New System.Drawing.Point(3, 31)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(0, 20)
        Me.LbUsuario.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Usuario:"
        '
        'Btnclose
        '
        Me.Btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btnclose.Location = New System.Drawing.Point(427, 263)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(82, 36)
        Me.Btnclose.TabIndex = 17
        Me.Btnclose.Text = "Cerrar Sesion"
        Me.Btnclose.UseVisualStyleBackColor = False
        '
        'DetallesToolStripMenuItem
        '
        Me.DetallesToolStripMenuItem.Name = "DetallesToolStripMenuItem"
        Me.DetallesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DetallesToolStripMenuItem.Text = "Detalles"
        '
        'DetallesToolStripMenuItem1
        '
        Me.DetallesToolStripMenuItem1.Name = "DetallesToolStripMenuItem1"
        Me.DetallesToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DetallesToolStripMenuItem1.Text = "Detalles"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(510, 302)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuGeneral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMenu"
        Me.Text = "FrmMenu"
        Me.MenuGeneral.ResumeLayout(False)
        Me.MenuGeneral.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuGeneral As MenuStrip
    Friend WithEvents CatalogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SucursalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TransporteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LbUsuario As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btnclose As Button
    Friend WithEvents DetallesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetallesToolStripMenuItem1 As ToolStripMenuItem
End Class
