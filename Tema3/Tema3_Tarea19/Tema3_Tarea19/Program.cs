using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 3 - Tarea 19: Manuel MR\n" +
                              "----------------------------\n\n");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i + 3 <= 100)
                    {
                        Console.Write($"{i}, ");
                    }
                    else
                    {
                        Console.Write($"{i} ");
                    }
                }
            }

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
