namespace Tema4_Tarea22
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
                    Console.WriteLine("\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        static int CalcularDivisionEntera (int num1, int num2)
        {
            int divisionEntera = 0;

            while (num1 >= num2)
            {
                num1 -= num2;
                divisionEntera++;
            }

            return divisionEntera;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 22: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            int num1, num2;

            num1 = LeerNumero("\nIntroduce el primer número: ");
            num2 = LeerNumero("\nIntroduce el segundo número: ");

            Console.WriteLine($"\n═> El resultado de la división entera de {num1}/{num2} es: " +
                              $"{CalcularDivisionEntera(num1, num2)}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
        }
    }
}
