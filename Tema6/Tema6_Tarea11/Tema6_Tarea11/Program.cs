namespace Tema6_Tarea11
{
    internal class Program
    {
        const string texto = "Debes introducir valores en la lista.",
                     titulo = "\nTema 6 - Tarea 11: Manuel MR ®\n" +
                              "══════════════════════════════\n\n";

        static void Main(string[] args)
        {
            Console.WriteLine(titulo);

            List<int> listaBase = new(), listaExponente = new(), listaPotencia = new();
            int opcion;
            bool esBaseLeida = false, esExponenteLeido = false;

            do
            {
                opcion = OperacionesList.Menu();

                switch (opcion)
                {
                    case 1:
                        OperacionesList.LeerListaBase(listaBase);
                        esBaseLeida = true;
                        break;
                    case 2:
                        OperacionesList.LeerListaExponente(listaExponente);
                        esExponenteLeido = true;
                        break;
                    case 3:
                        if (!esBaseLeida || !esExponenteLeido)
                        {
                            Console.WriteLine(texto);
                        }
                        else
                        {
                            listaPotencia.Clear();
                            OperacionesList.ListaPotencia(listaBase, listaExponente, listaPotencia);
                        }
                        break;
                    case 4:
                        if (!esBaseLeida || !esExponenteLeido)
                        {
                            Console.WriteLine(texto);
                        }
                        else
                        {
                            Console.WriteLine($"\nLista de valores para la base:\n" +
                                              $"{OperacionesList.MostrarLista(listaBase)}" +
                                              $"\nLista de valores para el exponente:\n" +
                                              $"{OperacionesList.MostrarLista(listaExponente)}" +
                                              $"\nLista de valores para la potencia (base ^ exponente):\n" +
                                              $"{OperacionesList.MostrarLista(listaPotencia)}");
                        }
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(titulo);

            } while (opcion != 5);

            Console.WriteLine("\n\nFin del programa." +
                              "\nPulsa una tecla para salir...");
        }
    }
}
