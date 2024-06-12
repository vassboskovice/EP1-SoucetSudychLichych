Imports System

Module Program
    Sub Main()

        Console.Write("Zadejte celkový poèet èísel")
        Dim totalNumbers As Integer = Integer.Parse(Console.ReadLine())

        Dim numbers(totalNumbers - 1) As Integer

        For i As Integer = 0 To totalNumbers - 1
            Console.Write("Zadejte èíslo" & (i + 1) & ": ")
        Next
        Console.WriteLine("Zadaná èísla jsou: ")
        For Each num As Integer In numbers
            Console.WriteLine(num)
        Next
        Console.WriteLine("Stisknìte libovolnou klávesu pro ukonèení.")
        Console.ReadKey()
   
    Console.WriteLine("Zadej nìjaké celé èíslo")
Dim a As Integer = Console.ReadLine()
If a <= 0.1 Then
    Console.WriteLine("Zadal jsi èíslo, které není celé ")
End If
Console.WriteLine("Dìkuji za zadání")
Console.ReadKey()
    
    
    
    End Sub
End Module
