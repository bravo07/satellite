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
        Me.btnTitle = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btnAttach = New System.Windows.Forms.Button()
        Me.btnDetatch = New System.Windows.Forms.Button()
        Me.btnReadLine = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnWriteLine = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnTitle
        '
        Me.btnTitle.Location = New System.Drawing.Point(138, 241)
        Me.btnTitle.Name = "btnTitle"
        Me.btnTitle.Size = New System.Drawing.Size(75, 23)
        Me.btnTitle.TabIndex = 27
        Me.btnTitle.Text = "Set"
        Me.btnTitle.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 218)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(27, 13)
        Me.label5.TabIndex = 26
        Me.label5.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(57, 215)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(156, 20)
        Me.txtTitle.TabIndex = 25
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 17)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(40, 13)
        Me.label4.TabIndex = 24
        Me.label4.Text = "Control"
        '
        'btnAttach
        '
        Me.btnAttach.Location = New System.Drawing.Point(57, 12)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(75, 23)
        Me.btnAttach.TabIndex = 23
        Me.btnAttach.Text = "Attach"
        Me.btnAttach.UseVisualStyleBackColor = True
        '
        'btnDetatch
        '
        Me.btnDetatch.Location = New System.Drawing.Point(138, 12)
        Me.btnDetatch.Name = "btnDetatch"
        Me.btnDetatch.Size = New System.Drawing.Size(75, 23)
        Me.btnDetatch.TabIndex = 22
        Me.btnDetatch.Text = "Detatch"
        Me.btnDetatch.UseVisualStyleBackColor = True
        '
        'btnReadLine
        '
        Me.btnReadLine.Location = New System.Drawing.Point(138, 173)
        Me.btnReadLine.Name = "btnReadLine"
        Me.btnReadLine.Size = New System.Drawing.Size(75, 23)
        Me.btnReadLine.TabIndex = 21
        Me.btnReadLine.Text = "Read Line"
        Me.btnReadLine.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 150)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(31, 13)
        Me.label2.TabIndex = 20
        Me.label2.Text = "Input"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(57, 147)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(156, 20)
        Me.txtInput.TabIndex = 19
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(57, 106)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(75, 23)
        Me.btnWrite.TabIndex = 18
        Me.btnWrite.Text = "Write"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnWriteLine
        '
        Me.btnWriteLine.Location = New System.Drawing.Point(138, 106)
        Me.btnWriteLine.Name = "btnWriteLine"
        Me.btnWriteLine.Size = New System.Drawing.Size(75, 23)
        Me.btnWriteLine.TabIndex = 17
        Me.btnWriteLine.Text = "Write Line"
        Me.btnWriteLine.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 83)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(39, 13)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Output"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(57, 80)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(156, 20)
        Me.txtOutput.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 274)
        Me.Controls.Add(Me.btnTitle)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.btnAttach)
        Me.Controls.Add(Me.btnDetatch)
        Me.Controls.Add(Me.btnReadLine)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnWriteLine)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtOutput)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Satellite Console Test (VB)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnTitle As Button
    Private WithEvents label5 As Label
    Private WithEvents txtTitle As TextBox
    Private WithEvents label4 As Label
    Private WithEvents btnAttach As Button
    Private WithEvents btnDetatch As Button
    Private WithEvents btnReadLine As Button
    Private WithEvents label2 As Label
    Private WithEvents txtInput As TextBox
    Private WithEvents btnWrite As Button
    Private WithEvents btnWriteLine As Button
    Private WithEvents label1 As Label
    Private WithEvents txtOutput As TextBox
End Class
