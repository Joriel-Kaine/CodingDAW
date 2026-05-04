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
        public static int ReadMenu(string message)
        {
            int num;
            bool isCorrect;

            do
            {
                Console.Write(message);
                isCorrect = int.TryParse(Console.ReadLine(), out num);

                if (isCorrect && (num < 1 || num > 8))
                {
                    Console.WriteLine("Introduce una opción correcta.");
                }

            } while (!isCorrect || (num < 1 || num > 8));

            return num;
        }

        public static int Menu()
        {
            int option;

            Console.WriteLine("\n   ==== MENÚ ====\n" +             
                              "\n1. Mostrar todos los estudiantes." +             
                              "\n2. Introducir estudiante nuevo." +           
                              "\n3. Mostrar datos de un estudiante (por ID)." +            
                              "\n4. Mostrar datos de un estudiante (por DNI)." +              
                              "\n5. Eliminar estudiante (por ID)." +            
                              "\n6. Eliminar estudiante (por DNI)." +                
                              "\n7. Editar los datos de un estudiante." +               
                              "\n8. Salir del programa.");
            
            option = ReadMenu("\nIntroduce una opción del menú: ");  
            Console.WriteLine();

            return option;
        }

        public static int ReadInteger(string message)
        {
            int num;
            bool isCorrect;

            Console.Write(message);
            isCorrect = int.TryParse(Console.ReadLine(), out num);

            if (!isCorrect)
            {
                throw new FormatException("Introduce valores numéricos válidos.");
            }

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
            var students = await controller.GetAsyncAll();

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
