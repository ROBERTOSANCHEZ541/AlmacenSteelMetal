Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Pedidos
    Dim connectionString As String = "data source=DESKTOP-6ECTDJR\SQLEXPRESS; initial catalog=Almacén; integrated security=SSPI; persist security info = false; trusted_connection= yes ; "
    Public ultimoID As Integer
    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFecha()
        Label1.Visible = False
        TxtIDPedido.Visible = False
        LlenarCbClienteN()
    End Sub
    Private Sub LlenarCbClienteN()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Nombre FROM Cliente"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim listaClient As New List(Of String)
                        While reader.Read()
                            Dim nombreCliente As String = reader("Nombre").ToString()
                            listaClient.Add(nombreCliente)
                        End While
                        CBNombreC.DataSource = listaClient
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

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        InsertarPedido()
    End Sub
    Private Sub InsertarPedido()
        Try
            If (txtClienteID.Text = "") Then
                MessageBox.Show("Faltan campos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtClienteID.Focus()
                Return
            End If
            If Not Integer.TryParse(txtClienteID.Text, Nothing) Then
                MessageBox.Show("El ClienteID debe ser un número entero válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using connection As New SqlConnection(connectionString)
                    connection.Open()
                Using comando As New SqlCommand("InsertarPedidoID", connection)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@FechaPedido", txtFechaPedido.Text)
                    comando.Parameters.AddWithValue("@ClienteID", Integer.Parse(txtClienteID.Text))
                    Dim parametroUltimoID As New SqlParameter("@UltimoID", SqlDbType.Int)
                    parametroUltimoID.Direction = ParameterDirection.Output
                    comando.Parameters.Add(parametroUltimoID)
                    comando.ExecuteNonQuery()
                    ultimoID = Convert.ToInt32(parametroUltimoID.Value)
                    TxtIDPedido.Text = ultimoID.ToString()
                End Using
                connection.Close()
            End Using
            MessageBox.Show("Pedido insertado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DetPedido.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error al intentar insertar el Pedido. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ObtenerPedidos()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using comando As New SqlCommand("ObtenerPedidos", connection)
                    comando.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter(comando)
                    Dim tablaPedidos As New DataTable()
                    adaptador.Fill(tablaPedidos)
                    dgvPedidos.DataSource = tablaPedidos
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener los pedidos. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        ObtenerPedidos()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub CBNombreC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNombreC.SelectedIndexChanged
        CargarTxtIDCliente()
    End Sub
    Private Sub CargarTxtIDCliente()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT IdCliente FROM Cliente WHERE Nombre = @nombre;"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nombre", CBNombreC.SelectedItem)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim IdCliente As Integer = reader("IdCliente").ToString()
                        txtClienteID.Text = IdCliente
                    End If
                End Using
                connection.Close()
            End Using
        End Using
    End Sub
End Class