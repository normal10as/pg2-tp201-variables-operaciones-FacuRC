Module Ecuacion
    '1.5
    'Crear un programa que resuelva la siguiente ecuación
    Sub main()
        Dim a, b, c, x As Int16
        a = 1
        b = 5
        c = 2

        x = (b ^ 2 - 4 * a * c) / (2 * a)
        Console.WriteLine("El resultado de la ecuacion es: " & x)
        Console.ReadKey()

    End Sub
End Module
