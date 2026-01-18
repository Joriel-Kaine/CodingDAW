namespace Tema6_Tarea06
{
    internal class Program
    {
        const int Tamano = 10;
        const string texto = "\nDebes introducir valores en el vector.";

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 6 - Tarea 6: Manuel MR ®\n" +
                              "═════════════════════════════\n\n");

            int[] numeros = new int[Tamano];
            int opcion;
            bool esLeido = false;

            do
            {
                opcion = OperacionesVector.Menu();

                switch (opcion)
                {
                    case 1:
                        OperacionesVector.LeerVector(numeros);
                        esLeido = true;
                        break;
                    case 2:
                        if (!esLeido)
                        {
                            Console.WriteLine(texto);
                        }
                        else
                        {
                            Console.WriteLine(OperacionesVector.GenerarTextoVector(numeros));
                        }
                        break;
                    case 3:
                        if (!esLeido)
                        {
                            Console.WriteLine(texto);
                        }
                        else
                        {
                            OperacionesVector.DesplazarValorVector(numeros);
                            Console.WriteLine(OperacionesVector.GenerarTextoVector(numeros));
                        }
                        break;
                }

            } while (opcion != 4);

            Console.WriteLine("\n\nFin del programa." +
                              "\nPulsa una tecla para salir...");
        }
    }
}
