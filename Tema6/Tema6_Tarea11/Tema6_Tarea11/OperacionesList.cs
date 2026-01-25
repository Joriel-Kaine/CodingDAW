using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Tarea11
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

        public static void LeerLista(List<int> listaBase, List<int> listaExponente)
        {
            int bbase, exponente, posicion = 0;
            string respuesta = "";

            do
            {


            } while (respuesta == "S" || respuesta == "s");
        }

        public static 
    }
}
