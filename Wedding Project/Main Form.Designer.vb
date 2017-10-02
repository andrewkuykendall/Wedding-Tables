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
        Me.txtGuests = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblTables = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtGuests
        '
        Me.txtGuests.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtGuests.Location = New System.Drawing.Point(215, 90)
        Me.txtGuests.Multiline = True
        Me.txtGuests.Name = "txtGuests"
        Me.txtGuests.Size = New System.Drawing.Size(65, 35)
        Me.txtGuests.TabIndex = 1
        Me.txtGuests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Guests: "
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(199, 259)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 46)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(73, 259)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(104, 46)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblTables
        '
        Me.lblTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTables.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTables.Location = New System.Drawing.Point(215, 182)
        Me.lblTables.Name = "lblTables"
        Me.lblTables.Size = New System.Drawing.Size(65, 34)
        Me.lblTables.TabIndex = 3
        Me.lblTables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tables Needed:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 339)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTables)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGuests)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wedding Tables"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGuests As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblTables As Label
    Friend WithEvents Label3 As Label
End Class
