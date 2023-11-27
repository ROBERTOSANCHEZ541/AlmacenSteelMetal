Public Class FrmMenu

    Private Sub ItemPrecios_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ItemClientes_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ItemAsist_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ItemPagos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TransporteToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem1.Click
        Compras.Show()
        Me.Hide()
    End Sub

    Private Sub TransporteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransporteToolStripMenuItem1.Click
        Transporte.Show()
        Me.Hide()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Cliente.Show()
        Me.Hide()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Productos.Show()
        Me.Hide()
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        Sucursales.Show()
        Me.Hide()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Empleados.Show()
        Me.Hide()

    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        Proveedor.Show()
        Me.Hide()
    End Sub

    Private Sub CatalogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoToolStripMenuItem.Click

    End Sub

    Private Sub CategoriasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem1.Click
        Categoria.Show()
        Me.Hide()
    End Sub

    Private Sub PedidosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem1.Click
        Pedidos.Show()
        Me.Hide()
    End Sub

    Private Sub LbUsuario_Click(sender As Object, e As EventArgs) Handles LbUsuario.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim valTxtUsuario As String = Login.VarTtxUser
        LbUsuario.Text = valTxtUsuario
    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Login.Show()
        Me.Close()
        Login.TxtRFC.Clear()
    End Sub

    Private Sub DetallesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DetallesToolStripMenuItem1.Click
        DetCompra.Show()
        Me.Hide()
    End Sub

    Private Sub DetallesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetallesToolStripMenuItem.Click
        DetPedido.Show()
        Me.Hide()
    End Sub
End Class