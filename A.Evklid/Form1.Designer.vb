<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Форма переопределяет dispose для очистки списка компонентов.
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

	'Является обязательной для конструктора форм Windows Forms
	Private components As System.ComponentModel.IContainer

	'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
	'Для ее изменения используйте конструктор форм Windows Form.  
	'Не изменяйте ее в редакторе исходного кода.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.TextBox3)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.TextBox1)
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Controls.Add(Me.TextBox2)
		Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.GroupBox1.ForeColor = System.Drawing.Color.White
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(200, 309)
		Me.GroupBox1.TabIndex = 6
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "data"
		'
		'Button2
		'
		Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.Button2.ForeColor = System.Drawing.Color.Black
		Me.Button2.Location = New System.Drawing.Point(38, 255)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(100, 34)
		Me.Button2.TabIndex = 8
		Me.Button2.Text = "reset"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.Label3.ForeColor = System.Drawing.Color.Black
		Me.Label3.Location = New System.Drawing.Point(79, 186)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(17, 21)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "c"
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(38, 210)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(100, 29)
		Me.TextBox3.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.Location = New System.Drawing.Point(77, 26)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(19, 21)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "a"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.Label2.ForeColor = System.Drawing.Color.Black
		Me.Label2.Location = New System.Drawing.Point(77, 82)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(19, 21)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "b"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(38, 50)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(100, 29)
		Me.TextBox1.TabIndex = 1
		'
		'Button1
		'
		Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.Button1.ForeColor = System.Drawing.Color.Black
		Me.Button1.Location = New System.Drawing.Point(38, 149)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(100, 34)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "count"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(38, 106)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(100, 29)
		Me.TextBox2.TabIndex = 3
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(225, 339)
		Me.Controls.Add(Me.GroupBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.Text = "Evklid"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents TextBox2 As TextBox
End Class
