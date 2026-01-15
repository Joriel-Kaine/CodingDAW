using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Tarea01
{
    public static class OperacionesVector
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

        public static void LeerVector(int[] vector)
        {
            int tamano = vector.Length;

            for (int i = 0; i < tamano; i++)
            {
                vector[i] = LeerNumero($"Introduce el valor ({i + 1} de {tamano}): ");
            }
        }

        public static string MostrarVector(int[] vector)
        {
            string texto = "═> Elementos que tiene el vector: \n";

            for (int i = 0; i < vector.Length; i++)
            {
                texto += $"{vector[i]}, ";
            }

            return texto;
        }

        public static int Menu()
        {
            int opcion;

            Console.WriteLine("\n   MENÚ\n" +
                              "\n1. Leer Vectores." +
                              "\n2. Mostrar Vectores." +
                              "\n3. Salir del programa.");

            opcion = LeerNumero("\nIntroduce una opción del menú: ");
            Console.WriteLine();

            return opcion;
        }
    }
}
