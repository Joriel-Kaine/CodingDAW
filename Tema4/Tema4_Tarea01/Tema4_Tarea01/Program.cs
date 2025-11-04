namespace Tema4_Tarea01
{
    internal class Program
    {
        static int SumarNumeros(int num1, int num2)
        {
            int resultado;
            resultado = num1 + num2;

            return resultado;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 3 - Tarea 1: Manuel MR ®\n" +
                              "═════════════════════════════\n\n");

            bool esCorrecto = false;
            int num1, num2, resultado;

            Console.Write("Introduce el primero número: ");
            esCorrecto = int.TryParse(Console.ReadLine(), out num1);

            Console.Write("\nIntroduce el segundo número: ");
            esCorrecto = int.TryParse(Console.ReadLine(), out num2);

            resultado = SumarNumeros(num1, num2);

            Console.WriteLine($"\n═> La suma de {num1} y {num2} es: {resultado}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
