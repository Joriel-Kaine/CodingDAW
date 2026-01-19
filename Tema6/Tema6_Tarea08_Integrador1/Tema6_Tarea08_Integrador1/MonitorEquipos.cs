using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Tarea08_Integrador1
{
    public class MonitorEquipos
    {
        public static int LeerNumero(string mensaje)
        {
            int num;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = int.TryParse(Console.ReadLine(), out num);

                if (!esCorrecto)
                {
                    Console.WriteLine("\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }
    }
}
