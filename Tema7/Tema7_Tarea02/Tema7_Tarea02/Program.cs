namespace Tema7_Tarea02
{
    internal class Program
    {
        const string Titulo = "\nTema 7 - Tarea 2: Manuel MR ®\n" +
                              "═════════════════════════════\n\n";

        static void Main(string[] args)
        {
            Console.WriteLine(Titulo);

            int opcion;
            ListaFechas lista = new();

            do
            {
                opcion = FuncionesInterfaz.Menu();

                switch (opcion)
                {
                    case 1:
                        FuncionesInterfaz.LeerFechas(lista);
                        break;
                    case 2:
                        FuncionesInterfaz.MostrarFechas(lista);
                        break;
                    case 3:
                        lista.OrdenarListaFechas();
                        break;
                }

            } while (opcion != 4);

            Console.WriteLine("\n\nFin del programa." +
                              "\nPulsa una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
