Module Module1

    Sub Main()
        Dim Z(,) As Double
        Dim M%, N%, i%, j%

        Do
            Console.Write("Max M=8, M=")
            M = Console.ReadLine()
        Loop Until M > 1 And M <= 8

        Do
            Console.Write("Max N=8, N=")
            N = Console.ReadLine()
        Loop Until N > 1 And N <= 8

        ReDim Z(M, N)
        For i = 1 To M
            For j = 1 To N
                Console.Write("Z(" & i & "," & j & ")=")  'Z(i,j)=46
                Z(i, j) = Console.ReadLine()
            Next
        Next

        'a/ suma na vsichki elementi pod masiva
        Dim S#
        S = 0
        For i = 1 To M
            For j = 1 To N
                S = S + Z(i, j)
            Next
        Next
        Console.WriteLine("S=" & S)
        Console.ReadKey()

        'b/ proizvedenie na nenulevi elementi 
        Dim P As Double
        P = 1
        For i = 1 To M
            For j = 1 To N
                If Z(i, j) <> 0 Then P = P * Z(i, j)
            Next
        Next
        Console.WriteLine("P=" & P)
        Console.ReadKey()

        'v/ maksimum na matricata i lokaciq 
        Dim Max#
        Dim imax%, jmax%
        Max = Z(1, 1)
        imax = 1 : jmax = 1
        For i = 1 To M
            For j = 1 To N
                If Z(i, j) > Max Then
                    Max = Z(i, j)
                    imax = i
                    jmax = j
                End If
            Next
        Next
        Console.WriteLine("max=Z(" & imax & "," & jmax & ")=" & Max) 'Z(4,4) = 9
        Console.ReadKey()

        'g/ minimum na matricata i lokaciq 
        Dim Min#
        Dim imin%, jmin%
        Min = Z(1, 1)
        imin = 1 : jmin = 1
        For i = 1 To M
            For j = 1 To N
                If Z(i, j) < Min Then
                    Min = Z(i, j)
                    imin = i
                    jmin = j
                End If
            Next
        Next
        Console.WriteLine("Min=Z(" & imin & "," & jmin & ")=" & Min) 'Z(2,3) = -10
        Console.ReadKey()
        'd/ sredno aritmetichno na polojitelnite elementi nad glabniq diagonal, ako matricata e kvadratna

        If M = N Then
            Dim Ap#, Sp#, Np%
            Sp = 0 : Np = 0
            For i = 1 To M
                For j = 1 To N
                    If i < j Then
                        If Z(i, j) > 0 Then
                            Sp = Sp + Z(i, j)
                            Np = Np + 1

                        End If
                    End If

                Next
            Next
            If Np > 0 Then
                Ap = Sp / Np
                Console.WriteLine("Ap=" & Ap)
                Console.ReadKey()
            Else
                Console.WriteLine("Няма положителни елементи над главния диагонал")
                Console.ReadKey()
            End If
        Else
            Console.WriteLine("Матрицата не е квадратна")
            Console.ReadKey()
        End If
        'e/ maksimum pod vtorostepenen diagonal
        Dim max2#
        max2 = Z(M, N)
        For i = 1 To M

            For j = 1 To N
                If Z(i, j) > max2 Then max2 = Z(i, j)
            Next
        Next
            Console.WriteLine("Мах под второстепенен диагонал=" & max2)
        Console.ReadKey()

        'j/ ako matricata ima cheten broy stulbove, namerete sumaja na elementite nad glavniq diagonal, /zadacha na qna
        If N Mod 2 = 0 Then

            For i = 1 To M
                For j = 1 To N
                    If j <= N / 2 Then
                        Z(i, j) = Z(i, j) + S
                    Else
                        Z(i, j) = Z(i, j) - S
                    End If

                Next
            Next

        End If
        Console.WriteLine("Резултатната матрица е:")
        For i = 1 To M
            For j = 1 To N
                Console.Write(Z(i, j) & "    ")
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub


End Module
