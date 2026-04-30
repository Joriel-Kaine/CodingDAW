using Supabase;
using static Supabase.Postgrest.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema9_Tarea02.Models;
using System.Diagnostics.CodeAnalysis;

namespace Tema9_Tarea02.Repositories
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
            var response = await _client
                .From<Student>()
                .Get();

            // La convierte en una lista del modelo. Devuelve lista vacía si hay un problema.
            return response.Models ?? new List<Student>();
        }

        // Añadir un estudiante.
        public async Task<Student?> InsertAsync(Student student)
        {
            var response = await _client
                .From<Student>()
                .Insert(student);

            return response.Models?.FirstOrDefault() ?? null;
        }

        // Actualizar un estudiante.
        public async Task<Student?> UpdateAsync(Student student)
        {
            var response = await _client
                .From<Student>()
                .Update(student);

            return response.Models?.FirstOrDefault() ?? null;
        }

        // Borrar por ID mediante el modelo con la PK (primary key), evitando el filter.
        public async Task<bool> DeleteAsyncId(int? id)
        {
            var toDelete = new Student(id, string.Empty, string.Empty, 0); // Solo importa el ID.
            var response = await _client
                .From<Student>()
                .Delete(toDelete);

            return response.Models is not null && response.Models.Count > 0;
        }

        // Buscar un estudiante mediante su PK.
        public async Task<Student?> GetByDniAsync(string dni)
        {
            var response = await _client
                .From<Student>()
                .Filter("dni", Operator.Equals, dni)
                .Get();

            return response.Models?.FirstOrDefault();
        }

        // Borrar por DNI mediante el modelo.
        public async Task<bool> DeleteAsyncDni(string dni)
        {
            var student = await GetByDniAsync(dni);

            return student is not null && await DeleteAsyncId(student.Id);
        }
    }
}
