''' <summary>
''' Controller Class
''' </summary>

Public Class UI_Controller
    'Declare Vars
    Private Sub UI_Controller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub




    ' General Functions
    '   Adding Or Subtracting Values
    Private Function Increment(OriginalNumberValue As Integer, Number As Integer, Type As Boolean) 'Parameter1 = Number to increase by 'x' /// Parameter2 = Number value to add or subtract
        Dim InitialValue = OriginalNumberValue

        Dim ValueToUse = Number

        If Type = True Then

            InitialValue = InitialValue + ValueToUse

        Else

            If (InitialValue - ValueToUse) >= 0 Then

                InitialValue = InitialValue - ValueToUse

            Else
                MsgBox("Error. Cant Go Below 0", MsgBoxStyle.Exclamation)

            End If

        End If

        Return InitialValue

    End Function


    '   Disable/Enable Button Groups

    ' Color Code
    '   Drink Types
    '       Back Color
    Private Sub DisableDrinksBackColor()
        If CheckBox_Drinks_Coke.Checked = False And CheckBox_Drink_Sprite.Checked = False Then
            GroupBox_Drinks.BackColor = Color.LightSteelBlue
        End If

    End Sub
    Private Sub EnableDrinksBackColor()
        If CheckBox_Drinks_Coke.Checked = True Or CheckBox_Drink_Sprite.Checked = True Then
            GroupBox_Drinks.BackColor = Color.LightGreen
        End If

    End Sub


    '       Back Color
    Private Sub EnablePropertiesBackColor()
        GroupBox_Drink_Property.BackColor = Color.LightGreen
    End Sub
    Private Sub DisablePropertiesBackColor()
        GroupBox_Drink_Property.BackColor = Color.LightSteelBlue
    End Sub


    'Clear
    Private Sub Button_Submit_Clear_Click(sender As Object, e As EventArgs) Handles Button_Submit_Clear.Click
        DisableDrinksBackColor()
        DisablePropertiesBackColor()

        CheckBox_Drinks_Coke.Checked = False
        CheckBox_Type_Diet.Checked = False
        CheckBox_Type_Regular.Checked = False

    End Sub
    Private Sub Clear()
        DisableDrinksBackColor()
        DisablePropertiesBackColor()

        CheckBox_Drinks_Coke.Checked = False
        CheckBox_Type_Diet.Checked = False
        CheckBox_Type_Regular.Checked = False

        Button_Drinks_Sprite_Quanity.Text = "0"
        Button_Drinks_Coke_Quanity.Text = "0"


    End Sub

    ' Quick Hit Buttons
    Private Function Calculator()
        UI_Controller_Calculator.ShowDialog()
        Return UI_Controller_Calculator.iAmount
    End Function















    'Group List Drinks

    'Coke    
    Private Sub Button_Coke_Up_Click(sender As Object, e As EventArgs) Handles Button_Drinks_Coke_Up.Click

        Dim LabelValue As String = Increment(Button_Drinks_Coke_Quanity.Text, 1, True)

        Button_Drinks_Coke_Quanity.Text = LabelValue

    End Sub
    Private Sub Button_Coke_Down_Click(sender As Object, e As EventArgs) Handles Button_Drinks_Coke_Down.Click

        Dim LabelValue As String = Increment(Button_Drinks_Coke_Quanity.Text, 1, False)

        Button_Drinks_Coke_Quanity.Text = LabelValue
    End Sub
    Private Sub CheckBox_Coke_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Drinks_Coke.CheckedChanged
        Dim FirstTouch As Integer = Val(Button_Drinks_Coke_Quanity.Text)
        If CheckBox_Drinks_Coke.Checked = True Then
            EnableDrinksBackColor()
            If FirstTouch = 0 Then
                Button_Drinks_Coke_Quanity.Text = "1"
            End If
        Else
            DisableDrinksBackColor()
        End If

    End Sub
    Private Sub Button_Coke_Quanity_Click(sender As Object, e As EventArgs) Handles Button_Drinks_Coke_Quanity.Click
        Button_Drinks_Coke_Quanity.Text = Calculator()
    End Sub



    'Sprite 
    Private Sub CheckBox_Drink_Sprite_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Drink_Sprite.CheckedChanged
        Dim FirstTouch As Integer = Val(Button_Drinks_Sprite_Quanity.Text)
        If CheckBox_Drink_Sprite.Checked = True Then
            EnableDrinksBackColor()
            If FirstTouch = 0 Then
                Button_Drinks_Sprite_Quanity.Text = "1"
            End If
        Else
            DisableDrinksBackColor()
        End If
    End Sub
    Private Sub Button_Drinks_Sprite_Up_Click(sender As Object, e As EventArgs) Handles Button_Drinks_Sprite_Up.Click

        Dim LabelValue As String = Increment(Button_Drinks_Sprite_Quanity.Text, 1, True)
        Button_Drinks_Sprite_Quanity.Text = LabelValue

    End Sub
    Private Sub Button_Drinks_Quanity_Click(sender As Object, e As EventArgs) Handles Button_Drinks_Sprite_Quanity.Click
        Button_Drinks_Sprite_Quanity.Text = Calculator()
    End Sub
    Private Sub Button_Drinks_Sprite_Down_Click(sender As Object, e As EventArgs) Handles Button_Drinks_Sprite_Down.Click
        Dim LabelValue As String = Increment(Button_Drinks_Sprite_Quanity.Text, 1, False)

        Button_Drinks_Sprite_Quanity.Text = LabelValue
    End Sub







    'GroupList Drink Properties
    Private Sub DrinkPropertySelection() Handles CheckBox_Type_Regular.CheckedChanged, CheckBox_Type_Diet.CheckedChanged
        If CheckBox_Type_Diet.Checked = True And CheckBox_Type_Regular.Checked = False Then
            EnablePropertiesBackColor()
        ElseIf CheckBox_Type_Regular.Checked = True And CheckBox_Type_Diet.Checked = False Then
            EnablePropertiesBackColor()
        Else
            DisablePropertiesBackColor()
        End If
    End Sub




    ' GroupList Submit
    Private Sub AddItem(ItemName As String, Quanity As Integer, ItemProperty As String)
        ' Ensure Quanity is Higher than 0
        If Quanity = 0 Then
            MsgBox(ItemName + " must have a quanity higher than 0")
        Else
            Dim CheckBox As New CheckedListBox()
            Dim oNewItem As Item


            oNewItem = New Item()
            oNewItem.SET_Product(ItemName)
            oNewItem.SET_iQuanity(Quanity)
            oNewItem.SET_sDrinkProperty(ItemProperty)

            Dim Item As String

            Item = oNewItem.GET_Product & vbTab & oNewItem.GET_sDrinkProperty & vbTab & oNewItem.GET_iQuanity.ToString
            ListBox_UI_Order.Items.Add(Item)
            Item = ""
        End If




    End Sub
    Private Sub Button_Order_Add_Click(sender As Object, e As EventArgs) Handles Button_Submit_Add.Click

        ' Check for Highlights
        If GroupBox_Drinks.BackColor = Color.LightGreen And GroupBox_Drink_Property.BackColor = Color.LightGreen Then
            Dim isChecked As Integer = 0
            Dim ItemProperty As String = ""

            If CheckBox_Type_Diet.Checked = True Then
                ItemProperty = "Diet"
            Else
                ItemProperty = "Regular"
            End If

            While isChecked < 3
                ' Add New Drinks Here






                'Coke
                If CheckBox_Drinks_Coke.Checked = True Then
                    AddItem("Coke", Val(Button_Drinks_Coke_Quanity.Text), ItemProperty)
                    CheckBox_Drinks_Coke.Checked = False
                    'Sprite
                ElseIf CheckBox_Drink_Sprite.Checked = True Then
                    AddItem("Sprite", Val(Button_Drinks_Sprite_Quanity.Text), ItemProperty)
                    CheckBox_Drink_Sprite.Checked = False


                End If

                isChecked = isChecked + 1
            End While


        Else
            If GroupBox_Drinks.BackColor = Color.LightGreen Then
                MsgBox("Please select a Drink Property Type", MsgBoxStyle.Information)
            Else
                MsgBox("Please select a Drink Type", MsgBoxStyle.Information)
            End If
        End If


        Clear()



    End Sub











    'Ordered List



    Private Sub Button_Order_Delete_Click(sender As Object, e As EventArgs) Handles Button_Order_Delete.Click
        ListBox_UI_Order.Items.Remove(ListBox_UI_Order.SelectedItem)
    End Sub

    Private Sub Button_Order_Clear_Click(sender As Object, e As EventArgs) Handles Button_Order_Clear.Click


        While Not (ListBox_UI_Order.Items.Count = 0)

            ListBox_UI_Order.Items.RemoveAt(0)
        End While
    End Sub

    Private Sub Button_Submit_Click(sender As Object, e As EventArgs) Handles Button_Submit.Click
        If ListBox_UI_Order.Items.Count > 0 Then
            MsgBox("Order Submitted Successfully", MsgBoxStyle.OkOnly)
        Else
            MsgBox("You have no items in your account", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub GroupBox_Drinks_Enter(sender As Object, e As EventArgs) Handles GroupBox_Drinks.Enter

    End Sub
End Class
