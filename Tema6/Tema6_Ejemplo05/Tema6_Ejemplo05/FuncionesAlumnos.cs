using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Ejemplo05
{
    public class FuncionesAlumnos
    {
        private static int LeerNumero(string mensaje)
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

        public static void LeerAlumnosYNotas(string[] vectorAlumnos, int[] vectorNotas)
        {
            // Leemos todos los elementos del vector.
            for (int i = 0; i < vectorAlumnos.Length; i++)
            {

            }
        }
    }
}
