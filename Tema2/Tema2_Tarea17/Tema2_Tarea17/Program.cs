using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Tarea17
{
    internal class Program
    {
        const int MesesAnyo = 12;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Tarea 17: Manuel MR");

                Console.Write("\nIntroduce tu nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Introduce tu edad (en años): ");
                int edad = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nHola {nombre}");

                int edadMeses = edad * MesesAnyo;
                Console.WriteLine($"Edad en meses: {edadMeses}");

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
