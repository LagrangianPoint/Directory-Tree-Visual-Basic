<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btnScan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(btnScan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSelectDir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSelectedDir = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxOutputFormat = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Directory Tree"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Creates a tree (list) of all the files within a folder recursively."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Step 1:  Select Directory to Scan"
        '
        'btnSelectDir
        '
        Me.btnSelectDir.Location = New System.Drawing.Point(18, 84)
        Me.btnSelectDir.Name = "btnSelectDir"
        Me.btnSelectDir.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectDir.TabIndex = 1
        Me.btnSelectDir.Text = "Browse"
        Me.btnSelectDir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Selected Directory:"
        '
        'lblSelectedDir
        '
        Me.lblSelectedDir.AutoSize = True
        Me.lblSelectedDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedDir.Location = New System.Drawing.Point(16, 127)
        Me.lblSelectedDir.Name = "lblSelectedDir"
        Me.lblSelectedDir.Size = New System.Drawing.Size(109, 12)
        Me.lblSelectedDir.TabIndex = 5
        Me.lblSelectedDir.Text = "SELECTED DIRECTORY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Step 2:  Select Output Format"
        '
        'cbxOutputFormat
        '
        Me.cbxOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOutputFormat.FormattingEnabled = True
        Me.cbxOutputFormat.Items.AddRange(New Object() {"TXT", "CSV"})
        Me.cbxOutputFormat.Location = New System.Drawing.Point(229, 149)
        Me.cbxOutputFormat.Name = "cbxOutputFormat"
        Me.cbxOutputFormat.Size = New System.Drawing.Size(94, 21)
        Me.cbxOutputFormat.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Step 3:  Select Output File Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(243, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "(No Extension)"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(325, 181)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(123, 20)
        Me.txtFileName.TabIndex = 3
        Me.txtFileName.Text = "tree_output"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Scan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 241)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbxOutputFormat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSelectedDir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSelectDir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "btnScan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Directory Tree"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSelectDir As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSelectedDir As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxOutputFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
