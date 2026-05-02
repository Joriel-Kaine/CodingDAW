using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema9_Tarea02.Controllers;

namespace Tema9_Tarea02.Views
{
    public static class ConsoleView
    {
        public static int LeerMenu(string mensaje)
        {
            int num;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = int.TryParse(Console.ReadLine(), out num);

                if (esCorrecto && (num < 1 || num > 8))
                {
                    Console.WriteLine("Introduce una opción correcta.");
                }

            } while (!esCorrecto || (num < 1 || num > 8));

            return num;
        }

        public static int Menu()
        {
            int opcion;

                Console.WriteLine("\n   ==== MENÚ ====\n" +
                                  "\n1. Mostrar todos los estudiantes." +
                                  "\n2. Introducir estudiante nuevo." +
                                  "\n3. Mostrar datos de un estudiante (por ID)." +
                                  "\n4. Mostrar datos de un estudiante (por DNI)." +
                                  "\n5. Eliminar estudiante (por ID)." +
                                  "\n6. Eliminar estudiante (por DNI)." +
                                  "\n7. Editar los datos de un estudiante." +
                                  "\n8. Salir del programa.");

                opcion = LeerMenu("\nIntroduce una opción del menú: ");
                Console.WriteLine();

            return opcion;
        }

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
                    Console.WriteLine("Introduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        public static async Task SafeExecuteAsync(Func<Task> action)
        {
            try
            {
                await action ();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }

        public static async Task PrintAllStudents(StudentsController controller)
        {
            var students = await controller.GetAllAsync();

            if (students.Count == 0)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
