using System.Numerics;

namespace Tema6_Tarea01
{
    internal class Program
    {
        const int Tamano = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 6 - Tarea 1: Manuel MR ®\n" +
                              "═════════════════════════════\n\n");

            int[] numeros = new int[Tamano];
            int opcion;

            do
            {
                opcion = OperacionesVector.Menu();

                switch (opcion)
                {
                    case 1:
                        OperacionesVector.LeerVector(numeros);
                        break;
                    case 2:
                        OperacionesVector.MostrarVector(numeros);
                        break;
                }

                Console.WriteLine("\nFin del programa.");

            } while (opcion != 3);

            Console.WriteLine($"\n{OperacionesVector.MostrarVector(numeros)}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
