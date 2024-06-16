Module Module1

    Sub Main()
        Dim PocetCisel As Object
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White
        Console.Write(" Ahoj kolik ËÌsel chceö? ")
        PocetCisel = Console.ReadLine
        If IsNumeric(PocetCisel) = False Then
            ' zde zjiöùujeme zdali je nebo nenÌ v objektu
            ' schov·no ËÌslo
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(" Chyba nezadali jste ËÌslo!! ")
            Console.ReadKey()
            Main()
        End If
        Dim CisteCislo As Integer = PocetCisel
        If CisteCislo <= 0 Then
            ' zde zjiöùujeme zdali je ËÌslo nula
            ' a nebo z·pornÈ
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(" Chyba nezadali jste kladnÈ ËÌslo!! ")
            Console.ReadKey()
            Main()
        End If
        Dim Nahoda
        Dim SoucetSudych, SoucetLichych As Double
        Console.Clear()
        For x = 1 To CisteCislo
            Nahoda = Rnd() * 1000
            Console.WriteLine(Nahoda)
            If Nahoda Mod 2 = 0 Then
                SoucetSudych += Nahoda
            Else
                SoucetLichych += Nahoda
            End If
        Next
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine(" SouËet sud˝ch je: " & SoucetSudych)
        Console.WriteLine(" SouËet lich˝ch je: " & SoucetLichych)
        Console.ReadKey()



    End Sub

End Module
