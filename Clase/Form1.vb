Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim datos = New DatosyModulos
        If datos.validarTexto(txtUser) And datos.validarContraseña(txtPass) Then
            If datos.login(txtUser, txtPass) Then
                Me.Visible = False
                Dim form = New Form2
                form.Show()
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos = New DatosyModulos
        If Not datos.checkConnection() Then
            Application.Exit()
        End If
    End Sub
End Class
