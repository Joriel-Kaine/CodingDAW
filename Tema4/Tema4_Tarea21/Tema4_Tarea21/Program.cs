namespace Tema4_Tarea21
{
    internal class Program
    {
        static int LeerNumero (string mensaje)
        {
            int num;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = int.TryParse(Console.ReadLine(), out num);

                if (!esCorrecto)
                {
                    Console.WriteLine("\n\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        static int CalcularFactorial (int num)
        {
            int factorial = 1;

            for (int i = num; i > 1 ; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 21: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            int num;

            num = LeerNumero("\nIntroduce un número entero: ");

            Console.WriteLine($"\n═> El factorial de {num} es: {CalcularFactorial(num)}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
        }
    }
}
