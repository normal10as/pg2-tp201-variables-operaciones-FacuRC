Module Aritmetica
    '1.4
    '    Crear un módulo llamado aritmética que Declare y asigne dos valores enteros y dos valores de
    'punto flotante. Luego demostrar las operaciones aritméticas básicas
    Sub main()
        Dim a, b As Int16
        Dim c, d As Single

        a = 125
        b = 65
        c = 1.25
        d = 7.39

        Console.WriteLine("Resta de enteros : " & a - b)
        Console.WriteLine("Suma de flotantes : " & c + d)
        Console.WriteLine("Division de un entero y un flotante : " & a / c)
        Console.WriteLine("Multiplicacion de un entero y un flotante : " & b * d)
        Console.ReadKey()


    End Sub

End Module
