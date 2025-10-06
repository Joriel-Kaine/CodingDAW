using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Tarea16
{
    internal class Program
    {
        const decimal retencion = 18;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Tarea 16: Manuel MR");

                Console.Write("\nEscribe el número de horas normales al mes: ");
                int horasNormal = int.Parse(Console.ReadLine());

                Console.Write("Escribe el número de horas extra al mes: ");
                int horasExtra = int.Parse(Console.ReadLine());

                Console.Write("Escribe el precio por hora: ");
                decimal precioHora = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"\nHoras normales: {horasNormal}, horas extra: {horasExtra} y un precio/hora de {precioHora} euros.");

                decimal nominaSinRetencion = (horasNormal * precioHora) + (horasExtra * (precioHora * 2));
                decimal nominaMensual = nominaSinRetencion - (nominaSinRetencion * (retencion / 100));

                Console.WriteLine($"\nNómina mensual sin retención: {nominaSinRetencion} euros.");
                Console.WriteLine($"Nómina mensual: {nominaMensual} euros.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Introduce un valor numérico válido.");
            }
        }
    }
}
