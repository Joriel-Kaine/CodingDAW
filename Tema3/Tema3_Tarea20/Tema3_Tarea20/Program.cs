using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 3 - Tarea 20: Manuel MR\n" +
                              "----------------------------\n\n");

            int suma = 0;
            string texto = "Números pares: ";

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    if (i + 2 <= 50)
                    {
                        suma += i;
                        texto += ($"{i}, ");
                    }
                    else
                    {
                        suma += i;
                        texto += ($"{i}");
                    }
                }
            }

            Console.WriteLine($"{texto}" +
                              $"\n\nLa suma de los números pares del 1 al 50 es: {suma}.");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
