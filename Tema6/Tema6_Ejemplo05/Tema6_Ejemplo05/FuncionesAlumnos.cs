using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Ejemplo05
{
    public class FuncionesAlumnos
    {
        private static int LeerNumero(string mensaje)
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

        public static void LeerAlumnosYNotas(string[] vectorAlumnos, int[] vectorNotas)
        {
            // Leemos todos los elementos del vector.
            for (int i = 0; i < vectorAlumnos.Length; i++)
            {
                Console.Write($"Introduce el nombre del alumno {i}: ");
                vectorAlumnos[i] = Console.ReadLine();

                do
                {
                    vectorNotas[i] = LeerNumero($"Introduce la nota de {vectorAlumnos[i]} (entre 0 y 10): ");

                } while (vectorNotas[i] < 0 || vectorNotas[i] > 10);
            }
        }

        // Mostramos el listado con todos los alumnos y sus notas.
        public static string MostrarAlumnosYNotas(string[] vectorAlumnos, int[] vectorNotas)
        {
            string texto = "Listado: \n";

            for (int i = 0; i < vectorAlumnos.Length; i++)
            {
                texto += $"{vectorAlumnos[i]}: {vectorNotas[i]} \n";
            }

            return texto;
        }

        // Método para intercambiar dos notas.
        private static void IntercambiarNotas(ref int nota1, ref int nota2)
        {
            int aux;

            aux = nota1;
            nota1 = nota2;
            nota2 = aux;
        }

        // Método para intercambiar dos nombres.
        private static void IntercambiarNombres(ref string nombre1, ref string nombre2)
        {
            string aux;

            aux = nombre1;
            nombre1 = nombre2;
            nombre2 = aux;
        }

        // Método que devuelve la posición de un alumno.
        // Devuelve -1 si no lo encuentra.
        public static int BuscarAlumno(string[] vectorAlumnos, string nombre)
        {
            int resultado, contador = 0;
            bool esEncontrado = false;

            while (!esEncontrado && contador < vectorAlumnos.Length)
            {
                if (vectorAlumnos[contador] == nombre)
                {
                    esEncontrado = true;
                }
                else
                {
                    contador++;
                }
            }

            if (esEncontrado)
            {
                resultado = contador;
            }
            else
            {
                resultado = -1;
            }

            return resultado;
        }

        // Algoritmo de ordenación.
        public static void OrdenarVectoresPorNotas(string[] vectorAlumnos, int[] vectorNotas)
        {
            int tamano = vectorAlumnos.Length;

            for (int i = 0; i < tamano - 1; i++)
            {
                for (int j = i + 1; j < tamano; j++)
                {
                    IntercambiarNotas(ref vectorNotas[i], ref vectorNotas[j]);
                    // También intercambiamos los nombres para que estén en la misma posición.
                    IntercambiarNombres(ref vectorAlumnos[i], ref vectorAlumnos[j]);
                }
            }
        }

        public static void OrdenarVectoresPorNombres(string[] vectorAlumnos, int[] vectorNotas)
        {
            int tamano = vectorAlumnos.Length;

            for (int i = 0; i < tamano - 1; i++)
            {
                for (int j = i + 1; j < tamano; j++)
                {
                    // Si es menor que 0 significa que la cadena j es menor alfabéticamente que la cadena i.
                    if (string.Compare(vectorAlumnos[j], vectorAlumnos[i]) < 0)
                    {
                        IntercambiarNombres(ref vectorAlumnos[i], ref vectorAlumnos[j]);
                        // También intercambiamos las notas para que estén en la misma posición.
                        IntercambiarNotas(ref vectorNotas[i], ref vectorNotas[j]);
                    }
                }
            }
        }

        public static int Menu()
        {
            int opcion;

            Console.WriteLine("\n   MENÚ\n" +
                              "\n1. Introducir todos los datos." +
                              "\n2. Mostrar todos los datos." +
                              "\n3. Buscar alumno." +
                              "\n4. Ordenar por notas." +
                              "\n5. Ordenar alfabéticamente." +
                              "\n6. Salir del programa.");

            opcion = LeerNumero("\nIntroduce una opción del menú: ");

            Console.WriteLine(); // Línea en blanco.

            return opcion;
        }
    }
}
