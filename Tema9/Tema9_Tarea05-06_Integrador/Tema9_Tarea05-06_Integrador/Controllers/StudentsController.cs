using Supabase.Postgrest.Converters;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tema9_Tarea02.Models;
using Tema9_Tarea02.Repositories;

namespace Tema9_Tarea02.Controllers
{
    public class StudentsController
    {
        private readonly StudentsRepository _repo;

        public StudentsController(StudentsRepository repo)
        {
            _repo = repo;
        }


        // Obtener toda la lista (el Program decide cómo mostrarla)
        public Task<List<Student>> GetAsyncAll() => _repo.GetAllAsync();

        // Crear desde datos primitivos
        public async Task<Student?> CreateAsync(string name, string dni, int age)
        {
            var isExisting = await _repo.GetByDniAsync(dni);

            // Validación mínima (opcional). Si no la quieres, quítala.
            NullWhiteSpaceValidation("nombre", name, nameof(name));

            if (!name.All(character => char.IsLetter(character) || character == ' '))
            {
                throw new ArgumentException("El nombre debe estar compuesto por letras.", nameof(name));
            }

            NullWhiteSpaceValidation("DNI", dni, nameof(dni));

            FormatDniValidation(dni, nameof(dni));

            if (isExisting is not null)
            {
                throw new ArgumentException("El DNI ya existe y no puede ser introducido.", nameof(dni));
            }

            if (age < 0)
            {
                throw new ArgumentOutOfRangeException("La edad no puede ser negativa.", nameof(age));
            }

            var student = new Student(null, name.Trim(), dni.Trim(), age);

            return await _repo.InsertAsync(student);
        }

        // Mostrar usando el ID.
        public async Task<Student> GetAsyncId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("El ID debe ser mayor que 0.", nameof(id));
            }

            var student = await _repo.GetByIdAsync(id);

            if (student is null)
            {
                throw new ArgumentException("No hay ningún estudiante con ese ID.", nameof(id));
            }

            return student;
        }

        // Mostrar usando el DNI.
        public async Task<Student> GetAsyncDni(string dni)
        {
            NullWhiteSpaceValidation("DNI", dni, nameof(dni));

            FormatDniValidation(dni, nameof(dni));

            var student = await _repo.GetByDniAsync(dni);

            if (student is null)
            {
                throw new ArgumentException("No hay ningún estudiante con ese DNI.", nameof(dni));
            }

            return student;
        }

        // Eliminar usando el ID.
        public async Task<bool> DeleteAsyncId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("El ID debe ser mayor que 0.", nameof(id));
            }

            var student = await _repo.GetByIdAsync(id);

            if (student is null)
            {
                throw new ArgumentException("No hay ningún estudiante con ese ID.", nameof(id));
            }

            return await _repo.DeleteAsyncId(id);
        }

        // Eliminar un estudiante usando el DNI.
        public async Task<bool> DeleteAsyncDni(string dni)
        {
            NullWhiteSpaceValidation("DNI", dni, nameof(dni));

            FormatDniValidation(dni, nameof(dni));

            var student = await _repo.GetByDniAsync(dni);

            if (student is null)
            {
                throw new ArgumentException("No hay ningún estudiante con ese DNI.", nameof(dni));
            }

            return await _repo.DeleteAsyncDni(dni);
        }

        // Actualizar un estudiante ya existente (normalmente obtenido desde la lista).
        public async Task<Student?> UpdateAsync(Student student, string? newName = null,
            string? newDni = null, int? newAge = null)
        {
            if (student is null)
            {
                throw new ArgumentNullException(nameof(student));
            }

            if (newName is not null)
            {
                NullWhiteSpaceValidation("nombre", newName, nameof(newName));

                if (!newName.All(character => char.IsLetter(character) || character == ' '))
                {
                    throw new ArgumentException("El nombre debe estar compuesto por letras.", nameof(newName));
                }

                student.Name = newName.Trim();
            }

            if (newDni is not null)
            {
                NullWhiteSpaceValidation("DNI", newDni, nameof(newDni));

                FormatDniValidation(newDni, nameof(newDni));

                var isExisting = await _repo.GetByDniAsync(newDni);

                if (isExisting is not null && isExisting.Id != student.Id)
                {
                    throw new ArgumentException("El DNI ya existe y no puede ser introducido.", nameof(newDni));
                }

                student.Dni = newDni.Trim();
            }

            if (newAge is not null)
            {
                if (newAge < 0)
                {
                    throw new ArgumentOutOfRangeException("La edad no puede ser negativa.", nameof(newAge));
                }

                student.Age = newAge.Value;
            }

            return await _repo.UpdateAsync(student);
        }


        // Métodos auxiliares.
        private void NullWhiteSpaceValidation(string displayName, string value, string paramName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"El {displayName} no puede estar vacío.", paramName);
            }
        }

        private void FormatDniValidation(string value, string paramName)
        {
            var pattern = @"^[0-9]{8}[A-Z]$";

            if (!Regex.IsMatch(value, pattern))
            {
                throw new ArgumentException($"El DNI no tiene el formato correcto.", paramName);
            }
        }
    }
}
