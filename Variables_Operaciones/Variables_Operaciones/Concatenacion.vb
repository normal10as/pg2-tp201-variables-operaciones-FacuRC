Module Concatenacion
    Sub main()
        '1.8. Crear un módulo llamado concatenación
        Dim NombreEmpresa, NombreCalle As String
        Dim AlturaCalle As Int16
        Dim FechaInicio As Date = "18/07/95  09:23:48"
        NombreEmpresa = " Pepe. "
        NombreCalle = " Paraguay. "
        AlturaCalle = 180
        Console.WriteLine("La empresa es: " & NombreEmpresa & "La direccion es: " & NombreCalle + " N " + AlturaCalle.ToString)
        Console.WriteLine("La fecha de inicio de actividades es: " & FechaInicio)
        Console.ReadKey()


    End Sub
End Module
