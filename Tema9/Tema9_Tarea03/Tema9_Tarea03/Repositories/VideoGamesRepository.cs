using Supabase;
using static Supabase.Postgrest.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema9_Tarea03.Models;

namespace Tema9_Tarea03.Repositories
{
    public class VideoGamesRepository
    {
        private readonly Client _client;

        public VideoGamesRepository(Client client)
        {
            _client = client;
        }

        // Lista de Videojuegos.
        public async Task<List<VideoGame>> GetAllAsync()
        {
            var response = await _client
                .From<VideoGame>()
                .Get();

            return response.Models ?? new List<VideoGame>();
        }

        // Añadir un videojuego.
        public async Task<VideoGame?> InsertVideoGame(VideoGame videoGame)
        {
            var response = await _client
                .From<VideoGame>()
                .Insert(videoGame);

            return response.Models?.FirstOrDefault() ?? null;
        }

        public async Task<VideoGame?> GetByAppIdAsync(int appId)
        {
            var response = await _client
                .From<VideoGame>()
                .Filter("appid", Operator.Equals, appId)
                .Single();

            return response;
        }




    }
}
