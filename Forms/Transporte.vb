Imports System.Data.SqlClient

Public Class Transporte
    Dim connectionString As String = "data source=DESKTOP-6ECTDJR\SQLEXPRESS; initial catalog=Almacén; integrated security=SSPI; persist security info = false; trusted_connection= yes ; "
    Private Sub InsertarTransp()
        Try
            If ValidacionTxts() Then
                Using conexion As New SqlConnection(connectionString)
                    conexion.Open()
                    Using comando As New SqlCommand("InsertarTransporte", conexion)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                        comando.Parameters.AddWithValue("@Tipo", TxtTipo.Text)
                        comando.Parameters.AddWithValue("@CapacidadKg", Integer.Parse(TxtCapacidad.Text))
                        comando.Parameters.AddWithValue("@NumeroPlaca", TxtPlaca.Text)
                        comando.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Transporte insertado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar insertar el transporte. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub MostrarTransp()
        Try
            Using conexion As New SqlConnection(connectionString)
                conexion.Open()
                Using comando As New SqlCommand("ObtenerTransportes", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    Using adaptador As New SqlDataAdapter(comando)
                        Dim tablaTransportes As New DataTable()
                        adaptador.Fill(tablaTransportes)
                        dgvTransporte.DataSource = tablaTransportes
                    End Using
                End Using
                conexion.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al intentar obtener los transportes. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ActualizarTransporte()
        Try
            If ValidacionTxtID() Then
                Using conexion As New SqlConnection(connectionString)
                    conexion.Open()
                    Using comando As New SqlCommand("ActualizarTransporte", conexion)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@IDTransporte", Integer.Parse(IDTextBox.Text))
                        comando.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                        comando.Parameters.AddWithValue("@Tipo", TxtTipo.Text)
                        comando.Parameters.AddWithValue("@CapacidadKg", Integer.Parse(TxtCapacidad.Text))
                        comando.Parameters.AddWithValue("@NumeroPlaca", TxtPlaca.Text)
                        comando.ExecuteNonQuery()
                    End Using
                    conexion.Close()
                End Using
                MessageBox.Show("Transporte actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar actualizar el transporte. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub EliminarTransp()
        Try
            If (IDTextBox.Text = "") Then
                MessageBox.Show("Debe ingresar un transporte para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using conexion As New SqlConnection(connectionString)
                conexion.Open()
                Using comando As New SqlCommand("EliminarTransporte", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@IDTransporte", Integer.Parse(IDTextBox.Text))
                    comando.ExecuteNonQuery()
                End Using
                conexion.Close()
            End Using
            MessageBox.Show("Transporte eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al intentar eliminar el transporte. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidacionTxts() As Boolean
        Return Not String.IsNullOrWhiteSpace(txtNombre.Text) AndAlso
                Not Integer.Parse(TxtCapacidad.Text) AndAlso
           Not String.IsNullOrWhiteSpace(TxtPlaca.Text) AndAlso
           Not String.IsNullOrWhiteSpace(TxtTipo.Text)
    End Function

    Private Function ValidacionTxtID() As Boolean
        Return Not Integer.Parse(IDTextBox.Text) AndAlso
                Not String.IsNullOrWhiteSpace(txtNombre.Text) AndAlso
              Not Integer.Parse(TxtCapacidad.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtPlaca.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtTipo.Text)
    End Function
    Private Sub Transporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDTextBox.Visible = False
        dgvTransporte.Columns.Add("IDTransporte", "IDTransporte")
        dgvTransporte.Columns.Add("Nombre", "Nombre")
        dgvTransporte.Columns.Add("Tipo", "Tipo")
        dgvTransporte.Columns.Add("CapacidadKg", "CapacidadKg")
        dgvTransporte.Columns.Add("NumeroPlaca", "NumeroPlaca")
    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        InsertarTransp()
    End Sub
    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        MostrarTransp()
    End Sub
    Private Sub BtnActualir_Click(sender As Object, e As EventArgs) Handles BtnActualir.Click
        IDTextBox.Visible = True
        ActualizarTransporte()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        IDTextBox.Visible = True
        EliminarTransp()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub
End Class