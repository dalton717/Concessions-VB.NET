<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Controller
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
        Me.GroupBox_Outbox = New System.Windows.Forms.GroupBox()
        Me.GroupBox_Drinks = New System.Windows.Forms.GroupBox()
        Me.Button_Drinks_Sprite_Up = New System.Windows.Forms.Button()
        Me.Button_Drinks_Sprite_Quanity = New System.Windows.Forms.Button()
        Me.Button_Drinks_Sprite_Down = New System.Windows.Forms.Button()
        Me.CheckBox_Drink_Sprite = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Drinks_Coke = New System.Windows.Forms.CheckBox()
        Me.Button_Drinks_Coke_Up = New System.Windows.Forms.Button()
        Me.Button_Drinks_Coke_Quanity = New System.Windows.Forms.Button()
        Me.Button_Drinks_Coke_Down = New System.Windows.Forms.Button()
        Me.GroupBox_Submit = New System.Windows.Forms.GroupBox()
        Me.Button_Submit_Clear = New System.Windows.Forms.Button()
        Me.Button_Submit_Add = New System.Windows.Forms.Button()
        Me.GroupBox_Drink_Property = New System.Windows.Forms.GroupBox()
        Me.CheckBox_Type_Diet = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Type_Regular = New System.Windows.Forms.CheckBox()
        Me.Button_Submit = New System.Windows.Forms.Button()
        Me.GroupBox_ = New System.Windows.Forms.GroupBox()
        Me.ListBox_UI_Order = New System.Windows.Forms.ListBox()
        Me.Button_Order_Clear = New System.Windows.Forms.Button()
        Me.Button_Order_Delete = New System.Windows.Forms.Button()
        Me.GroupBox_Outbox.SuspendLayout()
        Me.GroupBox_Drinks.SuspendLayout()
        Me.GroupBox_Submit.SuspendLayout()
        Me.GroupBox_Drink_Property.SuspendLayout()
        Me.GroupBox_.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Outbox
        '
        Me.GroupBox_Outbox.BackColor = System.Drawing.Color.Silver
        Me.GroupBox_Outbox.Controls.Add(Me.GroupBox_Drinks)
        Me.GroupBox_Outbox.Controls.Add(Me.GroupBox_Submit)
        Me.GroupBox_Outbox.Controls.Add(Me.GroupBox_Drink_Property)
        Me.GroupBox_Outbox.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox_Outbox.Name = "GroupBox_Outbox"
        Me.GroupBox_Outbox.Size = New System.Drawing.Size(1055, 268)
        Me.GroupBox_Outbox.TabIndex = 0
        Me.GroupBox_Outbox.TabStop = False
        '
        'GroupBox_Drinks
        '
        Me.GroupBox_Drinks.BackColor = System.Drawing.Color.Silver
        Me.GroupBox_Drinks.Controls.Add(Me.Button_Drinks_Sprite_Up)
        Me.GroupBox_Drinks.Controls.Add(Me.Button_Drinks_Sprite_Quanity)
        Me.GroupBox_Drinks.Controls.Add(Me.Button_Drinks_Sprite_Down)
        Me.GroupBox_Drinks.Controls.Add(Me.CheckBox_Drink_Sprite)
        Me.GroupBox_Drinks.Controls.Add(Me.CheckBox_Drinks_Coke)
        Me.GroupBox_Drinks.Controls.Add(Me.Button_Drinks_Coke_Up)
        Me.GroupBox_Drinks.Controls.Add(Me.Button_Drinks_Coke_Quanity)
        Me.GroupBox_Drinks.Controls.Add(Me.Button_Drinks_Coke_Down)
        Me.GroupBox_Drinks.Location = New System.Drawing.Point(0, 1)
        Me.GroupBox_Drinks.Name = "GroupBox_Drinks"
        Me.GroupBox_Drinks.Size = New System.Drawing.Size(883, 261)
        Me.GroupBox_Drinks.TabIndex = 6
        Me.GroupBox_Drinks.TabStop = False
        Me.GroupBox_Drinks.Text = "Drink Type"
        '
        'Button_Drinks_Sprite_Up
        '
        Me.Button_Drinks_Sprite_Up.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Drinks_Sprite_Up.Location = New System.Drawing.Point(87, 149)
        Me.Button_Drinks_Sprite_Up.Name = "Button_Drinks_Sprite_Up"
        Me.Button_Drinks_Sprite_Up.Size = New System.Drawing.Size(70, 31)
        Me.Button_Drinks_Sprite_Up.TabIndex = 6
        Me.Button_Drinks_Sprite_Up.Text = "Up"
        Me.Button_Drinks_Sprite_Up.UseVisualStyleBackColor = True
        '
        'Button_Drinks_Sprite_Quanity
        '
        Me.Button_Drinks_Sprite_Quanity.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Drinks_Sprite_Quanity.Location = New System.Drawing.Point(87, 178)
        Me.Button_Drinks_Sprite_Quanity.Name = "Button_Drinks_Sprite_Quanity"
        Me.Button_Drinks_Sprite_Quanity.Size = New System.Drawing.Size(70, 32)
        Me.Button_Drinks_Sprite_Quanity.TabIndex = 7
        Me.Button_Drinks_Sprite_Quanity.Text = "0"
        Me.Button_Drinks_Sprite_Quanity.UseVisualStyleBackColor = True
        '
        'Button_Drinks_Sprite_Down
        '
        Me.Button_Drinks_Sprite_Down.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Drinks_Sprite_Down.Location = New System.Drawing.Point(87, 206)
        Me.Button_Drinks_Sprite_Down.Name = "Button_Drinks_Sprite_Down"
        Me.Button_Drinks_Sprite_Down.Size = New System.Drawing.Size(70, 33)
        Me.Button_Drinks_Sprite_Down.TabIndex = 8
        Me.Button_Drinks_Sprite_Down.Text = "Down"
        Me.Button_Drinks_Sprite_Down.UseVisualStyleBackColor = True
        '
        'CheckBox_Drink_Sprite
        '
        Me.CheckBox_Drink_Sprite.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Drink_Sprite.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBox_Drink_Sprite.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CheckBox_Drink_Sprite.FlatAppearance.BorderSize = 2
        Me.CheckBox_Drink_Sprite.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua
        Me.CheckBox_Drink_Sprite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_Drink_Sprite.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Drink_Sprite.Location = New System.Drawing.Point(6, 149)
        Me.CheckBox_Drink_Sprite.Name = "CheckBox_Drink_Sprite"
        Me.CheckBox_Drink_Sprite.Size = New System.Drawing.Size(81, 90)
        Me.CheckBox_Drink_Sprite.TabIndex = 5
        Me.CheckBox_Drink_Sprite.Text = "Sprite"
        Me.CheckBox_Drink_Sprite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Drink_Sprite.UseVisualStyleBackColor = False
        '
        'CheckBox_Drinks_Coke
        '
        Me.CheckBox_Drinks_Coke.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Drinks_Coke.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBox_Drinks_Coke.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CheckBox_Drinks_Coke.FlatAppearance.BorderSize = 2
        Me.CheckBox_Drinks_Coke.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua
        Me.CheckBox_Drinks_Coke.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_Drinks_Coke.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Drinks_Coke.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox_Drinks_Coke.Name = "CheckBox_Drinks_Coke"
        Me.CheckBox_Drinks_Coke.Size = New System.Drawing.Size(81, 90)
        Me.CheckBox_Drinks_Coke.TabIndex = 1
        Me.CheckBox_Drinks_Coke.Text = "Coke"
        Me.CheckBox_Drinks_Coke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Drinks_Coke.UseVisualStyleBackColor = False
        '
        'Button_Drinks_Coke_Up
        '
        Me.Button_Drinks_Coke_Up.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Drinks_Coke_Up.Location = New System.Drawing.Point(87, 19)
        Me.Button_Drinks_Coke_Up.Name = "Button_Drinks_Coke_Up"
        Me.Button_Drinks_Coke_Up.Size = New System.Drawing.Size(70, 31)
        Me.Button_Drinks_Coke_Up.TabIndex = 2
        Me.Button_Drinks_Coke_Up.Text = "Up"
        Me.Button_Drinks_Coke_Up.UseVisualStyleBackColor = True
        '
        'Button_Drinks_Coke_Quanity
        '
        Me.Button_Drinks_Coke_Quanity.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Drinks_Coke_Quanity.Location = New System.Drawing.Point(87, 48)
        Me.Button_Drinks_Coke_Quanity.Name = "Button_Drinks_Coke_Quanity"
        Me.Button_Drinks_Coke_Quanity.Size = New System.Drawing.Size(70, 32)
        Me.Button_Drinks_Coke_Quanity.TabIndex = 3
        Me.Button_Drinks_Coke_Quanity.Text = "0"
        Me.Button_Drinks_Coke_Quanity.UseVisualStyleBackColor = True
        '
        'Button_Drinks_Coke_Down
        '
        Me.Button_Drinks_Coke_Down.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Drinks_Coke_Down.Location = New System.Drawing.Point(87, 76)
        Me.Button_Drinks_Coke_Down.Name = "Button_Drinks_Coke_Down"
        Me.Button_Drinks_Coke_Down.Size = New System.Drawing.Size(70, 33)
        Me.Button_Drinks_Coke_Down.TabIndex = 4
        Me.Button_Drinks_Coke_Down.Text = "Down"
        Me.Button_Drinks_Coke_Down.UseVisualStyleBackColor = True
        '
        'GroupBox_Submit
        '
        Me.GroupBox_Submit.BackColor = System.Drawing.Color.Silver
        Me.GroupBox_Submit.Controls.Add(Me.Button_Submit_Clear)
        Me.GroupBox_Submit.Controls.Add(Me.Button_Submit_Add)
        Me.GroupBox_Submit.Location = New System.Drawing.Point(889, 80)
        Me.GroupBox_Submit.Name = "GroupBox_Submit"
        Me.GroupBox_Submit.Size = New System.Drawing.Size(154, 185)
        Me.GroupBox_Submit.TabIndex = 5
        Me.GroupBox_Submit.TabStop = False
        Me.GroupBox_Submit.Text = "Item Submit"
        '
        'Button_Submit_Clear
        '
        Me.Button_Submit_Clear.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button_Submit_Clear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Submit_Clear.Location = New System.Drawing.Point(6, 19)
        Me.Button_Submit_Clear.Name = "Button_Submit_Clear"
        Me.Button_Submit_Clear.Size = New System.Drawing.Size(142, 75)
        Me.Button_Submit_Clear.TabIndex = 11
        Me.Button_Submit_Clear.Text = "Clear"
        Me.Button_Submit_Clear.UseVisualStyleBackColor = False
        '
        'Button_Submit_Add
        '
        Me.Button_Submit_Add.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button_Submit_Add.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Submit_Add.Location = New System.Drawing.Point(6, 91)
        Me.Button_Submit_Add.Name = "Button_Submit_Add"
        Me.Button_Submit_Add.Size = New System.Drawing.Size(142, 91)
        Me.Button_Submit_Add.TabIndex = 12
        Me.Button_Submit_Add.Text = "Add Item"
        Me.Button_Submit_Add.UseVisualStyleBackColor = False
        '
        'GroupBox_Drink_Property
        '
        Me.GroupBox_Drink_Property.BackColor = System.Drawing.Color.Silver
        Me.GroupBox_Drink_Property.Controls.Add(Me.CheckBox_Type_Diet)
        Me.GroupBox_Drink_Property.Controls.Add(Me.CheckBox_Type_Regular)
        Me.GroupBox_Drink_Property.Location = New System.Drawing.Point(889, 1)
        Me.GroupBox_Drink_Property.Name = "GroupBox_Drink_Property"
        Me.GroupBox_Drink_Property.Size = New System.Drawing.Size(160, 80)
        Me.GroupBox_Drink_Property.TabIndex = 4
        Me.GroupBox_Drink_Property.TabStop = False
        Me.GroupBox_Drink_Property.Text = "Drink Types"
        '
        'CheckBox_Type_Diet
        '
        Me.CheckBox_Type_Diet.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Type_Diet.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBox_Type_Diet.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CheckBox_Type_Diet.FlatAppearance.BorderSize = 2
        Me.CheckBox_Type_Diet.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.CheckBox_Type_Diet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.CheckBox_Type_Diet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_Type_Diet.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Type_Diet.Location = New System.Drawing.Point(81, 19)
        Me.CheckBox_Type_Diet.Name = "CheckBox_Type_Diet"
        Me.CheckBox_Type_Diet.Size = New System.Drawing.Size(73, 56)
        Me.CheckBox_Type_Diet.TabIndex = 10
        Me.CheckBox_Type_Diet.Text = "Diet"
        Me.CheckBox_Type_Diet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Type_Diet.UseVisualStyleBackColor = False
        '
        'CheckBox_Type_Regular
        '
        Me.CheckBox_Type_Regular.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Type_Regular.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBox_Type_Regular.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CheckBox_Type_Regular.FlatAppearance.BorderSize = 2
        Me.CheckBox_Type_Regular.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.CheckBox_Type_Regular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.CheckBox_Type_Regular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_Type_Regular.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Type_Regular.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox_Type_Regular.Name = "CheckBox_Type_Regular"
        Me.CheckBox_Type_Regular.Size = New System.Drawing.Size(73, 56)
        Me.CheckBox_Type_Regular.TabIndex = 9
        Me.CheckBox_Type_Regular.Text = "Regular"
        Me.CheckBox_Type_Regular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Type_Regular.UseVisualStyleBackColor = False
        '
        'Button_Submit
        '
        Me.Button_Submit.Location = New System.Drawing.Point(926, 121)
        Me.Button_Submit.Name = "Button_Submit"
        Me.Button_Submit.Size = New System.Drawing.Size(103, 91)
        Me.Button_Submit.TabIndex = 0
        Me.Button_Submit.Text = "Submit"
        Me.Button_Submit.UseVisualStyleBackColor = True
        '
        'GroupBox_
        '
        Me.GroupBox_.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox_.Controls.Add(Me.ListBox_UI_Order)
        Me.GroupBox_.Controls.Add(Me.Button_Submit)
        Me.GroupBox_.Controls.Add(Me.Button_Order_Clear)
        Me.GroupBox_.Controls.Add(Me.Button_Order_Delete)
        Me.GroupBox_.Location = New System.Drawing.Point(6, 283)
        Me.GroupBox_.Name = "GroupBox_"
        Me.GroupBox_.Size = New System.Drawing.Size(1035, 238)
        Me.GroupBox_.TabIndex = 1
        Me.GroupBox_.TabStop = False
        Me.GroupBox_.Text = "Your Order"
        '
        'ListBox_UI_Order
        '
        Me.ListBox_UI_Order.FormattingEnabled = True
        Me.ListBox_UI_Order.Location = New System.Drawing.Point(19, 29)
        Me.ListBox_UI_Order.Name = "ListBox_UI_Order"
        Me.ListBox_UI_Order.Size = New System.Drawing.Size(886, 199)
        Me.ListBox_UI_Order.TabIndex = 8
        '
        'Button_Order_Clear
        '
        Me.Button_Order_Clear.Location = New System.Drawing.Point(926, 80)
        Me.Button_Order_Clear.Name = "Button_Order_Clear"
        Me.Button_Order_Clear.Size = New System.Drawing.Size(103, 44)
        Me.Button_Order_Clear.TabIndex = 5
        Me.Button_Order_Clear.Text = "Clear Order"
        Me.Button_Order_Clear.UseVisualStyleBackColor = True
        '
        'Button_Order_Delete
        '
        Me.Button_Order_Delete.Location = New System.Drawing.Point(926, 40)
        Me.Button_Order_Delete.Name = "Button_Order_Delete"
        Me.Button_Order_Delete.Size = New System.Drawing.Size(103, 44)
        Me.Button_Order_Delete.TabIndex = 7
        Me.Button_Order_Delete.Text = "Delete Item"
        Me.Button_Order_Delete.UseVisualStyleBackColor = True
        '
        'UI_Controller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1051, 533)
        Me.Controls.Add(Me.GroupBox_)
        Me.Controls.Add(Me.GroupBox_Outbox)
        Me.Name = "UI_Controller"
        Me.Text = "Concession"
        Me.GroupBox_Outbox.ResumeLayout(False)
        Me.GroupBox_Drinks.ResumeLayout(False)
        Me.GroupBox_Submit.ResumeLayout(False)
        Me.GroupBox_Drink_Property.ResumeLayout(False)
        Me.GroupBox_.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox_Outbox As GroupBox
    Friend WithEvents GroupBox_Submit As GroupBox
    Friend WithEvents GroupBox_Drink_Property As GroupBox
    Friend WithEvents Button_Drinks_Coke_Down As Button
    Friend WithEvents Button_Drinks_Coke_Quanity As Button
    Friend WithEvents Button_Drinks_Coke_Up As Button
    Friend WithEvents GroupBox_ As GroupBox
    Friend WithEvents Button_Submit_Add As Button
    Friend WithEvents Button_Order_Delete As Button
    Friend WithEvents Button_Order_Clear As Button
    Friend WithEvents Button_Submit As Button
    Friend WithEvents Button_Submit_Clear As Button
    Friend WithEvents ListBox_UI_Order As ListBox
    Friend WithEvents GroupBox_Drinks As GroupBox
    Friend WithEvents CheckBox_Drinks_Coke As CheckBox
    Friend WithEvents CheckBox_Type_Regular As CheckBox
    Friend WithEvents CheckBox_Type_Diet As CheckBox
    Friend WithEvents Button_Drinks_Sprite_Up As Button
    Friend WithEvents Button_Drinks_Sprite_Quanity As Button
    Friend WithEvents Button_Drinks_Sprite_Down As Button
    Friend WithEvents CheckBox_Drink_Sprite As CheckBox
End Class
