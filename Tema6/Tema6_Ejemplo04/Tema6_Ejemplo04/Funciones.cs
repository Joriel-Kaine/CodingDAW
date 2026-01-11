using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Ejemplo04
{
    public class Funciones
    {
        // Función para leer un número.
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

        static public void LeerNotas(int[] vector)
        {
            // Leemos todos los elementos del vector.
            for (int i = 0; i < vector.Length; i++)
            {
                do
                {
                    vector[i] = LeerNumero($"Introduce la nota {i} (entre 0 y 10): ");

                } while (vector[i] < 0 || vector[i] > 10);
            }
        }

        static public string MostrarNotas(int[] vector)
        {
            string texto = "Notas: \n";

            for (int i = 0; i < vector.Length; i++)
            {
                texto += $"{vector[i]}, ";
            }

            return texto;
        }

        // Función que aumenta en 1 el valor de cada elemento del vector.
        static public void AumentarNotas(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] + 1 <= 10) // Si la suma es mayor que 10, ponemos 10.
                {
                    vector[i]++;
                }
                else
                {
                    vector[i] = 10;
                }

                // Operador ternario.
                // vector[i] = (vector[i] + 1 <= 10) ? vector[i] + 1 : 10;
            }
        }

        static public double CalcularNotaMedia(int[] vector)
        {
            double media = 0.0;

            for (int i = 0; i < vector.Length; i++)
            {
                media += vector[i];
            }

            return media / vector.Length;
        }

        static public int Menu()
        {
            int opcion;

            Console.WriteLine("\n   MENÚ\n" +
                              "\n1. Introducir todas las notas." +
                              "\n2. Mostrar todas las notas." +
                              "\n3. Aumentar en un punto todas las notas." +
                              "\n4. Media de las notas." +
                              "\n5. Salir del programa.");

            opcion = LeerNumero("\nIntroduce una opción del menú: ");

            return opcion;
        }
    }
}
