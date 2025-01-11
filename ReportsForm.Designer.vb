<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsForm))
		Me.cboReportType = New System.Windows.Forms.ComboBox()
		Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
		Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnGenerateReports = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.dgvReportData = New System.Windows.Forms.DataGridView()
		Me.btnPreviousPage = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.dgvReportData, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'cboReportType
		'
		Me.cboReportType.FormattingEnabled = True
		Me.cboReportType.Location = New System.Drawing.Point(194, 33)
		Me.cboReportType.Name = "cboReportType"
		Me.cboReportType.Size = New System.Drawing.Size(238, 24)
		Me.cboReportType.TabIndex = 0
		'
		'dtpStartDate
		'
		Me.dtpStartDate.Location = New System.Drawing.Point(194, 78)
		Me.dtpStartDate.Name = "dtpStartDate"
		Me.dtpStartDate.Size = New System.Drawing.Size(238, 22)
		Me.dtpStartDate.TabIndex = 2
		'
		'dtpEndDate
		'
		Me.dtpEndDate.Location = New System.Drawing.Point(194, 107)
		Me.dtpEndDate.Name = "dtpEndDate"
		Me.dtpEndDate.Size = New System.Drawing.Size(238, 22)
		Me.dtpEndDate.TabIndex = 3
		'
		'GroupBox1
		'
		Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
		Me.GroupBox1.Controls.Add(Me.btnGenerateReports)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.cboReportType)
		Me.GroupBox1.Controls.Add(Me.dtpEndDate)
		Me.GroupBox1.Controls.Add(Me.dtpStartDate)
		Me.GroupBox1.Location = New System.Drawing.Point(19, 35)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(583, 186)
		Me.GroupBox1.TabIndex = 7
		Me.GroupBox1.TabStop = False
		'
		'btnGenerateReports
		'
		Me.btnGenerateReports.Location = New System.Drawing.Point(425, 151)
		Me.btnGenerateReports.Name = "btnGenerateReports"
		Me.btnGenerateReports.Size = New System.Drawing.Size(152, 23)
		Me.btnGenerateReports.TabIndex = 7
		Me.btnGenerateReports.Text = "Generate Reports"
		Me.btnGenerateReports.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(23, 113)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(82, 18)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "End Date:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(23, 80)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(89, 18)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Start Date:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(20, 36)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(105, 18)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Report Type:"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.dgvReportData)
		Me.GroupBox2.Location = New System.Drawing.Point(13, 215)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(775, 223)
		Me.GroupBox2.TabIndex = 8
		Me.GroupBox2.TabStop = False
		'
		'dgvReportData
		'
		Me.dgvReportData.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
		Me.dgvReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvReportData.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
		Me.dgvReportData.Location = New System.Drawing.Point(6, 37)
		Me.dgvReportData.Name = "dgvReportData"
		Me.dgvReportData.RowHeadersWidth = 51
		Me.dgvReportData.RowTemplate.Height = 24
		Me.dgvReportData.Size = New System.Drawing.Size(763, 183)
		Me.dgvReportData.TabIndex = 0
		'
		'btnPreviousPage
		'
		Me.btnPreviousPage.Location = New System.Drawing.Point(646, 12)
		Me.btnPreviousPage.Name = "btnPreviousPage"
		Me.btnPreviousPage.Size = New System.Drawing.Size(153, 32)
		Me.btnPreviousPage.TabIndex = 9
		Me.btnPreviousPage.Text = "Previous Page"
		Me.btnPreviousPage.UseVisualStyleBackColor = True
		'
		'ReportsForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnPreviousPage)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "ReportsForm"
		Me.Text = "ReportsForm"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		CType(Me.dgvReportData, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents cboReportType As ComboBox
	Friend WithEvents dtpStartDate As DateTimePicker
	Friend WithEvents dtpEndDate As DateTimePicker
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents btnGenerateReports As Button
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents dgvReportData As DataGridView
	Friend WithEvents btnPreviousPage As Button
End Class
