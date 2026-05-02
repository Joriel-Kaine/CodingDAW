using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tema9_Tarea03.Models
{
    [Table("videogames")]
    public class VideoGame : BaseModel
    {
        [PrimaryKey("id", false)]
        public Guid Id { get; set; }
        [Column("appid")]   
        public int AppId { get; set; }
        [Column("name")]
        public string Name { get; set; } = "";
        [Column("genre")]
        public string Genre { get; set; } = "";
        [Column("year")]
        public int Year { get; set; }
        [Column("rating")]
        public double Rating { get; set; }
        [Column("price")]
        public decimal Price { get; set; }

        public VideoGame() { }

        public VideoGame(int appId, string name, string genre, int year, double rating, decimal price)
        {
            AppId = appId;
            Name = name;
            Genre = genre;
            Year = year;
            Rating = rating;
            Price = price;
        }

        public override string ToString()
            => $"{AppId} | {Name} | {Genre} | {Year} | {Rating} | {Price:C2}";
    }
}
