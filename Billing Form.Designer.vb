<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing_Form
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing_Form))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.txtDrugName = New System.Windows.Forms.TextBox()
		Me.txtPrice = New System.Windows.Forms.TextBox()
		Me.txtQuantity = New System.Windows.Forms.TextBox()
		Me.btnAddToCart = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnRefreshSales = New System.Windows.Forms.Button()
		Me.dgvSales = New System.Windows.Forms.DataGridView()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.btnGenerateBill = New System.Windows.Forms.Button()
		Me.lblTotalAmount = New System.Windows.Forms.Label()
		Me.dgvCart = New System.Windows.Forms.DataGridView()
		Me.btnPreviousPage = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(25, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(118, 23)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Drug Name:"
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(25, 55)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(100, 23)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Price:"
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(25, 93)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(100, 23)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Quantity:"
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
		'
		'txtDrugName
		'
		Me.txtDrugName.Location = New System.Drawing.Point(177, 15)
		Me.txtDrugName.Name = "txtDrugName"
		Me.txtDrugName.Size = New System.Drawing.Size(153, 22)
		Me.txtDrugName.TabIndex = 4
		'
		'txtPrice
		'
		Me.txtPrice.Location = New System.Drawing.Point(177, 56)
		Me.txtPrice.Name = "txtPrice"
		Me.txtPrice.Size = New System.Drawing.Size(153, 22)
		Me.txtPrice.TabIndex = 5
		'
		'txtQuantity
		'
		Me.txtQuantity.Location = New System.Drawing.Point(177, 95)
		Me.txtQuantity.Name = "txtQuantity"
		Me.txtQuantity.Size = New System.Drawing.Size(153, 22)
		Me.txtQuantity.TabIndex = 6
		'
		'btnAddToCart
		'
		Me.btnAddToCart.Location = New System.Drawing.Point(177, 123)
		Me.btnAddToCart.Name = "btnAddToCart"
		Me.btnAddToCart.Size = New System.Drawing.Size(153, 23)
		Me.btnAddToCart.TabIndex = 7
		Me.btnAddToCart.Text = "Add To Cart"
		Me.btnAddToCart.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(6, 144)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(130, 23)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Total Amount:"
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
		Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
		Me.GroupBox1.Controls.Add(Me.btnRefreshSales)
		Me.GroupBox1.Controls.Add(Me.dgvSales)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 282)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(967, 265)
		Me.GroupBox1.TabIndex = 13
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = " Active Sales DB"
		'
		'btnRefreshSales
		'
		Me.btnRefreshSales.Location = New System.Drawing.Point(6, 232)
		Me.btnRefreshSales.Name = "btnRefreshSales"
		Me.btnRefreshSales.Size = New System.Drawing.Size(125, 27)
		Me.btnRefreshSales.TabIndex = 1
		Me.btnRefreshSales.Text = "Refresh Sales"
		Me.btnRefreshSales.UseVisualStyleBackColor = True
		'
		'dgvSales
		'
		Me.dgvSales.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
		Me.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvSales.Location = New System.Drawing.Point(0, 21)
		Me.dgvSales.Name = "dgvSales"
		Me.dgvSales.RowHeadersWidth = 51
		Me.dgvSales.RowTemplate.Height = 24
		Me.dgvSales.Size = New System.Drawing.Size(967, 194)
		Me.dgvSales.TabIndex = 0
		'
		'GroupBox2
		'
		Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
		Me.GroupBox2.Controls.Add(Me.btnGenerateBill)
		Me.GroupBox2.Controls.Add(Me.lblTotalAmount)
		Me.GroupBox2.Controls.Add(Me.dgvCart)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Location = New System.Drawing.Point(379, 48)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(600, 228)
		Me.GroupBox2.TabIndex = 14
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Current Purchases"
		'
		'btnGenerateBill
		'
		Me.btnGenerateBill.Location = New System.Drawing.Point(133, 190)
		Me.btnGenerateBill.Name = "btnGenerateBill"
		Me.btnGenerateBill.Size = New System.Drawing.Size(170, 29)
		Me.btnGenerateBill.TabIndex = 12
		Me.btnGenerateBill.Text = "Generate Bill"
		Me.btnGenerateBill.UseVisualStyleBackColor = True
		'
		'lblTotalAmount
		'
		Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblTotalAmount.Location = New System.Drawing.Point(133, 144)
		Me.lblTotalAmount.Name = "lblTotalAmount"
		Me.lblTotalAmount.Size = New System.Drawing.Size(167, 23)
		Me.lblTotalAmount.TabIndex = 11
		'
		'dgvCart
		'
		Me.dgvCart.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
		Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvCart.Location = New System.Drawing.Point(0, 21)
		Me.dgvCart.Name = "dgvCart"
		Me.dgvCart.RowHeadersWidth = 51
		Me.dgvCart.RowTemplate.Height = 24
		Me.dgvCart.Size = New System.Drawing.Size(600, 110)
		Me.dgvCart.TabIndex = 10
		'
		'btnPreviousPage
		'
		Me.btnPreviousPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPreviousPage.Location = New System.Drawing.Point(850, 12)
		Me.btnPreviousPage.Name = "btnPreviousPage"
		Me.btnPreviousPage.Size = New System.Drawing.Size(129, 30)
		Me.btnPreviousPage.TabIndex = 15
		Me.btnPreviousPage.Text = "Previous Page"
		Me.btnPreviousPage.UseVisualStyleBackColor = True
		'
		'Billing_Form
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(991, 549)
		Me.Controls.Add(Me.btnPreviousPage)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btnAddToCart)
		Me.Controls.Add(Me.txtQuantity)
		Me.Controls.Add(Me.txtPrice)
		Me.Controls.Add(Me.txtDrugName)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "Billing_Form"
		Me.Text = "Billing_Form"
		Me.GroupBox1.ResumeLayout(False)
		CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents txtDrugName As TextBox
	Friend WithEvents txtPrice As TextBox
	Friend WithEvents txtQuantity As TextBox
	Friend WithEvents btnAddToCart As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents btnGenerateBill As Button
	Friend WithEvents lblTotalAmount As Label
	Friend WithEvents dgvCart As DataGridView
	Friend WithEvents btnRefreshSales As Button
	Friend WithEvents dgvSales As DataGridView
	Friend WithEvents btnPreviousPage As Button
End Class
