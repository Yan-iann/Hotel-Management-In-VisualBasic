<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RoomView = New System.Windows.Forms.DataGridView()
        Me.guestIdTxt = New System.Windows.Forms.TextBox()
        Me.checkInTxt = New System.Windows.Forms.TextBox()
        Me.checkOutTxt = New System.Windows.Forms.TextBox()
        Me.noGuestTxt = New System.Windows.Forms.TextBox()
        Me.roomIdTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.statusTxt = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.roomIdText = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.RoomView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reservation Panel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(364, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Guest ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(364, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Check In Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Check Out Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(364, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Number of Guests:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(364, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Status:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Search Room ID:"
        '
        'RoomView
        '
        Me.RoomView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoomView.Location = New System.Drawing.Point(15, 95)
        Me.RoomView.Name = "RoomView"
        Me.RoomView.Size = New System.Drawing.Size(343, 207)
        Me.RoomView.TabIndex = 8
        '
        'guestIdTxt
        '
        Me.guestIdTxt.Location = New System.Drawing.Point(459, 117)
        Me.guestIdTxt.Name = "guestIdTxt"
        Me.guestIdTxt.Size = New System.Drawing.Size(100, 20)
        Me.guestIdTxt.TabIndex = 11
        '
        'checkInTxt
        '
        Me.checkInTxt.Location = New System.Drawing.Point(459, 146)
        Me.checkInTxt.Name = "checkInTxt"
        Me.checkInTxt.Size = New System.Drawing.Size(100, 20)
        Me.checkInTxt.TabIndex = 12
        '
        'checkOutTxt
        '
        Me.checkOutTxt.Location = New System.Drawing.Point(459, 185)
        Me.checkOutTxt.Name = "checkOutTxt"
        Me.checkOutTxt.Size = New System.Drawing.Size(100, 20)
        Me.checkOutTxt.TabIndex = 13
        '
        'noGuestTxt
        '
        Me.noGuestTxt.Location = New System.Drawing.Point(459, 229)
        Me.noGuestTxt.Name = "noGuestTxt"
        Me.noGuestTxt.Size = New System.Drawing.Size(100, 20)
        Me.noGuestTxt.TabIndex = 14
        '
        'roomIdTxt
        '
        Me.roomIdTxt.Location = New System.Drawing.Point(107, 72)
        Me.roomIdTxt.Name = "roomIdTxt"
        Me.roomIdTxt.Size = New System.Drawing.Size(100, 20)
        Me.roomIdTxt.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(76, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Available Rooms"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(553, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Reserve"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'statusTxt
        '
        Me.statusTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statusTxt.FormattingEnabled = True
        Me.statusTxt.Items.AddRange(New Object() {"Waiting", "In Hotel"})
        Me.statusTxt.Location = New System.Drawing.Point(459, 266)
        Me.statusTxt.Name = "statusTxt"
        Me.statusTxt.Size = New System.Drawing.Size(121, 21)
        Me.statusTxt.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(569, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Room ID:"
        '
        'roomIdText
        '
        Me.roomIdText.Enabled = False
        Me.roomIdText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomIdText.Location = New System.Drawing.Point(644, 72)
        Me.roomIdText.Name = "roomIdText"
        Me.roomIdText.Size = New System.Drawing.Size(100, 26)
        Me.roomIdText.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(26, 317)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(222, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(634, 317)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 23)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "View Reservation"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(283, 317)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Refresh"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 347)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.roomIdText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.statusTxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.roomIdTxt)
        Me.Controls.Add(Me.noGuestTxt)
        Me.Controls.Add(Me.checkOutTxt)
        Me.Controls.Add(Me.checkInTxt)
        Me.Controls.Add(Me.guestIdTxt)
        Me.Controls.Add(Me.RoomView)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "GuestForm"
        CType(Me.RoomView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RoomView As DataGridView
    Friend WithEvents guestIdTxt As TextBox
    Friend WithEvents checkInTxt As TextBox
    Friend WithEvents checkOutTxt As TextBox
    Friend WithEvents noGuestTxt As TextBox
    Friend WithEvents roomIdTxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents statusTxt As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents roomIdText As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
