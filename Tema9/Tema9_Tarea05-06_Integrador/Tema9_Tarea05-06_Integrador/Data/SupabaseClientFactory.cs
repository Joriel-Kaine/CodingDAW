using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supabase;

namespace Tema9_Tarea05_06_Integrador.Data
{
    public static class SupabaseClientFactory
    {
        private static Client? _client;
        private static bool _initialized = false;

        private const string SUPABASE_URL_ENV = "SUPABASE_URL";
        private const string SUPABASE_ANON_KEY_ENV = "SUPABASE_ANON_KEY";

        public static async Task<Client> GetClientAsync()
        {
            if (_initialized && _client is not null)
            {
                return _client;
            }

            var url = Environment.GetEnvironmentVariable(SUPABASE_URL_ENV);
            var key = Environment.GetEnvironmentVariable(SUPABASE_ANON_KEY_ENV);

            if (string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(key))
            {
                throw new InvalidOperationException("Faltan variables de entorno SUPABASE_URL o SUPABASE_ANON_KEY");
            }

            var options = new SupabaseOptions
            {
                AutoConnectRealtime = false
            };

            _client = new Client(url, key, options);
            await _client.InitializeAsync();

            _initialized = true;
            return _client;
        }
    }
}
