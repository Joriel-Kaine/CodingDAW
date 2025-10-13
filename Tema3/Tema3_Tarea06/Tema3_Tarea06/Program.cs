using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nTema 3 - Tarea 6: Manuel MR\n\n");

            Console.Write("Introduce un día de la semana: ");
            string diaSemana = Console.ReadLine();

            switch (diaSemana)
            {
                case ("lunes"):
                    Console.WriteLine("\n\nInicio de la semana, ¡Ánimo!\n\n");
                    break;
                case ("martes"):
                    Console.WriteLine("\n\nEn martes, ni te cases ni te embarques.\n\n");
                    break;
                case ("miercoles"):
                    Console.WriteLine("\n\nMiércoles de ceniza.\n\n");
                    break;
                case ("jueves"):
                    Console.WriteLine("\n\nEstamos en la mitad de semana.\n\n");
                    break;
                case ("viernes"):
                    Console.WriteLine("\n\n¡Por fin es viernes!\n\n");
                    break;
                case ("sabado"):
                    Console.WriteLine("\n\nSábado sabadete...\n\n");
                    break;
                case ("domingo"):
                    Console.WriteLine("\n\nDia de descanso.\n\n");
                    break;
                default:
                    Console.WriteLine("\n\nNo coincide con nigún día de la semana.\n\n");
                    break;
            }
        }
    }
}
