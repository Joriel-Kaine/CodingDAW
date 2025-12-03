using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 3 - Tarea 28: Manuel MR\n" +
                              "----------------------------");

            bool esCorrecto;
            bool esPrimo = true;

            Console.Write("\n\nIntroduce un número entero: ");
            esCorrecto = int.TryParse(Console.ReadLine(), out int numero);

            if (esCorrecto)
            {
                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine($"\n\nEl número {numero} es un número pri1mo.");
                }
                else
                {
                    Console.WriteLine($"\n\nEl número {numero} no es un número primo.");
                }
            }
            else
            {
                Console.WriteLine("\n\nIntroduce un número entero válido.");
            }

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
