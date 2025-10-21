using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\nIntroduce un número entero: ");
            string texto = Console.ReadLine();

            bool exito = int.TryParse(texto, out int num);

            Console.WriteLine($"\n\nÉxito: {exito}");
            Console.WriteLine($"\nValor leído: {num}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
