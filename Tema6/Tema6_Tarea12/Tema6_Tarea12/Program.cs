namespace Tema6_Tarea12
{
    internal class Program
    {
        const string texto = "\nDebes introducir valores en la lista.",
                     titulo = "\nTema 6 - Tarea 12: Manuel MR ®\n" +
                              "══════════════════════════════\n\n";

        static void Main(string[] args)
        {
            Console.WriteLine(titulo);

            List<int> lista1 = new(), lista2 = new(), lista3 = new();

            Console.WriteLine("\n\nFin del programa." +
                              "\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
