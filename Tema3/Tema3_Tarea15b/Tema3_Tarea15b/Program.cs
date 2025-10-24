using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea15b
{
    internal class Program
    {
        enum TipoVehiculo
        {
            Coche = 1,
            Moto = 2,
            Bicicleta = 3,
            Autobús = 4,
            Camión = 5
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Tipos de vehículo disponibles: \n");

            foreach (TipoVehiculo tipo in Enum.GetValues(typeof(TipoVehiculo)))
            {
                Console.WriteLine($"{(int)tipo}. {tipo}");
            }

            Console.Write("\nIntroduce el tipo de vehículo (1 - 5): ");
            string entrada = Console.ReadLine();

            // Intentamos convertir la entrada del usuario al enum TipoVehiculo.
            if (int.TryParse(entrada, out int valor))
            {
                // Comprobamos si el valor introducido está definido en el enum.
                if (Enum.IsDefined(typeof(TipoVehiculo), valor))
                {
                    Console.WriteLine($"\n\nEl tipo de vehículo '{(TipoVehiculo)valor}' es válido.");
                }
                else
                {
                    Console.WriteLine("\n\nError: número fuera del rango del enumerado");
                }
            }
            else
            {
                Console.WriteLine("\n\nEntrada incorrecta: se ha de introducir un número");
            }
        }
    }
}
