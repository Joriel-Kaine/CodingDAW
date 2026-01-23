namespace Tema6_Ejemplo07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 6 - Ejemplo 7: Manuel MR ®\n" +
                              "═══════════════════════════════\n\n");

            int numElementos = EjemplosList.LeerNumero("Introduce el número de elementos de las listas: ");

            Console.WriteLine("\nIntroducimos la lista 1: ");
            List<int> listaNumeros1 = EjemplosList.LeerLista(numElementos);
            Console.WriteLine("\nIntroducimos la lista 2: ");
            List<int> listaNumeros2 = EjemplosList.LeerLista(numElementos);

            List<int> listaSuma = EjemplosList.SumarListas(listaNumeros1, listaNumeros2);

            Console.WriteLine("Lista 1:");
            Console.WriteLine(EjemplosList.MostrarLista(listaNumeros1));

            Console.WriteLine("Lista 2:");
            Console.WriteLine(EjemplosList.MostrarLista(listaNumeros2));

            Console.WriteLine("Lista suma:");
            Console.WriteLine(EjemplosList.MostrarLista(listaSuma));

            Console.WriteLine("\n\nPulsa una tecla para salir");
            Console.ReadKey();
        }
    }
}
