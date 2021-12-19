Module Module1

    Sub Main()



        Dim str1 As String
        Dim char1 As Char
        Dim allalphabets As Boolean
        Dim i As Integer

        allalphabets = True

        str1 = ""
        char1 = ""
        i = 0

        Console.Write(" Enter string:")
        str1 = Console.ReadLine

        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1)
            char1 = UCase(char1)

            If char1 < "A" Or char1 > "Z" Then
                allalphabets = False
            End If

        Next

        If allalphabets = False Then
            Console.WriteLine(" All characters are not alphabets ")
        Else
            Console.WriteLine(" All characters are alphabets ")
        End If

        Console.ReadKey()

    End Sub

End Module
