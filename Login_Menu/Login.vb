Imports System.Data.SqlClient

Public Class Login
    Public valTxtUsuario As String
    Dim connectionString As String = "data source=DESKTOP-6ECTDJR\SQLEXPRESS; initial catalog=Almacén; integrated security=SSPI; persist security info = false; trusted_connection= yes ; "

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNombre.Clear()
        TxtRFC.Clear()
    End Sub
    Public Property VarTtxUser() As String
        Get
            Return valTxtUsuario
        End Get
        Set(ByVal value As String)
            valTxtUsuario = value
        End Set
    End Property
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        valTxtUsuario = TxtNombre.Text
        Try
            'Dim nombre As String = TxtNombre.Text
            'Dim rfcDesencriptado As String = DecryptRFC(TxtRFC.Text)
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using comando As New SqlCommand("VerificarLogin", connection)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                    comando.Parameters.AddWithValue("@RFCDesencriptado", TxtRFC.Text)

                    Dim resultado As String = CStr(comando.ExecuteScalar())
                    If resultado = "Login exitoso" Then
                        MessageBox.Show("¡Login exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        FrmMenu.Show()
                        Me.Hide()
                    Else resultado = "Credenciales inválidas"
                        MessageBox.Show("Credenciales inválidas. Por favor, inténtelo de nuevo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al intentar iniciar sesión. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class