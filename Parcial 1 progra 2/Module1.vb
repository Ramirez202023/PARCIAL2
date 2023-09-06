Module Module1

    Sub Main()
        'Se nuestra las opciones que se pueden realizar
        Console.WriteLine("Hola, digita 1 para saber el gentilicio de un pais o 2 para saber la especie de un animal")
        Dim eleccion As Integer 'Se declara la variable que almacenara la eleccion
        Dim pais As String ' Se declara la variable que almacenra el pais seleccionado
        'Se declara la lista de paises disponibles 
        Dim pais1 As String = "ARABIA SAUDITA"
        Dim pais2 As String = "BELGICA"
        Dim pais3 As String = "MEXICO"
        Dim pais4 As String = "ESTADOS UNIDOS"
        Dim pais5 As String = "ARGENTINA"
        Dim animal As String 'Se declara la variable que almacenara el nombre de animal seleccionado
        'Se declara la lista de animales disponibles
        Dim animal1 As String = "TIGRE"
        Dim animal2 As String = "BALLENA"
        Dim animal3 As String = "AGUILA"
        Dim animal4 As String = "PERRO"
        Dim animal5 As String = "ELEFANTE"
        eleccion = Console.ReadLine
        If eleccion = 1 Then
            Console.WriteLine("Paises:")
            Console.WriteLine(pais1)
            Console.WriteLine(pais2)
            Console.WriteLine(pais3)
            Console.WriteLine(pais4)
            Console.WriteLine(pais5)
            Console.WriteLine("Digite el nombre del pais segun la lista")
            pais = Console.ReadLine.ToUpper() 'Lee la opcion de pais seleccionado
            'Compara el pais digitado con los disponibles de la lista y si lo encuentra devuelve su gentilicio
            If pais = pais1 Then
                Console.WriteLine("El gentilicio es: Saudi")
            ElseIf pais = pais2 Then
                Console.WriteLine("El gentilicio es: Belga")
            ElseIf pais = pais3 Then
                Console.WriteLine("El gentilicio es: Mexicano")
            ElseIf pais = pais4 Then
                Console.WriteLine("El gentilicio es: Estadounidense")
            ElseIf pais = pais5 Then
                Console.WriteLine("El gentilicio es: Argentino")
            Else
                Console.WriteLine("Error! Nombre del pais no esta en la lista") ' si no encuentra el pais digitado devuelve error
            End If

        ElseIf eleccion = 2 Then
            Console.WriteLine("Animales:")
            Console.WriteLine(animal1)
            Console.WriteLine(animal2)
            Console.WriteLine(animal3)
            Console.WriteLine(animal4)
            Console.WriteLine(animal5)
            Console.WriteLine("Digite el nombre del animal segun la lista")
            animal = Console.ReadLine.ToUpper() 'Lee la opcion de animal seleccionado
            'Compara el animal digitado con los disponibles de la lista y si lo encuentra devuelve su especie
            If animal = animal1 Then
                Console.WriteLine("La especie del animal es: Felino")
            ElseIf animal = animal2 Then
                Console.WriteLine("La especie del animal es: Mamifero")
            ElseIf animal = animal3 Then
                Console.WriteLine("La especie del animal es: Ave")
            ElseIf animal = animal4 Then
                Console.WriteLine("La especie del animal es: Canino")
            ElseIf animal = animal5 Then
                Console.WriteLine("La especie del animal es: Mamifero")
            Else
                Console.WriteLine("Error! Nombre del animal no esta en la lista") 'si no encuentra animal digitado decuelve error
            End If
        Else
            Console.WriteLine("Error, la opcion seleccionada es incorrecta o no se encuentra") 'Si no encuentra una opcion correcta devuelve error
        End If
        Console.ReadLine()
        Console.Clear()
        Console.WriteLine("Integrantes:")
        Console.WriteLine("Hugo Nelson Ramirez Perez Carnet: RP3440012019")
        Console.WriteLine("Francisco Salvador Moreno Garcia Carnet: MG1250012022")
        Console.ReadLine()
    End Sub

End Module
