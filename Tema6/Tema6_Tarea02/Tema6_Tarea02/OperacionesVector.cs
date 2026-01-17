using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Tarea02
{
    public class OperacionesVector
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

        public static void LeerVector(int[] vector)
        {
            int tamano = vector.Length;

            for (int i = 0; i < tamano; i++)
            {
                vector[i] = LeerNumero($"Introduce un valor ({i + 1} de {tamano}): ");
            }
        }

        public static string MostrarVector(int[] vector)
        {
            string texto = "Elementos del vector: \n";

            for (int i = 0; i < vector.Length; i++)
            {
                texto += $"{vector[i]}, ";
            }

            return texto;
        }

        private static int SumarVector(int[] vector)
        {
            int suma = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
            }

            return suma;
        }

        public static double MediaVector(int[] vector)
        {
            double media;

            media = (double)SumarVector(vector) / vector.Length;

            return media;
        }

        public static int Menu()
        {
            int opcion;

            Console.WriteLine("\n   MENÚ\n" +
                              "\n1. Leer vector." +
                              "\n2. Mostrar vector." +
                              "\n3. Media del vector." +
                              "\n4. Salir del programa.");

            opcion = LeerNumero("\nIntroduce una opción del menú: ");
            Console.WriteLine();

            return opcion;
        }
    }
}
