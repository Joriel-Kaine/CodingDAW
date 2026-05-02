using Supabase.Postgrest.Converters;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
        public Task<List<Student>> GetAllAsync() => _repo.GetAllAsync();

        // Crear desde datos primitivos
        public async Task<Student?> CreateAsync(string name, string dni, int age)
        {
            var patron = @"^[0-9]{8}[A-Z]$";
            var isExisting = await _repo.GetByDniAsync(dni);

            // Validación mínima (opcional). Si no la quieres, quítala.
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("El nombre no puede estar vacío.", nameof(name));
            }

            if (!name.All(character => char.IsLetter(character) || character == ' '))
            {
                throw new ArgumentException("El nombre debe estar compuesto por letras.", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(dni))
            {
                throw new ArgumentException("El DNI no puede estar vacío.", nameof(dni));
            }

            if (!Regex.IsMatch(dni, patron))
            {
                throw new ArgumentException(nameof(dni), "El DNI no tiene el formato correcto.");
            }

            if (isExisting is not null)
            {
                throw new ArgumentException(nameof(dni), "El DNI ya existe y no puede ser introducido.");
            }

            if (age < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "La edad no puede ser negativa");
            }

            var student = new Student(null, name.Trim(), dni.Trim(), age);

            return await _repo.InsertAsync(student);
        }

        // Mostrar usando el ID.
        public async Task<Student?> GetAsyncId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Id debe ser > 0");
            }

            return await _repo.GetByIdAsync(id);
        }

        // Mostrar usando el DNI.
        public async Task<Student?> GetAsyncDNI(string dni)
        {
            var patron = @"^[0-9]{8}[A-Z]$";

            if (string.IsNullOrWhiteSpace(dni))
            {
                throw new ArgumentException(nameof(dni), "El DNI no puede estar vacío.");
            }

            if (!Regex.IsMatch(dni, patron))
            {
                throw new ArgumentException(nameof(dni), "El DNI no tiene el formato correcto.");
            }

            return await _repo.GetByDniAsync(dni);
        }

        // Eliminar usando el ID.
        public async Task<bool> DeleteAsyncId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Id debe ser > 0");
            }

            return await _repo.DeleteAsyncId(id);
        }

        // Eliminar un estudiante usando el DNI.
        public async Task<bool> DeleteAsyncDni(string dni)
        {
            var patron = @"^[0-9]{8}[A-Z]$";

            if (string.IsNullOrWhiteSpace(dni))
            {
                throw new ArgumentException(nameof(dni), "El DNI no puede estar vacío.");
            }

            if (!Regex.IsMatch(dni, patron))
            {
                throw new ArgumentException(nameof(dni), "El DNI no tiene el formato correcto.");
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
                if (string.IsNullOrWhiteSpace(newName))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.", nameof(newName));
                }

                student.Name = newName.Trim();
            }

            if (newDni is not null)
            {
                var patron = @"^[0-9]{8}[A-Z]$";

                if (string.IsNullOrWhiteSpace(newDni))
                {
                    throw new ArgumentException("El DNI no puede estar vacío.", nameof(newDni));
                }

                if (!Regex.IsMatch(newDni, patron))
                {
                    throw new ArgumentException(nameof(newDni), "El DNI no tiene el formato correcto.");
                }

                student.Dni = newDni.Trim();
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
    }
}
