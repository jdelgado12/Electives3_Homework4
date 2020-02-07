Public Class Form1
    Dim A, B, C, D, E As Boolean

    Private time As Byte
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds
        Timer1.Start()
    End Sub
    Private binary As Byte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        binary = time

        A = CBool(binary >= 8)
        If A Then
            binary -= 8
        End If

        B = CBool(binary >= 4)
        If B Then
            binary -= 4
        End If

        C = CBool(binary >= 2)
        If C Then
            binary -= 2
        End If

        D = CBool(binary >= 1)
        If D Then
            binary -= 1
        End If

        IsOn(CBool((C And (Not B Or D)) Or (B And Not C)), Button1)

        IsOn(CBool(C Or A Or Not (B Xor D)), Button2)

        IsOn(CBool(Not B Or D Or C), Button3)

        IsOn(CBool(C Or A Or Not (B Xor D)), Button4)

        IsOn(B, Button5)

        IsOn(CBool(A Or (Not C And Not D) Or (B And (Not C Or Not D))), Button10)

        IsOn(CBool(Not A And Not B And Not C And D), Button9)

        IsOn(CBool(Not A And Not B And Not C And D), Button8)

        IsOn(CBool(Not A And Not B And Not C And Not D), Button7)

        IsOn(CBool(A Or (Not B And Not D) Or Not (C Xor D)), Button6)

        IsOn(CBool((Not A And Not B And Not C And Not D) Or (B And (C Xor D))), Button15)

        IsOn(CBool(A Or (C And Not D) Or (B And Not C)), Button14)

        IsOn(CBool(Not B Or Not C Or Not D), Button13)

        IsOn(CBool(A Or B Or C), Button12)

        IsOn(CBool((Not A And Not C And Not D) Or (A And D)), Button11)

        IsOn(CBool(Not D And (Not B Or C)), Button20)

        IsOn(CBool(Not A And Not B And Not C And Not D), Button19)

        IsOn(CBool(Not A And Not B And Not C And D), Button18)

        IsOn(CBool(D And B And C), Button17)

        IsOn(CBool(A Or (Not C And Not D) Or (Not B And C And D) Or (B And (Not C Or Not D))), Button16)

        IsOn(CBool((Not B And C) Or (B And Not C And D)), Button25)

        IsOn(CBool((Not D And (Not B Or C)) Or (Not A And (Not B Or (Not C And D)))), Button24)

        IsOn(CBool(Not B Or (C Xor D)), Button23)

        IsOn(CBool(Not B Or C Or D), Button22)

        IsOn(CBool(Not D And (B Xor C)), Button21)


        If time = 9 Then
            time = 0
        Else
            time += 1
        End If
    End Sub

    Private Sub IsOn(x As Boolean, button As Button)
        Console.WriteLine(x)
        Console.WriteLine(button)

        If x Then
            button.BackColor = Color.White
        Else
            button.BackColor = Color.Black
        End If
    End Sub

End Class
