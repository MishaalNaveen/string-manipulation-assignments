Module Module1

    Sub Main()


        Dim Str, Str1, Str2, Str3, FStr As String

        Str = ""
        Str1 = ""
        Str2 = ""
        Str3 = ""
        FStr = ""


        Console.Write("Enter string to be processed : ")

        Str = Console.ReadLine
        Str1 = Right(Str, 1)
        If Len(Str) < 3 Then
            Console.WriteLine(Str)
        Else
            If Str1 = "g" Then
                FStr = Str & "ly"
            Else
                FStr = Str & "ing"
            End If
            Console.WriteLine("Processed String is : " & FStr)
        End If

        Console.ReadKey()
    End Sub

End Module
