Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class DatosyModulos
    Private connection As MySqlConnection = New MySqlConnection("datasource=localhost; username=root; password=52059150; database=fbravo")

    Public Function checkConnection()
        Try
            connection.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al Conectar a la Base de Datos")
            Return False
        End Try
    End Function

    Public Function getConnection()
        Return connection
    End Function

    Public Function validarContraseña(txtValidarContraseña As TextBox) As Boolean
        Dim validador As New Regex("^\d{7,}$")

        If txtValidarContraseña.Text.Trim = "" Then
            MessageBox.Show("El campo para la contraseña no puede estar vacío")
            Return False
        ElseIf Not validador.IsMatch(txtValidarContraseña.Text) Then
            MessageBox.Show("El formato de la contraseña debe de ser solo numérico y tiene que tener un mínimo de 7 carácteres")
            txtValidarContraseña.Text = ""
            Return False
        Else
            Return True
        End If
    End Function

    Public Function login(username As TextBox, password As TextBox)
        getConnection().open
        Dim command = New MySqlCommand("SELECT * from clase1 where Username=@user", getConnection())
        command.Parameters.AddWithValue("@user", username.Text)
        command.CommandType = CommandType.Text

        Dim reader = command.ExecuteReader()
        If reader.Read Then
            If reader("Username").Equals(username.Text) And reader("Password").Equals(password.Text) Then
                Return True
                getConnection().Close
            Else
                username.Text = ""
                password.Text = ""
                MessageBox.Show("Usuario o contraseña incorrectos")
                reader.Close()
                getConnection().Close
                Return False
            End If
        Else
            password.Text = ""
            MessageBox.Show("Esta cuenta no existe!")
            reader.Close()
            getConnection().Close
            Return False
        End If
    End Function

    Public Function validarTexto(txtValidarTexto As TextBox) As Boolean
        Dim validador As New Regex("^[a-zA-Z]")
        If txtValidarTexto.Text.Trim = "" Then
            MessageBox.Show("El campo de texto no puede estar vacío")
            Return False
        ElseIf Not validador.IsMatch(txtValidarTexto.Text) Then
            MessageBox.Show("El campo de texto solo debe de tener letras")
            txtValidarTexto.Text = ""
            Return False
        Else
            Return True
        End If
    End Function
End Class
