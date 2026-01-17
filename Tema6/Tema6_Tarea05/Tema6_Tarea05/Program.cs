namespace Tema6_Tarea05
{
    internal class Program
    {
        const int Tamano = 10;
        const string texto = "\nDebes introducir valores en el vector.";

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 6 - Tarea 5: Manuel MR ®\n" +
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
                            int valor = 0;
                            valor = OperacionesVector.LeerNumero("\nIntroduce el valor que quieres buscar: ");
                            int posicion = OperacionesVector.BuscarValorVector(numeros, valor);

                            if (posicion >= 0)
                            {
                                Console.WriteLine($"\nLa primera posición del valor es: " +
                                                  $"{posicion}");
                            }
                            else
                            {
                                Console.WriteLine("\nNo se ha encontrado el valor introducido en el vector.");
                            }

                            Console.WriteLine($"\nEl número de veces que aparece el valor es: " +
                                              $"{OperacionesVector.ValorRepetidoVector(numeros, valor)}");
                        }
                        break;
                }

            } while (opcion != 4);

            Console.WriteLine("\n\nFin del programa." +
                              "\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
