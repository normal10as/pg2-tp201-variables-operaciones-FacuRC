Module Interes
    Sub main()
        '1.10
        'Realizar un programa que dé como resultado los intereses producidos y el capital
        'acumulado de un monto m invertido a un interés anual r durante t días.
        Dim monto As Decimal
    Dim interesanual As Single
    Dim tiempo As UShort
    Dim interesproducido As Single

        Console.WriteLine("Ingrese    monto: ")
        monto = Console.ReadLine()
        Console.WriteLine("Ingrese interes anual: ")
        interesanual = Console.ReadLine()
        Console.WriteLine("Ingrese cantidad de dias : ")
        tiempo = Console.ReadLine()

        interesproducido = (monto * interesanual * tiempo) / (360 * 100)


        Console.WriteLine("El interes anual es: " & interesproducido)
        Console.WriteLine("Y el monto acumulado es: " & monto + interesproducido)
        Console.ReadKey()
        End Sub
End Module
