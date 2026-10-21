Module Module1

    Sub Main()
        '1. Деклариране на данни 
        Dim P%, i%, N%
        ' Въвеждане на данни 
        Console.WriteLine("vuvedi N= ")
        N = Console.ReadLine()
        P = 1
        '3. Изчислителна част 
        For i = 1 To N
            P = P * i
        Next
        Console.WriteLine("p=" & P)
        Console.ReadKey()
    End Sub

End Module
