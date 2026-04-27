using Supabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema9_Tarea01.Models;

namespace Tema9_Tarea01.Repositories
{
    public class StudentsRepository
    {
        private readonly Client _client;
        public StudentsRepository(Client client)
        {
            _client = client;
        }

        // Obtener la lista de estudiantes.
        public async Task<List<Student>> GetAllAsync()
        {
            var response = await _client.From<Student>().Get();

            // La convierte en una lista del modelo. Devuelve lista vacía si hay un problema.
            return response.Models ?? new List<Student>();
        }

        // Añadir un estudiante.
        public async Task<Student?> InsertAsync(Student student)
        {
            var response = await _client.From<Student>().Insert(student);

            return response.Models?.FirstOrDefault() ?? null;
        }

        // Actualizar un estudiante.
        public async Task<Student?> UpdateAsync(Student student)
        {
            var response = await _client.From<Student>().Update(student);

            return response.Models?.FirstOrDefault() ?? null;
        }

        // Borrar por ID mediante el modelo con la PK (primary key), evitando el filter.
        public async Task<bool> DeleteAsync(int id)
        {
            var toDelete = new Student(id, string.Empty, 0); // Solo importa el ID.
            var response = await _client.From<Student>().Delete(toDelete);

            return response.Models != null && response.Models.Count > 0;
        }
    }
}
