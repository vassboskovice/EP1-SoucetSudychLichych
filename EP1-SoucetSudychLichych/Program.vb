Module Module1

    Sub Main()
        Dim PocetCisel As Object
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White
        Console.Write(" Ahoj kolik ��sel chce�? ")
        PocetCisel = Console.ReadLine
        If IsNumeric(PocetCisel) = False Then
            ' zde zji��ujeme zdali je nebo nen� v objektu
            ' schov�no ��slo
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(" Chyba nezadali jste ��slo!! ")
            Console.ReadKey()
            Main()
        End If
        Dim CisteCislo As Integer = PocetCisel
        If CisteCislo <= 0 Then
            ' zde zji��ujeme zdali je ��slo nula
            ' a nebo z�porn�
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(" Chyba nezadali jste kladn� ��slo!! ")
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
        Console.WriteLine(" Sou�et sud�ch je: " & SoucetSudych)
        Console.WriteLine(" Sou�et lich�ch je: " & SoucetLichych)
        Console.ReadKey()



    End Sub

End Module
