<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class generateRoom
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(177, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(455, 37)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "RANDOM ROOM ALLOCATION"
        '
        'Button1
        '
        Me.Button1.CheckedState.Parent = Me.Button1
        Me.Button1.CustomImages.Parent = Me.Button1
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.HoverState.Parent = Me.Button1
        Me.Button1.Location = New System.Drawing.Point(184, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.ShadowDecoration.Parent = Me.Button1
        Me.Button1.Size = New System.Drawing.Size(180, 45)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "GENERATE"
        '
        'Button2
        '
        Me.Button2.CheckedState.Parent = Me.Button2
        Me.Button2.CustomImages.Parent = Me.Button2
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.HoverState.Parent = Me.Button2
        Me.Button2.Location = New System.Drawing.Point(452, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.ShadowDecoration.Parent = Me.Button2
        Me.Button2.Size = New System.Drawing.Size(180, 45)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "VIEW ROOM"
        '
        'generateRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "generateRoom"
        Me.Text = "generateRoom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button2 As Guna.UI2.WinForms.Guna2Button
End Class
