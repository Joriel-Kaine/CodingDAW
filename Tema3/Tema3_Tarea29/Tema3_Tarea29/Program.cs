using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 3 - Tarea 29: Manuel MR\n" +
                              "----------------------------\n\n");

            bool entradaNum1;
            bool entradaNum2;
            int producto = 0;

            Console.Write("Introduce el primer número: ");
            entradaNum1 = int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("\nIntroduce el segundo número: ");
            entradaNum2 = int.TryParse(Console.ReadLine(), out int num2);

            for (int i = num1; i >= 1; i--)
            {
                producto += num2;
            }

            Console.WriteLine($"\nEl resultado final de la multiplicación de {num1} * {num2} es: {producto}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
