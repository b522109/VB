Public Class frmBookStore
    Dim OnHand As New Inventory


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the window and end the program
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Create the new Authot string
        Dim author As New Author
        author.FName = txtFName.Text
        author.LName = txtLName.Text
        Dim newBook As Book
        Dim exception As Integer
        'validate the input
        Try
            If IsNumeric(txtFName.Text) = True Or IsNothing(txtFName.Text) Then
                exception = 0
                Throw New Exception
            ElseIf IsNumeric(txtLName.Text) = True Or IsNothing(txtLName.Text) Then
                exception = 1
                Throw New Exception
            ElseIf IsNumeric(txtTitle.Text) = True Or IsNothing(txtTitle.Text) Then
                exception = 2
                Throw New Exception
            ElseIf IsNumeric(txtPrice.Text) = False Or txtPrice.Text(txtPrice.Text.Length - 3) <> _
                "." Or IsNothing(txtPrice.Text) Then
                exception = 3
                Throw New Exception
            ElseIf IsNumeric(txtQty.Text) = False Or IsNothing(txtQty.Text) Then
                exception = 4
                Throw New Exception
            ElseIf cmbCover.SelectedIndex = -1 Then
                exception = 5
            Else
                newBook = OnHand.buildBook(author, txtTitle.Text, cmbCover.SelectedItem.ToString, CDbl(txtPrice.Text), CInt(txtQty.Text))
                OnHand.Add(newBook)
            End If
        Catch ex As Exception When exception = 0
            MsgBox("First Name is required - no numbers please")
        Catch ex As Exception When exception = 1
            MsgBox("Last Name is requred - no numbers please")
        Catch ex As Exception When exception = 2
            MsgBox("Title is required - no numbers please")
        Catch ex As Exception When exception = 3
            MsgBox("Please enter a price in dollars and sense (a little joke!)")
        Catch ex As Exception When exception = 4
            MsgBox("Number to add must be greater than 0 - no text please")
        Catch ex As Exception When exception = 5
            MsgBox("Please select a cover format")
        End Try

        RefreshList()
        Dim q As Integer = MessageBox.Show("Clear form?", "Clear Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If q = DialogResult.Yes Then
            txtFName.Text = ""
            txtLName.Text = ""
            txtTitle.Text = ""
            txtQty.Text = ""

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Build some sample data
        Dim author As New Author
        author.FName = "Ann"
        author.LName = "Schoenbohm"
        OnHand.Add(OnHand.buildBook(author, "Shepherdsville", "TradePaperback", 19.19, 10))
        OnHand.Add(OnHand.buildBook(author, "The Sketch Book", "Paperback", 12.99, 10))
        OnHand.Add(OnHand.buildBook(author, "The Real Fifi LaRue", "eBook", 4.99, 10))
        author.FName = "John"
        author.LName = "Irving"
        OnHand.Add(OnHand.buildBook(author, "A Prayer for Owen Meany", "Hardcover", 16.99, 10))
        OnHand.Add(OnHand.buildBook(author, "Ciderhouse Rules", "Hardcover", 26.99, 10))

        'Fill the list box
        RefreshList()
    End Sub

   
    
    Private Sub btnSellBook_Click(sender As Object, e As EventArgs) Handles btnSellBook.Click
        'check the there is a current selected item in the list
        If lstOnHand.SelectedIndex <> -1 Then
            'If there are copies on hand, sell one, otherwise throw messagebox No Sale
            If CType(lstOnHand.SelectedItem, Book).Qty > 0 Then
                CType(lstOnHand.SelectedItem, Book).Qty = CType(lstOnHand.SelectedItem, Book).Qty - 1
            Else
                MessageBox.Show("There are no copies of the book to sell.", "No Sale", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'if no selection, give instruction to perform sale
        ElseIf lstOnHand.SelectedIndex = -1 Then
            MessageBox.Show("Please select a book from the list before clicking sell", "Sell Book Tip", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        'Update screen to reflect sale
        RefreshList()
    End Sub

    Private Sub btnAddQty_Click(sender As Object, e As EventArgs) Handles btnAddQty.Click
        'Check that an item is selected
        If lstOnHand.SelectedIndex <> -1 Then
            'Check that the user entered a number to add
            If IsNumeric(txtNumToAdd.Text) = True Then
                CType(lstOnHand.SelectedItem, Book).Qty += CInt(txtNumToAdd.Text)
            Else
                MsgBox("Please enter a number to add books")
            End If
        ElseIf lstOnHand.SelectedIndex = -1 Then
            MessageBox.Show("Please select a book from the list to add additional copies", "Add Book Tip", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

        'Update screen to reflect new copies
        RefreshList()
    End Sub


    Private Sub RefreshList()
        'clear the list to rebuild it
        lstOnHand.Items.Clear()
        'Rebuild list
        For Each item In OnHand.results
            lstOnHand.Items.Add(item)
        Next
       End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim SrchText As String = txtSearch.Text
        MsgBox("I can't get the f'ing search to work")

        
    End Sub

    Private Sub FindInList()
        'I cant get my search to work
    End Sub


    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        'clear the txtSearch text box when the cursor enters it
        txtSearch.Text = ""

        'Shift the focus to the search button
        Me.AcceptButton = btnSearch
    End Sub

    Private Sub txtFName_Enter(sender As Object, e As EventArgs) Handles txtFName.Enter
        'Shift the focus to the Add button
        Me.AcceptButton = btnAdd
    End Sub

    Private Sub txtQty_Enter(sender As Object, e As EventArgs) Handles txtQty.Enter
        'Shift the focus to the Add QTY button
        Me.AcceptButton = btnAddQty
    End Sub
End Class
