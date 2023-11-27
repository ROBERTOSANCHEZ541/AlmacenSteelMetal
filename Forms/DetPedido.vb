Imports System.Data.SqlClient

Public Class DetPedido
    Dim connectionString As String = "data source=DESKTOP-6ECTDJR\SQLEXPRESS; initial catalog=Almacén; integrated security=SSPI; persist security info = false; trusted_connection= yes ; "

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub DetPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtIdPedido.Text = Pedidos.ultimoID
        LlenarCbProductosN()
        LlenarCTranspN()
    End Sub
    Private Sub LlenarCbProductosN()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT NombreProducto FROM Productos"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim listaProductos As New List(Of String)
                        While reader.Read()
                            Dim nombreProducto As String = reader("NombreProducto").ToString()
                            listaProductos.Add(nombreProducto)
                        End While
                        CbProductosN.DataSource = listaProductos
                    End Using
                    connection.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los nombres de los productos. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LlenarCTranspN()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Nombre FROM Transporte"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim listaTransp As New List(Of String)
                        While reader.Read()
                            Dim nombreTransp As String = reader("Nombre").ToString()
                            listaTransp.Add(nombreTransp)
                        End While
                        CBTransp.DataSource = listaTransp
                    End Using
                    connection.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los nombres de los productos. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        Try
            If Not ValidacionTxtID() Then
                MessageBox.Show("Faltan campos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Using conexion As New SqlConnection(connectionString)
                    conexion.Open()
                    Using comando As New SqlCommand("InsertarDetallePedido", conexion)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@PedidoID", Integer.Parse(TxtIdPedido.Text))
                        comando.Parameters.AddWithValue("@ProductoID", Integer.Parse(CbIdProduct.SelectedItem))
                        comando.Parameters.AddWithValue("@IDTransporte", Integer.Parse(txtIdTransporte.Text))
                        comando.Parameters.AddWithValue("@Cantidad", Integer.Parse(TxtCantidad.Text))
                        comando.Parameters.AddWithValue("@PrecioUnitario", Decimal.Parse(TxtTotal.Text))
                        comando.ExecuteNonQuery()
                    End Using
                    conexion.Close()
                End Using
                ActualizarProducto()
                MessageBox.Show("Detalle de Pedido registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar insertar el detalle de Pedido. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ActualizarProducto()
        Dim stock As Decimal = Integer.Parse(TxtStock.Text)
        Dim cantidad As Decimal = Integer.Parse(TxtCantidad.Text)
        Dim totalStock As Decimal = stock - cantidad
        TxtRestante.Text = totalStock.ToString()
        Try
            If Not ValidacionTxtID() Then
                MessageBox.Show("Faltan campos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using comando As New SqlCommand("ActualizarProducto1", connection)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@IdArticulo", CbIdProduct.SelectedItem)
                        comando.Parameters.AddWithValue("@NombreProducto", CbProductosN.SelectedItem)
                        comando.Parameters.AddWithValue("@Precio", Decimal.Parse(TxtPrecio.Text))
                        comando.Parameters.AddWithValue("@Stock", Integer.Parse(TxtRestante.Text))
                        comando.ExecuteNonQuery()
                    End Using
                    connection.Close()
                End Using
                MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar actualizar el producto. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function ValidacionTxtID() As Boolean
        Return Not Integer.Parse(txtIdTransporte.Text) AndAlso
             Not Integer.Parse(TxtIdPedido.Text) AndAlso
             Not Decimal.Parse(TxtPrecio.Text) AndAlso
                 Not Integer.Parse(TxtStock.Text)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CargarPrecio()
    End Sub
    Private Sub CargarPrecio()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT precio,Stock FROM Productos WHERE IdArticulo= @IdArticulo;"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IdArticulo", CbIdProduct.SelectedItem)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim precio As Integer = reader("precio").ToString()
                        Dim stock As Integer = reader("Stock").ToString()
                        TxtPrecio.Text = precio
                        TxtStock.Text = stock
                    End If
                End Using
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim precio As Decimal = Decimal.Parse(TxtPrecio.Text)
        Dim cantidad As Decimal = Decimal.Parse(TxtCantidad.Text)
        Dim total As Decimal = precio * cantidad
        TxtTotal.Text = total.ToString()
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using comando As New SqlCommand("ObtenerDetallesPedido", connection)
                    comando.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter(comando)
                    Dim tablaDTPedido As New DataTable()
                    adaptador.Fill(tablaDTPedido)
                    dgvDTPedido.DataSource = tablaDTPedido
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener los Detalles del Pedido. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CBTransp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTransp.SelectedIndexChanged
        CargarTxtIDtransp()
    End Sub
    Private Sub CargarTxtIDtransp()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT IDTransporte FROM Transporte WHERE Nombre = @nombre;"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nombre", CBTransp.SelectedItem)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim Idtransp As Integer = reader("IDTransporte").ToString()
                        txtIdTransporte.Text = Idtransp
                    End If
                End Using
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub CbProductosN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbProductosN.SelectedIndexChanged
        LlenarCbProductosID()
    End Sub
    Private Sub LlenarCbProductosID()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT IdArticulo FROM Productos WHERE NombreProducto = @NombreProducto;"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NombreProducto", CbProductosN.SelectedItem)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim listaProductosID As New List(Of String)
                        While reader.Read()
                            Dim IDProducto As String = reader("IdArticulo").ToString()
                            listaProductosID.Add(IDProducto)
                        End While
                        CbIdProduct.DataSource = listaProductosID
                    End Using
                    connection.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los ID de los productos. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class