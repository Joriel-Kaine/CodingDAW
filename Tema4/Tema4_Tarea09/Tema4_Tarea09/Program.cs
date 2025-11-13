namespace Tema4_Tarea09
{
    internal class Program
    {
        const string titulo = "\nTema 4 - Tarea 9: Manuel MR ®\n" +
                              "═════════════════════════════\n\n";

        static int LeerEntero (string mensaje)
        {
            int num;
            bool esCorrecto ;

            do
            {
                Console.Write(mensaje);
                // Si lo que leemos no es un entero devuelve false.
                esCorrecto = int.TryParse(Console.ReadLine(), out num);

                if (!esCorrecto)
                {
                    Console.WriteLine("\nDebes introducir un valor numérico valido.");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine(titulo);
                }

            } while (!esCorrecto);
            // Continuamos pidiendo el número mientras no sea correcto.

            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(titulo);

            int num;

            num = LeerEntero("\nIntroduce un número entero: ");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
