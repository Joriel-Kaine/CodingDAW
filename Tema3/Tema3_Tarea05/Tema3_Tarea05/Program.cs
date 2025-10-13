using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Tarea05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nTema 3 - Tarea 5: Manuel MR\n\n");

            try
            {
                Console.Write("Introduce la nota del alumno: ");
                double nota = double.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 10)
                {
                    if (nota < 3)
                    {
                        Console.WriteLine($"\n\nCon la nota de {nota} la calificación es MUY DEFICIENTE.\n\n");
                    }
                    else if (nota < 5)
                    {
                        Console.WriteLine($"\n\nCon la nota de {nota} la calificación es INSUFICIENTE.\n\n");
                    }
                    else if (nota < 6)
                    {
                        Console.WriteLine($"\n\nCon la nota de {nota} la calificación es SUFICIENTE.\n\n");
                    }
                    else if (nota < 7)
                    {
                        Console.WriteLine($"\n\nCon la nota de {nota} la calificación es BIEN.\n\n");
                    }
                    else if (nota < 9)
                    {
                        Console.WriteLine($"\n\nCon la nota de {nota} la calificación es NOTABLE.\n\n");
                    }
                    else
                    {
                        Console.WriteLine($"\n\nCon la nota de {nota} la calificación es SOBRESALIENTE.\n\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n\nIntroduce una nota de alumno correcta.\n\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\n\nIntroduce un valor numérico válido.\n\n");
            }

            Console.WriteLine("Pulsa una tecla para salir...\n\n");
            Console.ReadKey();
        }
    }
}
