namespace Tema4_Tarea18
{
    internal class Program
    {
        static int LeerNumero (string mensaje)
        {
            int fecha;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = int.TryParse(Console.ReadLine(), out fecha);

                if (!esCorrecto)
                {
                    Console.WriteLine("\n\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return fecha;
        }

        static bool EsBisiesto (int year)
        {
            bool esCorrecto = false;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                esCorrecto = true;
            }

            return esCorrecto;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 18: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            int dia, mes, year;

            dia = LeerNumero("Introduce el día: ");
            mes = LeerNumero("Introduce el mes: ");
            year = LeerNumero("Introduce el año: ");

            DateTime fechaEspecifica = new DateTime(dia, mes, year);
            DateTime diaSiguiente = DateTime.Now.AddDays(1);

            Console.WriteLine($"\n═> La fecha introducida es ");

            Console.WriteLine("\nPulsa una tecla para sumar 1 día a la fecha introducida.");
            Console.ReadKey();
            Console.WriteLine($"\n═> La nueva fecha es {diaSiguiente}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
