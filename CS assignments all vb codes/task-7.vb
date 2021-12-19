Module Module1

    Sub Main()


        Dim Str, FStr As String
        Dim first2, last2 As String


        Str = ""
        FStr = ""
        first2 = ""
        last2 = ""


        Console.Write("Enter string to be processed : ")
        Str = Console.ReadLine
        If Len(Str) <= 2 Then
            Console.WriteLine("string is too short to be processed : " & Str)
        Else
            first2 = Left(Str, 2)
            last2 = Right(Str, 2)
            FStr = first2 & last2

            Console.WriteLine("Processed String is : " & FStr)

        End If

        Console.ReadKey()
    End Sub

End Module
