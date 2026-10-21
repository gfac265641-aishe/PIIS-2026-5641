Module Module1

    Sub Main()
        ' 1. Deklarirane na promenlivi
        Dim S#, i%
        '2. Vhodni danni 
        '3, izchislitelna chst 
        S = 0
        For i = 1 To 1000
            S = S + i   'S+=i(sukraten zapis)
        Next
        '4. Izchislitelna chast 
        Console.WriteLine("S =" & S)
        Console.ReadKey()
    End Sub

End Module
