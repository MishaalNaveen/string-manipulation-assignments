Module Module1

    Sub Main()
        Dim str1 As String
        Dim i, j, count, max As Integer
        Dim char1, char2, thischar As Char

        str1 = ""
        char1 = ""
        char2 = ""
        thischar = ""
        i = 0
        j = 0
        count = 0
        max = 0

        Console.Write("enter string to process : ")
        str1 = Console.ReadLine

        For i = 1 To Len(str1)
            count = 0
            char1 = Mid(str1, i, 1)

            For j = 1 To Len(str1)
                char2 = Mid(str1, j, 1)
                If char2 = char1 Then
                    count = count + 1
                End If
            Next
            If count > max Then
                max = count
                thischar = char1
            End If

        Next

        Console.WriteLine(" the character that appeared the most is: " & thischar)
        Console.WriteLine(" it is repeated: " & max & " times.")
        Console.ReadKey()
    End Sub

End Module
