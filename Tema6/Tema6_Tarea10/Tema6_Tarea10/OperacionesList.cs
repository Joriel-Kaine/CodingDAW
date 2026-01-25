using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Tarea10
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
        /*
        public static string MostrarListaJoin(List<int> lista)
        {
            return string.Join(" ", lista);
        }
        */
        public static string MostrarLista(List<int> lista)
        {
            string texto = "";

            foreach (int num in lista)
            {
                texto += $"{num.ToString()} ";
            }

            return texto;
        }

        public static void LeerLista(List<int> listaNumeros)
        {
            int num, posicion = 0;
            string respuesta = "";

            do
            {
                num = LeerNumero($"Introduce un número (posición {posicion++} de la lista): ");

                listaNumeros.Add(num);

                Console.WriteLine("¿Quieres introducir otro valor? (S/N): ");
                respuesta = Console.ReadLine();

            } while (respuesta == "S" || respuesta == "s");
        }

        public static void CopiarPares(List<int> listaNumeros, List<int> listaPares)
        {
            foreach (int pares in listaNumeros)
            {
                if (pares % 2 == 0)
                {
                    listaPares.Add(pares);
                }
            }
        }

        public static void MoverPares(List<int> listaNumeros, List<int> listaPares)
        {
            for (int i = 0; i < listaNumeros.Count; i++)
            {
                if (listaNumeros[i] % 2 == 0)
                {
                    listaPares.Add(listaNumeros[i]);
                    listaNumeros.RemoveAt(i);
                    i--;
                }
            }
        }

        public static int Menu()
        {
            int opcion;

            Console.WriteLine("\n■ Copiar y mover pares ­■" +
                              "\n1. Leer lista." +
                              "\n2. Mostrar lista de numeros." +
                              "\n3. Copiar pares a nueva lista." +
                              "\n4. Mover pares a nueva lista." +
                              "\n5. Mostrar todas las listas después de las operaciones." +
                              "\n6. Salir del programa.");

            opcion = LeerNumero("Introduce una opción del menú: ");

            return opcion;
        }
    }
}
