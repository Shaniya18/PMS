<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.lbl = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Pbar = New System.Windows.Forms.ProgressBar()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lbl
		'
		Me.lbl.Dock = System.Windows.Forms.DockStyle.Top
		Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl.Location = New System.Drawing.Point(0, 0)
		Me.lbl.Name = "lbl"
		Me.lbl.Size = New System.Drawing.Size(800, 38)
		Me.lbl.TabIndex = 0
		Me.lbl.Text = "Vitility Drugstore"
		Me.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(180, 38)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(441, 32)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Pharmacy Management System"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(-1, 73)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(801, 443)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(25, 432)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(209, 18)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Developed By:Shaniya Sen"
		'
		'Pbar
		'
		Me.Pbar.Location = New System.Drawing.Point(28, 464)
		Me.Pbar.Name = "Pbar"
		Me.Pbar.Size = New System.Drawing.Size(750, 23)
		Me.Pbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.Pbar.TabIndex = 4
		'
		'Timer1
		'
		Me.Timer1.Interval = 50
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 517)
		Me.Controls.Add(Me.Pbar)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lbl)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lbl As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Pbar As ProgressBar
	Friend WithEvents Timer1 As Timer
End Class
