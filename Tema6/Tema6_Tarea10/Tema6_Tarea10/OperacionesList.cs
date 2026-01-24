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

        public static List<int> LeerLista(int numElementos)
        {
            List<int> listaNumeros = new();
            int num;

            for (int i = 0; i < numElementos; i++)
            {
                num = LeerNumero($"Introduce un número ({i + 1} de {numElementos}): ");

                listaNumeros.Add(num);
            }

            return listaNumeros;
        }
    }
}
