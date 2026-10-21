Module Module1

    Sub Main()
        ' 1. Deklarirane na danni
        Dim A() As Double
        Dim M%, i%
        ' 2. Vuvejdane na danni
        Console.Write("vuvedi M=")
        M = Console.ReadLine()
        ReDim A(M)
        For i = 1 To M
            Console.Write("A(" & i & ")=") 'A(1)=...
            A(i) = Console.ReadLine()
        Next
        ' a) suma na vsichki elementi ot masiva
        Dim S#
        S = 0
        For i = 1 To M
            S = S + A(i)
        Next
        Console.WriteLine("S=" & S)
        Console.ReadKey()

        ' б) proivedenie ot vsichki nenulevi elementi
        Dim P#
        P = 1
        For i = 1 To M
            If A(i) <> 0 Then
                P = P * A(i)

            End If
        Next
        Console.WriteLine("P=" & P)
        Console.ReadKey()

        'в/ средно аритметично на положителни елементи 
        'dek.arirane na danni 
        Dim Ap#, Np%, Sp#
        ' vhodni danni 
        Sp = 0
        Np = 0
        Ap = 0
        For i = 1 To M
            If A(i) > 0 Then
                Sp = Sp + A(i) '0=0+10=10   10=10+9=19
                Np = Np + 1 '0=0+1=1  1=1+1
            End If
        Next

        Ap = Sp / Np

        If Np > 0 Then
            Console.WriteLine("Ap=" & Ap)
            Console.ReadKey()
        Else
            Console.WriteLine("Nqma polojitelni elementi")
            Console.ReadKey()
        End If
        'г/ максимум на елементите в масива
        Dim Max#, imax%
        Max = A(1) : imax = 1
        For i = 2 To M
            If A(i) > Max Then
                Max = A(i)
                imax = i
            End If

        Next
        Console.WriteLine("Maksimalen element A(" & imax & ")=" & Max) 'A(i)= Max
        Console.ReadKey()

        'д/ минимален на елементите в масива
        Dim Min#, imin%
        Min = A(1) : imin = 1
        For i = 2 To M
            If A(i) < Min Then
                Min = A(i)
                imin = i
            End If

        Next


    End Sub

End Module
