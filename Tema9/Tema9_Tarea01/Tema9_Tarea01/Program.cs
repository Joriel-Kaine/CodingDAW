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

            var client = await SupabaseClientFactory.GetClientAsync();
            var repo = new StudentsRepository(client);

            var inserted = await repo.InsertAsync(new Student(null, "Lito Kaine", 38));
            Console.WriteLine($"Insertado: {inserted?.Id} - {inserted?.Name} - {inserted?.Age}");

            var students = await repo.GetAllAsync();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} - {student.Name} - {student.Age}");
            }

            Console.WriteLine("Pulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
