Module Media
    Sub main()
        '1.6
        'Crear un programa que calcule la sumatoria y la media de cuatro números enteros ingresados por teclado.
        Dim a, b, c, d, s, m As Integer
        Console.Write("ingrese primer numero: ")
        a = Console.ReadLine()
        Console.Write("ingrese segundo numero: ")
        b = Console.ReadLine()
        Console.Write("ingrese tercer numero: ")
        c = Console.ReadLine()
        Console.Write("ingrese cuarto numero: ")
        d = Console.ReadLine()

        s = a + b + c + d

        Console.WriteLine("El resultado de la suma es: " & s & " Y la media es: " & s / 4)
        Console.ReadKey()
    End Sub
End Module
