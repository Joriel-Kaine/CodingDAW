using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 3 - Tarea 2: Manuel MR\n");

            try
            {
                // Pedimos para introducir los dos números enteros.
                Console.Write("Introduce el primer número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("\nIntroduce el segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.Clear();

                if (num1 == num2)
                {
                    Console.WriteLine($"\n\n\nLos numeros introducidos ({num1} y {num2}) son iguales.\n\n\n");
                }
                else
                {
                    Console.WriteLine($"\n\n\nLos números introducidos ({num1} y {num2}) son distintos.\n\n\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Introduce un valor numérico entero válido.");
            }
        }
    }
}
