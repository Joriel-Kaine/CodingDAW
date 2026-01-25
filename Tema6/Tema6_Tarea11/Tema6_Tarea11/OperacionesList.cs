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

        public static void LeerListaBase(List<int> listaBase)
        {
            int bbase;
            string respuesta = "";

            do
            {
                bbase = LeerNumero($"Introduce un número (posición {listaBase.Count} de la lista): ");

                listaBase.Add(bbase);

                Console.Write("¿Quieres introducir otro valor? (S/N): ");
                respuesta = Console.ReadLine();

            } while (respuesta.ToUpper() == "S");
        }

        public static void LeerListaExponente(List<int> listaExponente)
        {
            int exponente;
            string respuesta = "";

            do
            {
                exponente = LeerNumero($"Introduce un número (posición {listaExponente.Count} de la lista): ");

                listaExponente.Add(exponente);

                Console.Write("¿Quieres introducir otro valor? (S/N): ");
                respuesta = Console.ReadLine();

            } while (respuesta.ToUpper() == "S");
        }

        private static int Potencia(int bbase, int exponente)
        {
            int potencia = 1;

            for (int i = 0; i < exponente; i++)
            {
                potencia *= bbase;
            }

            return potencia;
        }

        public static void ListaPotencia(List<int> listaBase, List<int> listaExponente, List<int> listaPotencia)
        {
            int menor = listaBase.Count;

            if (menor > listaExponente.Count)
            {
                menor = listaExponente.Count;
            }

            for (int i = 0; i < menor; i++)
            {
                listaPotencia.Add(Potencia(listaBase[i], listaExponente[i]));
            }
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

        public static int Menu()
        {
            int opcion;

            Console.WriteLine("\n■ Potencias ■" +
                              "\n1. Leer bases." +
                              "\n2. Leer exponentes." +
                              "\n3. Calcular potencias." +
                              "\n4. Mostrar listas." +
                              "\n5. Salir del programa.");

            opcion = LeerNumero("\nIntroduce una opción del menú: ");
            Console.WriteLine();

            return opcion;
        }
    }
}
