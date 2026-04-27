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

        public async Task<List<Student>> GetAllAsync()
        {
            var response = await _client.From<Student>().Get();

            return response.Models ?? new List<Student>();
        }

        public async Task<Student?> InsertAsync(Student student)
        {
            var response = await _client.From<Student>().Insert(student);
            return response.Models?.FirstOrDefault() ?? null;
        }
    }
}
