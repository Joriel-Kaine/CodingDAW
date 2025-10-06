using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Tarea14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                Console.WriteLine("Tarea 14: Manuel MR\n");

                const decimal IVA = 0.21m;

                Console.Write("Introduce el precio del primer producto: ");
                decimal productoA = decimal.Parse(Console.ReadLine());

                Console.Write("\nIntroduce el precio del segundo producto: ");
                decimal productoB = decimal.Parse(Console.ReadLine());

                Console.Write("\nIntroduce el precio del tercer producto: ");
                decimal productoC = decimal.Parse(Console.ReadLine());

                // Sacamos por consola los precios introducidos.
                Console.WriteLine($"\nEl precio de los productos es: {productoA}€, {productoB}€ y {productoC}€.");

                // Calculamos el total sin IVA.
                decimal totalSinIVA = productoA + productoB + productoC;
                Console.WriteLine($"\nPrecio total sin IVA: {totalSinIVA}");

                // Calculamos el total con IVA.
                decimal totalConIVA = totalSinIVA * (1 + IVA); // También se puede hacer "totalSinIVA + (totalSinIVA * IVA)".
                Console.WriteLine($"Precio total con IVA: {totalConIVA}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nIntroduce un valor numérico válido.");
            }
        }
    }
}
