namespace Tema7_Tarea03
{
    internal class Program
    {
        const string Titulo = "\nTema 7 - Tarea 3: Manuel MR ®\n" +
                              "═════════════════════════════\n\n";

        static void Main(string[] args)
        {
            Console.WriteLine(Titulo);

            ListaAlumnos listaAlumnos = new();
            int opcion;

            do
            {
                opcion = FuncionesInterfaz.Menu();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(listaAlumnos.MostrarNombresListaAlumnos());
                        break;
                    case 2:
                        FuncionesInterfaz.LeerDatosAlumno(listaAlumnos);
                        break;
                    case 3:
                        string nombre = FuncionesInterfaz.LeerNombre();

                        Console.WriteLine();
                        Console.WriteLine(listaAlumnos.MostrarDatosAlumno(nombre));
                        break;
                    case 4:
                        FuncionesInterfaz.AddNotaAlumno(listaAlumnos);
                        break;
                    case 5:
                        nombre = FuncionesInterfaz.LeerNombre();

                        listaAlumnos.EliminarAlumno(nombre);
                        break;
                }

            } while (opcion != 6);

            Console.WriteLine("\n\nFin del programa." +
                              "\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
