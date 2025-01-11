<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pharmacist_MainPage
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pharmacist_MainPage))
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.DashBoardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashBoardToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.BillingToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.LogoutToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(939, 33)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'DashBoardToolStripMenuItem
		'
		Me.DashBoardToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
		Me.DashBoardToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DashBoardToolStripMenuItem.Name = "DashBoardToolStripMenuItem"
		Me.DashBoardToolStripMenuItem.Size = New System.Drawing.Size(119, 29)
		Me.DashBoardToolStripMenuItem.Text = "DashBoard"
		'
		'InventoryToolStripMenuItem
		'
		Me.InventoryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
		Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(110, 29)
		Me.InventoryToolStripMenuItem.Text = "Inventory"
		'
		'BillingToolStripMenuItem
		'
		Me.BillingToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
		Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(85, 29)
		Me.BillingToolStripMenuItem.Text = "Billing "
		'
		'ReportsToolStripMenuItem
		'
		Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
		Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(93, 29)
		Me.ReportsToolStripMenuItem.Text = "Reports"
		'
		'LogoutToolStripMenuItem
		'
		Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
		Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(86, 29)
		Me.LogoutToolStripMenuItem.Text = "Log out"
		'
		'PictureBox1
		'
		Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.InitialImage = Nothing
		Me.PictureBox1.Location = New System.Drawing.Point(0, 33)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(939, 523)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 1
		Me.PictureBox1.TabStop = False
		'
		'Pharmacist_MainPage
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(939, 556)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "Pharmacist_MainPage"
		Me.Text = "Pharmacist_MainPage"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents DashBoardToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BillingToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PictureBox1 As PictureBox
End Class
