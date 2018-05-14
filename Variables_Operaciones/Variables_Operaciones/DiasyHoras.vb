Module DiasyHoras
    Sub main()
        '1.15. Crear un programa que lea separadamente un número de día (1 a 31) y una hora (0 a 24).
        'Con esos valores crea una variable de tipo Date usando el mes y año actual y mostrarla.

        Dim dia, hora As Byte
        Dim fecha As Date
        Console.WriteLine("Ingrese un dia del 1 al 31: ")
        dia = Console.ReadLine
        Console.WriteLine("Ingrese una hora de 0 a 24:  ")
        hora = Console.ReadLine

        Console.WriteLine("Fecha y hora del ordenador: " & fecha.Now)
        Console.WriteLine("Fecha ingresada: " & dia & "/" & fecha.Now.Month & "/" & fecha.Now.Year)
        Console.WriteLine("Hora ingresada: " & hora & ":" & fecha.Now.Minute & ":" & fecha.Now.Second)
        Console.ReadKey()
    End Sub
End Module
