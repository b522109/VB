<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookStore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookStore))
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.cmbCover = New System.Windows.Forms.ComboBox()
        Me.lstOnHand = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSellBook = New System.Windows.Forms.Button()
        Me.btnAddQty = New System.Windows.Forms.Button()
        Me.txtNumToAdd = New System.Windows.Forms.TextBox()
        Me.lblBookList = New System.Windows.Forms.Label()
        Me.lblAddInfo = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSellInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStoreName = New System.Windows.Forms.Label()
        Me.picBLBooks = New System.Windows.Forms.PictureBox()
        CType(Me.picBLBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(571, 104)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(332, 27)
        Me.txtFName.TabIndex = 0
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(571, 155)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(332, 27)
        Me.txtLName.TabIndex = 1
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(572, 205)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(331, 27)
        Me.txtTitle.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(571, 257)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(331, 27)
        Me.txtPrice.TabIndex = 3
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(571, 317)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(108, 27)
        Me.txtQty.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(572, 411)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(327, 27)
        Me.txtSearch.TabIndex = 10
        Me.txtSearch.Text = "Type Info to search for here"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(696, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Binding"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(576, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Qty"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(570, 234)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(48, 20)
        Me.lblPrice.TabIndex = 11
        Me.lblPrice.Text = "Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(570, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Title"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(567, 133)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(145, 20)
        Me.lblLName.TabIndex = 13
        Me.lblLName.Text = "Author Last Name"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.Location = New System.Drawing.Point(568, 82)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(146, 20)
        Me.lblFname.TabIndex = 14
        Me.lblFname.Text = "Author First Name"
        '
        'cmbCover
        '
        Me.cmbCover.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCover.FormattingEnabled = True
        Me.cmbCover.Items.AddRange(New Object() {"HardCover", "TradePaperback", "PaperBack", "eBook"})
        Me.cmbCover.Location = New System.Drawing.Point(700, 316)
        Me.cmbCover.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCover.Name = "cmbCover"
        Me.cmbCover.Size = New System.Drawing.Size(202, 28)
        Me.cmbCover.TabIndex = 5
        '
        'lstOnHand
        '
        Me.lstOnHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOnHand.FormattingEnabled = True
        Me.lstOnHand.ItemHeight = 16
        Me.lstOnHand.Location = New System.Drawing.Point(12, 71)
        Me.lstOnHand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstOnHand.Name = "lstOnHand"
        Me.lstOnHand.Size = New System.Drawing.Size(527, 180)
        Me.lstOnHand.TabIndex = 17
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(571, 358)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(213, 40)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add Book to Inventory"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(572, 445)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(212, 40)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSellBook
        '
        Me.btnSellBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSellBook.Location = New System.Drawing.Point(16, 319)
        Me.btnSellBook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSellBook.Name = "btnSellBook"
        Me.btnSellBook.Size = New System.Drawing.Size(523, 40)
        Me.btnSellBook.TabIndex = 21
        Me.btnSellBook.Text = "Sell Book from Inventory"
        Me.btnSellBook.UseVisualStyleBackColor = True
        '
        'btnAddQty
        '
        Me.btnAddQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddQty.Location = New System.Drawing.Point(123, 447)
        Me.btnAddQty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddQty.Name = "btnAddQty"
        Me.btnAddQty.Size = New System.Drawing.Size(416, 40)
        Me.btnAddQty.TabIndex = 22
        Me.btnAddQty.Text = "Add Quantity"
        Me.btnAddQty.UseVisualStyleBackColor = True
        '
        'txtNumToAdd
        '
        Me.txtNumToAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumToAdd.Location = New System.Drawing.Point(16, 454)
        Me.txtNumToAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumToAdd.Name = "txtNumToAdd"
        Me.txtNumToAdd.Size = New System.Drawing.Size(89, 27)
        Me.txtNumToAdd.TabIndex = 23
        '
        'lblBookList
        '
        Me.lblBookList.AutoSize = True
        Me.lblBookList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookList.Location = New System.Drawing.Point(12, 49)
        Me.lblBookList.Name = "lblBookList"
        Me.lblBookList.Size = New System.Drawing.Size(124, 20)
        Me.lblBookList.TabIndex = 24
        Me.lblBookList.Text = "Books on Hand"
        '
        'lblAddInfo
        '
        Me.lblAddInfo.AutoSize = True
        Me.lblAddInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddInfo.Location = New System.Drawing.Point(568, 11)
        Me.lblAddInfo.Name = "lblAddInfo"
        Me.lblAddInfo.Size = New System.Drawing.Size(292, 60)
        Me.lblAddInfo.TabIndex = 25
        Me.lblAddInfo.Text = "To add a new book to Inventory," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "please enter the required information, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "then cl" & _
    "ick the Add Book button below."
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(790, 445)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 40)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSellInfo
        '
        Me.lblSellInfo.AutoSize = True
        Me.lblSellInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSellInfo.Location = New System.Drawing.Point(119, 277)
        Me.lblSellInfo.Name = "lblSellInfo"
        Me.lblSellInfo.Size = New System.Drawing.Size(333, 40)
        Me.lblSellInfo.TabIndex = 27
        Me.lblSellInfo.Text = "To Sell a book, select the book from the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "inventory list and click the Sell Book" & _
    " button."
        Me.lblSellInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 378)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 60)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "To increase Books on Hand of an existing title," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "enter the number of copies to ad" & _
    "d to inventory" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ann click the Add Quantity button."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStoreName
        '
        Me.lblStoreName.AutoSize = True
        Me.lblStoreName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStoreName.Location = New System.Drawing.Point(258, 11)
        Me.lblStoreName.Name = "lblStoreName"
        Me.lblStoreName.Size = New System.Drawing.Size(194, 32)
        Me.lblStoreName.TabIndex = 29
        Me.lblStoreName.Text = "Bohm's Books"
        '
        'picBLBooks
        '
        Me.picBLBooks.Image = CType(resources.GetObject("picBLBooks.Image"), System.Drawing.Image)
        Me.picBLBooks.Location = New System.Drawing.Point(466, 9)
        Me.picBLBooks.Margin = New System.Windows.Forms.Padding(0)
        Me.picBLBooks.Name = "picBLBooks"
        Me.picBLBooks.Size = New System.Drawing.Size(73, 60)
        Me.picBLBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBLBooks.TabIndex = 30
        Me.picBLBooks.TabStop = False
        '
        'frmBookStore
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 505)
        Me.Controls.Add(Me.picBLBooks)
        Me.Controls.Add(Me.lblStoreName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSellInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblAddInfo)
        Me.Controls.Add(Me.lblBookList)
        Me.Controls.Add(Me.txtNumToAdd)
        Me.Controls.Add(Me.btnAddQty)
        Me.Controls.Add(Me.btnSellBook)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstOnHand)
        Me.Controls.Add(Me.cmbCover)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmBookStore"
        Me.Text = "Bookstore Inventory"
        CType(Me.picBLBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents lblFname As System.Windows.Forms.Label
    Friend WithEvents cmbCover As System.Windows.Forms.ComboBox
    Friend WithEvents lstOnHand As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnSellBook As System.Windows.Forms.Button
    Friend WithEvents btnAddQty As System.Windows.Forms.Button
    Friend WithEvents txtNumToAdd As System.Windows.Forms.TextBox
    Friend WithEvents lblBookList As System.Windows.Forms.Label
    Friend WithEvents lblAddInfo As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblSellInfo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStoreName As System.Windows.Forms.Label
    Friend WithEvents picBLBooks As System.Windows.Forms.PictureBox

End Class
