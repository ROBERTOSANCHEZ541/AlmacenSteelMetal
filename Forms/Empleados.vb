Imports System.Data.SqlClient

Public Class Empleados
    Dim connectionString As String = "data source=DESKTOP-6ECTDJR\SQLEXPRESS; initial catalog=Almacén; integrated security=SSPI; persist security info = false; trusted_connection= yes ; "

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnActualir.Visible = False
        BtnMostrar.Visible = False
        BtnAgregar.Visible = False
        BtnBorrar.Visible = False
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        IDTextBox.Visible = False
        BtnAgregar.Visible = True
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            If ValidacionTxts() Then
                MessageBox.Show("Faltan campos por ingresar")
            ElseIf txtTelefono.Text.Length <> 10 Then
                MsgBox("Faltan o tiene mas de 10 digitos", MsgBoxStyle.Exclamation, "Ingrese su Número a 10 digitos")
                txtTelefono.Focus()
            Else
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using comando As New SqlCommand("InsertarEmpleado", connection)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                        comando.Parameters.AddWithValue("@Edad", TxtEdad.Text)
                        comando.Parameters.AddWithValue("@RFC", txtRfc.Text)
                        comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                        comando.Parameters.AddWithValue("@CURP", txtcurp.Text)
                        comando.Parameters.AddWithValue("@NSS", TxtNss.Text)
                        comando.Parameters.AddWithValue("@Puesto", TxtPuesto.Text)
                        comando.Parameters.AddWithValue("@IDSucursal", TxtIdSucursal.Text)
                        comando.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Empleado insertado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar insertar empleado. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Try
            If (TxtIdSucursal.Text = "") Then
                MessageBox.Show("Faltan campos por ingresar")
                TxtIdSucursal.Focus()
            Else
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using comando As New SqlCommand("ObtenerEmpleados", connection)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@IDSucursal", TxtIdSucursal.Text)
                        Dim adaptador As New SqlDataAdapter(comando)
                        Dim tablaEmpleados As New DataTable()
                        adaptador.Fill(tablaEmpleados)
                        dgvEmpleado.DataSource = tablaEmpleados
                    End Using
                End Using
                MessageBox.Show("Empleados obtenidos exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar obtener empleados. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnActualir_Click(sender As Object, e As EventArgs) Handles BtnActualir.Click
        Try
            If ValidacionTxtID() Then
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using comando As New SqlCommand("ActualizarEmpleado", connection)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@IdEmpleado", Integer.Parse(IDTextBox.Text))
                        comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                        comando.Parameters.AddWithValue("@Edad", TxtEdad.Text)
                        comando.Parameters.AddWithValue("@RFC", txtRfc.Text)
                        comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                        comando.Parameters.AddWithValue("@CURP", txtcurp.Text)
                        comando.Parameters.AddWithValue("@NSS", TxtNss.Text)
                        comando.Parameters.AddWithValue("@Puesto", TxtPuesto.Text)
                        comando.Parameters.AddWithValue("@IDSucursal", TxtIdSucursal.Text)
                        comando.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Empleado actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Faltan campos por ingresar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar actualizar empleado. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function ValidacionTxtID() As Boolean
        Return Not String.IsNullOrWhiteSpace(IDTextBox.Text) AndAlso
                Not String.IsNullOrWhiteSpace(TxtNombre.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtEdad.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtRfc.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtTelefono.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtcurp.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtNss.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtPuesto.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtIdSucursal.Text)
    End Function
    Private Function ValidacionTxts() As Boolean
        Return Not String.IsNullOrWhiteSpace(TxtNombre.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtEdad.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtRfc.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtTelefono.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtcurp.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtNss.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtPuesto.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtIdSucursal.Text)
    End Function
    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Try
            If IDTextBox.Text <> "" Then
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using comando As New SqlCommand("EliminarEmpleado", connection)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@IdEmpleado", IDTextBox.Text)
                        comando.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Empleado eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Falta ingresar el ID del empleado a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar eliminar empleado. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralToolStripMenuItem.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using comando As New SqlCommand("ObtenerEmpleadosG", connection)
                    comando.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter(comando)
                    Dim tablaEmpleados As New DataTable()
                    adaptador.Fill(tablaEmpleados)
                    dgvEmpleado.DataSource = tablaEmpleados
                End Using
                connection.Close()
            End Using
            MessageBox.Show("Empleados obtenidos exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al intentar obtener empleados. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        BtnMostrar.Visible = True
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        BtnActualir.Visible = True
    End Sub
End Class