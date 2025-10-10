using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Tarea20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Tema 2 - Tarea 20: Manuel MR");

                Console.Write("\nIntroduce un carácter: ");
                char caracter = char.Parse(Console.ReadLine());

                bool vocal = 'a' == caracter;
                bool digito = (0 <= caracter) && (caracter <= 9);

                Console.WriteLine($"\n¿Es vocal?: {vocal}" +
                                  $"\n¿Es dígito?: {digito}");

                Console.WriteLine("\nPulsa una tecla para salir...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
