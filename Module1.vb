Module Module1

    Sub Main()
        '1. Deklarirane na promenlivi
        Dim Y!, x!, c!
        '2. Vhodni danni 
        Console.Write("vuvedete x = ")
        x = Console.ReadLine()
        Console.Write("vuvedete c = ")
        c = Console.ReadLine()
        '3. izchislitelna chast 
        If x > c Then Y = Math.Abs(x) Else Y = Math.Atan(x)
        '4. Izvejdane na rezultati
        Console.WriteLine("Y= " & Y)
        Console.ReadKey()
    End Sub







End Module
