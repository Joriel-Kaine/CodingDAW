using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea07
{
    internal class Program
    {
        const string salida = "salir";

        static void Main(string[] args)
        {
            string tareasHogar;

            do
            {
                Console.Clear();

                Console.WriteLine("\n\nTema 3 - Tarea 7: Manuel MR\n\n");

                Console.Write("Escribe qué tarea del hogar deseas hacer ahora mismo: ");
                tareasHogar = Console.ReadLine();

                switch (tareasHogar)
                {
                    case ("lavar los platos"):
                        Console.WriteLine("\n\nLavando los platos...");
                        break;
                    case ("barrer el piso"):
                        Console.WriteLine("\n\nBarriendo el piso...");
                        break;
                    case ("sacar la basura"):
                        Console.WriteLine("\n\nSacando la basura...");
                        break;
                    case ("regar las plantas"):
                        Console.WriteLine("\n\nRegando las plantas...");
                        break;
                    case ("hacer la cama"):
                        Console.WriteLine("\n\nHaciendo la cama...");
                        break;
                    case ("salir"):
                        break;
                    default:
                        Console.WriteLine("\n\nEscribe una tarea del hogar válida...");
                        break;
                }

                if (tareasHogar != salida)
                {
                    Console.ReadKey();
                }

            } while (tareasHogar != salida);
        }
    }
}
