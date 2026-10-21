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
        ' б) proixvedenie ot vsichki nenulevi elementi
        Dim P#
        P = 1
        For i = 1 To M
            If A(i) <> 0 Then
                P = P * A(i)

            End If
        Next
        Console.WriteLine("P=" & P)
        Console.ReadKey()
    End Sub

End Module
