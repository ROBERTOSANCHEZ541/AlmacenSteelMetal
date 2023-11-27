Imports System.Data.SqlClient

Public Class Categoria
    Dim connectionString As String = "data source=DESKTOP-6ECTDJR\SQLEXPRESS; initial catalog=Almacén; integrated security=SSPI; persist security info = false; trusted_connection= yes ; "
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            ' Puedes ajustar esta condición según tus necesidades
            If TxtCategoria.Text <> "" Then
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    Using comando As New SqlCommand("InsertarCategoria", connection)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@TipoCategoria", TxtCategoria.Text)

                        comando.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Categoría insertada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Falta ingresar el tipo de categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar insertar categoría. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using comando As New SqlCommand("ObtenerCategorias", connection)
                    comando.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter(comando)
                    Dim tablaCategorias As New DataTable()
                    adaptador.Fill(tablaCategorias)
                    dgvCategorias.DataSource = tablaCategorias
                End Using
            End Using
            MessageBox.Show("Categorías obtenidas exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al intentar obtener categorías. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnActualir_Click(sender As Object, e As EventArgs) Handles BtnActualir.Click
        Try
            If IDTextBox.Text <> "" AndAlso TxtCategoria.Text <> "" Then
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using comando As New SqlCommand("ActualizarCategoria", connection)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@IdCategoria", Integer.Parse(IDTextBox.Text))
                        comando.Parameters.AddWithValue("@TipoCategoria", TxtCategoria.Text)
                        comando.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Categoría actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Falta ingresar el ID de la categoría o el tipo de categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar actualizar categoría. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub
End Class