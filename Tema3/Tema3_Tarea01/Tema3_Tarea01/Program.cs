using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\nTema 3 - Tarea 01: Manuel MR\n\n");

                Console.Write("Introduce un número entero cualquiera: ");
                int numEntero = int.Parse(Console.ReadLine());

                if (numEntero == 2)
                {
                    Console.WriteLine("\n\nEl número introducido es el 2\n\n");
                }
                else
                {
                    Console.WriteLine("\n\nEl número introducido NO es el 2\n\n");
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\nIntroduce un valor numérico válido.\n\n\n\n");
            }
        }
    }
}
