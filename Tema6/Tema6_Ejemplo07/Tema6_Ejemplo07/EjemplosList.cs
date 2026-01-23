using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Ejemplo07
{
    public class EjemplosList
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
            // Continuamos pidiendo el número mientras no sea un entero.

            return num;
        }

        // Función a la cual le pasamos el número de elementos de una lista y los leemos, creándola.
        public static List<int> LeerLista(int numElementos)
        {
            List<int> listaNumeros = new();

            for (int i = 0; i < numElementos; i++)
            {
                int num = LeerNumero($"Introduce el número {i}: ");

                listaNumeros.Add(num);
            }

            return listaNumeros;
        }

        /*
         * Función a la cual le pasamos dos listas y crea una tercera
         * con la suma posición a posición de las otras dos.
         */
        public static List<int> SumarListas(List<int> lista1, List<int> lista2)
        {
            List<int> listaSuma = new();

            for (int i = 0; i < lista1.Count; i++)
            {
                int suma = lista1[i] + lista2[i];

                listaSuma.Add(suma);
            }

            return listaSuma;
        }

        public static string MostrarLista(List<int> lista)
        {
            string texto = "";

            foreach (int num in lista)
            {
                texto += $"{num.ToString()} ";
            }

            return texto;
        }
    }
}
