Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    ' Connection string (modify as per your SQL Server instance)
    Private connectionString As String = "Data Source=DESKTOP-D9DRACQ;Initial Catalog=LibraryDB;Integrated Security=True"

    ' Function to establish database connection
    Private Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

    ' Load data into DataGridView
    Private Sub LoadData()
        Using con As SqlConnection = GetConnection()
            con.Open()
            Dim cmd As New SqlCommand("SELECT * FROM Books", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        End Using
    End Sub

    ' Add a new book
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using con As SqlConnection = GetConnection()
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO Books (Title, Author, YearPublished, Genre) VALUES (@Title, @Author, @YearPublished, @Genre)", con)
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text)
            cmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
            cmd.Parameters.AddWithValue("@YearPublished", CInt(txtYearPublished.Text))
            cmd.Parameters.AddWithValue("@Genre", txtGenre.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Book added successfully!")
            LoadData()
            ClearFields()
        End Using
    End Sub

    ' Update a book
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(DataGridView1.SelectedRows(0).Cells("ID").Value)
            Using con As SqlConnection = GetConnection()
                con.Open()
                Dim cmd As New SqlCommand("UPDATE Books SET Title=@Title, Author=@Author, YearPublished=@YearPublished, Genre=@Genre WHERE ID=@ID", con)
                cmd.Parameters.AddWithValue("@ID", id)
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text)
                cmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
                cmd.Parameters.AddWithValue("@YearPublished", CInt(txtYearPublished.Text))
                cmd.Parameters.AddWithValue("@Genre", txtGenre.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Book updated successfully!")
                LoadData()
                ClearFields()
            End Using
        Else
            MessageBox.Show("Please select a book to update.")
        End If
    End Sub

    ' Delete a book
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(DataGridView1.SelectedRows(0).Cells("ID").Value)
            Using con As SqlConnection = GetConnection()
                con.Open()
                Dim cmd As New SqlCommand("DELETE FROM Books WHERE ID=@ID", con)
                cmd.Parameters.AddWithValue("@ID", id)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Book deleted successfully!")
                LoadData()
                ClearFields()
            End Using
        Else
            MessageBox.Show("Please select a book to delete.")
        End If
    End Sub

    ' Clear input fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtTitle.Clear()
        txtAuthor.Clear()
        txtYearPublished.Clear()
        txtGenre.Clear()
    End Sub

    ' Load data when form is loaded
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    ' Fill text boxes when a row is selected in DataGridView
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow = DataGridView1.SelectedRows(0)
            txtTitle.Text = selectedRow.Cells("Title").Value.ToString()
            txtAuthor.Text = selectedRow.Cells("Author").Value.ToString()
            txtYearPublished.Text = selectedRow.Cells("YearPublished").Value.ToString()
            txtGenre.Text = selectedRow.Cells("Genre").Value.ToString()
        End If
    End Sub
End Class