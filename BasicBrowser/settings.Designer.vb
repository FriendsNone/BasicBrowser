<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.Gb_hpage = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Btn_set = New System.Windows.Forms.Button()
        Me.Btn_def = New System.Windows.Forms.Button()
        Me.Btn_close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Gb_search = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Gb_hpage.SuspendLayout()
        Me.Gb_search.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gb_hpage
        '
        Me.Gb_hpage.Controls.Add(Me.TextBox1)
        Me.Gb_hpage.Controls.Add(Me.Btn_set)
        Me.Gb_hpage.Controls.Add(Me.Btn_def)
        Me.Gb_hpage.Location = New System.Drawing.Point(12, 12)
        Me.Gb_hpage.Name = "Gb_hpage"
        Me.Gb_hpage.Size = New System.Drawing.Size(478, 53)
        Me.Gb_hpage.TabIndex = 0
        Me.Gb_hpage.TabStop = False
        Me.Gb_hpage.Text = "Homepage"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(293, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Btn_set
        '
        Me.Btn_set.Location = New System.Drawing.Point(387, 20)
        Me.Btn_set.Name = "Btn_set"
        Me.Btn_set.Size = New System.Drawing.Size(75, 23)
        Me.Btn_set.TabIndex = 0
        Me.Btn_set.Text = "Set"
        Me.Btn_set.UseVisualStyleBackColor = True
        '
        'Btn_def
        '
        Me.Btn_def.Location = New System.Drawing.Point(306, 20)
        Me.Btn_def.Name = "Btn_def"
        Me.Btn_def.Size = New System.Drawing.Size(75, 23)
        Me.Btn_def.TabIndex = 0
        Me.Btn_def.Text = "Default"
        Me.Btn_def.UseVisualStyleBackColor = True
        '
        'Btn_close
        '
        Me.Btn_close.Location = New System.Drawing.Point(412, 84)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(75, 23)
        Me.Btn_close.TabIndex = 1
        Me.Btn_close.Text = "Close"
        Me.Btn_close.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(302, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BasicBrowser (ver 0)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by FriendsNone"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Gb_search
        '
        Me.Gb_search.Controls.Add(Me.RadioButton4)
        Me.Gb_search.Controls.Add(Me.RadioButton3)
        Me.Gb_search.Controls.Add(Me.RadioButton2)
        Me.Gb_search.Controls.Add(Me.RadioButton1)
        Me.Gb_search.Location = New System.Drawing.Point(12, 71)
        Me.Gb_search.Name = "Gb_search"
        Me.Gb_search.Size = New System.Drawing.Size(284, 45)
        Me.Gb_search.TabIndex = 3
        Me.Gb_search.TabStop = False
        Me.Gb_search.Text = "Search Engines"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Google"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(72, 20)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Bing"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(124, 20)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton3.TabIndex = 0
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Yahoo"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(186, 20)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(91, 17)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "DuckDuckGo"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 125)
        Me.Controls.Add(Me.Gb_search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.Gb_hpage)
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Settings"
        Me.Gb_hpage.ResumeLayout(False)
        Me.Gb_hpage.PerformLayout()
        Me.Gb_search.ResumeLayout(False)
        Me.Gb_search.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gb_hpage As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Btn_set As Button
    Friend WithEvents Btn_def As Button
    Friend WithEvents Btn_close As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Gb_search As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
