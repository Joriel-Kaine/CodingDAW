using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Tarea07
{
    public class RegistroTemperaturas
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

        public static void LeerTemperatura(int[] vector)
        {
            int tamano = vector.Length;

            for (int i = 0; i < tamano; i++)
            {
                vector[i] = LeerNumero($"Introduce un valor ({i + 1} de {tamano}): ");
            }
        }

        public static string GenerarTextoTemperatura(int[] vector)
        {
            string texto = "Elementos del vector:\n";
            int tamano = vector.Length;

            for (int i = 0; i < tamano; i++)
            {
                if (i < tamano - 1)
                {
                    texto += $"{vector[i]}ºC, ";
                }
                else
                {
                    texto += $"{vector[i]}ºC";
                }
            }

            return texto;
        }

        public static int ObtenerMenorTemperatura(int[] vector)
        {
            int menor = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                if (menor > vector[i])
                {
                    menor = vector[i];
                }
            }

            return menor;
        }

        public static int ObtenerMayorTemperatura(int[] vector)
        {
            int mayor = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                if (mayor < vector[i])
                {
                    mayor = vector[i];
                }
            }

            return mayor;
        }

        private static int ObtenerSumaTemperatura(int[] vector)
        {
            int suma = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
            }

            return suma;
        }

        public static double ObtenerTemperaturaMedia(int[] vector)
        {
            return (double)ObtenerSumaTemperatura(vector) / vector.Length;
        }

        public static int Menu()
        {
            int opcion;

            Console.WriteLine("\n   Temperatura 24h\n" +
                              "\n1. Leer temperatura." +
                              "\n2. Mostrar temperatura." +
                              "\n3. Calcular datos temperatura." +
                              "\n4. Salir del programa.");

            opcion = LeerNumero("\nIntroduce una opción del menú: ");

            return opcion;
        }
    }
}
