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

            bool esCorrecto = false; // Declaramos una variable booleana para el TryParse.
            decimal precio;
            int totalProductos = 0;
            decimal totalVentas = 0;
            decimal precioMedioProd = 0;
            string salida = ""; // Declaramos una variable string para controlar la salida con "fin".

            Console.WriteLine("---- Registro de Ventas ----\n" +
                              "Introduce el precio de cada producto vendido.\n" +
                              "Escribe 'fin' para cerrar el registro.\n");

            while (salida != "fin")
            {
                Console.Write("Precio del producto: "); // Pedimos que se introduzca un valor.
                salida = Console.ReadLine(); // Almacenamos ese valor en el string.
                
                /*
                 * Si el valor es numérico, lo almacena en una variable y cambia el booleano a True.
                 * Debe ir fuera del if, ya que si va dentro del if sumaría un producto sea o no un número.
                 */
                esCorrecto = decimal.TryParse(salida, out precio);

                /*
                 * Si el valor introducido no es la palabra "fin"
                 * y el valor introducido es True (valor numérico)
                 * añade ese producto a un contador y almacena acumulando el total de las ventas.
                 */
                if (salida != "fin" && esCorrecto)
                {
                    totalProductos++;
                    totalVentas += precio;
                }
            }

            // Calculamos el precio medio a traves del total de las ventas y los productos introducidos.
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
