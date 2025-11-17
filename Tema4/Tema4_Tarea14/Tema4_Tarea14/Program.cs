namespace Tema4_Tarea14
{
    internal class Program
    {
        static int LeerNumero (string mensaje)
        {
            int num;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = int.TryParse(Console.ReadLine(), out num);

                if (!esCorrecto)
                {
                    Console.WriteLine("Introduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        static bool EsBisiesto (int year)
        {
            bool esBisiesto = false;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                esBisiesto = true;
            }

            return esBisiesto;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 14: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            int year;

            year = LeerNumero("Introduce el año: "); 

            if (EsBisiesto(year))
            {
                Console.WriteLine($"\nEl año {year} es bisiesto.");
            }
            else
            {
                Console.WriteLine($"\nEl año {year} no es bisiesto.");
            }
            
            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
