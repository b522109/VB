Public Class Inventory
    Inherits CollectionBase
    Public results As New ArrayList


    Public Function buildBook(author As Author, title As String, cover As String, price As Double, qty As Integer) As Book
        Dim newBook As New Book
        newBook.Author = author.Name
        newBook.Title = title
        newBook.Price = price
        newBook.Qty = qty
        newBook.Cover = cover

        Return newBook
    End Function

    Public Sub Add(newBook As Book)
        results.Add(newBook)
    End Sub

    Public Sub remove(soldBook As Book)
        Me.List.Remove(soldBook)
    End Sub

    Default Public Property Item(index As Integer) As Book
        Get
            Return CType(Me.List.Item(index), Book)
        End Get
        Set(value As Book)
            Me.List.Item(index) = value
        End Set
    End Property

        Public Sub Find(search As String)
    End Sub

    
End Class
