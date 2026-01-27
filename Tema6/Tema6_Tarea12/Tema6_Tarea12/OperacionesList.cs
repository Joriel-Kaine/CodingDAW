using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Tarea12
{
    public class OperacionesList
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

        public static void LeerLista(int numElementos, List<int> lista)
        {
            int num;

            for (int i = 0; i < numElementos; i++)
            {
                num = LeerNumero($"Introduce un número ({i + 1} de {numElementos}): ");

                lista.Add(num);
            }
        }
    }
}
