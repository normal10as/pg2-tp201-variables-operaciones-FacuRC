Module SumaFechas
    Sub main()
        '1.16. Crear un programa que se ingrese una fecha y un número dados de días, Mostrar como
        'resultado la fecha obtenida de sumar la cantidad de días a la fecha dada
        Dim fecha As Date
        Dim dias As Byte
        Console.WriteLine("Ingrese una fecha:")
        fecha = Console.ReadLine
        Console.WriteLine("Ingrese una cantidad de dias a sumar: ")
        dias = Console.ReadLine
        Console.WriteLine("El resultado es:" & fecha.AddDays(dias))
        Console.ReadKey()

    End Sub
End Module
