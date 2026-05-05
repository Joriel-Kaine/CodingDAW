using Supabase;
using System.Threading.Tasks;
using Tema9_Tarea02.Controllers;
using Tema9_Tarea02.Data;
using Tema9_Tarea02.Models;
using Tema9_Tarea02.Repositories;

namespace Tema9_Tarea02
{
    internal class ConsoleView
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("\nTema 9 - Tarea 2: Manuel MR ®\n" +
                              "═════════════════════════════\n\n");

            int option;
            Client client = await SupabaseClientFactory.GetClientAsync();
            var repo = new StudentsRepository(client);
            var controller = new StudentsController(repo);

            do
            {
                option = Menu();

                switch (option)
                {
                    case 1:
                        await SafeExecuteAsync(async () =>
                        {
                            await PrintAllStudents(controller);
                        });

                        break;
                    case 2:
                        await SafeExecuteAsync(async () =>
                        {
                            var name = ReadString("Introduce el nombre del estudiante: ", "nombre");

                            var dni = ReadString("Introduce su DNI: ", "DNI");

                            var age = ReadInteger("Introduce su edad: ");

                            await controller.CreateAsync(name, dni, age);

                            Console.WriteLine("Estudiante añadido correctamente.");
                        });

                        break;
                    case 3:
                        await SafeExecuteAsync(async () =>
                        {
                            var id = ReadInteger("Introduce el ID del estudiante a mostrar: ");

                            var student = await controller.GetAsyncId(id);

                            Console.WriteLine(student);
                        });

                        break;
                    case 4:
                        await SafeExecuteAsync(async () =>
                        {
                            var dni = ReadString("Introduce el DNI del estudiante: ", "DNI");

                            var student = await controller.GetAsyncDni(dni);

                            Console.WriteLine(student);
                        });

                        break;
                    case 5:
                        await SafeExecuteAsync(async () =>
                        {
                            var id = ReadInteger("Introduce el ID del estudiante a eliminar: ");

                            await controller.DeleteAsyncId(id);

                            Console.WriteLine("Estudiante eliminado correctamente.");
                        });

                        break;
                    case 6:
                        await SafeExecuteAsync(async () =>
                        {
                            var dni = ReadString("Introduce el DNI del estudiante: ", "DNI");

                            await controller.DeleteAsyncDni(dni);

                            Console.WriteLine("Estudiante eliminado correctamente.");
                        });

                        break;
                    case 7:
                        await SafeExecuteAsync(async () =>
                        {
                            var id = ReadInteger("Introduce el ID del estudiante a actualizar: ");

                            var student = await controller.GetAsyncId(id);

                            Console.WriteLine("Actualiza los datos del estudiante necesarios:");

                            Console.Write("Nombre (intro para no cambiar): ");
                            var newName = Console.ReadLine();
                            var newNameFinal = string.IsNullOrWhiteSpace(newName) ? null : newName;

                            Console.Write("DNI (intro para no cambiar): ");
                            var newDni = Console.ReadLine();
                            var newDniFinal = string.IsNullOrWhiteSpace(newDni) ? null : newDni;

                            var newAge = ReadNullInteger("Edad (intro para no cambiar): ");

                            await controller.UpdateAsync(student, newNameFinal, newDniFinal, newAge);

                            Console.WriteLine("Datos modificados correctamente.");
                        });

                        break;
                }

            } while (option != 8);

            Console.WriteLine("Pulsa una tecla para salir...");
            Console.ReadKey();
        }


        // Métodos auxiliares.
        private static int ReadMenu(string message)
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

        private static int Menu()
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

        private static int ReadInteger(string message)
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

        private static string ReadString(string message, string displayName)
        {
            Console.Write(message);
            var value = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"El {displayName} no puede estar vacío.");
            }

            return value;
        }

        private static int? ReadNullInteger(string message)
        {
            Console.Write(message);
            var value = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(value))
            {
                return null;
            }

            if (!int.TryParse(value, out int num))
            {
                throw new FormatException("Introduce valores numéricos válidos.");
            }

            return num;
        }

        private static async Task SafeExecuteAsync(Func<Task> action)
        {
            try
            {
                await action();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }

        private static async Task PrintAllStudents(StudentsController controller)
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
