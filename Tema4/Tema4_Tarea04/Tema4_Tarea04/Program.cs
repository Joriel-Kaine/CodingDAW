namespace Tema4_Tarea04
{
    internal class Program
    {
        static int ValorAbsoluto (int num)
        {
            int absoluto;

            return absoluto = (num < 0) ? -num : num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 4: Manuel MR ®\n" +
                              "═════════════════════════════\n\n");

            bool esCorrecto;
            int num, absoluto;

            Console.Write("Introduce un número: ");
            esCorrecto = int.TryParse(Console.ReadLine(), out num);

            if (esCorrecto)
            {
                absoluto = ValorAbsoluto(num);
                Console.WriteLine($"\n═> El valor absoluto de {num} es: {absoluto}");
            }
            else
            {
                Console.WriteLine("Introduce valores numéricos válidos.");
            }

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
