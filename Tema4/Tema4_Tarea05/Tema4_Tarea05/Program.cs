namespace Tema4_Tarea05
{
    internal class Program
    {
        static void CambiarAbsoluto (ref int num)
        {
            if (num < 0)
            {
                num = -num;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 5: Manuel MR ®\n" +
                              "═════════════════════════════\n\n");

            bool esCorrecto;
            int num;

            Console.Write("\nIntroduce un número: ");
            esCorrecto = int.TryParse(Console.ReadLine(), out num);

            if (esCorrecto)
            {
                CambiarAbsoluto(ref num);
                Console.WriteLine($"\n═> El resultado es: {num} ");
            }
            else
            {
                Console.WriteLine("\nIntroduce un valor numérico.");
            }

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
