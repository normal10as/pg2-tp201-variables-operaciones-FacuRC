Module NumeroMayor
    Sub main()
        '1.13. Elabore un programa que lea tres números y muestre el mayor.
        Dim a, b, c, r As Int16
        Console.WriteLine("Ingrese numero a: ")
        a = Console.ReadLine
        Console.WriteLine("Ingrese numero b: ")
        b = Console.ReadLine
        Console.WriteLine("Ingrese numero c: ")
        c = Console.ReadLine

        r = System.Math.Max(a, b)

        Console.WriteLine("El mayor es: " & System.Math.Max(c, r))

        Console.ReadKey()

    End Sub
End Module
