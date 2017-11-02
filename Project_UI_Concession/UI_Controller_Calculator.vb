Public Class UI_Controller_Calculator


    Dim LabelText As String = ""
    Public iAmount As Integer = 0


    ' Button Numbers
    Private Sub Button_Calc_9_Click(sender As Object, e As EventArgs) Handles Button_Calc_9.Click
        LabelText = LabelText + "9"
        Label_UI_Controller_Calc_TextDisplay.Text = LabelText
    End Sub
    Private Sub Button_Calc_8_Click(sender As Object, e As EventArgs) Handles Button_Calc_8.Click
        LabelText = LabelText + "8"
        Label_UI_Controller_Calc_TextDisplay.Text = LabelText
    End Sub
    Private Sub Button_Calc_7_Click(sender As Object, e As EventArgs) Handles Button_Calc_7.Click
        LabelText = LabelText + "7"
        Label_UI_Controller_Calc_TextDisplay.Text = LabelText
    End Sub
    Private Sub Button_Calc_6_Click(sender As Object, e As EventArgs) Handles Button_Calc_6.Click
        LabelText = LabelText + "6"
        Label_UI_Controller_Calc_TextDisplay.Text = LabelText
    End Sub
    Private Sub Button_Calc_5_Click(sender As Object, e As EventArgs) Handles Button_Calc_5.Click
        LabelText = LabelText + "5"
        Label_UI_Controller_Calc_TextDisplay.Text = LabelText
    End Sub
    Private Sub Button_Calc_4_Click(sender As Object, e As EventArgs) Handles Button_Calc_4.Click
        LabelText = LabelText + "4"
        Label_UI_Controller_Calc_TextDisplay.Text = LabelText
    End Sub
    Private Sub Button_Calc_3_Click(sender As Object, e As EventArgs) Handles Button_Calc_3.Click
        LabelText = LabelText + "3"
        Label_UI_Controller_Calc_TextDisplay.Text = LabelText
    End Sub
    Private Sub Button_Calc_2_Click(sender As Object, e As EventArgs) Handles Button_Calc_2.Click
        LabelText = LabelText + "2"
        Label_UI_Controller_Calc_TextDisplay.Text = LabelText
    End Sub
    Private Sub Button_Calc_1_Click(sender As Object, e As EventArgs) Handles Button_Calc_1.Click
        LabelText = LabelText + "1"
        Label_UI_Controller_Calc_TextDisplay.Text = LabelText
    End Sub
    Private Sub Button_Calc_0_Click(sender As Object, e As EventArgs) Handles Button_Calc_0.Click
        LabelText = LabelText + "0"
        Label_UI_Controller_Calc_TextDisplay.Text = LabelText
    End Sub

    'Backspace Button
    Private Sub Button_UI_Controller_Calc_BackSpace_Click(sender As Object, e As EventArgs) Handles Button_UI_Controller_Calc_BackSpace.Click
        Dim CurrentString As String = Label_UI_Controller_Calc_TextDisplay.Text
        Dim NewString As String = CurrentString
        If Len(CurrentString) > 0 Then
            NewString = CurrentString.Substring(0, (Len(CurrentString) - 1))
            Label_UI_Controller_Calc_TextDisplay.Text = NewString
        End If
        LabelText = NewString
        Label_UI_Controller_Calc_TextDisplay.Text = LabelText
    End Sub


    'Submit Button
    Private Sub Button_UI_Controller_Calc_Submit_Click(sender As Object, e As EventArgs) Handles Button_UI_Controller_Calc_Submit.Click
        iAmount = 0
        iAmount = Val(LabelText)
        Label_UI_Controller_Calc_TextDisplay.Text = ""
        LabelText = ""
        Me.Hide()
        UI_Controller.Show()

    End Sub

    'Clear Button
    Private Sub Button_UI_Calc_Clear_Click(sender As Object, e As EventArgs) Handles Button_UI_Calc_Clear.Click
        Label_UI_Controller_Calc_TextDisplay.Text = ""
        LabelText = ""
    End Sub

End Class