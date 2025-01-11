<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_Management
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory_Management))
		Me.txtAddCategory = New System.Windows.Forms.TextBox()
		Me.txtAddStock = New System.Windows.Forms.TextBox()
		Me.txtAddPrice = New System.Windows.Forms.TextBox()
		Me.txtAddDrugName = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.btnAddToDB = New System.Windows.Forms.Button()
		Me.btnUpdateDB = New System.Windows.Forms.Button()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.grpAddInformation = New System.Windows.Forms.GroupBox()
		Me.grpUpdateDB = New System.Windows.Forms.GroupBox()
		Me.txtUpdateID = New System.Windows.Forms.TextBox()
		Me.txtUpdateStock = New System.Windows.Forms.TextBox()
		Me.txtUpdatePrice = New System.Windows.Forms.TextBox()
		Me.txtUpdateCategory = New System.Windows.Forms.TextBox()
		Me.txtUpdateDrugName = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.grpDelete = New System.Windows.Forms.GroupBox()
		Me.txtDeleteID = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.grpShowData = New System.Windows.Forms.GroupBox()
		Me.btnRefresh = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.btnPreviousPage = New System.Windows.Forms.Button()
		Me.grpAddInformation.SuspendLayout()
		Me.grpUpdateDB.SuspendLayout()
		Me.grpDelete.SuspendLayout()
		Me.grpShowData.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtAddCategory
		'
		Me.txtAddCategory.Location = New System.Drawing.Point(153, 61)
		Me.txtAddCategory.Name = "txtAddCategory"
		Me.txtAddCategory.Size = New System.Drawing.Size(219, 27)
		Me.txtAddCategory.TabIndex = 0
		'
		'txtAddStock
		'
		Me.txtAddStock.Location = New System.Drawing.Point(153, 145)
		Me.txtAddStock.Name = "txtAddStock"
		Me.txtAddStock.Size = New System.Drawing.Size(219, 27)
		Me.txtAddStock.TabIndex = 1
		'
		'txtAddPrice
		'
		Me.txtAddPrice.Location = New System.Drawing.Point(153, 107)
		Me.txtAddPrice.Name = "txtAddPrice"
		Me.txtAddPrice.Size = New System.Drawing.Size(219, 27)
		Me.txtAddPrice.TabIndex = 2
		'
		'txtAddDrugName
		'
		Me.txtAddDrugName.Location = New System.Drawing.Point(153, 21)
		Me.txtAddDrugName.Name = "txtAddDrugName"
		Me.txtAddDrugName.Size = New System.Drawing.Size(219, 27)
		Me.txtAddDrugName.TabIndex = 3
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(14, 114)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(75, 20)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Price: $"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(14, 68)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(96, 20)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Category: "
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(14, 30)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(122, 20)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Drug Name:  "
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(14, 152)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(68, 20)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Stock: "
		'
		'btnAddToDB
		'
		Me.btnAddToDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAddToDB.Location = New System.Drawing.Point(279, 202)
		Me.btnAddToDB.Name = "btnAddToDB"
		Me.btnAddToDB.Size = New System.Drawing.Size(112, 23)
		Me.btnAddToDB.TabIndex = 8
		Me.btnAddToDB.Text = "Add To DB"
		Me.btnAddToDB.UseVisualStyleBackColor = True
		'
		'btnUpdateDB
		'
		Me.btnUpdateDB.Location = New System.Drawing.Point(174, 193)
		Me.btnUpdateDB.Name = "btnUpdateDB"
		Me.btnUpdateDB.Size = New System.Drawing.Size(111, 23)
		Me.btnUpdateDB.TabIndex = 9
		Me.btnUpdateDB.Text = "Update DB"
		Me.btnUpdateDB.UseVisualStyleBackColor = True
		'
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(112, 93)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnDelete.TabIndex = 10
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = True
		'
		'grpAddInformation
		'
		Me.grpAddInformation.BackColor = System.Drawing.SystemColors.Control
		Me.grpAddInformation.Controls.Add(Me.Label3)
		Me.grpAddInformation.Controls.Add(Me.Label2)
		Me.grpAddInformation.Controls.Add(Me.txtAddDrugName)
		Me.grpAddInformation.Controls.Add(Me.txtAddCategory)
		Me.grpAddInformation.Controls.Add(Me.Label1)
		Me.grpAddInformation.Controls.Add(Me.txtAddPrice)
		Me.grpAddInformation.Controls.Add(Me.txtAddStock)
		Me.grpAddInformation.Controls.Add(Me.Label4)
		Me.grpAddInformation.Controls.Add(Me.btnAddToDB)
		Me.grpAddInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpAddInformation.Location = New System.Drawing.Point(15, 12)
		Me.grpAddInformation.Name = "grpAddInformation"
		Me.grpAddInformation.Size = New System.Drawing.Size(407, 247)
		Me.grpAddInformation.TabIndex = 12
		Me.grpAddInformation.TabStop = False
		Me.grpAddInformation.Text = "Add Information"
		'
		'grpUpdateDB
		'
		Me.grpUpdateDB.BackColor = System.Drawing.SystemColors.Control
		Me.grpUpdateDB.Controls.Add(Me.txtUpdateID)
		Me.grpUpdateDB.Controls.Add(Me.txtUpdateStock)
		Me.grpUpdateDB.Controls.Add(Me.txtUpdatePrice)
		Me.grpUpdateDB.Controls.Add(Me.txtUpdateCategory)
		Me.grpUpdateDB.Controls.Add(Me.txtUpdateDrugName)
		Me.grpUpdateDB.Controls.Add(Me.Label10)
		Me.grpUpdateDB.Controls.Add(Me.Label9)
		Me.grpUpdateDB.Controls.Add(Me.Label8)
		Me.grpUpdateDB.Controls.Add(Me.Label7)
		Me.grpUpdateDB.Controls.Add(Me.Label6)
		Me.grpUpdateDB.Controls.Add(Me.btnUpdateDB)
		Me.grpUpdateDB.Location = New System.Drawing.Point(455, 21)
		Me.grpUpdateDB.Name = "grpUpdateDB"
		Me.grpUpdateDB.Size = New System.Drawing.Size(291, 238)
		Me.grpUpdateDB.TabIndex = 13
		Me.grpUpdateDB.TabStop = False
		Me.grpUpdateDB.Text = "Update Database"
		'
		'txtUpdateID
		'
		Me.txtUpdateID.Location = New System.Drawing.Point(96, 158)
		Me.txtUpdateID.Name = "txtUpdateID"
		Me.txtUpdateID.Size = New System.Drawing.Size(178, 22)
		Me.txtUpdateID.TabIndex = 19
		'
		'txtUpdateStock
		'
		Me.txtUpdateStock.Location = New System.Drawing.Point(96, 126)
		Me.txtUpdateStock.Name = "txtUpdateStock"
		Me.txtUpdateStock.Size = New System.Drawing.Size(178, 22)
		Me.txtUpdateStock.TabIndex = 18
		'
		'txtUpdatePrice
		'
		Me.txtUpdatePrice.Location = New System.Drawing.Point(96, 98)
		Me.txtUpdatePrice.Name = "txtUpdatePrice"
		Me.txtUpdatePrice.Size = New System.Drawing.Size(178, 22)
		Me.txtUpdatePrice.TabIndex = 17
		'
		'txtUpdateCategory
		'
		Me.txtUpdateCategory.Location = New System.Drawing.Point(96, 55)
		Me.txtUpdateCategory.Name = "txtUpdateCategory"
		Me.txtUpdateCategory.Size = New System.Drawing.Size(178, 22)
		Me.txtUpdateCategory.TabIndex = 16
		'
		'txtUpdateDrugName
		'
		Me.txtUpdateDrugName.Location = New System.Drawing.Point(96, 22)
		Me.txtUpdateDrugName.Name = "txtUpdateDrugName"
		Me.txtUpdateDrugName.Size = New System.Drawing.Size(178, 22)
		Me.txtUpdateDrugName.TabIndex = 15
		'
		'Label10
		'
		Me.Label10.Location = New System.Drawing.Point(10, 157)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(100, 23)
		Me.Label10.TabIndex = 14
		Me.Label10.Text = "ID:"
		'
		'Label9
		'
		Me.Label9.Location = New System.Drawing.Point(7, 126)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(100, 23)
		Me.Label9.TabIndex = 13
		Me.Label9.Text = "Stock:"
		'
		'Label8
		'
		Me.Label8.Location = New System.Drawing.Point(6, 97)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(100, 23)
		Me.Label8.TabIndex = 12
		Me.Label8.Text = "Price:$"
		'
		'Label7
		'
		Me.Label7.Location = New System.Drawing.Point(10, 52)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(100, 23)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "Category:"
		'
		'Label6
		'
		Me.Label6.Location = New System.Drawing.Point(7, 22)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(100, 23)
		Me.Label6.TabIndex = 10
		Me.Label6.Text = "Drug Name:"
		'
		'grpDelete
		'
		Me.grpDelete.Controls.Add(Me.txtDeleteID)
		Me.grpDelete.Controls.Add(Me.Label5)
		Me.grpDelete.Controls.Add(Me.btnDelete)
		Me.grpDelete.Location = New System.Drawing.Point(776, 118)
		Me.grpDelete.Name = "grpDelete"
		Me.grpDelete.Size = New System.Drawing.Size(193, 137)
		Me.grpDelete.TabIndex = 14
		Me.grpDelete.TabStop = False
		Me.grpDelete.Text = "Delete Database"
		'
		'txtDeleteID
		'
		Me.txtDeleteID.Location = New System.Drawing.Point(63, 40)
		Me.txtDeleteID.Name = "txtDeleteID"
		Me.txtDeleteID.Size = New System.Drawing.Size(100, 22)
		Me.txtDeleteID.TabIndex = 12
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(6, 43)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(100, 23)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "ID:"
		'
		'grpShowData
		'
		Me.grpShowData.BackgroundImage = CType(resources.GetObject("grpShowData.BackgroundImage"), System.Drawing.Image)
		Me.grpShowData.Controls.Add(Me.btnRefresh)
		Me.grpShowData.Controls.Add(Me.DataGridView1)
		Me.grpShowData.Location = New System.Drawing.Point(15, 265)
		Me.grpShowData.Name = "grpShowData"
		Me.grpShowData.Size = New System.Drawing.Size(878, 346)
		Me.grpShowData.TabIndex = 15
		Me.grpShowData.TabStop = False
		Me.grpShowData.Text = "Show Data"
		'
		'btnRefresh
		'
		Me.btnRefresh.Location = New System.Drawing.Point(19, 307)
		Me.btnRefresh.Name = "btnRefresh"
		Me.btnRefresh.Size = New System.Drawing.Size(117, 33)
		Me.btnRefresh.TabIndex = 1
		Me.btnRefresh.Text = "Refresh"
		Me.btnRefresh.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(18, 22)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowHeadersWidth = 51
		Me.DataGridView1.RowTemplate.Height = 24
		Me.DataGridView1.Size = New System.Drawing.Size(844, 279)
		Me.DataGridView1.TabIndex = 0
		'
		'btnPreviousPage
		'
		Me.btnPreviousPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPreviousPage.Location = New System.Drawing.Point(855, 3)
		Me.btnPreviousPage.Name = "btnPreviousPage"
		Me.btnPreviousPage.Size = New System.Drawing.Size(135, 41)
		Me.btnPreviousPage.TabIndex = 16
		Me.btnPreviousPage.Text = "Previous Page"
		Me.btnPreviousPage.UseVisualStyleBackColor = True
		'
		'Inventory_Management
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(991, 616)
		Me.Controls.Add(Me.btnPreviousPage)
		Me.Controls.Add(Me.grpShowData)
		Me.Controls.Add(Me.grpDelete)
		Me.Controls.Add(Me.grpUpdateDB)
		Me.Controls.Add(Me.grpAddInformation)
		Me.Name = "Inventory_Management"
		Me.Text = "Inventory_Management"
		Me.grpAddInformation.ResumeLayout(False)
		Me.grpAddInformation.PerformLayout()
		Me.grpUpdateDB.ResumeLayout(False)
		Me.grpUpdateDB.PerformLayout()
		Me.grpDelete.ResumeLayout(False)
		Me.grpDelete.PerformLayout()
		Me.grpShowData.ResumeLayout(False)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents txtAddCategory As TextBox
	Friend WithEvents txtAddStock As TextBox
	Friend WithEvents txtAddPrice As TextBox
	Friend WithEvents txtAddDrugName As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents btnAddToDB As Button
	Friend WithEvents btnUpdateDB As Button
	Friend WithEvents btnDelete As Button
	Friend WithEvents grpAddInformation As GroupBox
	Friend WithEvents grpUpdateDB As GroupBox
	Friend WithEvents grpDelete As GroupBox
	Friend WithEvents Label10 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents txtUpdateID As TextBox
	Friend WithEvents txtUpdateStock As TextBox
	Friend WithEvents txtUpdatePrice As TextBox
	Friend WithEvents txtUpdateCategory As TextBox
	Friend WithEvents txtUpdateDrugName As TextBox
	Friend WithEvents grpShowData As GroupBox
	Friend WithEvents btnRefresh As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents txtDeleteID As TextBox
	Friend WithEvents btnPreviousPage As Button
End Class
