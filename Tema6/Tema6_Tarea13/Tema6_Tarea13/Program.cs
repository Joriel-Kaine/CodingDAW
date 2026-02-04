namespace Tema6_Tarea13
{
    internal class Program
    {
        const string texto = "Debes introducir valores en la lista",
                     titulo = "\nTema 6 - Tarea 13: Manuel MR ®\n" +
                              "══════════════════════════════\n\n";

        static void Main(string[] args)
        {
            Console.WriteLine(titulo);



            Console.WriteLine("\n\nFin del programa." +
                              "\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
