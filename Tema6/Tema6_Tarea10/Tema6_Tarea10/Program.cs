namespace Tema6_Tarea10
{
    internal class Program
    {
        const string texto = "Debes introducir valores en la lista.",
                     titulo = "\nTema 6 - Tarea 10: Manuel MR ®\n" +
                              "══════════════════════════════\n\n";

        static void Main(string[] args)
        {
            Console.WriteLine(titulo);

            List<int> listaNumeros = new(), listaPares1 = new(), listaPares2 = new();
            int opcion;
            bool esLeido = false;

            do
            {
                opcion = OperacionesList.Menu();

                switch (opcion)
                {
                    case 1:
                        OperacionesList.LeerLista(listaNumeros);
                        esLeido = true;
                        break;
                    case 2:
                        if (!esLeido)
                        {
                            Console.WriteLine(texto);
                        }
                        else
                        {
                            Console.WriteLine(OperacionesList.MostrarLista(listaNumeros));
                        }
                        break;
                    case 3:
                        if (!esLeido)
                        {
                            Console.WriteLine(texto);
                        }
                        else
                        {
                            listaPares1.Clear();
                            OperacionesList.CopiarPares(listaNumeros, listaPares1);
                        }
                        break;
                    case 4:
                        if (!esLeido)
                        {
                            Console.WriteLine(texto);
                        }
                        else
                        {
                            listaPares2.Clear();
                            OperacionesList.MoverPares(listaNumeros, listaPares2);
                        }
                        break;
                    case 5:
                        if (!esLeido)
                        {
                            Console.WriteLine(texto);
                        }
                        else
                        {
                            Console.WriteLine($"\nLista de números modificada (solo impares):\n" +
                                              $"{OperacionesList.MostrarLista(listaNumeros)}" +
                                              $"\n\nLista de números pares copiados:\n" +
                                              $"{OperacionesList.MostrarLista(listaPares1)}" +
                                              $"\n\nLista de números pares movidos:\n" +
                                              $"{OperacionesList.MostrarLista(listaPares2)}");
                        }
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(titulo);

            } while (opcion != 6);

            Console.WriteLine("\n\nFin del programa." +
                              "\nPulsa una tecla para salir...");
        }
    }
}
