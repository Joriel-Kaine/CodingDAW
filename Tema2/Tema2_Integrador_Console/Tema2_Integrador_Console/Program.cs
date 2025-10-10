using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Integrador_Console
{
    internal class Program
    {
        // Declaramos las constantes necesarias aquí.
        const int minuto = 60;
        const decimal IVA = 0.21m;
        const decimal USD = 1.1672m;
        const decimal GBP = 0.8740m;

        static void Main(string[] args)
        {
            // Con esto podemos mostrar el símbolo del euro(€) en el resultado.
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n             ╔════════════════════════════════╗\n" +
                                "             ║ Tema 2 - Integrador: Manuel MR ║\n" +
                                "             ╚════════════════════════════════╝\n\n\n");

            // Introducimos los valores para la suma total de la duración de las canciones.
            Console.Write("Introduce la duración de la primera canción: ");
            decimal firstSong = decimal.Parse(Console.ReadLine());
            
            Console.Write("\nIntroduce la duración de la segunda canción: ");
            decimal secondSong = decimal.Parse(Console.ReadLine());

            Console.Write("\nIntroduce la duración de la tercera canción: ");
            decimal thirdSong = decimal.Parse(Console.ReadLine());
            
            // Conseguimos el total de los segundos
            int segundos = (int)((firstSong - (int)firstSong) * 100) +
                           (int)((secondSong - (int)secondSong) * 100) +
                           (int)((thirdSong - (int)thirdSong) * 100);
            int totalSeg = segundos % minuto;

            // Conseguimos el total de minutos de las 3 canciones.
            int minutos = (int)firstSong + (int)secondSong + (int)thirdSong;
            int totalMin = minutos + (segundos / minuto);

            // Pedimos que pulse una tecla para mostrar en consola el resultado de la operación.
            Console.WriteLine("\nPulsa Intro para mostrar la suma de las canciones...");
            Console.ReadKey();

            // Limpiamos la consola.
            Console.Clear();

            Console.WriteLine("\n             ╔════════════════════════════════╗\n" +
                                "             ║ Tema 2 - Integrador: Manuel MR ║\n" +
                                "             ╚════════════════════════════════╝\n\n\n");

            // Mostramos, de manera estructurada, los datos introducidos anteriormente y el total de la operación.
            Console.WriteLine($"╔══ Duración ══════════════════════════════════════════════╗\n" +
                              $"║                                                          ║\n" +
                              $"║                            Minutos : Segundos            ║\n" +
                              $"║                                                          ║\n" +
                              $"║       1ª Canción:             {(int)firstSong:D2}    :    {(int)((firstSong - (int)firstSong) * 100):D2}              ║\n" +
                              $"║                                                          ║\n" +
                              $"║       2ª Canción:             {(int)secondSong:D2}    :    {(int)((secondSong - (int)secondSong) * 100):D2}              ║\n" +
                              $"║                                                          ║\n" +
                              $"║       3ª Canción:             {(int)thirdSong:D2}    :    {(int)((thirdSong - (int)thirdSong) * 100):D2}              ║\n" +
                              $"║                                                          ║\n" +
                              $"║                                                          ║\n" +
                              $"║                                                          ║\n" +
                              $"║          Duración total:  {totalMin:D2}:{totalSeg:D2}                          ║\n" +
                              $"║                                                          ║\n" +
                              $"╚══════════════════════════════════════════════════════════╝");

            // Pedimos que pulse una tecla nuevamente para la siguiente parte de la tarea.
            Console.WriteLine("\nPulsa Intro para continuar con la siguiente parte...");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("\n             ╔════════════════════════════════╗\n" +
                                "             ║ Tema 2 - Integrador: Manuel MR ║\n" +
                                "             ╚════════════════════════════════╝\n\n\n");

            // Introducimos los valores necesarios.
            Console.Write("Introduce el precio base: ");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            Console.Write("\nIntroduce el descuento a aplicar: ");
            decimal descuento = decimal.Parse(Console.ReadLine());

            // Calculamos los valores que se nos piden: neto, IVA y el total en distintas monnedas.
            decimal neto = precioBase - (precioBase * descuento);
            decimal iva = neto * IVA;
            decimal totalEuros = neto + iva;
            decimal totalDolares = totalEuros * USD;
            decimal totalLibras = totalEuros * GBP;

            Console.WriteLine("\n\nPulsa Intro para mostrar operaciones distintas...");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("\n             ╔════════════════════════════════╗\n" +
                                "             ║ Tema 2 - Integrador: Manuel MR ║\n" +
                                "             ╚════════════════════════════════╝\n\n\n");

            Console.WriteLine($"╔══ Finanzas ════════════════════════════════════════════════════╗\n" +
                              $"║                                                                ║\n" +
                              $"║                                                                ║\n" +
                              $"║           Precio base:  {precioBase}          Descuento:  {descuento}           ║\n" +
                              $"║                                                                ║\n" +
                              $"║                                                                ║\n" +
                              $"║      Neto:  {neto:C2}                                            ║\n" +
                              $"║                                                                ║\n" +
                              $"║      IVA:  {iva:C2}                                              ║\n" +
                              $"║                                                                ║\n" +
                              $"║      Total (EUR):  {totalEuros:C2}                                     ║\n" +
                              $"║                                                                ║\n" +
                              $"║      Total (USD):  {totalDolares:N2}                                       ║\n" +
                              $"║                                                                ║\n" +
                              $"║      Total (GBP):  {totalLibras:N2}                                       ║\n" +
                              $"║                                                                ║\n" +
                              $"╚════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("\nPulsa Intro para salir...");
            Console.ReadKey();
        }
    }
}
