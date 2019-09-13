<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SHITEmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SHITEmenu))
        Me.cmdWaht = New System.Windows.Forms.Button()
        Me.cmdTakeIt = New System.Windows.Forms.Button()
        Me.CmdCan = New System.Windows.Forms.Button()
        Me.LBLScored = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdWaht
        '
        Me.cmdWaht.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdWaht.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdWaht.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWaht.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.cmdWaht.Location = New System.Drawing.Point(12, 12)
        Me.cmdWaht.Name = "cmdWaht"
        Me.cmdWaht.Size = New System.Drawing.Size(191, 58)
        Me.cmdWaht.TabIndex = 0
        Me.cmdWaht.Text = "What is the SHITE test?"
        Me.cmdWaht.UseVisualStyleBackColor = True
        '
        'cmdTakeIt
        '
        Me.cmdTakeIt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdTakeIt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTakeIt.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTakeIt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.cmdTakeIt.Location = New System.Drawing.Point(12, 76)
        Me.cmdTakeIt.Name = "cmdTakeIt"
        Me.cmdTakeIt.Size = New System.Drawing.Size(191, 58)
        Me.cmdTakeIt.TabIndex = 1
        Me.cmdTakeIt.Text = "Take the SHITE test"
        Me.cmdTakeIt.UseVisualStyleBackColor = True
        '
        'CmdCan
        '
        Me.CmdCan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCan.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdCan.Location = New System.Drawing.Point(12, 140)
        Me.CmdCan.Name = "CmdCan"
        Me.CmdCan.Size = New System.Drawing.Size(191, 58)
        Me.CmdCan.TabIndex = 2
        Me.CmdCan.Text = "I don't want to take the SHITE test"
        Me.CmdCan.UseVisualStyleBackColor = False
        '
        'LBLScored
        '
        Me.LBLScored.AutoSize = True
        Me.LBLScored.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBLScored.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLScored.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.LBLScored.Location = New System.Drawing.Point(209, 53)
        Me.LBLScored.Name = "LBLScored"
        Me.LBLScored.Size = New System.Drawing.Size(84, 57)
        Me.LBLScored.TabIndex = 3
        Me.LBLScored.Text = "You have not " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "yet taken the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "shite test"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(239, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'SHITEmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(297, 207)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LBLScored)
        Me.Controls.Add(Me.CmdCan)
        Me.Controls.Add(Me.cmdTakeIt)
        Me.Controls.Add(Me.cmdWaht)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SHITEmenu"
        Me.Text = "The S.H.I.T.E test"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdWaht As Button
    Friend WithEvents cmdTakeIt As Button
    Friend WithEvents CmdCan As Button
    Friend WithEvents LBLScored As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
