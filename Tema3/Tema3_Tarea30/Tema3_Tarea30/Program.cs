using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 3 - Tarea 30: Manuel MR\n" +
                              "----------------------------\n\n");

            bool entradaNum;
            double serie = 0;

            Console.Write("Introduce un número entero positivo: ");
            entradaNum = int.TryParse(Console.ReadLine(), out int numero);

            if (numero > 0)
            {
                for (int i = 1; i <= numero; i++)
                {
                    if (i % 2 == 0)
                    {
                        serie -= 1.0 / (double)i;
                    }
                    else
                    {
                        serie += 1.0 / (double)i;
                    }
                }

                Console.WriteLine($"\n\nEl resultado de la serie es: {serie}");
            }
            else
            {
                Console.WriteLine("\nDebes introducir un número válido.");
            }

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
