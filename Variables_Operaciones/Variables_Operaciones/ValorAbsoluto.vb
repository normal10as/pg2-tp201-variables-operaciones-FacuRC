Module ValorAbsoluto
    Sub main()
        '1.11. Ingresar un número por teclado y mostrar su valor absoluto, el resultado de elevarlo a la
        'décima potencia y su raíz cuadrada.
        Dim x As Double
        Dim b As Integer = 10

        Console.WriteLine("Ingrese un numero: ")
        x = Console.ReadLine()

        Console.WriteLine("El valor absoluto es: " & System.Math.Abs(x))
        Console.WriteLine("El numero elevado a 10: " & CLng(Math.Pow(x, b)))
        Console.WriteLine("La raiz cuadrada es: " & System.Math.Sqrt(x))


        Console.ReadKey()

    End Sub
End Module
