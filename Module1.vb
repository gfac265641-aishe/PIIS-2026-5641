Module Module1

    Sub Main()
        ' 1. Deklarirane na promenlivi
        Dim S#, i%, N%, M%
        '2. vhodni danni
        Console.WriteLine("Vuvedete stoinost za N = ")
        N = Console.ReadLine()
        Console.WriteLine("Vuvedete stoinost za M = (M < N) ")
        M = Console.ReadLine()
        '3. Izchislitelna chast
        S = 0
        For i = M To N
            S = S + i / i 'S+=1/i
        Next
        ' izvejdane na ekrana
        Console.WriteLine("S=" & S)
        Console.ReadKey()
    End Sub

End Module
