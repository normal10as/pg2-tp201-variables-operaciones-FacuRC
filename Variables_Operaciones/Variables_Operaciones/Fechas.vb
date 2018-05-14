Module Fechas
    Sub main()
        '1.14. Crear un programa que muestre en líneas diferentes con sus correspondientes títulos los
        'siguientes valores en el momento de la ejecución: día del año, mes, hora y minutos
        Dim x As Date

        Console.WriteLine("Dia de año:" & x.Now.DayOfYear)
        Console.WriteLine("Mes de año:" & x.Now.Month)
        Console.WriteLine("Horas: " & x.Now.Hour)
        Console.WriteLine("Minutos: " & x.Now.Minute)

        Console.ReadKey()


    End Sub


End Module
