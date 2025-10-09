using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Integrador_Console
{
    internal class Program
    {
        const int minuto = 60;

        static void Main(string[] args)
        {
            Console.WriteLine("\n             ╔════════════════════════════╗\n" +
                                "             ║ Tema integrador: Manuel MR ║\n" +
                                "             ╚════════════════════════════╝\n\n");

            // Introducimos los valores para la suma total de la duración de las canciones.
            Console.Write("Introduce la duración de la primera canción: ");
            decimal firstSong = decimal.Parse(Console.ReadLine());
            
            Console.Write("Introduce la duración de la segunda canción: ");
            decimal secondSong = decimal.Parse(Console.ReadLine());

            Console.Write("Introduce la duración de la tercera canción: ");
            decimal thirdSong = decimal.Parse(Console.ReadLine());
            
            // Conseguimos el total de los segundos
            int segundos = (int)((firstSong - (int)firstSong) * 100) +
                           (int)((secondSong - (int)secondSong) * 100) +
                           (int)((thirdSong - (int)thirdSong) * 100);
            int totalSeg = segundos % minuto;

            // Conseguimos el total de minutos de las 3 canciones.
            int minutos = (int)firstSong + (int)secondSong + (int)thirdSong;
            int totalMin = minutos + (segundos / minuto);







            
            Console.WriteLine($"Duración total: {totalMin}  ------   {totalSeg}");
            Console.WriteLine($"╔══ Duración ════════════════════════════════════════╗\n" +
                              $"║                                                    ║\n" +
                              $"║                         Minutos:Segundos           ║\n" +
                              $"║                                                    ║\n" +
                              $"║    1ª Canción:            ");
        }
    }
}
