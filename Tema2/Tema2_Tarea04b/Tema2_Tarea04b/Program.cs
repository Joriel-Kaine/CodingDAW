using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Tarea04b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Modificamos la consola para que acepte los caracteres que queremos.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ejercicio 4b");

            // Introducimos el precio antes del descuento.
            Console.Write("\nIntroduce el precio (decimal): ");
            decimal precio = decimal.Parse(Console.ReadLine());

            // Introducimos el descuento a aplicar al precio.
            Console.Write("Introduce el descuento (0 - 1): ");
            decimal descuento = decimal.Parse(Console.ReadLine());

            // Calculamos el precio neto tras el descuento aplicado.
            decimal neto = precio * (1 - descuento);

            // Mostramos por consola los resultados.
            Console.WriteLine($"\nPrecio:       {precio:C2}");
            Console.WriteLine($"Descuento:      {descuento:P1}");
            Console.WriteLine($"Neto:           {neto:C2}");

            // Pedimos pulsar una tecla para finalizar.
            Console.WriteLine("\nPulsa una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
