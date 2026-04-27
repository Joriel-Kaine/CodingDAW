using Supabase;
using Tema9_Tarea01.Controllers;
using Tema9_Tarea01.Data;
using Tema9_Tarea01.Models;
using Tema9_Tarea01.Repositories;

namespace Tema9_Tarea01
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("\nTema 9 - Tarea 1: Manuel MR ®\n" +
                              "═════════════════════════════\n\n");

            try
            {
                // Inicializar cliente, repositorio y controlador
                Client client = await SupabaseClientFactory.GetClientAsync();
                var repo = new StudentsRepository(client);
                var controller = new StudentsController(repo);

                Console.WriteLine("=== PRUEBAS CON CONTROLADOR (flujo secuencial) ===");

                // 1) Crear estudiante.
                Console.WriteLine("\n-- Creando estudiante...");
                var created = await controller.CreateAsync("Alumno controlador", 19);
                Console.WriteLine($"Creado: {created?.Id} - {created?.Name} - {created?.Age}");

                // 2) Listar todos.
                await MostrarLista(controller, "\n-- Lista tras Create:");

                // 3) Actualizar usando el mismo objeto creado.
                if (created is not null)
                {
                    Console.WriteLine("\n-- Actualizando estudiante (solo nombre y edad)...");

                    var updated = await controller.UpdateAsync(created, newName: "Alumno actualizado", newAge: 20);

                    Console.WriteLine(updated is null
                        ? "Update devolvió null. "
                        : $"Actualizado: {updated.Id} - {updated.Name} - {updated.Age}");
                }

                // 4) Listar de nuevo.
                await MostrarLista(controller, "\n-- Lista tras Update:");

                // 5) Borrar.
                if (created?.Id is int idTodelete) // Porque inserted.Id es nullable.
                {
                    Console.WriteLine("\n-- Borrando estudiante...");

                    var deleted = await controller.DeleteAsync(idTodelete);

                    Console.WriteLine(deleted ? "Borrado OK." : "No se encontró para borrar.");
                }

                // 6) Lista final.
                await MostrarLista(controller, "\n-- Lista final tras Delete:");

                Console.WriteLine("\n=== FIN DE PRUEBAS ===");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n*** ERROR DURANTE LAS PRUEBAS ***");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Pulsa una tecla para salir...");
            Console.ReadKey();
        }

        static async Task MostrarLista(StudentsController controller, string titulo)
        {
            Console.WriteLine(titulo);

            var students = await controller.GetAllAsync();

            if (students.Count == 0)
            {
                Console.WriteLine("(Lista vacía)");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} - {student.Name} - {student.Age}");
            }
        }
    }
}
