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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnSpeed = New System.Windows.Forms.Button()
        Me.lstSpeed = New System.Windows.Forms.ListBox()
        Me.lblAvgSpeed = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(322, 45)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(320, 32)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Internet Speed Test Survey"
        '
        'btnSpeed
        '
        Me.btnSpeed.BackColor = System.Drawing.Color.Olive
        Me.btnSpeed.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSpeed.Location = New System.Drawing.Point(348, 99)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(268, 60)
        Me.btnSpeed.TabIndex = 1
        Me.btnSpeed.Text = "Enter Internet Speed"
        Me.btnSpeed.UseVisualStyleBackColor = False
        '
        'lstSpeed
        '
        Me.lstSpeed.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSpeed.FormattingEnabled = True
        Me.lstSpeed.ItemHeight = 45
        Me.lstSpeed.Location = New System.Drawing.Point(644, 75)
        Me.lstSpeed.Name = "lstSpeed"
        Me.lstSpeed.Size = New System.Drawing.Size(139, 184)
        Me.lstSpeed.TabIndex = 2
        '
        'lblAvgSpeed
        '
        Me.lblAvgSpeed.AutoSize = True
        Me.lblAvgSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lblAvgSpeed.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgSpeed.Location = New System.Drawing.Point(392, 358)
        Me.lblAvgSpeed.Name = "lblAvgSpeed"
        Me.lblAvgSpeed.Size = New System.Drawing.Size(81, 30)
        Me.lblAvgSpeed.TabIndex = 3
        Me.lblAvgSpeed.Text = "Label1"
        Me.lblAvgSpeed.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(525, 303)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 44)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WeeklyAssignment6.My.Resources.Resources.speed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblAvgSpeed)
        Me.Controls.Add(Me.lstSpeed)
        Me.Controls.Add(Me.btnSpeed)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "Internet Speed Test Survey For Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents btnSpeed As Button
    Friend WithEvents lstSpeed As ListBox
    Friend WithEvents lblAvgSpeed As Label
    Friend WithEvents btnClear As Button
End Class
