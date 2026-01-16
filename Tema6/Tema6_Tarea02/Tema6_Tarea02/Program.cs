namespace Tema6_Tarea02
{
    internal class Program
    {
        const int Tamano = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 6 - Tarea 2: Manuel MR ®\n" +
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
                        Console.WriteLine(OperacionesVector.MostrarVector(numeros));
                        break;
                    case 3:
                        Console.WriteLine($"La media es: {OperacionesVector.MediaVector(numeros)}");
                        break;
                }

            } while (opcion != 4);

            Console.WriteLine("\n\nFin del programa." +
                              "Pulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
