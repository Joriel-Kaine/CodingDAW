using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Tema3_Tarea03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 3 - Tarea 3: Manuel MR\n\n");

            try
            {
                Console.Write("Introduce el primer número entero: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("\nIntroduce el segundo número entero: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num1 >= num2)
                {
                    Console.Clear();
                    Console.WriteLine($"\n\nEl número {num1} es el mayor de los dos.\n\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"\n\nEl número {num2} es el mayor de los dos.\n\n");
                }

                Console.WriteLine("Pulsa una tecla para salir...");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("\n\nIntroduce un valor numérico entero válido.\n\n");
            }
        }
    }
}
