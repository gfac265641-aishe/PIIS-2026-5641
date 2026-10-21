Module Module1

    Sub Main()
        '1. Деклариране на променливи и константи
        Dim R As Double, S As Double, P As Double
        Const pi As Double = 3.14159
        '2. Входни данни
        Console.WriteLine("Vuvedete radius = ")
        R = Console.ReadLine()
        '3. Изчислителна част 
        S = pi * R ^ 2 ' лице на окръжност 
        P = 2 * pi * R ' периметър на окръжност 
        '4. Извеждане на резултати 
        Console.WriteLine("Liceto e S =" & S)
        Console.WriteLine("Perimerura P = " & P)
        Console.ReadKey() ' оставя програмата отворена
    End Sub

End Module
