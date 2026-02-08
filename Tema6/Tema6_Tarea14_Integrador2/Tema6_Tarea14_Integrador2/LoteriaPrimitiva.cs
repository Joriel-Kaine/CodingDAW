using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Tarea14_Integrador2
{
    public class LoteriaPrimitiva
    {
        const int CantidadNum = 6;

        public static int LeerEntero(string mensaje)
        {
            int num;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = int.TryParse(Console.ReadLine(), out num);

                if (!esCorrecto)
                {
                    Console.WriteLine("\nDebes introducir valores numéricos válidos.");
                }

                if (esCorrecto && (num < 1 || num > 49))
                {
                    Console.WriteLine("\nLos números deben estar comprendidos entre 1 y 49.");
                }

            } while (!esCorrecto || (num < 1 || num > 49));

            return num;
        }

        public static void GenerarNumeros(List<int> numeros, Random random)
        {
            int num;

            numeros.Clear();

            for (int i = 0; i < CantidadNum; i++)
            {
                num = random.Next(1, 50);

                if (!numeros.Contains(num))
                {
                    numeros.Add(num);
                }
                else
                {
                    i--;
                }
            }

            numeros.Sort();
        }

        public static void LeerNumeros(List<int> numeros)
        {
            int num;

            numeros.Clear();

            for (int i = 0; i < CantidadNum; i++)
            {
                num = LeerEntero($"Introduce el número para la apuesta ({i + 1} de {CantidadNum}): ");

                if (!numeros.Contains(num))
                {
                    numeros.Add(num);
                }
                else
                {
                    i--;
                }
            }

            numeros.Sort();
        }

        public static int ComprobarAciertos(List<int> numSorteo, List<int> numApuesta)
        {
            int aciertos = 0;

            foreach (int num in numSorteo)
            {
                if (numApuesta.Contains(num))
                {
                    aciertos++;
                }
            }

            return aciertos;
        }

        public static string MostrarApuestas(List<int> numeros)
        {
            string texto = "";

            foreach (int num in numeros)
            {
                texto += $"{num} - ";
            }

            if (texto != "")
            {
                texto = texto.Remove(texto.Length - 3);
            }

            return texto;
        }

        public static int Menu()
        {
            int opcion;

            Console.WriteLine("\nLotería Primitiva\n" +
                              "\n1. Generar sorteo." +
                              "\n2. Apuesta manual." +
                              "\n3. Apuesta automática." +
                              "\n4. Comprobar aciertos." +
                              "\n5. Mostrar apuestas." +
                              "\n6. Salir del programa.");

            opcion = LeerEntero("\nIntroduce una opción del menú: ");
            Console.WriteLine();

            return opcion;
        }
    }
}
