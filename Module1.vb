Module Module1

    Sub Main()
        ' 1. Deklarirane na promenlivi
        Dim a#, b#, S#, c$
        ' 2. Vhodni danni 
        Console.Write("Vuvedete purva stoinost")
        a = Console.ReadLine()
et1:    Console.Write("Vuvedete vtora stoinost")
        b = Console.ReadLine()
et2:    Console.Write("Vuvedete operaciq (+,-,*,/)")
        c = Console.ReadLine()
        '3. Izchislitelna chst 
        S = 0
        Select Case c
            Case "+"
                S = a + b
            Case "-"
                S = a - b
            Case "*"
                S = a * b
            Case "/"
                If b <> 0 Then
                    S = a / b
                Else
                    Console.WriteLine("Vuvedete chislo razlichno ot 0")
                    GoTo et1
                End If
            Case Else
                Console.WriteLine("vuvedete pravilna operaciq")
                GoTo et2
        End Select
        '4. Izvejdane na rezultati 
        Console.WriteLine(" S = " & a & c & b & " = " & S)
        Console.ReadKey()


    End Sub

End Module
