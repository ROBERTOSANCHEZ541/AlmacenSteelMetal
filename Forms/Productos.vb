Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Productos
    Dim connectionString As String = "data source=DESKTOP-6ECTDJR\SQLEXPRESS; initial catalog=Almacén; integrated security=SSPI; persist security info = false; trusted_connection= yes ; "
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProductos.Columns.Add("IdArticulo", "IdArticulo")
        dgvProductos.Columns.Add("NombreProducto", "NombreProducto")
        dgvProductos.Columns.Add("Precio", "Precio")
        dgvProductos.Columns.Add("Stock", "Stock")
        dgvProductos.Columns.Add("Descripcion", "Descripcion")
        dgvProductos.Columns.Add("ID_Categoria", "ID_Categoria")
        dgvProductos.Columns.Add("IDSucursal", "IDSucursal")
    End Sub
    Private Sub InsertarProducto()
        Try
            If Not ValidacionTxts() Then
                MessageBox.Show("Faltan campos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using comando As New SqlCommand("InsertarProducto", connection)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@NombreProducto", TxtNombre.Text)
                        comando.Parameters.AddWithValue("@Precio", Decimal.Parse(txtPrecio.Text))
                        comando.Parameters.AddWithValue("@Stock", Integer.Parse(TxtCantidad.Text))
                        comando.Parameters.AddWithValue("@Descripcion", TxtDescrip.Text)
                        comando.Parameters.AddWithValue("@IDCategoria", Integer.Parse(TxtIdCategoria.Text))
                        comando.Parameters.AddWithValue("@IDSucursal", Integer.Parse(TxtIdSuc.Text))
                        comando.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Producto insertado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar insertar el producto. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargarProductos()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using comando As New SqlCommand("ObtenerProductos", connection)
                    comando.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter(comando)
                    Dim tablaProductos As New DataTable()
                    adaptador.Fill(tablaProductos)
                    dgvProductos.DataSource = tablaProductos
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ActualizarProducto()
        Try
            If Not ValidacionTxtID() Then
                MessageBox.Show("Faltan campos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using comando As New SqlCommand("ActualizarProducto", connection)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@IdArticulo", TxtIdProducto.Text)
                        comando.Parameters.AddWithValue("@NombreProducto", TxtNombre.Text)
                        comando.Parameters.AddWithValue("@Precio", Decimal.Parse(txtPrecio.Text))
                        comando.Parameters.AddWithValue("@Stock", Integer.Parse(TxtCantidad.Text))
                        comando.Parameters.AddWithValue("@Descripcion", TxtDescrip.Text)
                        comando.Parameters.AddWithValue("@IDCategoria", Integer.Parse(TxtIdCategoria.Text))
                        comando.Parameters.AddWithValue("@IDSucursal", Integer.Parse(TxtIdSuc.Text))
                        comando.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar actualizar el producto. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function ValidacionTxtID() As Boolean
        Return Not String.IsNullOrWhiteSpace(TxtIdProducto.Text) AndAlso
                Not String.IsNullOrWhiteSpace(txtPrecio.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtCantidad.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtDescrip.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtIdCategoria.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtIdSuc.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtNombre.Text)
    End Function
    Private Function ValidacionTxts() As Boolean
        Return Not String.IsNullOrWhiteSpace(txtPrecio.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtCantidad.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtDescrip.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtIdCategoria.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtIdSuc.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtNombre.Text)
    End Function
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        InsertarProducto()
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        CargarProductos()
    End Sub

    Private Sub BtnActualir_Click(sender As Object, e As EventArgs) Handles BtnActualir.Click
        ActualizarProducto()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub
End Class
