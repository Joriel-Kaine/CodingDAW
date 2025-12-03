namespace Tema4_Tarea01
{
    internal class Program
    {
        static int SumarNumeros(int num1, int num2)
        {
            int suma;
            suma = num1 + num2;

            return suma;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 3 - Tarea 1: Manuel MR ®\n" +
                              "═════════════════════════════\n\n");

            bool esCorrecto1, esCorrecto2;
            int num1, num2, suma;

            Console.Write("Introduce el primero número: ");
            esCorrecto1 = int.TryParse(Console.ReadLine(), out num1);

            Console.Write("\nIntroduce el segundo número: ");
            esCorrecto2 = int.TryParse(Console.ReadLine(), out num2);

            if (esCorrecto1 && esCorrecto2)
            {
                suma = SumarNumeros(num1, num2);
                Console.WriteLine($"\n═> La suma de {num1} y {num2} es: {suma}");
            }
            else
            {
                Console.WriteLine("\nIntroduce valores numéricos válidos.");
            }

                Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
