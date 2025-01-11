<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Form
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblPassword = New System.Windows.Forms.Label()
		Me.lblUserName = New System.Windows.Forms.Label()
		Me.txtUserName = New System.Windows.Forms.TextBox()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.GroupBox1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.GroupBox1.Controls.Add(Me.btnClear)
		Me.GroupBox1.Controls.Add(Me.btnLogin)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.lblPassword)
		Me.GroupBox1.Controls.Add(Me.lblUserName)
		Me.GroupBox1.Controls.Add(Me.txtUserName)
		Me.GroupBox1.Controls.Add(Me.txtPassword)
		Me.GroupBox1.Location = New System.Drawing.Point(606, -11)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(459, 420)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		'
		'btnClear
		'
		Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClear.Location = New System.Drawing.Point(182, 312)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(82, 33)
		Me.btnClear.TabIndex = 8
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnLogin
		'
		Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLogin.Location = New System.Drawing.Point(58, 309)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(88, 36)
		Me.btnLogin.TabIndex = 7
		Me.btnLogin.Text = "Login"
		Me.btnLogin.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(9, 20)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(265, 22)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Bula! ,Welcome To Our App."
		'
		'lblPassword
		'
		Me.lblPassword.AutoSize = True
		Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPassword.Location = New System.Drawing.Point(33, 173)
		Me.lblPassword.Name = "lblPassword"
		Me.lblPassword.Size = New System.Drawing.Size(113, 25)
		Me.lblPassword.TabIndex = 4
		Me.lblPassword.Text = "Password:"
		'
		'lblUserName
		'
		Me.lblUserName.AutoSize = True
		Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUserName.Location = New System.Drawing.Point(33, 128)
		Me.lblUserName.Name = "lblUserName"
		Me.lblUserName.Size = New System.Drawing.Size(126, 25)
		Me.lblUserName.TabIndex = 3
		Me.lblUserName.Text = "User Name:"
		'
		'txtUserName
		'
		Me.txtUserName.Location = New System.Drawing.Point(200, 128)
		Me.txtUserName.Name = "txtUserName"
		Me.txtUserName.Size = New System.Drawing.Size(184, 22)
		Me.txtUserName.TabIndex = 2
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(200, 173)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(184, 22)
		Me.txtPassword.TabIndex = 1
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(608, 408)
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'Login_Form
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1064, 408)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "Login_Form"
		Me.Text = "Login_Form"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents lblPassword As Label
	Friend WithEvents lblUserName As Label
	Friend WithEvents txtUserName As TextBox
	Friend WithEvents txtPassword As TextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label4 As Label
	Friend WithEvents btnClear As Button
	Friend WithEvents btnLogin As Button

End Class