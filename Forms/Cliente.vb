Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class Cliente
    Dim connectionString As String = "data source=DESKTOP-6ECTDJR\SQLEXPRESS; initial catalog=Almacén; integrated security=SSPI; persist security info = false; trusted_connection= yes ; "

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If (TxtNombre.Text = "" And txtEmail.Text = "" And txtTelefono.Text = "") Then
            MessageBox.Show("Faltan campos por ingresar")
        ElseIf txtTelefono.Text.Length <> 10 Then
            MsgBox("Faltan o tiene mas de 10 digitos", MsgBoxStyle.Exclamation, "Ingrese su Número a 10 digitos")
                txtTelefono.Focus()
            Else
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim nuevoIdParam As New SqlParameter("@NuevoID", SqlDbType.Int)
                    nuevoIdParam.Direction = ParameterDirection.Output
                    Using comando As New SqlCommand("InsertarCliente", connection)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                        comando.Parameters.AddWithValue("@Email", txtEmail.Text)
                        comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                        comando.Parameters.Add(nuevoIdParam)
                        comando.ExecuteNonQuery()
                        Dim nuevoId As Integer = CInt(nuevoIdParam.Value)
                        MessageBox.Show($"Cliente agregado exitosamente. Nuevo ID: {nuevoId}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al intentar agregar el cliente. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        If (IDTextBox.Text = "") Then
            MessageBox.Show("Faltan campos por ingresar")
        Else
            Dim idCliente As Integer
            If Integer.TryParse(IDTextBox.Text, idCliente) Then
                Try
                    Using connection As New SqlConnection(connectionString)
                        connection.Open()

                        Using comando As New SqlCommand("ObtenerClientesF", connection)
                            comando.CommandType = CommandType.StoredProcedure
                            comando.Parameters.AddWithValue("@IdCliente", idCliente)

                            Dim adaptador As New SqlDataAdapter(comando)
                            Dim tablaClientes As New DataTable()
                            adaptador.Fill(tablaClientes)

                            dgvClientes.Rows.Clear()

                            For Each fila As DataRow In tablaClientes.Rows
                                dgvClientes.Rows.Add(fila("IdCliente"), fila("Nombre"), fila("Email"), fila("Telefono"))
                            Next
                        End Using
                    End Using

                    MessageBox.Show("Clientes obtenidos exitosamente.")
                Catch ex As Exception
                    MessageBox.Show("Error al intentar obtener los clientes. Detalles: " & ex.Message)
                End Try
            Else
                MessageBox.Show("El ID del cliente debe ser un número entero válido.")
            End If
        End If
    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvClientes.Columns.Add("IdCliente", "ID Cliente")
        dgvClientes.Columns.Add("Nombre", "Nombre")
        dgvClientes.Columns.Add("Email", "Email")
        dgvClientes.Columns.Add("Telefono", "Teléfono")
        BtnActualir.Visible = False
        BtnAgregar.Visible = False
        BtnMostrar.Visible = False
    End Sub

    Private Sub BtnActualir_Click(sender As Object, e As EventArgs) Handles BtnActualir.Click
        If (TxtNombre.Text = "" And txtEmail.Text = "" And txtTelefono.Text = "" And IDTextBox.Text = "") Then
            MessageBox.Show("Faltan campos por ingresar")
        ElseIf txtTelefono.Text.Length <> 10 Then
            MessageBox.Show("El número de teléfono debe tener 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTelefono.Focus()
        Else
            Try
                Dim idCliente As Integer
                If Integer.TryParse(IDTextBox.Text, idCliente) Then
                    Using conexion As New SqlConnection(connectionString)
                        conexion.Open()
                        Using comando As New SqlCommand("ActualizarCliente", conexion)
                            comando.CommandType = CommandType.StoredProcedure
                            comando.Parameters.AddWithValue("@IdCliente", idCliente)
                            comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                            comando.Parameters.AddWithValue("@Email", txtEmail.Text)
                            comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                            comando.ExecuteNonQuery()
                        End Using
                        conexion.Close()
                    End Using
                    MessageBox.Show("Cliente actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("El ID del cliente no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al intentar actualizar el cliente. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        BtnAgregar.Visible = True
        BtnActualir.Visible = False
        BtnMostrar.Visible = False
        IDTextBox.Visible = False

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        BtnMostrar.Visible = True
        BtnAgregar.Visible = False
        BtnActualir.Visible = False
        IDTextBox.Visible = True
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        BtnActualir.Visible = True
        BtnAgregar.Visible = False
        BtnMostrar.Visible = False
        IDTextBox.Visible = True
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        BtnActualir.Visible = False
        BtnAgregar.Visible = False
        BtnMostrar.Visible = False
    End Sub

    Private Sub IDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        txtEmail.Clear()
        txtTelefono.Clear()
        TxtNombre.Clear()
        IDTextBox.Clear()
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralToolStripMenuItem.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using comando As New SqlCommand("ObtenerClientes", connection)
                    comando.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter(comando)
                    Dim tablaClientes As New DataTable()
                    adaptador.Fill(tablaClientes)
                    dgvClientes.Rows.Clear()
                    For Each fila As DataRow In tablaClientes.Rows
                        dgvClientes.Rows.Add(fila("IdCliente"), fila("Nombre"), fila("Email"), fila("Telefono"))
                    Next
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al intentar obtener clientes. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub IDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDTextBox.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub
End Class