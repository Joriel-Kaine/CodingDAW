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
                int primerNum = int.Parse(Console.ReadLine());

                Console.Write("\nIntroduce el segundo número: ");
                int segundoNum = int.Parse(Console.ReadLine());

                Console.Clear();

                if (primerNum == segundoNum)
                {
                    Console.WriteLine($"\n\n\nLos numeros introducidos ({primerNum} y {segundoNum}) son iguales.\n\n\n");
                }
                else
                {
                    Console.WriteLine($"\n\n\nLos números introducidos ({primerNum} y {segundoNum}) son distintos.\n\n\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Introduce un valor numérico entero válido.");
            }
        }
    }
}
