namespace Tema6_Tarea12
{
    internal class Program
    {
        const string Texto = "\nDebes introducir primero el número de elementos.",
                     TextoLista = "\nDebes introducir valores en la lista.",
                     Titulo = "\nTema 6 - Tarea 12: Manuel MR ®\n" +
                              "══════════════════════════════\n\n";

        static void Main(string[] args)
        {
            Console.WriteLine(Titulo);

            List<int> lista1 = new(), lista2 = new(), listaIntercalada = new();
            int opcion, numElementos1 = 0, numElementos2 = 0;
            bool esLeido1 = false, esLeido2 = false;

            do
            {
                opcion = OperacionesList.Menu();

                switch (opcion)
                {
                    case 1:
                        numElementos1 = OperacionesList.LeerNumero("Introduce el número de elementos de la primera lista: ");

                        numElementos2 = OperacionesList.LeerNumero("Introduce el número de elementos de la segunda lista: ");
                        break;
                    case 2:
                        if (numElementos1 == 0)
                        {
                            Console.WriteLine(Texto);
                        }
                        else
                        {
                            lista1 = OperacionesList.LeerLista(numElementos1);
                            esLeido1 = true;
                        }
                        break;
                    case 3:
                        if (numElementos2 == 0)
                        {
                            Console.WriteLine(Texto);
                        }
                        else
                        {
                            lista2 = OperacionesList.LeerLista(numElementos2);
                            esLeido2 = true;
                        }
                        break;
                    case 4:
                        if (!esLeido1 || !esLeido2)
                        {
                            Console.WriteLine(TextoLista);
                        }
                        else
                        {
                            listaIntercalada = OperacionesList.IntercalarLista(lista1, lista2);
                        }
                        break;
                    case 5:
                        if (!esLeido1 || !esLeido2)
                        {
                            Console.WriteLine(TextoLista);
                        }
                        else
                        {
                            Console.WriteLine($"La primera lista tiene lo siguientes elementos:\n" +
                                          $"{OperacionesList.MostrarLista(lista1)}\n" +
                                          $"La segunda lista tiene los siguientes elementos:\n" +
                                          $"{OperacionesList.MostrarLista(lista2)}\n" +
                                          $"Lista intercalada de la primera y segunda lista:\n" +
                                          $"{OperacionesList.MostrarLista(listaIntercalada)}");
                        }
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(Titulo);

            } while (opcion != 6);

            Console.WriteLine("\n\nFin del programa." +
                              "\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
