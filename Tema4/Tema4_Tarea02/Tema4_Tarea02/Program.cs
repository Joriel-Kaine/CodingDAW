namespace Tema4_Tarea02
{
    internal class Program
    {
        static bool EsDivisible (int num1, int num2)
        {
            if (num1 % num2 == 0)
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 2: Manuel MR ®\n" +
                              "═════════════════════════════\n\n");

            bool esCorrecto1, esCorrecto2;
            int num1, num2;

            try
            {
                Console.Write("Introduce el primer número: ");
                esCorrecto1 = int.TryParse(Console.ReadLine(), out num1);

                Console.Write("\nIntroduce el segundo número: ");
                esCorrecto2 = int.TryParse(Console.ReadLine(), out num2);

                if (esCorrecto1 && esCorrecto2)
                {
                    if (EsDivisible(num1, num2))
                    {
                        Console.WriteLine($"\n═> {num1} es divisible por {num2}");
                    }
                    else
                    {
                        Console.WriteLine($"\n═> {num1} no es divisible por {num2}");
                    }
                }
                else
                {
                    Console.WriteLine("\nIntroduce valores númericos válidos.");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\n\nNo se puede dividir por 0.");
            }

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
