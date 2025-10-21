using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea15
{
    internal class Program
    {
        enum TipoVehiculo
        {
            Coche,
            Moto,
            Bicicleta,
            Autobús,
            Camión
        }

        static void Main(string[] args)
        {
            string tipoVehiculo = "Tipos de vehículo disponibles:\n";

            foreach (TipoVehiculo vehiculo in Enum.GetValues(typeof(TipoVehiculo)))
            {
                tipoVehiculo += $"\n- {vehiculo}";
            }

            Console.WriteLine(tipoVehiculo);

            Console.Write("\n\nIntroduce el tipo de vehículo: ");
            string vehiculoSeleccionado = Console.ReadLine();
            
            bool resultado = Enum.IsDefined(typeof(TipoVehiculo), vehiculoSeleccionado);

            if (resultado == true)
            {
                Console.WriteLine($"\nEl tipo de vehículo '{vehiculoSeleccionado}' es válido.");
            }
            else
            {
                Console.WriteLine("\nEl tipo de vehiculo introducido no es válido.");
            }
            
            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
