using Supabase.Postgrest.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema9_Tarea01.Models;
using Tema9_Tarea01.Repositories;

namespace Tema9_Tarea01.Controllers
{
    public class StudentsController
    {
        private readonly StudentsRepository _repo;

        public StudentsController(StudentsRepository repo)
        {
            _repo = repo;
        }

        // Crear estudiante desde datos primitivos
        public async Task<Student?> CreateAsync(string name, int age)
        {
            // Validación mínima (opcional). Si no la quieres, quítala.
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("El nombre no puede estar vacío.", nameof(name));
            }
            
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "La edad no puede ser negativa");
            }

            var student = new Student(null, name.Trim(), age);

            return await _repo.InsertAsync(student);
        }

        // Obtener toda la lista (el Program decide cómo mostrarla)
        public Task<List<Student>> GetAllAsync() => _repo.GetAllAsync();

        // Actualizar un estudiante ya existente (normalmente obtenido desde la lista).
        public async Task<Student?> UpdateAsync(Student student, string? newName = null, int? newAge = null)
        {
            if (student is null)
            {
                throw new ArgumentNullException(nameof(student));
            }

            if (newName is not null)
            {
                if (string.IsNullOrWhiteSpace(newName))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.", nameof(newName));
                }

                student.Name = newName.Trim();
            }

            if (newAge is not null)
            {
                if (newAge < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(newAge), "La edad no puede ser negativa.");
                }

                student.Age = newAge.Value;
            }

            return await _repo.UpdateAsync(student);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Id debe ser > 0");
            }

            return await _repo.DeleteAsync(id);
        }
    }
}
