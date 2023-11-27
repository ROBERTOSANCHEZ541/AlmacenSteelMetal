Imports System.Data.SqlClient

Public Class Proveedor
    Dim connectionString As String = "data source=DESKTOP-6ECTDJR\SQLEXPRESS; initial catalog=Almacén; integrated security=SSPI; persist security info = false; trusted_connection= yes ; "

    Private Sub Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub InsertarProveedor()
        Try
            If Not ValidacionTxts() Then
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using conexion As New SqlConnection(connectionString)
                conexion.Open()
                Using comando As New SqlCommand("InsertarProveedor", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                    comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                    comando.Parameters.AddWithValue("@RFC", txtRFC.Text)
                    comando.ExecuteNonQuery()
                End Using
                conexion.Close()
            End Using
            MessageBox.Show("Proveedor insertado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al intentar insertar el proveedor. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidacionTxts() As Boolean
        Return Not String.IsNullOrWhiteSpace(txtNombre.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtDireccion.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtRFC.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtTelefono.Text)
    End Function
    Private Function ValidacionTxtID() As Boolean
        Return Not String.IsNullOrWhiteSpace(IDTextBox.Text) AndAlso
                Not String.IsNullOrWhiteSpace(txtNombre.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtTelefono.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtRFC.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtDireccion.Text)
    End Function

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using comando As New SqlCommand("ObtenerProveedores", connection)
                    comando.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter(comando)
                    Dim tablaEmpleados As New DataTable()
                    adaptador.Fill(tablaEmpleados)
                    dgvProveedores.DataSource = tablaEmpleados
                End Using
                connection.Close()
            End Using
            MessageBox.Show("Proveedores obtenidos exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al intentar obtener Proveedores. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        InsertarProveedor()
    End Sub

    Private Sub BtnActualir_Click(sender As Object, e As EventArgs) Handles BtnActualir.Click
        ActualizarProveedor()
    End Sub
    Private Sub ActualizarProveedor()
        Try
            If Not ValidacionTxtID() Then
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txtTelefono.Text.Length <> 10 Then
                MsgBox("Faltan o tiene mas de 10 digitos", MsgBoxStyle.Exclamation, "Ingrese su Número a 10 digitos")
                txtTelefono.Focus()
            Else
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using comando As New SqlCommand("ActualizarProveedor", connection)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@IdProveedor", Integer.Parse(IDTextBox.Text))
                        comando.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                        comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                        comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                        comando.Parameters.AddWithValue("@RFC", txtRFC.Text)
                        comando.ExecuteNonQuery()
                    End Using
                    connection.Close()
                End Using
                MessageBox.Show("Proveedor actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar actualizar el proveedor. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs)

    End Sub
End Class