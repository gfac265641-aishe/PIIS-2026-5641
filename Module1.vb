Imports System.Data.SqlClient

Module Module1

    Sub Main()
        ' 1. Deklarirane na promenlivi
        Dim V1, T1, V2, T2, V, T As Single
        '2. Vhodni danni 
        Console.Write("Vuvedete V1= ")
        V1 = Console.ReadLine()
        Console.Write("Vuvedete T1= ")
        T1 = Console.ReadLine()
        Console.Write("Vuvedete V2= ")
        V2 = Console.ReadLine()
        Console.Write("Vuvedete T2= ")
        T2 = Console.ReadLine()
        '3. Izchislitelna chast 
        V = V1 + V2
        T = (V1 * T1 + V2 * T2) / V
        '4. Izvejdane na rezultati 
        Console.WriteLine("Vuvedete V = " & V)
        Console.WriteLine("Vuvedete T = " & T)
        Console.ReadKey()




    End Sub

End Module
