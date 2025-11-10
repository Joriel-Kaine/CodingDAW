namespace Tema4_Tarea08
{
    internal class Program
    {
        static bool DivisionResto (int num1, int num2, out int division, out int resto)
        {
            bool esDivisible = true;
            division = 0;
            resto = 0;

            if (num2 == 0)
            {
                esDivisible = false;
            }
            else
            {
                division = num1 / num2;
                resto = num1 % num2;
            }

            return esDivisible;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 8: Manuel MR ®\n" +
                              "═════════════════════════════\n\n");

            bool esCorrecto1, esCorrecto2, esDivisible = true;
            int num1, num2, division, resto;

            Console.Write("Introduce el primer número: ");
            esCorrecto1 = int.TryParse(Console.ReadLine(), out num1);

            Console.Write("\nIntroduce el segundo número: ");
            esCorrecto2 = int.TryParse(Console.ReadLine(), out num2);

            if (esCorrecto1 && esCorrecto2)
            {
                esDivisible = DivisionResto (num1, num2, out division, out resto);
                Console.WriteLine($"\n═> El resultado de la división {num1} / {num2} es: {division}\n" +
                                  $"\n═> El resultado del resto de {num1} / {num2} es: {resto}\n" +
                                  $"\n═> Es divisible = {esDivisible}");
            }
            else
            {
                Console.WriteLine("\n\nIntroduce un valor numérico");
            }

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
