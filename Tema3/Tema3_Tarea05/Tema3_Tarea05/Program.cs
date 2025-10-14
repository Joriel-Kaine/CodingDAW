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
                string calificacion;

                Console.Write("Introduce la nota del alumno: ");
                double nota = double.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 10)
                {
                    if (nota < 3)
                    {
                        calificacion = "MUY DEFICIENTE";
                    }
                    else if (nota < 5)
                    {
                        calificacion = "INSUFICIENTE";
                    }
                    else if (nota < 6)
                    {
                        calificacion = "SUFICIENTE";
                    }
                    else if (nota < 7)
                    {
                        calificacion = "BIEN";
                    }
                    else if (nota < 9)
                    {
                        calificacion = "NOTABLE";
                    }
                    else
                    {
                        calificacion = "SOBRESALIENTE";
                        Console.WriteLine($"\n\nCon la nota de {nota} la calificación es SOBRESALIENTE.\n\n");
                    }

                    Console.WriteLine($"\n\nCon la nota de {nota} la calificación es {calificacion}.\n\n");
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
