using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Tarea18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                Console.WriteLine("Tarea 18: Manuel MR");

                Console.Write("\nIntroduce el precio: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                Console.Write("Introduce el descuento (0 - 1): ");
                decimal descuento = decimal.Parse(Console.ReadLine());

                decimal neto = precio - (precio * descuento);

                Console.WriteLine($"\nPrecio: {precio:C2}");
                Console.WriteLine($"Descuento: {descuento:P2}");
                Console.WriteLine($"Neto: {neto:C2}");

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
