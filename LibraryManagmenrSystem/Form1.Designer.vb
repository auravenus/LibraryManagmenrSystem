<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        titlelbl = New Label()
        txtTitle = New TextBox()
        authorlbl = New Label()
        txtAuthor = New TextBox()
        yearlbl = New Label()
        txtYearPublished = New TextBox()
        genrelbl = New Label()
        txtGenre = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(56, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(525, 39)
        Label1.TabIndex = 0
        Label1.Text = "LIBRARY MANAGMENT SYSTEM"
        ' 
        ' titlelbl
        ' 
        titlelbl.AutoSize = True
        titlelbl.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        titlelbl.Location = New Point(61, 131)
        titlelbl.Name = "titlelbl"
        titlelbl.Size = New Size(53, 23)
        titlelbl.TabIndex = 1
        titlelbl.Text = "Title"
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(142, 131)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(415, 23)
        txtTitle.TabIndex = 2
        ' 
        ' authorlbl
        ' 
        authorlbl.AutoSize = True
        authorlbl.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        authorlbl.Location = New Point(61, 201)
        authorlbl.Name = "authorlbl"
        authorlbl.Size = New Size(75, 23)
        authorlbl.TabIndex = 3
        authorlbl.Text = "Author"
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(142, 201)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(415, 23)
        txtAuthor.TabIndex = 4
        ' 
        ' yearlbl
        ' 
        yearlbl.AutoSize = True
        yearlbl.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        yearlbl.Location = New Point(61, 281)
        yearlbl.Name = "yearlbl"
        yearlbl.Size = New Size(152, 23)
        yearlbl.TabIndex = 5
        yearlbl.Text = "Year Published"
        ' 
        ' txtYearPublished
        ' 
        txtYearPublished.Location = New Point(227, 281)
        txtYearPublished.Name = "txtYearPublished"
        txtYearPublished.Size = New Size(330, 23)
        txtYearPublished.TabIndex = 6
        ' 
        ' genrelbl
        ' 
        genrelbl.AutoSize = True
        genrelbl.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        genrelbl.Location = New Point(61, 372)
        genrelbl.Name = "genrelbl"
        genrelbl.Size = New Size(66, 23)
        genrelbl.TabIndex = 7
        genrelbl.Text = "Genre"
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(142, 372)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(415, 23)
        txtGenre.TabIndex = 8
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(31, 456)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(124, 38)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Add Book"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(206, 456)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(120, 38)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update Book"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(364, 456)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(116, 38)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete Book"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(518, 456)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(109, 38)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(648, 28)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(609, 501)
        DataGridView1.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1269, 541)
        Controls.Add(DataGridView1)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(txtGenre)
        Controls.Add(genrelbl)
        Controls.Add(txtYearPublished)
        Controls.Add(yearlbl)
        Controls.Add(txtAuthor)
        Controls.Add(authorlbl)
        Controls.Add(txtTitle)
        Controls.Add(titlelbl)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents titlelbl As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents authorlbl As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents yearlbl As Label
    Friend WithEvents txtYearPublished As TextBox
    Friend WithEvents genrelbl As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents DataGridView1 As DataGridView

End Class
