using Supabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema9_Tarea03.Repositories
{
    public class VideoGamesRepository
    {
        private readonly Client _client;

        public VideoGamesRepository(Client client)
        {
            _client = client;
        }


    }
}
