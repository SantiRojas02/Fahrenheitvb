Module Fahrenheit

    Sub Main(args As String())
        'Declaracion de variables
        Dim temperaturaCelcius As Single
        Dim temperaturaFahrenheit As Single
        'Ingresamos los datos
        Console.Write("Ingresar temperatura en grados celcius: ")
        temperaturaCelcius = Console.ReadLine()
        ' Operaciones
        temperaturaFahrenheit = temperaturaCelcius * 1.8 + 32
        ' Resultado
        Console.WriteLine("Equivale a {temperaturaFahrenheit} grados Fahrenheit")

    End Sub

End Module
