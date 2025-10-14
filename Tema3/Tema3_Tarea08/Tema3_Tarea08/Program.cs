using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nTema 3 - Tarea 8: Manuel MR\n\n");

            Console.WriteLine("     MENÚ");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Teléfonos móviles");
            Console.WriteLine("2. Ordenadores");
            Console.WriteLine("3. Televisores");
            Console.WriteLine("4. Vestidos");
            Console.WriteLine("5. Faldas");
            Console.WriteLine("6. Pantalones");

            int opcion;

            Console.Write("\n\nElige una opción del menú: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine($"\n\nOpción seleccionada -> {opcion}\n" +
                                      "Has seleccionado una categoría de productos electrónicos.\n" +
                                      "Promoción: Financiación disponible hasta en 12 meses sin intereses.");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine($"\n\nOpción seleccionada -> {opcion}\n" +
                                      "Has seleccionado una categoría de productos de moda.\n" +
                                      "Promoción: 3x2 en artículos seleccionados.");
                    break;
                default:
                    Console.WriteLine($"\n\nOpción seleccionada -> {opcion}\n" +
                                      "Categoría no reconocida. Por favor, selecciona una opción válida del menú.");
                    break;
            }

            Console.WriteLine("\n\nPulsa una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
