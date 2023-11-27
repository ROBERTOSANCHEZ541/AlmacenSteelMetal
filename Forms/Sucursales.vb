Imports System.Data.SqlClient

Public Class Sucursales
    Dim connectionString As String = "data source=DESKTOP-6ECTDJR\SQLEXPRESS; initial catalog=Almacén; integrated security=SSPI; persist security info = false; trusted_connection= yes ; "

    Private Sub Sucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function ValidacionTxts() As Boolean
        Return Not String.IsNullOrWhiteSpace(TxtSucursal.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtDireccion.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtTelefono.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtCp.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtCiudad.Text)
    End Function
    Private Function ValidacionTxtID() As Boolean
        Return Not String.IsNullOrWhiteSpace(TxtSucursal.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtDireccion.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtTelefono.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtCp.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtCiudad.Text) AndAlso
               Not String.IsNullOrWhiteSpace(IDTextBox.Text)
    End Function

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            If Not ValidacionTxts() Then
                MessageBox.Show("Faltan campos por ingresar")
            ElseIf txtTelefono.Text.Length <> 10 Then
                MsgBox("Faltan o tiene mas de 10 digitos", MsgBoxStyle.Exclamation, "Ingrese su Número a 10 digitos")
                txtTelefono.Focus()
            Else
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using comando As New SqlCommand("InsertarSucursal", connection)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@NombreSucursal", TxtSucursal.Text)
                        comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                        comando.Parameters.AddWithValue("@Ciudad", TxtCiudad.Text)
                        comando.Parameters.AddWithValue("@CodigoPostal", txtCp.Text)
                        comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                        comando.ExecuteNonQuery()
                    End Using
                    connection.Close()
                End Using
                MessageBox.Show("Sucursal insertada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar insertar sucursal. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnActualir_Click(sender As Object, e As EventArgs) Handles BtnActualir.Click
        Try
            ' Validar si los campos están llenos
            If Not ValidacionTxtID() Then
                MessageBox.Show("Faltan campos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txtTelefono.Text.Length <> 10 Then
                MsgBox("Faltan o tiene más de 10 dígitos", MsgBoxStyle.Exclamation, "Ingrese su Número a 10 dígitos")
                txtTelefono.Focus()
            Else
                ' Los campos están llenos, proceder con la actualización
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using comando As New SqlCommand("ActualizarSucursal", connection)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@IDSucursal", IDTextBox.Text)
                        comando.Parameters.AddWithValue("@NombreSucursal", TxtSucursal.Text)
                        comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                        comando.Parameters.AddWithValue("@Ciudad", TxtCiudad.Text)
                        comando.Parameters.AddWithValue("@CodigoPostal", txtCp.Text)
                        comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                        comando.ExecuteNonQuery()
                    End Using
                    connection.Close()
                End Using
                MessageBox.Show("Sucursal actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar actualizar la sucursal. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using comando As New SqlCommand("ObtenerSucursales", connection)
                    comando.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter(comando)
                    Dim tablaSucursales As New DataTable()
                    adaptador.Fill(tablaSucursales)
                    dgvSucursales.DataSource = tablaSucursales
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar las sucursales. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub
End Class