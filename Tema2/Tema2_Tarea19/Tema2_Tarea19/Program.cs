using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Tarea19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                Console.WriteLine("Tema 2 - Tarea 19: Manuel MR");

                Console.Write("\nIntroduce un número decimal: ");
                decimal numero = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"\nN0: {numero:N0}" +
                                  $"\nN2: {numero:N2}" +
                                  $"\nC2: {numero:C2}" +
                                  $"\nP2: {numero:P2}");

                Console.WriteLine("\nPulsa una tecla para salir...");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Introduce un valor numérico válido.");
            }
        }
    }
}
