namespace Tema6_Ejemplo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 6 - Ejemplo 4: Manuel MR ®\n" +
                              "═══════════════════════════════\n\n");

            // Declaramos el vector directamente con los valores.
            int[] notas = { 0, 0, 0, 0, 0 };

            int opcion;

            do
            {
                opcion = Funciones.Menu();

                switch (opcion)
                {
                    case 1:
                        Funciones.LeerNotas(notas);
                        break;
                    case 2:
                        Console.WriteLine(Funciones.MostrarNotas(notas));
                        break;
                    case 3:
                        Funciones.AumentarNotas(notas);
                        break;
                    case 4:
                        double notaMedia = Funciones.CalcularNotaMedia(notas);
                        Console.WriteLine($"\nLa nota media es {notaMedia}");
                        break;
                }

            } while (opcion != 5);

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}

