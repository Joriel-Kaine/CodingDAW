using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Tarea15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Tarea 15: Manuel MR");

                Console.Write("\nEscribe el importe a ingresar del cliente: ");
                decimal cuenta = decimal.Parse(Console.ReadLine());

                Console.Write("\nEscribe el interés anual: ");
                decimal interes = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"\nEl cliente tiene {cuenta} euros en su cuenta y el interés anual es del {interes}%.");

                decimal capital = cuenta + (cuenta * (interes / 100));
                Console.WriteLine($"\nCapital final: {capital} euros.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nIntroduce un valor numérico válido.");
            }
        }
    }
}
