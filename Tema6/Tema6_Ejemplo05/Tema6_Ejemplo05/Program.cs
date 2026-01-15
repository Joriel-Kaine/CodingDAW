namespace Tema6_Ejemplo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 6 - Ejemplo 5: Manuel MR ®\n" +
                              "═══════════════════════════════\n\n");

            // Definimos y creamos los vectores
            const int Tamano = 4;
            string[] vectorAlumnos = new string[Tamano];
            int[] vectorNotas = new int[Tamano];

            int opcion;

            do
            {
                opcion = FuncionesAlumnos.Menu();

                switch (opcion)
                {
                    case 1:
                        FuncionesAlumnos.LeerAlumnosYNotas(vectorAlumnos, vectorNotas);
                        break;
                    case 2:
                        Console.WriteLine(FuncionesAlumnos.MostrarAlumnosYNotas(vectorAlumnos, vectorNotas));
                        break;
                    case 3:
                        Console.Write("\nIntroduce el nombre del alumno a buscar: ");
                        string nombre = Console.ReadLine();
                        int posicion = FuncionesAlumnos.BuscarAlumno(vectorAlumnos, nombre);

                        if (posicion >= 0)
                        {
                            Console.WriteLine($"Alumno: {vectorAlumnos[posicion]} Nota: {vectorNotas[posicion]}");
                        }
                        else
                        {
                            Console.WriteLine("\nNo se ha encontrado el alumno.");
                        }
                        break;
                    case 4:
                        FuncionesAlumnos.OrdenarVectoresPorNotas(vectorAlumnos, vectorNotas);
                        break;
                    case 5:
                        FuncionesAlumnos.OrdenarVectoresPorNombres(vectorAlumnos, vectorNotas);
                        break;
                }

            } while (opcion != 6);

            Console.WriteLine("\n\nFin del programa.\n" +
                              "Pulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}

