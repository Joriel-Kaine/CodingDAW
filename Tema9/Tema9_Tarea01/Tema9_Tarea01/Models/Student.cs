using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Tema9_Tarea01.Models
{
    [Table("students")]
    public class Student : BaseModel
    {
        [PrimaryKey("id", false)]
        public int? Id { get; set; }
        [Column("name")]
        public string Name { get; set; } = "";
        [Column("age")]
        public int Age { get; set; }

        public Student() { }

        public Student(int? id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
