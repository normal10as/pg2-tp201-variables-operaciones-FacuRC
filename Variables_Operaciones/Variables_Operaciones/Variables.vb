Module Variables
    '1. 1    1.2
    'Crear un módulo llamado “variables” en el proyecto “Hola Mundo”. Declarar variables de la
    'lista adjunta como locales (Dim) utilizando tipos de datos adecuados para cada información y
    'usando nombres que respeten las reglas de sintaxis, asignarles valores programáticamente y
    'luego mostrar por consola la leyenda que representa el dato seguido del valor del dato.
    ' nombre de una persona     /
    ' tipo de documento
    ' número de documento
    ' localidad
    ' fecha de nacimiento
    ' edad
    ' altura corporal
    ' estado civil
    ' si es argentino
    Sub Main()
        Dim Nombre, Tdocu, localidad, estcivil, nacion, nac As String
        Dim Ndocu, edad, altura As Integer
        Dim fnac As Date

        Nombre = "Facundo Cardozo"
        Tdocu = "D.N.I"
        localidad = "Posadas"
        estcivil = "Soltero"
        nacion = "Si"
        Ndocu = 36408008
        fnac = #7/18/1995#
        edad = 22
        altura = 1.75
        nac = "Argentino"

        Console.WriteLine("Nombre: " & Nombre & " Tipo de documento: " & Tdocu & " Numero de Documento: " & Ndocu & " Localidad: " & localidad & " 
 Fecha de nacimiento: " & fnac & "  Edad: " & edad & "  Altura Corporal: " & altura & "  Estado Civil: " & estcivil &
" Nacionalidad: " & nac)
        Console.ReadKey()
    End Sub

End Module
