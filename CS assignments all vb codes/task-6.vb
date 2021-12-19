Module Module1

    Sub Main()

        Dim donutCount As Integer

        donutCount = 0


        Console.Write("Enter number of donuts:")
        donutCount = Console.ReadLine


        If donutCount < 10 Then
            Console.WriteLine("Number of donuts : " & donutCount)
        Else
            Console.WriteLine("Number of donuts : Many")
        End If


        Console.ReadKey()
    End Sub

End Module
