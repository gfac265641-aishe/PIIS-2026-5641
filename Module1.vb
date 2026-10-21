Module Module1

    Sub Main()
        '1. Deklarirane na promenlivi 
        Dim x1#, y1#, z1#, x2#, y2#, z2#, D#
        '2. Vhodni danni 
        Console.Write("Vuvedete x1 ")
        x1 = Console.ReadLine()
        Console.Write("Vuvedete y1 ")
        y1 = Console.ReadLine()
        Console.Write("Vuvedete z1 ")
        z1 = Console.ReadLine()
        Console.Write("Vuvedete x2 ")
        x2 = Console.ReadLine()
        Console.Write("Vuvedete y2 ")
        y2 = Console.ReadLine()
        Console.Write("Vuvedete z2 ")
        z2 = Console.ReadLine()
        '3. Izchislitelna chast 
        D = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2 + (z2 - z1) ^ 2)
        '4. Izvejdane na danni
        Console.WriteLine("D = " & D)
        Console.ReadKey()
    End Sub

End Module
