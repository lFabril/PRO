Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos = New DatosyModulos
        datos.getConnection().open
        Dim command = New MySqlCommand("SELECT * from verduras", datos.getConnection())
        Dim reader = command.ExecuteReader()
        While reader.Read
            listar.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5))
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSessionOut.Click
        Me.Close()
        Dim form = New Form1
        form.Visible = True
    End Sub

    Private Sub btnVerdura_Click(sender As Object, e As EventArgs) Handles btnVerdura.Click
        listar.Rows.Add(txtVerdura.Text, verduras.Text, txtSiembra.Text, month.Text, txtPrecio.Text, txtCantidad.Text)
        Dim datos = New DatosyModulos
        datos.getConnection().open
        Dim command = New MySqlCommand("INSERT INTO verduras VALUES (@id,@nombre,@mes,@precio,@cantidad,@siembra)", datos.getConnection())
        command.Parameters.AddWithValue("@id", txtVerdura.Text)
        command.Parameters.AddWithValue("@nombre", verduras.SelectedItem)
        command.Parameters.AddWithValue("@siembra", txtSiembra.Text)
        command.Parameters.AddWithValue("@mes", month.SelectedItem)
        command.Parameters.AddWithValue("@precio", txtPrecio.Text)
        command.Parameters.AddWithValue("@cantidad", txtCantidad.Text)
        command.CommandType = CommandType.Text
        command.ExecuteNonQuery()
        datos.getConnection().close
        MessageBox.Show("Se han insertado los datos correctamente!")
        txtVerdura.Clear()
        verduras.ResetText()
        month.ResetText()
        txtSiembra.Clear()
        txtPrecio.Clear()
        txtCantidad.Clear()
    End Sub

    Private Sub listar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles listar.CellContentClick
        If e.ColumnIndex.Equals(6) Then
            Dim result As DialogResult = New DialogResult()
            result = MessageBox.Show("¿Estas seguro que desea eliminar este cliente?")
            If result = DialogResult.OK Then
                Dim datos = New DatosyModulos
                datos.getConnection().open
                Dim command = New MySqlCommand("DELETE from verduras where idverduras=@id", datos.getConnection())
                command.Parameters.AddWithValue("@id", listar.Rows(e.RowIndex).Cells(0).Value)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                datos.getConnection().close
                MessageBox.Show("La Eliminacion ha sido exitosa!")
                listar.Rows.RemoveAt(e.RowIndex)
            End If
        End If

    End Sub

    Private Sub listar_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles listar.CellEndEdit
        Dim datos = New DatosyModulos
        datos.getConnection().open
        Dim command = New MySqlCommand("SELECT * from verduras", datos.getConnection())
        Dim reader = command.ExecuteReader()
        While reader.Read
            If reader(e.ColumnIndex).Equals(listar.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                Return
            End If
        End While
        reader.Close()
        datos.getConnection().close
        datos.getConnection().open
        Dim command2 = New MySqlCommand("UPDATE verduras SET " + listar.Columns(e.ColumnIndex).Name + "= '" + listar.Rows(e.RowIndex).Cells(e.ColumnIndex).Value + "' WHERE idverduras=@id", datos.getConnection())
        command2.Parameters.AddWithValue("@id", listar.Rows(e.RowIndex).Cells(0).Value)
        command2.CommandType = CommandType.Text
        command2.ExecuteNonQuery()
        datos.getConnection().close
        MessageBox.Show("Datos actualizados!")
    End Sub

End Class