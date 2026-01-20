using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Tarea08_Integrador1
{
    public class MonitorEquipos
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

        public static void LeerDatosRed(string[] IP, int[] latencia)
        {
            int tamano = IP.Length;

            for (int i = 0; i < tamano; i++)
            {
                do
                {
                    Console.Write($"Introduce la IP del equipo ({i + 1} de {tamano}): ");
                    IP[i] = Console.ReadLine();

                    if (IP[i] is null || IP[i] == "")
                    {
                        Console.WriteLine("La IP no puede estar vacía.");
                    }

                } while (IP[i] is null || IP[i] == "");


                do
                {
                    latencia[i] = LeerNumero($"Introduce la latencia ({i + 1} de {tamano}): ");

                    if (latencia[i] < 0)
                    {
                        Console.WriteLine("\nLa latencia debe ser superior a 0.");
                    }

                } while (latencia[i] < 0);
            }
        }

        public static string ObtenerListadoRed(string[] IP, int[] latencia)
        {
            string texto = "Listado de direcciones IP y latencias:\n";
            int tamano = IP.Length;

            for (int i = 0; i < tamano; i++)
            {
                if (i < tamano - 1)
                {
                    texto += $"{IP[i]} - {latencia[i]}ms\n";
                }
                else
                {
                    texto += $"{IP[i]} - {latencia[i]}ms";
                }
            }

            return texto;
        }
    }
}
