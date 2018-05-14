Module ValorAproximado
    Sub main()
        '1.12. Ingresar un número real por teclado y mostrar su valor aproximado por exceso, su valor
        'aproximado por defecto y su valor redondeado.
        Dim x As Double

        Console.WriteLine("Ingrese un numero: ")
        x = Console.ReadLine()


        Console.WriteLine("Valor aproximado por exceso: " & System.Math.Ceiling(x))
        Console.WriteLine("Valor aproximado por defecto: " & System.Math.Floor(x))
        Console.WriteLine("Valor aproximado por redondeo: " & System.Math.Round(x))
        Console.ReadKey()

    End Sub
End Module
