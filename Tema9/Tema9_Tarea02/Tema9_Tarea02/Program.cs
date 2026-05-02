using Supabase;
using System.Threading.Tasks;
using Tema9_Tarea02.Controllers;
using Tema9_Tarea02.Data;
using Tema9_Tarea02.Models;
using Tema9_Tarea02.Repositories;
using Tema9_Tarea02.Views;

namespace Tema9_Tarea02
{
    internal class Program
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
                option = ConsoleView.Menu();

                switch (option)
                {
                    case 1:
                        await ConsoleView.SafeExecuteAsync(async () =>
                        {
                            await ConsoleView.PrintAllStudents(controller);
                        });

                        break;
                    case 2:
                        await ConsoleView.SafeExecuteAsync(async () =>
                        {
                            Console.Write("Introduce el nombre del estudiante: ");
                            var name = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(name))
                            {
                                Console.WriteLine("El nombre no puede estar vacío.");
                                return;
                            }

                            Console.Write("Introduce su DNI: ");
                            var dni = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(dni))
                            {
                                Console.WriteLine("El DNI no puede estar vacío.");
                                return;
                            }

                            var age = ConsoleView.ReadInteger("Introduce su edad: ");

                            await controller.CreateAsync(name, dni, age);

                            Console.WriteLine("Estudiante añadido correctamente.");
                        });

                        break;
                    case 3:
                        await ConsoleView.SafeExecuteAsync(async () =>
                        {
                            var id = ConsoleView.ReadInteger("Introduce el ID del estudiante a mostrar: ");

                            var student = await controller.GetAsyncId(id);

                            if (student is null)
                            {
                                Console.WriteLine("No hay ningún estudiante con ese ID.");
                                return;
                            }

                            Console.WriteLine(student);
                        });

                        break;
                    case 4:
                        await ConsoleView.SafeExecuteAsync(async () =>
                        {
                            Console.Write("Introduce el DNI del estudiante: ");
                            var dni = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(dni))
                            {
                                Console.WriteLine("El DNI no puede estar vacío.");
                                return;
                            }

                            var student = await controller.GetAsyncDni(dni);

                            if (student is null)
                            {
                                Console.WriteLine("No hay ningún estudiante con ese DNI");
                                return;
                            }

                            Console.WriteLine(student);
                        });

                        break;
                    case 5:
                        await ConsoleView.SafeExecuteAsync(async () =>
                        {
                            var id = ConsoleView.ReadInteger("Introduce el ID del estudiante a eliminar: ");

                            var student = await controller.GetAsyncId(id);

                            if (student is null)
                            {
                                Console.WriteLine("No hay ningún estudiante con ese ID");
                                return;
                            }

                            await controller.DeleteAsyncId(id);

                            Console.WriteLine("Estudiante eliminado correctamente.");
                        });

                        break;
                    case 6:
                        await ConsoleView.SafeExecuteAsync(async () =>
                        {
                            Console.Write("Introduce el DNI del estudiante: ");
                            var dni = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(dni))
                            {
                                Console.WriteLine("El DNI no puede estar vacío.");
                                return;
                            }

                            var student = await controller.GetAsyncDni(dni);
                            
                            if (student is null)
                            {
                                Console.WriteLine("No hay ningún estudiante con ese DNI.");
                                return;
                            }

                            await controller.DeleteAsyncDni(dni);

                            Console.WriteLine("Estudiante eliminado correctamente.");
                        });

                        break;
                    case 7:
                        await ConsoleView.SafeExecuteAsync(async () =>
                        {
                            var id = ConsoleView.ReadInteger("Introduce el ID del estudiante a actualizar: ");

                            var student = await controller.GetAsyncId(id);

                            if (student is null)
                            {
                                Console.WriteLine("No hay ningún estudiante con ese ID.");
                                return;
                            }

                            Console.WriteLine("Actualiza los datos del estudiante necesarios:");

                            Console.Write("Nombre: ");
                            var newName = Console.ReadLine();

                            Console.Write("DNI: ");
                            var newDni = Console.ReadLine();

                            var newAge = ConsoleView.ReadInteger("Edad: ");

                            await controller.UpdateAsync(student, newName, newDni, newAge);

                            Console.WriteLine("Datos modificados correctamente.");
                        });

                        break;
                }

            } while (option != 8);

            Console.WriteLine("Pulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
