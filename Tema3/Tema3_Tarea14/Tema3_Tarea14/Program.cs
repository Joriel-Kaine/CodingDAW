using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea14
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
            string tipoVehiculo = "Tipos de vehículos disponibles:\n";

            foreach (TipoVehiculo vehiculo in Enum.GetValues(typeof(TipoVehiculo)))
            {
                tipoVehiculo += $"\n- {vehiculo}";
            }

            Console.WriteLine($"{tipoVehiculo}");
            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
