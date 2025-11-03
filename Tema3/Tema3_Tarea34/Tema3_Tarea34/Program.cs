using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 3 - Tarea 34: Manuel MR\n" +
                              "----------------------------\n\n");

            bool esCorrecto = false;
            decimal precio;
            int totalProductos = 0;
            decimal totalVentas = 0;
            decimal precioMedioProd = 0;
            string salida = "";

            Console.WriteLine("---- Registro de Ventas ----\n" +
                              "Introduce el precio de cada producto vendido.\n" +
                              "Escribe 'fin' para cerrar el registro.\n");

            while (salida != "fin")
            {
                Console.Write("Precio del producto: ");
                salida = Console.ReadLine();
                esCorrecto = decimal.TryParse(salida, out precio);
                if (salida != "fin" && esCorrecto)
                {
                    totalProductos++;
                    totalVentas += precio;
                }
            }

            precioMedioProd = totalVentas / totalProductos;

            Console.WriteLine($"\n---- Resumen del día ----\n" +
                              $"Productos vendidos: {totalProductos}\n" +
                              $"Total de ventas: {totalVentas:C2}\n" +
                              $"Precio medio por producto: {precioMedioProd:C2}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
