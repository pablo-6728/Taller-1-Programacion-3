Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("     Herramientas de Programación Aplicadas III     ")
        Console.WriteLine("     Equipo #04                      15/04/2021     ")
        Console.WriteLine("Facilitador(a): Anna Araba de Ruiz" & "     Fecha: 29 de abril del 2021       ")
        Console.WriteLine(Chr(13) + Chr(10) + "               Integrantes:")
        Console.WriteLine("           LUQUE, JULIO" & " 08-0961-001454")
        Console.WriteLine("           DIEPPA, LEONARDO" & "  08-0928-000410")
        Console.WriteLine("           PALADINO, PABLO" & "  E-8-165038")
        Console.WriteLine("           TRIANES, MOCHETH" & "  8-920-2031")
        Console.WriteLine("Versión de visual: versión 2019 .NET Framework 4.7.2")
        Console.WriteLine("")
        Console.WriteLine("TOCA UNA TECLA PARA CONTINUAR")
        Console.WriteLine("")
        System.Console.ReadKey()
        'DECLARACIÓN DE VARIABLES
        Const X As Integer = 100 'CONSTANTE PARA ARREGLO Y MATRIZ
        Dim Notas(X, X) As Integer
        Dim Asignaturas(X) As String
        Dim i, W As Integer
        Dim cant1, cant2 As Integer
        Dim aprov As Integer
        Dim reprov As Integer
        Dim alto(X) As Integer
        Dim bajo(X) As Integer
        Dim A(X), B(X) As Integer
        Dim Promedio(X) As Single


        'FOR DE LECTURAS DE VARIABLES
        Console.WriteLine("CUANTAS ASIGNATURAS VA A RIGISTRAR")
        cant1 = Console.ReadLine()
        Console.WriteLine("Ingrese la Cantidad de Estudiantes Matriculados")
        cant2 = Console.ReadLine()
        For i = 0 To (cant1 - 1)
            Console.WriteLine("Digite EL nombre de la Asignatura " & i + 1)
            Asignaturas(i) = Console.ReadLine()
            For W = 0 To (cant2 - 1)
                Console.WriteLine("Nota del Estudiante " & (W + 1))     'La matriz esta hecha de tal forma que las filas son las notas y las columnas los estudiantes
                Notas(i, W) = Console.ReadLine()
            Next

        Next
        'PROCEDIMIENTO PARA CALCULAR EL PROMEDIO

        For i = 0 To (cant1 - 1)
            alto(i) = 0
            bajo(i) = 100
            aprov = 0
            reprov = 0
            For W = 0 To (cant2 - 1)
                'If para calcular las Notas ALTAS Y BAJAS
                If (Notas(i, W) > alto(i)) Then
                    alto(i) = Notas(i, W)

                End If
                If (Notas(i, W) < bajo(i)) Then
                    bajo(i) = Notas(i, W)
                End If
                '--------------------------------------------------
                'If para calcular las notas Aprobadas y Reprobadas
                If (Notas(i, W) >= 71) Then
                    aprov = aprov + 1
                    A(i) = aprov


                Else
                    reprov = reprov + 1
                    B(i) = reprov

                End If


            Next
        Next

        'CALCULO DEL PROMEIO DE LOS ESTUDIANTES
        For W = 0 To (cant2 - 1)
            Dim temp As Integer
            For i = 0 To (cant1 - 1)
                temp = temp + Notas(i, W)
            Next
            Promedio(i) = (temp / cant1)
            temp = 0
        Next

        Console.WriteLine("------------------------------------")
        For i = 0 To (cant2 - 1)
            For W = 0 To (cant1 - 1)
                Console.WriteLine("El promedio del estudiante {0} es {1}", i, Promedio(i))
            Next
        Next


        'ESCRITURA DE LA MATRIX
        For i = 0 To (cant1 - 1)
            Console.WriteLine("------------------------------------")
            Console.WriteLine("")
            Console.WriteLine(Asignaturas(i))
            For W = 0 To (cant2 - 1)
                Console.WriteLine(Notas(i, W) & "")
            Next
            Console.WriteLine("")
            Console.WriteLine("La cantidad total de estudiantes matriculados en la materia de " & Asignaturas(i) & " es " & W)
            Console.WriteLine("La nota más alta es: " & alto(i))
            Console.WriteLine("La nota más baja es: " & bajo(i))
            Console.WriteLine("La cantidad de alumnos aprobados es: " & A(i))
            Console.WriteLine("La cantidad de alumnos reprobados es :" & B(i))
        Next
        Console.ReadLine()
    End Sub
End Module
