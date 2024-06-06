Public Class Form1

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = Val(TextBox1.Text) * Val(TextBox3.Text)
        TextBox5.Text = Val(TextBox8.Text) * Val(TextBox6.Text)
        TextBox9.Text = Val(TextBox12.Text) * Val(TextBox10.Text)

        TextBox33.Text = Val(TextBox36.Text) * Val(TextBox34.Text)
        TextBox29.Text = Val(TextBox32.Text) * Val(TextBox30.Text)
        TextBox25.Text = Val(TextBox28.Text) * Val(TextBox26.Text)



        Label7.Text = Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox9.Text) + Val(TextBox33.Text) + Val(TextBox29.Text) + Val(TextBox29.Text)
        Label8.Text = Val(Label7.Text) * 0.19
        Label10.Text = Val(Label7.Text) + Val(Label8.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox8.Clear()
        TextBox12.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        TextBox6.Clear()
        TextBox10.Clear()

        Label7.Text = " "
        Label8.Text = " "
        Label10.Text = " "
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

        Label7.Text = " "
        Label8.Text = " "
        Label10.Text = " "
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        TextBox8.Clear()
        TextBox6.Clear()
        TextBox5.Clear()

        Label7.Text = " "
        Label8.Text = " "
        Label10.Text = " "
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        TextBox12.Clear()
        TextBox10.Clear()
        TextBox9.Clear()

        Label7.Text = " "
        Label8.Text = " "
        Label10.Text = " "
    End Sub

   
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GroupBox3.Visible = True
        GroupBox5.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        GroupBox2.Visible = True
        GroupBox5.Visible = False

    End Sub


   

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        GroupBox5.Visible = True
        GroupBox2.Visible = False
        GroupBox3.Visible = False

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox34.Clear()
        Label7.Text = " "
        Label8.Text = " "
        Label10.Text = " "
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Clear()
        Label7.Text = " "
        Label8.Text = " "
        Label10.Text = " "
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox6.Clear()
        Label7.Text = " "
        Label8.Text = " "
        Label10.Text = " "

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox10.Clear()
        Label7.Text = " "
        Label8.Text = " "
        Label10.Text = " "
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox30.Clear()
        Label7.Text = " "
        Label8.Text = " "
        Label10.Text = " "
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox26.Clear()
        Label7.Text = " "
        Label8.Text = " "
        Label10.Text = " "
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class
