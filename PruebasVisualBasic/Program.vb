Imports System

Module Program
    Dim objeto1 As New funciones()
    Sub main()
        'Console.WriteLine(objeto1.factorial())
        Console.WriteLine(objeto1.factorialFor())
    End Sub

End Module

Public Class funciones
    Public Function factorial() As Integer
        Dim numero, salida, it As Integer

        Console.WriteLine("Ingrese un numero para calcular el factorial: ")
        numero = Convert.ToInt32(Console.ReadLine())
        it = 1
        salida = 1

        While it <= numero
            salida *= it
            it += 1
        End While
        Return salida
    End Function

    Public Function factorialFor() As Integer
        Console.WriteLine("-------Factorial For--------")

        Dim numero, i, salida As Integer
        Console.WriteLine("Ingrese un numero: ")
        numero = Convert.ToInt32(Console.ReadLine())
        salida = 1

        For i = 1 To numero
            salida *= i
        Next
        Return salida
    End Function

End Class