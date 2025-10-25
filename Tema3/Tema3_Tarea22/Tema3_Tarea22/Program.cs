using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 3 - Tarea 22: Manuel MR\n" +
                              "----------------------------\n\n");

            int potencia = 1;

            Console.Write("Introduce un número entero: ");
            string valor1 = Console.ReadLine();

            Console.Write("\nIntroduce el número exponente: ");
            string valor2 = Console.ReadLine();

            if (int.TryParse(valor1, out int numero) && int.TryParse(valor2, out int exponente))
            {
                for (int i = 1; i <= exponente; i++)
                {
                    potencia *= numero;
                }

                Console.WriteLine($"\n\nLa potencia del número '{numero}' con exponente '{exponente}' es: {potencia}");
            }
            else
            {
                Console.WriteLine("\n\nDebes introducir un número entero o un exponente válido.");
            }


        }
    }
}
