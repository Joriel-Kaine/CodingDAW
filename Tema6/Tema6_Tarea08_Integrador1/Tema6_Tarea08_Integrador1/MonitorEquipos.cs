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

                } while (IP[i] == "");


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

        public static void CargarDatosAutomatico(string[] IP, string[] IP2,
                                                 int[] latencia, int[] latencia2)
        {
            for (int i = 0; i < IP.Length; i++)
            {
                IP[i] = IP2[i];
                latencia[i] = latencia2[i];
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

        public static int BuscarIP(string[] IP, string direccionIP)
        {
            int resultado = -1;

            for (int i = 0; i < IP.Length; i++)
            {
                if (IP[i] == direccionIP)
                {
                    resultado = i;
                }
            }

            return resultado;
        }

        public static void ObtenerEstadisticas(int[] latencia, out int mayor,
                                               out int menor, out double media)
        {
            int suma = 0;
            mayor = latencia[0]; menor = latencia[0];

            for (int i = 0; i < latencia.Length; i++)
            {
                if (mayor < latencia[i])
                {
                    mayor = latencia[i];
                }

                if (menor > latencia[i])
                {
                    menor = latencia[i];
                }

                suma += latencia[i];
            }

            media = (double)suma / latencia.Length;
        }

        private static void IntercambiarIP(ref string IP1, ref string IP2)
        {
            string aux;

            aux = IP1;
            IP1 = IP2;
            IP2 = aux;
        }

        private static void IntercambiarLatencia(ref int latencia1, ref int latencia2)
        {
            int aux;

            aux = latencia1;
            latencia1 = latencia2;
            latencia2 = aux;
        }

        public static void OrdenarPorLatencia(string[] IP, int[] latencia)
        {
            int tamano = latencia.Length;

            for (int i = 0; i < tamano - 1; i++)
            {
                for (int j = i + 1; j < tamano; j++)
                {
                    if (latencia[i] > latencia[j])
                    {
                        IntercambiarLatencia(ref latencia[i], ref latencia[j]);
                        IntercambiarIP(ref IP[i], ref IP[j]);
                    }
                }
            }
        }

        public static int Menu()
        {
            int opcion;

            Console.WriteLine("\nIPs + Latencias\n" +
                              "\n1. Cargar datos manualmente." +
                              "\n2. Cargar datos automáticamente (para pruebas)." +
                              "\n3. Listar equipos." +
                              "\n4. Buscar una IP y mostrar latencia." +
                              "\n5. Mostrar estadísticas (max, min, media)." +
                              "\n6. Ordenar por latencia (menor a mayor)." +
                              "\n7. Salir del programa.");

            opcion = LeerNumero("\nIntroduce una opción del menú: ");
            Console.WriteLine();

            return opcion;
        }
    }
}
