Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Compras
    Dim connectionString As String = "data source=DESKTOP-6ECTDJR\SQLEXPRESS; initial catalog=Almacén; integrated security=SSPI; persist security info = false; trusted_connection= yes ; "
    Public ultimoID As Integer
    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub
    Private Sub CargarIDEmp()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT IdEmpleado FROM Empleado WHERE Nombre = @NombreUsuario"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@NombreUsuario", FrmMenu.LbUsuario.Text)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim IDEmp As Integer = reader("IdEmpleado").ToString()
                        TxtEmpId.Text = IDEmp
                    End If
                End Using
                connection.Close()
            End Using
        End Using
    End Sub
    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFecha()
        Label1.Visible = False
        TxtIDCompra.Visible = False
        CargarIDEmp()
        LlenarCBProveeN()
    End Sub
    Private Sub LlenarCBProveeN()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Nombre FROM Proveedor"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim listaProv As New List(Of String)
                        While reader.Read()
                            Dim nombreProv As String = reader("Nombre").ToString()
                            listaProv.Add(nombreProv)
                        End While
                        CBNombreP.DataSource = listaProv
                    End Using
                    connection.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los nombres de los productos. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub TxtFecha()
        Dim fechaActual As Date = DateTime.Now
        Dim fechaFormateada As String = fechaActual.ToString("dd/MM/yyyy")
        txtFechaPedido.Text = fechaFormateada
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        ObtenerCompras()
    End Sub
    Private Sub ObtenerCompras()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using comando As New SqlCommand("ObtenerCompras", connection)
                    comando.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter(comando)
                    Dim tablaPedidos As New DataTable()
                    adaptador.Fill(tablaPedidos)
                    dgvCompras.DataSource = tablaPedidos
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener las compras. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            If Not ValidacionTxtID() Then
                MessageBox.Show("Faltan campos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Using conexion As New SqlConnection(connectionString)
                    conexion.Open()
                    Using comando As New SqlCommand("InsertarCompraID", conexion)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@FechaCompra", txtFechaPedido.Text)
                        comando.Parameters.AddWithValue("@ProveedorID", Integer.Parse(txtProvID.Text))
                        comando.Parameters.AddWithValue("@EmpleadoID", Integer.Parse(TxtEmpId.Text))

                        Dim parametroUltimoID As New SqlParameter("@UltimoID", SqlDbType.Int)
                        parametroUltimoID.Direction = ParameterDirection.Output
                        comando.Parameters.Add(parametroUltimoID)
                        comando.ExecuteNonQuery()
                        ultimoID = Convert.ToInt32(parametroUltimoID.Value)
                        TxtIDCompra.Text = ultimoID.ToString()
                    End Using
                    conexion.Close()
                End Using
                MessageBox.Show("Compra registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DetCompra.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar insertar la compra. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function ValidacionTxtID() As Boolean
        Return Not Integer.Parse(txtProvID.Text) AndAlso
             Not Integer.Parse(TxtEmpId.Text)
    End Function

    Private Sub CBNombreP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNombreP.SelectedIndexChanged
        CargarTxtIDProv()
    End Sub
    Private Sub CargarTxtIDProv()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT IdProveedor FROM Proveedor WHERE Nombre = @nombre;"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nombre", CBNombreP.SelectedItem)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim IdCliente As Integer = reader("IdProveedor").ToString()
                        txtProvID.Text = IdCliente
                    End If
                End Using
                connection.Close()
            End Using
        End Using
    End Sub
End Class