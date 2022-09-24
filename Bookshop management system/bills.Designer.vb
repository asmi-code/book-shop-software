<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bills
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bills))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cname = New System.Windows.Forms.TextBox()
        Me.bookname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.TextBox()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.addtobtn = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Totallbl = New System.Windows.Forms.Label()
        Me.billsdgv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.booksdgv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Unamelbl = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.billsdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.booksdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox9)
        Me.Panel1.Location = New System.Drawing.Point(7, -33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 780)
        Me.Panel1.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(72, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 37)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "BookShop"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(0, 20)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(66, 65)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 12
        Me.PictureBox9.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label15.Location = New System.Drawing.Point(277, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(274, 34)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "BookShop software"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(372, 37)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(53, 49)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 15
        Me.PictureBox5.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 23)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Client Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 27)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(149, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Quantity"
        '
        'cname
        '
        Me.cname.Location = New System.Drawing.Point(0, 173)
        Me.cname.Name = "cname"
        Me.cname.Size = New System.Drawing.Size(143, 30)
        Me.cname.TabIndex = 21
        '
        'bookname
        '
        Me.bookname.Enabled = False
        Me.bookname.Location = New System.Drawing.Point(0, 114)
        Me.bookname.Name = "bookname"
        Me.bookname.Size = New System.Drawing.Size(143, 30)
        Me.bookname.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Book Name"
        '
        'price
        '
        Me.price.Enabled = False
        Me.price.Location = New System.Drawing.Point(149, 173)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(89, 30)
        Me.price.TabIndex = 23
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(149, 114)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(89, 30)
        Me.qty.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(265, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 32)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'addtobtn
        '
        Me.addtobtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.addtobtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addtobtn.ForeColor = System.Drawing.Color.White
        Me.addtobtn.Location = New System.Drawing.Point(7, 208)
        Me.addtobtn.Name = "addtobtn"
        Me.addtobtn.Size = New System.Drawing.Size(164, 32)
        Me.addtobtn.TabIndex = 30
        Me.addtobtn.Text = "Add To List"
        Me.addtobtn.UseVisualStyleBackColor = False
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.Color.MidnightBlue
        Me.button4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.ForeColor = System.Drawing.Color.White
        Me.button4.Location = New System.Drawing.Point(177, 208)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(82, 32)
        Me.button4.TabIndex = 31
        Me.button4.Text = "Reset"
        Me.button4.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(98, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 27)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Books List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(667, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 27)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Books Bill"
        '
        'Totallbl
        '
        Me.Totallbl.AutoSize = True
        Me.Totallbl.BackColor = System.Drawing.Color.White
        Me.Totallbl.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Totallbl.Location = New System.Drawing.Point(743, 422)
        Me.Totallbl.Name = "Totallbl"
        Me.Totallbl.Size = New System.Drawing.Size(68, 27)
        Me.Totallbl.TabIndex = 36
        Me.Totallbl.Text = "Total"
        '
        'billsdgv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.billsdgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.billsdgv.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.billsdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.billsdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.billsdgv.ColumnHeadersHeight = 25
        Me.billsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.billsdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column2, Me.Column3, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.billsdgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.billsdgv.GridColor = System.Drawing.Color.Black
        Me.billsdgv.Location = New System.Drawing.Point(517, 129)
        Me.billsdgv.Name = "billsdgv"
        Me.billsdgv.RowHeadersVisible = False
        Me.billsdgv.RowHeadersWidth = 51
        Me.billsdgv.RowTemplate.Height = 24
        Me.billsdgv.Size = New System.Drawing.Size(457, 273)
        Me.billsdgv.TabIndex = 38
        Me.billsdgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.billsdgv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.billsdgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.billsdgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.billsdgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.billsdgv.ThemeStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.billsdgv.ThemeStyle.GridColor = System.Drawing.Color.Black
        Me.billsdgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue
        Me.billsdgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.billsdgv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billsdgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.billsdgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.billsdgv.ThemeStyle.HeaderStyle.Height = 25
        Me.billsdgv.ThemeStyle.ReadOnly = False
        Me.billsdgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.billsdgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.billsdgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billsdgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.billsdgv.ThemeStyle.RowsStyle.Height = 24
        Me.billsdgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.billsdgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.FillWeight = 106.9519!
        Me.Column1.HeaderText = "Id"
        Me.Column1.MinimumWidth = 4
        Me.Column1.Name = "Column1"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Book"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column2
        '
        Me.Column2.FillWeight = 97.68271!
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.FillWeight = 97.68271!
        Me.Column3.HeaderText = "Price"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.FillWeight = 97.68271!
        Me.Column5.HeaderText = "Total"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'booksdgv
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.booksdgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.booksdgv.BackgroundColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.booksdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.booksdgv.ColumnHeadersHeight = 4
        Me.booksdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.booksdgv.DefaultCellStyle = DataGridViewCellStyle6
        Me.booksdgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.booksdgv.Location = New System.Drawing.Point(3, 437)
        Me.booksdgv.Name = "booksdgv"
        Me.booksdgv.RowHeadersVisible = False
        Me.booksdgv.RowHeadersWidth = 51
        Me.booksdgv.RowTemplate.Height = 24
        Me.booksdgv.Size = New System.Drawing.Size(522, 289)
        Me.booksdgv.TabIndex = 39
        Me.booksdgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.booksdgv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.booksdgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.booksdgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.booksdgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.booksdgv.ThemeStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.booksdgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.booksdgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.booksdgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.booksdgv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booksdgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.booksdgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.booksdgv.ThemeStyle.HeaderStyle.Height = 4
        Me.booksdgv.ThemeStyle.ReadOnly = False
        Me.booksdgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.booksdgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.booksdgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booksdgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.booksdgv.ThemeStyle.RowsStyle.Height = 24
        Me.booksdgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.booksdgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(974, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 25)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "X"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(733, 452)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 47)
        Me.Button5.TabIndex = 41
        Me.Button5.Text = "Print"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(57, 34)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 42
        Me.PictureBox7.TabStop = False
        '
        'Unamelbl
        '
        Me.Unamelbl.AutoSize = True
        Me.Unamelbl.BackColor = System.Drawing.Color.White
        Me.Unamelbl.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unamelbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Unamelbl.Location = New System.Drawing.Point(63, 7)
        Me.Unamelbl.Name = "Unamelbl"
        Me.Unamelbl.Size = New System.Drawing.Size(95, 27)
        Me.Unamelbl.TabIndex = 43
        Me.Unamelbl.Text = "Uname"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Turquoise
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Unamelbl)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.PictureBox7)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Button5)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label10)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.booksdgv)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.billsdgv)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Totallbl)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label6)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.button4)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.addtobtn)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Button1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.qty)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.price)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.bookname)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cname)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label5)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label13)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.PictureBox5)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label15)
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(237, 3)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1003, 727)
        Me.Guna2CustomGradientPanel1.TabIndex = 42
        '
        'Bills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1252, 753)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Bills"
        Me.Text = "bills"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.billsdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.booksdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cname As TextBox
    Friend WithEvents bookname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents price As TextBox
    Friend WithEvents qty As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents addtobtn As Button
    Friend WithEvents button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Totallbl As Label
    Friend WithEvents billsdgv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents booksdgv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Unamelbl As Label
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
End Class
