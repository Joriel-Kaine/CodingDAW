using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea03
{
    public static class FuncionesInterfaz
    {
        const string Error = "\nIntroduce valores numéricos válidos.";

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
                    Console.WriteLine(Error);
                }

            } while (!esCorrecto);

            return num;
        }

        public static double LeerNota(string mensaje)
        {
            double nota;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = double.TryParse(Console.ReadLine(), out nota);

                if (!esCorrecto)
                {
                    Console.WriteLine(Error);
                }

                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("\nLa nota debe estar entre 0 y 10.");
                    esCorrecto = false;
                }

            } while (!esCorrecto);

            return nota;
        }

        public static string LeerNombre()
        {
            string nombre;

            Console.Write("\nIntroduce el nombre: ");
            nombre = Console.ReadLine();

            return nombre;
        }

        public static int Menu()
        {
            int opcion;

            Console.WriteLine("\n   ALUMNOS\n" +
                              "\n1. Mostrar nombres de los alumnos." +
                              "\n2. Introducir nuevo alumno." +
                              "\n3. Mostrar datos de un alumno." +
                              "\n4. Añadir nota de un alumno." +
                              "\n5. Eliminar un alumno." +
                              "\n6. Salir del programa.");

            opcion = LeerEntero("\nIntroduce una opción del menú: ");
            Console.WriteLine();

            return opcion;
        }

        public static void LeerDatosAlumno(ListaAlumnos listaAlumnos)
        {
            Alumno alumno = new();

            Console.Write("\nIntroduce el nombre: ");
            alumno.Nombre = Console.ReadLine();
            alumno.Edad = LeerEntero("\nIntroduce la edad: ");

            listaAlumnos.AddAlumno(alumno);
        }

        public static void AddNotaAlumno(ListaAlumnos listaAlumnos)
        {
            string nombre = LeerNombre();
            double nota = LeerNota("\nIntroduce la nota: ");

            bool esEncontrado = listaAlumnos.AddNotaAlumno(nombre, nota);

            if (esEncontrado)
            {
                Console.WriteLine("\nNota añadida");
            }
            else
            {
                Console.WriteLine($"\nEl alumno {nombre} no se ha encontrado.");
            }
        }
    }
}
