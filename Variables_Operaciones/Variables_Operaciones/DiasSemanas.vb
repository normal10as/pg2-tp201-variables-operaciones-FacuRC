Module DiasSemanas

    Enum DiasSemana As Integer
        Domingo
        Lunes
        Martes
        Miercoles
        Jueves
        Viernes
        Sabado
    End Enum
    Sub main()
        '1.17. Al programa anterior, utilizando una enumeración para los días de la semana en español,
        'mostrar que día que corresponde al resultado
        Dim fecha, x As Date
        Dim dias As Integer

        Console.WriteLine("Ingrese una fecha:")
        fecha = Console.ReadLine
        Console.WriteLine("Ingrese una cantidad de dias a sumar: ")
        dias = Console.ReadLine
        Console.WriteLine("El resultado es:" & fecha.AddDays(dias))
        Select Case x.DayOfWeek
            Case DiasSemana.Domingo
                Console.WriteLine("Domingo")
            Case DiasSemana.Lunes
                Console.WriteLine("Lunes")
            Case DiasSemana.Martes
                Console.WriteLine("Martes")
            Case DiasSemana.Miercoles
                Console.WriteLine("Miercoles")
            Case DiasSemana.Jueves
                Console.WriteLine("Jueves")
            Case DiasSemana.Viernes
                Console.WriteLine("Viernes")
            Case DiasSemana.Sabado
                Console.WriteLine("Sabado")
        End Select
        Console.ReadKey()

    End Sub
End Module
