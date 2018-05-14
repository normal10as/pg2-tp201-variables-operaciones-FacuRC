Module Semanas
    Sub main()
        '1.7
        'Crear un módulo llamado semanas y en el declarar las siguientes constantes: días del año, días
        'laborables y días de la semana.
        Const diasanio As Integer = 365
        Const diaslaborales As Integer = 5
        Const diassemana As Integer = 7
        Dim cs As Integer
        Dim csl As Integer

        cs = diasanio / diassemana
        csl = cs * diaslaborales

        Console.WriteLine("La cantidad de semanas que tiene el año es:" & cs & "La cantidad de dias laborales es: " & csl)
        Console.ReadKey()
    End Sub
End Module
