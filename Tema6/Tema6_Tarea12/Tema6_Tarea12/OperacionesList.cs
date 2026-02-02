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

        public static List<int> LeerLista(int numElementos)
        {
            int num;
            List<int> lista = new();

            for (int i = 0; i < numElementos; i++)
            {
                num = LeerNumero($"Introduce un número ({i + 1} de {numElementos}): ");

                lista.Add(num);
            }

            lista.Sort();

            return lista;
        }

        public static List<int> IntercalarLista(List<int> lista1, List<int> lista2)
        {
            List<int> listaIntercalada = new();
            int i = 0, j = 0;

            while (i < lista1.Count && j < lista2.Count)
            {
                if (lista1[i] < lista2[j])
                {
                    listaIntercalada.Add(lista1[i]);
                    i++;
                }
                else
                {
                    listaIntercalada.Add(lista2[j]);
                    j++;
                }
            }

            if (i == lista1.Count)
            {
                while (j < lista2.Count)
                {
                    listaIntercalada.Add(lista2[j]);
                    j++;
                }
            }
            else
            {
                while (i < lista1.Count)
                {
                    listaIntercalada.Add(lista1[i]);
                    i++;
                }
            }

            return listaIntercalada;
        }

        public static string MostrarLista(List<int> lista)
        {
            string texto = "";

            foreach (int num in lista)
            {
                texto += $"{num} · ";
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

            Console.WriteLine("\nIntercalar Listas\n" +
                              "\n1. Leer la primera lista." +
                              "\n2. Leer la segunda lista." +
                              "\n3. Intercalar las listas." +
                              "\n4. Mostrar las listas." +
                              "\n5. Salir del programa.");

            opcion = LeerNumero("Introduce una opción del menú: ");
            Console.WriteLine();

            return opcion;
        }
    }
}
